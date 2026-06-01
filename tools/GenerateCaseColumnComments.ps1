param(
    [string]$CaseRoot = 'G:\HD\sword3-products\client\ui\Scheme\Case',
    [string]$TableDefsPath = 'G:\HD\sword3-products\client\ui\Script\common\table_defs.lua',
    [string]$TranslationMappingPath = 'G:\HD\sword3-products\tools\GameDesignerTools\策划工具\Tools\翻译工具--生成Xml工具\JX3TabColumnMapping_New.xml',
    [string]$OutputPath = (Join-Path (Split-Path -Parent $PSScriptRoot) 'docs\Case表字段中文注释.md')
)

Set-StrictMode -Version 3.0
$ErrorActionPreference = 'Stop'

function Initialize-TextEncodings {
    try {
        Add-Type -AssemblyName System.Text.Encoding.CodePages -ErrorAction Stop
        $providerType = [System.Type]::GetType('System.Text.CodePagesEncodingProvider, System.Text.Encoding.CodePages')
        if ($null -ne $providerType) {
            $instance = $providerType.GetProperty('Instance').GetValue($null)
            [System.Text.Encoding]::RegisterProvider($instance)
        }
    }
    catch {
        # Windows PowerShell can already resolve GB18030 without the provider.
    }
}

function Read-TextSmart {
    param([string]$Path)

    $bytes = [System.IO.File]::ReadAllBytes($Path)
    if ($bytes.Length -ge 3 -and $bytes[0] -eq 0xEF -and $bytes[1] -eq 0xBB -and $bytes[2] -eq 0xBF) {
        return (Remove-LeadingBom -Text ([System.Text.Encoding]::UTF8.GetString($bytes)))
    }

    if ($bytes.Length -ge 2 -and $bytes[0] -eq 0xFF -and $bytes[1] -eq 0xFE) {
        return (Remove-LeadingBom -Text ([System.Text.Encoding]::Unicode.GetString($bytes)))
    }

    if ($bytes.Length -ge 2 -and $bytes[0] -eq 0xFE -and $bytes[1] -eq 0xFF) {
        return (Remove-LeadingBom -Text ([System.Text.Encoding]::BigEndianUnicode.GetString($bytes)))
    }

    $strictUtf8 = [System.Text.UTF8Encoding]::new($false, $true)
    try {
        return (Remove-LeadingBom -Text ($strictUtf8.GetString($bytes)))
    }
    catch [System.Text.DecoderFallbackException] {
        return (Remove-LeadingBom -Text ([System.Text.Encoding]::GetEncoding('GB18030').GetString($bytes)))
    }
}

function Remove-LeadingBom {
    param([string]$Text)

    if ($Text.Length -gt 0 -and $Text[0] -eq [char]0xFEFF) {
        return $Text.Substring(1)
    }

    return $Text
}

function Split-Lines {
    param([string]$Text)

    return $Text.Replace("`r`n", "`n").Replace("`r", "`n").Split("`n")
}

function Normalize-RelativePath {
    param([string]$Path)

    $value = $Path.Replace('/', '\').Replace('\\', '\').Trim()
    $lower = $value.ToLowerInvariant()
    $markers = @(
        '\ui\scheme\case\',
        'client\ui\scheme\case\',
        'ui\scheme\case\'
    )

    foreach ($marker in $markers) {
        $index = $lower.IndexOf($marker)
        if ($index -ge 0) {
            return $value.Substring($index + $marker.Length).TrimStart('\').ToLowerInvariant()
        }
    }

    return $value.TrimStart('\').ToLowerInvariant()
}

function Get-RelativeCasePath {
    param(
        [string]$Root,
        [string]$Path
    )

    $fullRoot = [System.IO.Path]::GetFullPath($Root).TrimEnd('\')
    $fullPath = [System.IO.Path]::GetFullPath($Path)
    return $fullPath.Substring($fullRoot.Length + 1)
}

function Count-Char {
    param(
        [string]$Text,
        [char]$Char
    )

    $count = 0
    foreach ($current in $Text.ToCharArray()) {
        if ($current -eq $Char) {
            $count++
        }
    }

    return $count
}

function Convert-TypeCode {
    param([string]$TypeCode)

    switch -CaseSensitive ($TypeCode) {
        'i' { return '整数' }
        'I' { return '整数' }
        'n' { return '整数' }
        'd' { return '整数' }
        'f' { return '浮点数' }
        's' { return '字符串' }
        'S' { return '多语言文本' }
        'b' { return '布尔' }
        'p' { return '路径' }
        default {
            if ([string]::IsNullOrWhiteSpace($TypeCode)) {
                return '未知'
            }

            return "未知($TypeCode)"
        }
    }
}

function Remove-TypePrefix {
    param([string]$Name)

    $value = $Name.Trim()
    if ($value -match '^(sz|dw|n|b|f|u|by|p|t|a)([A-Z_].*)$') {
        return $Matches[2]
    }

    return $value
}

function Normalize-NameKey {
    param([string]$Name)

    return (Remove-TypePrefix -Name $Name).ToLowerInvariant().Replace('_', '').Replace('-', '')
}

function Test-TextColumn {
    param(
        [hashtable]$TranslationColumns,
        [string]$RelativePathKey,
        [string]$ColumnName,
        [string]$LuaField
    )

    if (-not $TranslationColumns.ContainsKey($RelativePathKey)) {
        return $false
    }

    $columns = $TranslationColumns[$RelativePathKey]
    $candidates = New-Object 'System.Collections.Generic.List[string]'
    if (-not [string]::IsNullOrWhiteSpace($ColumnName)) {
        $candidates.Add($ColumnName)
        $candidates.Add((Remove-TypePrefix -Name $ColumnName))
    }
    if (-not [string]::IsNullOrWhiteSpace($LuaField)) {
        $candidates.Add($LuaField)
        $candidates.Add((Remove-TypePrefix -Name $LuaField))
    }

    foreach ($candidate in $candidates) {
        if ($columns.Contains($candidate)) {
            return $true
        }
    }

    return $false
}

function Get-MeaningFromName {
    param(
        [string]$ColumnName,
        [string]$LuaField,
        [bool]$IsTextColumn
    )

    $name = if (-not [string]::IsNullOrWhiteSpace($LuaField)) { $LuaField } else { $ColumnName }
    $key = Normalize-NameKey -Name $name
    $lower = $name.ToLowerInvariant()

    $exact = @{
        'id' = 'ID'
        'name' = '名称/标题文本'
        'title' = '标题文本'
        'shortname' = '简称文本'
        'shortdesc' = '简短描述文本'
        'desc' = '描述文本'
        'description' = '描述文本'
        'detail' = '详细说明/详情'
        'detaildesc' = '详细描述文本'
        'primer' = '剧情引子/简介'
        'message' = '提示消息文本'
        'msg' = '提示消息文本'
        'iconid' = '图标ID'
        'icon' = '图标'
        'itemtype' = '道具类型'
        'itemid' = '道具ID'
        'itemindex' = '道具索引'
        'itemtab' = '道具表类型'
        'series' = '系列'
        'holidayid' = '节日/活动ID'
        'sceneid' = '场景ID'
        'mapid' = '地图ID'
        'dlcid' = 'DLC/资料片ID'
        'dlcother' = '是否归入DLC其他分类'
        'showgetnew' = '是否显示新获得提示'
        'subachievements' = '子成就ID列表'
        'counters' = '成就计数器列表'
        'general' = '一级分类/大类ID'
        'sub' = '二级分类/子类ID'
        'subs' = '子项ID列表'
        'details' = '详情ID列表'
        'plotkey' = '剧情/活动剧情键'
        'sectionid' = '章节段落ID'
        'seasonid' = '赛季ID'
        'chapterid' = '章节ID'
        'beginquestid' = '起始任务ID'
        'endquestid' = '结束任务ID'
        'activityid' = '活动ID'
        'activeid' = '活动ID'
        'presetid' = '预设ID'
        'symbolid' = '标记/符号ID'
        'markid' = '标记ID'
        'startid' = '起始ID'
        'targetid' = '目标ID'
        'targettype' = '目标类型'
        'targetlevel' = '目标等级'
        'text' = '文本内容'
        'dsc' = '描述文本'
        'link' = '链接/跳转配置'
        'tplink' = '传送/跳转链接配置'
        'frame' = '帧号'
        'nameframe' = '名称图片帧号'
        'normalframe' = '普通状态帧号'
        'overframe' = '悬停/经过状态帧号'
        'top' = '顶部坐标/上边距'
        'last' = '末项/结束项'
        'windstrength' = '风力强度'
        'clothwindratio' = '布料风力系数'
        'localclothwind' = '局部布料风配置'
        'hidelock' = '是否隐藏锁定状态'
        'soundlist' = '音效列表'
        'sound' = '音效'
        'mountkungfu' = '当前心法/内功ID'
        'kungfuid' = '心法/内功ID'
        'showphysics1' = '是否显示外功属性1'
        'showphysics2' = '是否显示外功属性2'
        'showsolar1' = '是否显示阳性属性1'
        'showsolar2' = '是否显示阳性属性2'
        'showneutral1' = '是否显示混元属性1'
        'showneutral2' = '是否显示混元属性2'
        'showlunar1' = '是否显示阴性属性1'
        'showlunar2' = '是否显示阴性属性2'
        'showpoison1' = '是否显示毒性属性1'
        'showpoison2' = '是否显示毒性属性2'
        'showtherapy' = '是否显示治疗属性'
        'therapymainly' = '是否治疗为主'
        'physics1' = '外功属性1'
        'physics2' = '外功属性2'
        'solar1' = '阳性属性1'
        'solar2' = '阳性属性2'
        'neutral1' = '混元属性1'
        'neutral2' = '混元属性2'
        'lunar1' = '阴性属性1'
        'lunar2' = '阴性属性2'
        'poison1' = '毒性属性1'
        'poison2' = '毒性属性2'
        'therapy' = '治疗属性'
        'bossid' = '首领ID'
        'bossname' = '首领名称'
    }

    if ($exact.ContainsKey($key)) {
        return $exact[$key]
    }

    if ($lower -match 'quest') {
        if ($lower -match 'id') { return '任务ID' }
        return '任务相关配置'
    }
    if ($lower -match 'achievement') {
        if ($lower -match 'id') { return '成就ID' }
        return '成就相关配置'
    }
    if ($lower -match 'skill') {
        if ($lower -match 'id') { return '技能ID' }
        return '技能相关配置'
    }
    if ($lower -match 'buff') {
        if ($lower -match 'id') { return 'Buff ID' }
        return 'Buff相关配置'
    }
    if ($lower -match 'item') {
        if ($lower -match 'id|index') { return '道具ID/索引' }
        return '道具相关配置'
    }
    if ($lower -match 'reward|award|bonus') {
        return '奖励配置'
    }
    if ($lower -match 'path|file') {
        return '资源/文件路径'
    }
    if ($lower -match 'link|url') {
        return '链接/跳转配置'
    }
    if ($lower -match 'text|content|word') {
        return '文本内容'
    }
    if ($lower -match 'image|pic|photo') {
        return '图片资源配置'
    }
    if ($lower -match 'color|colour') {
        return '颜色配置'
    }
    if ($lower -match 'time|date|duration') {
        return '时间配置'
    }
    if ($lower -match 'count|num|amount|total') {
        return '数量/计数'
    }
    if ($lower -match 'level|grade|quality') {
        return '等级/品质'
    }
    if ($lower -match 'type|kind|class|category|group') {
        return '类型/分类'
    }
    if ($lower -match 'index|order|sort|rank') {
        return '索引/排序'
    }
    if ($lower -match 'frame') {
        return '帧号/图片帧配置'
    }
    if ($lower -match 'x$|y$|pos|position|width|height|offset') {
        return '坐标/尺寸配置'
    }
    if ($lower -match 'target') {
        return '目标配置'
    }
    if ($lower -match 'script|param|argument|(^|_)arg\d*($|_)') {
        return '脚本/参数配置'
    }
    if ($lower -match 'force|camp') {
        return '势力/阵营配置'
    }
    if ($lower -match 'show|enable|hide|disable|ban|need|can|is|has|use|open|close') {
        return '开关/条件配置'
    }
    if ($IsTextColumn) {
        return '文本内容'
    }

    return ''
}

function Get-ColumnComment {
    param(
        [string]$ColumnName,
        [string]$LuaField,
        [string]$InlineComment,
        [bool]$IsTextColumn
    )

    if (-not [string]::IsNullOrWhiteSpace($InlineComment)) {
        return [pscustomobject]@{
            Comment = $InlineComment.Trim()
            Source = '源码注释'
            Confidence = '高'
        }
    }

    $meaning = Get-MeaningFromName -ColumnName $ColumnName -LuaField $LuaField -IsTextColumn $IsTextColumn
    if (-not [string]::IsNullOrWhiteSpace($meaning)) {
        if ($IsTextColumn) {
            return [pscustomobject]@{
                Comment = $meaning
                Source = '翻译列/字段名'
                Confidence = '中'
            }
        }

        return [pscustomobject]@{
            Comment = $meaning
            Source = '字段名推断'
            Confidence = '低'
        }
    }

    return [pscustomobject]@{
        Comment = '待确认'
        Source = '待确认'
        Confidence = '待确认'
    }
}

function Convert-ToMarkdownCell {
    param([string]$Value)

    if ($null -eq $Value) {
        return ''
    }

    return $Value.Replace('|', '\|').Replace("`r`n", '<br>').Replace("`r", '<br>').Replace("`n", '<br>').Trim()
}

function Convert-ToMarkdownCodeCell {
    param([string]$Value)

    if ([string]::IsNullOrWhiteSpace($Value)) {
        return ''
    }

    $escaped = (Convert-ToMarkdownCell -Value $Value).Replace('`', '``')
    return [string]::Concat('`', $escaped, '`')
}

function Get-TableColumns {
    param([string]$Path)

    $text = Read-TextSmart -Path $Path
    $lines = Split-Lines -Text $text | Select-Object -First 10
    $rows = New-Object 'System.Collections.Generic.List[object]'
    $columnCount = 0

    foreach ($line in $lines) {
        $cells = ([string]$line).Split([char]9, [System.StringSplitOptions]::None)
        $rows.Add($cells)
        if ($cells.Length -gt $columnCount) {
            $columnCount = $cells.Length
        }
    }

    $columns = New-Object 'System.Collections.Generic.List[object]'
    for ($index = 0; $index -lt $columnCount; $index++) {
        $title = ''
        foreach ($cells in $rows) {
            if ($index -lt $cells.Length -and -not [string]::IsNullOrWhiteSpace($cells[$index])) {
                $title = $cells[$index].Trim()
                break
            }
        }

        if ([string]::IsNullOrWhiteSpace($title)) {
            $title = "第$($index + 1)列"
        }

        $columnRecord = [pscustomobject]@{
            Index = $index
            Title = $title
        }
        $columns.Add($columnRecord)
    }

    return $columns
}

function Read-TableDefinitions {
    param([string]$Path)

    $definitions = @{}
    if (-not (Test-Path -LiteralPath $Path)) {
        return $definitions
    }

    $text = Read-TextSmart -Path $Path
    $lines = Split-Lines -Text $text
    $currentRelativePath = $null
    $inTitle = $false
    $sawTitleBrace = $false
    $braceDepth = 0
    $fields = New-Object 'System.Collections.Generic.List[object]'

    foreach ($line in $lines) {
        if (-not $inTitle) {
            if ($line -match 'Path\s*=\s*"([^"]+)"') {
                $relativePath = Normalize-RelativePath -Path $Matches[1]
                if ($relativePath -match '(^|\\)case_mobile(\\|$)') {
                    $currentRelativePath = $null
                }
                else {
                    $currentRelativePath = $relativePath
                }
                continue
            }

            if ($null -ne $currentRelativePath -and $line -match 'Title\s*=') {
                $inTitle = $true
                $sawTitleBrace = $false
                $braceDepth = 0
                $fields = New-Object 'System.Collections.Generic.List[object]'
            }
            else {
                continue
            }
        }

        $openCount = Count-Char -Text $line -Char '{'
        $closeCount = Count-Char -Text $line -Char '}'
        if ($openCount -gt 0) {
            $sawTitleBrace = $true
        }
        $braceDepth += $openCount - $closeCount

        if ($line -match '\{f\s*=\s*"([^"]+)"\s*,\s*t\s*=\s*"([^"]+)"') {
            $typeCode = $Matches[1]
            $luaField = $Matches[2]
            $comment = ''
            if ($line -match '--\s*(.+)$') {
                $comment = $Matches[1].Trim()
            }

            $fieldRecord = [pscustomobject]@{
                TypeCode = $typeCode
                LuaField = $luaField
                InlineComment = $comment
            }
            $fields.Add($fieldRecord)
        }

        if ($sawTitleBrace -and $braceDepth -le 0) {
            if ($null -ne $currentRelativePath -and $fields.Count -gt 0) {
                $definitions[$currentRelativePath] = @($fields.ToArray())
            }

            $currentRelativePath = $null
            $inTitle = $false
            $sawTitleBrace = $false
            $braceDepth = 0
            $fields = New-Object 'System.Collections.Generic.List[object]'
        }
    }

    return $definitions
}

function Read-TranslationColumns {
    param([string]$Path)

    $result = @{}
    if (-not (Test-Path -LiteralPath $Path)) {
        return $result
    }

    $xml = [xml](Read-TextSmart -Path $Path)
    foreach ($tableNode in $xml.TextColumnMappings.ChildNodes) {
        if ($tableNode.NodeType -ne [System.Xml.XmlNodeType]::Element) {
            continue
        }
        if (-not $tableNode.HasAttribute('FilePath')) {
            continue
        }

        $relativePath = Normalize-RelativePath -Path $tableNode.GetAttribute('FilePath')
        $set = [System.Collections.Generic.HashSet[string]]::new([System.StringComparer]::OrdinalIgnoreCase)
        foreach ($columnNode in $tableNode.ChildNodes) {
            if ($columnNode.NodeType -eq [System.Xml.XmlNodeType]::Element) {
                [void]$set.Add($columnNode.LocalName)
                [void]$set.Add((Remove-TypePrefix -Name $columnNode.LocalName))
            }
        }

        if ($set.Count -gt 0) {
            $result[$relativePath] = $set
        }
    }

    return $result
}

function New-Document {
    param(
        [string]$CaseRoot,
        [hashtable]$Definitions,
        [hashtable]$TranslationColumns
    )

    $files = Get-ChildItem -LiteralPath $CaseRoot -Recurse -File |
        Where-Object { $_.Extension -in '.txt', '.tab' } |
        Sort-Object FullName

    $tables = New-Object 'System.Collections.Generic.List[object]'
    $totalColumns = 0
    $definitionMatchedTables = 0
    $textColumnCount = 0

    foreach ($file in $files) {
        $relativePath = Get-RelativeCasePath -Root $CaseRoot -Path $file.FullName
        $relativePathKey = Normalize-RelativePath -Path $relativePath
        [object[]]$columns = @(Get-TableColumns -Path $file.FullName)
        [object[]]$definitionFields = @()
        if ($Definitions.ContainsKey($relativePathKey)) {
            $definitionFields = @($Definitions[$relativePathKey])
        }
        if ($definitionFields.Count -gt 0) {
            $definitionMatchedTables++
        }

        $rows = New-Object 'System.Collections.Generic.List[object]'
        foreach ($column in $columns) {
            $field = if ($column.Index -lt $definitionFields.Count) { $definitionFields[$column.Index] } else { $null }
            $luaField = if ($null -ne $field) { $field.LuaField } else { '' }
            $typeCode = if ($null -ne $field) { $field.TypeCode } else { '' }
            $inlineComment = if ($null -ne $field) { $field.InlineComment } else { '' }
            $isTextColumn = Test-TextColumn `
                -TranslationColumns $TranslationColumns `
                -RelativePathKey $relativePathKey `
                -ColumnName $column.Title `
                -LuaField $luaField
            if ($isTextColumn) {
                $textColumnCount++
            }

            $comment = Get-ColumnComment `
                -ColumnName $column.Title `
                -LuaField $luaField `
                -InlineComment $inlineComment `
                -IsTextColumn $isTextColumn

            $rowRecord = [pscustomobject]@{
                Index = $column.Index + 1
                ColumnName = $column.Title
                LuaField = $luaField
                Type = Convert-TypeCode -TypeCode $typeCode
                Comment = $comment.Comment
                Source = $comment.Source
                Confidence = $comment.Confidence
            }
            $rows.Add($rowRecord)
        }

        $totalColumns += $columns.Count
        $tableRecord = [pscustomobject]@{
            RelativePath = $relativePath
            RelativePathKey = $relativePathKey
            Rows = @($rows.ToArray())
            HasDefinition = $definitionFields.Count -gt 0
        }
        $tables.Add($tableRecord)
    }

    $builder = [System.Text.StringBuilder]::new()
    [void]$builder.AppendLine('# Case表字段中文注释')
    [void]$builder.AppendLine()
    [void]$builder.AppendLine("> 生成时间：$(Get-Date -Format 'yyyy-MM-dd HH:mm:ss zzz')")
    [void]$builder.AppendLine("> 数据来源：$CaseRoot")
    [void]$builder.AppendLine()
    [void]$builder.AppendLine('## 汇总')
    [void]$builder.AppendLine()
    [void]$builder.AppendLine("- 总表数：$($tables.Count)")
    [void]$builder.AppendLine("- 总列位：$totalColumns")
    [void]$builder.AppendLine("- 匹配到 table_defs.lua 的表数：$definitionMatchedTables")
    [void]$builder.AppendLine("- 匹配到翻译映射的列位：$textColumnCount")
    [void]$builder.AppendLine()
    [void]$builder.AppendLine('## 可信度说明')
    [void]$builder.AppendLine()
    [void]$builder.AppendLine('| 来源 | 可信度 | 说明 |')
    [void]$builder.AppendLine('| --- | --- | --- |')
    [void]$builder.AppendLine('| 源码注释 | 高 | 来自 `table_defs.lua` 字段行内中文注释。 |')
    [void]$builder.AppendLine('| 翻译列/字段名 | 中 | 字段出现在翻译映射中，或按常见文案字段名识别。 |')
    [void]$builder.AppendLine('| 字段名推断 | 低 | 根据列名或 Lua 字段名关键词生成，需人工复核。 |')
    [void]$builder.AppendLine('| 待确认 | 待确认 | 未找到可靠来源，也无法从命名规则判断。 |')
    [void]$builder.AppendLine()

    foreach ($table in $tables) {
        [void]$builder.AppendLine("## $($table.RelativePath)")
        [void]$builder.AppendLine()
        $definitionText = if ($table.HasDefinition) { '是' } else { '否' }
        [void]$builder.AppendLine("- table_defs.lua：$definitionText")
        [void]$builder.AppendLine()
        [void]$builder.AppendLine('| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |')
        [void]$builder.AppendLine('| ---: | --- | --- | --- | --- | --- | --- |')
        foreach ($row in $table.Rows) {
            $line = '| {0} | {1} | {2} | {3} | {4} | {5} | {6} |' -f @(
                $row.Index,
                (Convert-ToMarkdownCodeCell -Value $row.ColumnName),
                (Convert-ToMarkdownCodeCell -Value $row.LuaField),
                (Convert-ToMarkdownCell -Value $row.Type),
                (Convert-ToMarkdownCell -Value $row.Comment),
                (Convert-ToMarkdownCell -Value $row.Source),
                (Convert-ToMarkdownCell -Value $row.Confidence)
            )
            [void]$builder.AppendLine($line)
        }
        [void]$builder.AppendLine()
    }

    return [pscustomobject]@{
        Markdown = $builder.ToString()
        TableCount = $tables.Count
        ColumnCount = $totalColumns
        DefinitionMatchedTables = $definitionMatchedTables
        TextColumnCount = $textColumnCount
    }
}

Initialize-TextEncodings

if (-not (Test-Path -LiteralPath $CaseRoot)) {
    throw "CaseRoot does not exist: $CaseRoot"
}

$definitions = Read-TableDefinitions -Path $TableDefsPath
$translationColumns = Read-TranslationColumns -Path $TranslationMappingPath
$document = New-Document -CaseRoot $CaseRoot -Definitions $definitions -TranslationColumns $translationColumns

$outputDirectory = Split-Path -Parent $OutputPath
if (-not [string]::IsNullOrWhiteSpace($outputDirectory)) {
    New-Item -ItemType Directory -Path $outputDirectory -Force | Out-Null
}

[System.IO.File]::WriteAllText($OutputPath, $document.Markdown, [System.Text.UTF8Encoding]::new($false))

Write-Host "Generated: $OutputPath"
Write-Host "Tables: $($document.TableCount)"
Write-Host "Columns: $($document.ColumnCount)"
Write-Host "Definition matched tables: $($document.DefinitionMatchedTables)"
Write-Host "Translation mapped columns: $($document.TextColumnCount)"
