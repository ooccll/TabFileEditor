# 最近打开文件功能设计

## 概述

在"文件"菜单中新增最近打开文件列表，最多保留10条记录，点击可快速重新打开文件。

## 数据模型与存储

### AppSettings 扩展

```csharp
private sealed record AppSettings(
    string? LastOpenedFilePath,
    List<string>? RecentFiles  // 最多10条，最新在前
);
```

### 存储规则

- 配置文件路径不变：可执行文件同目录下的 `填tab表工具.config.json`
- JSON 格式示例：
  ```json
  {
    "LastOpenedFilePath": "J:\\hj2\\...\\OperatAct.txt",
    "RecentFiles": [
      "J:\\hj2\\...\\OperatAct.txt",
      "J:\\hj2\\...\\QuestData.txt"
    ]
  }
  ```
- 最多保留10条，新打开的文件插入列表头部，已存在的则移到头部（去重）
- 保存时机：文件成功加载后，与现有 `SaveSettings` 调用点一致

### 向后兼容

`RecentFiles` 为 nullable，旧配置文件没有此字段时默认为空列表，不影响已有用户。

## 菜单 UI 与交互

### 菜单结构

```
文件(&F)
├ 打开...  Ctrl+O
├ 保存     Ctrl+S
├ ───────────────        ← 分隔线
├ J:\hj2\...\OperAct.txt  ← 最近文件项（完整路径）
├ J:\hj2\...\QuestData.txt
└ ...
```

### 交互细节

- 最近文件项无快捷键，靠鼠标点击或方向键选择
- 点击最近文件项时：
  1. 检查文件是否存在
  2. 存在 → 加载文件（同"打开"的加载逻辑）
  3. 不存在 → 弹出 MessageBox 提示"文件不存在：xxx"，然后从列表中移除该项并更新菜单和配置
- 当前正在编辑的文件有未保存修改时，先走现有的未保存提示流程（与"打开"一致）

### 菜单构建方式

- 在 `BuildUi()` 的文件菜单构建部分，分隔线之后动态生成 `ToolStripMenuItem`
- 提供一个 `UpdateRecentFilesMenu()` 方法，在每次文件加载成功后和窗体初始化时调用，重建最近文件子菜单项

## 核心逻辑流程

### 添加最近文件

```
AddRecentFile(path):
  1. 从 RecentFiles 中移除已存在的相同路径（去重）
  2. 将 path 插入列表头部
  3. 如果列表超过 10 条，移除尾部多余项
  4. 调用 SaveSettings 持久化
  5. 调用 UpdateRecentFilesMenu 刷新菜单
```

### 调用时机

- `LoadCurrentFile()` 成功后（现有 `SaveSettings(new AppSettings(_document.Path))` 处），改为同时更新 `RecentFiles`

### 启动恢复流程

- 窗体初始化时读取配置中的 `RecentFiles`
- 调用 `UpdateRecentFilesMenu()` 构建菜单项
- `TryLoadLastOpenedFile()` 逻辑不变，仍然自动加载最后一次打开的文件

### 错误处理

- 配置文件读取失败：RecentFiles 为空列表，不影响主流程
- 配置文件写入失败：静默忽略（与现有 SaveSettings 行为一致）
