# 富文本检测大小写不敏感

## 问题

`RichTextMarkup.LooksLikeRichText()` 使用大小写敏感的 `value.Contains("<text>")`，导致单元格内容包含大写 `<Text>` 标签时（如游戏数据中的 `<Text>text="九溪龟之血。" font=100</Text>`），"设置"按钮不显示，无法打开富文本编辑器。

## 修改

将 `RichTextMarkup.cs` 第 211 行：

```csharp
return !string.IsNullOrEmpty(value) && value.Contains("<text>");
```

改为：

```csharp
return !string.IsNullOrEmpty(value) && value.Contains("<text>", StringComparison.OrdinalIgnoreCase);
```

## 影响分析

- **解析器**：`TryParse` 和 `TextElementRegex` 已支持大小写不敏感，无需改动
- **序列化**：始终输出小写 `<text>`，编辑保存后格式自动规范化
- **任务文本检测**：`LooksLikeQuestText` 已使用 `OrdinalIgnoreCase` 排除 `<text>`，不受影响
- **双击编辑**：复用同一检测方法，自动受益

## 测试要点

1. 单元格内容为 `<Text>text="测试" font=100</Text>` 时，"设置"按钮应显示
2. 点击"设置"按钮应正确打开富文本编辑器
3. 编辑保存后，标签应规范化为小写 `<text>`
4. 原有小写 `<text>` 内容不受影响
