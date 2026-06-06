using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Windows.Forms;
using TabFileEditor.App;

namespace TabFileEditor.App.Tests;

public sealed class RichTextPreviewPanelTests : IDisposable
{
    private readonly string _tempDir = Path.Combine(Path.GetTempPath(), "RichTextPreviewPanelTests", Guid.NewGuid().ToString("N"));

    public RichTextPreviewPanelTests()
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
    public void LoadedFontUsesResolvedFontSizeWithoutAdditionalScaling()
    {
        var fontFile = FindSystemFontFile();
        if (fontFile is null)
        {
            return;
        }

        using var panel = new RichTextPreviewPanel(CreateLoader());
        var spec = new ResolvedFontSpec
        {
            FontFile = fontFile,
            Size = 18,
        };

        var font = InvokeGetFont(panel, spec);

        Assert.Equal(18F, font.Size);
        Assert.Equal(GraphicsUnit.Pixel, font.Unit);
    }

    [Fact]
    public void PreviewPanelTreatsNavigationKeysAsInputKeys()
    {
        using var panel = new RichTextPreviewPanel(CreateLoader());
        panel.CreateControl();

        var method = typeof(RichTextPreviewPanel).GetMethod(
            "IsInputKey",
            BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.NotNull(method);

        Assert.True((bool)method.Invoke(panel, [Keys.Up])!);
        Assert.True((bool)method.Invoke(panel, [Keys.Down])!);
        Assert.True((bool)method.Invoke(panel, [Keys.Left])!);
        Assert.True((bool)method.Invoke(panel, [Keys.Right])!);
        Assert.True((bool)method.Invoke(panel, [Keys.Home])!);
        Assert.True((bool)method.Invoke(panel, [Keys.End])!);
    }

    [Fact]
    public void DownArrowMovesCaretToNextVisualLineClosestToCurrentX()
    {
        RunOnStaThread(() =>
        {
            using var panel = CreatePanelWithTwoVisualLines();
            // Place caret on first line
            SetCaretOffset(panel, 2);
            var offsetBefore = GetCaretOffset(panel);

            SendKeyDown(panel, Keys.Down, shift: false);

            var offsetAfter = GetCaretOffset(panel);
            // Caret should have moved to a different (next) visual line
            Assert.NotEqual(offsetBefore, offsetAfter);
        });
    }

    [Fact]
    public void UpArrowMovesCaretToPreviousVisualLineClosestToCurrentX()
    {
        RunOnStaThread(() =>
        {
            using var panel = CreatePanelWithTwoVisualLines();
            // Place caret on second line (past the \n)
            SetCaretOffset(panel, 12);
            var offsetBefore = GetCaretOffset(panel);

            SendKeyDown(panel, Keys.Up, shift: false);

            var offsetAfter = GetCaretOffset(panel);
            // Caret should have moved back to first line
            Assert.NotEqual(offsetBefore, offsetAfter);
            Assert.True(offsetAfter < 10); // first line is before \n at index 10
        });
    }

    [Fact]
    public void ShiftDownExtendsSelectionWithoutMovingAnchor()
    {
        RunOnStaThread(() =>
        {
            using var panel = CreatePanelWithTwoVisualLines();
            SetCaretOffset(panel, 2);
            var anchorBefore = GetSelectionAnchor(panel);

            SendKeyDown(panel, Keys.Down, shift: true);

            var caretAfter = GetCaretOffset(panel);
            var anchorAfter = GetSelectionAnchor(panel);
            // Anchor should not change
            Assert.Equal(anchorBefore, anchorAfter);
            // Caret should have moved down
            Assert.True(caretAfter > anchorBefore);
        });
    }

    [Fact]
    public void DownAtLastLineKeepsCaretOnLastLine()
    {
        RunOnStaThread(() =>
        {
            using var panel = CreatePanelWithTwoVisualLines();
            // Place caret at the very end (second line end)
            SetCaretOffset(panel, panel.Document.TextLength);

            SendKeyDown(panel, Keys.Down, shift: false);

            var offsetAfter = GetCaretOffset(panel);
            // Should stay at the last position, not go past it
            Assert.Equal(panel.Document.TextLength, offsetAfter);
        });
    }

    [Fact]
    public void RepeatedDownKeepsPreferredColumn()
    {
        RunOnStaThread(() =>
        {
            using var panel = CreatePanelWithThreeVisualLines();
            // Place caret near middle of first line
            SetCaretOffset(panel, 3);

            SendKeyDown(panel, Keys.Down, shift: false);
            var secondLineOffset = GetCaretOffset(panel);

            SendKeyDown(panel, Keys.Down, shift: false);
            var thirdLineOffset = GetCaretOffset(panel);

            // Both moves should succeed (move to different offsets)
            Assert.True(secondLineOffset > 3, "First Down should move to second line");
            Assert.True(thirdLineOffset > secondLineOffset, "Second Down should move to third line");
            // The X positions for second and third line should be close to each other
            // (preferred column is maintained, not drifting to line end)
            var caretPositions = GetCaretPositions(panel);
            var caret2X = GetCaretX(caretPositions[secondLineOffset]);
            var caret3X = GetCaretX(caretPositions[thirdLineOffset]);
            Assert.True(Math.Abs(caret2X - caret3X) < 15f,
                $"Preferred column should be maintained: X2={caret2X}, X3={caret3X}");
        });
    }

    private RichTextPreviewPanel CreatePanelWithTwoVisualLines()
    {
        var panel = new RichTextPreviewPanel(CreateLoader());
        panel.Size = new System.Drawing.Size(400, 300);
        panel.CreateControl();
        // "0123456789\nABCDEFGHIJ" - two lines via explicit newline
        panel.SetDocument(new RichTextDocument(
        [
            new RichTextSegment("0123456789\nABCDEFGHIJ", 0),
        ]));
        return panel;
    }

    private RichTextPreviewPanel CreatePanelWithThreeVisualLines()
    {
        var panel = new RichTextPreviewPanel(CreateLoader());
        panel.Size = new System.Drawing.Size(400, 400);
        panel.CreateControl();
        panel.SetDocument(new RichTextDocument(
        [
            new RichTextSegment("0123456789\nABCDEFGHIJ\nabcdefghij", 0),
        ]));
        return panel;
    }

    private ElemSchemeLoader CreateLoader()
    {
        var elemDir = Path.Combine(_tempDir, "client", "ui", "Scheme", "Elem");
        Directory.CreateDirectory(elemDir);
        return new ElemSchemeLoader(elemDir);
    }

    private static int GetCaretOffset(RichTextPreviewPanel panel)
        => (int)typeof(RichTextPreviewPanel)
            .GetField("_caretOffset", BindingFlags.Instance | BindingFlags.NonPublic)!
            .GetValue(panel)!;

    private static int GetSelectionAnchor(RichTextPreviewPanel panel)
        => (int)typeof(RichTextPreviewPanel)
            .GetField("_selectionAnchor", BindingFlags.Instance | BindingFlags.NonPublic)!
            .GetValue(panel)!;

    private static void SetCaretOffset(RichTextPreviewPanel panel, int offset)
        => panel.SetCaretOffset(offset);

    private static void SendKeyDown(RichTextPreviewPanel panel, Keys key, bool shift)
    {
        var method = typeof(RichTextPreviewPanel).GetMethod(
            "OnKeyDown", BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.NotNull(method);
        var actualKey = shift ? key | Keys.Shift : key;
        method.Invoke(panel, [new KeyEventArgs(actualKey)]);
    }

    private static IReadOnlyList<object> GetCaretPositions(RichTextPreviewPanel panel)
    {
        var layoutMethod = typeof(RichTextPreviewPanel).GetMethod(
            "LayoutDocument", BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.NotNull(layoutMethod);
        using var g = panel.CreateGraphics();
        var layout = layoutMethod.Invoke(panel, [g])!;

        var caretPositionsProp = layout.GetType().GetProperty("CaretPositions");
        Assert.NotNull(caretPositionsProp);
        var list = caretPositionsProp.GetValue(layout) as System.Collections.IEnumerable;
        Assert.NotNull(list);
        return list.Cast<object>().ToList();
    }

    private static float GetCaretX(object caretItem)
        => (float)caretItem.GetType().GetProperty("X")!.GetValue(caretItem)!;

    private static Font InvokeGetFont(RichTextPreviewPanel panel, ResolvedFontSpec spec)
    {
        var method = typeof(RichTextPreviewPanel).GetMethod(
            "GetFont",
            BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.NotNull(method);
        return Assert.IsType<Font>(method.Invoke(panel, [spec]));
    }

    private static string? FindSystemFontFile()
    {
        var fontDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);
        if (string.IsNullOrEmpty(fontDirectory) || !Directory.Exists(fontDirectory))
            return null;

        return Directory.EnumerateFiles(fontDirectory, "*.ttf").FirstOrDefault();
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
