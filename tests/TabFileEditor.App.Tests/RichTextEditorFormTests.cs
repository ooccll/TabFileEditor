using System.Runtime.ExceptionServices;
using TabFileEditor.App;

namespace TabFileEditor.App.Tests;

public sealed class RichTextEditorFormTests : IDisposable
{
    private readonly string _tempDir = Path.Combine(Path.GetTempPath(), "RichTextEditorFormTests", Guid.NewGuid().ToString("N"));

    public RichTextEditorFormTests()
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
    public void DoubleClickingTextColumnStartsExpandedEditor()
    {
        RunOnStaThread(() =>
        {
            using var form = CreateForm();
            form.Show();
            Application.DoEvents();

            var grid = FindSegmentGrid(form);
            var textColumnIndex = grid.Columns["Text"]!.Index;
            var editBox = FindExpandedTextEditor(form);
            Assert.False(editBox.Visible);

            InvokePrivate(form, "OnSegmentGridCellDoubleClick", grid,
                new DataGridViewCellEventArgs(textColumnIndex, 0));

            Assert.True(editBox.Visible);
            Assert.Equal("Hello", editBox.Text);
        });
    }

    [Fact]
    public void ExpandedTextEditorTreatsNavigationKeysAsTextInput()
    {
        RunOnStaThread(() =>
        {
            using var form = CreateForm();
            form.Show();
            Application.DoEvents();

            var grid = FindSegmentGrid(form);
            var textColumnIndex = grid.Columns["Text"]!.Index;
            InvokePrivate(form, "OnSegmentGridCellDoubleClick", grid,
                new DataGridViewCellEventArgs(textColumnIndex, 0));

            var editBox = FindExpandedTextEditor(form);
            Assert.True(editBox.Visible);

            // ExpandedTextBox.IsInputKey should return true for navigation keys
            var isInputKeyMethod = editBox.GetType().GetMethod(
                "IsInputKey",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            Assert.NotNull(isInputKeyMethod);
            Assert.True((bool)isInputKeyMethod.Invoke(editBox, new object[] { Keys.Left })!);
            Assert.True((bool)isInputKeyMethod.Invoke(editBox, new object[] { Keys.Control | Keys.Right })!);
            Assert.True((bool)isInputKeyMethod.Invoke(editBox, new object[] { Keys.Shift | Keys.Down })!);

            // SegmentDataGridView.ProcessDialogKey should route navigation keys to the expanded editor
            var processDialogKeyMethod = grid.GetType().GetMethod(
                "ProcessDialogKey",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            Assert.NotNull(processDialogKeyMethod);
            Assert.True((bool)processDialogKeyMethod.Invoke(grid, new object[] { Keys.Left })!);

            // SegmentDataGridView.ProcessCmdKey should route navigation keys to the expanded editor
            var processCmdKeyMethod = grid.GetType().GetMethod(
                "ProcessCmdKey",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            Assert.NotNull(processCmdKeyMethod);
            Assert.True((bool)processCmdKeyMethod.Invoke(grid, new object[] { new Message(), Keys.Control | Keys.Right })!);
        });
    }

    [Fact]
    public void ExpandedTextEditorMovesCaretWhenGridReceivesArrowKey()
    {
        RunOnStaThread(() =>
        {
            using var form = CreateForm();
            form.Show();
            Application.DoEvents();

            var grid = FindSegmentGrid(form);
            var textColumnIndex = grid.Columns["Text"]!.Index;
            InvokePrivate(form, "OnSegmentGridCellDoubleClick", grid,
                new DataGridViewCellEventArgs(textColumnIndex, 0));

            var editBox = FindExpandedTextEditor(form);
            editBox.Text = "abc";
            editBox.SelectionStart = 1;
            editBox.SelectionLength = 0;
            grid.CurrentCell = grid.Rows[0].Cells[textColumnIndex];
            Assert.True(editBox.Visible);

            var handled = InvokeProtected<bool>(grid, "ProcessDialogKey", Keys.Right);

            Assert.True(handled);
            Assert.Same(grid.Rows[0].Cells[textColumnIndex], grid.CurrentCell);
            Assert.Equal(2, editBox.SelectionStart);
            Assert.Equal(0, editBox.SelectionLength);
        });
    }

    [Fact]
    public void ExpandedTextEditorSupportsCtrlAndShiftNavigationWhenGridReceivesKeys()
    {
        RunOnStaThread(() =>
        {
            using var form = CreateForm();
            form.Show();
            Application.DoEvents();

            var grid = FindSegmentGrid(form);
            var textColumnIndex = grid.Columns["Text"]!.Index;
            InvokePrivate(form, "OnSegmentGridCellDoubleClick", grid,
                new DataGridViewCellEventArgs(textColumnIndex, 0));

            var editBox = FindExpandedTextEditor(form);
            editBox.Text = "abc def";
            editBox.SelectionStart = 0;
            editBox.SelectionLength = 0;

            Assert.True(InvokeProtected<bool>(grid, "ProcessCmdKey", new Message(), Keys.Control | Keys.Right));
            Assert.Equal(4, editBox.SelectionStart);
            Assert.Equal(0, editBox.SelectionLength);

            Assert.True(InvokeProtected<bool>(grid, "ProcessDialogKey", Keys.Shift | Keys.Right));
            Assert.Equal(4, editBox.SelectionStart);
            Assert.Equal(1, editBox.SelectionLength);
        });
    }

    [Fact]
    public void DoubleClickingNonTextColumnDoesNotStartExpandedEditor()
    {
        RunOnStaThread(() =>
        {
            using var form = CreateForm();
            form.Show();
            Application.DoEvents();

            var grid = FindSegmentGrid(form);
            var fontSchemeIdColumnIndex = grid.Columns["FontSchemeId"]!.Index;
            var editBox = FindExpandedTextEditor(form);
            Assert.False(editBox.Visible);

            InvokePrivate(form, "OnSegmentGridCellDoubleClick", grid,
                new DataGridViewCellEventArgs(fontSchemeIdColumnIndex, 0));

            Assert.False(editBox.Visible);
        });
    }

    private RichTextEditorForm CreateForm()
    {
        var elemDir = Path.Combine(_tempDir, "Elem");
        Directory.CreateDirectory(elemDir);
        var loader = new ElemSchemeLoader(elemDir);
        var markup = "<text>text=\"Hello\" font=0</text><text>text=\"World\" font=0</text>";
        return new RichTextEditorForm(markup, loader);
    }

    private static DataGridView FindSegmentGrid(Form form)
    {
        return FindDescendants<DataGridView>(form).Single();
    }

    private static TextBox FindExpandedTextEditor(Form form)
    {
        return FindDescendants<TextBox>(form).Single(textBox => textBox.Name == "ExpandedTextEditorTextBox");
    }

    private static void InvokePrivate(object target, string methodName, params object[] args)
    {
        var method = target.GetType().GetMethod(
            methodName,
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
        Assert.NotNull(method);
        method.Invoke(target, args);
    }

    private static T InvokeProtected<T>(object target, string methodName, params object[] args)
    {
        var method = target.GetType().GetMethod(
            methodName,
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
        Assert.NotNull(method);
        return Assert.IsAssignableFrom<T>(method.Invoke(target, args));
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
}
