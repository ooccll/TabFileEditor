Set-StrictMode -Version 3.0
$ErrorActionPreference = 'Stop'

function Assert-True {
    param(
        [bool]$Condition,
        [string]$Message
    )

    if (-not $Condition) {
        throw $Message
    }
}

function Assert-Contains {
    param(
        [string]$Text,
        [string]$Expected,
        [string]$Message
    )

    Assert-True -Condition $Text.Contains($Expected) -Message $Message
}

$repoRoot = Split-Path -Parent (Split-Path -Parent $PSCommandPath)
$scriptPath = Join-Path $repoRoot 'tools\GenerateCaseColumnComments.ps1'
$tempRoot = Join-Path ([System.IO.Path]::GetTempPath()) ('case-column-comments-test-' + [System.Guid]::NewGuid().ToString('N'))

try {
    $caseRoot = Join-Path $tempRoot 'client\ui\Scheme\Case'
    $scriptRoot = Join-Path $tempRoot 'client\ui\Script\common'
    $mappingRoot = Join-Path $tempRoot 'tools'
    New-Item -ItemType Directory -Path $caseRoot, $scriptRoot, $mappingRoot -Force | Out-Null
    New-Item -ItemType Directory -Path (Join-Path $caseRoot 'BossDbm') -Force | Out-Null

    Set-Content -LiteralPath (Join-Path $caseRoot 'achievement.txt') -Encoding UTF8 -Value @(
        'ID	General	Name	ShortDesc	ShowGetNew	dwDLCID'
        '1	2	首胜	完成首胜	1	6'
    )
    Set-Content -LiteralPath (Join-Path $caseRoot 'ActivityPlotSection.tab') -Encoding UTF8 -Value @(
        'szPlotKey	nSectionID	szTitle	szPrimer	szDetail'
        'PlotA	1	序章	引子	详情'
    )
    Set-Content -LiteralPath (Join-Path $caseRoot 'CharInfoAttack.tab') -Encoding UTF8 -Value @(
        'KungfuID	Physics1	TherapyMainly'
        '10015	1	0'
    )
    Set-Content -LiteralPath (Join-Path $caseRoot 'BossDbm\BossDbmMap1.tab') -Encoding UTF8 -Value @(
        'BossID	BossName	UnknownFlag'
        '10	测试首领	1'
    )

    Set-Content -LiteralPath (Join-Path $scriptRoot 'table_defs.lua') -Encoding UTF8 -Value @'
return {
    Achievement = {
        Path = "\\ui\\Scheme\\Case\\achievement.txt",
        Title = {
            {f = "i", t = "dwID"}, -- 成就ID
            {f = "i", t = "dwGeneral"},
            {f = "s", t = "szName"},
            {f = "S", t = "szShortDesc"},
            {f = "b", t = "bShowGetNew"},
            {f = "i", t = "dwDLCID"},
        }
    },
    ActivityPlotSection = {
        Path = "\\ui\\scheme\\case\\ActivityPlotSection.tab",
        Title = {
            {f = "s", t = "szPlotKey"},
            {f = "i", t = "nSectionID"},
            {f = "s", t = "szTitle"},
            {f = "S", t = "szPrimer"},
            {f = "S", t = "szDetail"},
        }
    },
    CharInfoAttack = {
        Path = "\\UI\\Scheme\\Case\\CharInfoAttack.tab",
        Title = {
            {f = "i", t = "dwMountKungfu"},
            {f = "b", t = "bShowPhysics1"},
            {f = "b", t = "bTherapyMainly"},
        }
    },
}
'@

    Set-Content -LiteralPath (Join-Path $mappingRoot 'JX3TabColumnMapping_New.xml') -Encoding UTF8 -Value @'
<?xml version="1.0" encoding="utf-8"?>
<TextColumnMappings>
  <achievement FilePath="client\ui\Scheme\Case\achievement.txt">
    <Name/>
    <ShortDesc/>
  </achievement>
  <ActivityPlotSection FilePath="client\ui\scheme\case\ActivityPlotSection.tab">
    <szTitle/>
    <szPrimer/>
    <szDetail/>
  </ActivityPlotSection>
</TextColumnMappings>
'@

    $outputPath = Join-Path $tempRoot 'Case表字段中文注释.md'
    & $scriptPath `
        -CaseRoot $caseRoot `
        -TableDefsPath (Join-Path $scriptRoot 'table_defs.lua') `
        -TranslationMappingPath (Join-Path $mappingRoot 'JX3TabColumnMapping_New.xml') `
        -OutputPath $outputPath

    Assert-True -Condition (Test-Path -LiteralPath $outputPath) -Message '未生成字段注释文档。'
    $content = Get-Content -LiteralPath $outputPath -Raw -Encoding UTF8

    Assert-Contains -Text $content -Expected '总表数：4' -Message '汇总表数不正确。'
    Assert-Contains -Text $content -Expected '总列位：17' -Message '汇总列位数不正确。'
    Assert-Contains -Text $content -Expected '| 1 | `ID` | `dwID` | 整数 | 成就ID | 源码注释 | 高 |' -Message '未使用源码行内注释。'
    Assert-Contains -Text $content -Expected '| 3 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |' -Message '未识别翻译文本列。'
    Assert-Contains -Text $content -Expected '| 5 | `ShowGetNew` | `bShowGetNew` | 布尔 | 是否显示新获得提示 | 字段名推断 | 低 |' -Message '未生成布尔字段推断说明。'
    Assert-Contains -Text $content -Expected '| 2 | `Physics1` | `bShowPhysics1` | 布尔 | 是否显示外功属性1 | 字段名推断 | 低 |' -Message '未生成属性列推断说明。'
    Assert-Contains -Text $content -Expected '## BossDbm\BossDbmMap1.tab' -Message '未注册子目录表未进入文档。'
    Assert-Contains -Text $content -Expected '| 3 | `UnknownFlag` |  | 未知 | 待确认 | 待确认 | 待确认 |' -Message '未注册未知列未标记待确认。'

    Write-Host 'GenerateCaseColumnComments.Tests.ps1 passed.'
}
finally {
    if (Test-Path -LiteralPath $tempRoot) {
        Remove-Item -LiteralPath $tempRoot -Recurse -Force
    }
}
