namespace TabFileEditor.App;

internal static class ExpandedTextEditorKeyRouting
{
    private static readonly Dictionary<TextBox, int> ShiftSelectionAnchors = new();

    public static bool IsNavigationKey(Keys keyData)
    {
        var key = keyData & Keys.KeyCode;
        return key is Keys.Left or Keys.Right or Keys.Up or Keys.Down
            or Keys.Home or Keys.End or Keys.PageUp or Keys.PageDown;
    }

    public static bool RouteNavigationKeyToEditor(TextBox editor, Keys keyData)
    {
        if (!editor.Visible || !IsNavigationKey(keyData))
        {
            return false;
        }

        if (!editor.IsHandleCreated)
        {
            editor.CreateControl();
        }

        var key = keyData & Keys.KeyCode;
        var shift = (keyData & Keys.Shift) == Keys.Shift;
        editor.Focus();

        var anchor = GetSelectionAnchor(editor, shift);
        var target = GetNavigationTarget(editor, keyData, shift);
        if (shift)
        {
            ShiftSelectionAnchors[editor] = anchor;
            SelectBetween(editor, anchor, target);
        }
        else
        {
            ShiftSelectionAnchors.Remove(editor);
            editor.SelectionStart = target;
            editor.SelectionLength = 0;
        }

        return true;
    }

    private static int GetSelectionAnchor(TextBox editor, bool shift)
    {
        if (!shift)
        {
            return editor.SelectionStart;
        }

        if (ShiftSelectionAnchors.TryGetValue(editor, out var anchor))
        {
            return Math.Clamp(anchor, 0, editor.TextLength);
        }

        return editor.SelectionStart;
    }

    private static int GetNavigationTarget(TextBox editor, Keys keyData, bool shift)
    {
        var key = keyData & Keys.KeyCode;
        var control = (keyData & Keys.Control) == Keys.Control;
        if (!shift && !control && editor.SelectionLength > 0)
        {
            if (key is Keys.Left or Keys.Up or Keys.Home or Keys.PageUp)
            {
                return editor.SelectionStart;
            }

            if (key is Keys.Right or Keys.Down or Keys.End or Keys.PageDown)
            {
                return editor.SelectionStart + editor.SelectionLength;
            }
        }

        var caret = GetActiveCaret(editor);

        return key switch
        {
            Keys.Left => control ? FindPreviousWordStart(editor.Text, caret) : Math.Max(0, caret - 1),
            Keys.Right => control ? FindNextWordStart(editor.Text, caret) : Math.Min(editor.TextLength, caret + 1),
            Keys.Up => FindVerticalTarget(editor, caret, -1),
            Keys.Down => FindVerticalTarget(editor, caret, 1),
            Keys.Home => GetCurrentLineStart(editor, caret),
            Keys.End => GetCurrentLineEnd(editor, caret),
            Keys.PageUp => 0,
            Keys.PageDown => editor.TextLength,
            _ => caret,
        };
    }

    private static int GetActiveCaret(TextBox editor)
    {
        if (editor.SelectionLength == 0)
        {
            return editor.SelectionStart;
        }

        if (ShiftSelectionAnchors.TryGetValue(editor, out var anchor))
        {
            return anchor <= editor.SelectionStart
                ? editor.SelectionStart + editor.SelectionLength
                : editor.SelectionStart;
        }

        return editor.SelectionStart + editor.SelectionLength;
    }

    private static int FindPreviousWordStart(string text, int caret)
    {
        var index = Math.Clamp(caret, 0, text.Length);
        if (index == 0)
        {
            return 0;
        }

        index--;
        while (index > 0 && !IsWordChar(text[index]))
        {
            index--;
        }

        while (index > 0 && IsWordChar(text[index - 1]))
        {
            index--;
        }

        return index;
    }

    private static int FindNextWordStart(string text, int caret)
    {
        var index = Math.Clamp(caret, 0, text.Length);
        while (index < text.Length && IsWordChar(text[index]))
        {
            index++;
        }

        while (index < text.Length && !IsWordChar(text[index]))
        {
            index++;
        }

        return index;
    }

    private static bool IsWordChar(char value)
        => char.IsLetterOrDigit(value) || value == '_';

    private static int FindVerticalTarget(TextBox editor, int caret, int lineOffset)
    {
        var line = editor.GetLineFromCharIndex(Math.Clamp(caret, 0, editor.TextLength));
        var currentLineStart = editor.GetFirstCharIndexFromLine(line);
        if (currentLineStart < 0)
        {
            return Math.Clamp(caret, 0, editor.TextLength);
        }

        var targetLine = Math.Clamp(line + lineOffset, 0, Math.Max(0, editor.Lines.Length - 1));
        if (targetLine == line)
        {
            return Math.Clamp(caret, 0, editor.TextLength);
        }

        var column = caret - currentLineStart;
        var targetLineStart = editor.GetFirstCharIndexFromLine(targetLine);
        if (targetLineStart < 0)
        {
            return Math.Clamp(caret, 0, editor.TextLength);
        }

        return Math.Min(targetLineStart + column, GetLineEnd(editor, targetLine, targetLineStart));
    }

    private static int GetCurrentLineStart(TextBox editor, int caret)
    {
        var line = editor.GetLineFromCharIndex(Math.Clamp(caret, 0, editor.TextLength));
        var lineStart = editor.GetFirstCharIndexFromLine(line);
        return lineStart < 0 ? 0 : lineStart;
    }

    private static int GetCurrentLineEnd(TextBox editor, int caret)
    {
        var line = editor.GetLineFromCharIndex(Math.Clamp(caret, 0, editor.TextLength));
        var lineStart = editor.GetFirstCharIndexFromLine(line);
        return lineStart < 0 ? editor.TextLength : GetLineEnd(editor, line, lineStart);
    }

    private static int GetLineEnd(TextBox editor, int line, int lineStart)
    {
        var nextLineStart = editor.GetFirstCharIndexFromLine(line + 1);
        var lineEnd = nextLineStart < 0 ? editor.TextLength : nextLineStart;
        while (lineEnd > lineStart && editor.Text[lineEnd - 1] is '\r' or '\n')
        {
            lineEnd--;
        }

        return lineEnd;
    }

    private static void SelectBetween(TextBox editor, int anchor, int target)
    {
        anchor = Math.Clamp(anchor, 0, editor.TextLength);
        target = Math.Clamp(target, 0, editor.TextLength);
        editor.SelectionStart = Math.Min(anchor, target);
        editor.SelectionLength = Math.Abs(anchor - target);
    }
}
