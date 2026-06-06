namespace TabFileEditor.App;

public sealed class RichTextEditorForm : Form
{
    private readonly RichTextPreviewPanel _previewPanel;
    private readonly TextBox _markupTextBox = new();
    private readonly Label _statusLabel = new();
    private readonly Button _okButton = new();
    private readonly Button _cancelButton = new();
    private readonly SplitContainer _splitContainer = new();
    private RichTextDocument _document;
    private bool _updatingMarkupText;

    public string ResultMarkup { get; private set; } = "";

    private static readonly Color WindowBg = Color.FromArgb(0xF6, 0xF8, 0xFB);
    private static readonly Color AccentColor = Color.FromArgb(0x00, 0x7A, 0xCC);
    private static readonly Color MutedTextColor = Color.FromArgb(0x47, 0x55, 0x69);
    private static readonly Color ErrorTextColor = Color.FromArgb(0xB9, 0x1C, 0x1C);

    public RichTextEditorForm(string markup, ElemSchemeLoader loader)
    {
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
        _previewPanel.SetDocument(_document);
        _previewPanel.DocumentChanged += PreviewPanelDocumentChanged;

        BuildMarkupTextBox();
        BuildStatusLabel();
        BuildButtons();
        BuildLayout();

        UpdateMarkupTextFromDocument();
        UpdateValidationState(null);
    }

    private void BuildMarkupTextBox()
    {
        _markupTextBox.Name = "MarkupTextBox";
        _markupTextBox.Dock = DockStyle.Fill;
        _markupTextBox.Multiline = true;
        _markupTextBox.AcceptsReturn = true;
        _markupTextBox.AcceptsTab = true;
        _markupTextBox.WordWrap = true;
        _markupTextBox.ScrollBars = ScrollBars.Vertical;
        _markupTextBox.BorderStyle = BorderStyle.FixedSingle;
        _markupTextBox.Font = new Font("Consolas", 10F, FontStyle.Regular);
        _markupTextBox.TextChanged += MarkupTextBoxTextChanged;
    }

    private void BuildStatusLabel()
    {
        _statusLabel.Dock = DockStyle.Bottom;
        _statusLabel.Height = 26;
        _statusLabel.TextAlign = ContentAlignment.MiddleLeft;
        _statusLabel.ForeColor = MutedTextColor;
        _statusLabel.BackColor = WindowBg;
    }

    private void BuildButtons()
    {
        _okButton.Text = "确定";
        _okButton.Size = new Size(80, 34);
        _okButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        _okButton.BackColor = AccentColor;
        _okButton.ForeColor = Color.White;
        _okButton.FlatStyle = FlatStyle.Flat;
        _okButton.Cursor = Cursors.Hand;
        _okButton.FlatAppearance.BorderColor = AccentColor;
        _okButton.Click += OnOkClick;

        _cancelButton.Text = "取消";
        _cancelButton.Size = new Size(80, 34);
        _cancelButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        _cancelButton.FlatStyle = FlatStyle.Flat;
        _cancelButton.Cursor = Cursors.Hand;
        _cancelButton.Click += (_, _) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };

        CancelButton = _cancelButton;
    }

    private void BuildLayout()
    {
        var previewLabel = BuildSectionLabel("  预览编辑（选中文字后右键可直接更改字体）");
        var markupLabel = BuildSectionLabel("  实际标签");

        _splitContainer.Dock = DockStyle.Fill;
        _splitContainer.Orientation = Orientation.Horizontal;
        _splitContainer.BackColor = WindowBg;
        _splitContainer.SplitterWidth = 6;
        _splitContainer.Panel1MinSize = 160;
        _splitContainer.Panel2MinSize = 120;

        _splitContainer.Panel1.Controls.Add(_previewPanel);
        _splitContainer.Panel1.Controls.Add(previewLabel);

        var markupPanel = new Panel { Dock = DockStyle.Fill, BackColor = WindowBg };
        markupPanel.Controls.Add(_markupTextBox);
        markupPanel.Controls.Add(_statusLabel);

        _splitContainer.Panel2.Controls.Add(markupPanel);
        _splitContainer.Panel2.Controls.Add(markupLabel);

        var bottomPanel = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 50,
            BackColor = WindowBg,
        };
        bottomPanel.Controls.AddRange([_okButton, _cancelButton]);

        Controls.Add(_splitContainer);
        Controls.Add(bottomPanel);
    }

    private static Label BuildSectionLabel(string text)
    {
        return new Label
        {
            Text = text,
            Dock = DockStyle.Top,
            Height = 28,
            TextAlign = ContentAlignment.MiddleLeft,
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold),
            ForeColor = MutedTextColor,
            BackColor = WindowBg,
        };
    }

    private void PreviewPanelDocumentChanged(object? sender, EventArgs e)
    {
        _document = _previewPanel.Document;
        UpdateMarkupTextFromDocument();
        UpdateValidationState(null);
    }

    private void MarkupTextBoxTextChanged(object? sender, EventArgs e)
    {
        if (_updatingMarkupText) return;

        if (!RichTextMarkup.TryParse(_markupTextBox.Text, out var parsedDocument, out var error))
        {
            UpdateValidationState(error);
            return;
        }

        _document = parsedDocument;
        _previewPanel.SetDocument(_document);
        UpdateValidationState(null);
    }

    private void UpdateMarkupTextFromDocument()
    {
        var markup = RichTextMarkup.Serialize(_document);
        if (_markupTextBox.Text == markup) return;

        _updatingMarkupText = true;
        try
        {
            _markupTextBox.Text = markup;
        }
        finally
        {
            _updatingMarkupText = false;
        }
    }

    private void UpdateValidationState(string? error)
    {
        var valid = string.IsNullOrWhiteSpace(error);
        _okButton.Enabled = valid;
        _statusLabel.ForeColor = valid ? MutedTextColor : ErrorTextColor;
        _statusLabel.Text = valid
            ? "标签已同步。可在预览里编辑，也可直接修改完整标签。"
            : error;
    }

    public void AcceptDialog()
    {
        if (!RichTextMarkup.TryParse(_markupTextBox.Text, out var parsedDocument, out var error))
        {
            UpdateValidationState(error);
            return;
        }

        ResultMarkup = RichTextMarkup.Serialize(parsedDocument);
        DialogResult = DialogResult.OK;
        Close();
    }

    private void OnOkClick(object? sender, EventArgs e) => AcceptDialog();

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        _splitContainer.SplitterDistance = Math.Max(160, _splitContainer.Height * 2 / 3);
        PositionButtons();
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        PositionButtons();
    }

    private void PositionButtons()
    {
        if (_okButton.Parent is null || _cancelButton.Parent is null) return;

        _okButton.Location = new Point(ClientSize.Width - 190, 8);
        _cancelButton.Location = new Point(ClientSize.Width - 96, 8);
    }
}
