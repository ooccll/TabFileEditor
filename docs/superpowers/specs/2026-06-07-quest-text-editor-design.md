# QuestTextEditorForm 设计规格

## Context

Quests.tab 中的 FinishedDialogue、UnfinishedDialogue 等列使用游戏特定的标签体系（`<G>`、`<F###>`、`<N>`、`<C>` 等）控制文字格式。当前这些列只能用纯文本 TextBox 编辑，无法直观看到渲染效果，标签语法容易出错。

需要一个新的任务文本编辑器，提供游戏风格 WYSIWYG 编辑 + 源码编辑的双栏布局，支持全部 10 种任务标签。

---

## 1. 窗体布局

**QuestTextEditorForm** — 独立对话框窗体

```
┌─────────────────────────────────────────────┐
│ 📝 任务文本编辑器        QuestID: xx | ...  │ ← 标题栏
├─────────────────────────────────────────────┤
│ <G> <N> <C> | 字体方案▼ | <H28> <T> <J>    │ ← 工具栏
│            | ↵换行                           │
├─────────────────────────────────────────────┤
│                                             │
│  🎮 游戏风格编辑区（WYSIWYG，可直接编辑）    │ ← 上方：自定义面板
│  ┌─────────────────────────────────────┐    │    QuestTextPreviewPanel
│  │ 　灰色动作描写文本                    │    │
│  │                                     │    │
│  │ 　白色对话文本 蓝色物品名             │    │
│  └─────────────────────────────────────┘    │
│                                             │
├───────── ▲ 可拖动分割条 ────────────────────┤
│                                             │
│  📄 源码区（带标签原始文本，可直接编辑）      │ ← 下方：TextBox
│  ┌─────────────────────────────────────┐    │
│  │ <G><F174 动作>\n<H28><G>对话...       │    │
│  └─────────────────────────────────────┘    │
│                                             │
├─────────────────────────────────────────────┤
│                              [确定] [取消]   │ ← 底部按钮
└─────────────────────────────────────────────┘
```

- 窗体大小约 900×800，居中于父窗体，可调整大小
- SplitContainer 上下分割，初始比例约 60:40
- 底部状态栏显示解析状态（同步成功/解析错误）

---

## 2. 工具栏

| 按钮 | 行为 |
|------|------|
| `<G>` 缩进 | 在光标处插入段落缩进标记 |
| `<N>` 玩家名 | 在光标处插入玩家名占位符 |
| `<C>` 门派称谓 | 在光标处插入门派称谓占位符 |
| 字体方案下拉 | 选中文本后选择方案 → 包裹为 `<F### text>`；未选文本时设置后续输入字体 |
| `<H28>` 段距 | 在光标处插入段距标记 |
| `<T>` 图标 | 弹出图标 ID 输入框 → 插入 `<T[id]>` |
| `<J>` 金钱 | 弹出金额输入框 → 插入 `<J[amount]>` |
| ↵ 换行 | 在光标处插入 `\n` |

常用方案快捷按钮（可选）：F171蓝、F172红、F173绿、F174灰，方便一键应用。

---

## 3. 标签渲染与编辑行为

### 3.1 上方编辑区（QuestTextPreviewPanel）

基于现有 `RichTextPreviewPanel` 架构构建，复用其光标/选区/键盘/剪贴板/IME 处理逻辑。

各标签的渲染与编辑行为：

| 标签 | 渲染方式 | 编辑行为 |
|------|---------|---------|
| `<G>` | 2em 缩进，无可见标记 | 光标可定位到缩进前；Backspace 删除缩进标记 |
| `<N>` | 蓝色虚线下划线占位符"玩家名" | 点击选中整个占位符；Backspace/Delete 删除 |
| `<C>` | 紫色虚线下划线占位符"门派称谓" | 点击选中整个占位符；Backspace/Delete 删除 |
| `<F### text>` | 内联渲染：对应颜色/字号显示文本 | 光标可进入内部编辑文字；选中后右键/下拉可更改字体方案 |
| `\n` | 换行 | 在换行处按 Enter 或 Backspace 跨段操作 |
| `<H28>` | 段间虚线间距条（编辑态可见标记） | 点击选中；Delete/Backspace 删除 |
| `<T[id]>` | 内联图标 + 半透明边框 | 点击选中整个元素；Backspace/Delete 删除 |
| `<J[amount]>` | 金色徽章样式金额文本 | 点击选中整个元素；Backspace/Delete 删除 |
| `<A>/<AT>/<SD>/<WT>` | 灰色标签样式占位显示 | 点击选中；内部属性不可编辑 |

### 3.2 下方源码区

- RichTextBox，等宽字体（Consolas 10pt），显示原始带标签文本
- 语法高亮：标签名用紫色，F 标签内文本用对应颜色，`\n` 用粉色，普通文本默认色
- 可直接编辑，编辑后自动解析并同步到上方编辑区
- 同步时保留源码区光标位置

---

## 4. 文档模型

### 4.1 QuestTextDocument

新建 `QuestTextDocument` 类，内部表示为有序节点列表：

```csharp
public abstract record QuestTextNode
{
    public record TextRun(string Text, int FontSchemeId) : QuestTextNode;
    public record Indent() : QuestTextNode;                    // <G>
    public record PlayerName() : QuestTextNode;                // <N>
    public record FactionTitle() : QuestTextNode;              // <C>
    public record FontBlock(string Text, int FontSchemeId) : QuestTextNode;  // <F### text>
    public record LineHeight(int Height) : QuestTextNode;      // <H##>
    public record Icon(int IconId) : QuestTextNode;            // <T##>
    public record Money(long Amount, bool Compare) : QuestTextNode;  // <J##>
    public record ReservedTag(string Name, string? Attribute) : QuestTextNode;  // <A>/<AT>/<SD>/<WT>
    public record Newline() : QuestTextNode;                   // \n
}
```

关键方法：
- `Parse(string tagText)` — 解析标签文本为节点列表
- `Serialize()` — 序列化节点列表回标签文本
- `CharCount` — 所有可定位字符的总数（用于光标定位）
- `GetCharAt(int offset)` / `GetFontAt(int offset)` — 按字符偏移查询
- `InsertText(int offset, string text, int fontSchemeId)` — 在偏移处插入文本
- `DeleteRange(int start, int length)` — 删除范围
- `ApplyFont(int start, int length, int fontSchemeId)` — 将范围内文本包裹为 FontBlock

### 4.2 内部字符缓冲区

为了复用 `RichTextPreviewPanel` 的光标/选区逻辑，`QuestTextPreviewPanel` 内部维护一个扁平字符缓冲区：

- 普通文本字符：直接映射
- `<G>`：映射为特殊 Unicode 字符 ``，渲染时绘制缩进
- `<N>`：映射为 `` + "玩家名"显示文本
- `<C>`：映射为 `` + "门派称谓"显示文本
- `<H28>`：映射为 ``，渲染时绘制虚线间距
- `<T>`：映射为 ``
- `<J>`：映射为 ``
- 预留标签：映射为 ``~``

每个字符仍关联 FontSchemeId，复用现有布局引擎的字体/颜色逻辑。

### 4.3 解析器 QuestTextParser

解析标签文本为节点列表。核心解析逻辑：

```
输入: "<G><F174 陶寒亭听你...>\n<H28><G>甚好！"
输出: [Indent, FontBlock("陶寒亭听你...", 174), Newline, LineHeight(28), Indent, TextRun("甚好！", defaultFont)]
```

解析规则：
- `<G>` → Indent
- `<N>` → PlayerName
- `<C>` → FactionTitle
- `<F### text>` → FontBlock，解析 F 后的数字为 FontSchemeId，空格后到 `>` 为文本
- `<H##>` → LineHeight，解析 H 后的数字
- `<T##>` → Icon，解析 T 后的数字为 IconId
- `<J##>` → Money，解析 J 后的数字；若含 `compare` 属性则 Compare=true
- `<A>` / `<AT>` / `<SD>` / `<WT>` → ReservedTag
- `\n`（字面量两个字符）→ Newline
- 其他纯文本 → TextRun（使用默认字体方案 ID=18）

注意事项：
- 默认字体方案 ID = 18（与现有 RichTextDocument.DefaultFontSchemeId 一致）
- `<F### text>` 中的文本若含 `>` 字符，解析器需匹配到正确的闭合 `>`（遵循引擎解析器的规则：F 标签内文本不包含未转义的 `>`）
- `<G>` 通常出现在行首，但编辑器不应限制其位置

---

## 5. 双向同步机制

### 5.1 上方 → 下方

编辑区内容变更时（`DocumentChanged` 事件）：
1. 从 `QuestTextDocument` 序列化为标签文本
2. 设置 `_updatingSourceText = true`
3. 更新下方源码 TextBox
4. 重置标志

### 5.2 下方 → 上方

源码 TextBox 的 `TextChanged` 事件：
1. 检查 `_updatingSourceText` 标志，若为 true 则跳过
2. 调用 `QuestTextParser.TryParse(sourceText)` 解析
3. 若成功：更新 `QuestTextDocument`，刷新上方编辑区
4. 若失败：状态栏显示解析错误，保持上方显示上一次有效内容，禁用确定按钮

### 5.3 防止反馈循环

与现有 `RichTextEditorForm` 相同的 `_updatingSourceText` 布尔标志模式。

---

## 6. 触发方式

### 6.1 内容检测

在 `MainForm` 中新增 `QuestTextLooksLike(string value)` 检测方法：

- 检测单元格值是否包含任务标签特征：`<G>`、`<F` 后跟数字、`<N>`、`<C>`、`<H` 后跟数字
- 排除已由 `RichTextMarkup.LooksLikeRichText` 匹配的 `<text>` 格式
- 注意：单独的 `\n` 不作为检测条件（太常见），需要配合其他标签特征

### 6.2 按钮触发

复用现有 `_richTextButton` 机制，扩展判断逻辑：

```
if (列名在 RichTextFieldNames 中 || 内容包含 <text>)
    → 打开 RichTextEditorForm
else if (内容匹配 QuestTextLooksLike)
    → 打开 QuestTextEditorForm
```

### 6.3 双击触发

对匹配 QuestTextLooksLike 的单元格，双击直接打开任务文本编辑器（而非进入普通编辑模式）。

---

## 7. 关键文件与复用

| 现有文件 | 复用方式 |
|---------|---------|
| `RichTextPreviewPanel.cs` | 架构模板，复用光标/选区/键盘/剪贴板/布局引擎逻辑 |
| `RichTextMarkup.cs` | 不复用（不同标签体系），但作为 QuestTextParser 的设计参考 |
| `FontSchemePickerForm.cs` | 直接复用，用于 F 标签选择字体方案 |
| `ElemSchemeLoader.cs` | 直接复用，用于解析 Font.ini 和加载字体文件 |
| `RichTextEditorForm.cs` | 布局模板，复用 SplitContainer + 双向同步模式 |
| `MainForm.cs` | 扩展按钮触发逻辑，新增 QuestTextLooksLike 检测 |

新增文件：
| 文件 | 说明 |
|------|------|
| `QuestTextDocument.cs` | 任务文本文档模型（节点列表 + 字符缓冲区） |
| `QuestTextParser.cs` | 标签文本解析器 + 序列化器 |
| `QuestTextPreviewPanel.cs` | 游戏风格 WYSIWYG 编辑面板 |
| `QuestTextEditorForm.cs` | 编辑器对话框窗体 |

---

## 8. 验证方式

1. **解析正确性**：从 Quests.tab 读取多条 FinishedDialogue 内容，解析后序列化，验证与原始文本一致
2. **WYSIWYG 编辑**：打开编辑器，验证渲染效果与游戏内显示一致；验证光标定位、文字输入、选择、删除
3. **双向同步**：上方编辑后下方源码自动更新；下方修改源码后上方渲染自动更新
4. **工具栏操作**：测试每个按钮插入对应标签；选中文本后应用字体方案
5. **端到端**：在主界面双击 Quests.tab 的 FinishedDialogue 单元格 → 编辑器打开 → 编辑 → 确定 → 单元格值更新
