# 多选单元格边框显示设计

## 背景

当前 `DetailGridCellPainting` 仅为 `CurrentCell`（当前焦点单元格）绘制蓝色边框。当用户通过 Ctrl+Click 或 Shift+Click 选中多个单元格时，其他选中的单元格只有蓝色背景高亮，没有边框，视觉上不够清晰。

## 目标

选中的单元格（包括当前单元格）都显示蓝色边框，使多选状态更加直观。

## 方案

修改 `MainForm.cs` 中的 `DetailGridCellPainting` 方法：

1. 在现有的 `isCurrentCell` 判断基础上，增加 `isSelected` 判断
2. `isSelected` 通过 `e.State.HasFlag(DataGridViewElementStates.Selected)` 检查，直接读取事件参数中的状态标志，无需遍历 `SelectedCells` 集合
3. 对所有选中单元格使用相同的 `DrawCurrentDetailCellBorder` 方法绘制 2px 蓝色边框

### 改动点

**文件**: `src/TabFileEditor.App/MainForm.cs`

**方法**: `DetailGridCellPainting`

**变更**:
- 将条件 `if (ranges.Count == 0 && !isCurrentCell)` 改为 `if (ranges.Count == 0 && !isCurrentCell && !isSelected)`
- 将条件 `if (isCurrentCell)` 改为 `if (isCurrentCell || isSelected)`
- 新增 `isSelected` 变量：`var isSelected = e.State.HasFlag(DataGridViewElementStates.Selected);`

## 不变项

- 边框样式（颜色、宽度）保持不变
- 搜索高亮逻辑保持不变
- 单元格背景色逻辑保持不变
