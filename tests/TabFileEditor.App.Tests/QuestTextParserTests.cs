using TabFileEditor.App;

namespace TabFileEditor.App.Tests;

public sealed class QuestTextParserTests
{
    [Fact]
    public void ParseEmptyReturnsDefaultTextRun()
    {
        var doc = QuestTextParser.Parse("");
        var node = Assert.Single(doc.Nodes);
        var tr = Assert.IsType<QuestTextNode.TextRun>(node);
        Assert.Equal("", tr.Text);
        Assert.Equal(18, tr.FontSchemeId);
    }

    [Fact]
    public void ParsePlainTextReturnsTextRun()
    {
        var doc = QuestTextParser.Parse("Hello World");
        var node = Assert.Single(doc.Nodes);
        var tr = Assert.IsType<QuestTextNode.TextRun>(node);
        Assert.Equal("Hello World", tr.Text);
    }

    [Fact]
    public void ParseIndent()
    {
        var doc = QuestTextParser.Parse("<G>Text");
        Assert.Equal(2, doc.Nodes.Count);
        Assert.IsType<QuestTextNode.Indent>(doc.Nodes[0]);
        var tr = Assert.IsType<QuestTextNode.TextRun>(doc.Nodes[1]);
        Assert.Equal("Text", tr.Text);
    }

    [Fact]
    public void ParsePlayerName()
    {
        var doc = QuestTextParser.Parse("<G><N>，此事你做得甚佳");
        Assert.Equal(3, doc.Nodes.Count);
        Assert.IsType<QuestTextNode.Indent>(doc.Nodes[0]);
        Assert.IsType<QuestTextNode.PlayerName>(doc.Nodes[1]);
        var tr = Assert.IsType<QuestTextNode.TextRun>(doc.Nodes[2]);
        Assert.Equal("，此事你做得甚佳", tr.Text);
    }

    [Fact]
    public void ParseFactionTitle()
    {
        var doc = QuestTextParser.Parse("<G>这位万花的<C>，行行好");
        Assert.Equal(4, doc.Nodes.Count);
        Assert.IsType<QuestTextNode.Indent>(doc.Nodes[0]);
        var t1 = Assert.IsType<QuestTextNode.TextRun>(doc.Nodes[1]);
        Assert.Equal("这位万花的", t1.Text);
        Assert.IsType<QuestTextNode.FactionTitle>(doc.Nodes[2]);
        var t2 = Assert.IsType<QuestTextNode.TextRun>(doc.Nodes[3]);
        Assert.Equal("，行行好", t2.Text);
    }

    [Fact]
    public void ParseFontBlock()
    {
        var doc = QuestTextParser.Parse("<G><F174 陶寒亭听你说完经过，极为满意。>");
        Assert.Equal(2, doc.Nodes.Count);
        Assert.IsType<QuestTextNode.Indent>(doc.Nodes[0]);
        var fb = Assert.IsType<QuestTextNode.FontBlock>(doc.Nodes[1]);
        Assert.Equal(174, fb.FontSchemeId);
        Assert.Equal("陶寒亭听你说完经过，极为满意。", fb.Text);
    }

    [Fact]
    public void ParseMultipleFontBlocksMixed()
    {
        var doc = QuestTextParser.Parse("<G>哦，年轻人，你是来送<F171 茶叶>的？一定是<F173 秀秀>让你带给我的吧");
        Assert.Equal(6, doc.Nodes.Count);
        Assert.IsType<QuestTextNode.Indent>(doc.Nodes[0]);
        var t1 = Assert.IsType<QuestTextNode.TextRun>(doc.Nodes[1]);
        Assert.Equal("哦，年轻人，你是来送", t1.Text);
        var fb1 = Assert.IsType<QuestTextNode.FontBlock>(doc.Nodes[2]);
        Assert.Equal(171, fb1.FontSchemeId);
        Assert.Equal("茶叶", fb1.Text);
        var t2 = Assert.IsType<QuestTextNode.TextRun>(doc.Nodes[3]);
        Assert.Equal("的？一定是", t2.Text);
        var fb2 = Assert.IsType<QuestTextNode.FontBlock>(doc.Nodes[4]);
        Assert.Equal(173, fb2.FontSchemeId);
        Assert.Equal("秀秀", fb2.Text);
        var t3 = Assert.IsType<QuestTextNode.TextRun>(doc.Nodes[5]);
        Assert.Equal("让你带给我的吧", t3.Text);
    }

    [Fact]
    public void ParseNewline()
    {
        var doc = QuestTextParser.Parse("<G>First\\n<H28><G>Second");
        Assert.Equal(6, doc.Nodes.Count);
        Assert.IsType<QuestTextNode.Indent>(doc.Nodes[0]);
        var t1 = Assert.IsType<QuestTextNode.TextRun>(doc.Nodes[1]);
        Assert.Equal("First", t1.Text);
        Assert.IsType<QuestTextNode.Newline>(doc.Nodes[2]);
        Assert.IsType<QuestTextNode.LineHeight>(doc.Nodes[3]);
        var lh = (QuestTextNode.LineHeight)doc.Nodes[3];
        Assert.Equal(28, lh.Height);
        Assert.IsType<QuestTextNode.Indent>(doc.Nodes[4]);
        var t2 = Assert.IsType<QuestTextNode.TextRun>(doc.Nodes[5]);
        Assert.Equal("Second", t2.Text);
    }

    [Fact]
    public void ParseLineHeight()
    {
        var doc = QuestTextParser.Parse("<H28>");
        var lh = Assert.IsType<QuestTextNode.LineHeight>(Assert.Single(doc.Nodes));
        Assert.Equal(28, lh.Height);
    }

    [Fact]
    public void ParseIcon()
    {
        var doc = QuestTextParser.Parse("<T42>");
        var icon = Assert.IsType<QuestTextNode.Icon>(Assert.Single(doc.Nodes));
        Assert.Equal(42, icon.IconId);
    }

    [Fact]
    public void ParseMoney()
    {
        var doc = QuestTextParser.Parse("<J500>");
        var money = Assert.IsType<QuestTextNode.Money>(Assert.Single(doc.Nodes));
        Assert.Equal(500, money.Amount);
        Assert.False(money.Compare);
    }

    [Fact]
    public void ParseMoneyWithCompare()
    {
        var doc = QuestTextParser.Parse("<J500 compare>");
        var money = Assert.IsType<QuestTextNode.Money>(Assert.Single(doc.Nodes));
        Assert.Equal(500, money.Amount);
        Assert.True(money.Compare);
    }

    [Fact]
    public void ParseReservedTags()
    {
        var doc = QuestTextParser.Parse("<A><AT><SD><WT>");
        Assert.Equal(4, doc.Nodes.Count);
        var a = Assert.IsType<QuestTextNode.ReservedTag>(doc.Nodes[0]);
        Assert.Equal("A", a.Name);
        var at = Assert.IsType<QuestTextNode.ReservedTag>(doc.Nodes[1]);
        Assert.Equal("AT", at.Name);
        var sd = Assert.IsType<QuestTextNode.ReservedTag>(doc.Nodes[2]);
        Assert.Equal("SD", sd.Name);
        var wt = Assert.IsType<QuestTextNode.ReservedTag>(doc.Nodes[3]);
        Assert.Equal("WT", wt.Name);
    }

    [Fact]
    public void ParseTypicalMultiParagraphDialogue()
    {
        var input = "<G><F174 陶寒亭听你说完酒池峡中执行任务的经过，极为满意。>\\n<H28><G>甚好！这雪魔袋，是奖赏你的。";
        var doc = QuestTextParser.Parse(input);

        Assert.Equal(6, doc.Nodes.Count);
        Assert.IsType<QuestTextNode.Indent>(doc.Nodes[0]);
        Assert.IsType<QuestTextNode.FontBlock>(doc.Nodes[1]);
        Assert.IsType<QuestTextNode.Newline>(doc.Nodes[2]);
        Assert.IsType<QuestTextNode.LineHeight>(doc.Nodes[3]);
        Assert.IsType<QuestTextNode.Indent>(doc.Nodes[4]);
        Assert.IsType<QuestTextNode.TextRun>(doc.Nodes[5]);
    }

    [Fact]
    public void SerializeIndent()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.Indent(),
            new QuestTextNode.TextRun("Hello", 18)
        ]);
        Assert.Equal("<G>Hello", QuestTextParser.Serialize(doc));
    }

    [Fact]
    public void SerializeFontBlock()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.FontBlock("茶叶", 171)
        ]);
        Assert.Equal("<F171 茶叶>", QuestTextParser.Serialize(doc));
    }

    [Fact]
    public void SerializeNewline()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.Newline()
        ]);
        Assert.Equal("\\n", QuestTextParser.Serialize(doc));
    }

    [Fact]
    public void SerializeMoneyWithCompare()
    {
        var doc = new QuestTextDocument([
            new QuestTextNode.Money(500, true)
        ]);
        Assert.Equal("<J500 compare>", QuestTextParser.Serialize(doc));
    }

    [Fact]
    public void RoundtripTypicalDialogue()
    {
        var input = "<G><F174 陶寒亭听你说完酒池峡中执行任务的经过，极为满意。>\\n<H28><G>甚好！这雪魔袋，是奖赏你的。本谷如今与<F171 昆仑派>、<F171 浩气盟>正面对敌，正需要你这般兼备才智与武力的豪杰！";
        var doc = QuestTextParser.Parse(input);
        var serialized = QuestTextParser.Serialize(doc);
        Assert.Equal(input, serialized);
    }

    [Fact]
    public void RoundtripSimpleDialogue()
    {
        var input = "<G>既是薛姑娘所说，白胭自然放心。只希望小蓉这孩子不要惹祸。";
        var doc = QuestTextParser.Parse(input);
        var serialized = QuestTextParser.Serialize(doc);
        Assert.Equal(input, serialized);
    }

    [Fact]
    public void RoundtripPlayerNameDialogue()
    {
        var input = "<G><N>，此事你做得甚佳，已有我当年入谷时的风范了。";
        var doc = QuestTextParser.Parse(input);
        var serialized = QuestTextParser.Serialize(doc);
        Assert.Equal(input, serialized);
    }

    [Fact]
    public void RoundtripSpecialNPCDialogue()
    {
        var input = "<F28 汪汪！>";
        var doc = QuestTextParser.Parse(input);
        var serialized = QuestTextParser.Serialize(doc);
        Assert.Equal(input, serialized);
    }

    [Fact]
    public void RoundtripAllTagTypes()
    {
        var input = "<G>text<N><C><F171 item><H28><T5><J100><A><AT><SD><WT>\\nend";
        var doc = QuestTextParser.Parse(input);
        var serialized = QuestTextParser.Serialize(doc);
        Assert.Equal(input, serialized);
    }

    [Fact]
    public void LooksLikeQuestTextDetectsGTag()
    {
        Assert.True(QuestTextParser.LooksLikeQuestText("<G>hello"));
    }

    [Fact]
    public void LooksLikeQuestTextDetectsFTag()
    {
        Assert.True(QuestTextParser.LooksLikeQuestText("<F171 text>"));
    }

    [Fact]
    public void LooksLikeQuestTextDetectsNTag()
    {
        Assert.True(QuestTextParser.LooksLikeQuestText("<N>"));
    }

    [Fact]
    public void LooksLikeQuestTextDetectsHTag()
    {
        Assert.True(QuestTextParser.LooksLikeQuestText("<H28>"));
    }

    [Fact]
    public void LooksLikeQuestTextRejectsPlainText()
    {
        Assert.False(QuestTextParser.LooksLikeQuestText("just plain text"));
    }

    [Fact]
    public void LooksLikeQuestTextRejectsEmpty()
    {
        Assert.False(QuestTextParser.LooksLikeQuestText(""));
        Assert.False(QuestTextParser.LooksLikeQuestText(null));
    }

    [Fact]
    public void LooksLikeQuestTextRejectsRichText()
    {
        Assert.False(QuestTextParser.LooksLikeQuestText("<text>text=\"hello\" font=18</text>"));
    }

    [Fact]
    public void LooksLikeQuestTextDetectsCTag()
    {
        Assert.True(QuestTextParser.LooksLikeQuestText("这位万花的<C>，行行好"));
    }
}
