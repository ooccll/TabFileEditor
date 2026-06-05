using System.Text;

namespace TabFileEditor.App;

public sealed class FontSchemeEntry
{
    public int Id { get; init; }
    public string Name { get; init; } = "";
    public int FontId { get; init; }
    public string Color { get; init; } = "";
    public int Size { get; init; }
    public string BorderColor { get; init; } = "";
    public int BorderSize { get; init; }
    public string ProjectionColor { get; init; } = "";
    public int ProjectionSize { get; init; }
}

public sealed class FontDefEntry
{
    public int Id { get; init; }
    public string File { get; init; } = "";
    public int Size { get; init; }
    public int Dpi { get; init; }
    public bool Vertical { get; init; }
}

public sealed class ResolvedFontSpec
{
    public string FontFile { get; init; } = "";
    public int Size { get; init; }
    public Color FillColor { get; init; } = Color.White;
    public Color BorderColor { get; init; } = Color.Black;
    public int BorderSize { get; init; }
    public Color ShadowColor { get; init; } = Color.Black;
    public int ShadowSize { get; init; }
}

public sealed class ElemSchemeLoader
{
    public string ElemDirectory { get; }
    public string ClientUiRoot { get; }

    private Dictionary<string, (int R, int G, int B)>? _colorTable;
    private Dictionary<int, FontSchemeEntry>? _fontSchemes;
    private Dictionary<int, FontDefEntry>? _fontDefs;
    private bool _loaded;

    public ElemSchemeLoader(string elemDirectory)
    {
        ElemDirectory = elemDirectory;
        var dir = new DirectoryInfo(elemDirectory);
        ClientUiRoot = dir.Parent?.Parent?.FullName ?? elemDirectory;
    }

    public void EnsureLoaded()
    {
        if (_loaded) return;

        var colorTable = LoadColorTable();
        var fontSchemes = LoadFontSchemes();
        var fontDefs = LoadFontDefs();

        _colorTable = colorTable;
        _fontSchemes = fontSchemes;
        _fontDefs = fontDefs;
        _loaded = true;
    }

    public Dictionary<int, FontSchemeEntry> FontSchemes
    {
        get { EnsureLoaded(); return _fontSchemes!; }
    }

    public Dictionary<int, FontDefEntry> FontDefs
    {
        get { EnsureLoaded(); return _fontDefs!; }
    }

    public ResolvedFontSpec ResolveFont(int fontSchemeId)
    {
        EnsureLoaded();

        var scheme = _fontSchemes!.GetValueOrDefault(fontSchemeId)
            ?? _fontSchemes!.GetValueOrDefault(0)
            ?? new FontSchemeEntry();

        var fontId = scheme.FontId;
        var fontDef = _fontDefs!.GetValueOrDefault(fontId)
            ?? _fontDefs!.GetValueOrDefault(0)
            ?? new FontDefEntry();

        var size = scheme.Size > 0 ? scheme.Size : (fontDef.Size > 0 ? fontDef.Size : 16);
        size = Math.Max(size, 10);

        var fontFile = NormalizeFontPath(fontDef.File);
        if (!string.IsNullOrEmpty(fontFile) && !Path.IsPathRooted(fontFile))
        {
            fontFile = Path.Combine(ClientUiRoot, fontFile);
        }

        return new ResolvedFontSpec
        {
            FontFile = fontFile,
            Size = size,
            FillColor = ParseColor(scheme.Color, Color.White),
            BorderColor = ParseColor(scheme.BorderColor, Color.Black),
            BorderSize = scheme.BorderSize,
            ShadowColor = ParseColor(scheme.ProjectionColor, Color.FromArgb(0x8F, 0x8F, 0x8F)),
            ShadowSize = scheme.ProjectionSize,
        };
    }

    public Color ParseColor(string? colorNameOrHex, Color defaultColor)
    {
        EnsureLoaded();

        if (string.IsNullOrWhiteSpace(colorNameOrHex))
            return defaultColor;

        var text = colorNameOrHex.Trim();

        if (_colorTable!.TryGetValue(text.ToLowerInvariant(), out var named))
        {
            return Color.FromArgb(named.R, named.G, named.B);
        }

        if (text.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
        {
            try
            {
                var raw = Convert.ToInt32(text[2..], 16);
                if (text.Length >= 10)
                {
                    var a = (raw >> 24) & 0xFF;
                    var r = (raw >> 16) & 0xFF;
                    var g = (raw >> 8) & 0xFF;
                    var b = raw & 0xFF;
                    return Color.FromArgb(a, r, g, b);
                }
                if (text.Length >= 8)
                {
                    var r = (raw >> 16) & 0xFF;
                    var g = (raw >> 8) & 0xFF;
                    var b = raw & 0xFF;
                    return Color.FromArgb(255, r, g, b);
                }
            }
            catch
            {
                // fall through
            }
        }

        return defaultColor;
    }

    private Dictionary<string, (int R, int G, int B)> LoadColorTable()
    {
        var result = new Dictionary<string, (int, int, int)>(StringComparer.OrdinalIgnoreCase);
        var path = Path.Combine(ElemDirectory, "Color.txt");
        if (!File.Exists(path)) return result;

        using var reader = new StreamReader(path, Encoding.GetEncoding("GB18030"));
        var firstLine = true;
        while (reader.ReadLine() is { } line)
        {
            if (firstLine) { firstLine = false; continue; }
            var parts = line.Split('\t');
            if (parts.Length >= 4
                && int.TryParse(parts[1].Trim(), out var r)
                && int.TryParse(parts[2].Trim(), out var g)
                && int.TryParse(parts[3].Trim(), out var b))
            {
                result[parts[0].Trim().ToLowerInvariant()] = (r, g, b);
            }
        }
        return result;
    }

    private Dictionary<int, FontSchemeEntry> LoadFontSchemes()
    {
        var result = new Dictionary<int, FontSchemeEntry>();
        var path = Path.Combine(ElemDirectory, "Font.ini");
        if (!File.Exists(path)) return result;

        var ini = ReadIniFile(path);
        foreach (var (section, values) in ini)
        {
            if (!int.TryParse(section, out var id)) continue;
            result[id] = new FontSchemeEntry
            {
                Id = id,
                Name = values.GetValueOrDefault("Name") ?? "",
                FontId = ParseInt(values, "FontID", 0),
                Color = values.GetValueOrDefault("Color") ?? "",
                Size = ParseInt(values, "Size", 0),
                BorderColor = values.GetValueOrDefault("BorderColor") ?? "",
                BorderSize = ParseInt(values, "BorderSize", 0),
                ProjectionColor = values.GetValueOrDefault("ProjectionColor") ?? "",
                ProjectionSize = ParseInt(values, "ProjectionSize", 0),
            };
        }
        return result;
    }

    private Dictionary<int, FontDefEntry> LoadFontDefs()
    {
        var result = new Dictionary<int, FontDefEntry>();

        var basePath = Path.Combine(ElemDirectory, "fontlist.ini");
        if (File.Exists(basePath))
        {
            var baseIni = ReadIniFile(basePath);
            foreach (var (section, values) in baseIni)
            {
                if (!int.TryParse(section, out var id)) continue;
                result[id] = new FontDefEntry
                {
                    Id = id,
                    File = values.GetValueOrDefault("File") ?? "",
                    Size = ParseInt(values, "Size", 0),
                    Dpi = ParseInt(values, "Dpi", 96),
                    Vertical = ParseInt(values, "Vertical", 0) == 1,
                };
            }
        }

        var zhPath = Path.Combine(ElemDirectory, "fontlist.ini.zh_CN");
        if (File.Exists(zhPath))
        {
            var zhIni = ReadIniFile(zhPath);
            foreach (var (section, values) in zhIni)
            {
                if (!int.TryParse(section, out var id)) continue;

                if (result.TryGetValue(id, out var existing))
                {
                    var file = values.GetValueOrDefault("File");
                    var size = values.ContainsKey("Size") ? ParseInt(values, "Size", 0) : (int?)null;
                    var dpi = values.ContainsKey("Dpi") ? ParseInt(values, "Dpi", 96) : (int?)null;
                    var vertical = values.ContainsKey("Vertical") ? ParseInt(values, "Vertical", 0) == 1 : (bool?)null;

                    result[id] = new FontDefEntry
                    {
                        Id = id,
                        File = !string.IsNullOrEmpty(file) ? file : existing.File,
                        Size = size ?? existing.Size,
                        Dpi = dpi ?? existing.Dpi,
                        Vertical = vertical ?? existing.Vertical,
                    };
                }
                else
                {
                    result[id] = new FontDefEntry
                    {
                        Id = id,
                        File = values.GetValueOrDefault("File") ?? "",
                        Size = ParseInt(values, "Size", 0),
                        Dpi = ParseInt(values, "Dpi", 96),
                        Vertical = ParseInt(values, "Vertical", 0) == 1,
                    };
                }
            }
        }

        return result;
    }

    private static Dictionary<string, Dictionary<string, string>> ReadIniFile(string path)
    {
        var result = new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase);
        string? currentSection = null;

        using var reader = new StreamReader(path, Encoding.GetEncoding("GB18030"));
        while (reader.ReadLine() is { } line)
        {
            line = line.Trim();
            if (string.IsNullOrEmpty(line) || line.StartsWith(';')) continue;

            if (line.StartsWith('[') && line.EndsWith(']'))
            {
                currentSection = line[1..^1].Trim();
                if (!result.ContainsKey(currentSection))
                    result[currentSection] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            }
            else if (currentSection is not null)
            {
                var eq = line.IndexOf('=');
                if (eq > 0)
                {
                    var key = line[..eq].Trim();
                    var value = line[(eq + 1)..].Trim();
                    result[currentSection][key] = value;
                }
            }
        }
        return result;
    }

    private static int ParseInt(Dictionary<string, string> values, string key, int defaultValue)
    {
        if (values.TryGetValue(key, out var s) && int.TryParse(s, out var v))
            return v;
        return defaultValue;
    }

    private static string NormalizeFontPath(string path)
    {
        if (string.IsNullOrEmpty(path)) return path;
        var normalized = path.Replace('/', '\\');
        if (normalized.StartsWith("\\UI\\", StringComparison.OrdinalIgnoreCase))
            normalized = "UI" + normalized[3..];
        else if (normalized.StartsWith("\\", StringComparison.Ordinal))
            normalized = normalized[1..];
        return normalized;
    }

    public static string? ResolveElemDirectory(string documentPath)
    {
        var normalizedPath = documentPath.Replace('/', '\\');
        const string marker = "client\\ui";
        var idx = normalizedPath.IndexOf(marker, StringComparison.OrdinalIgnoreCase);
        if (idx < 0) return null;

        var clientUiRoot = normalizedPath[..(idx + marker.Length)];
        var elemDir = Path.Combine(clientUiRoot, "Scheme", "Elem");
        return Directory.Exists(elemDir) ? elemDir : null;
    }
}
