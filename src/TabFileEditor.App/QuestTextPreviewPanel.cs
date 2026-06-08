using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Text;

namespace TabFileEditor.App;

public sealed class QuestTextPreviewPanel : Panel
{
    private readonly ElemSchemeLoader _loader;
    private readonly Dictionary<(string file, int size, int dpi), Font> _fontCache = [];
    private readonly Dictionary<string, PrivateFontCollection> _pfcCache = [];
    private readonly ContextMenuStrip _contextMenu = new();
    private int _caretOffset;
    private int _selectionAnchor;
    private bool _draggingSelection;
    private float? _verticalCaretTargetX;
    private int _lastDeviceDpi;

    private const int PaddingPxBase = 12;
    private const int LineSpacingBase = 4;
    private const float IndentWidthBase = 32f;

    private float DpiScale => DeviceDpi / 96f;
    private int Scaled(int px) => (int)Math.Round(px * DpiScale);
    private float ScaledF(float px) => px * DpiScale;
    private int PaddingPx => Scaled(PaddingPxBase);
    private int LineSpacing => Scaled(LineSpacingBase);
    private float IndentWidth => ScaledF(IndentWidthBase);

    public event EventHandler? DocumentChanged;

    public QuestTextDocument Document { get; private set; } = new();

    public QuestTextPreviewPanel(ElemSchemeLoader loader)
    {
        _loader = loader;
        DoubleBuffered = true;
        BackColor = Color.FromArgb(0x25, 0x3C, 0x3F);
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

    public void SetDocument(QuestTextDocument document)
    {
        Document = document;
        SetCaretOffset(Math.Min(_caretOffset, Document.CharCount));
        Invalidate();
    }

    public void SetCaretOffset(int offset)
    {
        _caretOffset = Math.Clamp(offset, 0, Document.CharCount);
        _selectionAnchor = _caretOffset;
        _verticalCaretTargetX = null;
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
        _verticalCaretTargetX = null;
        RaiseDocumentChanged();
    }

    public void InsertNodeAtCaret(QuestTextNode node)
    {
        DeleteSelection();
        Document.InsertNode(_caretOffset, node);
        // Move caret past the inserted node in the buffer
        var newCharCount = Document.CharCount;
        var nodeRange = Document.GetNodeSelectionRange(_caretOffset);
        _caretOffset = Math.Min(nodeRange.End, newCharCount);
        _selectionAnchor = _caretOffset;
        _verticalCaretTargetX = null;
        RaiseDocumentChanged();
    }

    public void ApplyFontAtSelection(int fontSchemeId)
    {
        if (SelectionLength <= 0) return;
        Document.ApplyFont(SelectionStart, SelectionLength, fontSchemeId);
        _caretOffset = SelectionEnd;
        _selectionAnchor = _caretOffset;
        _verticalCaretTargetX = null;
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
        g.Clear(BackColor);
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.TextRenderingHint = TextRenderingHint.AntiAlias;
        g.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y);

        var layout = LayoutDocument(g);

        // Draw selection
        foreach (var item in layout.Items)
        {
            if (item.Offset >= SelectionStart && item.Offset < SelectionEnd)
            {
                using var selectionBrush = new SolidBrush(Color.FromArgb(120, 0x33, 0x99, 0xFF));
                g.FillRectangle(selectionBrush, item.Bounds);
            }
        }

        // Draw content
        foreach (var item in layout.Items)
        {
            switch (item.RenderKind)
            {
                case RenderKind.Normal:
                    DrawStyledText(g, item.Text, item.Font, item.Spec, item.Bounds.Location);
                    break;
                case RenderKind.Indent:
                    // Indent is invisible — already handled by X offset
                    break;
                case RenderKind.PlayerNamePlaceholder:
                case RenderKind.FactionTitlePlaceholder:
                    DrawPlaceholder(g, item);
                    break;
                case RenderKind.LineHeightBar:
                    DrawLineHeightBar(g, item);
                    break;
                case RenderKind.IconPlaceholder:
                    DrawIconPlaceholder(g, item);
                    break;
                case RenderKind.MoneyPlaceholder:
                    DrawMoneyPlaceholder(g, item);
                    break;
                case RenderKind.ReservedTagPlaceholder:
                    DrawReservedTagPlaceholder(g, item);
                    break;
            }
        }

        // Draw caret
        if (Focused && _caretOffset >= 0 && _caretOffset < layout.CaretPositions.Count)
        {
            var caret = layout.CaretPositions[_caretOffset];
            using var caretPen = new Pen(Color.White, ScaledF(1.5f));
            g.DrawLine(caretPen, caret.X, caret.Y, caret.X, caret.Y + caret.Height);
        }

        AutoScrollMinSize = new Size(0, Math.Max(0, (int)Math.Ceiling(layout.Height + PaddingPx)));
    }

    // ── Mouse ──

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        Focus();

        if (e.Button == MouseButtons.Left)
        {
            var offset = HitTest(e.Location);
            // If clicking on a non-editable node, select the entire node
            if (!Document.IsNodeEditable(offset))
            {
                var (nodeStart, nodeEnd) = Document.GetNodeSelectionRange(offset);
                _selectionAnchor = nodeStart;
                _caretOffset = nodeEnd;
            }
            else
            {
                _caretOffset = offset;
                _selectionAnchor = offset;
            }
            _verticalCaretTargetX = null;
            _draggingSelection = true;
            Invalidate();
        }
        else if (e.Button == MouseButtons.Right && SelectionLength == 0)
        {
            var offset = HitTest(e.Location);
            if (!Document.IsNodeEditable(offset))
            {
                var (nodeStart, nodeEnd) = Document.GetNodeSelectionRange(offset);
                _selectionAnchor = nodeStart;
                _caretOffset = nodeEnd;
            }
            else
            {
                SetCaretOffset(offset);
            }
            Invalidate();
        }
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);
        if (!_draggingSelection) return;

        _caretOffset = HitTest(e.Location);
        _verticalCaretTargetX = null;
        Invalidate();
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        _draggingSelection = false;
    }

    // ── Keyboard ──

    protected override void OnKeyPress(KeyPressEventArgs e)
    {
        base.OnKeyPress(e);
        if (char.IsControl(e.KeyChar)) return;

        InsertTextAtCaret(e.KeyChar.ToString());
        e.Handled = true;
    }

    protected override bool IsInputKey(Keys keyData)
    {
        var keyCode = keyData & Keys.KeyCode;
        return keyCode is Keys.Left or Keys.Right or Keys.Up or Keys.Down or Keys.Home or Keys.End
            || base.IsInputKey(keyData);
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
        base.OnKeyDown(e);

        if (e.Control)
        {
            if (e.KeyCode == Keys.A)
            {
                _selectionAnchor = 0;
                _caretOffset = Document.CharCount;
                _verticalCaretTargetX = null;
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
                _verticalCaretTargetX = null;
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
            if (e.KeyCode == Keys.Enter)
            {
                if (FindForm() is QuestTextEditorForm editorForm)
                    editorForm.AcceptDialog();
                e.SuppressKeyPress = true;
                return;
            }
        }

        if (e.KeyCode == Keys.Enter)
        {
            InsertNodeAtCaret(new QuestTextNode.Newline());
            e.SuppressKeyPress = true;
            return;
        }

        switch (e.KeyCode)
        {
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
                _verticalCaretTargetX = null;
                e.SuppressKeyPress = true;
                break;
            case Keys.Right:
                MoveCaret(1, e.Shift);
                _verticalCaretTargetX = null;
                e.SuppressKeyPress = true;
                break;
            case Keys.Up:
                MoveCaretVertically(-1, e.Shift);
                e.SuppressKeyPress = true;
                break;
            case Keys.Down:
                MoveCaretVertically(1, e.Shift);
                e.SuppressKeyPress = true;
                break;
            case Keys.Home:
                MoveCaretTo(0, e.Shift);
                _verticalCaretTargetX = null;
                e.SuppressKeyPress = true;
                break;
            case Keys.End:
                MoveCaretTo(Document.CharCount, e.Shift);
                _verticalCaretTargetX = null;
                e.SuppressKeyPress = true;
                break;
        }
    }

    // ── Selection ──

    private int SelectionStart => Math.Min(_caretOffset, _selectionAnchor);
    private int SelectionEnd => Math.Max(_caretOffset, _selectionAnchor);
    private int SelectionLength => SelectionEnd - SelectionStart;

    // ── Editing ──

    private void Backspace()
    {
        if (DeleteSelection())
        {
            _verticalCaretTargetX = null;
            RaiseDocumentChanged();
            return;
        }

        if (_caretOffset <= 0) return;

        // Check if the character before caret is a non-editable node marker
        if (!Document.IsNodeEditable(_caretOffset - 1))
        {
            var (nodeStart, nodeEnd) = Document.GetNodeSelectionRange(_caretOffset - 1);
            Document.DeleteRange(nodeStart, nodeEnd - nodeStart);
            _caretOffset = nodeStart;
        }
        else
        {
            Document.DeleteRange(_caretOffset - 1, 1);
            _caretOffset--;
        }

        _selectionAnchor = _caretOffset;
        _verticalCaretTargetX = null;
        RaiseDocumentChanged();
    }

    private void DeleteForward()
    {
        if (DeleteSelection())
        {
            _verticalCaretTargetX = null;
            RaiseDocumentChanged();
            return;
        }

        if (_caretOffset >= Document.CharCount) return;

        // Check if the character at caret is a non-editable node marker
        if (!Document.IsNodeEditable(_caretOffset))
        {
            var (nodeStart, nodeEnd) = Document.GetNodeSelectionRange(_caretOffset);
            Document.DeleteRange(nodeStart, nodeEnd - nodeStart);
        }
        else
        {
            Document.DeleteRange(_caretOffset, 1);
        }

        _verticalCaretTargetX = null;
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
        _caretOffset = Math.Clamp(offset, 0, Document.CharCount);
        if (!extendSelection)
            _selectionAnchor = _caretOffset;
        Invalidate();
    }

    private void MoveCaretVertically(int lineDelta, bool extendSelection)
    {
        using var g = CreateGraphics();
        var layout = LayoutDocument(g);
        if (layout.CaretPositions.Count == 0) return;

        var targetX = _verticalCaretTargetX ?? layout.CaretPositions[_caretOffset].X;
        var newOffset = FindVerticalCaretOffset(layout, _caretOffset, lineDelta, targetX);
        _verticalCaretTargetX = targetX;

        _caretOffset = newOffset;
        if (!extendSelection)
            _selectionAnchor = _caretOffset;
        Invalidate();
    }

    private static int FindVerticalCaretOffset(LayoutResult layout, int currentOffset, int lineDelta, float targetX)
    {
        var positions = layout.CaretPositions;
        if (positions.Count == 0) return currentOffset;

        var currentY = positions[currentOffset].Y;

        var lineYs = positions.Select(p => p.Y).Distinct().OrderBy(y => y).ToList();
        var currentLineIndex = lineYs.BinarySearch(currentY);
        if (currentLineIndex < 0) currentLineIndex = ~currentLineIndex;

        var targetLineIndex = Math.Clamp(currentLineIndex + lineDelta, 0, lineYs.Count - 1);
        if (targetLineIndex == currentLineIndex && ((lineDelta < 0 && currentLineIndex == 0) || (lineDelta > 0 && currentLineIndex == lineYs.Count - 1)))
            return currentOffset;

        var targetY = lineYs[targetLineIndex];

        var bestOffset = currentOffset;
        var bestDistance = double.MaxValue;
        for (var i = 0; i < positions.Count; i++)
        {
            if (Math.Abs(positions[i].Y - targetY) > 0.5f) continue;
            var dx = positions[i].X - targetX;
            var distance = dx * dx;
            if (distance < bestDistance)
            {
                bestDistance = distance;
                bestOffset = i;
            }
        }

        return bestOffset;
    }

    private void CopySelection()
    {
        if (SelectionLength <= 0) return;
        // Build plain text from buffer range
        var sb = new StringBuilder();
        var buf = Document.Buffer;
        for (var i = SelectionStart; i < SelectionEnd && i < buf.Count; i++)
        {
            var ch = buf[i].Ch;
            if (ch is not (QuestTextDocument.IndentMarker or QuestTextDocument.LineHeightMarker
                or QuestTextDocument.IconMarker or QuestTextDocument.MoneyMarker
                or QuestTextDocument.ReservedAMarker or QuestTextDocument.ReservedATMarker
                or QuestTextDocument.ReservedSDMarker or QuestTextDocument.ReservedWTMarker))
            {
                sb.Append(ch);
            }
        }
        if (sb.Length > 0)
            Clipboard.SetText(sb.ToString());
    }

    private void ChangeSelectedFont()
    {
        if (SelectionLength <= 0) return;

        var currentFontId = Document.GetFontAt(SelectionStart);
        using var picker = new FontSchemePickerForm(_loader, currentFontId);
        if (picker.ShowDialog(FindForm()) != DialogResult.OK) return;

        ApplyFontAtSelection(picker.SelectedFontSchemeId);
    }

    // ── Hit test ──

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

    // ── Layout engine ──

    private LayoutResult LayoutDocument(Graphics g)
    {
        var items = new List<CharLayoutItem>();
        var caretPositions = new List<CaretLayoutItem>();
        var maxWidth = Math.Max(1, ClientSize.Width - PaddingPx * 2);
        var x = (float)PaddingPx;
        var y = (float)PaddingPx;
        var lineHeight = ScaledF(18f);
        var buf = Document.Buffer;

        for (var offset = 0; offset < buf.Count; offset++)
        {
            var entry = buf[offset];
            var ch = entry.Ch;
            var fontSchemeId = entry.FontSchemeId;
            var spec = _loader.ResolveFont(fontSchemeId);
            var font = GetFont(spec);

            // Handle special markers
            if (ch == QuestTextDocument.IndentMarker)
            {
                caretPositions.Add(new CaretLayoutItem(x, y, Math.Max(lineHeight, font.Height)));
                // Advance X by indent width, no visible character
                x += IndentWidth;
                items.Add(new CharLayoutItem(offset, "", new RectangleF(x - IndentWidth, y, IndentWidth, font.Height), font, spec, RenderKind.Indent));
                continue;
            }

            if (ch == QuestTextDocument.LineHeightMarker)
            {
                var barHeight = ScaledF(16f);
                caretPositions.Add(new CaretLayoutItem(x, y, Math.Max(lineHeight, font.Height)));
                y += barHeight;
                var bounds = new RectangleF(PaddingPx, y - barHeight / 2, maxWidth, barHeight);
                items.Add(new CharLayoutItem(offset, "", bounds, font, spec, RenderKind.LineHeightBar));
                continue;
            }

            if (ch == QuestTextDocument.IconMarker)
            {
                var node = Document.GetNodeAt(offset);
                var iconId = node is QuestTextNode.Icon ic ? ic.IconId : 0;
                var displayText = $"[图标{iconId}]";
                caretPositions.Add(new CaretLayoutItem(x, y, Math.Max(lineHeight, font.Height)));
                var width = g.MeasureString(displayText, font, PointF.Empty, StringFormat.GenericTypographic).Width;
                var bounds = new RectangleF(x, y, width, font.Height);
                items.Add(new CharLayoutItem(offset, displayText, bounds, font, spec, RenderKind.IconPlaceholder));
                x += width;
                lineHeight = Math.Max(lineHeight, font.Height);
                continue;
            }

            if (ch == QuestTextDocument.MoneyMarker)
            {
                var node = Document.GetNodeAt(offset);
                var amount = node is QuestTextNode.Money m ? m.Amount : 0;
                var displayText = $"💰{amount}金";
                caretPositions.Add(new CaretLayoutItem(x, y, Math.Max(lineHeight, font.Height)));
                var width = g.MeasureString(displayText, font, PointF.Empty, StringFormat.GenericTypographic).Width;
                var bounds = new RectangleF(x, y, width, font.Height);
                items.Add(new CharLayoutItem(offset, displayText, bounds, font, spec, RenderKind.MoneyPlaceholder));
                x += width;
                lineHeight = Math.Max(lineHeight, font.Height);
                continue;
            }

            if (ch is QuestTextDocument.ReservedAMarker or QuestTextDocument.ReservedATMarker
                or QuestTextDocument.ReservedSDMarker or QuestTextDocument.ReservedWTMarker)
            {
                var node = Document.GetNodeAt(offset);
                var tagName = node is QuestTextNode.ReservedTag rt ? rt.Name : "?";
                var displayText = $"[{tagName}]";
                caretPositions.Add(new CaretLayoutItem(x, y, Math.Max(lineHeight, font.Height)));
                var width = g.MeasureString(displayText, font, PointF.Empty, StringFormat.GenericTypographic).Width;
                var bounds = new RectangleF(x, y, width, font.Height);
                items.Add(new CharLayoutItem(offset, displayText, bounds, font, spec, RenderKind.ReservedTagPlaceholder));
                x += width;
                lineHeight = Math.Max(lineHeight, font.Height);
                continue;
            }

            if (ch == QuestTextDocument.PlayerNameMarker || ch == QuestTextDocument.FactionTitleMarker)
            {
                var isPlayerName = ch == QuestTextDocument.PlayerNameMarker;
                var displayText = isPlayerName ? QuestTextDocument.PlayerNameDisplay : QuestTextDocument.FactionTitleDisplay;
                var placeholderFont = GetFont(_loader.ResolveFont(QuestTextDocument.DefaultFontSchemeId));
                var placeholderRenderKind = isPlayerName ? RenderKind.PlayerNamePlaceholder : RenderKind.FactionTitlePlaceholder;
                caretPositions.Add(new CaretLayoutItem(x, y, Math.Max(lineHeight, placeholderFont.Height)));

                var totalWidth = 0f;
                var charIdx = offset + 1; // display chars start after the marker in buffer
                foreach (var dc in displayText)
                {
                    var charText = dc.ToString();
                    var charWidth = MeasureCharacterWidth(g, charText, placeholderFont);
                    var bounds = new RectangleF(x + totalWidth, y, charWidth, placeholderFont.Height);
                    items.Add(new CharLayoutItem(charIdx, charText, bounds, placeholderFont,
                        _loader.ResolveFont(QuestTextDocument.DefaultFontSchemeId), placeholderRenderKind));
                    totalWidth += charWidth;
                    charIdx++;
                }

                x += totalWidth;
                lineHeight = Math.Max(lineHeight, placeholderFont.Height);
                // Skip the display text chars in the buffer (they follow the marker)
                offset += displayText.Length; // the for loop will also increment, so we skip displayText.Length
                continue;
            }

            // Normal character (including \n)
            caretPositions.Add(new CaretLayoutItem(x, y, Math.Max(lineHeight, font.Height)));

            if (ch == '\n')
            {
                x = PaddingPx;
                y += lineHeight + LineSpacing;
                lineHeight = font.Height;
                continue;
            }

            var normalText = ch.ToString();
            var width2 = MeasureCharacterWidth(g, normalText, font);
            if (x + width2 > PaddingPx + maxWidth
                && x > PaddingPx
                && !IsForbiddenLineStartSymbol(ch))
            {
                x = PaddingPx;
                y += lineHeight + LineSpacing;
                lineHeight = font.Height;
                caretPositions[^1] = new CaretLayoutItem(x, y, lineHeight);
            }

            var charBounds = new RectangleF(x, y, width2, font.Height);
            items.Add(new CharLayoutItem(offset, normalText, charBounds, font, spec, RenderKind.Normal));
            x += width2;
            lineHeight = Math.Max(lineHeight, font.Height);
        }

        caretPositions.Add(new CaretLayoutItem(x, y, lineHeight));
        return new LayoutResult(items, caretPositions, y + lineHeight);
    }

    // ── Rendering helpers ──

    private void DrawPlaceholder(Graphics g, CharLayoutItem item)
    {
        var underlineColor = item.RenderKind == RenderKind.PlayerNamePlaceholder
            ? Color.FromArgb(0x88, 0xCC, 0xFF)   // blue for <N> 玩家名
            : Color.FromArgb(0xBB, 0x88, 0xFF);   // purple for <C> 门派称谓

        DrawStyledText(g, item.Text, item.Font, item.Spec, item.Bounds.Location);

        using var pen = new Pen(underlineColor, ScaledF(1f)) { DashStyle = DashStyle.Dash };
        g.DrawLine(pen, item.Bounds.Left, item.Bounds.Bottom - 1, item.Bounds.Right, item.Bounds.Bottom - 1);
    }

    private void DrawLineHeightBar(Graphics g, CharLayoutItem item)
    {
        using var pen = new Pen(Color.FromArgb(0x44, 0x44, 0x44), ScaledF(1f)) { DashStyle = DashStyle.Dot };
        var centerY = item.Bounds.Y + item.Bounds.Height / 2;
        g.DrawLine(pen, item.Bounds.Left + Scaled(4), centerY, item.Bounds.Right - Scaled(4), centerY);
    }

    private void DrawIconPlaceholder(Graphics g, CharLayoutItem item)
    {
        using var backBrush = new SolidBrush(Color.FromArgb(0x33, 0x33, 0x44));
        g.FillRectangle(backBrush, item.Bounds);
        using var borderPen = new Pen(Color.FromArgb(0x66, 0x66, 0x88), ScaledF(1f));
        g.DrawRectangle(borderPen, item.Bounds.X, item.Bounds.Y, item.Bounds.Width, item.Bounds.Height);
        using var textBrush = new SolidBrush(Color.FromArgb(0xAA, 0xAA, 0xCC));
        g.DrawString(item.Text, item.Font, textBrush, item.Bounds.Location);
    }

    private void DrawMoneyPlaceholder(Graphics g, CharLayoutItem item)
    {
        using var backBrush = new SolidBrush(Color.FromArgb(0x33, 0x2B, 0x00));
        g.FillRectangle(backBrush, item.Bounds);
        using var borderPen = new Pen(Color.FromArgb(0x88, 0x77, 0x00), ScaledF(1f));
        g.DrawRectangle(borderPen, item.Bounds.X, item.Bounds.Y, item.Bounds.Width, item.Bounds.Height);
        using var textBrush = new SolidBrush(Color.FromArgb(0xFF, 0xDD, 0x00));
        g.DrawString(item.Text, item.Font, textBrush, item.Bounds.Location);
    }

    private void DrawReservedTagPlaceholder(Graphics g, CharLayoutItem item)
    {
        using var textBrush = new SolidBrush(Color.FromArgb(0x88, 0x88, 0x88));
        g.DrawString(item.Text, item.Font, textBrush, item.Bounds.Location);
    }

    // ── Font and measurement ──

    private static float MeasureCharacterWidth(Graphics g, string text, Font font)
    {
        if (text == " ")
            return GetHalfWidthSpaceWidth(font);

        if (text == "　")
            return GetHalfWidthSpaceWidth(font) * 3.5f;

        var measured = g.MeasureString(text, font, PointF.Empty, StringFormat.GenericTypographic);
        return Math.Max(4f, measured.Width);
    }

    private static float GetHalfWidthSpaceWidth(Font font)
        => Math.Max(4f, font.Size * 0.25f);

    private static bool IsForbiddenLineStartSymbol(char ch)
        => "，。；：！？、）】》」』〕〉…,.;:!?)]}>·-~/%".Contains(ch);

    private Font GetFont(ResolvedFontSpec spec)
    {
        if (_lastDeviceDpi != 0 && _lastDeviceDpi != DeviceDpi)
        {
            foreach (var f in _fontCache.Values) f.Dispose();
            _fontCache.Clear();
        }
        _lastDeviceDpi = DeviceDpi;

        var scaledSize = (int)Math.Round(spec.Size * DpiScale);
        var key = (spec.FontFile, scaledSize, DeviceDpi);
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
                    ? new Font(pfc.Families[0], scaledSize, GraphicsUnit.Pixel)
                    : new Font("Microsoft YaHei UI", scaledSize, GraphicsUnit.Pixel);
            }
            catch
            {
                font = new Font("Microsoft YaHei UI", scaledSize, GraphicsUnit.Pixel);
            }
        }
        else
        {
            font = new Font("Microsoft YaHei UI", scaledSize, GraphicsUnit.Pixel);
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

    // ── Internal types ──

    private enum RenderKind
    {
        Normal,
        Indent,
        PlayerNamePlaceholder,
        FactionTitlePlaceholder,
        LineHeightBar,
        IconPlaceholder,
        MoneyPlaceholder,
        ReservedTagPlaceholder,
    }

    private sealed record CharLayoutItem(
        int Offset,
        string Text,
        RectangleF Bounds,
        Font Font,
        ResolvedFontSpec Spec,
        RenderKind RenderKind = RenderKind.Normal);

    private sealed record CaretLayoutItem(float X, float Y, float Height);

    private sealed record LayoutResult(
        IReadOnlyList<CharLayoutItem> Items,
        IReadOnlyList<CaretLayoutItem> CaretPositions,
        float Height);
}
