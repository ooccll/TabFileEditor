using System.Drawing.Drawing2D;
using TabFileEditor.Core;

namespace TabFileEditor.App;

public sealed class FrameSelectorForm : Form
{
    private readonly UitexData _data;
    private readonly AtlasPanel _atlasPanel;
    private readonly Label _statusLabel;

    public int SelectedFrameIndex { get; private set; } = -1;

    public FrameSelectorForm(UitexData data, Bitmap atlasImage, string displayTitle)
    {
        _data = data;

        Text = $"选择帧 - {displayTitle}";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.Sizable;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;

        var statusHeight = 36;

        ClientSize = new Size(atlasImage.Width, atlasImage.Height + statusHeight);
        AutoScroll = true;

        _atlasPanel = new AtlasPanel(data, atlasImage)
        {
            Dock = DockStyle.Fill,
        };
        _atlasPanel.FrameClicked += OnFrameClicked;
        _atlasPanel.FrameHoverChanged += OnFrameHoverChanged;

        _statusLabel = new Label
        {
            Dock = DockStyle.Bottom,
            Height = statusHeight,
            TextAlign = ContentAlignment.MiddleLeft,
            Font = new Font("Microsoft YaHei UI", 9F),
            ForeColor = Color.FromArgb(0x47, 0x55, 0x69),
            BackColor = Color.FromArgb(0xF6, 0xF8, 0xFB),
            Padding = new Padding(8, 0, 8, 0),
            Text = $"共 {data.FrameCount} 帧，点击选择帧",
        };

        Controls.Add(_atlasPanel);
        Controls.Add(_statusLabel);

        KeyPreview = true;
        KeyDown += (_, e) =>
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        };
    }

    private void OnFrameClicked(int frameIndex)
    {
        SelectedFrameIndex = frameIndex;
        DialogResult = DialogResult.OK;
        Close();
    }

    private void OnFrameHoverChanged(int? frameIndex)
    {
        if (frameIndex.HasValue)
        {
            var frame = _data.Frames[frameIndex.Value];
            _statusLabel.Text = $"帧 {frameIndex.Value}    {frame.Width} × {frame.Height}    点击选择此帧";
        }
        else
        {
            _statusLabel.Text = $"共 {_data.FrameCount} 帧，点击选择帧";
        }
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        _atlasPanel.FrameClicked -= OnFrameClicked;
        _atlasPanel.FrameHoverChanged -= OnFrameHoverChanged;
        base.OnFormClosed(e);
    }
}

internal sealed class AtlasPanel : Panel
{
    private readonly UitexData _data;
    private readonly Bitmap _atlasImage;
    private int? _hoveredFrameIndex;

    public event Action<int>? FrameClicked;
    public event Action<int?>? FrameHoverChanged;

    public AtlasPanel(UitexData data, Bitmap atlasImage)
    {
        _data = data;
        _atlasImage = atlasImage;
        DoubleBuffered = true;
        BackColor = Color.FromArgb(0x1A, 0x1A, 0x1A);
    }

    protected override void OnResize(EventArgs eventargs)
    {
        base.OnResize(eventargs);
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
        e.Graphics.DrawImage(_atlasImage, 0, 0);

        // 所有帧边界线（淡灰色）
        using var dimPen = new Pen(Color.FromArgb(40, 255, 255, 255), 1);
        foreach (var frame in _data.Frames)
        {
            if (frame.Width <= 0 || frame.Height <= 0) continue;
            var rect = FrameToDisplayRect(frame);
            e.Graphics.DrawRectangle(dimPen, rect);
        }

        // 悬停帧高亮
        if (_hoveredFrameIndex.HasValue)
        {
            var hoverFrame = _data.Frames[_hoveredFrameIndex.Value];
            if (hoverFrame.Width > 0 && hoverFrame.Height > 0)
            {
                var rect = FrameToDisplayRect(hoverFrame);

                using var fillBrush = new SolidBrush(Color.FromArgb(40, 0, 170, 255));
                e.Graphics.FillRectangle(fillBrush, rect);

                using var borderPen = new Pen(Color.FromArgb(200, 0, 170, 255), 2);
                e.Graphics.DrawRectangle(borderPen, rect);

                // 帧号标签
                var labelText = $"帧 {_hoveredFrameIndex.Value}";
                using var labelFont = new Font("Microsoft YaHei UI", 8F);
                var labelSize = TextRenderer.MeasureText(labelText, labelFont);
                var labelX = rect.Left;
                var labelY = rect.Top - labelSize.Height - 2;
                if (labelY < 0) labelY = rect.Top + 2;

                using var labelBg = new SolidBrush(Color.FromArgb(180, 0, 170, 255));
                e.Graphics.FillRectangle(labelBg, labelX, labelY, labelSize.Width + 4, labelSize.Height + 2);
                TextRenderer.DrawText(e.Graphics, labelText, labelFont,
                    new Point(labelX + 2, labelY + 1), Color.White);
            }
        }
    }

    private Rectangle FrameToDisplayRect(FrameInfo frame)
    {
        return new Rectangle(frame.Left, frame.Top, frame.Width, frame.Height);
    }

    private int? HitTestFrame(Point mousePos)
    {
        for (var i = 0; i < _data.Frames.Count; i++)
        {
            var f = _data.Frames[i];
            if (f.Width <= 0 || f.Height <= 0) continue;
            if (mousePos.X >= f.Left && mousePos.X < f.Left + f.Width &&
                mousePos.Y >= f.Top && mousePos.Y < f.Top + f.Height)
            {
                return i;
            }
        }
        return null;
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);
        var hit = HitTestFrame(e.Location);
        if (hit != _hoveredFrameIndex)
        {
            _hoveredFrameIndex = hit;
            Cursor = hit.HasValue ? Cursors.Hand : Cursors.Default;
            FrameHoverChanged?.Invoke(hit);
            Invalidate();
        }
    }

    protected override void OnMouseClick(MouseEventArgs e)
    {
        base.OnMouseClick(e);
        var hit = HitTestFrame(e.Location);
        if (hit.HasValue)
        {
            FrameClicked?.Invoke(hit.Value);
        }
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        if (_hoveredFrameIndex.HasValue)
        {
            _hoveredFrameIndex = null;
            Cursor = Cursors.Default;
            FrameHoverChanged?.Invoke(null);
            Invalidate();
        }
    }
}
