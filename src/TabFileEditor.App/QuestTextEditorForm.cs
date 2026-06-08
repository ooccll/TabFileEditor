using System.Text;

namespace TabFileEditor.App;

public sealed class QuestTextEditorForm : Form
{
    private readonly QuestTextPreviewPanel _previewPanel;
    private readonly TextBox _sourceTextBox = new();
    private readonly Label _statusLabel = new();
    private readonly Button _okButton = new();
    private readonly Button _cancelButton = new();
    private readonly SplitContainer _splitContainer = new();
    private readonly ToolStrip _toolStrip = new();
    private readonly ElemSchemeLoader _loader;
    private QuestTextDocument _document;
    private bool _updatingSourceText;

    public string ResultTagText { get; private set; } = "";

    private static readonly Color WindowBg = Color.FromArgb(0xF6, 0xF8, 0xFB);
    private static readonly Color AccentColor = Color.FromArgb(0x00, 0x7A, 0xCC);
    private static readonly Color MutedTextColor = Color.FromArgb(0x47, 0x55, 0x69);
    private static readonly Color ErrorTextColor = Color.FromArgb(0xB9, 0x1C, 0x1C);

    private float DpiScale => DeviceDpi / 96f;
    private int Scaled(int pixels) => (int)Math.Round(pixels * DpiScale);

    public QuestTextEditorForm(string tagText, ElemSchemeLoader loader)
    {
        _loader = loader;
        _document = QuestTextParser.Parse(tagText);

        Text = "任务文本编辑器";
        Size = new Size(Scaled(900), Scaled(800));
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.Sizable;
        MaximizeBox = false;
        ShowInTaskbar = false;
        BackColor = WindowBg;

        _previewPanel = new QuestTextPreviewPanel(loader)
        {
            Dock = DockStyle.Fill,
            BorderStyle = BorderStyle.FixedSingle,
        };
        _previewPanel.SetDocument(_document);
        _previewPanel.DocumentChanged += PreviewPanelDocumentChanged;

        BuildToolStrip();
        BuildSourceTextBox();
        BuildStatusLabel();
        BuildButtons();
        BuildLayout();

        UpdateSourceTextFromDocument();
        UpdateValidationState(null);

        DpiChanged += (_, _) => ApplyDpiScaling();
    }

    private void BuildToolStrip()
    {
        _toolStrip.Dock = DockStyle.Top;
        _toolStrip.BackColor = Color.FromArgb(0xE8, 0xEB, 0xF0);
        _toolStrip.GripStyle = ToolStripGripStyle.Hidden;
        _toolStrip.Padding = new Padding(Scaled(4), Scaled(2), Scaled(4), Scaled(2));
        _toolStrip.Font = new Font("Microsoft YaHei UI", 9F);

        // <G> 缩进
        _toolStrip.Items.Add(new ToolStripButton("<G> 缩进", null, (_, _) =>
            _previewPanel.InsertNodeAtCaret(new QuestTextNode.Indent()))
        { ToolTipText = "插入段落缩进标记 <G>" });

        // <N> 玩家名
        _toolStrip.Items.Add(new ToolStripButton("<N> 玩家名", null, (_, _) =>
            _previewPanel.InsertNodeAtCaret(new QuestTextNode.PlayerName()))
        { ToolTipText = "插入玩家角色名占位符 <N>" });

        // <C> 门派称谓
        _toolStrip.Items.Add(new ToolStripButton("<C> 门派称谓", null, (_, _) =>
            _previewPanel.InsertNodeAtCaret(new QuestTextNode.FactionTitle()))
        { ToolTipText = "插入门派称谓占位符 <C>" });

        _toolStrip.Items.Add(new ToolStripSeparator());

        // 字体方案下拉
        var fontDrop = new ToolStripDropDownButton("字体方案") { ToolTipText = "选中文字后选择字体方案" };
        AddFontSchemeMenuItem(fontDrop, "F171 蓝色（地名/物品）", 171);
        AddFontSchemeMenuItem(fontDrop, "F172 红色（警告/备注）", 172);
        AddFontSchemeMenuItem(fontDrop, "F173 绿色（NPC名/地点）", 173);
        AddFontSchemeMenuItem(fontDrop, "F174 灰色（动作描写）", 174);
        AddFontSchemeMenuItem(fontDrop, "F28 白色大字（特殊NPC）", 28);
        fontDrop.DropDownItems.Add(new ToolStripSeparator());
        fontDrop.DropDownItems.Add("更多方案...", null, (_, _) => ChangeSelectedFont());
        _toolStrip.Items.Add(fontDrop);

        _toolStrip.Items.Add(new ToolStripSeparator());

        // <H28> 段距
        _toolStrip.Items.Add(new ToolStripButton("<H28> 段距", null, (_, _) =>
            _previewPanel.InsertNodeAtCaret(new QuestTextNode.LineHeight(28)))
        { ToolTipText = "插入段间距标记 <H28>" });

        // <T> 图标
        _toolStrip.Items.Add(new ToolStripButton("<T> 图标", null, (_, _) => InsertIconTag())
        { ToolTipText = "插入图标标记 <T>" });

        // <J> 金钱
        _toolStrip.Items.Add(new ToolStripButton("<J> 金钱", null, (_, _) => InsertMoneyTag())
        { ToolTipText = "插入金钱标记 <J>" });

        _toolStrip.Items.Add(new ToolStripSeparator());

        // 换行
        _toolStrip.Items.Add(new ToolStripButton("↵ 换行", null, (_, _) =>
            _previewPanel.InsertNodeAtCaret(new QuestTextNode.Newline()))
        { ToolTipText = "插入换行 \\n" });
    }

    private void AddFontSchemeMenuItem(ToolStripDropDownButton parent, string label, int fontSchemeId)
    {
        parent.DropDownItems.Add(label, null, (_, _) =>
            _previewPanel.ApplyFontAtSelection(fontSchemeId));
    }

    private void ChangeSelectedFont()
    {
        using var picker = new FontSchemePickerForm(_loader, QuestTextDocument.DefaultFontSchemeId);
        if (picker.ShowDialog(this) != DialogResult.OK) return;
        _previewPanel.ApplyFontAtSelection(picker.SelectedFontSchemeId);
    }

    private void InsertIconTag()
    {
        using var inputForm = new Form
        {
            Text = "插入图标",
            Size = new Size(Scaled(300), Scaled(140)),
            StartPosition = FormStartPosition.CenterParent,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            MaximizeBox = false,
            MinimizeBox = false,
            ShowInTaskbar = false,
        };
        var label = new Label { Text = "图标 ID:", Location = new Point(Scaled(16), Scaled(16)), AutoSize = true };
        var textBox = new TextBox { Location = new Point(Scaled(16), Scaled(40)), Width = Scaled(250) };
        var okBtn = new Button { Text = "确定", DialogResult = DialogResult.OK, Location = new Point(Scaled(110), Scaled(70)), Size = new Size(Scaled(80), Scaled(28)) };
        var cancelBtn = new Button { Text = "取消", DialogResult = DialogResult.Cancel, Location = new Point(Scaled(196), Scaled(70)), Size = new Size(Scaled(80), Scaled(28)) };
        inputForm.Controls.AddRange([label, textBox, okBtn, cancelBtn]);
        inputForm.AcceptButton = okBtn;
        inputForm.CancelButton = cancelBtn;

        if (inputForm.ShowDialog(this) != DialogResult.OK) return;
        if (int.TryParse(textBox.Text, out var iconId) && iconId >= 0)
            _previewPanel.InsertNodeAtCaret(new QuestTextNode.Icon(iconId));
    }

    private void InsertMoneyTag()
    {
        using var inputForm = new Form
        {
            Text = "插入金钱",
            Size = new Size(Scaled(300), Scaled(150)),
            StartPosition = FormStartPosition.CenterParent,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            MaximizeBox = false,
            MinimizeBox = false,
            ShowInTaskbar = false,
        };
        var label = new Label { Text = "金额:", Location = new Point(Scaled(16), Scaled(16)), AutoSize = true };
        var textBox = new TextBox { Location = new Point(Scaled(16), Scaled(40)), Width = Scaled(250) };
        var compareCheck = new CheckBox { Text = "比较（金币不足时变红）", Location = new Point(Scaled(16), Scaled(68)), AutoSize = true };
        var okBtn = new Button { Text = "确定", DialogResult = DialogResult.OK, Location = new Point(Scaled(110), Scaled(90)), Size = new Size(Scaled(80), Scaled(28)) };
        var cancelBtn = new Button { Text = "取消", DialogResult = DialogResult.Cancel, Location = new Point(Scaled(196), Scaled(90)), Size = new Size(Scaled(80), Scaled(28)) };
        inputForm.Controls.AddRange([label, textBox, compareCheck, okBtn, cancelBtn]);
        inputForm.AcceptButton = okBtn;
        inputForm.CancelButton = cancelBtn;

        if (inputForm.ShowDialog(this) != DialogResult.OK) return;
        if (long.TryParse(textBox.Text, out var amount) && amount >= 0)
            _previewPanel.InsertNodeAtCaret(new QuestTextNode.Money(amount, compareCheck.Checked));
    }

    private void BuildSourceTextBox()
    {
        _sourceTextBox.Name = "SourceTextBox";
        _sourceTextBox.Dock = DockStyle.Fill;
        _sourceTextBox.Multiline = true;
        _sourceTextBox.AcceptsReturn = true;
        _sourceTextBox.AcceptsTab = true;
        _sourceTextBox.WordWrap = true;
        _sourceTextBox.ScrollBars = ScrollBars.Vertical;
        _sourceTextBox.BorderStyle = BorderStyle.FixedSingle;
        _sourceTextBox.Font = new Font("Consolas", 10F, FontStyle.Regular);
        _sourceTextBox.TextChanged += SourceTextBoxTextChanged;
    }

    private void BuildStatusLabel()
    {
        _statusLabel.Dock = DockStyle.Bottom;
        _statusLabel.Height = Scaled(26);
        _statusLabel.TextAlign = ContentAlignment.MiddleLeft;
        _statusLabel.ForeColor = MutedTextColor;
        _statusLabel.BackColor = WindowBg;
    }

    private void BuildButtons()
    {
        _okButton.Text = "确定";
        _okButton.Size = new Size(Scaled(80), Scaled(34));
        _okButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        _okButton.BackColor = AccentColor;
        _okButton.ForeColor = Color.White;
        _okButton.FlatStyle = FlatStyle.Flat;
        _okButton.Cursor = Cursors.Hand;
        _okButton.FlatAppearance.BorderColor = AccentColor;
        _okButton.Click += OnOkClick;

        _cancelButton.Text = "取消";
        _cancelButton.Size = new Size(Scaled(80), Scaled(34));
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
        var previewLabel = BuildSectionLabel("  游戏风格编辑区（所见即所得，可直接编辑）");
        var sourceLabel = BuildSectionLabel("  源码（带标签的原始文本，可直接编辑）");

        _splitContainer.Dock = DockStyle.Fill;
        _splitContainer.Orientation = Orientation.Horizontal;
        _splitContainer.BackColor = WindowBg;
        _splitContainer.Panel1.BackColor = Color.FromArgb(0x48, 0x47, 0x44);
        _splitContainer.SplitterWidth = Scaled(6);

        _splitContainer.Panel1.Controls.Add(_previewPanel);
        _splitContainer.Panel1.Controls.Add(previewLabel);

        var sourcePanel = new Panel { Dock = DockStyle.Fill, BackColor = WindowBg };
        sourcePanel.Controls.Add(_sourceTextBox);
        sourcePanel.Controls.Add(_statusLabel);

        _splitContainer.Panel2.Controls.Add(sourcePanel);
        _splitContainer.Panel2.Controls.Add(sourceLabel);

        var bottomPanel = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = Scaled(50),
            BackColor = WindowBg,
        };
        bottomPanel.Controls.AddRange([_okButton, _cancelButton]);

        Controls.Add(_splitContainer);
        Controls.Add(bottomPanel);
        Controls.Add(_toolStrip);
    }

    private Label BuildSectionLabel(string text)
    {
        return new Label
        {
            Text = text,
            Dock = DockStyle.Top,
            Height = Scaled(28),
            TextAlign = ContentAlignment.MiddleLeft,
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold),
            ForeColor = MutedTextColor,
            BackColor = WindowBg,
        };
    }

    // ── Sync ──

    private void PreviewPanelDocumentChanged(object? sender, EventArgs e)
    {
        _document = _previewPanel.Document;
        UpdateSourceTextFromDocument();
        UpdateValidationState(null);
    }

    private void SourceTextBoxTextChanged(object? sender, EventArgs e)
    {
        if (_updatingSourceText) return;

        if (!QuestTextParser.TryParse(_sourceTextBox.Text, out var parsedDocument, out var error))
        {
            UpdateValidationState(error);
            return;
        }

        _document = parsedDocument;
        _previewPanel.SetDocument(_document);
        UpdateValidationState(null);
    }

    private void UpdateSourceTextFromDocument()
    {
        var tagText = QuestTextParser.Serialize(_document);
        if (_sourceTextBox.Text == tagText) return;

        _updatingSourceText = true;
        try
        {
            _sourceTextBox.Text = tagText;
        }
        finally
        {
            _updatingSourceText = false;
        }
    }

    private void UpdateValidationState(string? error)
    {
        var valid = string.IsNullOrWhiteSpace(error);
        _okButton.Enabled = valid;
        _statusLabel.ForeColor = valid ? MutedTextColor : ErrorTextColor;
        _statusLabel.Text = valid
            ? "标签已同步。可在编辑区编辑，也可直接修改源码标签。"
            : error;
    }

    public void AcceptDialog()
    {
        if (!QuestTextParser.TryParse(_sourceTextBox.Text, out var parsedDocument, out var error))
        {
            UpdateValidationState(error);
            return;
        }

        ResultTagText = QuestTextParser.Serialize(parsedDocument);
        DialogResult = DialogResult.OK;
        Close();
    }

    private void OnOkClick(object? sender, EventArgs e) => AcceptDialog();

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        _splitContainer.Panel1MinSize = Scaled(160);
        _splitContainer.Panel2MinSize = Scaled(120);
        _splitContainer.SplitterDistance = Math.Max(Scaled(160), _splitContainer.Height * 3 / 5);
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

        _okButton.Location = new Point(ClientSize.Width - Scaled(190), Scaled(8));
        _cancelButton.Location = new Point(ClientSize.Width - Scaled(96), Scaled(8));
    }

    private void ApplyDpiScaling()
    {
        _okButton.Size = new Size(Scaled(80), Scaled(34));
        _cancelButton.Size = new Size(Scaled(80), Scaled(34));
        _statusLabel.Height = Scaled(26);
        _splitContainer.SplitterWidth = Scaled(6);
        _splitContainer.Panel1MinSize = Scaled(160);
        _splitContainer.Panel2MinSize = Scaled(120);
        _toolStrip.Padding = new Padding(Scaled(4), Scaled(2), Scaled(4), Scaled(2));
        PositionButtons();
    }
}
