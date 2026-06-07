using TabFileEditor.App;

namespace TabFileEditor.App.Tests;

public sealed class QuestTextDocumentTests
{
    [Fact]
    public void BufferMapsTextRunCorrectly()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.TextRun("Hello", 18)
        ]);
        Assert.Equal(5, doc.CharCount);
        Assert.Equal('H', doc.GetCharAt(0));
        Assert.Equal('o', doc.GetCharAt(4));
        Assert.Equal(18, doc.GetFontAt(0));
    }

    [Fact]
    public void BufferMapsIndentAsMarker()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.Indent(),
            new QuestTextNode.TextRun("Text", 18)
        ]);
        Assert.Equal(QuestTextDocument.IndentMarker, doc.GetCharAt(0));
        Assert.Equal('T', doc.GetCharAt(1));
    }

    [Fact]
    public void BufferMapsPlayerNameAsMarkerPlusDisplay()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.PlayerName()
        ]);
        // Marker + "玩家名" display text
        Assert.Equal(QuestTextDocument.PlayerNameMarker, doc.GetCharAt(0));
        Assert.Equal('玩', doc.GetCharAt(1));
        Assert.Equal('家', doc.GetCharAt(2));
        Assert.Equal('名', doc.GetCharAt(3));
        Assert.Equal(4, doc.CharCount);
    }

    [Fact]
    public void BufferMapsFactionTitleAsMarkerPlusDisplay()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.FactionTitle()
        ]);
        Assert.Equal(QuestTextDocument.FactionTitleMarker, doc.GetCharAt(0));
        Assert.Equal(5, doc.CharCount); // marker + "门派称谓"
    }

    [Fact]
    public void BufferMapsNewlineAsNewline()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.Newline()
        ]);
        Assert.Equal('\n', doc.GetCharAt(0));
        Assert.Equal(1, doc.CharCount);
    }

    [Fact]
    public void BufferMapsLineHeightAsMarker()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.LineHeight(28)
        ]);
        Assert.Equal(QuestTextDocument.LineHeightMarker, doc.GetCharAt(0));
        Assert.Equal(1, doc.CharCount);
    }

    [Fact]
    public void BufferMapsIconAsMarker()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.Icon(42)
        ]);
        Assert.Equal(QuestTextDocument.IconMarker, doc.GetCharAt(0));
    }

    [Fact]
    public void BufferMapsMoneyAsMarker()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.Money(500, false)
        ]);
        Assert.Equal(QuestTextDocument.MoneyMarker, doc.GetCharAt(0));
    }

    [Fact]
    public void GetNodeSelectionRangeReturnsFullNodeRange()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.TextRun("A", 18),
            new QuestTextNode.PlayerName(),
            new QuestTextNode.TextRun("B", 18)
        ]);
        // PlayerName occupies buffer positions 1-4 (marker + "玩家名")
        var (start, end) = doc.GetNodeSelectionRange(1);
        Assert.Equal(1, start);
        Assert.Equal(5, end); // exclusive
    }

    [Fact]
    public void IsNodeEditableReturnsTrueForTextRun()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.TextRun("Hello", 18)
        ]);
        Assert.True(doc.IsNodeEditable(0));
    }

    [Fact]
    public void IsNodeEditableReturnsFalseForPlayerName()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.PlayerName()
        ]);
        Assert.False(doc.IsNodeEditable(0));
    }

    [Fact]
    public void InsertTextInMiddleOfTextRun()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.TextRun("Hello", 18)
        ]);
        doc.InsertText(2, "XX", 20);
        var serialized = QuestTextParser.Serialize(doc);
        Assert.Equal("HeXXllo", serialized);
    }

    [Fact]
    public void InsertTextAtEnd()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.TextRun("Hello", 18)
        ]);
        doc.InsertText(5, " World", 18);
        Assert.Equal("Hello World", QuestTextParser.Serialize(doc));
    }

    [Fact]
    public void InsertNodeBeforeExistingNode()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.TextRun("Hello", 18)
        ]);
        doc.InsertNode(0, new QuestTextNode.Indent());
        Assert.Equal("<G>Hello", QuestTextParser.Serialize(doc));
    }

    [Fact]
    public void DeleteRangeWithinTextRun()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.TextRun("Hello World", 18)
        ]);
        doc.DeleteRange(5, 6); // delete " World"
        Assert.Equal("Hello", QuestTextParser.Serialize(doc));
    }

    [Fact]
    public void DeleteRangeRemovingNonEditableNode()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.Indent(),
            new QuestTextNode.TextRun("Hello", 18)
        ]);
        // Delete the indent marker (position 0)
        doc.DeleteRange(0, 1);
        Assert.Equal("Hello", QuestTextParser.Serialize(doc));
    }

    [Fact]
    public void ApplyFontWrapsAsFontBlock()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.TextRun("Hello World", 18)
        ]);
        doc.ApplyFont(6, 5, 171); // "World" -> F171
        var serialized = QuestTextParser.Serialize(doc);
        Assert.Equal("Hello <F171 World>", serialized);
    }

    [Fact]
    public void NormalizeMergesAdjacentTextRunWithSameFont()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.TextRun("A", 18),
            new QuestTextNode.TextRun("B", 18)
        ]);
        Assert.Single(doc.Nodes);
        var tr = Assert.IsType<QuestTextNode.TextRun>(doc.Nodes[0]);
        Assert.Equal("AB", tr.Text);
    }

    [Fact]
    public void NormalizeDoesNotMergeDifferentFonts()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.TextRun("A", 18),
            new QuestTextNode.TextRun("B", 20)
        ]);
        Assert.Equal(2, doc.Nodes.Count);
    }

    [Fact]
    public void ParseMutateSerializeRoundtrip()
    {
        var input = "<G><F174 动作描写>\\n<H28><G>对话内容";
        var doc = QuestTextParser.Parse(input);

        // Buffer: [0:Indent, 1:动, 2:作, 3:描, 4:写, 5:\n, 6:LineHeight, 7:Indent, 8:对, 9:话, 10:内, 11:容]
        // Insert "继续" at position 5 (at start of Newline node, should append to previous FontBlock)
        doc.InsertText(5, "继续", 174);

        var serialized = QuestTextParser.Serialize(doc);
        Assert.Equal("<G><F174 动作描写继续>\\n<H28><G>对话内容", serialized);
    }

    [Fact]
    public void GetNodeAtReturnsCorrectNode()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.Indent(),
            new QuestTextNode.TextRun("Hello", 18),
            new QuestTextNode.PlayerName()
        ]);
        Assert.IsType<QuestTextNode.Indent>(doc.GetNodeAt(0));
        Assert.IsType<QuestTextNode.TextRun>(doc.GetNodeAt(1));
        Assert.IsType<QuestTextNode.PlayerName>(doc.GetNodeAt(6));
    }
}
