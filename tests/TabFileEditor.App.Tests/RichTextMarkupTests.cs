using TabFileEditor.App;

namespace TabFileEditor.App.Tests;

public sealed class RichTextMarkupTests
{
    [Fact]
    public void ParsePlainTextCreatesDefaultFontSegment()
    {
        var document = RichTextMarkup.Parse("Hello");

        var segment = Assert.Single(document.Segments);
        Assert.Equal("Hello", segment.Text);
        Assert.Equal(18, segment.FontSchemeId);
    }

    [Fact]
    public void ParseEmptyTextCreatesEditableDefaultSegment()
    {
        var document = RichTextMarkup.Parse("");

        var segment = Assert.Single(document.Segments);
        Assert.Equal("", segment.Text);
        Assert.Equal(18, segment.FontSchemeId);
    }

    [Fact]
    public void TryParseRejectsInvalidMarkup()
    {
        Assert.False(RichTextMarkup.TryParse("<text>text=\"Hello\" font=18", out _, out var error));
        Assert.False(string.IsNullOrWhiteSpace(error));
    }

    [Fact]
    public void ApplyingFontToSelectedRangeSplitsSegment()
    {
        var document = RichTextMarkup.Parse("<text>text=\"HelloWorld\" font=18</text>");

        document.ApplyFont(5, 5, 20);

        Assert.Equal(
            [
                new RichTextSegment("Hello", 18),
                new RichTextSegment("World", 20),
            ],
            document.Segments);
    }

    [Fact]
    public void ApplyingFontAcrossSegmentsReplacesOnlySelectedRangeAndMergesAdjacentFonts()
    {
        var document = RichTextMarkup.Parse(
            "<text>text=\"Hello\" font=18</text><text>text=\"World\" font=20</text><text>text=\"Again\" font=18</text>");

        document.ApplyFont(5, 2, 18);

        Assert.Equal(
            [
                new RichTextSegment("HelloWo", 18),
                new RichTextSegment("rld", 20),
                new RichTextSegment("Again", 18),
            ],
            document.Segments);
    }

    [Fact]
    public void InsertAndDeleteTextPreserveCurrentFont()
    {
        var document = RichTextMarkup.Parse("<text>text=\"Hello\" font=18</text><text>text=\"World\" font=20</text>");

        document.InsertText(5, "\nNew", 20);
        document.DeleteRange(0, 2);

        Assert.Equal(
            [
                new RichTextSegment("llo", 18),
                new RichTextSegment("\nNewWorld", 20),
            ],
            document.Segments);
        Assert.Equal("<text>text=\"llo\" font=18</text><text>text=\"\\\\\\nNewWorld\" font=20</text>",
            RichTextMarkup.Serialize(document));
    }
}
