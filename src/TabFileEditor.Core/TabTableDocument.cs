using System.Globalization;
using System.Text;

namespace TabFileEditor.Core;

public sealed class TabTableDocument
{
    private const int InspectRowCount = 10;
    private static readonly Encoding StrictUtf8 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);
    private static readonly Encoding Utf8NoBom = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

    private readonly Encoding _encoding;
    private readonly string _newline;
    private readonly bool _hasFinalNewline;
    private readonly List<TabTableRow> _rows;

    private TabTableDocument(
        string path,
        Encoding encoding,
        string newline,
        bool hasFinalNewline,
        List<TabTableRow> rows,
        IReadOnlyList<TabTableColumn> columns,
        bool hasIdColumn,
        int dataStartRowIndex,
        int recommendedDisplayColumnIndex)
    {
        Path = path;
        _encoding = encoding;
        _newline = newline;
        _hasFinalNewline = hasFinalNewline;
        _rows = rows;
        Rows = _rows;
        Columns = columns;
        HasIdColumn = hasIdColumn;
        DataStartRowIndex = dataStartRowIndex;
        RecommendedDisplayColumnIndex = recommendedDisplayColumnIndex;
    }

    public string Path { get; }

    public IReadOnlyList<TabTableColumn> Columns { get; }

    public IReadOnlyList<TabTableRow> Rows { get; }

    public IReadOnlyList<TabTableRow> PreambleRows =>
        DataStartRowIndex > 0
            ? _rows.Take(DataStartRowIndex).ToList()
            : [];

    public IReadOnlyList<TabTableRow> DataRows =>
        DataStartRowIndex > 0
            ? _rows.Skip(DataStartRowIndex).ToList()
            : _rows.ToList();

    public bool HasIdColumn { get; }

    public int DataStartRowIndex { get; }

    public int RecommendedDisplayColumnIndex { get; }

    public string DisplayName => System.IO.Path.GetFileName(Path);

    public static TabTableDocument Load(string path)
    {
        if (!File.Exists(path))
        {
            throw new FileNotFoundException("未找到 tab 表格文件。", path);
        }

        var bytes = ReadAllBytesWithSharedAccess(path);
        var (encoding, text) = DecodeText(bytes);
        var newline = DetectNewline(text);
        var hasFinalNewline = EndsWithNewline(text);
        var normalized = text.Replace("\r\n", "\n").Replace('\r', '\n');
        if (hasFinalNewline && normalized.Length > 0)
        {
            normalized = normalized[..^1];
        }

        var rows = normalized.Length == 0
            ? []
            : normalized
                .Split('\n')
                .Select((line, index) => new TabTableRow(index, line.Split('\t')))
                .ToList();
        var columnCount = rows.Count == 0 ? 0 : rows.Max(row => row.Cells.Count);
        var columns = BuildColumns(rows, columnCount);
        var hasIdColumn = HasFirstColumnIdHeader(rows);
        var dataStartRowIndex = FindDataStartRowIndex(rows, columnCount);
        var recommendedDisplayColumnIndex = FindRecommendedDisplayColumnIndex(rows, columnCount);

        return new TabTableDocument(
            path,
            encoding,
            newline,
            hasFinalNewline,
            rows,
            columns,
            hasIdColumn,
            dataStartRowIndex,
            recommendedDisplayColumnIndex);
    }

    public void SetCellValue(TabTableRow row, int columnIndex, string value)
    {
        if (!_rows.Any(current => ReferenceEquals(current, row)))
        {
            throw new ArgumentException("行不属于当前 tab 表。", nameof(row));
        }

        ValidateCellValue(value);
        EnsureCellExists(row, columnIndex);
        row.Cells[columnIndex] = value;
    }

    public TabTableRow InsertRowBelow(TabTableRow referenceRow)
    {
        var index = _rows.FindIndex(r => ReferenceEquals(r, referenceRow));
        if (index < 0)
        {
            throw new ArgumentException("行不属于当前 tab 表。", nameof(referenceRow));
        }

        var columnCount = Columns.Count;
        var cells = Enumerable.Range(0, columnCount).Select(_ => string.Empty).ToList();
        var newRow = new TabTableRow(0, cells);
        _rows.Insert(index + 1, newRow);
        ReindexRows();
        return newRow;
    }

    public void DeleteRow(TabTableRow row)
    {
        var index = _rows.FindIndex(r => ReferenceEquals(r, row));
        if (index < 0)
        {
            throw new ArgumentException("行不属于当前 tab 表。", nameof(row));
        }

        if (index < DataStartRowIndex)
        {
            throw new InvalidOperationException("不能删除表头行。");
        }

        _rows.RemoveAt(index);
        ReindexRows();
    }

    private void ReindexRows()
    {
        for (var i = 0; i < _rows.Count; i++)
        {
            _rows[i].RowIndex = i;
        }
    }

    public void Save()
    {
        var lines = _rows.Select(row => string.Join('\t', row.Cells));
        var text = string.Join(_newline, lines);
        if (_hasFinalNewline)
        {
            text += _newline;
        }

        File.WriteAllText(Path, text, _encoding);
    }

    public string BuildRowListText(TabTableRow row, int displayColumnIndex)
    {
        var value = GetCellValue(row, displayColumnIndex).Trim();
        if (HasIdColumn && long.TryParse(GetCellValue(row, 0).Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out var id))
        {
            return string.IsNullOrEmpty(value) ? $"[{id}]" : $"[{id}] {value}";
        }

        return string.IsNullOrEmpty(value) ? $"第{row.RowIndex + 1}行" : value;
    }

    public static string GetCellValue(TabTableRow row, int columnIndex)
    {
        return columnIndex >= 0 && columnIndex < row.Cells.Count ? row.Cells[columnIndex] : string.Empty;
    }

    private static IReadOnlyList<TabTableColumn> BuildColumns(IReadOnlyList<TabTableRow> rows, int columnCount)
    {
        var inspectedRows = rows.Take(InspectRowCount).ToList();
        var columns = new List<TabTableColumn>();
        for (var columnIndex = 0; columnIndex < columnCount; columnIndex++)
        {
            var title = inspectedRows
                .Select(row => GetCellValue(row, columnIndex).Trim())
                .FirstOrDefault(value => value.Length > 0);
            columns.Add(new TabTableColumn(columnIndex, string.IsNullOrEmpty(title) ? $"第{columnIndex + 1}列" : title));
        }

        return columns;
    }

    private static bool HasFirstColumnIdHeader(IReadOnlyList<TabTableRow> rows)
    {
        return rows
            .Take(InspectRowCount)
            .Select(row => GetCellValue(row, 0))
            .Any(value => LooksLikeIdHeaderCell(value));
    }

    private static int FindDataStartRowIndex(IReadOnlyList<TabTableRow> rows, int columnCount)
    {
        var lastHeaderRowIndex = -1;
        var seenSchemaOrIdHeader = false;
        var inspected = Math.Min(InspectRowCount, rows.Count);

        for (var i = 0; i < inspected; i++)
        {
            var cell0 = GetCellValue(rows[i], 0).Trim();

            if (long.TryParse(cell0, NumberStyles.Integer, CultureInfo.InvariantCulture, out _))
            {
                break;
            }

            if (LooksLikeDataLikeValue(cell0) && !LooksLikeIdHeaderCell(cell0))
            {
                break;
            }

            if (LooksLikeIdHeaderCell(cell0))
            {
                seenSchemaOrIdHeader = true;
                lastHeaderRowIndex = i;
            }
            else if (LooksLikeSchemaHeaderRow(rows[i], columnCount))
            {
                seenSchemaOrIdHeader = true;
                lastHeaderRowIndex = i;
            }
            else if (seenSchemaOrIdHeader && IsLikelyTypeOrCommentRow(cell0))
            {
                lastHeaderRowIndex = i;
            }
            else if (seenSchemaOrIdHeader && HasNonAsciiFirstCell(cell0) && NextRowStartsWithNumeric(rows, i))
            {
                lastHeaderRowIndex = i;
            }
        }

        return lastHeaderRowIndex >= 0 ? lastHeaderRowIndex + 1 : 0;
    }

    private static bool LooksLikeSchemaHeaderRow(TabTableRow row, int columnCount)
    {
        if (columnCount <= 2)
        {
            return false;
        }

        var nonEmptyCount = 0;
        var fieldNameCount = 0;
        for (var i = 0; i < columnCount && i < row.Cells.Count; i++)
        {
            var cell = row.Cells[i].Trim();
            if (cell.Length == 0)
            {
                continue;
            }

            nonEmptyCount++;
            if (LooksLikeFieldNameCell(cell))
            {
                fieldNameCount++;
            }
        }

        return nonEmptyCount >= 3 && fieldNameCount * 5 >= nonEmptyCount * 3;
    }

    private static bool LooksLikeFieldNameCell(string cell)
    {
        if (cell.Length == 0 || cell.Length > 64)
        {
            return false;
        }

        if (LooksLikeDataLikeValue(cell))
        {
            return false;
        }

        if (!char.IsLetter(cell[0]) && cell[0] != '_')
        {
            return false;
        }

        for (var i = 0; i < cell.Length; i++)
        {
            if (!char.IsAsciiLetterOrDigit(cell[i]) && cell[i] != '_')
            {
                return false;
            }
        }

        return true;
    }

    private static bool LooksLikeDataLikeValue(string cell)
    {
        if (cell.Length == 0)
        {
            return false;
        }

        if (long.TryParse(cell, NumberStyles.Integer, CultureInfo.InvariantCulture, out _))
        {
            return true;
        }

        if (double.TryParse(cell, NumberStyles.Float, CultureInfo.InvariantCulture, out _))
        {
            return true;
        }

        if (cell.Contains('/'))
        {
            return true;
        }

        if (cell.StartsWith('<') && cell.EndsWith('>'))
        {
            return true;
        }

        if (cell.StartsWith('{') && cell.EndsWith('}'))
        {
            return true;
        }

        if (cell.Length > 2 && cell.StartsWith("at") && char.IsUpper(cell[2]))
        {
            return true;
        }

        return false;
    }

    private static bool LooksLikeIdHeaderCell(string cell)
    {
        return string.Equals(cell.Trim(), "ID", StringComparison.OrdinalIgnoreCase);
    }

    private static bool IsLikelyTypeOrCommentRow(string firstCell)
    {
        if (string.Equals(firstCell, "int", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(firstCell, "string", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(firstCell, "float", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(firstCell, "bool", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(firstCell, "double", StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }

        return false;
    }

    private static bool HasNonAsciiFirstCell(string cell)
    {
        for (var i = 0; i < cell.Length; i++)
        {
            if (cell[i] > 127)
            {
                return true;
            }
        }

        return false;
    }

    private static bool NextRowStartsWithNumeric(IReadOnlyList<TabTableRow> rows, int currentIndex)
    {
        var nextIndex = currentIndex + 1;
        if (nextIndex >= rows.Count)
        {
            return false;
        }

        var nextCell = GetCellValue(rows[nextIndex], 0).Trim();
        return long.TryParse(nextCell, NumberStyles.Integer, CultureInfo.InvariantCulture, out _);
    }

    private static int FindRecommendedDisplayColumnIndex(IReadOnlyList<TabTableRow> rows, int columnCount)
    {
        for (var columnIndex = 0; columnIndex < columnCount; columnIndex++)
        {
            var hasName = rows
                .Take(InspectRowCount)
                .Select(row => GetCellValue(row, columnIndex))
                .Any(value => value.Contains("Name", StringComparison.OrdinalIgnoreCase));
            if (hasName)
            {
                return columnIndex;
            }
        }

        return 0;
    }

    private static void EnsureCellExists(TabTableRow row, int columnIndex)
    {
        if (columnIndex < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(columnIndex), "列索引不能小于 0。");
        }

        while (row.Cells.Count <= columnIndex)
        {
            row.Cells.Add(string.Empty);
        }
    }

    private static void ValidateCellValue(string value)
    {
        if (value.Contains('\t') || value.Contains('\r') || value.Contains('\n'))
        {
            throw new ArgumentException("单元格内容不能包含制表符或换行。", nameof(value));
        }
    }

    private static (Encoding Encoding, string Text) DecodeText(byte[] bytes)
    {
        if (StartsWith(bytes, Encoding.UTF8.GetPreamble()))
        {
            return (Encoding.UTF8, Encoding.UTF8.GetString(bytes));
        }

        if (StartsWith(bytes, Encoding.Unicode.GetPreamble()))
        {
            return (Encoding.Unicode, Encoding.Unicode.GetString(bytes));
        }

        if (StartsWith(bytes, Encoding.BigEndianUnicode.GetPreamble()))
        {
            return (Encoding.BigEndianUnicode, Encoding.BigEndianUnicode.GetString(bytes));
        }

        try
        {
            return (Utf8NoBom, StrictUtf8.GetString(bytes));
        }
        catch (DecoderFallbackException)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var gb18030 = Encoding.GetEncoding("GB18030");
            return (gb18030, gb18030.GetString(bytes));
        }
    }

    private static byte[] ReadAllBytesWithSharedAccess(string path)
    {
        using var stream = new FileStream(
            path,
            FileMode.Open,
            FileAccess.Read,
            FileShare.ReadWrite | FileShare.Delete);
        using var memory = new MemoryStream();
        stream.CopyTo(memory);
        return memory.ToArray();
    }

    private static bool StartsWith(byte[] bytes, byte[] prefix)
    {
        if (prefix.Length == 0 || bytes.Length < prefix.Length)
        {
            return false;
        }

        for (var index = 0; index < prefix.Length; index++)
        {
            if (bytes[index] != prefix[index])
            {
                return false;
            }
        }

        return true;
    }

    private static string DetectNewline(string text)
    {
        if (text.Contains("\r\n", StringComparison.Ordinal))
        {
            return "\r\n";
        }

        if (text.Contains('\n'))
        {
            return "\n";
        }

        if (text.Contains('\r'))
        {
            return "\r";
        }

        return Environment.NewLine;
    }

    private static bool EndsWithNewline(string text)
    {
        return text.EndsWith('\n') || text.EndsWith('\r');
    }
}
