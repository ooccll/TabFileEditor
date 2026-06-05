using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace TabFileEditor.App;

public sealed class RichTextPreviewPanel : Panel
{
    private readonly ElemSchemeLoader _loader;
    private List<RichTextSegment> _segments = [];
    private readonly Dictionary<(string file, int size), Font> _fontCache = [];
    private readonly Dictionary<string, PrivateFontCollection> _pfcCache = [];
    private const int PaddingPx = 12;
    private const int LineSpacing = 4;

    public RichTextPreviewPanel(ElemSchemeLoader loader)
    {
        _loader = loader;
        DoubleBuffered = true;
        BackColor = Color.FromArgb(0x1A, 0x1A, 0x2E);
    }

    public void SetSegments(List<RichTextSegment> segments)
    {
        _segments = segments;
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.TextRenderingHint = TextRenderingHint.AntiAlias;

        var clientWidth = ClientSize.Width - PaddingPx * 2;
        if (clientWidth <= 0) return;

        var x = (float)PaddingPx;
        var y = (float)PaddingPx;
        var maxLineHeight = 0f;

        foreach (var segment in _segments)
        {
            var spec = _loader.ResolveFont(segment.FontSchemeId);
            var font = GetFont(spec);
            var text = segment.Text.Replace("\\n", "\n");
            var lines = text.Split('\n');

            for (var i = 0; i < lines.Length; i++)
            {
                if (i > 0)
                {
                    x = PaddingPx;
                    y += maxLineHeight + LineSpacing;
                    maxLineHeight = 0;
                }

                var lineText = lines[i];
                if (string.IsNullOrEmpty(lineText))
                {
                    var lineHeight = font.Height;
                    if (lineHeight > maxLineHeight) maxLineHeight = lineHeight;
                    continue;
                }

                // Word wrap
                var wrappedLines = WrapText(g, lineText, font, clientWidth);
                foreach (var wrappedLine in wrappedLines)
                {
                    var lineHeight = font.Height;
                    if (lineHeight > maxLineHeight) maxLineHeight = lineHeight;

                    // Shadow
                    if (spec.ShadowSize > 0)
                    {
                        using var shadowBrush = new SolidBrush(Color.FromArgb(180, spec.ShadowColor));
                        g.DrawString(wrappedLine, font, shadowBrush,
                            x + spec.ShadowSize, y + spec.ShadowSize);
                    }

                    // Border/stroke (offset in 4 directions)
                    if (spec.BorderSize > 0)
                    {
                        using var borderBrush = new SolidBrush(spec.BorderColor);
                        var offsets = spec.BorderSize switch
                        {
                            1 => new (float dx, float dy)[] { (0, -1), (0, 1), (-1, 0), (1, 0) },
                            _ => new (float dx, float dy)[]
                            {
                                (0, -1), (0, 1), (-1, 0), (1, 0),
                                (-1, -1), (-1, 1), (1, -1), (1, 1),
                            }
                        };
                        foreach (var (dx, dy) in offsets)
                        {
                            g.DrawString(wrappedLine, font, borderBrush, x + dx, y + dy);
                        }
                    }

                    // Fill
                    using var fillBrush = new SolidBrush(spec.FillColor);
                    g.DrawString(wrappedLine, font, fillBrush, x, y);

                    var textSize = g.MeasureString(wrappedLine, font);
                    x += textSize.Width;

                    // If this wrapped line pushed x past the edge, move to next line
                    if (x >= PaddingPx + clientWidth)
                    {
                        x = PaddingPx;
                        y += maxLineHeight + LineSpacing;
                        maxLineHeight = 0;
                    }
                }
            }
        }
    }

    private Font GetFont(ResolvedFontSpec spec)
    {
        var key = (spec.FontFile, spec.Size);
        if (_fontCache.TryGetValue(key, out var cached))
            return cached;

        Font font;
        if (!string.IsNullOrEmpty(spec.FontFile) && File.Exists(spec.FontFile))
        {
            try
            {
                if (!_pfcCache.TryGetValue(spec.FontFile, out var pfc))
                {
                    pfc = new PrivateFontCollection();
                    pfc.AddFontFile(spec.FontFile);
                    _pfcCache[spec.FontFile] = pfc;
                }

                if (pfc.Families.Length > 0)
                {
                    font = new Font(pfc.Families[0], spec.Size, GraphicsUnit.Pixel);
                }
                else
                {
                    font = new Font("Microsoft YaHei UI", spec.Size * 0.75f, GraphicsUnit.Pixel);
                }
            }
            catch
            {
                font = new Font("Microsoft YaHei UI", spec.Size * 0.75f, GraphicsUnit.Pixel);
            }
        }
        else
        {
            font = new Font("Microsoft YaHei UI", spec.Size * 0.75f, GraphicsUnit.Pixel);
        }

        _fontCache[key] = font;
        return font;
    }

    private static List<string> WrapText(Graphics g, string text, Font font, float maxWidth)
    {
        var result = new List<string>();
        if (string.IsNullOrEmpty(text))
        {
            result.Add(text);
            return result;
        }

        var currentLine = "";
        foreach (var ch in text)
        {
            var testLine = currentLine + ch;
            var testWidth = g.MeasureString(testLine, font).Width;
            if (testWidth > maxWidth && currentLine.Length > 0)
            {
                result.Add(currentLine);
                currentLine = ch.ToString();
            }
            else
            {
                currentLine = testLine;
            }
        }

        if (currentLine.Length > 0)
            result.Add(currentLine);

        return result;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            foreach (var font in _fontCache.Values)
                font.Dispose();
            _fontCache.Clear();

            foreach (var pfc in _pfcCache.Values)
                pfc.Dispose();
            _pfcCache.Clear();
        }
        base.Dispose(disposing);
    }
}
