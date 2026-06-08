# 最近打开文件功能 实施计划

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** 在"文件"菜单中新增最近打开文件列表，最多保留10条，点击可快速重新打开文件。

**Architecture:** 扩展现有 `AppSettings` record 新增 `RecentFiles` 列表字段，在 `MainForm` 中新增 `AddRecentFile`、`UpdateRecentFilesMenu`、`OnRecentFileClick` 方法，修改 `BuildUi` 和 `LoadCurrentFile` 实现完整流程。

**Tech Stack:** C# / .NET 10 / WinForms / System.Text.Json

---

### Task 1: 扩展 AppSettings 数据模型

**Files:**
- Modify: `src/TabFileEditor.App/MainForm.cs:3031`

- [ ] **Step 1: 修改 AppSettings record**

将第 3031 行的 `AppSettings` record 从：

```csharp
private sealed record AppSettings(string? LastOpenedFilePath);
```

改为：

```csharp
private sealed record AppSettings(string? LastOpenedFilePath, List<string>? RecentFiles);
```

- [ ] **Step 2: 修改 LoadSettings 默认值**

将第 3043 行的默认返回和第 3047 行的 catch 返回从 `new AppSettings(null)` 改为 `new AppSettings(null, null)`：

```csharp
if (!File.Exists(path)) return new AppSettings(null, null);
```

```csharp
catch { return new AppSettings(null, null); }
```

- [ ] **Step 3: 修改 LoadCurrentFile 中的 SaveSettings 调用**

将第 1325 行从：

```csharp
SaveSettings(new AppSettings(_document.Path));
```

改为：

```csharp
var settings = LoadSettings();
var recentFiles = settings.RecentFiles ?? new List<string>();
recentFiles.Remove(_document.Path);
recentFiles.Insert(0, _document.Path);
if (recentFiles.Count > 10) recentFiles.RemoveRange(10, recentFiles.Count - 10);
SaveSettings(new AppSettings(_document.Path, recentFiles));
UpdateRecentFilesMenu(recentFiles);
```

- [ ] **Step 4: 构建并验证编译通过**

Run: `cd "J:\怀旧版策划工具\怀旧版策划库\trunk\ui\AI\AI_Tools\填tab表" && dotnet build src/TabFileEditor.App/TabFileEditor.App.csproj`
Expected: Build succeeded, 0 errors

- [ ] **Step 5: 运行现有测试确认无回归**

Run: `cd "J:\怀旧版策划工具\怀旧版策划库\trunk\ui\AI\AI_Tools\填tab表" && dotnet test`
Expected: All tests pass

- [ ] **Step 6: 提交**

```bash
git add src/TabFileEditor.App/MainForm.cs
git commit -m "扩展AppSettings支持最近文件列表"
```

---

### Task 2: 添加菜单 UI 和交互逻辑

**Files:**
- Modify: `src/TabFileEditor.App/MainForm.cs`

- [ ] **Step 1: 添加 _recentFiles 字段和 _fileMenu 字段**

在 MainForm 类的字段区域（约第 70 行 `_document` 字段附近）添加：

```csharp
private List<string> _recentFiles = new();
private readonly ToolStripMenuItem _fileMenu = new("文件(&F)");
```

- [ ] **Step 2: 修改 BuildUi 中的文件菜单构建**

将第 123-125 行从：

```csharp
var fileMenu = new ToolStripMenuItem("文件(&F)");
fileMenu.DropDownItems.Add(new ToolStripMenuItem("打开...", null, OnMenuOpenFile) { ShortcutKeys = Keys.Control | Keys.O });
fileMenu.DropDownItems.Add(new ToolStripMenuItem("保存", null, OnMenuSaveFile) { ShortcutKeys = Keys.Control | Keys.S });
```

改为：

```csharp
_fileMenu.DropDownItems.Add(new ToolStripMenuItem("打开...", null, OnMenuOpenFile) { ShortcutKeys = Keys.Control | Keys.O });
_fileMenu.DropDownItems.Add(new ToolStripMenuItem("保存", null, OnMenuSaveFile) { ShortcutKeys = Keys.Control | Keys.S });
_fileMenu.DropDownItems.Add(new ToolStripSeparator());
```

同时将第 135 行的 `fileMenu` 改为 `_fileMenu`：

```csharp
menuStrip.Items.AddRange(new ToolStripItem[] { _fileMenu, editMenu, helpMenu });
```

- [ ] **Step 3: 添加 UpdateRecentFilesMenu 方法**

在 `OnMenuAbout` 方法之后（约第 1274 行后）添加：

```csharp
private void UpdateRecentFilesMenu(List<string>? recentFiles)
{
    _recentFiles = recentFiles ?? new List<string>();

    while (_fileMenu.DropDownItems.Count > 3)
        _fileMenu.DropDownItems.RemoveAt(_fileMenu.DropDownItems.Count - 1);

    foreach (var filePath in _recentFiles)
    {
        var item = new ToolStripMenuItem(filePath, null, OnRecentFileClick);
        _fileMenu.DropDownItems.Add(item);
    }
}

private void OnRecentFileClick(object? sender, EventArgs e)
{
    if (sender is not ToolStripMenuItem item) return;
    var path = item.Text;

    if (!File.Exists(path))
    {
        MessageBox.Show(this, $"文件不存在：\n{path}", "文件不存在", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        _recentFiles.Remove(path);
        SaveSettings(new AppSettings(LoadSettings().LastOpenedFilePath, _recentFiles));
        UpdateRecentFilesMenu(_recentFiles);
        return;
    }

    if (!ConfirmDiscardDirtyChanges("打开新文件前，存在未保存修改。是否放弃这些修改？"))
        return;

    _filePathTextBox.Text = path;
    LoadCurrentFile();
}
```

- [ ] **Step 4: 修改 TryLoadLastOpenedFile 以初始化最近文件菜单**

将第 3060-3067 行的 `TryLoadLastOpenedFile` 方法从：

```csharp
private void TryLoadLastOpenedFile()
{
    var settings = LoadSettings();
    if (string.IsNullOrWhiteSpace(settings.LastOpenedFilePath)) return;
    if (!File.Exists(settings.LastOpenedFilePath)) return;
    _filePathTextBox.Text = settings.LastOpenedFilePath;
    LoadCurrentFile();
}
```

改为：

```csharp
private void TryLoadLastOpenedFile()
{
    var settings = LoadSettings();
    UpdateRecentFilesMenu(settings.RecentFiles);
    if (string.IsNullOrWhiteSpace(settings.LastOpenedFilePath)) return;
    if (!File.Exists(settings.LastOpenedFilePath)) return;
    _filePathTextBox.Text = settings.LastOpenedFilePath;
    LoadCurrentFile();
}
```

- [ ] **Step 5: 构建并验证编译通过**

Run: `cd "J:\怀旧版策划工具\怀旧版策划库\trunk\ui\AI\AI_Tools\填tab表" && dotnet build src/TabFileEditor.App/TabFileEditor.App.csproj`
Expected: Build succeeded, 0 errors

- [ ] **Step 6: 运行现有测试确认无回归**

Run: `cd "J:\怀旧版策划工具\怀旧版策划库\trunk\ui\AI\AI_Tools\填tab表" && dotnet test`
Expected: All tests pass

- [ ] **Step 7: 提交**

```bash
git add src/TabFileEditor.App/MainForm.cs
git commit -m "添加最近打开文件菜单UI和交互逻辑"
```

---

### Task 3: 添加测试

**Files:**
- Modify: `tests/TabFileEditor.App.Tests/MainFormTests.cs`

- [ ] **Step 1: 添加最近文件菜单测试**

在 `MainFormTests` 类的测试方法区域（最后一个测试方法之后、辅助方法之前）添加：

```csharp
[Fact]
public void LoadingFileAddsToRecentFilesMenu()
{
    RunOnStaThread(() =>
    {
        var tablePath = CreateSampleTable();
        using var form = new MainForm();
        form.CreateControl();
        FindFilePathTextBox(form).Text = tablePath;

        InvokePrivate(form, "LoadCurrentFile");

        var menuStrip = FindDescendants<MenuStrip>(form).Single();
        var fileMenu = menuStrip.Items.Cast<ToolStripMenuItem>().Single(m => m.Text == "文件(&F)");
        Assert.True(fileMenu.DropDownItems.Count >= 4);
        var recentItem = fileMenu.DropDownItems.Cast<ToolStripItem>().OfType<ToolStripMenuItem>().Last();
        Assert.Equal(tablePath, recentItem.Text);
    });
}

[Fact]
public void RecentFilesMenuShowsCompleteFilePath()
{
    RunOnStaThread(() =>
    {
        var tablePath = CreateSampleTable();
        using var form = new MainForm();
        form.CreateControl();
        FindFilePathTextBox(form).Text = tablePath;

        InvokePrivate(form, "LoadCurrentFile");

        var menuStrip = FindDescendants<MenuStrip>(form).Single();
        var fileMenu = menuStrip.Items.Cast<ToolStripMenuItem>().Single(m => m.Text == "文件(&F)");
        var recentItems = fileMenu.DropDownItems.Cast<ToolStripItem>()
            .Where(item => item is ToolStripMenuItem and not ToolStripSeparator)
            .Cast<ToolStripMenuItem>()
            .Skip(2)
            .ToList();
        Assert.Single(recentItems);
        Assert.Equal(tablePath, recentItems[0].Text);
    });
}
```

- [ ] **Step 2: 运行新测试确认通过**

Run: `cd "J:\怀旧版策划工具\怀旧版策划库\trunk\ui\AI\AI_Tools\填tab表" && dotnet test tests/TabFileEditor.App.Tests/TabFileEditor.App.Tests.csproj --filter "LoadingFileAddsToRecentFilesMenu|RecentFilesMenuShowsCompleteFilePath" -v normal`
Expected: 2 tests pass

- [ ] **Step 3: 运行全部测试确认无回归**

Run: `cd "J:\怀旧版策划工具\怀旧版策划库\trunk\ui\AI\AI_Tools\填tab表" && dotnet test`
Expected: All tests pass

- [ ] **Step 4: 提交**

```bash
git add tests/TabFileEditor.App.Tests/MainFormTests.cs
git commit -m "添加最近打开文件功能的测试"
```

---

### Task 4: 代码审查与最终验证

**Files:**
- Review: `src/TabFileEditor.App/MainForm.cs`
- Review: `tests/TabFileEditor.App.Tests/MainFormTests.cs`

- [ ] **Step 1: 执行 /review 代码审查**

- [ ] **Step 2: 手动启动应用验证功能**

Run: `cd "J:\怀旧版策划工具\怀旧版策划库\trunk\ui\AI\AI_Tools\填tab表" && dotnet run --project src/TabFileEditor.App/TabFileEditor.App.csproj`

验证项目：
1. 文件菜单下方显示分隔线
2. 打开文件后，分隔线下方出现完整路径菜单项
3. 点击菜单项可重新打开文件
4. 关闭应用后重新打开，最近文件列表保留
5. 打开不存在的文件路径时弹出提示并从列表移除

- [ ] **Step 3: 推送到远端**

```bash
git push
```
