using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace TabFileEditor.App;

public sealed record RichTextSegment(string Text, int FontSchemeId);

public sealed class RichTextDocument
{
    public List<RichTextSegment> Segments { get; } = [];

    public RichTextDocument() { }

    public RichTextDocument(List<RichTextSegment> segments)
    {
        Segments = segments;
    }
}

public static class RichTextMarkup
{
    private static readonly Regex TextElementRegex = new(
        @"<text>text=""(.*?)""\s+font=(\d+)</text>",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);

    public static RichTextDocument Parse(string markup)
    {
        var segments = new List<RichTextSegment>();
        foreach (Match match in TextElementRegex.Matches(markup))
        {
            var text = match.Groups[1].Value;
            text = text.Replace("\r\n", "\\\\n").Replace("\n", "\\\\n").Replace("\r", "\\\\n");
            var fontId = int.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);
            segments.Add(new RichTextSegment(text, fontId));
        }
        return new RichTextDocument(segments);
    }

    public static string Serialize(RichTextDocument doc)
    {
        var sb = new StringBuilder();
        foreach (var segment in doc.Segments)
        {
            var text = segment.Text.Replace("\r\n", "\\\\n").Replace("\n", "\\\\n").Replace("\r", "\\\\n");
            sb.Append($"<text>text=\"{text}\" font={segment.FontSchemeId}</text>");
        }
        return sb.ToString();
    }

    public static bool LooksLikeRichText(string? value)
    {
        return !string.IsNullOrEmpty(value) && value.Contains("<text>");
    }
}
