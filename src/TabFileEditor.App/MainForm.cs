using System.Diagnostics;
using TabFileEditor.Core;

namespace TabFileEditor.App;

public sealed class MainForm : Form
{
    private const string AppName = "填tab表工具";
    private const int DefaultWindowWidth = 1180;
    private const int DefaultWindowHeight = 720;
    private const int TopBarHeight = 66;
    private const int ColumnBarHeight = 48;
    private const int BottomBarHeight = 48;
    private const int SaveButtonWidth = 172;
    private const int OpenTableDirectoryButtonWidth = 188;

    private static readonly Color WindowBg = ColorTranslator.FromHtml("#F6F8FB");
    private static readonly Color PanelBg = Color.White;
    private static readonly Color BorderColor = ColorTranslator.FromHtml("#D7DEE8");
    private static readonly Color HeaderBg = ColorTranslator.FromHtml("#EAF1F8");
    private static readonly Color AccentColor = ColorTranslator.FromHtml("#1D64D8");
    private static readonly Color TextColor = ColorTranslator.FromHtml("#1F2937");
    private static readonly Color MutedTextColor = ColorTranslator.FromHtml("#475569");
    private static readonly Color ReadOnlyCellBg = SystemColors.Control;
    private static readonly Color CurrentRowHighlight = ColorTranslator.FromHtml("#D7E9FF");
    private static readonly Color DisabledButtonBg = ColorTranslator.FromHtml("#E5E7EB");
    private static readonly Color DisabledButtonTextColor = ColorTranslator.FromHtml("#8A8A8A");
    private static readonly Color DisabledButtonBorderColor = ColorTranslator.FromHtml("#CBD5E1");

    private readonly TextBox _filePathTextBox = new();
    private readonly Button _browseButton = new();
    private readonly Button _reloadButton = new();
    private readonly ComboBox _displayColumnComboBox = new();
    private readonly SplitContainer _splitContainer = new();
    private readonly TextBox _rowSearchTextBox = new();
    private readonly ListBox _rowListBox = new();
    private readonly DataGridView _detailGrid = new();
    private readonly Button _openTableDirectoryButton = new();
    private readonly Button _saveButton = new();
    private readonly ToolStripStatusLabel _statusLabel = new();

    private TabTableDocument? _document;
    private bool _isDirty;
    private bool _loadingRows;
    private bool _loadingDetails;
    private bool _splitterInitialized;
    private int _displayColumnIndex;
    private Action<ProcessStartInfo> _startProcess = processStartInfo => Process.Start(processStartInfo);

    public MainForm()
    {
        Text = AppName;
        BackColor = WindowBg;
        MinimumSize = new Size(900, 540);
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(DefaultWindowWidth, DefaultWindowHeight);
        Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

        BuildUi();
        SetStatus("请选择要打开的 tab 表格文件。");
        UpdateActionButtons();
    }

    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);
        InitializeSplitterDistance();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        if (!ConfirmDiscardDirtyChanges("关闭工具前，存在未保存修改。是否放弃这些修改？"))
        {
            e.Cancel = true;
            return;
        }

        base.OnFormClosing(e);
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (keyData == (Keys.Control | Keys.S))
        {
            SaveCurrentFile(showSuccessMessage: false);
            return true;
        }

        return base.ProcessCmdKey(ref msg, keyData);
    }

    private void BuildUi()
    {
        var root = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 4,
            BackColor = WindowBg,
        };
        root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, TopBarHeight));
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, ColumnBarHeight));
        root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, BottomBarHeight));
        Controls.Add(root);

        BuildFileBar(root);
        BuildColumnBar(root);
        BuildContent(root);
        BuildBottomBar(root);
    }

    private void BuildFileBar(TableLayoutPanel root)
    {
        var fileBar = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 4,
            RowCount = 1,
            BackColor = PanelBg,
            Margin = new Padding(10, 10, 10, 6),
            Padding = new Padding(10, 6, 10, 6),
        };
        fileBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 76));
        fileBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        fileBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86));
        fileBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108));
        fileBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        fileBar.Paint += DrawPanelBorder;
        root.Controls.Add(fileBar, 0, 0);

        fileBar.Controls.Add(BuildLabel("表格文件"), 0, 0);

        _filePathTextBox.Name = "FilePathTextBox";
        _filePathTextBox.Dock = DockStyle.None;
        _filePathTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        _filePathTextBox.Margin = new Padding(0, 1, 8, 1);
        _filePathTextBox.BorderStyle = BorderStyle.FixedSingle;
        fileBar.Controls.Add(_filePathTextBox, 1, 0);

        ConfigureButton(_browseButton, "选择");
        _browseButton.Click += (_, _) => BrowseFile();
        fileBar.Controls.Add(_browseButton, 2, 0);

        ConfigureButton(_reloadButton, "重新加载");
        _reloadButton.Click += (_, _) => LoadCurrentFile();
        fileBar.Controls.Add(_reloadButton, 3, 0);
    }

    private void BuildColumnBar(TableLayoutPanel root)
    {
        var columnBar = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 3,
            RowCount = 1,
            BackColor = WindowBg,
            Margin = new Padding(10, 0, 10, 8),
        };
        columnBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118));
        columnBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 360));
        columnBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        columnBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        root.Controls.Add(columnBar, 0, 1);

        columnBar.Controls.Add(BuildLabel("左侧显示列"), 0, 0);

        _displayColumnComboBox.Name = "DisplayColumnComboBox";
        _displayColumnComboBox.Dock = DockStyle.Fill;
        _displayColumnComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        _displayColumnComboBox.Margin = new Padding(0, 2, 0, 2);
        _displayColumnComboBox.Enabled = false;
        _displayColumnComboBox.SelectedIndexChanged += (_, _) => DisplayColumnComboBoxSelectedIndexChanged();
        columnBar.Controls.Add(_displayColumnComboBox, 1, 0);
    }

    private void BuildContent(TableLayoutPanel root)
    {
        _splitContainer.Dock = DockStyle.Fill;
        _splitContainer.BackColor = WindowBg;
        _splitContainer.FixedPanel = FixedPanel.Panel1;
        _splitContainer.Padding = new Padding(10, 0, 10, 8);
        root.Controls.Add(_splitContainer, 0, 2);

        BuildRowListPanel();
        ConfigureDetailGrid();
    }

    private void BuildRowListPanel()
    {
        var rowListPanel = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 2,
            BackColor = WindowBg,
            Margin = new Padding(0),
        };
        rowListPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        rowListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
        rowListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        _splitContainer.Panel1.Controls.Add(rowListPanel);

        _rowSearchTextBox.Name = "RowSearchTextBox";
        _rowSearchTextBox.Dock = DockStyle.Fill;
        _rowSearchTextBox.Margin = new Padding(0, 0, 0, 6);
        _rowSearchTextBox.BorderStyle = BorderStyle.FixedSingle;
        _rowSearchTextBox.PlaceholderText = "搜索左侧列表";
        _rowSearchTextBox.TextChanged += (_, _) => RenderRows(selectFirstWhenAvailable: true);
        rowListPanel.Controls.Add(_rowSearchTextBox, 0, 0);

        _rowListBox.Dock = DockStyle.Fill;
        _rowListBox.BorderStyle = BorderStyle.FixedSingle;
        _rowListBox.BackColor = PanelBg;
        _rowListBox.ForeColor = TextColor;
        _rowListBox.IntegralHeight = false;
        _rowListBox.SelectedIndexChanged += (_, _) => RenderSelectedRow();
        rowListPanel.Controls.Add(_rowListBox, 0, 1);
    }

    private void ConfigureDetailGrid()
    {
        _detailGrid.Name = "DetailGrid";
        _detailGrid.Dock = DockStyle.Fill;
        _detailGrid.AllowUserToAddRows = false;
        _detailGrid.AllowUserToDeleteRows = false;
        _detailGrid.AllowUserToResizeRows = false;
        _detailGrid.BackgroundColor = PanelBg;
        _detailGrid.BorderStyle = BorderStyle.FixedSingle;
        _detailGrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        _detailGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        _detailGrid.ColumnHeadersHeight = 34;
        _detailGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        _detailGrid.EnableHeadersVisualStyles = false;
        _detailGrid.GridColor = BorderColor;
        _detailGrid.MultiSelect = true;
        _detailGrid.RowHeadersVisible = false;
        _detailGrid.RowTemplate.Height = 30;
        _detailGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
        _detailGrid.ColumnHeadersDefaultCellStyle.BackColor = HeaderBg;
        _detailGrid.ColumnHeadersDefaultCellStyle.ForeColor = TextColor;
        _detailGrid.ColumnHeadersDefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
        _detailGrid.DefaultCellStyle.BackColor = PanelBg;
        _detailGrid.DefaultCellStyle.ForeColor = TextColor;
        _detailGrid.DefaultCellStyle.SelectionBackColor = CurrentRowHighlight;
        _detailGrid.DefaultCellStyle.SelectionForeColor = TextColor;
        _detailGrid.CellValueChanged += DetailGridCellValueChanged;
        _detailGrid.CellBeginEdit += DetailGridCellBeginEdit;
        _detailGrid.CellEndEdit += DetailGridCellEndEdit;
        _splitContainer.Panel2.Controls.Add(_detailGrid);
    }

    private void BuildBottomBar(TableLayoutPanel root)
    {
        var bottomBar = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 3,
            RowCount = 1,
            BackColor = WindowBg,
            Margin = new Padding(0),
            Padding = new Padding(10, 4, 10, 8),
        };
        bottomBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        bottomBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, OpenTableDirectoryButtonWidth));
        bottomBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, SaveButtonWidth));
        bottomBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        root.Controls.Add(bottomBar, 0, 3);

        var statusStrip = new StatusStrip
        {
            Dock = DockStyle.Fill,
            SizingGrip = false,
            Margin = new Padding(0),
            Padding = Padding.Empty,
            BackColor = WindowBg,
        };
        _statusLabel.Spring = true;
        _statusLabel.TextAlign = ContentAlignment.MiddleLeft;
        statusStrip.Items.Add(_statusLabel);
        bottomBar.Controls.Add(statusStrip, 0, 0);

        ConfigureButton(_openTableDirectoryButton, "打开表格所在目录");
        _openTableDirectoryButton.Click += (_, _) => OpenCurrentFileDirectory();
        bottomBar.Controls.Add(_openTableDirectoryButton, 1, 0);

        ConfigureButton(_saveButton, "保存", accent: true);
        _saveButton.Click += (_, _) => SaveCurrentFile(showSuccessMessage: true);
        bottomBar.Controls.Add(_saveButton, 2, 0);
    }

    private void BrowseFile()
    {
        if (!ConfirmDiscardDirtyChanges("打开新文件前，存在未保存修改。是否放弃这些修改？"))
        {
            return;
        }

        using var dialog = new OpenFileDialog
        {
            Title = "选择 tab 表格文件",
            Filter = "Tab 表格文件 (*.txt;*.tab;*.xls)|*.txt;*.tab;*.xls|所有文件 (*.*)|*.*",
            CheckFileExists = true,
            Multiselect = false,
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        _filePathTextBox.Text = dialog.FileName;
        LoadCurrentFile();
    }

    private void LoadCurrentFile()
    {
        if (!ConfirmDiscardDirtyChanges("重新加载前，存在未保存修改。是否放弃这些修改？"))
        {
            return;
        }

        var path = _filePathTextBox.Text.Trim();
        if (string.IsNullOrWhiteSpace(path))
        {
            SetStatus("请选择要打开的 tab 表格文件。");
            return;
        }

        try
        {
            _document = TabTableDocument.Load(path);
            _isDirty = false;
            _rowSearchTextBox.Clear();
            PopulateDisplayColumnComboBox();
            RenderRows(selectFirstWhenAvailable: true);
            SetStatus($"已加载 {_document.DisplayName}，共 {_document.DataRows.Count} 行。");
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or InvalidDataException or ArgumentException)
        {
            _document = null;
            _isDirty = false;
            _displayColumnComboBox.Items.Clear();
            _displayColumnComboBox.Enabled = false;
            ClearRowsAndDetails();
            SetStatus($"加载失败：{ex.Message}");
            MessageBox.Show(this, $"加载失败。\n\n{ex.Message}", "加载失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            UpdateActionButtons();
        }
    }

    private void PopulateDisplayColumnComboBox()
    {
        _displayColumnComboBox.Items.Clear();
        if (_document is null)
        {
            _displayColumnComboBox.Enabled = false;
            return;
        }

        foreach (var column in _document.Columns)
        {
            _displayColumnComboBox.Items.Add(new DisplayColumnItem(column));
        }

        _displayColumnComboBox.Enabled = _displayColumnComboBox.Items.Count > 0;
        if (_displayColumnComboBox.Items.Count == 0)
        {
            _displayColumnIndex = 0;
            return;
        }

        var selectedIndex = Math.Clamp(_document.RecommendedDisplayColumnIndex, 0, _displayColumnComboBox.Items.Count - 1);
        _displayColumnComboBox.SelectedIndex = selectedIndex;
        _displayColumnIndex = selectedIndex;
    }

    private void DisplayColumnComboBoxSelectedIndexChanged()
    {
        if (_displayColumnComboBox.SelectedItem is not DisplayColumnItem item)
        {
            return;
        }

        _displayColumnIndex = item.Column.Index;
        RenderRows(selectFirstWhenAvailable: true);
    }

    private void RenderRows(bool selectFirstWhenAvailable, TabTableRow? preferredRow = null)
    {
        if (_loadingRows)
        {
            return;
        }

        _loadingRows = true;
        try
        {
            _rowListBox.BeginUpdate();
            _rowListBox.Items.Clear();

            if (_document is null)
            {
                ClearDetails();
                return;
            }

            var query = _rowSearchTextBox.Text.Trim();
            foreach (var row in _document.DataRows)
            {
                var item = new RowListItem(row, _document.BuildRowListText(row, _displayColumnIndex));
                if (query.Length == 0 || item.Text.Contains(query, StringComparison.OrdinalIgnoreCase))
                {
                    _rowListBox.Items.Add(item);
                }
            }

            var preferredIndex = preferredRow is null
                ? -1
                : _rowListBox.Items
                    .Cast<RowListItem>()
                    .Select((item, index) => new { item, index })
                    .FirstOrDefault(pair => ReferenceEquals(pair.item.Row, preferredRow))
                    ?.index ?? -1;
            if (preferredIndex >= 0)
            {
                _rowListBox.SelectedIndex = preferredIndex;
            }
            else if (selectFirstWhenAvailable && _rowListBox.Items.Count > 0)
            {
                _rowListBox.SelectedIndex = 0;
            }
            else
            {
                ClearDetails();
            }
        }
        finally
        {
            _rowListBox.EndUpdate();
            _loadingRows = false;
        }

        if (_rowListBox.SelectedItem is RowListItem)
        {
            RenderSelectedRow();
        }
    }

    private void RenderSelectedRow()
    {
        if (_loadingRows)
        {
            return;
        }

        var selectedItem = _rowListBox.SelectedItem as RowListItem;
        if (selectedItem is null || _document is null)
        {
            ClearDetails();
            return;
        }

        _loadingDetails = true;
        try
        {
            _detailGrid.Columns.Clear();
            _detailGrid.Rows.Clear();
            ConfigureDetailColumns();

            foreach (var column in _document.Columns)
            {
                var rowIndex = _detailGrid.Rows.Add();
                var gridRow = _detailGrid.Rows[rowIndex];
                gridRow.Tag = column.Index;
                gridRow.Cells[0].Value = $"第{column.Index + 1}列";

                var gridColumnIndex = 1;
                foreach (var preambleRow in _document.PreambleRows)
                {
                    gridRow.Cells[gridColumnIndex].Value = TabTableDocument.GetCellValue(preambleRow, column.Index);
                    gridColumnIndex++;
                }

                gridRow.Cells[gridColumnIndex].Value = TabTableDocument.GetCellValue(selectedItem.Row, column.Index);
            }
        }
        finally
        {
            _loadingDetails = false;
        }
    }

    private void ConfigureDetailColumns()
    {
        _detailGrid.Columns.Add(BuildReadOnlyTextColumn("ColumnIndex", "列", 86));

        if (_document is not null)
        {
            foreach (var preambleRow in _document.PreambleRows)
            {
                _detailGrid.Columns.Add(BuildReadOnlyTextColumn(
                    $"Preamble{preambleRow.RowIndex}",
                    $"第{preambleRow.RowIndex + 1}行",
                    180));
            }
        }

        var valueColumn = new DataGridViewTextBoxColumn
        {
            Name = "Value",
            HeaderText = "值",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            MinimumWidth = 180,
            ReadOnly = false,
            SortMode = DataGridViewColumnSortMode.NotSortable,
        };
        valueColumn.DefaultCellStyle.BackColor = PanelBg;
        _detailGrid.Columns.Add(valueColumn);
    }

    private static DataGridViewTextBoxColumn BuildReadOnlyTextColumn(string name, string headerText, int width)
    {
        return new DataGridViewTextBoxColumn
        {
            Name = name,
            HeaderText = headerText,
            Width = width,
            MinimumWidth = Math.Min(width, 120),
            ReadOnly = true,
            SortMode = DataGridViewColumnSortMode.NotSortable,
            DefaultCellStyle = { BackColor = ReadOnlyCellBg },
        };
    }

    private void DetailGridCellBeginEdit(object? sender, DataGridViewCellCancelEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0)
        {
            return;
        }

        e.Cancel = _detailGrid.Columns[e.ColumnIndex].Name != "Value";
    }

    private void DetailGridCellEndEdit(object? sender, DataGridViewCellEventArgs e)
    {
        _detailGrid.Rows[e.RowIndex].ErrorText = string.Empty;
    }

    private void DetailGridCellValueChanged(object? sender, DataGridViewCellEventArgs e)
    {
        if (_loadingDetails ||
            _document is null ||
            e.RowIndex < 0 ||
            e.ColumnIndex < 0 ||
            _detailGrid.Columns[e.ColumnIndex].Name != "Value" ||
            _rowListBox.SelectedItem is not RowListItem selectedItem ||
            _detailGrid.Rows[e.RowIndex].Tag is not int tableColumnIndex)
        {
            return;
        }

        var value = Convert.ToString(_detailGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) ?? string.Empty;
        try
        {
            _document.SetCellValue(selectedItem.Row, tableColumnIndex, value);
            _isDirty = true;
            UpdateActionButtons();
            RenderRows(selectFirstWhenAvailable: true, preferredRow: selectedItem.Row);
            SetStatus("存在未保存修改。");
        }
        catch (ArgumentException ex)
        {
            _detailGrid.Rows[e.RowIndex].ErrorText = ex.Message;
            _detailGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = TabTableDocument.GetCellValue(selectedItem.Row, tableColumnIndex);
            MessageBox.Show(this, ex.Message, "内容无效", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void SaveCurrentFile(bool showSuccessMessage)
    {
        if (_document is null || !_isDirty)
        {
            return;
        }

        _detailGrid.EndEdit();

        try
        {
            _document.Save();
            _isDirty = false;
            UpdateActionButtons();
            SetStatus($"{_document.DisplayName} 已保存。");
            if (showSuccessMessage)
            {
                MessageBox.Show(this, "保存成功。", "保存完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
        {
            SetStatus($"保存失败：{ex.Message}");
            MessageBox.Show(this, $"保存失败，当前修改仍保留在工具中。\n\n{ex.Message}", "保存失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void OpenCurrentFileDirectory()
    {
        if (!TryGetCurrentFilePath(out var filePath))
        {
            SetStatus("当前没有可打开目录的表格文件。");
            return;
        }

        try
        {
            _startProcess(BuildSelectFileProcessStartInfo(filePath));
            SetStatus($"已打开 {Path.GetFileName(filePath)} 所在目录。");
        }
        catch (Exception ex)
        {
            SetStatus($"打开表格所在目录失败：{ex.Message}");
            MessageBox.Show(this, $"打开表格所在目录失败。\n\n{ex.Message}", "打开失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool TryGetCurrentFilePath(out string filePath)
    {
        filePath = string.Empty;
        var path = _document?.Path ?? _filePathTextBox.Text.Trim();
        if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
        {
            return false;
        }

        filePath = Path.GetFullPath(path);
        return true;
    }

    private static ProcessStartInfo BuildSelectFileProcessStartInfo(string filePath)
    {
        var fullPath = Path.GetFullPath(filePath);
        return new ProcessStartInfo
        {
            FileName = "explorer.exe",
            Arguments = $"/select,\"{fullPath}\"",
            WorkingDirectory = Path.GetDirectoryName(fullPath) ?? string.Empty,
            UseShellExecute = true,
        };
    }

    private void ClearRowsAndDetails()
    {
        _rowListBox.Items.Clear();
        ClearDetails();
    }

    private void ClearDetails()
    {
        _loadingDetails = true;
        try
        {
            _detailGrid.Columns.Clear();
            _detailGrid.Rows.Clear();
            ConfigureDetailColumns();
        }
        finally
        {
            _loadingDetails = false;
        }
    }

    private void InitializeSplitterDistance()
    {
        if (_splitterInitialized)
        {
            return;
        }

        const int panel1MinSize = 260;
        const int panel2MinSize = 260;
        if (_splitContainer.Width < panel1MinSize + panel2MinSize)
        {
            return;
        }

        _splitContainer.Panel1MinSize = panel1MinSize;
        _splitContainer.Panel2MinSize = panel2MinSize;
        _splitContainer.SplitterDistance = Math.Min(340, _splitContainer.Width - panel2MinSize);
        _splitterInitialized = true;
    }

    private bool ConfirmDiscardDirtyChanges(string message)
    {
        if (!_isDirty)
        {
            return true;
        }

        var result = MessageBox.Show(
            this,
            message,
            "未保存修改",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2);
        return result == DialogResult.Yes;
    }

    private void UpdateActionButtons()
    {
        var hasFile = TryGetCurrentFilePath(out _);
        _openTableDirectoryButton.Enabled = hasFile;
        _openTableDirectoryButton.Cursor = hasFile ? Cursors.Hand : Cursors.Default;

        _saveButton.Enabled = _document is not null && _isDirty;
        UpdateSaveButtonStyle();
    }

    private void UpdateSaveButtonStyle()
    {
        if (_saveButton.Enabled)
        {
            _saveButton.BackColor = AccentColor;
            _saveButton.ForeColor = Color.White;
            _saveButton.Cursor = Cursors.Hand;
            _saveButton.FlatAppearance.BorderColor = AccentColor;
            _saveButton.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#0B5CAD");
            _saveButton.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#0B5CAD");
            return;
        }

        _saveButton.BackColor = DisabledButtonBg;
        _saveButton.ForeColor = DisabledButtonTextColor;
        _saveButton.Cursor = Cursors.Default;
        _saveButton.FlatAppearance.BorderColor = DisabledButtonBorderColor;
        _saveButton.FlatAppearance.MouseOverBackColor = DisabledButtonBg;
        _saveButton.FlatAppearance.MouseDownBackColor = DisabledButtonBg;
    }

    private void SetStatus(string text)
    {
        _statusLabel.Text = text;
    }

    private static Label BuildLabel(string text)
    {
        return new Label
        {
            Text = text,
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleLeft,
            ForeColor = MutedTextColor,
            AutoSize = false,
        };
    }

    private static void ConfigureButton(Button button, string text, bool accent = false)
    {
        button.Text = text;
        button.Dock = DockStyle.Fill;
        button.Margin = new Padding(4, 0, 0, 0);
        button.FlatStyle = FlatStyle.Flat;
        button.BackColor = accent ? AccentColor : PanelBg;
        button.ForeColor = accent ? Color.White : TextColor;
        button.Cursor = Cursors.Hand;
        button.FlatAppearance.BorderColor = accent ? AccentColor : BorderColor;
        button.FlatAppearance.MouseOverBackColor = accent ? ColorTranslator.FromHtml("#0B5CAD") : ColorTranslator.FromHtml("#F2F6FC");
        button.FlatAppearance.MouseDownBackColor = accent ? ColorTranslator.FromHtml("#0B5CAD") : HeaderBg;
    }

    private static void DrawPanelBorder(object? sender, PaintEventArgs e)
    {
        if (sender is not Control control)
        {
            return;
        }

        using var pen = new Pen(BorderColor);
        e.Graphics.DrawRectangle(pen, 0, 0, control.Width - 1, control.Height - 1);
    }

    private sealed class DisplayColumnItem
    {
        public DisplayColumnItem(TabTableColumn column)
        {
            Column = column;
        }

        public TabTableColumn Column { get; }

        public override string ToString()
        {
            return $"第{Column.Index + 1}列 - {Column.Title}";
        }
    }

    private sealed class RowListItem
    {
        public RowListItem(TabTableRow row, string text)
        {
            Row = row;
            Text = text;
        }

        public TabTableRow Row { get; }

        public string Text { get; }

        public override string ToString()
        {
            return Text;
        }
    }
}
