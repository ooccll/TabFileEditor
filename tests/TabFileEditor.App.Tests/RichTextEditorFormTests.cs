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
    public void FormUsesEditablePreviewAndMarkupTextBox()
    {
        RunOnStaThread(() =>
        {
            using var form = CreateForm();
            form.Show();
            Application.DoEvents();

            Assert.Single(FindDescendants<RichTextPreviewPanel>(form));
            var markupTextBox = Assert.Single(FindDescendants<TextBox>(form), textBox => textBox.Name == "MarkupTextBox");
            Assert.True(markupTextBox.WordWrap);
            Assert.Equal(ScrollBars.Vertical, markupTextBox.ScrollBars);
            Assert.Empty(FindDescendants<DataGridView>(form));
        });
    }

    [Fact]
    public void PreviewTextInputSynchronizesMarkupTextBox()
    {
        RunOnStaThread(() =>
        {
            using var form = CreateForm();
            form.Show();
            Application.DoEvents();

            var preview = FindDescendants<RichTextPreviewPanel>(form).Single();
            var markupTextBox = FindMarkupTextBox(form);

            preview.SetCaretOffset(5);
            preview.InsertTextAtCaret("!");
            Application.DoEvents();

            Assert.Equal("<text>text=\"Hello!World\" font=0</text>",
                markupTextBox.Text);
        });
    }

    [Fact]
    public void InvalidMarkupTextDisablesOkButtonAndKeepsLastValidPreviewDocument()
    {
        RunOnStaThread(() =>
        {
            using var form = CreateForm();
            form.Show();
            Application.DoEvents();

            var preview = FindDescendants<RichTextPreviewPanel>(form).Single();
            var markupTextBox = FindMarkupTextBox(form);
            var okButton = FindDescendants<Button>(form).Single(button => button.Text == "确定");

            markupTextBox.Text = "<text>text=\"Broken\" font=0";
            Application.DoEvents();

            Assert.False(okButton.Enabled);
            Assert.Equal("HelloWorld", preview.Document.GetPlainText());
            Assert.Equal("<text>text=\"Broken\" font=0", markupTextBox.Text);
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

    private static TextBox FindMarkupTextBox(Form form)
    {
        return FindDescendants<TextBox>(form).Single(textBox => textBox.Name == "MarkupTextBox");
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
