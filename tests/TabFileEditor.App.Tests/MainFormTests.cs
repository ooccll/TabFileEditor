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

            var root = Assert.IsType<TableLayoutPanel>(Assert.Single(form.Controls.Cast<Control>()));
            Assert.Equal(4, root.RowCount);
            Assert.IsType<TableLayoutPanel>(root.GetControlFromPosition(0, 0));
            Assert.IsType<TableLayoutPanel>(root.GetControlFromPosition(0, 1));
            var splitContainer = Assert.IsType<SplitContainer>(root.GetControlFromPosition(0, 2));
            var bottomBar = Assert.IsType<TableLayoutPanel>(root.GetControlFromPosition(0, 3));

            Assert.Equal("FilePathTextBox", FindFilePathTextBox(form).Name);
            var displayColumnComboBox = FindDisplayColumnComboBox(form);
            Assert.Equal(ComboBoxStyle.DropDownList, displayColumnComboBox.DropDownStyle);
            Assert.Equal("RowSearchTextBox", FindRowSearchTextBox(form).Name);
            Assert.NotNull(FindDescendant<ListBox>(splitContainer.Panel1));

            var detailGrid = FindDetailGrid(form);
            Assert.False(detailGrid.AllowUserToAddRows);
            Assert.False(detailGrid.RowHeadersVisible);

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
            Assert.Equal(4, detailGrid.Columns.Count);
            Assert.Equal("第1行", detailGrid.Columns[1].HeaderText);
            Assert.Equal("第2行", detailGrid.Columns[2].HeaderText);
            Assert.Equal("值", detailGrid.Columns[3].HeaderText);
            Assert.True(detailGrid.Columns[1].ReadOnly);
            Assert.True(detailGrid.Columns[2].ReadOnly);
            Assert.False(detailGrid.Columns[3].ReadOnly);
            Assert.Equal("QuestName", detailGrid.Rows[1].Cells[1].Value);
            Assert.Equal("FirstQuest", detailGrid.Rows[1].Cells[3].Value);
        });
    }

    [Fact]
    public void SearchFiltersLeftRowList()
    {
        RunOnStaThread(() =>
        {
            var tablePath = CreateSampleTable();
            using var form = new MainForm();
            form.CreateControl();
            FindFilePathTextBox(form).Text = tablePath;
            InvokePrivate(form, "LoadCurrentFile");

            FindRowSearchTextBox(form).Text = "second";

            var rowListBox = FindDescendant<ListBox>(form);
            Assert.NotNull(rowListBox);
            var item = Assert.Single(rowListBox.Items.Cast<object>());
            Assert.Equal("[2] SecondQuest", item.ToString());
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

    private string CreateSampleTable()
    {
        var path = Path.Combine(_tempDir, "QuestTab.xls");
        var lines = new[]
        {
            "ID\tQuestName\tDesc",
            "int\tstring\tstring",
            "1\tFirstQuest\t第一条",
            "2\tSecondQuest\t第二条",
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

    private static void InvokePrivate(object target, string methodName, params object[] args)
    {
        var method = target.GetType().GetMethod(
            methodName,
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
        Assert.NotNull(method);
        method.Invoke(target, args);
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
}
