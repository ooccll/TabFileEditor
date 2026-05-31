using System.Runtime.ExceptionServices;
using System.Text;
using TabFileEditor.App;

namespace TabFileEditor.App.Tests;

public sealed class MainFormTests : IDisposable
{
    private static readonly Encoding GbkEncoding = CreateGbkEncoding();
    private readonly string _tempDir = Path.Combine(Path.GetTempPath(), "TabFileEditorAppTests", Guid.NewGuid().ToString("N"));

    public MainFormTests()
    {
        Directory.CreateDirectory(_tempDir);
    }

    public void Dispose()
    {
        if (Directory.Exists(_tempDir))
        {
            Directory.Delete(_tempDir, recursive: true);
        }
    }

    [Fact]
    public void MainFormUsesRequestedEditorLayout()
    {
        RunOnStaThread(() =>
        {
            using var form = new MainForm();
            form.ClientSize = new Size(1000, 620);
            form.CreateControl();
            form.PerformLayout();
            InvokePrivate(form, "InitializeSplitterDistance");
            form.PerformLayout();

            var root = Assert.IsType<TableLayoutPanel>(Assert.Single(form.Controls.Cast<Control>()));
            Assert.Equal(4, root.RowCount);
            Assert.IsType<TableLayoutPanel>(root.GetControlFromPosition(0, 0));
            var searchBar = Assert.IsType<TableLayoutPanel>(root.GetControlFromPosition(0, 1));
            var splitContainer = Assert.IsType<SplitContainer>(root.GetControlFromPosition(0, 2));
            var bottomBar = Assert.IsType<TableLayoutPanel>(root.GetControlFromPosition(0, 3));

            Assert.Equal("FilePathTextBox", FindFilePathTextBox(form).Name);
            var displayColumnComboBox = FindDisplayColumnComboBox(form);
            Assert.Equal(ComboBoxStyle.DropDownList, displayColumnComboBox.DropDownStyle);
            var rowSearchTextBox = FindRowSearchTextBox(form);
            Assert.Same(rowSearchTextBox, Assert.Single(searchBar.Controls.Cast<Control>()));
            Assert.Same(rowSearchTextBox, searchBar.GetControlFromPosition(0, 0));
            Assert.DoesNotContain(
                searchBar.Controls.Cast<Control>().OfType<Label>(),
                label => label.Text == "搜索");
            Assert.DoesNotContain(FindDescendants<Button>(form), button => button.Name == "ClearSearchButton");
            Assert.Equal("搜索内容，可用空格隔开多个关键字", rowSearchTextBox.PlaceholderText);

            var rowListPanel = Assert.IsType<TableLayoutPanel>(Assert.Single(splitContainer.Panel1.Controls.Cast<Control>()));
            var displayColumnPanel = Assert.IsType<TableLayoutPanel>(rowListPanel.GetControlFromPosition(0, 0));
            Assert.Equal("显示列", Assert.IsType<Label>(displayColumnPanel.GetControlFromPosition(0, 0)).Text);
            Assert.Same(displayColumnComboBox, displayColumnPanel.GetControlFromPosition(1, 0));
            var rowListBox = FindDescendant<ListBox>(splitContainer.Panel1);
            Assert.NotNull(rowListBox);
            Assert.Equal(Padding.Empty, rowListBox.Margin);
            Assert.Equal(rowListBox.Right, displayColumnComboBox.Right);

            var detailGrid = FindDetailGrid(form);
            Assert.False(detailGrid.AllowUserToAddRows);
            Assert.False(detailGrid.RowHeadersVisible);
            Assert.Equal(detailGrid.Bottom, rowListBox.Bottom);

            var openButton = FindButton(form, "打开表格所在目录");
            var saveButton = FindButton(form, "保存");
            Assert.Same(openButton, bottomBar.GetControlFromPosition(1, 0));
            Assert.Same(saveButton, bottomBar.GetControlFromPosition(2, 0));
            Assert.False(openButton.Enabled);
            Assert.False(saveButton.Enabled);
        });
    }

    [Fact]
    public void LoadingFileDefaultsDisplayColumnToNameAndShowsIdList()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateSampleTable();
            using var form = new MainForm();
            form.CreateControl();
            FindFilePathTextBox(form).Text = tablePath;

            InvokePrivate(form, "LoadCurrentFile");

            var comboBox = FindDisplayColumnComboBox(form);
            Assert.Equal(1, comboBox.SelectedIndex);
            Assert.Contains("QuestName", comboBox.Text);

            var rowListBox = FindDescendant<ListBox>(form);
            Assert.NotNull(rowListBox);
            Assert.Collection(
                rowListBox.Items.Cast<object>().Select(item => item.ToString()),
                item => Assert.Equal("[1] FirstQuest", item),
                item => Assert.Equal("[2] SecondQuest", item));
            Assert.Equal(0, rowListBox.SelectedIndex);

            var detailGrid = FindDetailGrid(form);
            Assert.Equal(3, detailGrid.Columns.Count);
            Assert.Null(detailGrid.Columns["ColumnIndex"]);
            Assert.Equal("第1行", detailGrid.Columns[0].HeaderText);
            Assert.Equal("第2行", detailGrid.Columns[1].HeaderText);
            Assert.Equal("值", detailGrid.Columns[2].HeaderText);
            Assert.True(detailGrid.Columns[0].ReadOnly);
            Assert.True(detailGrid.Columns[1].ReadOnly);
            Assert.False(detailGrid.Columns[2].ReadOnly);
            Assert.Equal("QuestName", detailGrid.Rows[1].Cells[0].Value);
            Assert.Equal("FirstQuest", detailGrid.Rows[1].Cells[2].Value);
        });
    }

    [Fact]
    public void LoadingFileWithIdZeroShowsZeroRowAndUsesRowsAboveItAsReadOnlyPreamble()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateIdZeroTable();
            using var form = new MainForm();
            form.CreateControl();
            FindFilePathTextBox(form).Text = tablePath;

            InvokePrivate(form, "LoadCurrentFile");

            var rowListBox = FindDescendant<ListBox>(form);
            Assert.NotNull(rowListBox);
            Assert.Collection(
                rowListBox.Items.Cast<object>().Select(item => item.ToString()),
                item => Assert.Equal("[0] DefaultQuest", item),
                item => Assert.Equal("[1] FirstQuest", item));
            Assert.Equal(0, rowListBox.SelectedIndex);

            var detailGrid = FindDetailGrid(form);
            Assert.Equal(3, detailGrid.Columns.Count);
            Assert.Null(detailGrid.Columns["ColumnIndex"]);
            Assert.Equal("第1行", detailGrid.Columns[0].HeaderText);
            Assert.Equal("第2行", detailGrid.Columns[1].HeaderText);
            Assert.Equal("Name", detailGrid.Rows[1].Cells[0].Value);
            Assert.Equal("string", detailGrid.Rows[1].Cells[1].Value);
            Assert.Equal("DefaultQuest", detailGrid.Rows[1].Cells[2].Value);
        });
    }

    [Fact]
    public void LoadingFileWithEmptyDisplayColumnShowsOnlyIdInLeftList()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateIdZeroEmptyNameTable();
            using var form = new MainForm();
            form.CreateControl();
            FindFilePathTextBox(form).Text = tablePath;

            InvokePrivate(form, "LoadCurrentFile");

            var comboBox = FindDisplayColumnComboBox(form);
            Assert.Equal(1, comboBox.SelectedIndex);
            Assert.Contains("szName", comboBox.Text);

            var rowListBox = FindDescendant<ListBox>(form);
            Assert.NotNull(rowListBox);
            Assert.Collection(
                rowListBox.Items.Cast<object>().Select(item => item.ToString()),
                item => Assert.Equal("[0]", item),
                item => Assert.Equal("[1] FirstQuest", item));

            var detailGrid = FindDetailGrid(form);
            Assert.Equal(string.Empty, detailGrid.Rows[1].Cells["Value"].Value);
        });
    }

    [Fact]
    public void SearchFiltersLeftRowListByAnyCellValueAndAllKeywords()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateSampleTable();
            using var form = new MainForm();
            form.CreateControl();
            FindFilePathTextBox(form).Text = tablePath;
            InvokePrivate(form, "LoadCurrentFile");

            var rowSearchTextBox = FindRowSearchTextBox(form);
            rowSearchTextBox.Text = "only path";

            var rowListBox = FindDescendant<ListBox>(form);
            Assert.NotNull(rowListBox);
            var item = Assert.Single(rowListBox.Items.Cast<object>());
            Assert.Equal("[2] SecondQuest", item.ToString());

            var detailGrid = FindDetailGrid(form);
            var valueColumnIndex = detailGrid.Columns["Value"]!.Index;
            Assert.NotEmpty(GetDetailSearchMatchRanges(form, detailRowIndex: 2, valueColumnIndex));

            rowSearchTextBox.Clear();

            Assert.Equal(string.Empty, rowSearchTextBox.Text);
            Assert.Equal(2, rowListBox.Items.Count);
            Assert.Empty(GetDetailSearchMatchRanges(form, detailRowIndex: 2, valueColumnIndex));

            rowSearchTextBox.Text = "only missing";

            Assert.Empty(rowListBox.Items.Cast<object>());

            rowSearchTextBox.Clear();

            Assert.Equal(2, rowListBox.Items.Count);
        });
    }

    [Fact]
    public void DetailGridReportsSearchMatchRangesOnlyForValueColumn()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateSampleTable();
            using var form = new MainForm();
            form.CreateControl();
            FindFilePathTextBox(form).Text = tablePath;
            InvokePrivate(form, "LoadCurrentFile");

            FindRowSearchTextBox(form).Text = "first path";

            var rowListBox = FindDescendant<ListBox>(form);
            Assert.NotNull(rowListBox);
            rowListBox.SelectedIndex = 0;

            var detailGrid = FindDetailGrid(form);
            var valueColumnIndex = detailGrid.Columns["Value"]!.Index;
            var preambleColumnIndex = detailGrid.Columns["Preamble0"]!.Index;
            var pathValue = Assert.IsType<string>(detailGrid.Rows[2].Cells["Value"].Value);
            var pathStart = pathValue.IndexOf("path", StringComparison.OrdinalIgnoreCase);

            var nameRanges = GetDetailSearchMatchRanges(form, detailRowIndex: 1, valueColumnIndex);
            var pathRanges = GetDetailSearchMatchRanges(form, detailRowIndex: 2, valueColumnIndex);

            Assert.Contains(("FirstQuest".IndexOf("first", StringComparison.OrdinalIgnoreCase), "first".Length), nameRanges);
            Assert.Contains((pathStart, "path".Length), pathRanges);
            Assert.Empty(GetDetailSearchMatchRanges(form, detailRowIndex: 2, preambleColumnIndex));

            FindRowSearchTextBox(form).Clear();

            Assert.Empty(GetDetailSearchMatchRanges(form, detailRowIndex: 2, valueColumnIndex));
        });
    }

    [Fact]
    public void EditingValueCellEnablesSaveAndWritesTabFile()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateSampleTable();
            using var form = new MainForm();
            form.CreateControl();
            FindFilePathTextBox(form).Text = tablePath;
            InvokePrivate(form, "LoadCurrentFile");

            var detailGrid = FindDetailGrid(form);
            detailGrid.Rows[2].Cells["Value"].Value = "修改后的描述";
            InvokePrivate(
                form,
                "DetailGridCellValueChanged",
                detailGrid,
                new DataGridViewCellEventArgs(detailGrid.Columns["Value"]!.Index, 2));

            var saveButton = FindButton(form, "保存");
            Assert.True(saveButton.Enabled);

            InvokePrivate(form, "SaveCurrentFile", false);

            Assert.False(saveButton.Enabled);
            Assert.Contains("FirstQuest\t修改后的描述", File.ReadAllText(tablePath, GbkEncoding));
        });
    }

    [Fact]
    public void SaveShortcutWritesEditedValueAndDisablesSaveButton()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateSampleTable();
            using var form = new MainForm();
            form.CreateControl();
            FindFilePathTextBox(form).Text = tablePath;
            InvokePrivate(form, "LoadCurrentFile");

            var detailGrid = FindDetailGrid(form);
            detailGrid.Rows[2].Cells["Value"].Value = "快捷键保存描述";
            InvokePrivate(
                form,
                "DetailGridCellValueChanged",
                detailGrid,
                new DataGridViewCellEventArgs(detailGrid.Columns["Value"]!.Index, 2));
            var saveButton = FindButton(form, "保存");
            Assert.True(saveButton.Enabled);

            var handled = InvokeProcessCmdKey(form, Keys.Control | Keys.S);

            Assert.True(handled);
            Assert.False(saveButton.Enabled);
            Assert.Contains("FirstQuest\t快捷键保存描述", File.ReadAllText(tablePath, GbkEncoding));
        });
    }

    [Fact]
    public void DetailGridCopiesSelectedValueCellsWithShortcut()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateSampleTable();
            using var form = new MainForm();
            form.CreateControl();
            FindFilePathTextBox(form).Text = tablePath;
            InvokePrivate(form, "LoadCurrentFile");

            var detailGrid = FindDetailGrid(form);
            detailGrid.CurrentCell = detailGrid.Rows[1].Cells["Value"];
            detailGrid.ClearSelection();
            detailGrid.Rows[1].Cells["Value"].Selected = true;
            detailGrid.Rows[2].Cells["Value"].Selected = true;
            var keyArgs = new KeyEventArgs(Keys.Control | Keys.C);

            InvokePrivate(form, "DetailGridKeyDown", detailGrid, keyArgs);

            Assert.True(keyArgs.Handled);
            Assert.True(keyArgs.SuppressKeyPress);
            Assert.Equal("FirstQuest\r\nAlphaPath说明", Clipboard.GetText());
            Assert.Contains("已复制 2 个单元格", GetStatusText(form));
            Clipboard.Clear();
        });
    }

    [Fact]
    public void DetailGridPastesClipboardRowsDownFromCurrentValueCellWithShortcut()
    {
        RunOnStaThread(() =>
        {
            try
            {
                var tablePath = CreateSampleTable();
                using var form = new MainForm();
                form.CreateControl();
                FindFilePathTextBox(form).Text = tablePath;
                InvokePrivate(form, "LoadCurrentFile");

                var detailGrid = FindDetailGrid(form);
                var rowListBox = FindDescendant<ListBox>(form);
                Assert.NotNull(rowListBox);
                detailGrid.CurrentCell = detailGrid.Rows[1].Cells["Value"];
                Clipboard.SetText("CopiedQuest\r\nCopiedDesc");
                var keyArgs = new KeyEventArgs(Keys.Control | Keys.V);

                InvokePrivate(form, "DetailGridKeyDown", detailGrid, keyArgs);

                Assert.True(keyArgs.Handled);
                Assert.True(keyArgs.SuppressKeyPress);
                Assert.Equal("CopiedQuest", detailGrid.Rows[1].Cells["Value"].Value);
                Assert.Equal("CopiedDesc", detailGrid.Rows[2].Cells["Value"].Value);
                Assert.Equal("[1] CopiedQuest", rowListBox.Items[0].ToString());
                Assert.True(FindButton(form, "保存").Enabled);
                Assert.Contains("已粘贴 2 项", GetStatusText(form));
            }
            finally
            {
                Clipboard.Clear();
            }
        });
    }

    [Fact]
    public void DetailGridPasteUsesLastClipboardColumnAndReportsOverflow()
    {
        RunOnStaThread(() =>
        {
            try
            {
                var tablePath = CreateSampleTable();
                using var form = new MainForm();
                form.CreateControl();
                FindFilePathTextBox(form).Text = tablePath;
                InvokePrivate(form, "LoadCurrentFile");

                var detailGrid = FindDetailGrid(form);
                detailGrid.CurrentCell = detailGrid.Rows[2].Cells["Value"];
                Clipboard.SetText("字段\t说明\tOnlyLastColumn\r\n字段2\t说明2\tOverflow");

                InvokePrivate(form, "PasteClipboardToDetailGrid");

                Assert.Equal("OnlyLastColumn", detailGrid.Rows[2].Cells["Value"].Value);
                Assert.Contains("已粘贴 1 项，超出 1 项未粘贴", GetStatusText(form));
            }
            finally
            {
                Clipboard.Clear();
            }
        });
    }

    [Fact]
    public void DetailGridPasteRequiresCurrentValueCell()
    {
        RunOnStaThread(() =>
        {
            try
            {
                var tablePath = CreateSampleTable();
                using var form = new MainForm();
                form.CreateControl();
                FindFilePathTextBox(form).Text = tablePath;
                InvokePrivate(form, "LoadCurrentFile");

                var detailGrid = FindDetailGrid(form);
                detailGrid.CurrentCell = detailGrid.Rows[1].Cells[0];
                Clipboard.SetText("ShouldNotPaste");

                InvokePrivate(form, "PasteClipboardToDetailGrid");

                Assert.Equal("FirstQuest", detailGrid.Rows[1].Cells["Value"].Value);
                Assert.Equal("请先选中值列单元格再粘贴。", GetStatusText(form));
            }
            finally
            {
                Clipboard.Clear();
            }
        });
    }

    [Fact]
    public void DetailGridUndoRestoresLastSingleValueEdit()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateSampleTable();
            using var form = new MainForm();
            form.CreateControl();
            FindFilePathTextBox(form).Text = tablePath;
            InvokePrivate(form, "LoadCurrentFile");

            var detailGrid = FindDetailGrid(form);
            var rowListBox = FindDescendant<ListBox>(form);
            Assert.NotNull(rowListBox);
            detailGrid.CurrentCell = detailGrid.Rows[1].Cells["Value"];
            detailGrid.Rows[1].Cells["Value"].Value = "UndoQuest";
            InvokePrivate(
                form,
                "DetailGridCellValueChanged",
                detailGrid,
                new DataGridViewCellEventArgs(detailGrid.Columns["Value"]!.Index, 1));
            Assert.Equal("[1] UndoQuest", rowListBox.Items[0].ToString());

            var keyArgs = new KeyEventArgs(Keys.Control | Keys.Z);
            InvokePrivate(form, "DetailGridKeyDown", detailGrid, keyArgs);

            Assert.True(keyArgs.Handled);
            Assert.True(keyArgs.SuppressKeyPress);
            Assert.Equal("FirstQuest", detailGrid.Rows[1].Cells["Value"].Value);
            Assert.Equal("[1] FirstQuest", rowListBox.Items[0].ToString());
            Assert.True(FindButton(form, "保存").Enabled);
            Assert.Contains("已撤销 1 项", GetStatusText(form));
        });
    }

    [Fact]
    public void DetailGridUndoRestoresExpandedValueEdit()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateLongDescriptionTable();
            using var form = new MainForm();
            form.CreateControl();
            FindFilePathTextBox(form).Text = tablePath;
            InvokePrivate(form, "LoadCurrentFile");

            var detailGrid = FindDetailGrid(form);
            var valueColumnIndex = detailGrid.Columns["Value"]!.Index;
            detailGrid.CurrentCell = detailGrid.Rows[2].Cells[valueColumnIndex];
            var oldValue = Convert.ToString(detailGrid.CurrentCell.Value) ?? string.Empty;
            InvokePrivate(
                form,
                "DetailGridCellBeginEdit",
                detailGrid,
                new DataGridViewCellCancelEventArgs(valueColumnIndex, 2));
            var editBox = FindExpandedValueEditorTextBox(form);
            editBox.Text = "展开编辑后撤销";
            InvokePrivate(form, "CommitExpandedValueEditor");
            Assert.Equal("展开编辑后撤销", detailGrid.Rows[2].Cells["Value"].Value);

            InvokePrivate(form, "UndoLastDetailChange");

            Assert.Equal(oldValue, detailGrid.Rows[2].Cells["Value"].Value);
            Assert.True(FindButton(form, "保存").Enabled);
            Assert.Contains("已撤销 1 项", GetStatusText(form));
        });
    }

    [Fact]
    public void DetailGridUndoRestoresLastPasteAsSingleAction()
    {
        RunOnStaThread(() =>
        {
            try
            {
                var tablePath = CreateSampleTable();
                using var form = new MainForm();
                form.CreateControl();
                FindFilePathTextBox(form).Text = tablePath;
                InvokePrivate(form, "LoadCurrentFile");

                var detailGrid = FindDetailGrid(form);
                var rowListBox = FindDescendant<ListBox>(form);
                Assert.NotNull(rowListBox);
                detailGrid.CurrentCell = detailGrid.Rows[1].Cells["Value"];
                Clipboard.SetText("PastedQuest\r\nPastedDesc");
                InvokePrivate(form, "PasteClipboardToDetailGrid");
                Assert.Equal("PastedQuest", detailGrid.Rows[1].Cells["Value"].Value);
                Assert.Equal("PastedDesc", detailGrid.Rows[2].Cells["Value"].Value);

                var keyArgs = new KeyEventArgs(Keys.Control | Keys.Z);
                InvokePrivate(form, "DetailGridKeyDown", detailGrid, keyArgs);

                Assert.True(keyArgs.Handled);
                Assert.True(keyArgs.SuppressKeyPress);
                Assert.Equal("FirstQuest", detailGrid.Rows[1].Cells["Value"].Value);
                Assert.Equal("AlphaPath说明", detailGrid.Rows[2].Cells["Value"].Value);
                Assert.Equal("[1] FirstQuest", rowListBox.Items[0].ToString());
                Assert.Contains("已撤销 2 项", GetStatusText(form));
            }
            finally
            {
                Clipboard.Clear();
            }
        });
    }

    [Fact]
    public void DetailGridPasteUnchangedValuesDoesNotCreateUndoAction()
    {
        RunOnStaThread(() =>
        {
            try
            {
                var tablePath = CreateSampleTable();
                using var form = new MainForm();
                form.CreateControl();
                FindFilePathTextBox(form).Text = tablePath;
                InvokePrivate(form, "LoadCurrentFile");

                var detailGrid = FindDetailGrid(form);
                detailGrid.CurrentCell = detailGrid.Rows[1].Cells["Value"];
                Clipboard.SetText("FirstQuest\r\nAlphaPath说明");
                InvokePrivate(form, "PasteClipboardToDetailGrid");

                var keyArgs = new KeyEventArgs(Keys.Control | Keys.Z);
                InvokePrivate(form, "DetailGridKeyDown", detailGrid, keyArgs);

                Assert.True(keyArgs.Handled);
                Assert.True(keyArgs.SuppressKeyPress);
                Assert.Equal("FirstQuest", detailGrid.Rows[1].Cells["Value"].Value);
                Assert.Equal("AlphaPath说明", detailGrid.Rows[2].Cells["Value"].Value);
                Assert.Equal("没有可撤销的操作。", GetStatusText(form));
            }
            finally
            {
                Clipboard.Clear();
            }
        });
    }

    [Fact]
    public void DetailGridUndoWithEmptyStackOnlyUpdatesStatus()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateSampleTable();
            using var form = new MainForm();
            form.CreateControl();
            FindFilePathTextBox(form).Text = tablePath;
            InvokePrivate(form, "LoadCurrentFile");

            var detailGrid = FindDetailGrid(form);
            detailGrid.CurrentCell = detailGrid.Rows[1].Cells["Value"];
            var keyArgs = new KeyEventArgs(Keys.Control | Keys.Z);

            InvokePrivate(form, "DetailGridKeyDown", detailGrid, keyArgs);

            Assert.True(keyArgs.Handled);
            Assert.True(keyArgs.SuppressKeyPress);
            Assert.Equal("FirstQuest", detailGrid.Rows[1].Cells["Value"].Value);
            Assert.Equal("没有可撤销的操作。", GetStatusText(form));
        });
    }

    [Fact]
    public void DetailGridUndoShortcutDoesNotInterceptExpandedValueEditor()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateLongDescriptionTable();
            using var form = new MainForm();
            form.CreateControl();
            FindFilePathTextBox(form).Text = tablePath;
            InvokePrivate(form, "LoadCurrentFile");

            var detailGrid = FindDetailGrid(form);
            var valueColumnIndex = detailGrid.Columns["Value"]!.Index;
            detailGrid.CurrentCell = detailGrid.Rows[2].Cells[valueColumnIndex];
            InvokePrivate(
                form,
                "DetailGridCellBeginEdit",
                detailGrid,
                new DataGridViewCellCancelEventArgs(valueColumnIndex, 2));
            var editBox = FindExpandedValueEditorTextBox(form);
            editBox.Text = "编辑中";
            var keyArgs = new KeyEventArgs(Keys.Control | Keys.Z);

            InvokePrivate(form, "DetailGridKeyDown", detailGrid, keyArgs);

            Assert.False(keyArgs.Handled);
            Assert.False(keyArgs.SuppressKeyPress);
            Assert.Equal("编辑中", editBox.Text);
        });
    }

    [Fact]
    public void DetailGridKeyPressStartsExpandedEditorWithTypedCharacterReplacingOldValue()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateSampleTable();
            using var form = new MainForm();
            form.CreateControl();
            FindFilePathTextBox(form).Text = tablePath;
            InvokePrivate(form, "LoadCurrentFile");

            var detailGrid = FindDetailGrid(form);
            Assert.Equal(DataGridViewEditMode.EditProgrammatically, detailGrid.EditMode);
            detailGrid.CurrentCell = detailGrid.Rows[1].Cells["Value"];
            var keyArgs = new KeyPressEventArgs('A');

            InvokePrivate(form, "DetailGridKeyPress", detailGrid, keyArgs);

            Assert.True(keyArgs.Handled);
            var editBox = FindExpandedValueEditorTextBox(form);
            Assert.Equal("A", editBox.Text);
            Assert.Equal(1, editBox.SelectionStart);
            Assert.Equal(0, editBox.SelectionLength);
            Assert.Equal("FirstQuest", detailGrid.Rows[1].Cells["Value"].Value);
        });
    }

    [Fact]
    public void DetailGridKeyPressStartsExpandedEditorForEmptyValueCell()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateIdZeroEmptyNameTable();
            using var form = new MainForm();
            form.CreateControl();
            FindFilePathTextBox(form).Text = tablePath;
            InvokePrivate(form, "LoadCurrentFile");

            var detailGrid = FindDetailGrid(form);
            detailGrid.CurrentCell = detailGrid.Rows[1].Cells["Value"];
            Assert.Equal(string.Empty, detailGrid.CurrentCell.Value);
            var keyArgs = new KeyPressEventArgs('B');

            InvokePrivate(form, "DetailGridKeyPress", detailGrid, keyArgs);

            Assert.True(keyArgs.Handled);
            var editBox = FindExpandedValueEditorTextBox(form);
            Assert.Equal("B", editBox.Text);
            Assert.Equal(1, editBox.SelectionStart);
        });
    }

    [Fact]
    public void DetailGridKeyPressDoesNotStartEditorForReadOnlyColumn()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateSampleTable();
            using var form = new MainForm();
            form.CreateControl();
            FindFilePathTextBox(form).Text = tablePath;
            InvokePrivate(form, "LoadCurrentFile");

            var detailGrid = FindDetailGrid(form);
            detailGrid.CurrentCell = detailGrid.Rows[1].Cells[0];
            var keyArgs = new KeyPressEventArgs('A');

            InvokePrivate(form, "DetailGridKeyPress", detailGrid, keyArgs);

            Assert.False(keyArgs.Handled);
            Assert.Equal(string.Empty, FindExpandedValueEditorTextBox(form).Text);
        });
    }

    [Fact]
    public void DetailGridKeyPressDoesNotInterceptExpandedValueEditor()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateLongDescriptionTable();
            using var form = new MainForm();
            form.CreateControl();
            FindFilePathTextBox(form).Text = tablePath;
            InvokePrivate(form, "LoadCurrentFile");

            var detailGrid = FindDetailGrid(form);
            var valueColumnIndex = detailGrid.Columns["Value"]!.Index;
            detailGrid.CurrentCell = detailGrid.Rows[2].Cells[valueColumnIndex];
            InvokePrivate(
                form,
                "DetailGridCellBeginEdit",
                detailGrid,
                new DataGridViewCellCancelEventArgs(valueColumnIndex, 2));
            var editBox = FindExpandedValueEditorTextBox(form);
            editBox.Text = "编辑中";
            var keyArgs = new KeyPressEventArgs('C');

            InvokePrivate(form, "DetailGridKeyPress", detailGrid, keyArgs);

            Assert.False(keyArgs.Handled);
            Assert.Equal("编辑中", editBox.Text);
        });
    }

    [Fact]
    public void DetailGridF2StartsExpandedEditorWithExistingValue()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateSampleTable();
            using var form = new MainForm();
            form.CreateControl();
            FindFilePathTextBox(form).Text = tablePath;
            InvokePrivate(form, "LoadCurrentFile");

            var detailGrid = FindDetailGrid(form);
            detailGrid.CurrentCell = detailGrid.Rows[1].Cells["Value"];
            var keyArgs = new KeyEventArgs(Keys.F2);

            InvokePrivate(form, "DetailGridKeyDown", detailGrid, keyArgs);

            Assert.True(keyArgs.Handled);
            Assert.True(keyArgs.SuppressKeyPress);
            var editBox = FindExpandedValueEditorTextBox(form);
            Assert.Equal("FirstQuest", editBox.Text);
            Assert.Equal(editBox.Text.Length, editBox.SelectionStart);
            Assert.Equal(0, editBox.SelectionLength);
        });
    }

    [Fact]
    public void DetailGridShortcutsDoNotInterceptExpandedValueEditor()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateLongDescriptionTable();
            using var form = new MainForm();
            form.CreateControl();
            FindFilePathTextBox(form).Text = tablePath;
            InvokePrivate(form, "LoadCurrentFile");

            var detailGrid = FindDetailGrid(form);
            var valueColumnIndex = detailGrid.Columns["Value"]!.Index;
            detailGrid.CurrentCell = detailGrid.Rows[2].Cells[valueColumnIndex];
            InvokePrivate(
                form,
                "DetailGridCellBeginEdit",
                detailGrid,
                new DataGridViewCellCancelEventArgs(valueColumnIndex, 2));
            var editBox = FindExpandedValueEditorTextBox(form);
            Assert.Equal(Convert.ToString(detailGrid.CurrentCell.Value), editBox.Text);
            var keyArgs = new KeyEventArgs(Keys.Control | Keys.V);

            InvokePrivate(form, "DetailGridKeyDown", detailGrid, keyArgs);

            Assert.False(keyArgs.Handled);
            Assert.False(keyArgs.SuppressKeyPress);
            Assert.Equal(Convert.ToString(detailGrid.CurrentCell.Value), editBox.Text);
        });
    }

    [Fact]
    public void DetailGridHighlightsCurrentRowAndPaintsCurrentCellBorder()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateSampleTable();
            using var form = new MainForm();
            form.CreateControl();
            FindFilePathTextBox(form).Text = tablePath;
            InvokePrivate(form, "LoadCurrentFile");

            var detailGrid = FindDetailGrid(form);
            var valueColumnIndex = detailGrid.Columns["Value"]!.Index;
            detailGrid.CurrentCell = detailGrid.Rows[2].Cells[valueColumnIndex];

            Assert.Equal(CurrentRowHighlightForTest(), detailGrid.Rows[2].DefaultCellStyle.BackColor);
            Assert.Equal(Color.Empty, detailGrid.Rows[1].DefaultCellStyle.BackColor);
            Assert.Equal(CurrentRowHighlightForTest(), detailGrid.DefaultCellStyle.SelectionBackColor);
            Assert.Equal(TextColorForTest(), detailGrid.DefaultCellStyle.SelectionForeColor);

            using var bitmap = new Bitmap(240, 40);
            using var graphics = Graphics.FromImage(bitmap);
            var paintArgs = CreateCellPaintingEventArgs(detailGrid, 2, valueColumnIndex, graphics);
            InvokePrivate(form, "DetailGridCellPainting", detailGrid, paintArgs);

            Assert.True(paintArgs.Handled);
        });
    }

    [Fact]
    public void EditingLongValueCellUsesExpandedMultilineEditor()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateLongDescriptionTable();
            using var form = new MainForm();
            form.ClientSize = new Size(1000, 620);
            form.CreateControl();
            InvokePrivate(form, "InitializeSplitterDistance");
            form.PerformLayout();
            FindFilePathTextBox(form).Text = tablePath;
            InvokePrivate(form, "LoadCurrentFile");
            form.PerformLayout();

            var detailGrid = FindDetailGrid(form);
            var valueColumnIndex = detailGrid.Columns["Value"]!.Index;
            const int descriptionRowIndex = 2;
            detailGrid.CurrentCell = detailGrid.Rows[descriptionRowIndex].Cells[valueColumnIndex];
            detailGrid.Size = new Size(700, 460);
            var cellBounds = detailGrid.GetCellDisplayRectangle(valueColumnIndex, descriptionRowIndex, cutOverflow: false);
            if (cellBounds.Width <= 0 || cellBounds.Height <= 0)
            {
                cellBounds = new Rectangle(
                    detailGrid.Columns.Cast<DataGridViewColumn>().Take(valueColumnIndex).Sum(column => column.Width),
                    detailGrid.ColumnHeadersHeight + descriptionRowIndex * detailGrid.Rows[descriptionRowIndex].Height,
                    detailGrid.Columns[valueColumnIndex].Width,
                    detailGrid.Rows[descriptionRowIndex].Height);
            }

            var editArgs = new DataGridViewCellCancelEventArgs(valueColumnIndex, descriptionRowIndex);
            InvokePrivate(form, "DetailGridCellBeginEdit", detailGrid, editArgs);

            Assert.True(editArgs.Cancel);
            var editBox = FindExpandedValueEditorTextBox(form);
            Assert.Same(detailGrid, editBox.Parent);
            Assert.Equal(Convert.ToString(detailGrid.CurrentCell.Value), editBox.Text);
            Assert.Equal(PanelBgForTest(), editBox.BackColor);
            Assert.NotEqual(Color.Black, editBox.BackColor);
            Assert.Equal(TextColorForTest(), editBox.ForeColor);
            Assert.Equal(BorderStyle.FixedSingle, editBox.BorderStyle);
            Assert.Equal(cellBounds.Left, editBox.Left);
            Assert.Equal(cellBounds.Top, editBox.Top);
            Assert.Equal(cellBounds.Width, editBox.Width);
            Assert.True(editBox.Height > detailGrid.Rows[descriptionRowIndex].Height);
            Assert.True(editBox.Bottom <= detailGrid.ClientSize.Height);
            Assert.Equal(30, detailGrid.Rows[descriptionRowIndex].Height);
            Assert.True(editBox.Multiline);
            Assert.True(editBox.WordWrap);
            Assert.Equal(ScrollBars.Vertical, editBox.ScrollBars);

            editBox.Text = "修改后的长内容";
            InvokePrivate(form, "CommitExpandedValueEditor");

            Assert.Equal(string.Empty, editBox.Text);
            Assert.Equal("修改后的长内容", detailGrid.Rows[descriptionRowIndex].Cells["Value"].Value);
            Assert.True(FindButton(form, "保存").Enabled);

            detailGrid.CurrentCell = detailGrid.Rows[descriptionRowIndex].Cells[0];

            var readOnlyEditArgs = new DataGridViewCellCancelEventArgs(0, descriptionRowIndex);
            InvokePrivate(form, "DetailGridCellBeginEdit", detailGrid, readOnlyEditArgs);
            Assert.True(readOnlyEditArgs.Cancel);
            Assert.Equal(string.Empty, editBox.Text);
        });
    }

    [Fact]
    public void DoubleClickingUnselectedValueCellStartsExpandedEditor()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateLongDescriptionTable();
            using var form = new MainForm();
            form.ClientSize = new Size(1000, 620);
            form.CreateControl();
            InvokePrivate(form, "InitializeSplitterDistance");
            form.PerformLayout();
            FindFilePathTextBox(form).Text = tablePath;
            InvokePrivate(form, "LoadCurrentFile");
            form.PerformLayout();

            var detailGrid = FindDetailGrid(form);
            detailGrid.Size = new Size(700, 460);
            var valueColumnIndex = detailGrid.Columns["Value"]!.Index;
            const int descriptionRowIndex = 2;
            detailGrid.CurrentCell = detailGrid.Rows[0].Cells[0];

            var cellBounds = detailGrid.GetCellDisplayRectangle(valueColumnIndex, descriptionRowIndex, cutOverflow: false);
            if (cellBounds.Width <= 0 || cellBounds.Height <= 0)
            {
                cellBounds = new Rectangle(
                    detailGrid.Columns.Cast<DataGridViewColumn>().Take(valueColumnIndex).Sum(column => column.Width),
                    detailGrid.ColumnHeadersHeight + descriptionRowIndex * detailGrid.Rows[descriptionRowIndex].Height,
                    detailGrid.Columns[valueColumnIndex].Width,
                    detailGrid.Rows[descriptionRowIndex].Height);
            }

            InvokePrivate(
                form,
                "DetailGridCellDoubleClick",
                detailGrid,
                new DataGridViewCellEventArgs(valueColumnIndex, descriptionRowIndex));

            Assert.Same(detailGrid.Rows[descriptionRowIndex].Cells[valueColumnIndex], detailGrid.CurrentCell);
            var editBox = FindExpandedValueEditorTextBox(form);
            Assert.Equal(Convert.ToString(detailGrid.CurrentCell.Value), editBox.Text);
            Assert.Equal(cellBounds.Left, editBox.Left);
            Assert.Equal(cellBounds.Top, editBox.Top);
            Assert.Equal(cellBounds.Width, editBox.Width);
            Assert.True(editBox.Height > detailGrid.Rows[descriptionRowIndex].Height);

            InvokePrivate(form, "HideExpandedValueEditor");
            detailGrid.CurrentCell = detailGrid.Rows[0].Cells[valueColumnIndex];
            InvokePrivate(
                form,
                "DetailGridCellDoubleClick",
                detailGrid,
                new DataGridViewCellEventArgs(0, descriptionRowIndex));

            Assert.Equal(string.Empty, editBox.Text);
        });
    }

    private string CreateSampleTable()
    {
        var path = Path.Combine(_tempDir, "QuestTab.xls");
        var lines = new[]
        {
            "ID\tQuestName\tDesc",
            "int\tstring\tstring",
            "1\tFirstQuest\tAlphaPath说明",
            "2\tSecondQuest\tOnlyMatchedByPath",
        };
        File.WriteAllText(path, string.Join("\r\n", lines) + "\r\n", GbkEncoding);
        return path;
    }

    private string CreateLongDescriptionTable()
    {
        var path = Path.Combine(_tempDir, "LongDescriptionQuestTab.xls");
        var longDescription = string.Join(' ', Enumerable.Repeat("LongDescriptionSegment", 160));
        var lines = new[]
        {
            "ID\tQuestName\tDesc",
            "int\tstring\tstring",
            $"1\tFirstQuest\t{longDescription}",
        };
        File.WriteAllText(path, string.Join("\r\n", lines) + "\r\n", GbkEncoding);
        return path;
    }

    private string CreateIdZeroTable()
    {
        var path = Path.Combine(_tempDir, "ZeroQuestTab.xls");
        var lines = new[]
        {
            "ID\tName\tDesc",
            "int\tstring\tstring",
            "0\tDefaultQuest\t默认行",
            "1\tFirstQuest\t第一条",
        };
        File.WriteAllText(path, string.Join("\r\n", lines) + "\r\n", GbkEncoding);
        return path;
    }

    private string CreateIdZeroEmptyNameTable()
    {
        var path = Path.Combine(_tempDir, "ZeroEmptyNameQuestTab.xls");
        var lines = new[]
        {
            "ID\tszName\tDesc",
            "int\tstring\tstring",
            "0\t\t默认行",
            "1\tFirstQuest\t第一条",
        };
        File.WriteAllText(path, string.Join("\r\n", lines) + "\r\n", GbkEncoding);
        return path;
    }

    private static void RunOnStaThread(Action action)
    {
        ExceptionDispatchInfo? exception = null;
        var thread = new Thread(() =>
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                exception = ExceptionDispatchInfo.Capture(ex);
            }
        });

        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
        thread.Join();
        exception?.Throw();
    }

    private static TextBox FindFilePathTextBox(Form form)
    {
        return FindDescendants<TextBox>(form).Single(textBox => textBox.Name == "FilePathTextBox");
    }

    private static ComboBox FindDisplayColumnComboBox(Form form)
    {
        return FindDescendants<ComboBox>(form).Single(comboBox => comboBox.Name == "DisplayColumnComboBox");
    }

    private static TextBox FindRowSearchTextBox(Form form)
    {
        return FindDescendants<TextBox>(form).Single(textBox => textBox.Name == "RowSearchTextBox");
    }

    private static TextBox FindExpandedValueEditorTextBox(Form form)
    {
        return FindDescendants<TextBox>(form).Single(textBox => textBox.Name == "ExpandedValueEditorTextBox");
    }

    private static DataGridView FindDetailGrid(Form form)
    {
        var detailGrid = FindDescendant<DataGridView>(form);
        Assert.NotNull(detailGrid);
        return detailGrid;
    }

    private static Button FindButton(Form form, string text)
    {
        return FindDescendants<Button>(form).Single(button => button.Text == text);
    }

    private static string GetStatusText(Form form)
    {
        return FindDescendants<StatusStrip>(form)
            .Single()
            .Items
            .OfType<ToolStripStatusLabel>()
            .Single()
            .Text ?? string.Empty;
    }

    private static bool InvokeProcessCmdKey(Form form, Keys keyData)
    {
        var method = form.GetType().GetMethod(
            "ProcessCmdKey",
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
        Assert.NotNull(method);
        var args = new object[] { new Message(), keyData };
        return Assert.IsType<bool>(method.Invoke(form, args));
    }

    private static void InvokePrivate(object target, string methodName, params object[] args)
    {
        var method = target.GetType().GetMethod(
            methodName,
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
        Assert.NotNull(method);
        method.Invoke(target, args);
    }

    private static IReadOnlyList<(int Start, int Length)> GetDetailSearchMatchRanges(
        Form form,
        int detailRowIndex,
        int detailColumnIndex)
    {
        return InvokePrivate<IReadOnlyList<(int Start, int Length)>>(
            form,
            "GetDetailSearchMatchRanges",
            detailRowIndex,
            detailColumnIndex);
    }

    private static T InvokePrivate<T>(object target, string methodName, params object[] args)
    {
        var method = target.GetType().GetMethod(
            methodName,
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
        Assert.NotNull(method);
        return Assert.IsAssignableFrom<T>(method.Invoke(target, args));
    }

    private static DataGridViewCellPaintingEventArgs CreateCellPaintingEventArgs(
        DataGridView detailGrid,
        int rowIndex,
        int columnIndex,
        Graphics graphics)
    {
        var cell = detailGrid.Rows[rowIndex].Cells[columnIndex];
        var cellBounds = new Rectangle(0, 0, Math.Max(120, detailGrid.Columns[columnIndex].Width), detailGrid.Rows[rowIndex].Height);
        return new DataGridViewCellPaintingEventArgs(
            detailGrid,
            graphics,
            cellBounds,
            cellBounds,
            rowIndex,
            columnIndex,
            DataGridViewElementStates.Selected,
            cell.Value,
            Convert.ToString(cell.FormattedValue) ?? string.Empty,
            string.Empty,
            cell.InheritedStyle,
            new DataGridViewAdvancedBorderStyle(),
            DataGridViewPaintParts.All);
    }

    private static TControl? FindDescendant<TControl>(Control parent)
        where TControl : Control
    {
        foreach (Control child in parent.Controls)
        {
            if (child is TControl match)
            {
                return match;
            }

            var descendant = FindDescendant<TControl>(child);
            if (descendant is not null)
            {
                return descendant;
            }
        }

        return null;
    }

    private static IReadOnlyList<TControl> FindDescendants<TControl>(Control parent)
        where TControl : Control
    {
        var controls = new List<TControl>();
        foreach (Control child in parent.Controls)
        {
            if (child is TControl match)
            {
                controls.Add(match);
            }

            controls.AddRange(FindDescendants<TControl>(child));
        }

        return controls;
    }

    private static Encoding CreateGbkEncoding()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        return Encoding.GetEncoding("GB18030");
    }

    private static Color PanelBgForTest()
    {
        return Color.White;
    }

    private static Color TextColorForTest()
    {
        return ColorTranslator.FromHtml("#1F2937");
    }

    private static Color CurrentRowHighlightForTest()
    {
        return ColorTranslator.FromHtml("#D7E9FF");
    }
}
