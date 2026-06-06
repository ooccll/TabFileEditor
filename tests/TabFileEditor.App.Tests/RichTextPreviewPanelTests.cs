using System.Reflection;
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

    private ElemSchemeLoader CreateLoader()
    {
        var elemDir = Path.Combine(_tempDir, "client", "ui", "Scheme", "Elem");
        Directory.CreateDirectory(elemDir);
        return new ElemSchemeLoader(elemDir);
    }

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
}
