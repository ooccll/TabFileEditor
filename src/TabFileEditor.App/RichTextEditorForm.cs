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
    private bool _updatingGrid;

    public string ResultMarkup { get; private set; } = "";

    private static readonly Color WindowBg = Color.FromArgb(0xF6, 0xF8, 0xFB);
    private static readonly Color AccentColor = Color.FromArgb(0x00, 0x7A, 0xCC);

    public RichTextEditorForm(string markup, ElemSchemeLoader loader)
    {
        _loader = loader;
        _document = RichTextMarkup.Parse(markup);

        Text = "富文本编辑器";
        Size = new Size(900, 700);
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.Sizable;
        MaximizeBox = false;
        ShowInTaskbar = false;
        BackColor = WindowBg;

        _previewPanel = new RichTextPreviewPanel(loader)
        {
            Dock = DockStyle.Top,
            Height = 250,
            BorderStyle = BorderStyle.FixedSingle,
        };

        _segmentGrid = new DataGridView
        {
            Dock = DockStyle.Fill,
            AllowUserToAddRows = false,
            AllowUserToDeleteRows = false,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            MultiSelect = false,
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders,
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
            BackgroundColor = Color.White,
            RowHeadersVisible = false,
        };

        _contextMenu = new ContextMenuStrip();
        _contextMenu.Items.Add("在此之后插入段落", null, OnInsertSegmentAfter);
        _contextMenu.Items.Add("删除段落", null, OnDeleteSegment);
        _contextMenu.Items.Add("-");
        _contextMenu.Items.Add("上移", null, OnMoveSegmentUp);
        _contextMenu.Items.Add("下移", null, OnMoveSegmentDown);

        _segmentGrid.CellValueChanged += OnSegmentGridCellValueChanged;
        _segmentGrid.CellClick += OnSegmentGridCellClick;
        _segmentGrid.CellContextMenuStripNeeded += (_, e) =>
        {
            if (e.RowIndex >= 0) _contextMenu.Show(_segmentGrid, _segmentGrid.PointToClient(Cursor.Position));
        };

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

        var centerPanel = new Panel { Dock = DockStyle.Fill };
        centerPanel.Controls.Add(_segmentGrid);
        centerPanel.Controls.Add(segmentLabel);

        Controls.Add(centerPanel);
        Controls.Add(bottomPanel);
        Controls.Add(_previewPanel);
        Controls.Add(previewLabel);

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
        };

        var fontNameCol = new DataGridViewTextBoxColumn
        {
            HeaderText = "字体名称",
            Name = "FontName",
            Width = 160,
            ReadOnly = true,
        };

        var colorCol = new DataGridViewTextBoxColumn
        {
            HeaderText = "颜色",
            Name = "Color",
            Width = 80,
            ReadOnly = true,
        };

        var textCol = new DataGridViewTextBoxColumn
        {
            HeaderText = "文本内容",
            Name = "Text",
            Width = 360,
            ReadOnly = false,
        };

        var changeFontCol = new DataGridViewButtonColumn
        {
            HeaderText = "",
            Text = "...",
            Name = "ChangeFont",
            Width = 50,
            UseColumnTextForButtonValue = true,
        };

        _segmentGrid.Columns.AddRange([fontIdCol, fontNameCol, colorCol, textCol, changeFontCol]);

        PopulateGridRows();
        _updatingGrid = false;
    }

    private void PopulateGridRows()
    {
        _segmentGrid.Rows.Clear();
        foreach (var seg in _document.Segments)
        {
            var scheme = _loader.FontSchemes.GetValueOrDefault(seg.FontSchemeId);
            var row = new DataGridViewRow();
            row.CreateCells(_segmentGrid,
                seg.FontSchemeId,
                scheme?.Name ?? "",
                scheme?.Color ?? "",
                seg.Text,
                "");
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

        var newText = _segmentGrid.Rows[e.RowIndex].Cells["Text"].Value?.ToString() ?? "";
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
        _segmentGrid.Rows[e.RowIndex].Cells["Color"].Value = scheme?.Color ?? "";
        _updatingGrid = false;

        RefreshPreview();
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
        ResultMarkup = RichTextMarkup.Serialize(_document);
        DialogResult = DialogResult.OK;
        Close();
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
