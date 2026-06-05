namespace TabFileEditor.Core;

public sealed class FrameInfo
{
    public int Left { get; }
    public int Top { get; }
    public int Width { get; }
    public int Height { get; }

    public FrameInfo(int left, int top, int width, int height)
    {
        Left = left;
        Top = top;
        Width = width;
        Height = height;
    }
}

public sealed class UitexData
{
    public IReadOnlyList<FrameInfo> Frames { get; }
    public string TgaFilePath { get; }
    public int FrameCount => Frames.Count;

    public UitexData(IReadOnlyList<FrameInfo> frames, string tgaFilePath)
    {
        Frames = frames;
        TgaFilePath = tgaFilePath;
    }
}

public static class UitexParser
{
    public static UitexData Read(string uitexFilePath)
    {
        if (!File.Exists(uitexFilePath))
            throw new FileNotFoundException($"找不到 UITex 文件：{uitexFilePath}", uitexFilePath);

        var tgaFilePath = Path.ChangeExtension(uitexFilePath, ".tga");

        var frames = new List<FrameInfo>();
        using (var stream = new FileStream(uitexFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete))
        using (var reader = new BinaryReader(stream))
        {
            // 文件头: 88 bytes = 6 ints (4 each) + 2 char[32]
            _ = reader.ReadInt32();   // nUiTexFlag
            _ = reader.ReadInt32();   // nWidth
            _ = reader.ReadInt32();   // nHeight
            var nFrameCount = reader.ReadInt32();
            _ = reader.ReadInt32();   // nAnimateCount
            _ = reader.ReadInt32();   // dwFileLen
            // szTgaFileName: 忽略头部中的 TGA 文件名，使用与 .uitex 同名推导
            _ = reader.ReadBytes(32); // szTgaFileName
            _ = reader.ReadBytes(32); // szBuffer

            // 帧数边界检查
            const int HeaderSize = 88;
            const int FrameSize = 20;
            var remainingBytes = stream.Length - HeaderSize;
            var maxPossibleFrames = remainingBytes / FrameSize;
            if (nFrameCount < 0 || nFrameCount > maxPossibleFrames)
                throw new InvalidDataException($"uitex 文件格式无效：帧数 {nFrameCount} 超出文件大小限制（最大 {maxPossibleFrames}）。");

            // 帧数据: 20 bytes each
            for (var i = 0; i < nFrameCount; i++)
            {
                _ = reader.ReadInt32(); // dwInfo
                var nLeft = reader.ReadInt32();
                var nTop = reader.ReadInt32();
                var nWidth = reader.ReadInt32();
                var nHeight = reader.ReadInt32();
                frames.Add(new FrameInfo(nLeft, nTop, nWidth, nHeight));
            }
        }

        return new UitexData(frames, tgaFilePath);
    }
}
