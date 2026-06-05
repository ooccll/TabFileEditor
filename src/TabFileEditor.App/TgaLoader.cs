using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace TabFileEditor.App;

public static class TgaLoader
{
    public static Bitmap Load(string path)
    {
        using var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
        using var reader = new BinaryReader(stream);

        // TGA 文件头（18 字节）
        var idLength = reader.ReadByte();       // 0: ID 字段长度
        _ = reader.ReadByte();                  // 1: 颜色表类型
        var imageType = reader.ReadByte();       // 2: 图像类型（2=无压缩真彩色, 10=RLE压缩真彩色）
        _ = reader.ReadBytes(5);                // 3-7: 颜色表规格
        var xOrigin = reader.ReadInt16();       // 8-9: X 原点
        var yOrigin = reader.ReadInt16();       // 10-11: Y 原点
        var width = reader.ReadInt16();         // 12-13: 宽度
        var height = reader.ReadInt16();        // 14-15: 高度
        var pixelDepth = reader.ReadByte();     // 16: 像素深度（24 或 32）
        var imageDescriptor = reader.ReadByte(); // 17: 图像描述符（bit 5 = 原点位置）

        if (imageType != 2 && imageType != 10)
            throw new InvalidDataException($"不支持的 TGA 图像类型：{imageType}（仅支持类型 2 和 10）。");

        if (pixelDepth != 24 && pixelDepth != 32)
            throw new InvalidDataException($"不支持的 TGA 像素深度：{pixelDepth}（仅支持 24 和 32 位）。");

        // 跳过 ID 字段和颜色表
        if (idLength > 0)
            _ = reader.ReadBytes(idLength);

        var bytesPerPixel = pixelDepth / 8;
        var rowSize = width * bytesPerPixel;
        var pixelCount = width * height;

        // 解码像素数据（BGR 或 BGRA）
        byte[] rawPixels;
        if (imageType == 2)
        {
            // 无压缩：直接读取
            rawPixels = reader.ReadBytes(pixelCount * bytesPerPixel);
        }
        else
        {
            // RLE 压缩：解包
            rawPixels = DecodeRle(reader, width, height, bytesPerPixel);
        }

        // 转换为 32-bit ARGB 像素数组
        var argbPixels = new byte[width * height * 4];
        for (var i = 0; i < width * height; i++)
        {
            var srcOffset = i * bytesPerPixel;
            var dstOffset = i * 4;

            // Format32bppArgb 内存布局为 BGRA，与 TGA 原始像素顺序一致
            argbPixels[dstOffset + 0] = rawPixels[srcOffset + 0]; // B
            argbPixels[dstOffset + 1] = rawPixels[srcOffset + 1]; // G
            argbPixels[dstOffset + 2] = rawPixels[srcOffset + 2]; // R

            if (bytesPerPixel == 4)
                argbPixels[dstOffset + 3] = rawPixels[srcOffset + 3]; // A
            else
                argbPixels[dstOffset + 3] = 0xFF; // 24-bit 无 Alpha，设为不透明
        }

        // 垂直翻转：TGA 原点在左下时需要翻转
        var originTopLeft = (imageDescriptor & 0x20) != 0;
        if (!originTopLeft)
        {
            var rowBytes = width * 4;
            var tempRow = new byte[rowBytes];
            for (var y = 0; y < height / 2; y++)
            {
                var topOffset = y * rowBytes;
                var bottomOffset = (height - 1 - y) * rowBytes;
                Buffer.BlockCopy(argbPixels, topOffset, tempRow, 0, rowBytes);
                Buffer.BlockCopy(argbPixels, bottomOffset, argbPixels, topOffset, rowBytes);
                Buffer.BlockCopy(tempRow, 0, argbPixels, bottomOffset, rowBytes);
            }
        }

        // 写入 Bitmap
        var bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
        var bmpData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
        try
        {
            Marshal.Copy(argbPixels, 0, bmpData.Scan0, argbPixels.Length);
        }
        finally
        {
            bitmap.UnlockBits(bmpData);
        }

        return bitmap;
    }

    private static byte[] DecodeRle(BinaryReader reader, int width, int height, int bytesPerPixel)
    {
        var pixelCount = width * height;
        var result = new byte[pixelCount * bytesPerPixel];
        var writeOffset = 0;

        while (writeOffset < result.Length)
        {
            var packetHeader = reader.ReadByte();
            var runLength = (packetHeader & 0x7F) + 1;

            if ((packetHeader & 0x80) != 0)
            {
                // RLE 包：重复单个像素 runLength 次
                var pixel = reader.ReadBytes(bytesPerPixel);
                for (var i = 0; i < runLength; i++)
                {
                    Buffer.BlockCopy(pixel, 0, result, writeOffset, bytesPerPixel);
                    writeOffset += bytesPerPixel;
                }
            }
            else
            {
                // 原始包：直接读取 runLength 个像素
                var rawData = reader.ReadBytes(runLength * bytesPerPixel);
                Buffer.BlockCopy(rawData, 0, result, writeOffset, rawData.Length);
                writeOffset += rawData.Length;
            }
        }

        return result;
    }
}
