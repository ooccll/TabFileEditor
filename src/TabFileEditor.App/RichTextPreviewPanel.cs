using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace TabFileEditor.App;

internal sealed record LineLayout(
    float X, float Y, float Width, float Height,
    string Text, int CharStart, int CharLength);

internal sealed record SegmentLayout(
    int SegmentIndex, RectangleF Bounds, List<LineLayout> Lines);

internal sealed record HitTestResult(
    int SegmentIndex, int CharIndex, bool IsAtSegmentEnd);

public sealed class RichTextPreviewPanel : Panel
{
    private readonly ElemSchemeLoader _loader;
    private List<RichTextSegment> _segments = [];
    private List<SegmentLayout> _layout = [];
    private readonly Dictionary<(string file, int size), Font> _fontCache = [];
    private readonly Dictionary<string, PrivateFontCollection> _pfcCache = [];
    private const int PaddingPx = 12;
    private const int LineSpacing = 4;
    private const int SegmentEndHitWidth = 14;

    private int _hoveredSegmentIndex = -1;
    private bool _hoverAtSegmentEnd;
    private int _editingSegmentIndex = -1;
    private TextBox? _overlayEditor;
    private ContextMenuStrip? _contextMenu;
    private bool _layoutDirty = true;

    public event Action<int>? SegmentClicked;
    public event Action<int>? NewSegmentRequested;
    public event Action<int>? SegmentDeleteRequested;
    public event Action<int>? SegmentMoveUpRequested;
    public event Action<int>? SegmentMoveDownRequested;
    public event Action<int>? SegmentInsertAfterRequested;
    public event Action? EditingStarted;
    public event Action? EditingFinished;

    public List<RichTextSegment> Segments => _segments;

    public RichTextPreviewPanel(ElemSchemeLoader loader)
    {
        _loader = loader;
        DoubleBuffered = true;
        BackColor = Color.FromArgb(0x1A, 0x1A, 0x2E);
        AutoScroll = true;
    }

    public void SetSegments(List<RichTextSegment> segments)
    {
        _segments = segments;
        _layoutDirty = true;
        Invalidate();
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        _layoutDirty = true;
    }

    #region Layout Engine

    private List<SegmentLayout> ComputeLayout(Graphics g)
    {
        return ComputeLayout(g, ClientSize.Width);
    }

    private List<SegmentLayout> ComputeLayout(Graphics g, int viewportWidth)
    {
        var result = new List<SegmentLayout>();
        var clientWidth = viewportWidth - PaddingPx * 2;
        if (clientWidth <= 0) return result;

        var x = (float)PaddingPx;
        var y = (float)PaddingPx;
        var maxLineHeight = 0f;

        for (var si = 0; si < _segments.Count; si++)
        {
            var segment = _segments[si];
            var spec = _loader.ResolveFont(segment.FontSchemeId);
            var font = GetFont(spec);
            var text = segment.Text;
            var lines = text.Split('\n');

            var segLines = new List<LineLayout>();
            var segTop = y;
            var segRight = x;
            var charOffset = 0;

            for (var i = 0; i < lines.Length; i++)
            {
                if (i > 0)
                {
                    x = PaddingPx;
                    y += maxLineHeight + LineSpacing;
                    maxLineHeight = 0;
                }

                var lineText = lines[i];
                if (string.IsNullOrEmpty(lineText))
                {
                    var lineHeight = font.Height;
                    if (lineHeight > maxLineHeight) maxLineHeight = lineHeight;

                    segLines.Add(new LineLayout(x, y, 0, lineHeight, "", charOffset, 0));
                    charOffset += lineText.Length + 1; // +1 for the \n
                    continue;
                }

                var wrappedLines = WrapText(g, lineText, font, clientWidth - (x - PaddingPx));
                for (var wi = 0; wi < wrappedLines.Count; wi++)
                {
                    var wrappedLine = wrappedLines[wi];
                    var lineHeight = font.Height;
                    if (lineHeight > maxLineHeight) maxLineHeight = lineHeight;

                    var textSize = g.MeasureString(wrappedLine, font);

                    segLines.Add(new LineLayout(x, y, textSize.Width, lineHeight,
                        wrappedLine, charOffset, wrappedLine.Length));

                    charOffset += wrappedLine.Length;

                    if (wi < wrappedLines.Count - 1)
                    {
                        x = PaddingPx;
                        y += maxLineHeight + LineSpacing;
                        maxLineHeight = 0;
                    }
                    else
                    {
                        x += textSize.Width;
                    }

                    segRight = Math.Max(segRight, x);
                }

                charOffset = (i < lines.Length - 1) ? charOffset + 1 : charOffset;
            }

            // Finalize segment: move to next line for next segment
            y += maxLineHeight + LineSpacing;
            x = PaddingPx;

            var bounds = new RectangleF(
                PaddingPx - 2, segTop - 2,
                segRight - PaddingPx + 4, y - segTop - LineSpacing + 4);

            result.Add(new SegmentLayout(si, bounds, segLines));
        }

        return result;
    }

    public Size MeasurePreferredContentSize(int maxViewportWidth)
    {
        using var g = CreateGraphics();
        var viewportWidth = Math.Max(PaddingPx * 2 + 100, Math.Min(maxViewportWidth, MeasurePreferredViewportWidth(g)));
        var layout = ComputeLayout(g, viewportWidth);
        var contentHeight = PaddingPx * 2;
        var contentWidth = viewportWidth;

        if (layout.Count > 0)
        {
            contentHeight = (int)Math.Ceiling(layout[^1].Bounds.Bottom + PaddingPx);
            contentWidth = (int)Math.Ceiling(Math.Max(
                viewportWidth,
                layout.Max(segment => segment.Bounds.Right + PaddingPx)));
        }

        return new Size(
            Math.Min(maxViewportWidth, Math.Max(PaddingPx * 2 + 100, contentWidth)),
            Math.Max(PaddingPx * 2 + 40, contentHeight));
    }

    private int MeasurePreferredViewportWidth(Graphics g)
    {
        var maxLineWidth = 0f;
        foreach (var segment in _segments)
        {
            var spec = _loader.ResolveFont(segment.FontSchemeId);
            var font = GetFont(spec);
            foreach (var line in segment.Text.Split('\n'))
            {
                var width = string.IsNullOrEmpty(line)
                    ? 0
                    : g.MeasureString(line, font).Width;
                maxLineWidth = Math.Max(maxLineWidth, width);
            }
        }

        return (int)Math.Ceiling(maxLineWidth + PaddingPx * 2 + SegmentEndHitWidth);
    }

    private void EnsureLayout(Graphics g)
    {
        if (!_layoutDirty && _layout.Count > 0) return;
        _layout = ComputeLayout(g);
        if (_layout.Count > 0)
        {
            var lastSeg = _layout[^1];
            var totalHeight = lastSeg.Bounds.Bottom + PaddingPx;
            AutoScrollMinSize = new Size(0, (int)totalHeight);
        }
        _layoutDirty = false;
    }

    #endregion

    #region Hit Testing

    private HitTestResult HitTest(Point mousePos)
    {
        if (_layoutDirty || _layout.Count == 0)
        {
            using var g = CreateGraphics();
            EnsureLayout(g);
        }

        var adjusted = new Point(mousePos.X - AutoScrollPosition.X, mousePos.Y - AutoScrollPosition.Y);

        for (var si = 0; si < _layout.Count; si++)
        {
            var seg = _layout[si];
            var spec = _loader.ResolveFont(_segments[si].FontSchemeId);
            var font = GetFont(spec);

            for (var li = 0; li < seg.Lines.Count; li++)
            {
                var line = seg.Lines[li];
                if (string.IsNullOrEmpty(line.Text)) continue;

                if (adjusted.Y >= line.Y && adjusted.Y < line.Y + line.Height)
                {
                    if (adjusted.X >= line.X && adjusted.X < line.X + line.Width)
                    {
                        using var g = CreateGraphics();
                        var charIndex = FindCharIndex(g, font, line, adjusted.X);
                        return new HitTestResult(si, line.CharStart + charIndex, false);
                    }
                }

                // Check segment end on last visible line
                if (li == seg.Lines.Count - 1 || IsLastVisibleLineOfSegment(seg, li))
                {
                    var endX = line.X + line.Width;
                    if (adjusted.Y >= line.Y && adjusted.Y < line.Y + line.Height
                        && adjusted.X >= endX && adjusted.X < endX + SegmentEndHitWidth)
                    {
                        return new HitTestResult(si, line.CharStart + line.CharLength, true);
                    }
                }
            }
        }

        return new HitTestResult(-1, 0, false);
    }

    private bool IsLastVisibleLineOfSegment(SegmentLayout seg, int lineIndex)
    {
        for (var i = lineIndex + 1; i < seg.Lines.Count; i++)
        {
            if (!string.IsNullOrEmpty(seg.Lines[i].Text)) return false;
        }
        return true;
    }

    private int FindCharIndex(Graphics g, Font font, LineLayout line, float mouseX)
    {
        var relativeX = mouseX - line.X;
        if (relativeX <= 0) return 0;

        var text = line.Text;
        var low = 0;
        var high = text.Length;

        while (low < high)
        {
            var mid = (low + high + 1) / 2;
            var width = g.MeasureString(text[..mid], font).Width;
            if (width < relativeX)
                low = mid;
            else
                high = mid - 1;
        }

        return low;
    }

    #endregion

    #region Mouse Interaction

    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);
        if (_overlayEditor != null) return;

        var hit = HitTest(e.Location);
        var changed = _hoveredSegmentIndex != hit.SegmentIndex || _hoverAtSegmentEnd != hit.IsAtSegmentEnd;

        _hoveredSegmentIndex = hit.SegmentIndex;
        _hoverAtSegmentEnd = hit.IsAtSegmentEnd;

        if (hit.IsAtSegmentEnd)
            Cursor = Cursors.Cross;
        else if (hit.SegmentIndex >= 0)
            Cursor = Cursors.IBeam;
        else
            Cursor = Cursors.Default;

        if (changed) Invalidate();
    }

    protected override void OnMouseClick(MouseEventArgs e)
    {
        base.OnMouseClick(e);
        if (e.Button != MouseButtons.Left) return;

        var hit = HitTest(e.Location);

        if (_overlayEditor != null)
        {
            if (hit.SegmentIndex == _editingSegmentIndex)
                return;

            CommitEdit();

            if (hit.IsAtSegmentEnd && hit.SegmentIndex >= 0)
            {
                NewSegmentRequested?.Invoke(hit.SegmentIndex);
            }
            else if (hit.SegmentIndex >= 0)
            {
                SegmentClicked?.Invoke(hit.SegmentIndex);
            }
            return;
        }

        if (hit.IsAtSegmentEnd && hit.SegmentIndex >= 0)
        {
            NewSegmentRequested?.Invoke(hit.SegmentIndex);
        }
        else if (hit.SegmentIndex >= 0)
        {
            SegmentClicked?.Invoke(hit.SegmentIndex);
        }
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        if (e.Button != MouseButtons.Right) return;

        var hit = HitTest(e.Location);
        if (hit.SegmentIndex < 0) return;

        BuildContextMenu(hit.SegmentIndex);
        _contextMenu!.Show(this, e.Location);
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        var changed = _hoveredSegmentIndex != -1 || _hoverAtSegmentEnd;
        _hoveredSegmentIndex = -1;
        _hoverAtSegmentEnd = false;
        Cursor = Cursors.Default;
        if (changed) Invalidate();
    }

    private void BuildContextMenu(int segmentIndex)
    {
        _contextMenu?.Dispose();
        _contextMenu = new ContextMenuStrip();

        _contextMenu.Items.Add("在此之后插入段落", null, (_, _) =>
            SegmentInsertAfterRequested?.Invoke(segmentIndex));

        var deleteItem = _contextMenu.Items.Add("删除段落", null, (_, _) =>
            SegmentDeleteRequested?.Invoke(segmentIndex));
        deleteItem.Enabled = _segments.Count > 1;

        _contextMenu.Items.Add("-");

        var upItem = _contextMenu.Items.Add("上移", null, (_, _) =>
            SegmentMoveUpRequested?.Invoke(segmentIndex));
        upItem.Enabled = segmentIndex > 0;

        var downItem = _contextMenu.Items.Add("下移", null, (_, _) =>
            SegmentMoveDownRequested?.Invoke(segmentIndex));
        downItem.Enabled = segmentIndex < _segments.Count - 1;
    }

    #endregion

    #region Inline Editing

    public void BeginEdit(int segmentIndex)
    {
        if (segmentIndex < 0 || segmentIndex >= _segments.Count) return;

        // Commit any existing edit first
        if (_overlayEditor != null && _editingSegmentIndex >= 0)
            CommitEdit();

        _editingSegmentIndex = segmentIndex;
        _hoveredSegmentIndex = -1;

        using var g = CreateGraphics();
        EnsureLayout(g);

        if (segmentIndex >= _layout.Count) return;

        var segLayout = _layout[segmentIndex];
        var segment = _segments[segmentIndex];
        var spec = _loader.ResolveFont(segment.FontSchemeId);
        var font = GetFont(spec);

        _overlayEditor = new TextBox
        {
            Multiline = true,
            WordWrap = true,
            Font = font,
            ForeColor = spec.FillColor,
            BackColor = Color.FromArgb(0x22, 0x22, 0x38),
            BorderStyle = BorderStyle.FixedSingle,
            Location = new Point(
                (int)segLayout.Bounds.X + AutoScrollPosition.X,
                (int)segLayout.Bounds.Y + AutoScrollPosition.Y),
            Size = new Size(
                Math.Max((int)segLayout.Bounds.Width, 100),
                Math.Max((int)segLayout.Bounds.Height, font.Height + 4)),
            Text = segment.Text,
            AcceptsReturn = true,
            AcceptsTab = false,
            ScrollBars = ScrollBars.None,
        };

        _overlayEditor.LostFocus += OnOverlayLostFocus;
        _overlayEditor.KeyDown += OnOverlayKeyDown;
        _overlayEditor.TextChanged += OnOverlayTextChanged;

        Controls.Add(_overlayEditor);
        _overlayEditor.Focus();
        _overlayEditor.SelectAll();

        EditingStarted?.Invoke();
        Invalidate();
    }

    public void CommitEdit()
    {
        if (_overlayEditor == null || _editingSegmentIndex < 0) return;

        var newText = _overlayEditor.Text.Replace("\r\n", "\n");
        if (_editingSegmentIndex < _segments.Count)
        {
            _segments[_editingSegmentIndex] = _segments[_editingSegmentIndex] with { Text = newText };
        }

        RemoveOverlay();
        _layoutDirty = true;
        Invalidate();
        EditingFinished?.Invoke();
    }

    public void CancelEdit()
    {
        if (_overlayEditor == null) return;
        RemoveOverlay();
        Invalidate();
    }

    private void RemoveOverlay()
    {
        if (_overlayEditor == null) return;
        _overlayEditor.LostFocus -= OnOverlayLostFocus;
        _overlayEditor.KeyDown -= OnOverlayKeyDown;
        _overlayEditor.TextChanged -= OnOverlayTextChanged;
        Controls.Remove(_overlayEditor);
        _overlayEditor.Dispose();
        _overlayEditor = null;
        _editingSegmentIndex = -1;
    }

    private void OnOverlayLostFocus(object? sender, EventArgs e)
    {
        // Delay to allow button clicks (like font picker) to process first
        BeginInvoke(new Action(() =>
        {
            if (_overlayEditor != null && _editingSegmentIndex >= 0)
                CommitEdit();
        }));
    }

    private void OnOverlayKeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
        {
            e.Handled = true;
            CancelEdit();
        }
    }

    private void OnOverlayTextChanged(object? sender, EventArgs e)
    {
        ResizeOverlayEditorToText();
    }

    private void ResizeOverlayEditorToText()
    {
        if (_overlayEditor == null) return;

        using var g = CreateGraphics();
        var layoutX = _overlayEditor.Left - AutoScrollPosition.X;
        var maxWidth = Math.Max(100, ClientSize.Width - PaddingPx - layoutX);
        var measureWidth = Math.Max(1, maxWidth - 8);
        var desiredWidth = 100f;
        var visualLineCount = 0;

        foreach (var rawLine in _overlayEditor.Text.Replace("\r\n", "\n").Replace('\r', '\n').Split('\n'))
        {
            var wrappedLines = WrapText(g, rawLine, _overlayEditor.Font, measureWidth);
            visualLineCount += Math.Max(1, wrappedLines.Count);

            foreach (var wrappedLine in wrappedLines)
            {
                var lineWidth = string.IsNullOrEmpty(wrappedLine)
                    ? 0
                    : g.MeasureString(wrappedLine, _overlayEditor.Font).Width + 10;
                desiredWidth = Math.Max(desiredWidth, lineWidth);
            }
        }

        var desiredHeight = Math.Max(_overlayEditor.Font.Height + 4, visualLineCount * _overlayEditor.Font.Height + 8);
        var maxHeight = Math.Max(_overlayEditor.Font.Height + 4, ClientSize.Height - Math.Max(0, _overlayEditor.Top) - PaddingPx);
        var newSize = new Size(
            (int)Math.Ceiling((double)Math.Min(maxWidth, desiredWidth)),
            (int)Math.Ceiling((double)Math.Min(maxHeight, desiredHeight)));
        var newScrollBars = desiredHeight > maxHeight ? ScrollBars.Vertical : ScrollBars.None;

        if (_overlayEditor.Size != newSize)
            _overlayEditor.Size = newSize;
        if (_overlayEditor.ScrollBars != newScrollBars)
            _overlayEditor.ScrollBars = newScrollBars;

        Invalidate();
    }

    #endregion

    #region Painting

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.TextRenderingHint = TextRenderingHint.AntiAlias;

        g.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y);

        EnsureLayout(g);

        var clientWidth = ClientSize.Width - PaddingPx * 2;
        if (clientWidth <= 0) return;

        // Render text for each segment
        foreach (var segLayout in _layout)
        {
            if (segLayout.SegmentIndex >= _segments.Count) continue;
            var segment = _segments[segLayout.SegmentIndex];
            var spec = _loader.ResolveFont(segment.FontSchemeId);
            var font = GetFont(spec);

            foreach (var line in segLayout.Lines)
            {
                if (string.IsNullOrEmpty(line.Text)) continue;

                // Shadow
                if (spec.ShadowSize > 0)
                {
                    using var shadowBrush = new SolidBrush(Color.FromArgb(180, spec.ShadowColor));
                    g.DrawString(line.Text, font, shadowBrush,
                        line.X + spec.ShadowSize, line.Y + spec.ShadowSize);
                }

                // Border/stroke
                if (spec.BorderSize > 0)
                {
                    using var borderBrush = new SolidBrush(spec.BorderColor);
                    var offsets = spec.BorderSize switch
                    {
                        1 => new (float dx, float dy)[] { (0, -1), (0, 1), (-1, 0), (1, 0) },
                        _ => new (float dx, float dy)[]
                        {
                            (0, -1), (0, 1), (-1, 0), (1, 0),
                            (-1, -1), (-1, 1), (1, -1), (1, 1),
                        }
                    };
                    foreach (var (dx, dy) in offsets)
                        g.DrawString(line.Text, font, borderBrush, line.X + dx, line.Y + dy);
                }

                // Fill
                using var fillBrush = new SolidBrush(spec.FillColor);
                g.DrawString(line.Text, font, fillBrush, line.X, line.Y);
            }
        }

        // Draw overlays
        DrawOverlays(g);
    }

    private void DrawOverlays(Graphics g)
    {
        // Hover border
        if (_hoveredSegmentIndex >= 0 && _hoveredSegmentIndex != _editingSegmentIndex
            && _hoveredSegmentIndex < _layout.Count)
        {
            var bounds = _layout[_hoveredSegmentIndex].Bounds;
            using var pen = new Pen(Color.FromArgb(0x60, 0x00, 0x7A, 0xCC), 1.5f);
            using var brush = new SolidBrush(Color.FromArgb(0x10, 0x00, 0x7A, 0xCC));
            g.FillRectangle(brush, bounds);
            g.DrawRectangle(pen, bounds.X, bounds.Y, bounds.Width, bounds.Height);
        }

        // Edit highlight
        if (_editingSegmentIndex >= 0 && _overlayEditor != null)
        {
            var bounds = new RectangleF(
                _overlayEditor.Location.X - AutoScrollPosition.X - 2,
                _overlayEditor.Location.Y - AutoScrollPosition.Y - 2,
                _overlayEditor.Width + 4,
                _overlayEditor.Height + 4);
            using var pen = new Pen(Color.FromArgb(0x00, 0x7A, 0xCC), 2f);
            using var brush = new SolidBrush(Color.FromArgb(0x18, 0x00, 0x7A, 0xCC));
            g.FillRectangle(brush, bounds);
            g.DrawRectangle(pen, bounds.X, bounds.Y, bounds.Width, bounds.Height);
        }
        else if (_editingSegmentIndex >= 0 && _editingSegmentIndex < _layout.Count)
        {
            var bounds = _layout[_editingSegmentIndex].Bounds;
            using var pen = new Pen(Color.FromArgb(0x00, 0x7A, 0xCC), 2f);
            using var brush = new SolidBrush(Color.FromArgb(0x18, 0x00, 0x7A, 0xCC));
            g.FillRectangle(brush, bounds);
            g.DrawRectangle(pen, bounds.X, bounds.Y, bounds.Width, bounds.Height);
        }

        // New segment cursor
        if (_hoverAtSegmentEnd && _hoveredSegmentIndex >= 0 && _hoveredSegmentIndex < _layout.Count)
        {
            var seg = _layout[_hoveredSegmentIndex];
            var lastLine = seg.Lines.LastOrDefault(l => !string.IsNullOrEmpty(l.Text));
            if (lastLine != null)
            {
                var endX = lastLine.X + lastLine.Width + 2;
                var endY = lastLine.Y + (lastLine.Height - 8) / 2;
                using var pen = new Pen(Color.FromArgb(0x00, 0x7A, 0xCC), 1.5f);
                using var brush = new SolidBrush(Color.FromArgb(0x30, 0x00, 0x7A, 0xCC));
                g.FillRectangle(brush, endX, endY, 8, 8);
                g.DrawRectangle(pen, endX, endY, 8, 8);
            }
        }
    }

    #endregion

    #region Font Helpers

    internal Font GetFont(ResolvedFontSpec spec)
    {
        var key = (spec.FontFile, spec.Size);
        if (_fontCache.TryGetValue(key, out var cached))
            return cached;

        Font font;
        if (!string.IsNullOrEmpty(spec.FontFile) && File.Exists(spec.FontFile))
        {
            try
            {
                if (!_pfcCache.TryGetValue(spec.FontFile, out var pfc))
                {
                    pfc = new PrivateFontCollection();
                    pfc.AddFontFile(spec.FontFile);
                    _pfcCache[spec.FontFile] = pfc;
                }

                if (pfc.Families.Length > 0)
                {
                    font = new Font(pfc.Families[0], spec.Size, GraphicsUnit.Point);
                }
                else
                {
                    font = new Font("Microsoft YaHei UI", spec.Size, GraphicsUnit.Point);
                }
            }
            catch
            {
                font = new Font("Microsoft YaHei UI", spec.Size, GraphicsUnit.Point);
            }
        }
        else
        {
            font = new Font("Microsoft YaHei UI", spec.Size, GraphicsUnit.Point);
        }

        _fontCache[key] = font;
        return font;
    }

    private static List<string> WrapText(Graphics g, string text, Font font, float maxWidth)
    {
        var result = new List<string>();
        if (string.IsNullOrEmpty(text))
        {
            result.Add(text);
            return result;
        }

        var currentLine = "";
        foreach (var ch in text)
        {
            var testLine = currentLine + ch;
            var testWidth = g.MeasureString(testLine, font).Width;
            if (testWidth > maxWidth && currentLine.Length > 0)
            {
                result.Add(currentLine);
                currentLine = ch.ToString();
            }
            else
            {
                currentLine = testLine;
            }
        }

        if (currentLine.Length > 0)
            result.Add(currentLine);

        return result;
    }

    #endregion

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _overlayEditor?.Dispose();
            _contextMenu?.Dispose();

            foreach (var font in _fontCache.Values)
                font.Dispose();
            _fontCache.Clear();

            foreach (var pfc in _pfcCache.Values)
                pfc.Dispose();
            _pfcCache.Clear();
        }
        base.Dispose(disposing);
    }
}
