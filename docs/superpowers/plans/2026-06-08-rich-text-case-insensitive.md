# 富文本检测大小写不敏感 实现计划

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** 让 `LooksLikeRichText` 支持大小写不敏感的 `<text>` 标签检测，使含大写 `<Text>` 标签的单元格也能显示"设置"按钮。

**Architecture:** 修改 `RichTextMarkup.LooksLikeRichText()` 方法，将 `Contains("<text>")` 改为使用 `StringComparison.OrdinalIgnoreCase`，与解析器保持一致。

**Tech Stack:** C# / .NET 10.0 / WinForms

---

### Task 1: 修改 LooksLikeRichText 为大小写不敏感

**Files:**
- Modify: `src/TabFileEditor.App/RichTextMarkup.cs:209-212`

- [ ] **Step 1: 修改 LooksLikeRichText 方法**

将第 211 行：

```csharp
return !string.IsNullOrEmpty(value) && value.Contains("<text>");
```

改为：

```csharp
return !string.IsNullOrEmpty(value) && value.Contains("<text>", StringComparison.OrdinalIgnoreCase);
```

- [ ] **Step 2: 构建验证**

Run: `dotnet build src/TabFileEditor.App/TabFileEditor.App.csproj`
Expected: BUILD SUCCEEDED，无编译错误

- [ ] **Step 3: 提交**

```bash
git add src/TabFileEditor.App/RichTextMarkup.cs
git commit -m "修复LooksLikeRichText大小写敏感导致大写<Text>标签无法触发设置按钮的问题"
```
