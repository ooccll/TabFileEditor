namespace TabFileEditor.Core;

public sealed class TabTableColumn
{
    public TabTableColumn(int index, string title)
    {
        Index = index;
        Title = title;
    }

    public int Index { get; }

    public string Title { get; }
}

public sealed class TabTableRow
{
    internal TabTableRow(int rowIndex, IReadOnlyList<string> cells)
    {
        RowIndex = rowIndex;
        Cells = cells.ToList();
    }

    public int RowIndex { get; internal set; }

    public List<string> Cells { get; }
}
