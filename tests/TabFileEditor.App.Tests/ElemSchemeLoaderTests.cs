using TabFileEditor.App;
using System.Text;

namespace TabFileEditor.App.Tests;

public sealed class ElemSchemeLoaderTests : IDisposable
{
    private readonly string _tempDir = Path.Combine(Path.GetTempPath(), "ElemSchemeLoaderTests", Guid.NewGuid().ToString("N"));

    public ElemSchemeLoaderTests()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Directory.CreateDirectory(_tempDir);
    }

    public void Dispose()
    {
        if (Directory.Exists(_tempDir))
        {
            Directory.Delete(_tempDir, recursive: true);
        }
    }

    [Theory]
    [InlineData("gamefont.ttf")]
    [InlineData("Font\\gamefont.ttf")]
    [InlineData("UI\\Font\\gamefont.ttf")]
    public void ResolveFontUsesFixedUiFontDirectory(string configuredPath)
    {
        var uiRoot = Path.Combine(_tempDir, "client", "ui");
        var elemDir = Path.Combine(uiRoot, "Scheme", "Elem");
        var fontDir = Path.Combine(uiRoot, "Font");
        Directory.CreateDirectory(elemDir);
        Directory.CreateDirectory(fontDir);
        File.WriteAllText(Path.Combine(fontDir, "gamefont.ttf"), "");

        File.WriteAllText(Path.Combine(elemDir, "Font.ini"), """
            [18]
            FontID=1
            Size=18
            """);
        File.WriteAllText(Path.Combine(elemDir, "fontlist.ini"), $$"""
            [1]
            File={{configuredPath}}
            Size=16
            """);

        var loader = new ElemSchemeLoader(elemDir);

        var spec = loader.ResolveFont(18);

        Assert.Equal(Path.Combine(fontDir, "gamefont.ttf"), spec.FontFile);
    }
}
