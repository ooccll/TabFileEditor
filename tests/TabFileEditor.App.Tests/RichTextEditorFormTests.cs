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

            Assert.Same(editor, FindOverlayEditor(panel));
            Assert.Equal("修改后的文字", panel.Segments[0].Text);
        });
    }

    [Fact]
    public void RichTextEditorFormKeepsTextAfterBlankClickCommit()
    {
        RunOnStaThread(() =>
        {
            using var form = new RichTextEditorForm("<text>text=\"原文字\" font=18</text>", CreateLoader());
            form.CreateControl();
            var panel = FindDescendant<RichTextPreviewPanel>(form);
            panel.BeginEdit(0);
            var editor = FindOverlayEditor(panel);
            editor.Text = "修改后的文字";

            InvokeMouseClick(panel, new Point(panel.ClientSize.Width - 20, panel.ClientSize.Height - 20));
            InvokePrivate(form, "OnOkClick", null!, EventArgs.Empty);

            Assert.Contains("修改后的文字", form.ResultMarkup);
            Assert.Contains("<text>", form.ResultMarkup);
        });
    }

    [Fact]
    public void RichTextEditorFormShowsEditableTextBoxesWithoutEnteringEditMode()
    {
        RunOnStaThread(() =>
        {
            using var form = new RichTextEditorForm(
                "<text>text=\"第一段\" font=18</text><text>text=\"第二段\" font=19</text>",
                CreateLoader());
            form.CreateControl();
            var panel = FindDescendant<RichTextPreviewPanel>(form);

            var editors = FindDescendants<TextBox>(panel);

            Assert.Equal(2, editors.Count);
            Assert.All(editors, editor =>
            {
                Assert.False(editor.ReadOnly);
                Assert.True(editor.Multiline);
                Assert.Equal(BorderStyle.FixedSingle, editor.BorderStyle);
            });
            Assert.Collection(
                editors.OrderBy(editor => editor.Top).ThenBy(editor => editor.Left),
                editor => Assert.Equal("第一段", editor.Text),
                editor => Assert.Equal("第二段", editor.Text));
        });
    }

    [Fact]
    public void EditingDirectTextBoxUpdatesResultMarkup()
    {
        RunOnStaThread(() =>
        {
            using var form = new RichTextEditorForm("<text>text=\"原文字\" font=18</text>", CreateLoader());
            form.CreateControl();
            var panel = FindDescendant<RichTextPreviewPanel>(form);
            var editor = Assert.Single(FindDescendants<TextBox>(panel));

            editor.Text = "直接修改";
            InvokePrivate(form, "OnOkClick", null!, EventArgs.Empty);

            Assert.Contains("直接修改", form.ResultMarkup);
            Assert.Contains("font=18", form.ResultMarkup);
        });
    }

    [Fact]
    public void HoveringRichTextSegmentShowsActionButtons()
    {
        RunOnStaThread(() =>
        {
            using var panel = CreatePanel([new RichTextSegment("原文字", 18)]);
            var editor = Assert.Single(FindDescendants<TextBox>(panel));

            InvokeControlMouseEnter(editor);

            var buttons = FindDescendants<Button>(panel);
            Assert.Contains(buttons, button => button.Text == "改变字体" && button.Visible);
            Assert.Contains(buttons, button => button.Text == "文本末尾新增字符串" && button.Visible);
        });
    }

    [Fact]
    public void ApplyingFontSchemeUpdatesCurrentRichTextSegment()
    {
        RunOnStaThread(() =>
        {
            using var panel = CreatePanel([new RichTextSegment("原文字", 18)]);

            InvokePrivate(panel, "ApplyFontSchemeToSegment", 0, 19);

            Assert.Equal(19, panel.Segments[0].FontSchemeId);
        });
    }

    [Fact]
    public void AppendingTextAddsToCurrentRichTextSegment()
    {
        RunOnStaThread(() =>
        {
            using var panel = CreatePanel([new RichTextSegment("原文字", 18)]);

            InvokePrivate(panel, "AppendTextToSegment", 0, "追加");

            Assert.Equal("原文字追加", panel.Segments[0].Text);
            Assert.Equal("原文字追加", Assert.Single(FindDescendants<TextBox>(panel)).Text);
        });
    }

    [Fact]
    public void RichTextPreviewPanelDoesNotMutateSourceSegmentList()
    {
        RunOnStaThread(() =>
        {
            var sourceSegments = new List<RichTextSegment> { new("原文字", 18) };
            using var panel = CreatePanel(sourceSegments);
            panel.BeginEdit(0);
            FindOverlayEditor(panel).Text = "修改后的文字";

            panel.CommitEdit();

            Assert.Equal("原文字", sourceSegments[0].Text);
            Assert.Equal("修改后的文字", panel.Segments[0].Text);
        });
    }

    [Fact]
    public void RichTextOverlayEditorKeepsWrappedLayoutWidthWhenTextChanges()
    {
        RunOnStaThread(() =>
        {
            var longText = string.Concat(Enumerable.Repeat("这是一段需要自动换行的富文本内容", 8));
            using var panel = CreatePanel([new RichTextSegment(longText, 18)]);
            panel.Size = new Size(240, 240);
            panel.BeginEdit(0);
            var editor = FindOverlayEditor(panel);
            var initialWidth = editor.Width;

            editor.Text = longText + longText;

            Assert.Equal(initialWidth, editor.Width);
            Assert.True(editor.Height > editor.Font.Height * 2);
            Assert.True(editor.Width <= panel.ClientSize.Width - 24);
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

            var editors = FindDescendants<TextBox>(panel)
                .OrderBy(textBox => textBox.Top)
                .ThenBy(textBox => textBox.Left)
                .ToList();
            Assert.Equal("第一段修改", panel.Segments[0].Text);
            Assert.Equal("第二段", editors[1].Text);
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

    private static List<TControl> FindDescendants<TControl>(Control parent)
        where TControl : Control
    {
        var result = new List<TControl>();
        foreach (Control child in parent.Controls)
        {
            if (child is TControl match)
                result.Add(match);

            result.AddRange(FindDescendants<TControl>(child));
        }
        return result;
    }

    private static TControl FindDescendant<TControl>(Control parent)
        where TControl : Control
    {
        foreach (Control child in parent.Controls)
        {
            if (child is TControl match)
                return match;

            var nested = FindDescendantOrNull<TControl>(child);
            if (nested is not null)
                return nested;
        }

        throw new InvalidOperationException($"Could not find {typeof(TControl).Name}.");
    }

    private static TControl? FindDescendantOrNull<TControl>(Control parent)
        where TControl : Control
    {
        foreach (Control child in parent.Controls)
        {
            if (child is TControl match)
                return match;

            var nested = FindDescendantOrNull<TControl>(child);
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

    private static void InvokeControlMouseEnter(Control control)
    {
        var method = typeof(Control).GetMethod(
            "OnMouseEnter",
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
        Assert.NotNull(method);
        method.Invoke(control, [EventArgs.Empty]);
    }

    private static void InvokePrivate(object target, string methodName, params object[] args)
    {
        var method = target.GetType().GetMethod(
            methodName,
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
        Assert.NotNull(method);
        method.Invoke(target, args);
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
