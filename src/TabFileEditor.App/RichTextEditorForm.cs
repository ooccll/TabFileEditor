namespace TabFileEditor.App;

public sealed class RichTextEditorForm : Form
{
    private readonly ElemSchemeLoader _loader;
    private readonly RichTextDocument _document;
    private readonly RichTextPreviewPanel _previewPanel;
    private readonly Button _okButton;
    private readonly Button _cancelButton;

    private readonly Panel _fontBar;
    private readonly Label _fontLabel;
    private readonly Button _fontPickerButton;

    private int _editingSegmentIndex = -1;
    private bool _reenteringEdit;

    public string ResultMarkup { get; private set; } = "";

    private static readonly Color WindowBg = Color.FromArgb(0xF6, 0xF8, 0xFB);
    private static readonly Color AccentColor = Color.FromArgb(0x00, 0x7A, 0xCC);
    private static readonly Color FontBarBg = Color.FromArgb(0x2A, 0x2A, 0x3E);

    public RichTextEditorForm(string markup, ElemSchemeLoader loader)
    {
        _loader = loader;
        _document = RichTextMarkup.Parse(markup);

        Text = "富文本编辑器";
        Size = new Size(900, 750);
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

        _previewPanel.SegmentClicked += OnSegmentClicked;
        _previewPanel.NewSegmentRequested += OnNewSegmentRequested;
        _previewPanel.SegmentDeleteRequested += OnSegmentDeleteRequested;
        _previewPanel.SegmentMoveUpRequested += OnSegmentMoveUpRequested;
        _previewPanel.SegmentMoveDownRequested += OnSegmentMoveDownRequested;
        _previewPanel.SegmentInsertAfterRequested += OnSegmentInsertAfterRequested;
        _previewPanel.EditingStarted += OnEditingStarted;
        _previewPanel.EditingFinished += OnEditingFinished;

        // Font bar
        _fontBar = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 36,
            BackColor = FontBarBg,
            Visible = false,
        };

        _fontLabel = new Label
        {
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleLeft,
            ForeColor = Color.White,
            Font = new Font("Microsoft YaHei UI", 9F),
            Padding = new Padding(8, 0, 0, 0),
        };

        _fontPickerButton = new Button
        {
            Text = "...",
            Size = new Size(36, 28),
            Anchor = AnchorStyles.Right | AnchorStyles.Top,
            FlatStyle = FlatStyle.Flat,
            BackColor = Color.FromArgb(0x3A, 0x3A, 0x4E),
            ForeColor = Color.White,
            Cursor = Cursors.Hand,
        };
        _fontPickerButton.FlatAppearance.BorderColor = Color.FromArgb(0x50, 0x50, 0x64);
        _fontPickerButton.Click += OnFontPickerClick;

        _fontBar.Controls.Add(_fontLabel);
        _fontBar.Controls.Add(_fontPickerButton);
        _fontPickerButton.Location = new Point(_fontBar.Width - 44, 4);

        // Bottom panel with OK/Cancel
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

        // WinForms Z-order: add Fill first, then Bottom panels on top
        Controls.Add(_previewPanel);
        Controls.Add(_fontBar);
        Controls.Add(bottomPanel);

        AcceptButton = _okButton;
        CancelButton = _cancelButton;

        RefreshPreview();
        AutoSizeToContent();
    }

    private void AutoSizeToContent()
    {
        Control screenControl = Owner ?? this;
        var screen = Screen.FromControl(screenControl).WorkingArea;
        const int minWidth = 500;
        const int minHeight = 300;
        const int screenMargin = 24;

        var maxWindowWidth = Math.Max(1, screen.Width - screenMargin);
        var maxWindowHeight = Math.Max(1, screen.Height - screenMargin);
        var maxClientWidth = Math.Max(1, maxWindowWidth - (Width - ClientSize.Width));
        var maxPreviewWidth = Math.Max(1, maxClientWidth - 2);
        var contentSize = _previewPanel.MeasurePreferredContentSize(maxPreviewWidth);
        var desiredClientSize = new Size(
            contentSize.Width + 2,
            contentSize.Height + _fontBar.Height + 50 + 2);
        var desiredWindowSize = SizeFromClientSize(desiredClientSize);

        var width = Math.Min(maxWindowWidth, Math.Max(minWidth, desiredWindowSize.Width));
        var height = Math.Min(maxWindowHeight, Math.Max(minHeight, desiredWindowSize.Height));

        Size = new Size(width, height);
        Location = new Point(
            screen.X + (screen.Width - width) / 2,
            screen.Y + (screen.Height - height) / 2);
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        AutoSizeToContent();
    }

    private void RefreshPreview()
    {
        _previewPanel.SetSegments(_document.Segments);
    }

    #region Preview Panel Event Handlers

    private void OnSegmentClicked(int segmentIndex)
    {
        _editingSegmentIndex = segmentIndex;
        _previewPanel.BeginEdit(segmentIndex);
        ShowFontBar(segmentIndex);
    }

    private void OnNewSegmentRequested(int afterIndex)
    {
        var fontId = afterIndex < _document.Segments.Count
            ? _document.Segments[afterIndex].FontSchemeId
            : 18;
        var newSeg = new RichTextSegment("", fontId);
        _document.Segments.Insert(afterIndex + 1, newSeg);
        RefreshPreview();

        // Enter edit mode for the new segment
        _editingSegmentIndex = afterIndex + 1;
        _previewPanel.BeginEdit(afterIndex + 1);
        ShowFontBar(afterIndex + 1);
    }

    private void OnSegmentDeleteRequested(int segmentIndex)
    {
        if (_document.Segments.Count <= 1) return;
        if (segmentIndex < 0 || segmentIndex >= _document.Segments.Count) return;

        _document.Segments.RemoveAt(segmentIndex);
        RefreshPreview();
    }

    private void OnSegmentMoveUpRequested(int segmentIndex)
    {
        if (segmentIndex <= 0) return;
        (_document.Segments[segmentIndex - 1], _document.Segments[segmentIndex]) =
            (_document.Segments[segmentIndex], _document.Segments[segmentIndex - 1]);
        RefreshPreview();
    }

    private void OnSegmentMoveDownRequested(int segmentIndex)
    {
        if (segmentIndex >= _document.Segments.Count - 1) return;
        (_document.Segments[segmentIndex], _document.Segments[segmentIndex + 1]) =
            (_document.Segments[segmentIndex + 1], _document.Segments[segmentIndex]);
        RefreshPreview();
    }

    private void OnSegmentInsertAfterRequested(int segmentIndex)
    {
        var fontId = segmentIndex < _document.Segments.Count
            ? _document.Segments[segmentIndex].FontSchemeId
            : 18;
        var newSeg = new RichTextSegment("", fontId);
        _document.Segments.Insert(segmentIndex + 1, newSeg);
        RefreshPreview();

        _editingSegmentIndex = segmentIndex + 1;
        _previewPanel.BeginEdit(segmentIndex + 1);
        ShowFontBar(segmentIndex + 1);
    }

    private void OnEditingStarted()
    {
    }

    private void OnEditingFinished()
    {
        SyncFromPreview();

        // Don't reset state if we're about to re-enter edit mode (e.g. font picker)
        if (_reenteringEdit) return;

        HideFontBar();
        _editingSegmentIndex = -1;
    }

    private void SyncFromPreview()
    {
        var segments = _previewPanel.Segments.ToList();
        _document.Segments.Clear();
        _document.Segments.AddRange(segments);
    }

    #endregion

    #region Font Bar

    private void ShowFontBar(int segmentIndex)
    {
        if (segmentIndex < 0 || segmentIndex >= _document.Segments.Count) return;

        var fontSchemeId = _document.Segments[segmentIndex].FontSchemeId;
        var scheme = _loader.FontSchemes.GetValueOrDefault(fontSchemeId);
        _fontLabel.Text = $"  字体: {scheme?.Name ?? "未知"} (ID {fontSchemeId})";
        _fontBar.Visible = true;
    }

    private void HideFontBar()
    {
        _fontBar.Visible = false;
    }

    private void OnFontPickerClick(object? sender, EventArgs e)
    {
        if (_editingSegmentIndex < 0 || _editingSegmentIndex >= _document.Segments.Count) return;

        var editIdx = _editingSegmentIndex;
        var currentFontId = _document.Segments[editIdx].FontSchemeId;

        // Prevent EditingFinished from resetting state when overlay loses focus to the dialog
        _reenteringEdit = true;
        using var picker = new FontSchemePickerForm(_loader, currentFontId);
        if (picker.ShowDialog(this) != DialogResult.OK)
        {
            _reenteringEdit = false;
            // Re-enter edit mode even on cancel
            _previewPanel.SetSegments(_document.Segments);
            _editingSegmentIndex = editIdx;
            _previewPanel.BeginEdit(editIdx);
            return;
        }
        _reenteringEdit = false;

        var newFontId = picker.SelectedFontSchemeId;
        _document.Segments[editIdx] = _document.Segments[editIdx] with { FontSchemeId = newFontId };

        _previewPanel.SetSegments(_document.Segments);
        ShowFontBar(editIdx);
        _editingSegmentIndex = editIdx;
        _previewPanel.BeginEdit(editIdx);
    }

    #endregion

    private void OnOkClick(object? sender, EventArgs e)
    {
        // Commit any pending edit
        if (_editingSegmentIndex >= 0)
        {
            _previewPanel.CommitEdit();
            SyncFromPreview();
        }

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
        if (_fontPickerButton is not null)
            _fontPickerButton.Location = new Point(_fontBar.Width - 44, 4);
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        _previewPanel.Dispose();
        base.OnFormClosed(e);
    }
}
