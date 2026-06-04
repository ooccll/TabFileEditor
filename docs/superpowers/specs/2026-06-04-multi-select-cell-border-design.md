# 多选单元格边框显示设计

## 背景

当前 `DetailGridCellPainting` 仅为 `CurrentCell`（当前焦点单元格）绘制蓝色边框。当用户通过 Ctrl+Click 或 Shift+Click 选中多个单元格时，选中的单元格只有蓝色背景高亮，没有外边框，视觉上不够清晰。

## 目标

选中多个单元格时，绘制一个统一的外边框包围整个选区，使多选状态更加直观。

## 方案

修改 `MainForm.cs`，在 `DetailGridCellPainting` 中为多选区域绘制统一外边框：

1. 移除当前仅对 `CurrentCell` 绘制边框的逻辑
2. 在每个单元格绘制完成后，检查是否有选区需要绘制统一外边框
3. 计算所有选中单元格的最小包围矩形，绘制一个 2px 蓝色边框

### 改动点

**文件**: `src/TabFileEditor.App/MainForm.cs`

**修改方法**: `DetailGridCellPainting`

- 移除 `isCurrentCell` 相关的边框绘制逻辑
- 改为在 `OnPaint` 或 `CellPainting` 末尾计算选区矩形并绘制统一外边框

**新增方法**: `DrawSelectionBorder`

- 遍历 `_detailGrid.SelectedCells` 计算最小/最大行列索引
- 通过 `GetCellDisplayRectangle` 获取各单元格位置
- 计算包围整个选区的矩形
- 使用 `CurrentCellBorderColor` 和 2px 宽度绘制边框

### 视觉效果

- 单选时：当前单元格周围显示蓝色边框（与现有一致）
- 多选时：所有选中单元格被一个统一的蓝色矩形边框包围

## 不变项

- 边框颜色（`CurrentCellBorderColor` = `AccentColor`）和宽度（2px）保持不变
- 搜索高亮逻辑保持不变
- 单元格背景色逻辑保持不变
