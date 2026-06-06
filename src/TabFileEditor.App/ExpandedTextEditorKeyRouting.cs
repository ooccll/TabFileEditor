using System.Runtime.InteropServices;

namespace TabFileEditor.App;

internal static class ExpandedTextEditorKeyRouting
{
    private static readonly Dictionary<TextBox, int> ShiftSelectionAnchors = new();
    private static readonly Dictionary<TextBox, VerticalNavigationState> VerticalNavigationStates = new();

    private const int EmGetLineCount = 0x00BA;
    private const int EmLineIndex = 0x00BB;
    private const int EmLineLength = 0x00C1;
    private const int EmLineFromChar = 0x00C9;

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

        if (key is not (Keys.Up or Keys.Down))
        {
            VerticalNavigationStates.Remove(editor);
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
        caret = Math.Clamp(caret, 0, editor.TextLength);
        var currentLine = (int)SendMessage(editor.Handle, EmLineFromChar, caret, 0);
        var currentLineStart = GetLineIndex(editor, currentLine);
        if (currentLine < 0 || currentLineStart < 0)
        {
            return caret;
        }

        var desiredColumn = caret - currentLineStart;
        if (VerticalNavigationStates.TryGetValue(editor, out var state) &&
            state.LastCaret == caret)
        {
            desiredColumn = state.DesiredColumn;
        }

        var lineCount = (int)SendMessage(editor.Handle, EmGetLineCount, 0, 0);
        var targetLine = Math.Clamp(currentLine + lineOffset, 0, Math.Max(0, lineCount - 1));
        if (targetLine == currentLine)
        {
            return caret;
        }

        var targetLineStart = GetLineIndex(editor, targetLine);
        if (targetLineStart < 0)
        {
            return lineOffset < 0 ? 0 : editor.TextLength;
        }

        var targetLineLength = (int)SendMessage(editor.Handle, EmLineLength, targetLineStart, 0);
        var target = targetLineStart + Math.Min(desiredColumn, Math.Max(0, targetLineLength));
        target = Math.Clamp(target, 0, editor.TextLength);
        VerticalNavigationStates[editor] = new VerticalNavigationState(desiredColumn, target);
        return target;
    }

    private static int GetLineIndex(TextBox editor, int line)
    {
        return (int)SendMessage(editor.Handle, EmLineIndex, line, 0);
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

    [DllImport("user32.dll")]
    private static extern nint SendMessage(nint hWnd, int msg, nint wParam, nint lParam);

    private sealed record VerticalNavigationState(int DesiredColumn, int LastCaret);
}
