using System.Drawing.Text;

namespace TabFileEditor.App;

public sealed class RichTextEditorForm : Form
{
    private readonly ElemSchemeLoader _loader;
    private readonly RichTextDocument _document;
    private readonly RichTextPreviewPanel _previewPanel;
    private readonly DataGridView _segmentGrid;
    private readonly Button _okButton;
    private readonly Button _cancelButton;
    private readonly ContextMenuStrip _contextMenu;
    private readonly SplitContainer _splitContainer;
    private bool _updatingGrid;

    private readonly TextBox _expandedTextEditor = new();
    private int _expandedTextEditorRowIndex = -1;
    private bool _committingExpandedTextEditor;
    private const int ExpandedEditorPadding = 8;

    public string ResultMarkup { get; private set; } = "";

    private static readonly Color WindowBg = Color.FromArgb(0xF6, 0xF8, 0xFB);
    private static readonly Color AccentColor = Color.FromArgb(0x00, 0x7A, 0xCC);

    public RichTextEditorForm(string markup, ElemSchemeLoader loader)
    {
        _loader = loader;
        _document = RichTextMarkup.Parse(markup);

        Text = "富文本编辑器";
        Size = new Size(1100, 900);
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.Sizable;
        MaximizeBox = false;
        ShowInTaskbar = false;
        BackColor = WindowBg;

        _previewPanel = new RichTextPreviewPanel(loader)
        {
            Dock = DockStyle.Fill,
            BorderStyle = BorderStyle.FixedSingle,
        };

        _segmentGrid = new DataGridView
        {
            Dock = DockStyle.Fill,
            AllowUserToAddRows = false,
            AllowUserToDeleteRows = false,
            AllowUserToOrderColumns = false,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            MultiSelect = false,
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders,
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
            BackgroundColor = Color.White,
            RowHeadersVisible = false,
        };

        _expandedTextEditor.Visible = false;
        _expandedTextEditor.Multiline = true;
        _expandedTextEditor.WordWrap = true;
        _expandedTextEditor.AcceptsReturn = false;
        _expandedTextEditor.AcceptsTab = false;
        _expandedTextEditor.BorderStyle = BorderStyle.FixedSingle;
        _expandedTextEditor.ScrollBars = ScrollBars.Vertical;
        _expandedTextEditor.KeyDown += ExpandedTextEditorKeyDown;
        _expandedTextEditor.Leave += (_, _) => CommitExpandedTextEditor();
        _segmentGrid.Controls.Add(_expandedTextEditor);

        _segmentGrid.PreviewKeyDown += (_, e) =>
        {
            if (_expandedTextEditor.Visible && e.KeyCode == Keys.Enter)
                e.IsInputKey = true;
        };

        _contextMenu = new ContextMenuStrip();
        _contextMenu.Items.Add("在此之后插入段落", null, OnInsertSegmentAfter);
        _contextMenu.Items.Add("删除段落", null, OnDeleteSegment);
        _contextMenu.Items.Add("-");
        _contextMenu.Items.Add("上移", null, OnMoveSegmentUp);
        _contextMenu.Items.Add("下移", null, OnMoveSegmentDown);

        _segmentGrid.CellValueChanged += OnSegmentGridCellValueChanged;
        _segmentGrid.CellClick += OnSegmentGridCellClick;
        _segmentGrid.CellDoubleClick += OnSegmentGridCellDoubleClick;
        _segmentGrid.CellContextMenuStripNeeded += (_, e) =>
        {
            if (e.RowIndex >= 0) _contextMenu.Show(_segmentGrid, _segmentGrid.PointToClient(Cursor.Position));
        };

        var bottomPanel = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 50,
            BackColor = WindowBg,
        };

        _okButton = new Button
        {
            Text = "确定",
            Size = new Size(80, 34),
            Location = new Point(ClientSize.Width - 190, 8),
            Anchor = AnchorStyles.Right | AnchorStyles.Bottom,
            BackColor = AccentColor,
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Cursor = Cursors.Hand,
        };
        _okButton.FlatAppearance.BorderColor = AccentColor;
        _okButton.Click += OnOkClick;

        _cancelButton = new Button
        {
            Text = "取消",
            Size = new Size(80, 34),
            Location = new Point(ClientSize.Width - 96, 8),
            Anchor = AnchorStyles.Right | AnchorStyles.Bottom,
            FlatStyle = FlatStyle.Flat,
            Cursor = Cursors.Hand,
        };
        _cancelButton.Click += (_, _) => { DialogResult = DialogResult.Cancel; Close(); };

        bottomPanel.Controls.AddRange([_okButton, _cancelButton]);

        var previewLabel = new Label
        {
            Text = "  预览",
            Dock = DockStyle.Top,
            Height = 28,
            TextAlign = ContentAlignment.MiddleLeft,
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold),
            ForeColor = Color.FromArgb(0x47, 0x55, 0x69),
            BackColor = WindowBg,
        };

        var segmentLabel = new Label
        {
            Text = "  段落列表",
            Dock = DockStyle.Top,
            Height = 28,
            TextAlign = ContentAlignment.MiddleLeft,
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold),
            ForeColor = Color.FromArgb(0x47, 0x55, 0x69),
            BackColor = WindowBg,
        };

        _splitContainer = new SplitContainer
        {
            Dock = DockStyle.Fill,
            Orientation = Orientation.Horizontal,
            BackColor = WindowBg,
            SplitterWidth = 6,
            Panel1MinSize = 100,
            Panel2MinSize = 100,
        };

        _splitContainer.Panel1.Controls.Add(_previewPanel);
        _splitContainer.Panel1.Controls.Add(previewLabel);
        _splitContainer.Panel2.Controls.Add(_segmentGrid);
        _splitContainer.Panel2.Controls.Add(segmentLabel);

        Controls.Add(bottomPanel);
        Controls.Add(_splitContainer);

        AcceptButton = _okButton;
        CancelButton = _cancelButton;

        InitSegmentGrid();
        RefreshPreview();
    }

    private void InitSegmentGrid()
    {
        _updatingGrid = true;

        _segmentGrid.Columns.Clear();

        var fontIdCol = new DataGridViewTextBoxColumn
        {
            HeaderText = "字体ID",
            Name = "FontSchemeId",
            Width = 60,
            ReadOnly = true,
            SortMode = DataGridViewColumnSortMode.NotSortable,
        };

        var fontNameCol = new DataGridViewTextBoxColumn
        {
            HeaderText = "字体名称",
            Name = "FontName",
            Width = 160,
            ReadOnly = true,
            SortMode = DataGridViewColumnSortMode.NotSortable,
        };

        var textCol = new DataGridViewTextBoxColumn
        {
            HeaderText = "文本内容",
            Name = "Text",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            ReadOnly = false,
            SortMode = DataGridViewColumnSortMode.NotSortable,
        };

        var changeFontCol = new DataGridViewButtonColumn
        {
            HeaderText = "",
            Text = "...",
            Name = "ChangeFont",
            Width = 50,
            UseColumnTextForButtonValue = true,
            SortMode = DataGridViewColumnSortMode.NotSortable,
        };

        _segmentGrid.Columns.AddRange([changeFontCol, fontIdCol, fontNameCol, textCol]);

        PopulateGridRows();
        _updatingGrid = false;
    }

    private void PopulateGridRows()
    {
        HideExpandedTextEditor();
        _segmentGrid.Rows.Clear();
        foreach (var seg in _document.Segments)
        {
            var scheme = _loader.FontSchemes.GetValueOrDefault(seg.FontSchemeId);
            var row = new DataGridViewRow();
            row.CreateCells(_segmentGrid,
                "",
                seg.FontSchemeId,
                scheme?.Name ?? "",
                TextToGridDisplay(seg.Text));
            _segmentGrid.Rows.Add(row);
        }
    }

    private void RefreshPreview()
    {
        _previewPanel.SetSegments(_document.Segments);
    }

    private void OnSegmentGridCellValueChanged(object? sender, DataGridViewCellEventArgs e)
    {
        if (_updatingGrid || e.RowIndex < 0) return;
        if (_segmentGrid.Columns[e.ColumnIndex].Name != "Text") return;

        var rawText = _segmentGrid.Rows[e.RowIndex].Cells["Text"].Value?.ToString() ?? "";
        var newText = GridDisplayToText(rawText);
        if (e.RowIndex < _document.Segments.Count)
        {
            _document.Segments[e.RowIndex] = _document.Segments[e.RowIndex] with { Text = newText };
            RefreshPreview();
        }
    }

    private void OnSegmentGridCellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        if (_segmentGrid.Columns[e.ColumnIndex].Name != "ChangeFont") return;

        var currentFontId = _document.Segments[e.RowIndex].FontSchemeId;
        using var picker = new FontSchemePickerForm(_loader, currentFontId);
        if (picker.ShowDialog(this) != DialogResult.OK) return;

        var newFontId = picker.SelectedFontSchemeId;
        _document.Segments[e.RowIndex] = _document.Segments[e.RowIndex] with { FontSchemeId = newFontId };

        _updatingGrid = true;
        var scheme = _loader.FontSchemes.GetValueOrDefault(newFontId);
        _segmentGrid.Rows[e.RowIndex].Cells["FontSchemeId"].Value = newFontId;
        _segmentGrid.Rows[e.RowIndex].Cells["FontName"].Value = scheme?.Name ?? "";
        _updatingGrid = false;

        RefreshPreview();
    }

    private void OnSegmentGridCellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        if (_segmentGrid.Columns[e.ColumnIndex].Name != "Text") return;

        if (!CommitExpandedTextEditor()) return;
        ShowExpandedTextEditor(e.RowIndex);
    }

    private void ShowExpandedTextEditor(int rowIndex)
    {
        if (rowIndex < 0 || rowIndex >= _segmentGrid.Rows.Count) return;

        _expandedTextEditorRowIndex = rowIndex;

        var text = _segmentGrid.Rows[rowIndex].Cells["Text"].Value?.ToString() ?? "";

        var cellBounds = _segmentGrid.GetCellDisplayRectangle(
            _segmentGrid.Columns["Text"]!.Index, rowIndex, false);
        if (cellBounds.Width <= 0 || cellBounds.Height <= 0)
        {
            HideExpandedTextEditor();
            return;
        }

        var requiredHeight = CalculateExpandedTextEditorRequiredHeight(
            text, _segmentGrid.Font, cellBounds.Width);
        var availableHeight = Math.Max(
            cellBounds.Height,
            _segmentGrid.ClientSize.Height - cellBounds.Top - 2);
        var height = Math.Clamp(requiredHeight, cellBounds.Height, availableHeight);

        _expandedTextEditor.Font = _segmentGrid.Font;
        _expandedTextEditor.Text = text;
        _expandedTextEditor.Bounds = new Rectangle(cellBounds.Left, cellBounds.Top, cellBounds.Width, height);
        _expandedTextEditor.Visible = true;
        _expandedTextEditor.BringToFront();
        _expandedTextEditor.Focus();
        _expandedTextEditor.SelectionStart = _expandedTextEditor.Text.Length;
    }

    private bool CommitExpandedTextEditor()
    {
        if (_expandedTextEditorRowIndex < 0) return true;
        if (_committingExpandedTextEditor) return true;

        _committingExpandedTextEditor = true;
        try
        {
            var rowIndex = _expandedTextEditorRowIndex;
            if (rowIndex < 0 || rowIndex >= _segmentGrid.Rows.Count ||
                rowIndex >= _document.Segments.Count)
            {
                HideExpandedTextEditor();
                return true;
            }

            var newText = GridDisplayToText(_expandedTextEditor.Text);
            if (_document.Segments[rowIndex].Text == newText)
            {
                HideExpandedTextEditor();
                return true;
            }

            _document.Segments[rowIndex] = _document.Segments[rowIndex] with { Text = newText };

            _updatingGrid = true;
            _segmentGrid.Rows[rowIndex].Cells["Text"].Value = TextToGridDisplay(newText);
            _updatingGrid = false;

            RefreshPreview();
            HideExpandedTextEditor();
            return true;
        }
        finally
        {
            _committingExpandedTextEditor = false;
        }
    }

    private void HideExpandedTextEditor()
    {
        _expandedTextEditorRowIndex = -1;
        _expandedTextEditor.Visible = false;
    }

    private void ExpandedTextEditorKeyDown(object? sender, KeyEventArgs e)
    {
        if (e.Modifiers != Keys.None) return;

        if (e.KeyCode == Keys.Enter)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
            CommitExpandedTextEditor();
            _segmentGrid.Focus();
        }
        else if (e.KeyCode == Keys.Escape)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
            HideExpandedTextEditor();
            _segmentGrid.Focus();
        }
    }

    private static int CalculateExpandedTextEditorRequiredHeight(string text, Font font, int editorWidth)
    {
        var measureText = string.IsNullOrEmpty(text) ? " " : text;
        var measureWidth = Math.Max(1, editorWidth - ExpandedEditorPadding);
        var measured = TextRenderer.MeasureText(
            measureText,
            font,
            new Size(measureWidth, 10000),
            TextFormatFlags.WordBreak | TextFormatFlags.TextBoxControl | TextFormatFlags.NoPrefix);
        return Math.Max(30, measured.Height + ExpandedEditorPadding);
    }

    private void OnInsertSegmentAfter(object? sender, EventArgs e)
    {
        if (_segmentGrid.CurrentRow is not { } row) return;
        var idx = row.Index;
        var fontId = idx < _document.Segments.Count ? _document.Segments[idx].FontSchemeId : 18;
        var newSeg = new RichTextSegment("", fontId);
        _document.Segments.Insert(idx + 1, newSeg);

        _updatingGrid = true;
        PopulateGridRows();
        _updatingGrid = false;
        RefreshPreview();
    }

    private void OnDeleteSegment(object? sender, EventArgs e)
    {
        if (_segmentGrid.CurrentRow is not { } row) return;
        if (_document.Segments.Count <= 1) return;
        var idx = row.Index;
        if (idx >= 0 && idx < _document.Segments.Count)
        {
            _document.Segments.RemoveAt(idx);
            _updatingGrid = true;
            PopulateGridRows();
            _updatingGrid = false;
            RefreshPreview();
        }
    }

    private void OnMoveSegmentUp(object? sender, EventArgs e)
    {
        if (_segmentGrid.CurrentRow is not { } row) return;
        var idx = row.Index;
        if (idx <= 0) return;

        (_document.Segments[idx - 1], _document.Segments[idx]) =
            (_document.Segments[idx], _document.Segments[idx - 1]);

        _updatingGrid = true;
        PopulateGridRows();
        _segmentGrid.ClearSelection();
        _segmentGrid.Rows[idx - 1].Selected = true;
        _updatingGrid = false;
        RefreshPreview();
    }

    private void OnMoveSegmentDown(object? sender, EventArgs e)
    {
        if (_segmentGrid.CurrentRow is not { } row) return;
        var idx = row.Index;
        if (idx >= _document.Segments.Count - 1) return;

        (_document.Segments[idx], _document.Segments[idx + 1]) =
            (_document.Segments[idx + 1], _document.Segments[idx]);

        _updatingGrid = true;
        PopulateGridRows();
        _segmentGrid.ClearSelection();
        _segmentGrid.Rows[idx + 1].Selected = true;
        _updatingGrid = false;
        RefreshPreview();
    }

    private void OnOkClick(object? sender, EventArgs e)
    {
        CommitExpandedTextEditor();
        ResultMarkup = RichTextMarkup.Serialize(_document);
        DialogResult = DialogResult.OK;
        Close();
    }

    private static string TextToGridDisplay(string text)
        => text.Replace("\n", @"\\\n");

    private static string GridDisplayToText(string display)
        => display.Replace(@"\\\n", "\n");

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        _splitContainer.SplitterDistance = _splitContainer.Height / 2;
        PerformLayout();
        _okButton.Location = new Point(ClientSize.Width - 190, 8);
        _cancelButton.Location = new Point(ClientSize.Width - 96, 8);
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        if (_okButton is not null)
            _okButton.Location = new Point(ClientSize.Width - 190, 8);
        if (_cancelButton is not null)
            _cancelButton.Location = new Point(ClientSize.Width - 96, 8);
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        _previewPanel.Dispose();
        base.OnFormClosed(e);
    }
}
