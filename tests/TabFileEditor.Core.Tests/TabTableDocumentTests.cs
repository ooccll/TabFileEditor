using System.Text;
using TabFileEditor.Core;

namespace TabFileEditor.Core.Tests;

public sealed class TabTableDocumentTests : IDisposable
{
    private static readonly Encoding GbkEncoding = CreateGbkEncoding();
    private readonly string _tempDir = Path.Combine(Path.GetTempPath(), "TabFileEditorTests", Guid.NewGuid().ToString("N"));

    public TabTableDocumentTests()
    {
        Directory.CreateDirectory(_tempDir);
    }

    public void Dispose()
    {
        if (Directory.Exists(_tempDir))
        {
            Directory.Delete(_tempDir, recursive: true);
        }
    }

    [Fact]
    public void LoadsTabFileAndDetectsNameColumnAndIdPreamble()
    {
        var path = Path.Combine(_tempDir, "QuestTab.xls");
        CreateTextTable(
            path,
            ["ID", "QuestName", "Desc"],
            ["int", "string", "string"],
            ["编号", "任务名", "描述"],
            ["1", "FirstQuest", "第一条"],
            ["2", "SecondQuest", "第二条"]);

        var table = TabTableDocument.Load(path);

        Assert.True(table.HasIdColumn);
        Assert.Equal(3, table.PreambleRows.Count);
        Assert.Equal(3, table.DataStartRowIndex);
        Assert.Equal(1, table.RecommendedDisplayColumnIndex);
        Assert.Collection(
            table.Columns,
            column => Assert.Equal("ID", column.Title),
            column => Assert.Equal("QuestName", column.Title),
            column => Assert.Equal("Desc", column.Title));
        Assert.Collection(
            table.DataRows,
            row => Assert.Equal("[1] FirstQuest", table.BuildRowListText(row, table.RecommendedDisplayColumnIndex)),
            row => Assert.Equal("[2] SecondQuest", table.BuildRowListText(row, table.RecommendedDisplayColumnIndex)));
    }

    [Fact]
    public void UsesFirstNumericIdRowAsDataStartWhenIdZeroExists()
    {
        var path = Path.Combine(_tempDir, "ZeroId.tab");
        CreateTextTable(
            path,
            ["ID", "Name", "Desc"],
            ["int", "string", "string"],
            ["0", "DefaultQuest", "默认行"],
            ["1", "FirstQuest", "第一条"]);

        var table = TabTableDocument.Load(path);

        Assert.True(table.HasIdColumn);
        Assert.Equal(2, table.DataStartRowIndex);
        Assert.Collection(
            table.PreambleRows,
            row => Assert.Equal("ID", row.Cells[0]),
            row => Assert.Equal("int", row.Cells[0]));
        Assert.Collection(
            table.DataRows,
            row => Assert.Equal("0", row.Cells[0]),
            row => Assert.Equal("1", row.Cells[0]));
    }

    [Fact]
    public void BuildRowListTextUsesOnlyIdWhenDisplayColumnIsEmpty()
    {
        var path = Path.Combine(_tempDir, "EmptyNameWithId.tab");
        CreateTextTable(
            path,
            ["ID", "szName", "Desc"],
            ["int", "string", "string"],
            ["0", "", "默认行"],
            ["1", "FirstQuest", "第一条"]);

        var table = TabTableDocument.Load(path);

        Assert.Equal(1, table.RecommendedDisplayColumnIndex);
        Assert.Equal("[0]", table.BuildRowListText(table.DataRows[0], table.RecommendedDisplayColumnIndex));
        Assert.Equal(string.Empty, TabTableDocument.GetCellValue(table.DataRows[0], table.RecommendedDisplayColumnIndex));
        Assert.Equal("[1] FirstQuest", table.BuildRowListText(table.DataRows[1], table.RecommendedDisplayColumnIndex));
    }

    [Fact]
    public void BuildRowListTextKeepsRowFallbackForEmptyDisplayColumnWithoutId()
    {
        var path = Path.Combine(_tempDir, "EmptyNameWithoutId.tab");
        CreateTextTable(
            path,
            ["Key", "Value"],
            ["Alpha", ""]);

        var table = TabTableDocument.Load(path);

        Assert.False(table.HasIdColumn);
        Assert.Equal("第2行", table.BuildRowListText(table.DataRows[1], 1));
    }

    [Fact]
    public void UsesFirstNumericIdRowEvenWhenItIsNotZeroOrOne()
    {
        var path = Path.Combine(_tempDir, "HighId.tab");
        CreateTextTable(
            path,
            ["ID", "Name"],
            ["int", "string"],
            ["100", "Hundred"],
            ["101", "HundredOne"]);

        var table = TabTableDocument.Load(path);

        Assert.Equal(2, table.DataStartRowIndex);
        Assert.Collection(
            table.DataRows,
            row => Assert.Equal("100", row.Cells[0]),
            row => Assert.Equal("101", row.Cells[0]));
    }

    [Fact]
    public void DefaultsToFirstColumnWhenNoNameColumnExists()
    {
        var path = Path.Combine(_tempDir, "NoName.tab");
        CreateTextTable(
            path,
            ["Key", "Value"],
            ["Alpha", "One"],
            ["Beta", "Two"]);

        var table = TabTableDocument.Load(path);

        Assert.False(table.HasIdColumn);
        Assert.Equal(0, table.DataStartRowIndex);
        Assert.Empty(table.PreambleRows);
        Assert.Equal(0, table.RecommendedDisplayColumnIndex);
        Assert.Equal("Alpha", table.BuildRowListText(table.DataRows[1], table.RecommendedDisplayColumnIndex));
    }

    [Fact]
    public void LoadsTabFileWhileAnotherProcessHoldsSharedWriteAccess()
    {
        var path = Path.Combine(_tempDir, "SharedWrite.tab");
        CreateTextTable(
            path,
            ["ID", "Name"],
            ["1", "Alpha"]);

        using var writer = new FileStream(
            path,
            FileMode.Open,
            FileAccess.ReadWrite,
            FileShare.ReadWrite);

        var table = TabTableDocument.Load(path);

        Assert.Equal("Alpha", table.DataRows[0].Cells[1]);
    }

    [Fact]
    public void SavesEditedCellBackToTabFileWithOriginalEncodingAndNewline()
    {
        var path = Path.Combine(_tempDir, "SaveTab.xls");
        CreateTextTable(
            path,
            ["ID", "Name", "Desc"],
            ["int", "string", "string"],
            ["编号", "名称", "描述"],
            ["1", "OldName", "旧描述"]);

        var table = TabTableDocument.Load(path);
        table.SetCellValue(table.DataRows[0], 2, "新描述");
        table.Save();

        var bytes = File.ReadAllBytes(path);
        var text = GbkEncoding.GetString(bytes);
        Assert.Contains("OldName\t新描述", text);
        Assert.EndsWith("\r\n", text);
        Assert.Equal("新描述", TabTableDocument.Load(path).DataRows[0].Cells[2]);
    }

    [Theory]
    [InlineData("含\t制表符")]
    [InlineData("含\n换行")]
    [InlineData("含\r回车")]
    public void RejectsValuesThatWouldBreakTabFileShape(string value)
    {
        var path = Path.Combine(_tempDir, "RejectTab.tab");
        CreateTextTable(path, ["ID", "Name"], ["1", "Alpha"]);

        var table = TabTableDocument.Load(path);

        Assert.Throws<ArgumentException>(() => table.SetCellValue(table.DataRows[0], 1, value));
    }

    [Fact]
    public void LoadsStringKeyTableWithIdHeaderAsPreamble()
    {
        var path = Path.Combine(_tempDir, "StringKeyTab.xls");
        CreateTextTable(
            path,
            ["ID", "IsNormal", "GeneratedBase", "StrengthValue"],
            ["atInvalid", "{D2-D0}"],
            ["atAgilityBase", "1", "<text>", "100"]);

        var table = TabTableDocument.Load(path);

        Assert.True(table.HasIdColumn);
        Assert.Equal(1, table.DataStartRowIndex);
        Assert.Single(table.PreambleRows);
        Assert.Equal("ID", table.PreambleRows[0].Cells[0]);
        Assert.Equal(2, table.DataRows.Count);
        Assert.Equal("atInvalid", table.DataRows[0].Cells[0]);
        Assert.Equal("atAgilityBase", table.DataRows[1].Cells[0]);
    }

    [Fact]
    public void StringKeyTableBuildRowListTextUsesRawValue()
    {
        var path = Path.Combine(_tempDir, "StringKeyDisplay.tab");
        CreateTextTable(
            path,
            ["ID", "Name"],
            ["atFoo", "FooName"],
            ["atBar", ""]);

        var table = TabTableDocument.Load(path);

        Assert.Equal("FooName", table.BuildRowListText(table.DataRows[0], 1));
        Assert.Equal("第3行", table.BuildRowListText(table.DataRows[1], 1));
    }

    [Fact]
    public void StringKeyTableDeleteRowProtectsIdHeader()
    {
        var path = Path.Combine(_tempDir, "StringKeyDelete.tab");
        CreateTextTable(
            path,
            ["ID", "Name"],
            ["atFoo", "FooName"],
            ["atBar", "BarName"]);

        var table = TabTableDocument.Load(path);

        Assert.Throws<InvalidOperationException>(() => table.DeleteRow(table.PreambleRows[0]));
        table.DeleteRow(table.DataRows[0]);
        Assert.Single(table.DataRows);
        Assert.Equal("atBar", table.DataRows[0].Cells[0]);
    }

    [Fact]
    public void DetectsSchemaHeaderBeforeNumericIndexRowsWithoutIdColumn()
    {
        var path = Path.Combine(_tempDir, "SchemaHeader.tab");
        CreateTextTable(
            path,
            ["nIndex", "szType", "szName", "_Comment", "szBigAvatarPath", "nBigAvatarFrame"],
            ["0", "NPC/Longshou/Tower", "龙首", "备注", "ui/Image/Common/MobaMessage5.UITex", "8"],
            ["1", "", "小兵", "备注", "ui/Image/Common/MobaMessage5.UITex", "8"]);

        var table = TabTableDocument.Load(path);

        Assert.False(table.HasIdColumn);
        Assert.Equal(1, table.DataStartRowIndex);
        Assert.Single(table.PreambleRows);
        Assert.Equal("nIndex", table.PreambleRows[0].Cells[0]);
        Assert.Equal(2, table.DataRows.Count);
        Assert.Equal("0", table.DataRows[0].Cells[0]);
        Assert.Equal(2, table.RecommendedDisplayColumnIndex);
        Assert.Equal("龙首", table.BuildRowListText(table.DataRows[0], table.RecommendedDisplayColumnIndex));
    }

    [Fact]
    public void SchemaHeaderWithCommentRowAndNumericData()
    {
        var path = Path.Combine(_tempDir, "SchemaWithComment.tab");
        CreateTextTable(
            path,
            ["nIndex", "szType", "szName"],
            ["1001", "NPC", "铁匠"],
            ["1002", "NPC", "商人"]);

        var table = TabTableDocument.Load(path);

        Assert.Equal(1, table.DataStartRowIndex);
        Assert.Single(table.PreambleRows);
        Assert.Equal(2, table.DataRows.Count);
        Assert.Equal("1001", table.DataRows[0].Cells[0]);
    }

    [Fact]
    public void AttributeTableWithIdHeaderAndStringKeysStillWorks()
    {
        var path = Path.Combine(_tempDir, "AttributeRegression.tab");
        CreateTextTable(
            path,
            ["ID", "IsNormal", "GeneratedBase", "GeneratedMagic"],
            ["atInvalid", "{D2-D0}"],
            ["atAgilityBase", "1", "<text>", ""]);

        var table = TabTableDocument.Load(path);

        Assert.True(table.HasIdColumn);
        Assert.Equal(1, table.DataStartRowIndex);
        Assert.Single(table.PreambleRows);
        Assert.Equal("ID", table.PreambleRows[0].Cells[0]);
        Assert.Equal(2, table.DataRows.Count);
        Assert.Equal("atInvalid", table.DataRows[0].Cells[0]);
    }

    [Fact]
    public void AtInvalidAsFirstRowDoesNotCreatePreamble()
    {
        var path = Path.Combine(_tempDir, "AtInvalidFirst.tab");
        CreateTextTable(
            path,
            ["atInvalid", "{D2-D0}"],
            ["atFoo", "1"]);

        var table = TabTableDocument.Load(path);

        Assert.False(table.HasIdColumn);
        Assert.Equal(0, table.DataStartRowIndex);
        Assert.Empty(table.PreambleRows);
        Assert.Equal(2, table.DataRows.Count);
    }

    [Fact]
    public void TwoColumnKeyValueTableHasNoPreamble()
    {
        var path = Path.Combine(_tempDir, "KeyValue.tab");
        CreateTextTable(
            path,
            ["Key", "Value"],
            ["Alpha", "One"],
            ["Beta", "Two"]);

        var table = TabTableDocument.Load(path);

        Assert.False(table.HasIdColumn);
        Assert.Equal(0, table.DataStartRowIndex);
        Assert.Empty(table.PreambleRows);
        Assert.Equal(3, table.DataRows.Count);
    }

    [Fact]
    public void NumericIdTableWithThreePreambleRowsStillWorks()
    {
        var path = Path.Combine(_tempDir, "ThreePreamble.tab");
        CreateTextTable(
            path,
            ["ID", "QuestName", "Desc"],
            ["int", "string", "string"],
            ["编号", "任务名", "描述"],
            ["1", "FirstQuest", "第一条"],
            ["2", "SecondQuest", "第二条"]);

        var table = TabTableDocument.Load(path);

        Assert.True(table.HasIdColumn);
        Assert.Equal(3, table.DataStartRowIndex);
        Assert.Equal(3, table.PreambleRows.Count);
        Assert.Equal(2, table.DataRows.Count);
        Assert.Equal("[1] FirstQuest", table.BuildRowListText(table.DataRows[0], table.RecommendedDisplayColumnIndex));
    }

    private static void CreateTextTable(string path, params string[][] rows)
    {
        var lines = rows.Select(row => string.Join('\t', row));
        File.WriteAllText(path, string.Join("\r\n", lines) + "\r\n", GbkEncoding);
    }

    private static Encoding CreateGbkEncoding()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        return Encoding.GetEncoding("GB18030");
    }
}
