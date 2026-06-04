# 多选单元格边框显示设计

## 背景

当前 `DetailGridCellPainting` 仅为 `CurrentCell`（当前焦点单元格）绘制蓝色边框。当用户选中多个单元格时，视觉上不够清晰。

## 目标

区分两种多选场景，提供更清晰的视觉反馈：
- **连续选区（Shift+Click）**：绘制统一外边框包围整个矩形选区
- **不连续选区（Ctrl+Click）**：保持现有行为，仅最后选中的格子有边框

## 方案

修改 `MainForm.cs`，在 `DetailGridCellPainting` 中增加连续选区的统一外边框绘制：

### 判断连续选区

通过 `_detailGrid.SelectedCells` 计算最小/最大行列索引，判断选中单元格数量是否等于 `(maxRow - minRow + 1) * (maxCol - minCol + 1)`。如果相等，说明是连续矩形选区。

### 改动点

**文件**: `src/TabFileEditor.App/MainForm.cs`

**修改方法**: `DetailGridCellPainting`

- 保留现有的 `isCurrentCell` 边框绘制逻辑（单选和不连续多选时生效）
- 在方法末尾增加对连续选区的统一外边框绘制

**新增方法**: `DrawSelectionBorder`

- 遍历 `_detailGrid.SelectedCells` 计算最小/最大行列索引
- 判断是否为连续矩形选区
- 如果是连续选区且选中单元格 > 1，通过 `GetCellDisplayRectangle` 获取左上角和右下角单元格位置
- 计算包围整个选区的矩形，使用 `CurrentCellBorderColor` 和 2px 宽度绘制统一边框

### 视觉效果

| 场景 | 行为 |
|------|------|
| 单选 | 当前单元格显示蓝色边框（不变） |
| Shift+Click 连续多选 | 整个选区显示一个统一的蓝色矩形外边框 |
| Ctrl+Click 不连续多选 | 仅最后选中的格子有边框（不变） |

## 不变项

- 边框颜色（`CurrentCellBorderColor` = `AccentColor`）和宽度（2px）保持不变
- 搜索高亮逻辑保持不变
- 单元格背景色逻辑保持不变
