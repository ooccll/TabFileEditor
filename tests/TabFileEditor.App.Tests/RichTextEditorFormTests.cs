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
            Directory.Delete(_tempDir, recursive: true);
    }

    [Fact]
    public void RichTextEditorFormSizesToContentWithinScreen()
    {
        RunOnStaThread(() =>
        {
            using var form = new RichTextEditorForm("<text>text=\"短文本\" font=18</text>", CreateLoader());
            form.CreateControl();

            var workingArea = Screen.FromControl(form).WorkingArea;

            Assert.True(form.Width < 900);
            Assert.True(form.Height < 750);
            Assert.True(form.Width <= workingArea.Width);
            Assert.True(form.Height <= workingArea.Height);
        });
    }

    [Fact]
    public void ClickingBlankAreaCommitsActiveRichTextEdit()
    {
        RunOnStaThread(() =>
        {
            using var panel = CreatePanel([new RichTextSegment("原文字", 18)]);
            panel.BeginEdit(0);
            var editor = FindOverlayEditor(panel);
            editor.Text = "修改后的文字";

            InvokeMouseClick(panel, new Point(panel.ClientSize.Width - 20, panel.ClientSize.Height - 20));

            Assert.Null(FindOverlayEditorOrNull(panel));
            Assert.Equal("修改后的文字", panel.Segments[0].Text);
        });
    }

    [Fact]
    public void RichTextOverlayEditorResizesWhenTextChanges()
    {
        RunOnStaThread(() =>
        {
            using var panel = CreatePanel([new RichTextSegment("短文本", 18)]);
            panel.BeginEdit(0);
            var editor = FindOverlayEditor(panel);
            var initialHeight = editor.Height;

            editor.Text = "第一行\r\n第二行\r\n第三行";

            Assert.True(editor.Height > initialHeight);
        });
    }

    [Fact]
    public void ClickingAnotherSegmentCommitsCurrentEditAndStartsNextEdit()
    {
        RunOnStaThread(() =>
        {
            using var panel = CreatePanel([
                new RichTextSegment("第一段", 18),
                new RichTextSegment("第二段", 18),
            ]);
            panel.SegmentClicked += panel.BeginEdit;
            panel.BeginEdit(0);
            var editor = FindOverlayEditor(panel);
            editor.Text = "第一段修改";

            InvokeMouseClick(panel, new Point(20, 45));

            var nextEditor = FindOverlayEditor(panel);
            Assert.Equal("第一段修改", panel.Segments[0].Text);
            Assert.Equal("第二段", nextEditor.Text);
        });
    }

    private RichTextPreviewPanel CreatePanel(List<RichTextSegment> segments)
    {
        var panel = new RichTextPreviewPanel(CreateLoader())
        {
            Size = new Size(420, 240),
        };
        panel.CreateControl();
        panel.SetSegments(segments);
        return panel;
    }

    private ElemSchemeLoader CreateLoader()
    {
        var elemDir = Path.Combine(_tempDir, "Elem");
        Directory.CreateDirectory(elemDir);
        return new ElemSchemeLoader(elemDir);
    }

    private static TextBox FindOverlayEditor(Control parent)
    {
        var editor = FindOverlayEditorOrNull(parent);
        Assert.NotNull(editor);
        return editor;
    }

    private static TextBox? FindOverlayEditorOrNull(Control parent)
    {
        foreach (Control child in parent.Controls)
        {
            if (child is TextBox textBox)
                return textBox;

            var nested = FindOverlayEditorOrNull(child);
            if (nested is not null)
                return nested;
        }
        return null;
    }

    private static void InvokeMouseClick(RichTextPreviewPanel panel, Point location)
    {
        var method = typeof(RichTextPreviewPanel).GetMethod(
            "OnMouseClick",
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
        Assert.NotNull(method);
        method.Invoke(panel, [new MouseEventArgs(MouseButtons.Left, 1, location.X, location.Y, 0)]);
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
}
