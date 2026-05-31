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
    private const int SearchControlHeight = 24;
    private const int DetailGridRowHeight = 30;
    private const int ExpandedValueEditorPadding = 8;
    private const int ExpandedValueEditorBottomMargin = 2;
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
    private static readonly Color SearchMatchHighlightColor = ColorTranslator.FromHtml("#FFF2A8");
    private static readonly Color DisabledButtonBg = ColorTranslator.FromHtml("#E5E7EB");
    private static readonly Color DisabledButtonTextColor = ColorTranslator.FromHtml("#8A8A8A");
    private static readonly Color DisabledButtonBorderColor = ColorTranslator.FromHtml("#CBD5E1");

    private readonly TextBox _filePathTextBox = new();
    private readonly Button _browseButton = new();
    private readonly Button _reloadButton = new();
    private readonly ComboBox _displayColumnComboBox = new();
    private readonly SplitContainer _splitContainer = new();
    private readonly TextBox _rowSearchTextBox = new();
    private readonly Button _clearSearchButton = new();
    private readonly ListBox _rowListBox = new();
    private readonly DataGridView _detailGrid = new();
    private readonly TextBox _expandedValueEditorTextBox = new();
    private readonly Button _openTableDirectoryButton = new();
    private readonly Button _saveButton = new();
    private readonly ToolStripStatusLabel _statusLabel = new();

    private TabTableDocument? _document;
    private bool _isDirty;
    private bool _loadingRows;
    private bool _loadingDetails;
    private bool _splitterInitialized;
    private bool _committingExpandedValueEditor;
    private int _expandedValueEditorRowIndex = -1;
    private int _expandedValueEditorColumnIndex = -1;
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
        BuildSearchBar(root);
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

    private void BuildSearchBar(TableLayoutPanel root)
    {
        var searchBar = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 3,
            RowCount = 1,
            BackColor = WindowBg,
            Margin = new Padding(10, 0, 10, 8),
        };
        searchBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56));
        searchBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        searchBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40));
        searchBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        root.Controls.Add(searchBar, 0, 1);

        _rowSearchTextBox.Name = "RowSearchTextBox";
        _rowSearchTextBox.Dock = DockStyle.Fill;
        _rowSearchTextBox.Height = SearchControlHeight;
        _rowSearchTextBox.Margin = new Padding(0, 2, 0, 2);
        _rowSearchTextBox.BorderStyle = BorderStyle.FixedSingle;
        _rowSearchTextBox.PlaceholderText = "搜索内容，可用空格隔开多个关键字";
        _rowSearchTextBox.TextChanged += (_, _) => RowSearchTextBoxTextChanged();

        var searchLabel = BuildLabel("搜索");
        searchLabel.Dock = DockStyle.None;
        searchLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        searchLabel.Height = SearchControlHeight;
        searchLabel.Margin = new Padding(0, 2, 0, 2);
        searchBar.Controls.Add(searchLabel, 0, 0);
        searchBar.Controls.Add(_rowSearchTextBox, 1, 0);

        ConfigureButton(_clearSearchButton, "×");
        _clearSearchButton.Name = "ClearSearchButton";
        _clearSearchButton.Dock = DockStyle.None;
        _clearSearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _clearSearchButton.Height = SearchControlHeight;
        _clearSearchButton.Font = new Font(Font, FontStyle.Bold);
        _clearSearchButton.Padding = new Padding(0, 0, 0, 2);
        _clearSearchButton.TextAlign = ContentAlignment.MiddleCenter;
        _clearSearchButton.Margin = new Padding(4, 2, 0, 2);
        _clearSearchButton.Click += (_, _) => _rowSearchTextBox.Clear();
        searchBar.Controls.Add(_clearSearchButton, 2, 0);
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

        rowListPanel.Controls.Add(BuildDisplayColumnPanel(), 0, 0);

        _rowListBox.Dock = DockStyle.Fill;
        _rowListBox.Margin = Padding.Empty;
        _rowListBox.BorderStyle = BorderStyle.FixedSingle;
        _rowListBox.BackColor = PanelBg;
        _rowListBox.ForeColor = TextColor;
        _rowListBox.IntegralHeight = false;
        _rowListBox.SelectedIndexChanged += (_, _) => RenderSelectedRow();
        rowListPanel.Controls.Add(_rowListBox, 0, 1);
    }

    private TableLayoutPanel BuildDisplayColumnPanel()
    {
        var displayColumnPanel = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 2,
            RowCount = 1,
            BackColor = WindowBg,
            Margin = new Padding(0, 0, 0, 6),
        };
        displayColumnPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62));
        displayColumnPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        displayColumnPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

        displayColumnPanel.Controls.Add(BuildLabel("显示列"), 0, 0);

        _displayColumnComboBox.Name = "DisplayColumnComboBox";
        _displayColumnComboBox.Dock = DockStyle.Fill;
        _displayColumnComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        _displayColumnComboBox.Margin = new Padding(0, 2, 0, 2);
        _displayColumnComboBox.Enabled = false;
        _displayColumnComboBox.SelectedIndexChanged += (_, _) => DisplayColumnComboBoxSelectedIndexChanged();
        displayColumnPanel.Controls.Add(_displayColumnComboBox, 1, 0);

        return displayColumnPanel;
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
        _detailGrid.RowTemplate.Height = DetailGridRowHeight;
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
        _detailGrid.CellPainting += DetailGridCellPainting;
        ConfigureExpandedValueEditor();
        _splitContainer.Panel2.Controls.Add(_detailGrid);
    }

    private void ConfigureExpandedValueEditor()
    {
        _expandedValueEditorTextBox.Name = "ExpandedValueEditorTextBox";
        _expandedValueEditorTextBox.Visible = false;
        _expandedValueEditorTextBox.Multiline = true;
        _expandedValueEditorTextBox.WordWrap = true;
        _expandedValueEditorTextBox.AcceptsReturn = false;
        _expandedValueEditorTextBox.AcceptsTab = false;
        _expandedValueEditorTextBox.BorderStyle = BorderStyle.FixedSingle;
        _expandedValueEditorTextBox.BackColor = PanelBg;
        _expandedValueEditorTextBox.ForeColor = TextColor;
        _expandedValueEditorTextBox.ScrollBars = ScrollBars.None;
        _expandedValueEditorTextBox.KeyDown += ExpandedValueEditorTextBoxKeyDown;
        _expandedValueEditorTextBox.Leave += (_, _) => CommitExpandedValueEditor();
        _detailGrid.Controls.Add(_expandedValueEditorTextBox);
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

    private void RowSearchTextBoxTextChanged()
    {
        RenderRows(selectFirstWhenAvailable: true);
        _detailGrid.Invalidate();
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

            var searchKeywords = BuildSearchKeywords(_rowSearchTextBox.Text);
            foreach (var row in _document.DataRows)
            {
                var item = new RowListItem(row, _document.BuildRowListText(row, _displayColumnIndex));
                if (RowMatchesSearch(row, searchKeywords))
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

    private static bool RowMatchesSearch(TabTableRow row, IReadOnlyList<string> searchKeywords)
    {
        foreach (var keyword in searchKeywords)
        {
            var matched = row.Cells.Any(cell => cell.Contains(keyword, StringComparison.OrdinalIgnoreCase));
            if (!matched)
            {
                return false;
            }
        }

        return true;
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
            HideExpandedValueEditor();
            _detailGrid.Columns.Clear();
            _detailGrid.Rows.Clear();
            ConfigureDetailColumns();

            foreach (var column in _document.Columns)
            {
                var rowIndex = _detailGrid.Rows.Add();
                var gridRow = _detailGrid.Rows[rowIndex];
                gridRow.Tag = column.Index;

                var gridColumnIndex = 0;
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

        e.Cancel = true;
        if (_detailGrid.Columns[e.ColumnIndex].Name == "Value")
        {
            ShowExpandedValueEditor(e.RowIndex, e.ColumnIndex);
        }
    }

    private void DetailGridCellEndEdit(object? sender, DataGridViewCellEventArgs e)
    {
        _detailGrid.Rows[e.RowIndex].ErrorText = string.Empty;
    }

    private void ShowExpandedValueEditor(int rowIndex, int columnIndex)
    {
        if (_document is null ||
            rowIndex < 0 ||
            rowIndex >= _detailGrid.Rows.Count ||
            columnIndex < 0 ||
            columnIndex >= _detailGrid.Columns.Count)
        {
            HideExpandedValueEditor();
            return;
        }

        _expandedValueEditorRowIndex = rowIndex;
        _expandedValueEditorColumnIndex = columnIndex;

        var text = Convert.ToString(_detailGrid.Rows[rowIndex].Cells[columnIndex].Value) ?? string.Empty;
        var bounds = CalculateExpandedValueEditorBounds(rowIndex, columnIndex, text);
        var requiredHeight = CalculateExpandedValueEditorRequiredHeight(text, _detailGrid.Font, bounds.Width);

        _expandedValueEditorTextBox.Font = _detailGrid.Font;
        _expandedValueEditorTextBox.Text = text;
        _expandedValueEditorTextBox.Bounds = bounds;
        _expandedValueEditorTextBox.ScrollBars = requiredHeight > bounds.Height ? ScrollBars.Vertical : ScrollBars.None;
        _expandedValueEditorTextBox.Visible = true;
        _expandedValueEditorTextBox.BringToFront();
        _expandedValueEditorTextBox.Focus();
        _expandedValueEditorTextBox.SelectionStart = _expandedValueEditorTextBox.TextLength;
        _expandedValueEditorTextBox.SelectionLength = 0;
    }

    private Rectangle CalculateExpandedValueEditorBounds(int rowIndex, int columnIndex, string text)
    {
        var cellBounds = GetValueCellDisplayBounds(rowIndex, columnIndex);
        var requiredHeight = CalculateExpandedValueEditorRequiredHeight(text, _detailGrid.Font, cellBounds.Width);
        var availableHeight = Math.Max(
            cellBounds.Height,
            _detailGrid.ClientSize.Height - cellBounds.Top - ExpandedValueEditorBottomMargin);
        var height = Math.Clamp(requiredHeight, cellBounds.Height, availableHeight);

        return new Rectangle(cellBounds.Left, cellBounds.Top, cellBounds.Width, height);
    }

    private Rectangle GetValueCellDisplayBounds(int rowIndex, int columnIndex)
    {
        var cellBounds = _detailGrid.GetCellDisplayRectangle(columnIndex, rowIndex, cutOverflow: false);
        if (cellBounds.Width > 0 && cellBounds.Height > 0)
        {
            return cellBounds;
        }

        var left = 0;
        for (var index = 0; index < columnIndex; index++)
        {
            left += _detailGrid.Columns[index].Width;
        }

        var rowHeight = rowIndex >= 0 && rowIndex < _detailGrid.Rows.Count
            ? _detailGrid.Rows[rowIndex].Height
            : DetailGridRowHeight;
        return new Rectangle(
            left,
            _detailGrid.ColumnHeadersHeight + (rowIndex * rowHeight),
            Math.Max(1, _detailGrid.Columns[columnIndex].Width),
            rowHeight);
    }

    private bool CommitExpandedValueEditor()
    {
        if (!IsExpandedValueEditorActive() || _committingExpandedValueEditor)
        {
            return true;
        }

        _committingExpandedValueEditor = true;
        try
        {
            return CommitExpandedValueEditorCore();
        }
        finally
        {
            _committingExpandedValueEditor = false;
        }
    }

    private bool CommitExpandedValueEditorCore()
    {
        if (_document is null ||
            _expandedValueEditorRowIndex < 0 ||
            _expandedValueEditorRowIndex >= _detailGrid.Rows.Count ||
            _expandedValueEditorColumnIndex < 0 ||
            _expandedValueEditorColumnIndex >= _detailGrid.Columns.Count ||
            _detailGrid.Rows[_expandedValueEditorRowIndex].Tag is not int tableColumnIndex ||
            _rowListBox.SelectedItem is not RowListItem selectedItem)
        {
            HideExpandedValueEditor();
            return true;
        }

        var value = _expandedValueEditorTextBox.Text;
        if (value == TabTableDocument.GetCellValue(selectedItem.Row, tableColumnIndex))
        {
            HideExpandedValueEditor();
            return true;
        }

        try
        {
            _document.SetCellValue(selectedItem.Row, tableColumnIndex, value);
            _detailGrid.Rows[_expandedValueEditorRowIndex].Cells[_expandedValueEditorColumnIndex].Value = value;
            _isDirty = true;
            HideExpandedValueEditor();
            UpdateActionButtons();
            RenderRows(selectFirstWhenAvailable: true, preferredRow: selectedItem.Row);
            SetStatus("存在未保存修改。");
            return true;
        }
        catch (ArgumentException ex)
        {
            _detailGrid.Rows[_expandedValueEditorRowIndex].ErrorText = ex.Message;
            MessageBox.Show(this, ex.Message, "内容无效", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            _expandedValueEditorTextBox.Focus();
            return false;
        }
    }

    private void HideExpandedValueEditor()
    {
        _expandedValueEditorRowIndex = -1;
        _expandedValueEditorColumnIndex = -1;
        _expandedValueEditorTextBox.Visible = false;
        _expandedValueEditorTextBox.Text = string.Empty;
    }

    private bool IsExpandedValueEditorActive()
    {
        return _expandedValueEditorRowIndex >= 0 && _expandedValueEditorColumnIndex >= 0;
    }

    private void ExpandedValueEditorTextBoxKeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            CommitExpandedValueEditor();
        }
        else if (e.KeyCode == Keys.Escape)
        {
            e.SuppressKeyPress = true;
            HideExpandedValueEditor();
            _detailGrid.Focus();
        }
    }

    private void DetailGridCellValueChanged(object? sender, DataGridViewCellEventArgs e)
    {
        if (_loadingDetails ||
            _committingExpandedValueEditor ||
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

    private static int CalculateExpandedValueEditorRequiredHeight(string text, Font font, int editorWidth)
    {
        var measureText = string.IsNullOrEmpty(text) ? " " : text;
        var measureWidth = Math.Max(1, editorWidth - ExpandedValueEditorPadding);
        var measured = TextRenderer.MeasureText(
            measureText,
            font,
            new Size(measureWidth, 10000),
            TextFormatFlags.WordBreak | TextFormatFlags.TextBoxControl | TextFormatFlags.NoPrefix);
        return Math.Max(DetailGridRowHeight, measured.Height + ExpandedValueEditorPadding);
    }

    private void DetailGridCellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
    {
        var graphics = e.Graphics;
        var cellStyle = e.CellStyle;
        if (e.RowIndex < 0 || e.ColumnIndex < 0 || graphics is null || cellStyle is null)
        {
            return;
        }

        var ranges = GetDetailSearchMatchRanges(e.RowIndex, e.ColumnIndex);
        if (ranges.Count == 0)
        {
            return;
        }

        PaintDetailValueCellWithSearchHighlight(e, graphics, cellStyle, ranges);
        e.Handled = true;
    }

    private IReadOnlyList<(int Start, int Length)> GetDetailSearchMatchRanges(int rowIndex, int columnIndex)
    {
        if (rowIndex < 0 ||
            rowIndex >= _detailGrid.Rows.Count ||
            columnIndex < 0 ||
            columnIndex >= _detailGrid.Columns.Count ||
            _detailGrid.Columns[columnIndex].Name != "Value")
        {
            return Array.Empty<(int Start, int Length)>();
        }

        var searchKeywords = BuildSearchKeywords(_rowSearchTextBox.Text);
        if (searchKeywords.Count == 0)
        {
            return Array.Empty<(int Start, int Length)>();
        }

        var value = Convert.ToString(_detailGrid.Rows[rowIndex].Cells[columnIndex].Value) ?? string.Empty;
        return FindSearchMatchRanges(value, searchKeywords);
    }

    private static IReadOnlyList<(int Start, int Length)> FindSearchMatchRanges(
        string value,
        IReadOnlyList<string> searchKeywords)
    {
        if (value.Length == 0 || searchKeywords.Count == 0)
        {
            return Array.Empty<(int Start, int Length)>();
        }

        var ranges = new List<(int Start, int Length)>();
        foreach (var keyword in searchKeywords)
        {
            var startIndex = 0;
            while (startIndex < value.Length)
            {
                var matchIndex = value.IndexOf(keyword, startIndex, StringComparison.OrdinalIgnoreCase);
                if (matchIndex < 0)
                {
                    break;
                }

                ranges.Add((matchIndex, keyword.Length));
                startIndex = matchIndex + Math.Max(keyword.Length, 1);
            }
        }

        return ranges
            .OrderBy(range => range.Start)
            .ThenByDescending(range => range.Length)
            .ToList();
    }

    private void PaintDetailValueCellWithSearchHighlight(
        DataGridViewCellPaintingEventArgs e,
        Graphics graphics,
        DataGridViewCellStyle cellStyle,
        IReadOnlyList<(int Start, int Length)> ranges)
    {
        e.Paint(e.ClipBounds, e.PaintParts & ~DataGridViewPaintParts.ContentForeground);

        var text = Convert.ToString(e.FormattedValue) ?? string.Empty;
        var textBounds = GetDetailCellTextBounds(e.CellBounds, cellStyle);
        DrawSearchMatchHighlights(graphics, text, cellStyle.Font ?? Font, textBounds, ranges);

        TextRenderer.DrawText(
            graphics,
            text,
            cellStyle.Font ?? Font,
            textBounds,
            cellStyle.ForeColor,
            TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPrefix);
    }

    private static Rectangle GetDetailCellTextBounds(Rectangle cellBounds, DataGridViewCellStyle cellStyle)
    {
        var padding = cellStyle.Padding;
        return new Rectangle(
            cellBounds.Left + padding.Left + 4,
            cellBounds.Top + padding.Top + 2,
            Math.Max(0, cellBounds.Width - padding.Horizontal - 8),
            Math.Max(0, cellBounds.Height - padding.Vertical - 4));
    }

    private static void DrawSearchMatchHighlights(
        Graphics graphics,
        string text,
        Font font,
        Rectangle textBounds,
        IReadOnlyList<(int Start, int Length)> ranges)
    {
        if (text.Length == 0 || ranges.Count == 0 || textBounds.Width <= 0 || textBounds.Height <= 0)
        {
            return;
        }

        using var brush = new SolidBrush(SearchMatchHighlightColor);
        foreach (var range in ranges)
        {
            if (range.Start < 0 || range.Length <= 0 || range.Start >= text.Length)
            {
                continue;
            }

            var safeLength = Math.Min(range.Length, text.Length - range.Start);
            var before = text[..range.Start];
            var match = text.Substring(range.Start, safeLength);
            var x = textBounds.Left + MeasureDetailTextWidth(graphics, before, font);
            var width = Math.Max(2, MeasureDetailTextWidth(graphics, match, font));
            var highlightBounds = new Rectangle(
                x,
                textBounds.Top + 2,
                Math.Min(width, Math.Max(0, textBounds.Right - x)),
                Math.Max(0, textBounds.Height - 4));
            if (highlightBounds.Width > 0 && highlightBounds.Height > 0)
            {
                graphics.FillRectangle(brush, highlightBounds);
            }
        }
    }

    private static int MeasureDetailTextWidth(Graphics graphics, string text, Font font)
    {
        if (text.Length == 0)
        {
            return 0;
        }

        return TextRenderer.MeasureText(
            graphics,
            text,
            font,
            Size.Empty,
            TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix).Width;
    }

    private static IReadOnlyList<string> BuildSearchKeywords(string searchText)
    {
        if (string.IsNullOrWhiteSpace(searchText))
        {
            return Array.Empty<string>();
        }

        var keywords = new List<string>();
        var startIndex = -1;
        for (var index = 0; index < searchText.Length; index++)
        {
            if (char.IsWhiteSpace(searchText[index]))
            {
                if (startIndex >= 0)
                {
                    keywords.Add(searchText[startIndex..index]);
                    startIndex = -1;
                }
            }
            else if (startIndex < 0)
            {
                startIndex = index;
            }
        }

        if (startIndex >= 0)
        {
            keywords.Add(searchText[startIndex..]);
        }

        return keywords;
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
        HideExpandedValueEditor();
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
