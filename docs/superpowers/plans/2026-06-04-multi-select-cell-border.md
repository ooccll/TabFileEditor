# 多选单元格统一外边框实现计划

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** 当 Shift+Click 连续选中多个单元格时，绘制一个统一的蓝色外边框包围整个选区

**Architecture:** 在 `DetailGridCellPainting` 中增加连续选区检测逻辑，新增 `DrawSelectionBorder` 方法计算选区矩形并绘制统一边框

**Tech Stack:** .NET 10, WinForms, C#

---

## 文件结构

- Modify: `src/TabFileEditor.App/MainForm.cs:1420-1454` — 修改 `DetailGridCellPainting` 方法
- Modify: `src/TabFileEditor.App/MainForm.cs:1592-1598` — 新增 `DrawSelectionBorder` 方法（在 `DrawCurrentDetailCellBorder` 之后）

---

### Task 1: 修改 DetailGridCellPainting 增加连续选区检测

**Files:**
- Modify: `src/TabFileEditor.App/MainForm.cs:1420-1454`

- [ ] **Step 1: 修改 DetailGridCellPainting 方法**

将 `DetailGridCellPainting` 方法从：

```csharp
private void DetailGridCellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
{
    var graphics = e.Graphics;
    var cellStyle = e.CellStyle;
    if (e.RowIndex < 0 || e.ColumnIndex < 0 || graphics is null || cellStyle is null)
    {
        return;
    }

    var ranges = GetDetailSearchMatchRanges(e.RowIndex, e.ColumnIndex);
    var isCurrentCell =
        _detailGrid.CurrentCell is not null &&
        e.RowIndex == _detailGrid.CurrentCell.RowIndex &&
        e.ColumnIndex == _detailGrid.CurrentCell.ColumnIndex;
    if (ranges.Count == 0 && !isCurrentCell)
    {
        return;
    }

    if (ranges.Count > 0)
    {
        PaintDetailValueCellWithSearchHighlight(e, graphics, cellStyle, ranges);
    }
    else
    {
        e.Paint(e.ClipBounds, e.PaintParts);
    }

    if (isCurrentCell)
    {
        DrawCurrentDetailCellBorder(e);
    }

    e.Handled = true;
}
```

改为：

```csharp
private void DetailGridCellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
{
    var graphics = e.Graphics;
    var cellStyle = e.CellStyle;
    if (e.RowIndex < 0 || e.ColumnIndex < 0 || graphics is null || cellStyle is null)
    {
        return;
    }

    var ranges = GetDetailSearchMatchRanges(e.RowIndex, e.ColumnIndex);
    var isCurrentCell =
        _detailGrid.CurrentCell is not null &&
        e.RowIndex == _detailGrid.CurrentCell.RowIndex &&
        e.ColumnIndex == _detailGrid.CurrentCell.ColumnIndex;
    if (ranges.Count == 0 && !isCurrentCell)
    {
        return;
    }

    if (ranges.Count > 0)
    {
        PaintDetailValueCellWithSearchHighlight(e, graphics, cellStyle, ranges);
    }
    else
    {
        e.Paint(e.ClipBounds, e.PaintParts);
    }

    if (isCurrentCell)
    {
        DrawCurrentDetailCellBorder(e);
    }

    if (IsContiguousSelection())
    {
        DrawSelectionBorder(e);
    }

    e.Handled = true;
}
```

- [ ] **Step 2: Commit**

```bash
git add src/TabFileEditor.App/MainForm.cs
git commit -m "feat: 在 DetailGridCellPainting 中增加连续选区检测调用"
```

---

### Task 2: 新增连续选区检测和绘制方法

**Files:**
- Modify: `src/TabFileEditor.App/MainForm.cs` — 在 `DrawCurrentDetailCellBorder` 方法之后添加

- [ ] **Step 1: 新增 IsContiguousSelection 方法**

在 `DrawCurrentDetailCellBorder` 方法之后添加：

```csharp
private bool IsContiguousSelection()
{
    var selectedCells = _detailGrid.SelectedCells;
    if (selectedCells.Count <= 1)
    {
        return false;
    }

    var minRowIndex = int.MaxValue;
    var maxRowIndex = int.MinValue;
    var minColumnIndex = int.MaxValue;
    var maxColumnIndex = int.MinValue;

    foreach (DataGridViewCell cell in selectedCells)
    {
        if (cell.RowIndex < minRowIndex) minRowIndex = cell.RowIndex;
        if (cell.RowIndex > maxRowIndex) maxRowIndex = cell.RowIndex;
        if (cell.ColumnIndex < minColumnIndex) minColumnIndex = cell.ColumnIndex;
        if (cell.ColumnIndex > maxColumnIndex) maxColumnIndex = cell.ColumnIndex;
    }

    var expectedCount = (maxRowIndex - minRowIndex + 1) * (maxColumnIndex - minColumnIndex + 1);
    return selectedCells.Count == expectedCount;
}
```

- [ ] **Step 2: 新增 DrawSelectionBorder 方法**

在 `IsContiguousSelection` 方法之后添加：

```csharp
private void DrawSelectionBorder(DataGridViewCellPaintingEventArgs e)
{
    var selectedCells = _detailGrid.SelectedCells;
    if (selectedCells.Count <= 1)
    {
        return;
    }

    var minRowIndex = int.MaxValue;
    var maxRowIndex = int.MinValue;
    var minColumnIndex = int.MaxValue;
    var maxColumnIndex = int.MinValue;

    foreach (DataGridViewCell cell in selectedCells)
    {
        if (cell.RowIndex < minRowIndex) minRowIndex = cell.RowIndex;
        if (cell.RowIndex > maxRowIndex) maxRowIndex = cell.RowIndex;
        if (cell.ColumnIndex < minColumnIndex) minColumnIndex = cell.ColumnIndex;
        if (cell.ColumnIndex > maxColumnIndex) maxColumnIndex = cell.ColumnIndex;
    }

    var topLeftBounds = _detailGrid.GetCellDisplayRectangle(minColumnIndex, minRowIndex, false);
    var bottomRightBounds = _detailGrid.GetCellDisplayRectangle(maxColumnIndex, maxRowIndex, false);

    if (topLeftBounds.Width <= 0 || topLeftBounds.Height <= 0 ||
        bottomRightBounds.Width <= 0 || bottomRightBounds.Height <= 0)
    {
        return;
    }

    var selectionRect = new Rectangle(
        topLeftBounds.Left,
        topLeftBounds.Top,
        bottomRightBounds.Right - topLeftBounds.Left,
        bottomRightBounds.Bottom - topLeftBounds.Top);

    selectionRect.Inflate(-1, -1);
    using var pen = new Pen(CurrentCellBorderColor, 2);
    e.Graphics!.DrawRectangle(pen, selectionRect);
}
```

- [ ] **Step 3: Commit**

```bash
git add src/TabFileEditor.App/MainForm.cs
git commit -m "feat: 新增连续选区检测和统一外边框绘制方法"
```

---

### Task 3: 构建并手动验证

- [ ] **Step 1: 构建项目**

```bash
cd src/TabFileEditor.App && dotnet build
```

Expected: Build succeeded

- [ ] **Step 2: 运行工具手动验证**

启动工具，打开一个 tab 文件，测试以下场景：
1. 单击单个单元格 → 蓝色边框正常显示
2. Shift+Click 选中连续区域 → 统一蓝色外边框包围整个选区
3. Ctrl+Click 选中不连续单元格 → 仅最后选中的格子有边框
4. 搜索高亮功能不受影响

- [ ] **Step 3: Commit 最终版本**

```bash
git add -A
git commit -m "feat: 多选单元格统一外边框功能完成"
git push
```
