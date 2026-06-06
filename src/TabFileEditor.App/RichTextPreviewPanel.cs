using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace TabFileEditor.App;

public sealed class RichTextPreviewPanel : Panel
{
    private readonly ElemSchemeLoader _loader;
    private readonly Dictionary<(string file, int size), Font> _fontCache = [];
    private readonly Dictionary<string, PrivateFontCollection> _pfcCache = [];
    private readonly ContextMenuStrip _contextMenu = new();
    private int _caretOffset;
    private int _selectionAnchor;
    private bool _draggingSelection;

    private const int PaddingPx = 12;
    private const int LineSpacing = 4;
    private const int CharSpacing = -3;

    public event EventHandler? DocumentChanged;

    public RichTextDocument Document { get; private set; } = new();

    public RichTextPreviewPanel(ElemSchemeLoader loader)
    {
        _loader = loader;
        DoubleBuffered = true;
        BackColor = Color.FromArgb(0x1A, 0x1A, 0x2E);
        AutoScroll = true;
        TabStop = true;
        Cursor = Cursors.IBeam;

        _contextMenu.Opening += (_, e) =>
        {
            _contextMenu.Items[0].Enabled = SelectionLength > 0;
            e.Cancel = false;
        };
        _contextMenu.Items.Add("更改字体", null, (_, _) => ChangeSelectedFont());
        ContextMenuStrip = _contextMenu;
    }

    public void SetDocument(RichTextDocument document)
    {
        Document = new RichTextDocument(document.Segments.ToList());
        SetCaretOffset(Math.Min(_caretOffset, Document.TextLength));
        Invalidate();
    }

    public void SetSegments(List<RichTextSegment> segments)
        => SetDocument(new RichTextDocument(segments));

    public void SetCaretOffset(int offset)
    {
        _caretOffset = Math.Clamp(offset, 0, Document.TextLength);
        _selectionAnchor = _caretOffset;
        Invalidate();
    }

    public void InsertTextAtCaret(string text)
    {
        if (string.IsNullOrEmpty(text)) return;

        DeleteSelection();
        var fontSchemeId = Document.GetFontAt(_caretOffset);
        Document.InsertText(_caretOffset, text, fontSchemeId);
        _caretOffset += text.Length;
        _selectionAnchor = _caretOffset;
        RaiseDocumentChanged();
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.TextRenderingHint = TextRenderingHint.AntiAlias;
        g.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y);

        var layout = LayoutDocument(g);
        foreach (var item in layout.Items)
        {
            if (item.Offset >= SelectionStart && item.Offset < SelectionEnd)
            {
                using var selectionBrush = new SolidBrush(Color.FromArgb(120, 0x33, 0x99, 0xFF));
                g.FillRectangle(selectionBrush, item.Bounds);
            }

            DrawStyledText(g, item.Text, item.Font, item.Spec, item.Bounds.Location);
        }

        if (Focused && _caretOffset >= 0 && _caretOffset < layout.CaretPositions.Count)
        {
            var caret = layout.CaretPositions[_caretOffset];
            using var caretPen = new Pen(Color.White, 1.5f);
            g.DrawLine(caretPen, caret.X, caret.Y, caret.X, caret.Y + caret.Height);
        }

        AutoScrollMinSize = new Size(0, Math.Max(0, (int)Math.Ceiling(layout.Height + PaddingPx)));
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        Focus();

        if (e.Button == MouseButtons.Left)
        {
            var offset = HitTest(e.Location);
            _caretOffset = offset;
            _selectionAnchor = offset;
            _draggingSelection = true;
            Invalidate();
        }
        else if (e.Button == MouseButtons.Right && SelectionLength == 0)
        {
            SetCaretOffset(HitTest(e.Location));
        }
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);
        if (!_draggingSelection) return;

        _caretOffset = HitTest(e.Location);
        Invalidate();
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        _draggingSelection = false;
    }

    protected override void OnKeyPress(KeyPressEventArgs e)
    {
        base.OnKeyPress(e);
        if (char.IsControl(e.KeyChar)) return;

        InsertTextAtCaret(e.KeyChar.ToString());
        e.Handled = true;
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
        base.OnKeyDown(e);

        if (e.Control)
        {
            if (e.KeyCode == Keys.A)
            {
                _selectionAnchor = 0;
                _caretOffset = Document.TextLength;
                Invalidate();
                e.SuppressKeyPress = true;
                return;
            }
            if (e.KeyCode == Keys.C)
            {
                CopySelection();
                e.SuppressKeyPress = true;
                return;
            }
            if (e.KeyCode == Keys.X)
            {
                CopySelection();
                DeleteSelection();
                RaiseDocumentChanged();
                e.SuppressKeyPress = true;
                return;
            }
            if (e.KeyCode == Keys.V)
            {
                if (Clipboard.ContainsText())
                    InsertTextAtCaret(Clipboard.GetText());
                e.SuppressKeyPress = true;
                return;
            }
        }

        switch (e.KeyCode)
        {
            case Keys.Enter:
                InsertTextAtCaret("\n");
                e.SuppressKeyPress = true;
                break;
            case Keys.Back:
                Backspace();
                e.SuppressKeyPress = true;
                break;
            case Keys.Delete:
                DeleteForward();
                e.SuppressKeyPress = true;
                break;
            case Keys.Left:
                MoveCaret(-1, e.Shift);
                e.SuppressKeyPress = true;
                break;
            case Keys.Right:
                MoveCaret(1, e.Shift);
                e.SuppressKeyPress = true;
                break;
            case Keys.Home:
                MoveCaretTo(0, e.Shift);
                e.SuppressKeyPress = true;
                break;
            case Keys.End:
                MoveCaretTo(Document.TextLength, e.Shift);
                e.SuppressKeyPress = true;
                break;
        }
    }

    private int SelectionStart => Math.Min(_caretOffset, _selectionAnchor);
    private int SelectionEnd => Math.Max(_caretOffset, _selectionAnchor);
    private int SelectionLength => SelectionEnd - SelectionStart;

    private void Backspace()
    {
        if (DeleteSelection())
        {
            RaiseDocumentChanged();
            return;
        }

        if (_caretOffset <= 0) return;
        Document.DeleteRange(_caretOffset - 1, 1);
        _caretOffset--;
        _selectionAnchor = _caretOffset;
        RaiseDocumentChanged();
    }

    private void DeleteForward()
    {
        if (DeleteSelection())
        {
            RaiseDocumentChanged();
            return;
        }

        if (_caretOffset >= Document.TextLength) return;
        Document.DeleteRange(_caretOffset, 1);
        RaiseDocumentChanged();
    }

    private bool DeleteSelection()
    {
        if (SelectionLength <= 0) return false;

        var start = SelectionStart;
        Document.DeleteRange(start, SelectionLength);
        _caretOffset = start;
        _selectionAnchor = start;
        return true;
    }

    private void MoveCaret(int delta, bool extendSelection)
        => MoveCaretTo(_caretOffset + delta, extendSelection);

    private void MoveCaretTo(int offset, bool extendSelection)
    {
        _caretOffset = Math.Clamp(offset, 0, Document.TextLength);
        if (!extendSelection)
            _selectionAnchor = _caretOffset;
        Invalidate();
    }

    private void CopySelection()
    {
        if (SelectionLength <= 0) return;
        Clipboard.SetText(Document.GetPlainText().Substring(SelectionStart, SelectionLength));
    }

    private void ChangeSelectedFont()
    {
        if (SelectionLength <= 0) return;

        var currentFontId = Document.GetFontAt(SelectionStart);
        using var picker = new FontSchemePickerForm(_loader, currentFontId);
        if (picker.ShowDialog(FindForm()) != DialogResult.OK) return;

        Document.ApplyFont(SelectionStart, SelectionLength, picker.SelectedFontSchemeId);
        _caretOffset = SelectionEnd;
        _selectionAnchor = _caretOffset;
        RaiseDocumentChanged();
    }

    private int HitTest(Point clientPoint)
    {
        using var graphics = CreateGraphics();
        var layout = LayoutDocument(graphics);
        if (layout.CaretPositions.Count == 0) return 0;

        var documentPoint = new PointF(
            clientPoint.X - AutoScrollPosition.X,
            clientPoint.Y - AutoScrollPosition.Y);

        var bestOffset = 0;
        var bestDistance = double.MaxValue;
        for (var i = 0; i < layout.CaretPositions.Count; i++)
        {
            var caret = layout.CaretPositions[i];
            var centerY = caret.Y + caret.Height / 2f;
            var dx = caret.X - documentPoint.X;
            var dy = centerY - documentPoint.Y;
            var distance = dx * dx + dy * dy;
            if (distance < bestDistance)
            {
                bestDistance = distance;
                bestOffset = i;
            }
        }

        return bestOffset;
    }

    private LayoutResult LayoutDocument(Graphics g)
    {
        var items = new List<CharLayoutItem>();
        var caretPositions = new List<CaretLayoutItem>();
        var maxWidth = Math.Max(1, ClientSize.Width - PaddingPx * 2);
        var x = (float)PaddingPx;
        var y = (float)PaddingPx;
        var lineHeight = 18f;
        var offset = 0;

        foreach (var segment in Document.Segments)
        {
            var spec = _loader.ResolveFont(segment.FontSchemeId);
            var font = GetFont(spec);
            lineHeight = Math.Max(lineHeight, font.Height);

            foreach (var ch in segment.Text)
            {
                caretPositions.Add(new CaretLayoutItem(x, y, Math.Max(lineHeight, font.Height)));

                if (ch == '\n')
                {
                    x = PaddingPx;
                    y += lineHeight + LineSpacing;
                    lineHeight = font.Height;
                    offset++;
                    continue;
                }

                var charText = ch.ToString();
                var width = Math.Max(4f, g.MeasureString(charText, font).Width);
                if (x + width + CharSpacing > PaddingPx + maxWidth && x > PaddingPx)
                {
                    x = PaddingPx;
                    y += lineHeight + LineSpacing;
                    lineHeight = font.Height;
                    caretPositions[^1] = new CaretLayoutItem(x, y, lineHeight);
                }

                var bounds = new RectangleF(x, y, width, font.Height);
                items.Add(new CharLayoutItem(offset, charText, bounds, font, spec));
                x += width + CharSpacing;
                lineHeight = Math.Max(lineHeight, font.Height);
                offset++;
            }
        }

        caretPositions.Add(new CaretLayoutItem(x, y, lineHeight));
        return new LayoutResult(items, caretPositions, y + lineHeight);
    }

    private Font GetFont(ResolvedFontSpec spec)
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

                font = pfc.Families.Length > 0
                    ? new Font(pfc.Families[0], spec.Size, GraphicsUnit.Pixel)
                    : new Font("Microsoft YaHei UI", spec.Size, GraphicsUnit.Pixel);
            }
            catch
            {
                font = new Font("Microsoft YaHei UI", spec.Size, GraphicsUnit.Pixel);
            }
        }
        else
        {
            font = new Font("Microsoft YaHei UI", spec.Size, GraphicsUnit.Pixel);
        }

        _fontCache[key] = font;
        return font;
    }

    private static void DrawStyledText(Graphics g, string text, Font font, ResolvedFontSpec spec, PointF location)
    {
        if (spec.ShadowSize > 0)
        {
            using var shadowBrush = new SolidBrush(Color.FromArgb(180, spec.ShadowColor));
            g.DrawString(text, font, shadowBrush, location.X + spec.ShadowSize, location.Y + spec.ShadowSize);
        }

        if (spec.BorderSize > 0)
        {
            using var borderBrush = new SolidBrush(spec.BorderColor);
            var offsets = spec.BorderSize switch
            {
                1 => new (float dx, float dy)[] { (0, -1), (0, 1), (-1, 0), (1, 0) },
                _ =>
                [
                    (0, -1), (0, 1), (-1, 0), (1, 0),
                    (-1, -1), (-1, 1), (1, -1), (1, 1),
                ],
            };
            foreach (var (dx, dy) in offsets)
                g.DrawString(text, font, borderBrush, location.X + dx, location.Y + dy);
        }

        using var fillBrush = new SolidBrush(spec.FillColor);
        g.DrawString(text, font, fillBrush, location);
    }

    private void RaiseDocumentChanged()
    {
        Invalidate();
        DocumentChanged?.Invoke(this, EventArgs.Empty);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _contextMenu.Dispose();

            foreach (var font in _fontCache.Values)
                font.Dispose();
            _fontCache.Clear();

            foreach (var pfc in _pfcCache.Values)
                pfc.Dispose();
            _pfcCache.Clear();
        }
        base.Dispose(disposing);
    }

    private sealed record CharLayoutItem(
        int Offset,
        string Text,
        RectangleF Bounds,
        Font Font,
        ResolvedFontSpec Spec);

    private sealed record CaretLayoutItem(float X, float Y, float Height);

    private sealed record LayoutResult(
        IReadOnlyList<CharLayoutItem> Items,
        IReadOnlyList<CaretLayoutItem> CaretPositions,
        float Height);
}
