using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.Json;
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
    private static readonly Color CurrentCellBorderColor = AccentColor;
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
    private readonly ListBox _rowListBox = new();
    private readonly DetailDataGridView _detailGrid = new();
    private readonly ExpandedTextBox _expandedValueEditorTextBox = new();
    private readonly Button _timeFieldButton = new();
    private readonly Button _frameSelectButton = new();
    private readonly Button _richTextButton = new();
    private readonly Button _openTableDirectoryButton = new();
    private readonly Button _saveButton = new();
    private readonly Button _insertRowButton = new();
    private readonly Button _deleteRowButton = new();
    private readonly ContextMenuStrip _rowListBoxContextMenu = new();
    private readonly ToolStripStatusLabel _statusLabel = new();
    private readonly Stack<DetailUndoAction> _undoStack = new();
    private readonly Dictionary<string, int> _detailGridColumnWidths = new();
    private readonly Button _titleRowSelectorButton = new();
    private readonly CheckedListBox _titleRowCheckedListBox = new();
    private readonly ToolStripDropDown _titleRowDropDown = new();
    private readonly HashSet<int> _selectedTitleRowIndexes = new();
    private bool _updatingTitleRowSelection;

    private TabTableDocument? _document;
    private bool _isDirty;
    private bool _loadingRows;
    private bool _loadingDetails;
    private bool _splitterInitialized;
    private bool _committingExpandedValueEditor;
    private bool _handlingDetailCurrentCellChanged;
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
        TryLoadLastOpenedFile();
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
            ColumnCount = 1,
            RowCount = 1,
            BackColor = WindowBg,
            Margin = new Padding(10, 0, 10, 8),
        };
        searchBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        searchBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        root.Controls.Add(searchBar, 0, 1);

        _rowSearchTextBox.Name = "RowSearchTextBox";
        _rowSearchTextBox.Dock = DockStyle.Fill;
        _rowSearchTextBox.Height = SearchControlHeight;
        _rowSearchTextBox.Margin = new Padding(0, 2, 0, 2);
        _rowSearchTextBox.BorderStyle = BorderStyle.FixedSingle;
        _rowSearchTextBox.PlaceholderText = "搜索内容，可用空格隔开多个关键字";
        _rowSearchTextBox.TextChanged += (_, _) => RowSearchTextBoxTextChanged();

        searchBar.Controls.Add(_rowSearchTextBox, 0, 0);
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
        _splitContainer.Panel2.Padding = new Padding(0, 0, 6, 0);
    }

    private void BuildRowListPanel()
    {
        var rowListPanel = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 3,
            BackColor = WindowBg,
            Margin = new Padding(0),
        };
        rowListPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        rowListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
        rowListPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        rowListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42));
        _splitContainer.Panel1.Controls.Add(rowListPanel);

        rowListPanel.Controls.Add(BuildDisplayColumnPanel(), 0, 0);

        _rowListBox.Dock = DockStyle.Fill;
        _rowListBox.Margin = Padding.Empty;
        _rowListBox.BorderStyle = BorderStyle.FixedSingle;
        _rowListBox.BackColor = PanelBg;
        _rowListBox.ForeColor = TextColor;
        _rowListBox.IntegralHeight = false;
        _rowListBox.SelectedIndexChanged += (_, _) =>
        {
            RenderSelectedRow();
            UpdateActionButtons();
        };
        rowListPanel.Controls.Add(_rowListBox, 0, 1);

        var insertItem = new ToolStripMenuItem("在下方插入");
        insertItem.Click += (_, _) => InsertRowBelow();
        _rowListBoxContextMenu.Items.Add(insertItem);
        _rowListBoxContextMenu.Opening += (_, _) =>
        {
            insertItem.Enabled = _document is not null && _rowListBox.SelectedItem is RowListItem;
        };
        _rowListBox.ContextMenuStrip = _rowListBoxContextMenu;

        var buttonPanel = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 2,
            RowCount = 1,
            Margin = new Padding(0, 4, 0, 0),
            Padding = Padding.Empty,
            BackColor = WindowBg,
        };
        buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        buttonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

        ConfigureButton(_insertRowButton, "在下方插入");
        _insertRowButton.AutoSize = false;
        _insertRowButton.Dock = DockStyle.Fill;
        _insertRowButton.Margin = Padding.Empty;
        _insertRowButton.TextAlign = ContentAlignment.MiddleCenter;
        _insertRowButton.Padding = new Padding(4, 0, 4, 0);
        _insertRowButton.Click += (_, _) => InsertRowBelow();
        buttonPanel.Controls.Add(_insertRowButton, 0, 0);

        ConfigureButton(_deleteRowButton, "删除");
        _deleteRowButton.AutoSize = true;
        _deleteRowButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        _deleteRowButton.Dock = DockStyle.Left;
        _deleteRowButton.TextAlign = ContentAlignment.MiddleCenter;
        _deleteRowButton.Padding = new Padding(4, 0, 4, 0);
        _deleteRowButton.Click += (_, _) => DeleteSelectedRow();
        buttonPanel.Controls.Add(_deleteRowButton, 1, 0);

        rowListPanel.Controls.Add(buttonPanel, 0, 2);
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
        displayColumnPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 78));
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
        _detailGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
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
        _detailGrid.CellDoubleClick += DetailGridCellDoubleClick;
        _detailGrid.CellEndEdit += DetailGridCellEndEdit;
        _detailGrid.CellPainting += DetailGridCellPainting;
        _detailGrid.ColumnWidthChanged += DetailGridColumnWidthChanged;
        _detailGrid.KeyDown += DetailGridKeyDown;
        _detailGrid.KeyPress += DetailGridKeyPress;
        _detailGrid.CurrentCellChanged += DetailGridCurrentCellChanged;
        _detailGrid.Scroll += DetailGridScroll;
        ConfigureExpandedValueEditor();

        var detailPanel = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 2,
            Margin = Padding.Empty,
            Padding = Padding.Empty,
        };
        detailPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        detailPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
        detailPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        detailPanel.Controls.Add(BuildTitleRowSelectorPanel(), 0, 0);
        detailPanel.Controls.Add(_detailGrid, 0, 1);
        _splitContainer.Panel2.Controls.Add(detailPanel);
    }

    private TableLayoutPanel BuildTitleRowSelectorPanel()
    {
        var panel = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 2,
            RowCount = 1,
            BackColor = WindowBg,
            Margin = new Padding(0, 0, 0, 4),
        };
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 78));
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

        panel.Controls.Add(BuildLabel("标题行"), 0, 0);

        _titleRowSelectorButton.Text = "未选择";
        _titleRowSelectorButton.Dock = DockStyle.Fill;
        _titleRowSelectorButton.FlatStyle = FlatStyle.Flat;
        _titleRowSelectorButton.BackColor = PanelBg;
        _titleRowSelectorButton.ForeColor = TextColor;
        _titleRowSelectorButton.FlatAppearance.BorderColor = BorderColor;
        _titleRowSelectorButton.Margin = new Padding(0, 0, 0, 0);
        _titleRowSelectorButton.TextAlign = ContentAlignment.MiddleLeft;
        _titleRowSelectorButton.Padding = new Padding(6, 0, 6, 0);
        _titleRowSelectorButton.Enabled = false;
        _titleRowSelectorButton.Click += (_, _) => ShowTitleRowDropDown();
        panel.Controls.Add(_titleRowSelectorButton, 1, 0);

        ConfigureTitleRowDropDown();
        return panel;
    }

    private void ConfigureTitleRowDropDown()
    {
        _titleRowCheckedListBox.CheckOnClick = true;
        _titleRowCheckedListBox.ItemCheck += TitleRowCheckedListBoxItemCheck;

        var host = new ToolStripControlHost(_titleRowCheckedListBox)
        {
            AutoSize = false,
            Size = new Size(580, 380),
            Margin = Padding.Empty,
            Padding = Padding.Empty,
        };
        _titleRowDropDown.Items.Add(host);
        _titleRowDropDown.AutoSize = false;
        _titleRowDropDown.Width = 500;
        _titleRowDropDown.Height = 300;
        _titleRowDropDown.Opening += (_, _) =>
        {
            host.Size = new Size(_titleRowDropDown.Width, _titleRowDropDown.Height);
            _titleRowCheckedListBox.Size = host.Size;
        };
    }

    private void ShowTitleRowDropDown()
    {
        if (!_titleRowSelectorButton.Enabled)
        {
            return;
        }

        _titleRowDropDown.Show(_titleRowSelectorButton, new Point(0, _titleRowSelectorButton.Height));
    }

    private void PopulateTitleRowSelector()
    {
        _titleRowCheckedListBox.Items.Clear();
        _selectedTitleRowIndexes.Clear();

        if (_document is null || _document.Rows.Count == 0)
        {
            _titleRowSelectorButton.Enabled = false;
            _titleRowSelectorButton.Text = "未选择";
            return;
        }

        _updatingTitleRowSelection = true;
        try
        {
            var maxRowIndex = Math.Min(_document.Rows.Count, 10);
            for (var i = 0; i < maxRowIndex; i++)
            {
                var row = _document.Rows[i];
                var isPreamble = i < _document.DataStartRowIndex;
                _titleRowCheckedListBox.Items.Add(new DisplayRowItem(row), isPreamble);
                if (isPreamble)
                {
                    _selectedTitleRowIndexes.Add(i);
                }
            }
        }
        finally
        {
            _updatingTitleRowSelection = false;
        }

        _titleRowSelectorButton.Enabled = true;
        UpdateTitleRowSelectorButtonText();
    }

    private void ClearTitleRowSelector()
    {
        _titleRowCheckedListBox.Items.Clear();
        _selectedTitleRowIndexes.Clear();
        _titleRowSelectorButton.Enabled = false;
        _titleRowSelectorButton.Text = "未选择";
    }

    private void TitleRowCheckedListBoxItemCheck(object? sender, ItemCheckEventArgs e)
    {
        if (_updatingTitleRowSelection)
        {
            return;
        }

        _updatingTitleRowSelection = true;
        BeginInvoke(() =>
        {
            _updatingTitleRowSelection = false;
            _selectedTitleRowIndexes.Clear();
            for (var i = 0; i < _titleRowCheckedListBox.CheckedItems.Count; i++)
            {
                if (_titleRowCheckedListBox.CheckedItems[i] is DisplayRowItem item)
                {
                    _selectedTitleRowIndexes.Add(item.Row.RowIndex);
                }
            }

            var currentIndex = e.Index;
            var currentChecked = e.NewValue == CheckState.Checked;
            if (_titleRowCheckedListBox.Items[currentIndex] is DisplayRowItem currentItem)
            {
                if (currentChecked)
                {
                    _selectedTitleRowIndexes.Add(currentItem.Row.RowIndex);
                }
                else
                {
                    _selectedTitleRowIndexes.Remove(currentItem.Row.RowIndex);
                }
            }

            UpdateTitleRowSelectorButtonText();
            RenderSelectedRow();
        });
    }

    private void UpdateTitleRowSelectorButtonText()
    {
        var count = _selectedTitleRowIndexes.Count;
        if (count == 0)
        {
            _titleRowSelectorButton.Text = "未选择";
            return;
        }

        var selectedNames = _titleRowCheckedListBox.CheckedItems
            .Cast<DisplayRowItem>()
            .Select(item => $"第{item.Row.RowIndex + 1}行")
            .ToList();

        _titleRowSelectorButton.Text = string.Join(", ", selectedNames);
    }

    private IEnumerable<int> GetSelectedTitleRowIndexesInDocumentOrder()
    {
        if (_document is null)
        {
            yield break;
        }

        var maxRowIndex = Math.Min(_document.Rows.Count, 10);
        for (var i = 0; i < maxRowIndex; i++)
        {
            if (_selectedTitleRowIndexes.Contains(i))
            {
                yield return i;
            }
        }
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
        _expandedValueEditorTextBox.Leave += (_, _) =>
        {
            if (_handlingDetailCurrentCellChanged || _committingExpandedValueEditor || !IsExpandedValueEditorActive())
                return;
            CommitExpandedValueEditor();
        };
        _detailGrid.Controls.Add(_expandedValueEditorTextBox);
        _detailGrid.GetExpandedEditor = () => _expandedValueEditorTextBox;
        ConfigureTimeFieldButton();
        ConfigureFrameSelectButton();
        ConfigureRichTextButton();
    }

    private static readonly HashSet<string> TimeFieldNames = new(StringComparer.OrdinalIgnoreCase)
    {
        "nPreTime",
        "szStartTime",
        "szEndTime",
        "nResTime",
    };

    private static readonly HashSet<string> FrameSelectFieldNames = new(StringComparer.OrdinalIgnoreCase)
    {
        "dwNormalFrame",
        "dwHighLightFrame",
    };

    private static readonly HashSet<string> RichTextFieldNames = new(StringComparer.OrdinalIgnoreCase)
    {
        "szActivityExplain",
    };

    private void ConfigureTimeFieldButton()
    {
        _timeFieldButton.Text = "设置";
        _timeFieldButton.Visible = false;
        _timeFieldButton.FlatStyle = FlatStyle.Flat;
        _timeFieldButton.BackColor = AccentColor;
        _timeFieldButton.ForeColor = Color.White;
        _timeFieldButton.FlatAppearance.BorderColor = AccentColor;
        _timeFieldButton.Font = new Font(Font.FontFamily, 9F, FontStyle.Regular);
        _timeFieldButton.AutoSize = true;
        _timeFieldButton.AutoSizeMode = AutoSizeMode.GrowOnly;
        _timeFieldButton.MinimumSize = new Size(50, DetailGridRowHeight);
        _timeFieldButton.Cursor = Cursors.Hand;
        _timeFieldButton.Click += (_, _) => OpenTimePickerDialog();
        _detailGrid.Controls.Add(_timeFieldButton);
    }

    private void ConfigureFrameSelectButton()
    {
        _frameSelectButton.Text = "选择";
        _frameSelectButton.Visible = false;
        _frameSelectButton.FlatStyle = FlatStyle.Flat;
        _frameSelectButton.BackColor = AccentColor;
        _frameSelectButton.ForeColor = Color.White;
        _frameSelectButton.FlatAppearance.BorderColor = AccentColor;
        _frameSelectButton.Font = new Font(Font.FontFamily, 9F, FontStyle.Regular);
        _frameSelectButton.AutoSize = true;
        _frameSelectButton.AutoSizeMode = AutoSizeMode.GrowOnly;
        _frameSelectButton.MinimumSize = new Size(50, DetailGridRowHeight);
        _frameSelectButton.Cursor = Cursors.Hand;
        _frameSelectButton.Click += (_, _) => OpenFrameSelectorDialog();
        _detailGrid.Controls.Add(_frameSelectButton);
    }

    private void ConfigureRichTextButton()
    {
        _richTextButton.Text = "设置";
        _richTextButton.Visible = false;
        _richTextButton.FlatStyle = FlatStyle.Flat;
        _richTextButton.BackColor = AccentColor;
        _richTextButton.ForeColor = Color.White;
        _richTextButton.FlatAppearance.BorderColor = AccentColor;
        _richTextButton.Font = new Font(Font.FontFamily, 9F, FontStyle.Regular);
        _richTextButton.AutoSize = true;
        _richTextButton.AutoSizeMode = AutoSizeMode.GrowOnly;
        _richTextButton.MinimumSize = new Size(50, DetailGridRowHeight);
        _richTextButton.Cursor = Cursors.Hand;
        _richTextButton.Click += (_, _) => OpenRichTextEditorDialog();
        _detailGrid.Controls.Add(_richTextButton);
    }

    private void UpdateTimeFieldButtonVisibility()
    {
        if (_document is null ||
            _detailGrid.CurrentCell is not { RowIndex: >= 0, ColumnIndex: >= 0 } currentCell ||
            _detailGrid.Columns[currentCell.ColumnIndex].Name != "Value" ||
            _detailGrid.Rows[currentCell.RowIndex].Tag is not int tableColumnIndex ||
            tableColumnIndex < 0 ||
            tableColumnIndex >= _document.Columns.Count ||
            !TimeFieldNames.Contains(_document.Columns[tableColumnIndex].Title))
        {
            HideTimeFieldButton();
            return;
        }

        ShowTimeFieldButton(currentCell.RowIndex);
    }

    private void ShowTimeFieldButton(int rowIndex)
    {
        if (rowIndex < 0 || rowIndex >= _detailGrid.Rows.Count)
        {
            HideTimeFieldButton();
            return;
        }

        _timeFieldButton.Visible = true;
        _timeFieldButton.BringToFront();
        UpdateTimeFieldButtonPosition();
    }

    private void UpdateTimeFieldButtonPosition()
    {
        if (!_timeFieldButton.Visible ||
            _detailGrid.CurrentCell is not { RowIndex: >= 0 } currentCell)
        {
            return;
        }

        var valueColumnIndex = _detailGrid.Columns.Count - 1;
        var cellBounds = GetValueCellDisplayBounds(currentCell.RowIndex, valueColumnIndex);
        var buttonWidth = _timeFieldButton.Width;

        _timeFieldButton.Location = new Point(
            cellBounds.Right - buttonWidth,
            cellBounds.Top);
    }

    private void HideTimeFieldButton()
    {
        _timeFieldButton.Visible = false;
    }

    private void UpdateFrameSelectButtonVisibility()
    {
        if (_document is null ||
            _detailGrid.CurrentCell is not { RowIndex: >= 0, ColumnIndex: >= 0 } currentCell ||
            _detailGrid.Columns[currentCell.ColumnIndex].Name != "Value" ||
            _detailGrid.Rows[currentCell.RowIndex].Tag is not int tableColumnIndex ||
            tableColumnIndex < 0 ||
            tableColumnIndex >= _document.Columns.Count ||
            !FrameSelectFieldNames.Contains(_document.Columns[tableColumnIndex].Title) ||
            !IsOperatActFile() ||
            string.IsNullOrWhiteSpace(GetSzLinkFrameValue()) ||
            !CanResolveFrameBasePath())
        {
            HideFrameSelectButton();
            return;
        }

        ShowFrameSelectButton(currentCell.RowIndex);
    }

    private bool IsOperatActFile()
    {
        if (_document is null) return false;
        var fileName = Path.GetFileName(_document.Path);
        return string.Equals(fileName, "OperatAct.txt", StringComparison.OrdinalIgnoreCase);
    }

    private bool CanResolveFrameBasePath()
    {
        if (_document is null) return false;
        var normalizedPath = _document.Path.Replace('/', '\\');
        return normalizedPath.Contains("client\\ui", StringComparison.OrdinalIgnoreCase);
    }

    private string GetSzLinkFrameValue()
    {
        if (_document is null || _rowListBox.SelectedItem is not RowListItem selectedItem)
            return string.Empty;

        var szLinkFrameIndex = FindColumnIndex(_document.Columns, "szLinkFrame");
        if (szLinkFrameIndex < 0)
            return string.Empty;

        return TabTableDocument.GetCellValue(selectedItem.Row, szLinkFrameIndex).Trim();
    }

    private static int FindColumnIndex(IReadOnlyList<TabTableColumn> columns, string title)
    {
        for (var i = 0; i < columns.Count; i++)
        {
            if (string.Equals(columns[i].Title, title, StringComparison.OrdinalIgnoreCase))
                return i;
        }
        return -1;
    }

    private void ShowFrameSelectButton(int rowIndex)
    {
        if (rowIndex < 0 || rowIndex >= _detailGrid.Rows.Count)
        {
            HideFrameSelectButton();
            return;
        }

        _frameSelectButton.Visible = true;
        _frameSelectButton.BringToFront();
        UpdateFrameSelectButtonPosition();
    }

    private void UpdateFrameSelectButtonPosition()
    {
        if (!_frameSelectButton.Visible ||
            _detailGrid.CurrentCell is not { RowIndex: >= 0 } currentCell)
        {
            return;
        }

        var valueColumnIndex = _detailGrid.Columns.Count - 1;
        var cellBounds = GetValueCellDisplayBounds(currentCell.RowIndex, valueColumnIndex);
        var buttonWidth = _frameSelectButton.Width;

        _frameSelectButton.Location = new Point(
            cellBounds.Right - buttonWidth,
            cellBounds.Top);
    }

    private void HideFrameSelectButton()
    {
        _frameSelectButton.Visible = false;
    }

    private void UpdateRichTextButtonVisibility()
    {
        if (_document is null ||
            _detailGrid.CurrentCell is not { RowIndex: >= 0, ColumnIndex: >= 0 } currentCell ||
            _detailGrid.Columns[currentCell.ColumnIndex].Name != "Value" ||
            _detailGrid.Rows[currentCell.RowIndex].Tag is not int tableColumnIndex ||
            tableColumnIndex < 0 ||
            tableColumnIndex >= _document.Columns.Count ||
            _rowListBox.SelectedItem is not RowListItem selectedItem)
        {
            HideRichTextButton();
            return;
        }

        var columnTitle = _document.Columns[tableColumnIndex].Title;
        var cellValue = TabTableDocument.GetCellValue(selectedItem.Row, tableColumnIndex);

        if (!RichTextFieldNames.Contains(columnTitle) &&
            !RichTextMarkup.LooksLikeRichText(cellValue))
        {
            HideRichTextButton();
            return;
        }

        ShowRichTextButton(currentCell.RowIndex);
    }

    private void ShowRichTextButton(int rowIndex)
    {
        if (rowIndex < 0 || rowIndex >= _detailGrid.Rows.Count)
        {
            HideRichTextButton();
            return;
        }

        _richTextButton.Visible = true;
        _richTextButton.BringToFront();
        UpdateRichTextButtonPosition();
    }

    private void UpdateRichTextButtonPosition()
    {
        if (!_richTextButton.Visible ||
            _detailGrid.CurrentCell is not { RowIndex: >= 0 } currentCell)
        {
            return;
        }

        var valueColumnIndex = _detailGrid.Columns.Count - 1;
        var cellBounds = GetValueCellDisplayBounds(currentCell.RowIndex, valueColumnIndex);
        var buttonWidth = _richTextButton.Width;

        _richTextButton.Location = new Point(
            cellBounds.Right - buttonWidth,
            cellBounds.Top);
    }

    private void HideRichTextButton()
    {
        _richTextButton.Visible = false;
    }

    private ElemSchemeLoader? _elemSchemeLoader;

    private ElemSchemeLoader? GetElemSchemeLoader()
    {
        if (_document is null) return null;
        var elemDir = ElemSchemeLoader.ResolveElemDirectory(_document.Path);
        if (elemDir is null) return null;

        if (_elemSchemeLoader is null || _elemSchemeLoader.ElemDirectory != elemDir)
        {
            _elemSchemeLoader = new ElemSchemeLoader(elemDir);
        }
        return _elemSchemeLoader;
    }

    private void OpenRichTextEditorDialog()
    {
        if (_document is null ||
            _detailGrid.CurrentCell is not { RowIndex: >= 0, ColumnIndex: >= 0 } currentCell ||
            _detailGrid.Columns[currentCell.ColumnIndex].Name != "Value" ||
            _detailGrid.Rows[currentCell.RowIndex].Tag is not int tableColumnIndex ||
            _rowListBox.SelectedItem is not RowListItem selectedItem)
        {
            return;
        }

        var loader = GetElemSchemeLoader();
        if (loader is null)
        {
            MessageBox.Show(this, $"无法从表格路径推导出 Elem 配置目录。\n表格路径：{_document.Path}",
                "路径错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var currentValue = TabTableDocument.GetCellValue(selectedItem.Row, tableColumnIndex);

        try
        {
            using var form = new RichTextEditorForm(currentValue, loader);
            if (form.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            var newValue = form.ResultMarkup;
            var oldValue = currentValue.Trim();
            if (newValue == oldValue)
            {
                return;
            }

            _document.SetCellValue(selectedItem.Row, tableColumnIndex, newValue);
            _detailGrid.Rows[currentCell.RowIndex].Cells[currentCell.ColumnIndex].Value = newValue;
            PushUndoAction(new DetailUndoAction(
                selectedItem.Row,
                [new DetailUndoCell(currentCell.RowIndex, tableColumnIndex, oldValue)]));
            _isDirty = true;
            UpdateActionButtons();
            RenderRows(selectFirstWhenAvailable: true, preferredRow: selectedItem.Row);
            SetStatus("存在未保存修改。");
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, $"富文本编辑器错误：\n\n{ex.Message}\n\n{ex.StackTrace}",
                "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void OpenTimePickerDialog()
    {
        if (_document is null ||
            _detailGrid.CurrentCell is not { RowIndex: >= 0, ColumnIndex: >= 0 } currentCell ||
            _detailGrid.Columns[currentCell.ColumnIndex].Name != "Value" ||
            _detailGrid.Rows[currentCell.RowIndex].Tag is not int tableColumnIndex ||
            _rowListBox.SelectedItem is not RowListItem selectedItem)
        {
            return;
        }

        var currentValue = TabTableDocument.GetCellValue(selectedItem.Row, tableColumnIndex).Trim();
        var initialDateTime = DateTime.Now;
        if (long.TryParse(currentValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out var timestamp) &&
            timestamp > 0)
        {
            try
            {
                initialDateTime = DateTimeOffset.FromUnixTimeSeconds(timestamp).UtcDateTime;
            }
            catch
            {
                // 解析失败时使用当前时间
            }
        }

        using var form = new DateTimePickerForm(initialDateTime);
        if (form.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        var selectedDateTime = form.SelectedDateTime;
        var newTimestamp = new DateTimeOffset(
            selectedDateTime.Year,
            selectedDateTime.Month,
            selectedDateTime.Day,
            selectedDateTime.Hour,
            selectedDateTime.Minute,
            selectedDateTime.Second,
            TimeSpan.Zero).ToUnixTimeSeconds();
        var newValue = newTimestamp.ToString(CultureInfo.InvariantCulture);

        var oldValue = currentValue;
        if (newValue == oldValue)
        {
            return;
        }

        try
        {
            _document.SetCellValue(selectedItem.Row, tableColumnIndex, newValue);
            _detailGrid.Rows[currentCell.RowIndex].Cells[currentCell.ColumnIndex].Value = newValue;
            PushUndoAction(new DetailUndoAction(
                selectedItem.Row,
                [new DetailUndoCell(currentCell.RowIndex, tableColumnIndex, oldValue)]));
            _isDirty = true;
            UpdateActionButtons();
            RenderRows(selectFirstWhenAvailable: true, preferredRow: selectedItem.Row);
            SetStatus("存在未保存修改。");
        }
        catch (ArgumentException ex)
        {
            _detailGrid.Rows[currentCell.RowIndex].ErrorText = ex.Message;
            MessageBox.Show(this, ex.Message, "内容无效", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void OpenFrameSelectorDialog()
    {
        if (_document is null ||
            _detailGrid.CurrentCell is not { RowIndex: >= 0, ColumnIndex: >= 0 } currentCell ||
            _detailGrid.Columns[currentCell.ColumnIndex].Name != "Value" ||
            _detailGrid.Rows[currentCell.RowIndex].Tag is not int tableColumnIndex ||
            _rowListBox.SelectedItem is not RowListItem selectedItem)
        {
            return;
        }

        var szLinkFrameValue = GetSzLinkFrameValue();
        if (string.IsNullOrWhiteSpace(szLinkFrameValue))
        {
            MessageBox.Show(this, "当前行的 szLinkFrame 为空，无法选择帧。", "无法选择",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var absolutePath = ResolveFrameAbsolutePath(szLinkFrameValue);
        if (absolutePath is null)
        {
            MessageBox.Show(this, $"无法从表格路径推导出 szLinkFrame 的绝对路径。\n表格路径：{_document.Path}\nszLinkFrame：{szLinkFrameValue}",
                "路径错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!File.Exists(absolutePath))
        {
            MessageBox.Show(this, $"找不到 UITex 文件：\n{absolutePath}", "文件不存在",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        UitexData uitexData;
        try
        {
            uitexData = UitexParser.Read(absolutePath);
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, $"UITex 文件格式错误：\n{absolutePath}\n\n{ex.Message}", "解析失败",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!File.Exists(uitexData.TgaFilePath))
        {
            MessageBox.Show(this, $"找不到纹理文件：\n{uitexData.TgaFilePath}", "文件不存在",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Bitmap? atlasImage = null;
        try
        {
            atlasImage = TgaLoader.Load(uitexData.TgaFilePath);
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, $"无法加载纹理图片：\n{uitexData.TgaFilePath}\n\n{ex.Message}", "加载失败",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        using (atlasImage)
        using (var form = new FrameSelectorForm(uitexData, atlasImage, Path.GetFileName(szLinkFrameValue)))
        {
            if (form.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            var newValue = form.SelectedFrameIndex.ToString(CultureInfo.InvariantCulture);
            var oldValue = TabTableDocument.GetCellValue(selectedItem.Row, tableColumnIndex).Trim();
            if (newValue == oldValue)
            {
                return;
            }

            try
            {
                _document.SetCellValue(selectedItem.Row, tableColumnIndex, newValue);
                _detailGrid.Rows[currentCell.RowIndex].Cells[currentCell.ColumnIndex].Value = newValue;
                PushUndoAction(new DetailUndoAction(
                    selectedItem.Row,
                    [new DetailUndoCell(currentCell.RowIndex, tableColumnIndex, oldValue)]));
                _isDirty = true;
                UpdateActionButtons();
                RenderRows(selectFirstWhenAvailable: true, preferredRow: selectedItem.Row);
                SetStatus("存在未保存修改。");
            }
            catch (ArgumentException ex)
            {
                _detailGrid.Rows[currentCell.RowIndex].ErrorText = ex.Message;
                MessageBox.Show(this, ex.Message, "内容无效", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    private string? ResolveFrameAbsolutePath(string szLinkFrameValue)
    {
        if (_document is null) return null;

        var docPath = _document.Path;
        var normalizedPath = docPath.Replace('/', '\\');

        const string marker = "client\\ui";
        var idx = normalizedPath.IndexOf(marker, StringComparison.OrdinalIgnoreCase);
        if (idx < 0) return null;

        var basePath = normalizedPath[..(idx + "client".Length)];
        var relativePath = szLinkFrameValue.Replace('/', '\\');
        return Path.GetFullPath(Path.Combine(basePath, relativePath));
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
            _undoStack.Clear();
            _detailGridColumnWidths.Clear();
            _rowSearchTextBox.Clear();
            PopulateDisplayColumnComboBox();
            PopulateTitleRowSelector();
            RenderRows(selectFirstWhenAvailable: true);
            SetStatus($"已加载 {_document.DisplayName}，共 {_document.DataRows.Count} 行。");
            SaveSettings(new AppSettings(_document.Path));
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or InvalidDataException or ArgumentException)
        {
            _document = null;
            _isDirty = false;
            _undoStack.Clear();
            _displayColumnComboBox.Items.Clear();
            _displayColumnComboBox.Enabled = false;
            ClearTitleRowSelector();
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

        var detailGridViewportState = CaptureDetailGridViewportState(preferredRow);
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
            RenderSelectedRow(detailGridViewportState);
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

    private void InsertRowBelow()
    {
        if (_document is null || _rowListBox.SelectedItem is not RowListItem selectedItem)
        {
            return;
        }

        var newRow = _document.InsertRowBelow(selectedItem.Row);
        _isDirty = true;
        RenderRows(selectFirstWhenAvailable: false, preferredRow: newRow);
        UpdateActionButtons();
        SetStatus("已在下方插入新行。");
    }

    private void DeleteSelectedRow()
    {
        if (_document is null || _rowListBox.SelectedItem is not RowListItem selectedItem)
        {
            return;
        }

        var result = MessageBox.Show(
            this,
            "确定要删除选中的行吗？",
            "确认删除",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2);
        if (result != DialogResult.Yes)
        {
            return;
        }

        var currentIndex = _rowListBox.SelectedIndex;
        _document.DeleteRow(selectedItem.Row);
        _isDirty = true;

        var nextPreferred = currentIndex < _rowListBox.Items.Count - 1
            ? (_rowListBox.Items[currentIndex + 1] as RowListItem)?.Row
            : currentIndex > 0
                ? (_rowListBox.Items[currentIndex - 1] as RowListItem)?.Row
                : null;
        RenderRows(selectFirstWhenAvailable: nextPreferred is null, preferredRow: nextPreferred);
        UpdateActionButtons();
        SetStatus("已删除选中行。");
    }

    private void RenderSelectedRow(DetailGridViewportState? viewportState = null)
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
                foreach (var titleRowIndex in GetSelectedTitleRowIndexesInDocumentOrder())
                {
                    gridRow.Cells[gridColumnIndex].Value = TabTableDocument.GetCellValue(
                        _document.Rows[titleRowIndex], column.Index);
                    gridColumnIndex++;
                }

                gridRow.Cells[gridColumnIndex].Value = TabTableDocument.GetCellValue(selectedItem.Row, column.Index);
            }
        }
        finally
        {
            _loadingDetails = false;
        }

        RestoreDetailGridViewportState(viewportState);
        UpdateDetailCurrentRowHighlight();
    }

    private DetailGridViewportState? CaptureDetailGridViewportState(TabTableRow? preferredRow)
    {
        if (preferredRow is null ||
            _rowListBox.SelectedItem is not RowListItem selectedItem ||
            !ReferenceEquals(selectedItem.Row, preferredRow) ||
            _detailGrid.Rows.Count == 0)
        {
            return null;
        }

        return new DetailGridViewportState(
            TryGetFirstDisplayedScrollingRowIndex(),
            TryGetFirstDisplayedScrollingColumnIndex(),
            _detailGrid.CurrentCell?.RowIndex,
            _detailGrid.CurrentCell?.ColumnIndex);
    }

    private int? TryGetFirstDisplayedScrollingRowIndex()
    {
        try
        {
            return _detailGrid.FirstDisplayedScrollingRowIndex;
        }
        catch (InvalidOperationException)
        {
            return null;
        }
    }

    private int? TryGetFirstDisplayedScrollingColumnIndex()
    {
        try
        {
            return _detailGrid.FirstDisplayedScrollingColumnIndex;
        }
        catch (InvalidOperationException)
        {
            return null;
        }
    }

    private void RestoreDetailGridViewportState(DetailGridViewportState? viewportState)
    {
        if (viewportState is null ||
            _detailGrid.Rows.Count == 0 ||
            _detailGrid.Columns.Count == 0)
        {
            return;
        }

        RestoreDetailGridCurrentCell(viewportState);
        RestoreFirstDisplayedScrollingColumn(viewportState.FirstDisplayedScrollingColumnIndex);
        RestoreFirstDisplayedScrollingRow(viewportState.FirstDisplayedScrollingRowIndex);
    }

    private void RestoreDetailGridCurrentCell(DetailGridViewportState viewportState)
    {
        if (viewportState.CurrentCellRowIndex is not { } rowIndex ||
            viewportState.CurrentCellColumnIndex is not { } columnIndex ||
            rowIndex < 0 ||
            rowIndex >= _detailGrid.Rows.Count ||
            columnIndex < 0 ||
            columnIndex >= _detailGrid.Columns.Count ||
            !_detailGrid.Rows[rowIndex].Visible ||
            !_detailGrid.Columns[columnIndex].Visible)
        {
            return;
        }

        _detailGrid.CurrentCell = _detailGrid.Rows[rowIndex].Cells[columnIndex];
    }

    private void RestoreFirstDisplayedScrollingRow(int? rowIndex)
    {
        if (rowIndex is null || _detailGrid.Rows.Count == 0)
        {
            return;
        }

        var clampedRowIndex = Math.Clamp(rowIndex.Value, 0, _detailGrid.Rows.Count - 1);
        if (!_detailGrid.Rows[clampedRowIndex].Visible)
        {
            return;
        }

        try
        {
            _detailGrid.FirstDisplayedScrollingRowIndex = clampedRowIndex;
        }
        catch (InvalidOperationException)
        {
        }
        catch (ArgumentOutOfRangeException)
        {
        }
    }

    private void RestoreFirstDisplayedScrollingColumn(int? columnIndex)
    {
        if (columnIndex is null || _detailGrid.Columns.Count == 0)
        {
            return;
        }

        var clampedColumnIndex = Math.Clamp(columnIndex.Value, 0, _detailGrid.Columns.Count - 1);
        var column = _detailGrid.Columns[clampedColumnIndex];
        if (!column.Visible || column.Frozen)
        {
            return;
        }

        try
        {
            _detailGrid.FirstDisplayedScrollingColumnIndex = clampedColumnIndex;
        }
        catch (InvalidOperationException)
        {
        }
        catch (ArgumentOutOfRangeException)
        {
        }
    }

    private void ConfigureDetailColumns()
    {
        if (_document is not null)
        {
            foreach (var titleRowIndex in GetSelectedTitleRowIndexesInDocumentOrder())
            {
                _detailGrid.Columns.Add(BuildReadOnlyTextColumn(
                    $"TitleRow{titleRowIndex}",
                    $"第{titleRowIndex + 1}行",
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
        ApplyDetailGridColumnWidths();
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

    private void ApplyDetailGridColumnWidths()
    {
        foreach (DataGridViewColumn column in _detailGrid.Columns)
        {
            if (_detailGridColumnWidths.TryGetValue(column.Name, out var width))
            {
                column.Width = Math.Max(column.MinimumWidth, width);
            }
        }
    }

    private void DetailGridColumnWidthChanged(object? sender, DataGridViewColumnEventArgs e)
    {
        if (_loadingDetails || string.IsNullOrEmpty(e.Column.Name))
        {
            return;
        }

        _detailGridColumnWidths[e.Column.Name] = e.Column.Width;

        if (_timeFieldButton.Visible)
        {
            UpdateTimeFieldButtonPosition();
        }

        if (_frameSelectButton.Visible)
        {
            UpdateFrameSelectButtonPosition();
        }

        if (_richTextButton.Visible)
        {
            UpdateRichTextButtonPosition();
        }
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

    private void DetailGridCellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 ||
            e.ColumnIndex < 0 ||
            e.RowIndex >= _detailGrid.Rows.Count ||
            e.ColumnIndex >= _detailGrid.Columns.Count ||
            _detailGrid.Columns[e.ColumnIndex].Name != "Value")
        {
            return;
        }

        if (!CommitExpandedValueEditor())
        {
            return;
        }

        _detailGrid.CurrentCell = _detailGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
        ShowExpandedValueEditor(e.RowIndex, e.ColumnIndex);
    }

    private void DetailGridCellEndEdit(object? sender, DataGridViewCellEventArgs e)
    {
        _detailGrid.Rows[e.RowIndex].ErrorText = string.Empty;
    }

    private void DetailGridCurrentCellChanged(object? sender, EventArgs e)
    {
        if (_handlingDetailCurrentCellChanged)
        {
            UpdateDetailCurrentRowHighlight();
            return;
        }

        if (IsExpandedValueEditorActive() &&
            _detailGrid.CurrentCell is { } currentCell &&
            (currentCell.RowIndex != _expandedValueEditorRowIndex ||
             currentCell.ColumnIndex != _expandedValueEditorColumnIndex))
        {
            var editorRowIndex = _expandedValueEditorRowIndex;
            var editorColumnIndex = _expandedValueEditorColumnIndex;
            CommitExpandedValueEditorAfterCurrentCellChanged(editorRowIndex, editorColumnIndex);
        }

        UpdateTimeFieldButtonVisibility();
        UpdateFrameSelectButtonVisibility();
        UpdateRichTextButtonVisibility();
        UpdateDetailCurrentRowHighlight();
    }

    private void DetailGridScroll(object? sender, ScrollEventArgs e)
    {
        if (_timeFieldButton.Visible)
        {
            UpdateTimeFieldButtonPosition();
        }

        if (_frameSelectButton.Visible)
        {
            UpdateFrameSelectButtonPosition();
        }

        if (_richTextButton.Visible)
        {
            UpdateRichTextButtonPosition();
        }
    }

    private void CommitExpandedValueEditorAfterCurrentCellChanged(int editorRowIndex, int editorColumnIndex)
    {
        if (!IsExpandedValueEditorActive() ||
            _expandedValueEditorRowIndex != editorRowIndex ||
            _expandedValueEditorColumnIndex != editorColumnIndex ||
            _detailGrid.CurrentCell is null ||
            (_detailGrid.CurrentCell.RowIndex == editorRowIndex &&
             _detailGrid.CurrentCell.ColumnIndex == editorColumnIndex))
        {
            return;
        }

        _handlingDetailCurrentCellChanged = true;
        try
        {
            if (!CommitExpandedValueEditor())
            {
                // Defer restore to avoid SetCurrentCellAddressCore re-entrancy
                BeginInvoke(() =>
                {
                    RestoreDetailCurrentCell(editorRowIndex, editorColumnIndex);
                    UpdateDetailCurrentRowHighlight();
                });
            }
            else
            {
                _detailGrid.Focus();
            }
        }
        finally
        {
            _handlingDetailCurrentCellChanged = false;
        }

        UpdateDetailCurrentRowHighlight();
    }

    private void RestoreDetailCurrentCell(int rowIndex, int columnIndex)
    {
        if (rowIndex < 0 ||
            rowIndex >= _detailGrid.Rows.Count ||
            columnIndex < 0 ||
            columnIndex >= _detailGrid.Columns.Count ||
            !_detailGrid.Rows[rowIndex].Visible ||
            !_detailGrid.Columns[columnIndex].Visible)
        {
            return;
        }

        _handlingDetailCurrentCellChanged = true;
        try
        {
            _detailGrid.CurrentCell = _detailGrid.Rows[rowIndex].Cells[columnIndex];
        }
        finally
        {
            _handlingDetailCurrentCellChanged = false;
        }

        if (_expandedValueEditorTextBox.Visible)
        {
            _expandedValueEditorTextBox.Focus();
        }
    }

    private void ShowExpandedValueEditor(int rowIndex, int columnIndex, string? initialText = null)
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

        var text = initialText ?? Convert.ToString(_detailGrid.Rows[rowIndex].Cells[columnIndex].Value) ?? string.Empty;
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
        UpdateTimeFieldButtonVisibility();
        UpdateFrameSelectButtonVisibility();
        UpdateRichTextButtonVisibility();
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
        var oldValue = TabTableDocument.GetCellValue(selectedItem.Row, tableColumnIndex);
        if (value == oldValue)
        {
            HideExpandedValueEditor();
            return true;
        }

        try
        {
            _document.SetCellValue(selectedItem.Row, tableColumnIndex, value);
            _detailGrid.Rows[_expandedValueEditorRowIndex].Cells[_expandedValueEditorColumnIndex].Value = value;
            PushUndoAction(new DetailUndoAction(
                selectedItem.Row,
                [new DetailUndoCell(_expandedValueEditorRowIndex, tableColumnIndex, oldValue)]));
            _isDirty = true;
            HideExpandedValueEditor();
            UpdateActionButtons();
            if (!_handlingDetailCurrentCellChanged)
            {
                RenderRows(selectFirstWhenAvailable: true, preferredRow: selectedItem.Row);
            }
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
        HideTimeFieldButton();
        HideFrameSelectButton();
        HideRichTextButton();
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
            if (CommitExpandedValueEditor())
            {
                e.Handled = true;
                _detailGrid.Focus();
            }
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
            _handlingDetailCurrentCellChanged ||
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
        var oldValue = TabTableDocument.GetCellValue(selectedItem.Row, tableColumnIndex);
        if (value == oldValue)
        {
            return;
        }

        try
        {
            _document.SetCellValue(selectedItem.Row, tableColumnIndex, value);
            PushUndoAction(new DetailUndoAction(
                selectedItem.Row,
                [new DetailUndoCell(e.RowIndex, tableColumnIndex, oldValue)]));
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

    private void UpdateDetailCurrentRowHighlight()
    {
        var currentRowIndex = _detailGrid.CurrentCell?.RowIndex ?? -1;
        foreach (DataGridViewRow row in _detailGrid.Rows)
        {
            row.DefaultCellStyle.BackColor = row.Index == currentRowIndex ? CurrentRowHighlight : Color.Empty;
        }

        _detailGrid.Invalidate();
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
        var isCurrentCell =
            _detailGrid.CurrentCell is not null &&
            e.RowIndex == _detailGrid.CurrentCell.RowIndex &&
            e.ColumnIndex == _detailGrid.CurrentCell.ColumnIndex;
        if (ranges.Count == 0 && !isCurrentCell)
        {
            return;
        }

        if (ranges.Count > 0)
        {
            PaintDetailValueCellWithSearchHighlight(e, graphics, cellStyle, ranges);
        }
        else
        {
            e.Paint(e.ClipBounds, e.PaintParts);
        }

        if (isCurrentCell)
        {
            if (IsContiguousSelection())
            {
                DrawSelectionBorder(e);
            }
            else
            {
                DrawCurrentDetailCellBorder(e);
            }
        }

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

    private static void DrawCurrentDetailCellBorder(DataGridViewCellPaintingEventArgs e)
    {
        var borderRectangle = e.CellBounds;
        borderRectangle.Inflate(-1, -1);
        using var pen = new Pen(CurrentCellBorderColor, 2);
        e.Graphics!.DrawRectangle(pen, borderRectangle);
    }

    private bool IsContiguousSelection()
    {
        var selectedCells = _detailGrid.SelectedCells;
        if (selectedCells.Count <= 1)
        {
            return false;
        }

        var minRowIndex = int.MaxValue;
        var maxRowIndex = int.MinValue;
        var minColumnIndex = int.MaxValue;
        var maxColumnIndex = int.MinValue;

        foreach (DataGridViewCell cell in selectedCells)
        {
            if (cell.RowIndex < minRowIndex) minRowIndex = cell.RowIndex;
            if (cell.RowIndex > maxRowIndex) maxRowIndex = cell.RowIndex;
            if (cell.ColumnIndex < minColumnIndex) minColumnIndex = cell.ColumnIndex;
            if (cell.ColumnIndex > maxColumnIndex) maxColumnIndex = cell.ColumnIndex;
        }

        var expectedCount = (maxRowIndex - minRowIndex + 1) * (maxColumnIndex - minColumnIndex + 1);
        return selectedCells.Count == expectedCount;
    }

    private void DrawSelectionBorder(DataGridViewCellPaintingEventArgs e)
    {
        var selectedCells = _detailGrid.SelectedCells;
        if (selectedCells.Count <= 1)
        {
            return;
        }

        var minRowIndex = int.MaxValue;
        var maxRowIndex = int.MinValue;
        var minColumnIndex = int.MaxValue;
        var maxColumnIndex = int.MinValue;

        foreach (DataGridViewCell cell in selectedCells)
        {
            if (cell.RowIndex < minRowIndex) minRowIndex = cell.RowIndex;
            if (cell.RowIndex > maxRowIndex) maxRowIndex = cell.RowIndex;
            if (cell.ColumnIndex < minColumnIndex) minColumnIndex = cell.ColumnIndex;
            if (cell.ColumnIndex > maxColumnIndex) maxColumnIndex = cell.ColumnIndex;
        }

        var topLeftBounds = _detailGrid.GetCellDisplayRectangle(minColumnIndex, minRowIndex, false);
        var bottomRightBounds = _detailGrid.GetCellDisplayRectangle(maxColumnIndex, maxRowIndex, false);

        if (topLeftBounds.Width <= 0 || topLeftBounds.Height <= 0 ||
            bottomRightBounds.Width <= 0 || bottomRightBounds.Height <= 0)
        {
            return;
        }

        var selectionRect = new Rectangle(
            topLeftBounds.Left,
            topLeftBounds.Top,
            bottomRightBounds.Right - topLeftBounds.Left,
            bottomRightBounds.Bottom - topLeftBounds.Top);

        selectionRect.Inflate(-1, -1);
        using var pen = new Pen(CurrentCellBorderColor, 2);
        e.Graphics!.DrawRectangle(pen, selectionRect);
    }

    private void DetailGridKeyPress(object? sender, KeyPressEventArgs e)
    {
        if (_detailGrid.IsCurrentCellInEditMode ||
            IsExpandedValueEditorActive() ||
            char.IsControl(e.KeyChar) ||
            _detailGrid.CurrentCell is not { RowIndex: >= 0 } currentCell ||
            currentCell.ColumnIndex < 0 ||
            currentCell.ColumnIndex >= _detailGrid.Columns.Count ||
            _detailGrid.Columns[currentCell.ColumnIndex].Name != "Value")
        {
            return;
        }

        ShowExpandedValueEditor(currentCell.RowIndex, currentCell.ColumnIndex, e.KeyChar.ToString());
        e.Handled = true;
    }

    private void DetailGridKeyDown(object? sender, KeyEventArgs e)
    {
        if (_detailGrid.IsCurrentCellInEditMode || IsExpandedValueEditorActive())
        {
            return;
        }

        if (e.KeyCode == Keys.F2 && !e.Control && !e.Alt && !e.Shift)
        {
            if (_detailGrid.CurrentCell is { RowIndex: >= 0 } currentCell &&
                currentCell.ColumnIndex >= 0 &&
                currentCell.ColumnIndex < _detailGrid.Columns.Count &&
                _detailGrid.Columns[currentCell.ColumnIndex].Name == "Value")
            {
                ShowExpandedValueEditor(currentCell.RowIndex, currentCell.ColumnIndex);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            return;
        }

        if (!e.Control || e.Alt || e.Shift)
        {
            return;
        }

        if (e.KeyCode == Keys.C)
        {
            CopySelectedDetailCellsToClipboard();
            e.SuppressKeyPress = true;
            e.Handled = true;
            return;
        }

        if (e.KeyCode == Keys.V)
        {
            PasteClipboardToDetailGrid();
            e.SuppressKeyPress = true;
            e.Handled = true;
            return;
        }

        if (e.KeyCode == Keys.Z)
        {
            UndoLastDetailChange();
            e.SuppressKeyPress = true;
            e.Handled = true;
        }
    }

    private void CopySelectedDetailCellsToClipboard()
    {
        var selectedCells = _detailGrid.SelectedCells
            .Cast<DataGridViewCell>()
            .Where(cell => cell.RowIndex >= 0 && cell.ColumnIndex >= 0)
            .OrderBy(cell => cell.RowIndex)
            .ThenBy(cell => cell.ColumnIndex)
            .ToList();
        if (selectedCells.Count == 0 && _detailGrid.CurrentCell is { RowIndex: >= 0, ColumnIndex: >= 0 } currentCell)
        {
            selectedCells.Add(currentCell);
        }

        if (selectedCells.Count == 0)
        {
            return;
        }

        var selectedRows = selectedCells
            .Select(cell => cell.RowIndex)
            .Distinct()
            .OrderBy(rowIndex => rowIndex)
            .ToList();
        var selectedColumns = selectedCells
            .Select(cell => cell.ColumnIndex)
            .Distinct()
            .OrderBy(columnIndex => columnIndex)
            .ToList();
        var selectedLocations = selectedCells
            .Select(cell => (cell.RowIndex, cell.ColumnIndex))
            .ToHashSet();
        var builder = new StringBuilder();

        for (var rowOffset = 0; rowOffset < selectedRows.Count; rowOffset++)
        {
            if (rowOffset > 0)
            {
                builder.Append("\r\n");
            }

            var rowIndex = selectedRows[rowOffset];
            for (var columnOffset = 0; columnOffset < selectedColumns.Count; columnOffset++)
            {
                if (columnOffset > 0)
                {
                    builder.Append('\t');
                }

                var columnIndex = selectedColumns[columnOffset];
                if (!selectedLocations.Contains((rowIndex, columnIndex)))
                {
                    continue;
                }

                builder.Append(SanitizeClipboardCell(Convert.ToString(_detailGrid.Rows[rowIndex].Cells[columnIndex].Value) ?? string.Empty));
            }
        }

        Clipboard.SetText(builder.ToString());
        SetStatus($"已复制 {selectedCells.Count} 个单元格。");
    }

    private void PasteClipboardToDetailGrid()
    {
        if (_detailGrid.CurrentCell is not { RowIndex: >= 0 } currentCell ||
            currentCell.ColumnIndex < 0 ||
            currentCell.ColumnIndex >= _detailGrid.Columns.Count ||
            _detailGrid.Columns[currentCell.ColumnIndex].Name != "Value")
        {
            SetStatus("请先选中值列单元格再粘贴。");
            return;
        }

        if (!Clipboard.ContainsText())
        {
            SetStatus("剪贴板没有可粘贴的文本。");
            return;
        }

        var clipboardValues = ParseClipboardValuesForValueColumn(Clipboard.GetText());
        if (clipboardValues.Count == 0)
        {
            SetStatus("剪贴板没有可粘贴的文本。");
            return;
        }

        if (_document is null || _rowListBox.SelectedItem is not RowListItem selectedItem)
        {
            return;
        }

        _detailGrid.EndEdit();

        var availableRows = Math.Max(0, _detailGrid.Rows.Count - currentCell.RowIndex);
        var pasteCount = Math.Min(clipboardValues.Count, availableRows);
        if (pasteCount == 0)
        {
            SetStatus("没有可粘贴的目标行。");
            return;
        }

        var undoCells = new List<DetailUndoCell>();
        _loadingDetails = true;
        try
        {
            for (var offset = 0; offset < pasteCount; offset++)
            {
                var rowIndex = currentCell.RowIndex + offset;
                if (_detailGrid.Rows[rowIndex].Tag is not int tableColumnIndex)
                {
                    continue;
                }

                var newValue = clipboardValues[offset];
                var oldValue = TabTableDocument.GetCellValue(selectedItem.Row, tableColumnIndex);
                _document.SetCellValue(selectedItem.Row, tableColumnIndex, newValue);
                _detailGrid.Rows[rowIndex].Cells[currentCell.ColumnIndex].Value = newValue;
                _detailGrid.Rows[rowIndex].ErrorText = string.Empty;
                if (oldValue != newValue)
                {
                    undoCells.Add(new DetailUndoCell(rowIndex, tableColumnIndex, oldValue));
                }
            }
        }
        catch (ArgumentException ex)
        {
            SetStatus(ex.Message);
            MessageBox.Show(this, ex.Message, "无法粘贴单元格", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        finally
        {
            _loadingDetails = false;
        }

        PushUndoAction(new DetailUndoAction(selectedItem.Row, undoCells));
        if (undoCells.Count > 0)
        {
            _isDirty = true;
            UpdateActionButtons();
            RenderRows(selectFirstWhenAvailable: true, preferredRow: selectedItem.Row);
        }

        var overflowCount = clipboardValues.Count - pasteCount;
        SetStatus(overflowCount > 0
            ? $"已粘贴 {pasteCount} 项，超出 {overflowCount} 项未粘贴。"
            : $"已粘贴 {pasteCount} 项。");
    }

    private void UndoLastDetailChange()
    {
        if (_undoStack.Count == 0)
        {
            SetStatus("没有可撤销的操作。");
            return;
        }

        var action = _undoStack.Pop();
        if (_document is null || !_document.Rows.Any(row => ReferenceEquals(row, action.Row)))
        {
            SetStatus("没有可撤销的操作。");
            return;
        }

        HideExpandedValueEditor();
        _loadingDetails = true;
        try
        {
            foreach (var undoCell in action.Cells)
            {
                _document.SetCellValue(action.Row, undoCell.TableColumnIndex, undoCell.OldValue);
            }
        }
        finally
        {
            _loadingDetails = false;
        }

        _isDirty = true;
        RenderRows(selectFirstWhenAvailable: true, preferredRow: action.Row);
        UpdateActionButtons();
        SetStatus($"已撤销 {action.Cells.Count} 项。");
    }

    private void PushUndoAction(DetailUndoAction action)
    {
        if (action.Cells.Count == 0)
        {
            return;
        }

        _undoStack.Push(action);
    }

    private static IReadOnlyList<string> ParseClipboardValuesForValueColumn(string text)
    {
        var normalized = text.Replace("\r\n", "\n").Replace('\r', '\n').TrimEnd('\n');
        if (normalized.Length == 0)
        {
            return Array.Empty<string>();
        }

        return normalized
            .Split('\n')
            .Select(row => row.Split('\t').LastOrDefault() ?? string.Empty)
            .ToList();
    }

    private static string SanitizeClipboardCell(string value)
    {
        return value
            .Replace('\t', ' ')
            .Replace('\r', ' ')
            .Replace('\n', ' ');
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
        _undoStack.Clear();
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

        var canModifyRow = _document is not null && _rowListBox.SelectedItem is RowListItem;
        _insertRowButton.Enabled = canModifyRow;
        _insertRowButton.Cursor = canModifyRow ? Cursors.Hand : Cursors.Default;
        _deleteRowButton.Enabled = canModifyRow;
        _deleteRowButton.Cursor = canModifyRow ? Cursors.Hand : Cursors.Default;
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

    private sealed class DisplayRowItem
    {
        public DisplayRowItem(TabTableRow row)
        {
            Row = row;
        }

        public TabTableRow Row { get; }

        public override string ToString()
        {
            var preview = string.Join("\t", Row.Cells.Take(3));
            return $"第{Row.RowIndex + 1}行 - {preview}";
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

    private sealed record DetailUndoAction(
        TabTableRow Row,
        IReadOnlyList<DetailUndoCell> Cells);

    private sealed record DetailUndoCell(
        int DetailRowIndex,
        int TableColumnIndex,
        string OldValue);

    private sealed record DetailGridViewportState(
        int? FirstDisplayedScrollingRowIndex,
        int? FirstDisplayedScrollingColumnIndex,
        int? CurrentCellRowIndex,
        int? CurrentCellColumnIndex);

    private sealed record AppSettings(string? LastOpenedFilePath);

    private static string GetSettingsFilePath()
    {
        return Path.Combine(Path.GetDirectoryName(Environment.ProcessPath)!, "填tab表工具.config.json");
    }

    private static AppSettings LoadSettings()
    {
        try
        {
            var path = GetSettingsFilePath();
            if (!File.Exists(path)) return new AppSettings(null);
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<AppSettings>(json) ?? new AppSettings(null);
        }
        catch { return new AppSettings(null); }
    }

    private static void SaveSettings(AppSettings settings)
    {
        try
        {
            var json = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(GetSettingsFilePath(), json);
        }
        catch { }
    }

    private void TryLoadLastOpenedFile()
    {
        var settings = LoadSettings();
        if (string.IsNullOrWhiteSpace(settings.LastOpenedFilePath)) return;
        if (!File.Exists(settings.LastOpenedFilePath)) return;
        _filePathTextBox.Text = settings.LastOpenedFilePath;
        LoadCurrentFile();
    }

    private class ExpandedTextBox : TextBox
    {
        protected override bool IsInputKey(Keys keyData)
        {
            if (ExpandedTextEditorKeyRouting.IsNavigationKey(keyData))
            {
                return true;
            }
            return base.IsInputKey(keyData);
        }
    }

    private class DetailDataGridView : DataGridView
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Func<TextBox?>? GetExpandedEditor { get; set; }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            var editor = GetExpandedEditor?.Invoke();
            if (editor is { Visible: true })
            {
                var key = keyData & Keys.KeyCode;
                if ((keyData & Keys.Control) == Keys.Control)
                {
                    if (key == Keys.C)
                    {
                        if (!string.IsNullOrEmpty(editor.SelectedText))
                            Clipboard.SetText(editor.SelectedText);
                        return true;
                    }
                    if (key == Keys.X)
                    {
                        if (!string.IsNullOrEmpty(editor.SelectedText))
                        {
                            Clipboard.SetText(editor.SelectedText);
                            editor.SelectedText = "";
                        }
                        return true;
                    }
                    if (key == Keys.V) { editor.Paste(); return true; }
                    if (key == Keys.A) { editor.SelectAll(); return true; }
                }
                // Route navigation keys to the overlay editor instead of moving the grid cell.
                if (ExpandedTextEditorKeyRouting.RouteNavigationKeyToEditor(editor, keyData))
                {
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            var editor = GetExpandedEditor?.Invoke();
            if (editor is { Visible: true })
            {
                if (ExpandedTextEditorKeyRouting.RouteNavigationKeyToEditor(editor, keyData))
                {
                    return true;
                }
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
