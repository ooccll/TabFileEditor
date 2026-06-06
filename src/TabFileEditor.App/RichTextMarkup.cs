using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace TabFileEditor.App;

public sealed record RichTextSegment(string Text, int FontSchemeId);

public sealed class RichTextDocument
{
    public const int DefaultFontSchemeId = 18;

    public List<RichTextSegment> Segments { get; } = [];

    public RichTextDocument()
    {
        Segments.Add(new RichTextSegment("", DefaultFontSchemeId));
    }

    public RichTextDocument(List<RichTextSegment> segments)
    {
        Segments = Normalize(segments);
    }

    public string GetPlainText()
        => string.Concat(Segments.Select(segment => segment.Text));

    public int TextLength => Segments.Sum(segment => segment.Text.Length);

    public int GetFontAt(int offset)
    {
        offset = Math.Clamp(offset, 0, TextLength);
        var position = 0;
        foreach (var segment in Segments)
        {
            if (segment.Text.Length == 0)
                return segment.FontSchemeId;
            if (offset < position + segment.Text.Length)
                return segment.FontSchemeId;
            position += segment.Text.Length;
        }

        return Segments.Count > 0 ? Segments[^1].FontSchemeId : DefaultFontSchemeId;
    }

    public void InsertText(int offset, string text, int fontSchemeId)
    {
        if (string.IsNullOrEmpty(text)) return;
        ReplaceRange(offset, 0, text, fontSchemeId);
    }

    public void DeleteRange(int start, int length)
    {
        ReplaceRange(start, length, "", DefaultFontSchemeId);
    }

    public void ApplyFont(int start, int length, int fontSchemeId)
    {
        var (safeStart, safeEnd) = ClampRange(start, length);
        if (safeEnd <= safeStart) return;

        var updated = new List<RichTextSegment>();
        AddRange(updated, 0, safeStart);
        var selectedText = GetPlainText()[safeStart..safeEnd];
        updated.Add(new RichTextSegment(selectedText, fontSchemeId));
        AddRange(updated, safeEnd, TextLength);
        ReplaceSegments(updated);
    }

    private void ReplaceRange(int start, int length, string replacement, int fontSchemeId)
    {
        var (safeStart, safeEnd) = ClampRange(start, length);
        var updated = new List<RichTextSegment>();
        AddRange(updated, 0, safeStart);
        if (!string.IsNullOrEmpty(replacement))
            updated.Add(new RichTextSegment(replacement, fontSchemeId));
        AddRange(updated, safeEnd, TextLength);
        ReplaceSegments(updated);
    }

    private (int Start, int End) ClampRange(int start, int length)
    {
        var safeStart = Math.Clamp(start, 0, TextLength);
        var safeLength = Math.Max(0, length);
        var safeEnd = Math.Clamp(safeStart + safeLength, safeStart, TextLength);
        return (safeStart, safeEnd);
    }

    private void AddRange(List<RichTextSegment> target, int start, int end)
    {
        if (end <= start) return;

        var position = 0;
        foreach (var segment in Segments)
        {
            var segmentStart = position;
            var segmentEnd = position + segment.Text.Length;
            position = segmentEnd;

            var overlapStart = Math.Max(start, segmentStart);
            var overlapEnd = Math.Min(end, segmentEnd);
            if (overlapEnd <= overlapStart) continue;

            var localStart = overlapStart - segmentStart;
            var localLength = overlapEnd - overlapStart;
            target.Add(new RichTextSegment(segment.Text.Substring(localStart, localLength), segment.FontSchemeId));
        }
    }

    private void ReplaceSegments(List<RichTextSegment> segments)
    {
        Segments.Clear();
        Segments.AddRange(Normalize(segments));
    }

    private static List<RichTextSegment> Normalize(IEnumerable<RichTextSegment> segments)
    {
        var normalized = new List<RichTextSegment>();
        foreach (var segment in segments)
        {
            if (string.IsNullOrEmpty(segment.Text))
                continue;

            if (normalized.Count > 0 && normalized[^1].FontSchemeId == segment.FontSchemeId)
            {
                normalized[^1] = normalized[^1] with { Text = normalized[^1].Text + segment.Text };
            }
            else
            {
                normalized.Add(segment);
            }
        }

        if (normalized.Count == 0)
            normalized.Add(new RichTextSegment("", DefaultFontSchemeId));

        return normalized;
    }
}

public static class RichTextMarkup
{
    private static readonly Regex TextElementRegex = new(
        @"<text>text=""(.*?)""\s+font=(\d+)</text>",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);

    public static RichTextDocument Parse(string markup)
    {
        if (!TryParse(markup, out var document, out _))
        {
            return new RichTextDocument([new RichTextSegment(markup ?? "", RichTextDocument.DefaultFontSchemeId)]);
        }

        return document;
    }

    public static bool TryParse(string? markup, out RichTextDocument document, out string? error)
    {
        markup ??= "";

        if (!markup.Contains("<text>", StringComparison.OrdinalIgnoreCase))
        {
            document = new RichTextDocument([new RichTextSegment(markup, RichTextDocument.DefaultFontSchemeId)]);
            error = null;
            return true;
        }

        var segments = new List<RichTextSegment>();
        var position = 0;
        foreach (Match match in TextElementRegex.Matches(markup))
        {
            if (match.Index != position)
            {
                document = new RichTextDocument();
                error = $"无法解析第 {position + 1} 个字符附近的富文本标签。";
                return false;
            }

            var text = match.Groups[1].Value;
            text = text.Replace("\\\\\\n", "\n");
            var fontId = int.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);
            segments.Add(new RichTextSegment(text, fontId));
            position = match.Index + match.Length;
        }

        if (position != markup.Length || segments.Count == 0)
        {
            document = new RichTextDocument();
            error = $"无法解析第 {position + 1} 个字符附近的富文本标签。";
            return false;
        }

        document = new RichTextDocument(segments);
        error = null;
        return true;
    }

    public static string Serialize(RichTextDocument doc)
    {
        var sb = new StringBuilder();
        foreach (var segment in doc.Segments)
        {
            var text = segment.Text.Replace("\r\n", "\\\\\\n").Replace("\n", "\\\\\\n").Replace("\r", "\\\\\\n");
            sb.Append($"<text>text=\"{text}\" font={segment.FontSchemeId}</text>");
        }
        return sb.ToString();
    }

    public static bool LooksLikeRichText(string? value)
    {
        return !string.IsNullOrEmpty(value) && value.Contains("<text>");
    }
}
