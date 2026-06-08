using System.Text;

namespace TabFileEditor.App;

// ── Node types ──────────────────────────────────────────────────────

public abstract record QuestTextNode
{
    public record TextRun(string Text, int FontSchemeId) : QuestTextNode;
    public record Indent() : QuestTextNode;                                       // <G>
    public record PlayerName() : QuestTextNode;                                   // <N>
    public record FactionTitle() : QuestTextNode;                                 // <C>
    public record FontBlock(string Text, int FontSchemeId) : QuestTextNode;       // <F### text>
    public record LineHeight(int Height) : QuestTextNode;                         // <H##>
    public record Icon(int IconId) : QuestTextNode;                               // <T##>
    public record Money(long Amount, bool Compare) : QuestTextNode;               // <J##>
    public record ReservedTag(string Name, string? Attribute) : QuestTextNode;    // <A>/<AT>/<SD>/<WT>
    public record Newline() : QuestTextNode;                                      // \n
}

// ── Document model ──────────────────────────────────────────────────

public sealed class QuestTextDocument
{
    public const int DefaultFontSchemeId = 160;

    public List<QuestTextNode> Nodes { get; private set; } = [];

    // ── Flat character buffer for panel layout/cursor/selection ──

    public record BufferEntry(char Ch, int FontSchemeId, int NodeIndex);

    private List<BufferEntry> _buffer = [];
    private bool _bufferDirty = true;

    public List<BufferEntry> Buffer
    {
        get
        {
            if (_bufferDirty) RebuildBuffer();
            return _buffer;
        }
    }

    public int CharCount => Buffer.Count;

    // ── Special Unicode markers ──

    public const char IndentMarker = '';
    public const char PlayerNameMarker = '';
    public const char FactionTitleMarker = '';
    public const char LineHeightMarker = '';
    public const char IconMarker = '';
    public const char MoneyMarker = '';
    public const char ReservedAMarker = '';
    public const char ReservedATMarker = '';
    public const char ReservedSDMarker = '';
    public const char ReservedWTMarker = '';

    public static readonly string PlayerNameDisplay = "玩家名";
    public static readonly string FactionTitleDisplay = "门派称谓";

    // ── Constructors ──

    public QuestTextDocument() { }

    public QuestTextDocument(List<QuestTextNode> nodes)
    {
        Nodes = Normalize(nodes);
    }

    // ── Buffer queries ──

    public char GetCharAt(int offset)
    {
        var buf = Buffer;
        return offset >= 0 && offset < buf.Count ? buf[offset].Ch : '\0';
    }

    public int GetFontAt(int offset)
    {
        var buf = Buffer;
        return offset >= 0 && offset < buf.Count ? buf[offset].FontSchemeId : DefaultFontSchemeId;
    }

    public int GetNodeIndexAt(int offset)
    {
        var buf = Buffer;
        return offset >= 0 && offset < buf.Count ? buf[offset].NodeIndex : -1;
    }

    public QuestTextNode? GetNodeAt(int offset)
    {
        var idx = GetNodeIndexAt(offset);
        return idx >= 0 && idx < Nodes.Count ? Nodes[idx] : null;
    }

    // ── Node-level selection range for non-editable nodes ──

    public (int Start, int End) GetNodeSelectionRange(int offset)
    {
        var buf = Buffer;
        if (offset < 0 || offset >= buf.Count) return (offset, offset);

        var nodeIndex = buf[offset].NodeIndex;
        var start = offset;
        while (start > 0 && buf[start - 1].NodeIndex == nodeIndex) start--;
        var end = offset + 1;
        while (end < buf.Count && buf[end].NodeIndex == nodeIndex) end++;
        return (start, end);
    }

    public bool IsNodeEditable(int offset)
    {
        var node = GetNodeAt(offset);
        return node is QuestTextNode.TextRun or QuestTextNode.FontBlock;
    }

    // ── Mutations ──

    public void InsertText(int offset, string text, int fontSchemeId)
    {
        if (string.IsNullOrEmpty(text)) return;
        var buf = Buffer;
        offset = Math.Clamp(offset, 0, buf.Count);

        // Find the node and position within it
        var (nodeIndex, charInNode) = FindNodePosition(offset);

        if (nodeIndex < 0)
        {
            // Append at end
            Nodes.Add(new QuestTextNode.TextRun(text, fontSchemeId));
        }
        else
        {
            var node = Nodes[nodeIndex];
            switch (node)
            {
                case QuestTextNode.TextRun tr:
                    SplitAndInsertText(nodeIndex, charInNode, text, fontSchemeId, tr.FontSchemeId);
                    break;
                case QuestTextNode.FontBlock fb:
                    SplitAndInsertText(nodeIndex, charInNode, text, fontSchemeId, fb.FontSchemeId);
                    break;
                default:
                    // Non-editable node — check if we're at its start (append to previous node)
                    // or in the middle/end (insert after it)
                    var nodeStart = FindNodeStart(nodeIndex);
                    if (offset == nodeStart && nodeIndex > 0)
                    {
                        // At start of non-editable node — append to previous node if it's editable
                        var prevNode = Nodes[nodeIndex - 1];
                        switch (prevNode)
                        {
                            case QuestTextNode.TextRun prevTr when prevTr.FontSchemeId == fontSchemeId:
                                Nodes[nodeIndex - 1] = prevTr with { Text = prevTr.Text + text };
                                break;
                            case QuestTextNode.FontBlock prevFb when prevFb.FontSchemeId == fontSchemeId:
                                Nodes[nodeIndex - 1] = prevFb with { Text = prevFb.Text + text };
                                break;
                            default:
                                Nodes.Insert(nodeIndex, new QuestTextNode.TextRun(text, fontSchemeId));
                                break;
                        }
                    }
                    else
                    {
                        // In middle or at end of non-editable node — insert after it
                        Nodes.Insert(nodeIndex + 1, new QuestTextNode.TextRun(text, fontSchemeId));
                    }
                    break;
            }
        }

        NormalizeInPlace();
        MarkBufferDirty();
    }

    public void InsertNode(int offset, QuestTextNode node)
    {
        var buf = Buffer;
        offset = Math.Clamp(offset, 0, buf.Count);

        var (nodeIndex, charInNode) = FindNodePosition(offset);

        if (nodeIndex < 0)
        {
            Nodes.Add(node);
        }
        else
        {
            var n = Nodes[nodeIndex];
            switch (n)
            {
                case QuestTextNode.TextRun or QuestTextNode.FontBlock:
                {
                    var originalText = n switch
                    {
                        QuestTextNode.TextRun tr => tr.Text,
                        QuestTextNode.FontBlock fb => fb.Text,
                        _ => ""
                    };
                    var fontSchemeId = n switch
                    {
                        QuestTextNode.TextRun tr => tr.FontSchemeId,
                        QuestTextNode.FontBlock fb => fb.FontSchemeId,
                        _ => 0
                    };
                    var before = originalText[..charInNode];
                    var after = originalText[charInNode..];

                    var replacement = new List<QuestTextNode>();
                    if (before.Length > 0)
                        replacement.Add(n is QuestTextNode.FontBlock
                            ? new QuestTextNode.FontBlock(before, fontSchemeId)
                            : new QuestTextNode.TextRun(before, fontSchemeId));
                    replacement.Add(node);
                    if (after.Length > 0)
                        replacement.Add(n is QuestTextNode.FontBlock
                            ? new QuestTextNode.FontBlock(after, fontSchemeId)
                            : new QuestTextNode.TextRun(after, fontSchemeId));

                    if (replacement.Count == 0)
                        replacement.Add(node);

                    Nodes.RemoveAt(nodeIndex);
                    Nodes.InsertRange(nodeIndex, replacement);
                    break;
                }
                default:
                {
                    var nodeStart = FindNodeStart(nodeIndex);
                    if (offset == nodeStart)
                        Nodes.Insert(nodeIndex, node);
                    else
                        Nodes.Insert(nodeIndex + 1, node);
                    break;
                }
            }
        }

        NormalizeInPlace();
        MarkBufferDirty();
    }

    public void DeleteRange(int start, int length)
    {
        if (length <= 0) return;
        var buf = Buffer;
        start = Math.Clamp(start, 0, buf.Count);
        var end = Math.Clamp(start + length, start, buf.Count);
        if (end <= start) return;

        // Collect affected node indices
        var affectedIndices = new HashSet<int>();
        for (var i = start; i < end; i++)
            affectedIndices.Add(buf[i].NodeIndex);

        if (affectedIndices.Count == 0) return;

        // For fully covered non-editable nodes, remove them entirely
        // For partially covered text nodes, trim them
        var updated = new List<QuestTextNode>();
        var minIdx = affectedIndices.Min();
        var maxIdx = affectedIndices.Max();

        for (var ni = 0; ni < Nodes.Count; ni++)
        {
            if (ni < minIdx || ni > maxIdx)
            {
                updated.Add(Nodes[ni]);
                continue;
            }

            if (!affectedIndices.Contains(ni))
            {
                updated.Add(Nodes[ni]);
                continue;
            }

            var node = Nodes[ni];
            var nodeStart = FindNodeStart(ni);
            var nodeEnd = FindNodeEnd(ni);

            // Fully covered → remove
            if (nodeStart >= start && nodeEnd <= end)
                continue;

            // Partially covered text nodes → trim
            switch (node)
            {
                case QuestTextNode.TextRun tr:
                    {
                        var text = tr.Text;
                        var localStart = Math.Max(0, start - nodeStart);
                        var localEnd = Math.Min(text.Length, end - nodeStart);
                        var newText = text[..localStart] + text[localEnd..];
                        if (newText.Length > 0)
                            updated.Add(new QuestTextNode.TextRun(newText, tr.FontSchemeId));
                        break;
                    }
                case QuestTextNode.FontBlock fb:
                    {
                        var text = fb.Text;
                        var localStart = Math.Max(0, start - nodeStart);
                        var localEnd = Math.Min(text.Length, end - nodeStart);
                        var newText = text[..localStart] + text[localEnd..];
                        if (newText.Length > 0)
                            updated.Add(new QuestTextNode.FontBlock(newText, fb.FontSchemeId));
                        break;
                    }
                default:
                    // Non-editable node that's partially covered shouldn't happen
                    // but keep it if it has content
                    updated.Add(node);
                    break;
            }
        }

        Nodes = Normalize(updated);
        MarkBufferDirty();
    }

    public void ApplyFont(int start, int length, int fontSchemeId)
    {
        var buf = Buffer;
        var safeStart = Math.Clamp(start, 0, buf.Count);
        var safeEnd = Math.Clamp(start + length, safeStart, buf.Count);
        if (safeEnd <= safeStart) return;

        // Check if there are any editable characters in the range
        var hasEditable = false;
        for (var i = safeStart; i < safeEnd; i++)
        {
            if (IsEditableBufferChar(buf[i].Ch))
            {
                hasEditable = true;
                break;
            }
        }
        if (!hasEditable) return;

        // Split nodes at selection boundaries so edges are clean
        SplitNodeAtBufferOffset(safeStart);
        SplitNodeAtBufferOffset(safeEnd);

        // Rebuild buffer after splits
        MarkBufferDirty();
        buf = Buffer;

        // Collect editable node indices within the selection
        var affectedNodeIndices = new HashSet<int>();
        for (var i = safeStart; i < safeEnd; i++)
        {
            if (IsEditableBufferChar(buf[i].Ch))
                affectedNodeIndices.Add(buf[i].NodeIndex);
        }

        // Change font of affected editable nodes
        for (var ni = 0; ni < Nodes.Count; ni++)
        {
            if (!affectedNodeIndices.Contains(ni)) continue;
            var node = Nodes[ni];
            switch (node)
            {
                case QuestTextNode.TextRun tr:
                    Nodes[ni] = fontSchemeId == DefaultFontSchemeId
                        ? tr with { FontSchemeId = fontSchemeId }
                        : new QuestTextNode.FontBlock(tr.Text, fontSchemeId);
                    break;
                case QuestTextNode.FontBlock fb:
                    Nodes[ni] = fontSchemeId == DefaultFontSchemeId
                        ? new QuestTextNode.TextRun(fb.Text, fontSchemeId)
                        : fb with { FontSchemeId = fontSchemeId };
                    break;
            }
        }

        NormalizeInPlace();
        MarkBufferDirty();
    }

    private static bool IsEditableBufferChar(char ch)
    {
        return ch != IndentMarker && ch != PlayerNameMarker && ch != FactionTitleMarker &&
               ch != LineHeightMarker && ch != IconMarker && ch != MoneyMarker &&
               ch != ReservedAMarker && ch != ReservedATMarker && ch != ReservedSDMarker && ch != ReservedWTMarker &&
               ch != '\n';
    }

    private void SplitNodeAtBufferOffset(int offset)
    {
        if (offset <= 0) return;
        var buf = Buffer;
        if (offset >= buf.Count) return;

        var nodeIndex = buf[offset].NodeIndex;
        var nodeStart = FindNodeStart(nodeIndex);

        // Already at a node boundary — no split needed
        if (offset == nodeStart) return;

        var node = Nodes[nodeIndex];
        switch (node)
        {
            case QuestTextNode.TextRun tr:
            {
                var charInNode = offset - nodeStart;
                var before = tr.Text[..charInNode];
                var after = tr.Text[charInNode..];
                Nodes.RemoveAt(nodeIndex);
                if (after.Length > 0)
                    Nodes.Insert(nodeIndex, new QuestTextNode.TextRun(after, tr.FontSchemeId));
                if (before.Length > 0)
                    Nodes.Insert(nodeIndex, new QuestTextNode.TextRun(before, tr.FontSchemeId));
                break;
            }
            case QuestTextNode.FontBlock fb:
            {
                var charInNode = offset - nodeStart;
                var before = fb.Text[..charInNode];
                var after = fb.Text[charInNode..];
                Nodes.RemoveAt(nodeIndex);
                if (after.Length > 0)
                    Nodes.Insert(nodeIndex, new QuestTextNode.FontBlock(after, fb.FontSchemeId));
                if (before.Length > 0)
                    Nodes.Insert(nodeIndex, new QuestTextNode.FontBlock(before, fb.FontSchemeId));
                break;
            }
            // Non-editable nodes cannot be split
        }

        MarkBufferDirty();
    }

    // ── Internal helpers ──

    private (int NodeIndex, int CharInNode) FindNodePosition(int bufferOffset)
    {
        var buf = Buffer;
        if (buf.Count == 0 || bufferOffset >= buf.Count) return (-1, 0);
        if (bufferOffset < 0) return (0, 0);

        var nodeIndex = buf[bufferOffset].NodeIndex;
        var nodeStart = FindNodeStart(nodeIndex);
        return (nodeIndex, bufferOffset - nodeStart);
    }

    private int FindNodeStart(int nodeIndex)
    {
        var buf = Buffer;
        for (var i = 0; i < buf.Count; i++)
        {
            if (buf[i].NodeIndex == nodeIndex) return i;
        }
        return buf.Count;
    }

    private int FindNodeEnd(int nodeIndex)
    {
        var buf = Buffer;
        var end = buf.Count;
        for (var i = buf.Count - 1; i >= 0; i--)
        {
            if (buf[i].NodeIndex == nodeIndex) { end = i + 1; break; }
        }
        return end;
    }

    private void SplitAndInsertText(int nodeIndex, int charInNode, string text, int insertFont, int nodeFont)
    {
        var node = Nodes[nodeIndex];
        var originalText = node switch
        {
            QuestTextNode.TextRun tr => tr.Text,
            QuestTextNode.FontBlock fb => fb.Text,
            _ => ""
        };

        var before = originalText[..charInNode];
        var after = originalText[charInNode..];

        // When inserting at the end of a node with the same font, merge into the node
        // Otherwise split into separate pieces
        var replacement = new List<QuestTextNode>();
        if (before.Length > 0)
            replacement.Add(node switch
            {
                QuestTextNode.TextRun => new QuestTextNode.TextRun(before, nodeFont),
                QuestTextNode.FontBlock => new QuestTextNode.FontBlock(before, nodeFont),
                _ => new QuestTextNode.TextRun(before, nodeFont)
            });

        // If inserting with same font as the node, merge into the node type
        if (insertFont == nodeFont && before.Length > 0 && after.Length == 0)
        {
            // Append to the existing node
            var combinedText = before + text;
            replacement.Clear();
            replacement.Add(node switch
            {
                QuestTextNode.TextRun => new QuestTextNode.TextRun(combinedText, nodeFont),
                QuestTextNode.FontBlock => new QuestTextNode.FontBlock(combinedText, nodeFont),
                _ => new QuestTextNode.TextRun(combinedText, nodeFont)
            });
            if (after.Length > 0)
                replacement.Add(node switch
                {
                    QuestTextNode.TextRun => new QuestTextNode.TextRun(after, nodeFont),
                    QuestTextNode.FontBlock => new QuestTextNode.FontBlock(after, nodeFont),
                    _ => new QuestTextNode.TextRun(after, nodeFont)
                });
        }
        else
        {
            replacement.Add(new QuestTextNode.TextRun(text, insertFont));

            if (after.Length > 0)
                replacement.Add(node switch
                {
                    QuestTextNode.TextRun => new QuestTextNode.TextRun(after, nodeFont),
                    QuestTextNode.FontBlock => new QuestTextNode.FontBlock(after, nodeFont),
                    _ => new QuestTextNode.TextRun(after, nodeFont)
                });
        }

        Nodes.RemoveAt(nodeIndex);
        Nodes.InsertRange(nodeIndex, replacement);
    }

    private void RebuildBuffer()
    {
        _buffer.Clear();
        for (var ni = 0; ni < Nodes.Count; ni++)
        {
            switch (Nodes[ni])
            {
                case QuestTextNode.TextRun tr:
                    foreach (var ch in tr.Text)
                        _buffer.Add(new BufferEntry(ch, tr.FontSchemeId, ni));
                    break;
                case QuestTextNode.FontBlock fb:
                    foreach (var ch in fb.Text)
                        _buffer.Add(new BufferEntry(ch, fb.FontSchemeId, ni));
                    break;
                case QuestTextNode.Indent:
                    _buffer.Add(new BufferEntry(IndentMarker, DefaultFontSchemeId, ni));
                    break;
                case QuestTextNode.PlayerName:
                    _buffer.Add(new BufferEntry(PlayerNameMarker, DefaultFontSchemeId, ni));
                    foreach (var ch in PlayerNameDisplay)
                        _buffer.Add(new BufferEntry(ch, DefaultFontSchemeId, ni));
                    break;
                case QuestTextNode.FactionTitle:
                    _buffer.Add(new BufferEntry(FactionTitleMarker, DefaultFontSchemeId, ni));
                    foreach (var ch in FactionTitleDisplay)
                        _buffer.Add(new BufferEntry(ch, DefaultFontSchemeId, ni));
                    break;
                case QuestTextNode.Newline:
                    _buffer.Add(new BufferEntry('\n', DefaultFontSchemeId, ni));
                    break;
                case QuestTextNode.LineHeight:
                    _buffer.Add(new BufferEntry(LineHeightMarker, DefaultFontSchemeId, ni));
                    break;
                case QuestTextNode.Icon:
                    _buffer.Add(new BufferEntry(IconMarker, DefaultFontSchemeId, ni));
                    break;
                case QuestTextNode.Money:
                    _buffer.Add(new BufferEntry(MoneyMarker, DefaultFontSchemeId, ni));
                    break;
                case QuestTextNode.ReservedTag rt:
                    var marker = rt.Name switch
                    {
                        "A" => ReservedAMarker,
                        "AT" => ReservedATMarker,
                        "SD" => ReservedSDMarker,
                        "WT" => ReservedWTMarker,
                        _ => ReservedAMarker
                    };
                    _buffer.Add(new BufferEntry(marker, DefaultFontSchemeId, ni));
                    break;
            }
        }
        _bufferDirty = false;
    }

    private void MarkBufferDirty()
    {
        _bufferDirty = true;
    }

    private void NormalizeInPlace()
    {
        Nodes = Normalize(Nodes);
    }

    private static List<QuestTextNode> Normalize(List<QuestTextNode> nodes)
    {
        var result = new List<QuestTextNode>();
        foreach (var node in nodes)
        {
            switch (node)
            {
                case QuestTextNode.TextRun tr when string.IsNullOrEmpty(tr.Text):
                    continue;
                case QuestTextNode.FontBlock fb when string.IsNullOrEmpty(fb.Text):
                    continue;
                // Merge adjacent TextRun with same font
                case QuestTextNode.TextRun tr when result.Count > 0 && result[^1] is QuestTextNode.TextRun prev && prev.FontSchemeId == tr.FontSchemeId:
                    result[^1] = prev with { Text = prev.Text + tr.Text };
                    break;
                // Merge adjacent FontBlock with same font
                case QuestTextNode.FontBlock fb when result.Count > 0 && result[^1] is QuestTextNode.FontBlock prev && prev.FontSchemeId == fb.FontSchemeId:
                    result[^1] = prev with { Text = prev.Text + fb.Text };
                    break;
                // Merge TextRun into FontBlock with same font
                case QuestTextNode.TextRun tr when result.Count > 0 && result[^1] is QuestTextNode.FontBlock prev && prev.FontSchemeId == tr.FontSchemeId:
                    result[^1] = prev with { Text = prev.Text + tr.Text };
                    break;
                // Merge FontBlock into TextRun with same font
                case QuestTextNode.FontBlock fb when result.Count > 0 && result[^1] is QuestTextNode.TextRun prev && prev.FontSchemeId == fb.FontSchemeId:
                    result[^1] = prev with { Text = prev.Text + fb.Text };
                    break;
                default:
                    result.Add(node);
                    break;
            }
        }

        if (result.Count == 0)
            result.Add(new QuestTextNode.TextRun("", DefaultFontSchemeId));

        return result;
    }
}

// ── Parser / Serializer ─────────────────────────────────────────────

public static class QuestTextParser
{
    public static QuestTextDocument Parse(string? tagText)
    {
        if (!TryParse(tagText, out var doc, out _))
        {
            return new QuestTextDocument([new QuestTextNode.TextRun(tagText ?? "", QuestTextDocument.DefaultFontSchemeId)]);
        }
        return doc;
    }

    public static bool TryParse(string? tagText, out QuestTextDocument document, out string? error)
    {
        tagText ??= "";

        var nodes = new List<QuestTextNode>();
        var pos = 0;

        while (pos < tagText.Length)
        {
            // \n literal (backslash + n)
            if (pos + 1 < tagText.Length && tagText[pos] == '\\' && tagText[pos + 1] == 'n')
            {
                nodes.Add(new QuestTextNode.Newline());
                pos += 2;
                continue;
            }

            // Tag starting with <
            if (tagText[pos] == '<')
            {
                // <G>
                if (pos + 2 < tagText.Length && tagText[pos + 1] == 'G' && tagText[pos + 2] == '>')
                {
                    nodes.Add(new QuestTextNode.Indent());
                    pos += 3;
                    continue;
                }

                // <N>
                if (pos + 2 < tagText.Length && tagText[pos + 1] == 'N' && tagText[pos + 2] == '>')
                {
                    nodes.Add(new QuestTextNode.PlayerName());
                    pos += 3;
                    continue;
                }

                // <C>
                if (pos + 2 < tagText.Length && tagText[pos + 1] == 'C' && tagText[pos + 2] == '>')
                {
                    nodes.Add(new QuestTextNode.FactionTitle());
                    pos += 3;
                    continue;
                }

                // <F### text>
                if (pos + 1 < tagText.Length && tagText[pos + 1] == 'F' && char.IsDigit(tagText[pos + 2]))
                {
                    var numStart = pos + 2;
                    var numEnd = numStart;
                    while (numEnd < tagText.Length && char.IsDigit(tagText[numEnd])) numEnd++;
                    var fontId = int.Parse(tagText[numStart..numEnd]);

                    if (numEnd < tagText.Length && tagText[numEnd] == ' ')
                    {
                        var textStart = numEnd + 1;
                        var closeIdx = tagText.IndexOf('>', textStart);
                        if (closeIdx >= 0)
                        {
                            var text = tagText[textStart..closeIdx];
                            nodes.Add(new QuestTextNode.FontBlock(text, fontId));
                            pos = closeIdx + 1;
                            continue;
                        }
                    }

                    // <F###> without text — treat as font marker with empty text (unusual but tolerant)
                    if (numEnd < tagText.Length && tagText[numEnd] == '>')
                    {
                        nodes.Add(new QuestTextNode.FontBlock("", fontId));
                        pos = numEnd + 1;
                        continue;
                    }
                }

                // <H##>
                if (pos + 1 < tagText.Length && tagText[pos + 1] == 'H' && char.IsDigit(tagText[pos + 2]))
                {
                    var numStart = pos + 2;
                    var numEnd = numStart;
                    while (numEnd < tagText.Length && char.IsDigit(tagText[numEnd])) numEnd++;
                    var height = int.Parse(tagText[numStart..numEnd]);

                    if (numEnd < tagText.Length && tagText[numEnd] == '>')
                    {
                        nodes.Add(new QuestTextNode.LineHeight(height));
                        pos = numEnd + 1;
                        continue;
                    }
                }

                // <T##>
                if (pos + 1 < tagText.Length && tagText[pos + 1] == 'T' && char.IsDigit(tagText[pos + 2]))
                {
                    var numStart = pos + 2;
                    var numEnd = numStart;
                    while (numEnd < tagText.Length && char.IsDigit(tagText[numEnd])) numEnd++;
                    var iconId = int.Parse(tagText[numStart..numEnd]);

                    if (numEnd < tagText.Length && tagText[numEnd] == '>')
                    {
                        nodes.Add(new QuestTextNode.Icon(iconId));
                        pos = numEnd + 1;
                        continue;
                    }
                }

                // <J##> or <J## compare>
                if (pos + 1 < tagText.Length && tagText[pos + 1] == 'J' && char.IsDigit(tagText[pos + 2]))
                {
                    var numStart = pos + 2;
                    var numEnd = numStart;
                    while (numEnd < tagText.Length && char.IsDigit(tagText[numEnd])) numEnd++;
                    var amount = long.Parse(tagText[numStart..numEnd]);

                    var compare = false;
                    var restStart = numEnd;
                    if (restStart < tagText.Length && tagText[restStart] == ' ')
                    {
                        // Check for compare attribute
                        var closeIdx = tagText.IndexOf('>', restStart);
                        if (closeIdx >= 0)
                        {
                            var attr = tagText[restStart..closeIdx].Trim();
                            if (attr.Equals("compare", StringComparison.OrdinalIgnoreCase))
                                compare = true;
                            nodes.Add(new QuestTextNode.Money(amount, compare));
                            pos = closeIdx + 1;
                            continue;
                        }
                    }

                    if (numEnd < tagText.Length && tagText[numEnd] == '>')
                    {
                        nodes.Add(new QuestTextNode.Money(amount, compare));
                        pos = numEnd + 1;
                        continue;
                    }
                }

                // <AT>
                if (pos + 3 < tagText.Length && tagText[(pos + 1)..(pos + 3)] == "AT" && tagText[pos + 3] == '>')
                {
                    nodes.Add(new QuestTextNode.ReservedTag("AT", null));
                    pos += 4;
                    continue;
                }

                // <SD>
                if (pos + 3 < tagText.Length && tagText[(pos + 1)..(pos + 3)] == "SD" && tagText[pos + 3] == '>')
                {
                    nodes.Add(new QuestTextNode.ReservedTag("SD", null));
                    pos += 4;
                    continue;
                }

                // <WT>
                if (pos + 3 < tagText.Length && tagText[(pos + 1)..(pos + 3)] == "WT" && tagText[pos + 3] == '>')
                {
                    nodes.Add(new QuestTextNode.ReservedTag("WT", null));
                    pos += 4;
                    continue;
                }

                // <A>
                if (pos + 2 < tagText.Length && tagText[pos + 1] == 'A' && tagText[pos + 2] == '>')
                {
                    nodes.Add(new QuestTextNode.ReservedTag("A", null));
                    pos += 3;
                    continue;
                }
            }

            // Plain text — accumulate until next tag or \n
            var textStart2 = pos;
            while (pos < tagText.Length)
            {
                if (tagText[pos] == '<') break;
                if (pos + 1 < tagText.Length && tagText[pos] == '\\' && tagText[pos + 1] == 'n') break;
                pos++;
            }

            if (pos > textStart2)
            {
                nodes.Add(new QuestTextNode.TextRun(tagText[textStart2..pos], QuestTextDocument.DefaultFontSchemeId));
            }
            else
            {
                // Unknown/unmatched < — treat as plain text
                nodes.Add(new QuestTextNode.TextRun(tagText[pos].ToString(), QuestTextDocument.DefaultFontSchemeId));
                pos++;
            }
        }

        document = new QuestTextDocument(nodes);
        error = null;
        return true;
    }

    public static string Serialize(QuestTextDocument doc)
    {
        var sb = new StringBuilder();
        foreach (var node in doc.Nodes)
        {
            switch (node)
            {
                case QuestTextNode.TextRun tr:
                    sb.Append(tr.Text);
                    break;
                case QuestTextNode.Indent:
                    sb.Append("<G>");
                    break;
                case QuestTextNode.PlayerName:
                    sb.Append("<N>");
                    break;
                case QuestTextNode.FactionTitle:
                    sb.Append("<C>");
                    break;
                case QuestTextNode.FontBlock fb:
                    sb.Append($"<F{fb.FontSchemeId} {fb.Text}>");
                    break;
                case QuestTextNode.LineHeight lh:
                    sb.Append($"<H{lh.Height}>");
                    break;
                case QuestTextNode.Icon ic:
                    sb.Append($"<T{ic.IconId}>");
                    break;
                case QuestTextNode.Money m:
                    if (m.Compare)
                        sb.Append($"<J{m.Amount} compare>");
                    else
                        sb.Append($"<J{m.Amount}>");
                    break;
                case QuestTextNode.ReservedTag rt:
                    sb.Append($"<{rt.Name}>");
                    break;
                case QuestTextNode.Newline:
                    sb.Append("\\n");
                    break;
            }
        }
        return sb.ToString();
    }

    public static bool LooksLikeQuestText(string? value)
    {
        if (string.IsNullOrEmpty(value)) return false;
        // Exclude <text> rich text format
        if (value.Contains("<text>", StringComparison.OrdinalIgnoreCase)) return false;

        // Check for quest tag patterns
        if (value.Contains("<G>", StringComparison.OrdinalIgnoreCase)) return true;
        if (value.Contains("<N>", StringComparison.OrdinalIgnoreCase)) return true;
        if (value.Contains("<C>", StringComparison.OrdinalIgnoreCase)) return true;

        // <F followed by digit
        for (var i = 0; i < value.Length - 2; i++)
        {
            if (value[i] == '<' && (value[i + 1] == 'F' || value[i + 1] == 'f') && char.IsDigit(value[i + 2]))
                return true;
            if (value[i] == '<' && (value[i + 1] == 'H' || value[i + 1] == 'h') && char.IsDigit(value[i + 2]))
                return true;
        }

        return false;
    }
}
