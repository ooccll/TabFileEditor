# Case表字段中文注释

> 生成时间：2026-06-01 11:01:46 +08:00
> 数据来源：G:\HD\sword3-products\client\ui\Scheme\Case

## 汇总

- 总表数：1864
- 总列位：12104
- 匹配到 table_defs.lua 的表数：810
- 匹配到翻译映射的列位：1247

## 可信度说明

| 来源 | 可信度 | 说明 |
| --- | --- | --- |
| 源码注释 | 高 | 来自 `table_defs.lua` 字段行内中文注释。 |
| 翻译列/字段名 | 中 | 字段出现在翻译映射中，或按常见文案字段名识别。 |
| 字段名推断 | 低 | 根据列名或 Lua 字段名关键词生成，需人工复核。 |
| 待确认 | 待确认 | 未找到可靠来源，也无法从命名规则判断。 |

## AccountFriendAvatar.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szPath` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |

## achievement.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `General` | `dwGeneral` | 整数 | 一级分类/大类ID | 字段名推断 | 低 |
| 3 | `Sub` | `dwSub` | 整数 | 二级分类/子类ID | 字段名推断 | 低 |
| 4 | `Detail` | `dwDetail` | 整数 | 详细说明/详情 | 字段名推断 | 低 |
| 5 | `Visible` | `nVisible` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `IconID` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 7 | `SubAchievements` | `szSubAchievements` | 字符串 | 子成就ID列表 | 字段名推断 | 低 |
| 8 | `Counters` | `szCounters` | 字符串 | 成就计数器列表 | 字段名推断 | 低 |
| 9 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 10 | `ShortDesc` | `szShortDesc` | 多语言文本 | 简短描述文本 | 翻译列/字段名 | 中 |
| 11 | `Desc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 12 | `Message` | `szMsg` | 多语言文本 | 提示消息文本 | 翻译列/字段名 | 中 |
| 13 | `ItemType` | `dwItemType` | 整数 | 道具类型 | 字段名推断 | 低 |
| 14 | `ItemID` | `dwItemID` | 整数 | 道具ID | 字段名推断 | 低 |
| 15 | `Series` | `szSeries` | 字符串 | 系列 | 字段名推断 | 低 |
| 16 | `HolidayID` | `dwHolidayID` | 整数 | 节日/活动ID | 字段名推断 | 低 |
| 17 | `SceneID` | `szSceneID` | 字符串 | 场景ID | 字段名推断 | 低 |
| 18 | `ShowGetNew` | `bShowGetNew` | 布尔 | 是否显示新获得提示 | 字段名推断 | 低 |
| 19 | `dwDLCID` | `dwDLCID` | 整数 | DLC/资料片ID | 字段名推断 | 低 |
| 20 | `dwMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 21 | `bDLCOther` | `bDLCOther` | 布尔 | 是否归入DLC其他分类 | 字段名推断 | 低 |

## AchievementCounter.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |

## achivementgeneral.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `Subs` | `szSubs` | 字符串 | 子项ID列表 | 字段名推断 | 低 |

## achivementprogress.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `Top` | `nTop` | 整数 | 顶部坐标/上边距 | 字段名推断 | 低 |
| 4 | `Last` | `nLast` | 整数 | 末项/结束项 | 字段名推断 | 低 |
| 5 | `ImagePath` | `szImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `Frame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 7 | `ItemType` | `nItemType` | 整数 | 道具类型 | 字段名推断 | 低 |
| 8 | `ItemID` | `nItemID` | 整数 | 道具ID | 字段名推断 | 低 |
| 9 | `SFXPath` | `szSFXPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `MobileImagePath` | `szMobileImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |

## achivementsdetail.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `Achievements` | `szAchievements` | 字符串 | 成就相关配置 | 字段名推断 | 低 |

## achivementsub.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `Details` | `szDetails` | 字符串 | 详情ID列表 | 字段名推断 | 低 |
| 4 | `Achievements` | `szAchievements` | 字符串 | 成就相关配置 | 字段名推断 | 低 |

## ActivityCollectInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nActivityID` | `nActivityID` | 整数 | 活动ID | 字段名推断 | 低 |
| 2 | `szBgImagePath` | `szBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `szMoileBgPath` | `szMoileBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## ActivityCollectItem.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwTabType` | `dwTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 4 | `nCount` | `nCount` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 5 | `nActivityID` | `nActivityID` | 整数 | 活动ID | 字段名推断 | 低 |
| 6 | `szDsc` | `szDsc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 7 | `szTPLink` | `szTPLink` | 字符串 | 传送/跳转链接配置 | 字段名推断 | 低 |

## ActivityFilterPreset.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `dwMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 3 | `dwActivityID` | `dwActivityID` | 整数 | 活动ID | 字段名推断 | 低 |
| 4 | `nPresetID` | `nPresetID` | 整数 | 预设ID | 字段名推断 | 低 |
| 5 | `fWindStrength` | `fWindStrength` | 浮点数 | 风力强度 | 字段名推断 | 低 |
| 6 | `fClothWindRatio` | `fClothWindRatio` | 浮点数 | 布料风力系数 | 字段名推断 | 低 |
| 7 | `szLocalClothWind` | `szLocalClothWind` | 字符串 | 局部布料风配置 | 字段名推断 | 低 |
| 8 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 9 | `szImgNormalPath` | `szImgNormalPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `nNormalFrame` | `nNormalFrame` | 整数 | 普通状态帧号 | 字段名推断 | 低 |
| 11 | `szImgOverPath` | `szImgOverPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 12 | `nOverFrame` | `nOverFrame` | 整数 | 悬停/经过状态帧号 | 字段名推断 | 低 |
| 13 | `szImgDisablePath` | `szImgDisablePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 14 | `nDisableFrame` | `nDisableFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 15 | `szMobileImgNormalPath` | `szMobileImgNormalPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 16 | `szMobileImgDisablePath` | `szMobileImgDisablePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |

## ActivityGetRewardlInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nActivityID` | `nActivityID` | 整数 | 活动ID | 字段名推断 | 低 |
| 2 | `szBgImagePath` | `szBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `szTPLink` | `szTPLink` | 字符串 | 传送/跳转链接配置 | 字段名推断 | 低 |
| 4 | `szMobileBgPath` | `szMobileBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 字段名推断 | 低 |
| 6 | `szText` | `szText` | 字符串 | 文本内容 | 字段名推断 | 低 |

## ActivityPlotSection.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `szPlotKey` | `szPlotKey` | 字符串 | 剧情/活动剧情键 | 字段名推断 | 低 |
| 2 | `nSectionID` | `nSectionID` | 整数 | 章节段落ID | 字段名推断 | 低 |
| 3 | `nSeasonID` | `nSeasonID` | 整数 | 赛季ID | 字段名推断 | 低 |
| 4 | `nChapterID` | `nChapterID` | 整数 | 章节ID | 字段名推断 | 低 |
| 5 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 6 | `dwBeginQuestID` | `dwBeginQuestID` | 整数 | 起始任务ID | 字段名推断 | 低 |
| 7 | `dwEndQuestID` | `dwEndQuestID` | 整数 | 结束任务ID | 字段名推断 | 低 |
| 8 | `bHideLock` | `bHideLock` | 布尔 | 是否隐藏锁定状态 | 字段名推断 | 低 |
| 9 | `szPrimer` | `szPrimer` | 多语言文本 | 剧情引子/简介 | 翻译列/字段名 | 中 |
| 10 | `szDetail` | `szDetail` | 多语言文本 | 详细说明/详情 | 翻译列/字段名 | 中 |
| 11 | `szSoundList` | `szSoundList` | 字符串 | 音效列表 | 字段名推断 | 低 |

## ActivityPlotSectionLayer.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `szPlotKey` | `szPlotKey` | 字符串 | 剧情/活动剧情键 | 字段名推断 | 低 |
| 2 | `nID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 3 | `szType` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 4 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 5 | `szTime` | `szTime` | 字符串 | 时间配置 | 字段名推断 | 低 |
| 6 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `nImageFrame` | `nImageFrame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 8 | `bHideLock` | `bHideLock` | 布尔 | 是否隐藏锁定状态 | 字段名推断 | 低 |

## ActivitySymbolInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `MapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 2 | `SymbolID` | `nSymbolID` | 整数 | 标记/符号ID | 字段名推断 | 低 |
| 3 | `ImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 5 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 6 | `Description` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 7 | `Position` | `szPositions` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |

## ActivityTip.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ActivityID` | `dwActivityID` | 整数 | 活动ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `TimeDesc` | `szTimeDesc` | 字符串 | 时间配置 | 翻译列/字段名 | 中 |
| 4 | `Link` | `szLink` | 多语言文本 | 链接/跳转配置 | 字段名推断 | 低 |
| 5 | `Title` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |

## AddMapMark.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwMarkID` | `dwMarkID` | 整数 | 标记ID | 字段名推断 | 低 |
| 2 | `bImage` | `bImage` | 布尔 | 图片资源配置 | 字段名推断 | 低 |
| 3 | `szImgPath` | `szImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 5 | `bAni` | `bAni` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `szAniPath` | `szAniPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `nGroup` | `nGroup` | 整数 | 类型/分类 | 字段名推断 | 低 |

## Adventure.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwStartID` | `dwStartID` | 整数 | 起始ID | 字段名推断 | 低 |
| 3 | `dwFinishID` | `dwFinishID` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 4 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 5 | `szRewardPath` | `szRewardPath` | 路径 | 奖励配置 | 字段名推断 | 低 |
| 6 | `szNamePath` | `szNamePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `nNameFrame` | `nNameFrame` | 整数 | 名称图片帧号 | 字段名推断 | 低 |
| 8 | `szFirstPagePath` | `szFirstPagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `szTaskTracePath` | `szTaskTracePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `nTaskTraceFrame` | `nTaskTraceFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 11 | `szOpenPath` | `szOpenPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 12 | `nOpenFrame` | `nOpenFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 13 | `szRewardType` | `szRewardType` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 14 | `szOpenRewardPath` | `szOpenRewardPath` | 路径 | 奖励配置 | 字段名推断 | 低 |
| 15 | `bHide` | `bHide` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 16 | `nStartQuestID` | `nStartQuestID` | 整数 | 任务ID | 字段名推断 | 低 |
| 17 | `nFinishQuestID` | `nFinishQuestID` | 整数 | 任务ID | 字段名推断 | 低 |
| 18 | `nClassify` | `nClassify` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 19 | `bPerfect` | `bPerfect` | 布尔 | 待确认 | 待确认 | 待确认 |
| 20 | `szReward` | `szReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 21 | `szMobileNamePath` | `szMobileNamePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 22 | `szMobileOpenNamePath` | `szMobileOpenNamePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 23 | `buffList` | `szBuffList` | 字符串 | Buff相关配置 | 字段名推断 | 低 |
| 24 | `szFront` | `szFront` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 25 | `nCampCanSee` | `nCampCanSee` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 26 | `nRelation` | `nRelation` | 整数 | 待确认 | 待确认 | 待确认 |
| 27 | `RewdItem` | `szRewardItemList` | 字符串 | 道具相关配置 | 字段名推断 | 低 |

## AdventureTask.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwAdventureID` | `dwAdventureID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `dwAcceptID` | `dwAcceptID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `dwFinishID` | `dwFinishID` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 5 | `dwPage` | `dwPage` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 字段名推断 | 低 |
| 7 | `szGoalMsg` | `szGoalMsg` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `szDescribe` | `szDescribe` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 9 | `szFinishDescribe` | `szFinishDescribe` | 多语言文本 | 开关/条件配置 | 字段名推断 | 低 |
| 10 | `szFramePath` | `szFramePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 11 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 12 | `nQuestID` | `nQuestID` | 整数 | 任务ID | 字段名推断 | 低 |

## AdventureTaskOrigin.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `dwAdventureID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `dwAcceptID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `dwFinishID` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 5 | `dwPage` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 6 | `szTitle` |  | 未知 | 标题文本 | 翻译列/字段名 | 中 |
| 7 | `szGoalMsg` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `szDescribe` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `szFinishDescribe` |  | 未知 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 10 | `szFramePath` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |
| 11 | `nFrame` |  | 未知 | 帧号 | 字段名推断 | 低 |
| 12 | `nQuestID` |  | 未知 | 任务ID | 字段名推断 | 低 |

## AdventureTryBook.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwAdvID` | `dwAdvID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szAdvName` | `szAdvName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `nOffset` | `nOffset` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `nLength` | `nLength` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 6 | `nTryMax` | `nTryMax` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `nFreshType` | `nFreshType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 8 | `dwPetID` | `dwPetID` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `bHide` | `bHide` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 10 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 11 | `szDescRich` | `szDescRich` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 12 | `dwTotalTryCountID` | `dwTotalTryCountID` | 整数 | 数量/计数 | 字段名推断 | 低 |

## ALLKB_SeasonReward.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `DesignationID` | `nDesignationID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `ItemType1` | `nItemType1` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 5 | `ItemIndex1` | `dwItemIndex1` | 整数 | 道具ID/索引 | 字段名推断 | 低 |
| 6 | `Count1` | `nCount1` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 7 | `ItemType2` | `nItemType2` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 8 | `ItemIndex2` | `dwItemIndex2` | 整数 | 道具ID/索引 | 字段名推断 | 低 |
| 9 | `Count2` | `nCount2` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 10 | `ItemType3` | `nItemType3` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 11 | `ItemIndex3` | `dwItemIndex3` | 整数 | 道具ID/索引 | 字段名推断 | 低 |
| 12 | `Count3` | `nCount3` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 13 | `ItemType4` | `nItemType4` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 14 | `ItemIndex4` | `dwItemIndex4` | 整数 | 道具ID/索引 | 字段名推断 | 低 |
| 15 | `Count4` | `nCount4` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 16 | `ItemType5` | `nItemType5` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 17 | `ItemIndex5` | `dwItemIndex5` | 整数 | 道具ID/索引 | 字段名推断 | 低 |
| 18 | `Count5` | `nCount5` | 整数 | 数量/计数 | 字段名推断 | 低 |

## ALLKB_WeekReward.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `Gold` | `nGold` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `Prestige` | `nPrestige` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `TitlePoint` | `nTitlePoint` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `DesignationID` | `nDesignationID` | 整数 | 待确认 | 待确认 | 待确认 |

## animalAction.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Command` | `nCommand` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `CommandDesc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 3 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 4 | `Tips` | `szTip` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 5 | `IconID` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |

## AnnounceImage.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Path` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |

## area_lock.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `id` | `id` | 整数 | ID | 字段名推断 | 低 |
| 2 | `ui_wnd` | `ui_wnd` | 路径 | 待确认 | 待确认 | 待确认 |
| 3 | `ui_item` | `ui_item` | 路径 | 道具相关配置 | 字段名推断 | 低 |
| 4 | `shield_key` | `shield` | 布尔 | 待确认 | 待确认 | 待确认 |
| 5 | `gray` | `is_gray` | 布尔 | 坐标/尺寸配置 | 字段名推断 | 低 |

## Arena\ArenaCropReward.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nCropType` | `nCropType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `szDescribe` | `szDescribe` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `nAwardRequire` | `nAwardRequire` | 整数 | 奖励配置 | 字段名推断 | 低 |
| 5 | `szReward` | `szReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |

## Arena\ArenaServer.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `ServerIP` | `szIP` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `QueueIni` | `szQueueIniPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## Arena\ArenaSkillAdjust.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `KungfuID` | `dwKungfuID` | 整数 | 心法/内功ID | 字段名推断 | 低 |
| 2 | `DynamicBuff` | `szDynamicBuff` | 字符串 | Buff相关配置 | 字段名推断 | 低 |
| 3 | `DisableSkills` | `szDisableSkills` | 字符串 | 技能相关配置 | 字段名推断 | 低 |

## Arena\ArenaVotingPanel.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szDesc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |

## Arena\GuessBonusImage.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `dwGoodID` | `dwGoodID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `nForceID` | `nForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |

## Arena\GuessTeamRank.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `TeamName` | `szTeamName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `dwGlobalID` | `dwGlobalID` | 整数 | 待确认 | 待确认 | 待确认 |

## Arena\MasterBonus.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Rank` | `nRank` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `RankText` | `szRankText` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `Percent` | `fPercent` | 浮点数 | 待确认 | 待确认 | 待确认 |

## Arena\MasterBonusItem.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `LogicID` | `dwLogicID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `dwType` | `dwTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 5 | `nGroupType` | `nGroupType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 6 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |

## arenafightlevel.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `level` | `level` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 2 | `imagefile` | `imagefile` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nframe` | `nframe` | 整数 | 帧号 | 字段名推断 | 低 |
| 4 | `arena award` | `arenaaward` | 整数 | 奖励配置 | 字段名推断 | 低 |
| 5 | `title` | `title` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `desc` | `desc` | 多语言文本 | 描述文本 | 字段名推断 | 低 |
| 7 | `item_desc` | `itemdesc` | 多语言文本 | 道具相关配置 | 翻译列/字段名 | 中 |
| 8 | `score` | `score` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `hlscore` | `hlscore` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `LevelAward` | `levelaward` | 路径 | 奖励配置 | 字段名推断 | 低 |
| 11 | `nNormal` | `normal` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `High` | `high` | 整数 | 待确认 | 待确认 | 待确认 |
| 13 | `GetNormal` | `opennormal` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 14 | `GetHigh` | `openhigh` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 15 | `Award_desc` | `levelawarddesc` | 多语言文本 | 奖励配置 | 翻译列/字段名 | 中 |

## ArenaLiveMap.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 2 | `Path` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `Frame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## ArenaTowerCardList.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `nSkillID` | `nSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 4 | `nSkillLevel` | `nSkillLevel` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 5 | `bCanEnhanced` | `bCanEnhanced` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `nEnhancedSkillID` | `nEnhancedSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 7 | `nEnhancedSkillLevel` | `nEnhancedSkillLevel` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 8 | `bCanFire` | `bCanFire` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 9 | `nFireSkillID` | `nFireSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 10 | `nFireSkillLevel` | `nFireSkillLevel` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 11 | `nEnhancedFireSkillID` | `nEnhancedFireSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 12 | `nEnhancedFireSkillLevel` | `nEnhancedFireSkillLevel` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 13 | `nStar` | `nStar` | 整数 | 待确认 | 待确认 | 待确认 |
| 14 | `bGold` | `bGold` | 布尔 | 待确认 | 待确认 | 待确认 |
| 15 | `bWater` | `bWater` | 布尔 | 待确认 | 待确认 | 待确认 |
| 16 | `bWood` | `bWood` | 布尔 | 待确认 | 待确认 | 待确认 |
| 17 | `bFire` | `bFire` | 布尔 | 待确认 | 待确认 | 待确认 |
| 18 | `bEarth` | `bEarth` | 布尔 | 待确认 | 待确认 | 待确认 |
| 19 | `nTag` | `nTag` | 整数 | 待确认 | 待确认 | 待确认 |
| 20 | `szSpecialWuXing` | `szSpecialWuXing` | 字符串 | 待确认 | 待确认 | 待确认 |
| 21 | `nSpecialTag` | `nSpecialTag` | 整数 | 待确认 | 待确认 | 待确认 |

## ArenaTowerCardSkin.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nWuXing` | `nWuXing` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szImagebg` | `szImagebg` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 3 | `nImgbgFrames` | `nImgbgFrames` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `szImageRightTop` | `szImageRightTop` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 5 | `nImgRightTopFrames` | `nImgRightTopFrames` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `szSmallImageRightTop` | `szSmallImageRightTop` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 7 | `nSmallImgRightTopFrames` | `nSmallImgRightTopFrames` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `szSmallImageLeftbottom` | `szSmallImageLeftbottom` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 9 | `nSmallImgLeftbottomFrames` | `nSmallImgLeftbottomFrames` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 10 | `szOneStarImg` | `szOneStarImg` | 字符串 | 待确认 | 待确认 | 待确认 |
| 11 | `nOneStarFrames` | `nOneStarFrames` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 12 | `szTwoStarImg` | `szTwoStarImg` | 字符串 | 待确认 | 待确认 | 待确认 |
| 13 | `nTwoStarFrames` | `nTwoStarFrames` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 14 | `szThreeStarImg` | `szThreeStarImg` | 字符串 | 待确认 | 待确认 | 待确认 |
| 15 | `nThreeStarFrames` | `nThreeStarFrames` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 16 | `szFourStarImg` | `szFourStarImg` | 字符串 | 待确认 | 待确认 | 待确认 |
| 17 | `nFourStarFrames` | `nFourStarFrames` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 18 | `szAttrIcon` | `szAttrIcon` | 字符串 | 待确认 | 待确认 | 待确认 |
| 19 | `nAttrIconFrames` | `nAttrIconFrames` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 20 | `szSmallImagebg` | `szSmallImagebg` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 21 | `nSmallImgbgFrames` | `nSmallImgbgFrames` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 22 | `szSmallCircleImage` | `szSmallCircleImage` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 23 | `nSmallCircleImageFrames` | `nSmallCircleImageFrames` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 24 | `szSmallMutlAttributeImagebg` | `szSmallMutlAttributeImagebg` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 25 | `nSmallMutlAttributeImgbgFrames` | `nSmallMutlAttributeImgbgFrames` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## ArenaTowerElementInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 字段名推断 | 低 |
| 3 | `szAttributeName1` | `szAttributeName1` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `fBaseValue1` | `fBaseValue1` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 5 | `szAttributeName2` | `szAttributeName2` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `fBaseValue2` | `fBaseValue2` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 7 | `szAttributeName3` | `szAttributeName3` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `fBaseValue3` | `fBaseValue3` | 浮点数 | 待确认 | 待确认 | 待确认 |

## ArenaTowerOtherCardList.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `bGold` | `bGold` | 布尔 | 待确认 | 待确认 | 待确认 |
| 3 | `bWater` | `bWater` | 布尔 | 待确认 | 待确认 | 待确认 |
| 4 | `bWood` | `bWood` | 布尔 | 待确认 | 待确认 | 待确认 |
| 5 | `bFire` | `bFire` | 布尔 | 待确认 | 待确认 | 待确认 |
| 6 | `bEarth` | `bEarth` | 布尔 | 待确认 | 待确认 | 待确认 |
| 7 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 8 | `szDescribe` | `szDescribe` | 字符串 | 待确认 | 待确认 | 待确认 |
| 9 | `nIconID` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 10 | `bWuXing` | `bWuXing` | 布尔 | 待确认 | 待确认 | 待确认 |
| 11 | `bCommonBonus` | `bCommonBonus` | 布尔 | 奖励配置 | 字段名推断 | 低 |

## ArenaTowerRoundList.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `bShopRound` | `bShopRound` | 布尔 | 待确认 | 待确认 | 待确认 |
| 4 | `nAddPrestigeLx` | `nAddPrestigeLx` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `nAddTitlePointLx` | `nAddTitlePointLx` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 6 | `nAddArenaTowerAwardLx` | `nAddArenaTowerAwardLx` | 整数 | 奖励配置 | 字段名推断 | 低 |
| 7 | `szAddItemLx` | `szAddItemLx` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 8 | `nAddPrestigeTz` | `nAddPrestigeTz` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `nAddTitlePointTz` | `nAddTitlePointTz` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `nAddArenaTowerAwardTz` | `nAddArenaTowerAwardTz` | 整数 | 奖励配置 | 字段名推断 | 低 |
| 11 | `szAddItemTz` | `szAddItemTz` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 12 | `szDXImage` | `szDXImage` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 13 | `szNameImg` | `szNameImg` | 字符串 | 待确认 | 待确认 | 待确认 |
| 14 | `nNameImgFrames` | `nNameImgFrames` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## ArtistReward.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szRewardName` | `szRewardName` | 字符串 | 奖励配置 | 翻译列/字段名 | 中 |
| 3 | `nPrice` | `nPrice` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `dwFrame` | `dwFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 5 | `szLinkFrame` | `szLinkFrame` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 6 | `szDescribe` | `szDescribe` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## ArtistSkills.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nTabType` | `nTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `nTabIndex` | `nTabIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 4 | `nSkillID` | `nSkillID` | 整数 | 技能ID | 字段名推断 | 低 |

## ArtistWriteList.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nShowItemID` | `nShowItemID` | 整数 | 道具ID/索引 | 字段名推断 | 低 |

## AssassinationTaskScroll.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `_szComment` | `_szComment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 4 | `szBgImageWithoutWordsPath` | `szBgImageWithoutWordsPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `szBgImageWithWordsPath` | `szBgImageWithWordsPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `szImageTitlePath` | `szImageTitlePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `nImageTitleFrame` | `nImageTitleFrame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 8 | `szText` | `szText` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `szImageSealPath` | `szImageSealPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `nImageSealFrame` | `nImageSealFrame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 11 | `szMobileBgImageWithoutWordsPath` | `szMobileBgImageWithoutWordsPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 12 | `szMobileBgImageWithWordsPath` | `szMobileBgImageWithWordsPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 13 | `szMobileImageTitlePath` | `szMobileImageTitlePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 14 | `szMobileImageSealPath` | `szMobileImageSealPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## AsuraBoss.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwBossID` | `dwBossID` | 整数 | 首领ID | 字段名推断 | 低 |
| 2 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `dwMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 4 | `nLimit` | `nLimit` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `szTip` | `szTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `szDetail` | `szDetail` | 字符串 | 详细说明/详情 | 翻译列/字段名 | 中 |

## AsuraReward.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwTabType` | `dwTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |

## attribute.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `szAttributeName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 2 | `IsNormal` | `bIsNormal` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 3 | `GeneratedBase` | `szGeneratedBase` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `GeneratedMagic` | `szGeneratedMagic` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `PreviewBase` | `szPreviewBase` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `PreviewMagic` | `szPreviewMagic` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `HorseBase` | `szHorseBase` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `HorseMagic` | `szHorseMagic` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `StrengthValue` | `szStrengthValue` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 10 | `IsMobile` | `bIsMobile` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## AttributeToCategory.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `AttributeID` | `AttributeID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 2 | `CategoryTitle` | `CategoryTitle` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |

## AuctionActivity.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ActivityID` | `dwActivityID` | 整数 | 活动ID | 字段名推断 | 低 |
| 2 | `Title` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 3 | `CategoryGood` | `CategoryGood` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 4 | `CategoryEvil` | `CategoryEvil` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 5 | `CategoryNeuter` | `CategoryNeuter` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 6 | `bNeuter` | `bNeuter` | 布尔 | 待确认 | 待确认 | 待确认 |
| 7 | `Tip` | `szTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `BtnTip` | `szBtnTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## AutoCorpsName.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `force_id` | `ForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 2 | `title` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 3 | `pre_title` | `szPreTitle` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## AutoProgressBarInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nTableID` | `nTableID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szIniPath` | `szIniPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `szPath` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nIconFrame` | `nIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## AutoQuestList.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `MapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 3 | `Force` | `nForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 4 | `Camp` | `nCamp` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 5 | `QuestList` | `szQuestList` | 字符串 | 任务相关配置 | 字段名推断 | 低 |

## AutoSearchPriority.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `dwTemplateID` | `dwTemplateID` | 整数 | 待确认 | 待确认 | 待确认 |

## AutoSearchShield.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Type` | `dwType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |

## AwardFurnitureModelInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `FurnitureID` | `dwFurnitureID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nPutType` | `nPutType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `Pos` | `szPos` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `PosMB` | `szPosMB` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `Yaw` | `nYaw` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 6 | `Scale` | `fScale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 7 | `ScaleMB` | `fScaleMB` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 8 | `nDetails` | `nDetails` | 整数 | 详情ID列表 | 字段名推断 | 低 |

## AwardRemind.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Activity` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `TimeRepresent` | `szTimeRepresent` | 多语言文本 | 时间配置 | 翻译列/字段名 | 中 |
| 4 | `Level` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 5 | `Details` | `szDetails` | 多语言文本 | 详情ID列表 | 翻译列/字段名 | 中 |
| 6 | `Award` | `szAward` | 多语言文本 | 奖励配置 | 翻译列/字段名 | 中 |
| 7 | `LinkID` | `szLink` | 多语言文本 | 链接/跳转配置 | 翻译列/字段名 | 中 |
| 8 | `QuestID` | `dwQuestID` | 整数 | 任务ID | 字段名推断 | 低 |

## BaiZhanDbmTab.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` | `nMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` | `nTargetID` | 整数 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` | `nTargetLevel` | 整数 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` | `nTargetType` | 整数 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` | `nActionID` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` | `nAction` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `szSkill` | `szSkill` | 字符串 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nStartTime` | `nStartTime` | 浮点数 | 时间配置 | 字段名推断 | 低 |
| 11 | `nSkillCD` | `nSkillCD` | 浮点数 | 技能相关配置 | 字段名推断 | 低 |
| 12 | `nSkillIconID` | `nSkillIconID` | 整数 | 技能ID | 字段名推断 | 低 |
| 13 | `nColorID` | `nColorID` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 14 | `nNormalPriority` | `nNormalPriority` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 15 | `nAbsolutePriority` | `nAbsolutePriority` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 16 | `bStartTimePause` | `bStartTimePause` | 布尔 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` | `bTimeCeil` | 布尔 | 时间配置 | 字段名推断 | 低 |
| 18 | `tbGroupID` | `tbGroupID` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 19 | `szComment1` | `szComment1` | 字符串 | 待确认 | 待确认 | 待确认 |
| 20 | `szComment2` | `szComment2` | 字符串 | 待确认 | 待确认 | 待确认 |

## BallonShield.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `MapType\|MapID` | `szMapType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 2 | `ShieldLevel` | `nShieldLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |

## battlefield.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `MapId` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 2 | `MapName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `Describe` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 4 | `Group0` | `szGroup1` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 5 | `Group1` | `szGroup2` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 6 | `Group2` | `szGroup3` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 7 | `Group3` | `szGroup4` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 8 | `PQOption0Name` | `szPQOptionName1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `PQOption0Icon` | `nPQOptionIcon1` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `PQOption1Name` | `szPQOptionName2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 11 | `PQOption1Icon` | `nPQOptionIcon2` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `PQOption2Name` | `szPQOptionName3` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 13 | `PQOption2Icon` | `nPQOptionIcon3` | 整数 | 待确认 | 待确认 | 待确认 |
| 14 | `PQOption3Name` | `szPQOptionName4` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 15 | `PQOption3Icon` | `nPQOptionIcon4` | 整数 | 待确认 | 待确认 | 待确认 |
| 16 | `Reward0Icon` | `nRewardIcon1` | 整数 | 奖励配置 | 字段名推断 | 低 |
| 17 | `Reward1Icon` | `nRewardIcon2` | 整数 | 奖励配置 | 字段名推断 | 低 |
| 18 | `Reward2Icon` | `nRewardIcon3` | 整数 | 奖励配置 | 字段名推断 | 低 |
| 19 | `Reward3Icon` | `nRewardIcon4` | 整数 | 奖励配置 | 字段名推断 | 低 |
| 20 | `HelpImage` | `szHelpImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 21 | `HelpText` | `szHelpText` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 22 | `Type` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 23 | `szTypeName` | `szTypeName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 24 | `szActivityID` | `szActivityID` | 字符串 | 活动ID | 字段名推断 | 低 |
| 25 | `szTimeTip` | `szTimeTip` | 字符串 | 时间配置 | 翻译列/字段名 | 中 |
| 26 | `szSubMapID` | `szSubMapID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 27 | `nRoomType` | `nRoomType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 28 | `szMapPath` | `szMapPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 29 | `szMobileMapPath` | `szMobileMapPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 30 | `dwActivityID` | `dwActivityID` | 整数 | 活动ID | 字段名推断 | 低 |
| 31 | `szRewards` | `szRewards` | 字符串 | 奖励配置 | 字段名推断 | 低 |

## BattleField\MOBABattleNonPlayerInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szType` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `_Comment` | `_szComment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `szBigAvatarPath` | `szBigAvatarPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `nBigAvatarFrame` | `nBigAvatarFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `szSmallAvatarPathBlue` | `szSmallAvatarPathBlue` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `nSmallAvatarFrameBlue` | `nSmallAvatarFrameBlue` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 9 | `szSmallAvatarPathRed` | `szSmallAvatarPathRed` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `nSmallAvatarFrameRed` | `nSmallAvatarFrameRed` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## BattleField\MOBABattleVoice.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `szID` | `szID` | 字符串 | ID | 字段名推断 | 低 |
| 2 | `szSoundFilePath` | `szSoundFilePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `_szComment` | `_szComment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## BattleField\TongBattledragonTips.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szAvatarPath` | `szAvatarPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nAvatarFrame` | `nAvatarFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `szMobileAvatarPath` | `szMobileAvatarPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `szAvatarBgPath` | `szAvatarBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `nAvatarBgFrame` | `nAvatarBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `szMobileAvatarBgPath` | `szMobileAvatarBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `szMsgPath` | `szMsgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `nMsgFrame` | `nMsgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 10 | `szMsgBgPath` | `szMsgBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 11 | `nMsgBgFrame` | `nMsgBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 12 | `szMobileMsgBgPath` | `szMobileMsgBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 13 | `szMaleSoundFilePath` | `szMaleSoundFilePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 14 | `szFemaleSoundFilePath` | `szFemaleSoundFilePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 15 | `szBoySoundFilePath` | `szBoySoundFilePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 16 | `szGirlSoundFilePath` | `szGirlSoundFilePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 17 | `szTips` | `szTips` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## BattleField\TongBattleTips.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szUITEXPath` | `szUITEXPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 4 | `szMobileImgBgPath` | `szMobileImgBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `szMaleSoundFilePath` | `szMaleSoundFilePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `szFemaleSoundFilePath` | `szFemaleSoundFilePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `szBoySoundFilePath` | `szBoySoundFilePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `szGirlSoundFilePath` | `szGirlSoundFilePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `szTips` | `szTips` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## battlefielddata.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 3 | `szImage` | `szImage` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 4 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 5 | `szFrame` | `szFrame` | 字符串 | 帧号 | 字段名推断 | 低 |
| 6 | `szTip` | `szTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `bArgTip` | `bArgTip` | 布尔 | 待确认 | 待确认 | 待确认 |
| 8 | `nSubType` | `nSubType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 9 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 10 | `fScale` | `fScale` | 浮点数 | 待确认 | 待确认 | 待确认 |

## battlefieldMapIcon.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `MapId` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `RedPath` | `szRedPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `RedFrame` | `nRedFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `BluePath` | `szBluePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `BlueFrame` | `nBlueFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## BattleFieldRecord.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `bDps` | `bDPS` | 布尔 | 待确认 | 待确认 | 待确认 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `szKey` | `szKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `szRoleKey` | `szRoleKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 6 | `szPath` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## BattleMarkState.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Path` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `Frame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 4 | `Tip` | `szTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `bArgTip` | `bArgTip` | 布尔 | 待确认 | 待确认 | 待确认 |
| 6 | `Scale` | `fScale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 7 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 8 | `szMobileImage` | `szMobileImage` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 9 | `MobileScale` | `fMobileScale` | 浮点数 | 待确认 | 待确认 | 待确认 |

## BFArenaEvent.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `TabID` | `szTabsID` | 字符串 | 待确认 | 待确认 | 待确认 |

## BFArenaExcellent.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szImage` | `szImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 5 | `szIconImage` | `szIconImage` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 6 | `nIconFrame` | `nIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `nIndex（位置，越小越中间）` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 8 | `szTip` | `szTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `bAscending（是否升序）` | `bAscending` | 布尔 | 待确认 | 待确认 | 待确认 |
| 10 | `OneValue（一个变量排序）` | `szOneValue` | 字符串 | 待确认 | 待确认 | 待确认 |
| 11 | `Formula（公式排序）` | `szFormula` | 字符串 | 待确认 | 待确认 | 待确认 |
| 12 | `Value1` | `szValue1` | 字符串 | 待确认 | 待确认 | 待确认 |
| 13 | `Value2` | `szValue2` | 字符串 | 待确认 | 待确认 | 待确认 |
| 14 | `Value3` | `szValue3` | 字符串 | 待确认 | 待确认 | 待确认 |
| 15 | `szMobileImage` | `szMobileImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |

## BGMState.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `BuffID` | `nBuffID` | 整数 | Buff ID | 字段名推断 | 低 |
| 3 | `BuffLevel` | `nBuffLevel` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 4 | `HaveBuff` | `bHaveBuff` | 布尔 | Buff相关配置 | 字段名推断 | 低 |
| 5 | `bFightState` | `nFightState` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `QuestID` | `dwQuestID` | 整数 | 任务ID | 字段名推断 | 低 |
| 7 | `QuestSate` | `nQuestState` | 整数 | 任务相关配置 | 字段名推断 | 低 |
| 8 | `MinHealthPct` | `fMinHealthPct` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 9 | `MaxHealthPct` | `fMaxHealthPct` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 10 | `MapID` | `szMapList` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 11 | `OriginalBGM` | `szOriginalBGM` | 字符串 | 待确认 | 待确认 | 待确认 |
| 12 | `ReplaceBGM` | `szReplaceBGM` | 字符串 | 待确认 | 待确认 | 待确认 |
| 13 | `StackingBGM` | `szStackingBGM` | 字符串 | 待确认 | 待确认 | 待确认 |
| 14 | `StackingState` | `szStackingState` | 字符串 | 待确认 | 待确认 | 待确认 |
| 15 | `StackingStopState` | `szStackingStopState` | 字符串 | 待确认 | 待确认 | 待确认 |
| 16 | `Priority` | `nPriority` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 17 | `SoundType` | `szSoundType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 18 | `Sound` | `szSound` | 字符串 | 音效 | 字段名推断 | 低 |

## BigBagFilterSetting.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nClass` | `nClass` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `nSub` | `nSub` | 整数 | 二级分类/子类ID | 字段名推断 | 低 |
| 3 | `szClassName` | `szClassName` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 4 | `szSubName` | `szSubName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `nFilterTag` | `nFilterTag` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `nNormalFrame` | `nNormalFrame` | 整数 | 普通状态帧号 | 字段名推断 | 低 |
| 7 | `nSelFrame` | `nSelFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `nDisableFrame` | `nDisableFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## BirthdayCardInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nYear` | `nYear` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szContent` | `szContent` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 3 | `szContentImgPath` | `szContentImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `szCoverSfxPath` | `szCoverSfxPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `szOpenSfxPath` | `szOpenSfxPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `szMBContentImgPath` | `szMBContentImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `szMBCoverSfxPath` | `szMBCoverSfxPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `szMBOpenSfxPath` | `szMBOpenSfxPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## BossDbm\BossDbmMap298.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `10人辉天` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap299.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `靳孔明开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap341.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `10人荒血路康疑开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap347.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `10人冰火岛青莲狱伊玛目开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap364.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `10人普通尘归海巨冥湾1号孙楚珊开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap368.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `10人尘归海·饕餮洞黄穆开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap426.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `铁黎开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap452.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `周贽 开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap482.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `余晖开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap518.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `罗芬开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap559.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `巨型尖吻凤开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap562.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `百战异闻录1阶钱南撰进战标识` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap573.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `勒齐那开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap586.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `张景超开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap587.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `张景超开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap588.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `张景超开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap597.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `沃石院-孟承开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap599.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `英雄地井开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap607.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `5人英雄幽藤馆吴添明开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap623.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `英雄江天夜宴开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap636.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `时风开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap637.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `时风开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap638.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `时风开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap639.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `鹿桥驿-骨面天君开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap648.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `魏华开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap649.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `魏华开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap650.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `魏华开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap659.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `5人英雄栖灵洞天辛仕徽开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap668.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `10人赤幽明开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap669.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `25人普通赤幽明开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap670.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `25人葛木寒开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap682.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `5人普通天龙寺枯荣大师开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap683.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `5人英雄天龙寺枯荣大师开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap684.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `5人普通冰川宫宝库甄三笔开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap685.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `5人英雄冰川宫宝库甄三笔开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap686.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `10人一之窟伍靖远开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap687.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `25人普通骆耀阳开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap688.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `骆耀阳英雄暂停` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap690.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `普通风砂旧垒刘重开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap691.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `英雄风砂旧垒刘重开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap693.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `普通不染窟1号开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap694.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `普通不染窟1号开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap706.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `10人太极宫邢廷恩开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap707.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `25人普通太极宫邢廷恩开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap708.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `25人英雄太极宫邢廷恩开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap710.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `25人挑战空城殿池清川开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap720.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `25人挑战阿里曼幻身开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap722.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `10人【会战弓月城】【巴图仁钦】开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap723.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `25人普通【会战弓月城】【巴图仁钦】开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap724.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `25人英雄【会战弓月城】【巴图仁钦】开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap726.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `5人英雄獭山岛石固勇开战` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap793.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `10人唐醉` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap794.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `25人普通唐醉` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossDbm\BossDbmMap795.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 4 | `nTargetID` |  | 未知 | 目标ID | 字段名推断 | 低 |
| 5 | `nTargetLevel` |  | 未知 | 目标等级 | 字段名推断 | 低 |
| 6 | `nTargetType` |  | 未知 | 目标类型 | 字段名推断 | 低 |
| 7 | `nActionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nAction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `tbSkill` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `nProtectTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 11 | `nKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nClearKey` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nClearType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nAddTimekey` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 15 | `nTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 16 | `nStopTimer` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 17 | `bTimeCeil` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 18 | `bIsBoss` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `25人英雄唐醉` |  | 未知 | 待确认 | 待确认 | 待确认 |

## BossFocusBuff.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nBuffID` | `nBuffID` | 整数 | Buff ID | 字段名推断 | 低 |
| 3 | `nBuffLevel` | `nBuffLevel` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 4 | `nBuffStack` | `nBuffStack` | 整数 | Buff相关配置 | 字段名推断 | 低 |

## boxinfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `TITLE` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 3 | `DESC` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |

## bp_skill_school_kungfu.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ForceID` | `dwSchoolID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `KungFuID` | `szKungfu` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `SortID` | `dwSortID` | 整数 | 索引/排序 | 字段名推断 | 低 |

## BranchName.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ProfessionID` | `dwProfessionID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `BranchID` | `dwBranchID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |

## BrightMarkIcon.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nPageID` | `nPageID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `nIconID` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 4 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 5 | `szColorfulName` | `szColorfulName` | 多语言文本 | 颜色配置 | 翻译列/字段名 | 中 |
| 6 | `szDesc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 7 | `bShow` | `bShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 8 | `szItemIndex` | `szItemIndex` | 字符串 | 道具索引 | 字段名推断 | 低 |

## BrightMarkTitle.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nPageid` | `nPageID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `bShow` | `bShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## buff.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `BuffID` | `dwBuffID` | 整数 | Buff ID | 字段名推断 | 低 |
| 2 | `Level` | `dwLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `IconID` | `dwIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 4 | `Sparking` | `bSparking` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `ShowTime` | `bShowTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 6 | `Show` | `bShow` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 7 | `Remark` | `szRemark` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 9 | `Desc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 10 | `IsAddPeriod` | `bAutoAddPeriod` | 布尔 | 待确认 | 待确认 | 待确认 |
| 11 | `TypeIconID` | `nCatalog` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `MbSpecialShow` | `bMbSpecialShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 13 | `MbSpecialShowPriority` | `nMbSpecialShowPriority` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 14 | `MbCantRebirth` | `bMbCantRebirth` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 15 | `MbIsShow` | `bMbIsShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 16 | `bCollapse` | `bCollapse` | 布尔 | 待确认 | 待确认 | 待确认 |
| 17 | `nMbUIListPriority` | `nMbUIListPriority` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 18 | `nUIBuffType` | `nUIBuffType` | 整数 | Buff相关配置 | 字段名推断 | 低 |

## buff_represent.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `RepresentID` | `dwRepresentID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `Action` | `bAction` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `SkinRepresentID` | `sSkinRepresent` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `Desc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |

## BuffClickEvent.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `szEvent` | `szEvent` | 字符串 | 待确认 | 待确认 | 待确认 |

## BuffMonitor.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nBuffID1` | `dwBuffID1` | 整数 | Buff ID | 字段名推断 | 低 |
| 3 | `nBuffIconID1` | `dwBuffIconID1` | 整数 | Buff ID | 字段名推断 | 低 |
| 4 | `nBuffID2` | `dwBuffID2` | 整数 | Buff ID | 字段名推断 | 低 |
| 5 | `nBuffIconID2` | `dwBuffIconID2` | 整数 | Buff ID | 字段名推断 | 低 |
| 6 | `nBuffID3` | `dwBuffID3` | 整数 | Buff ID | 字段名推断 | 低 |
| 7 | `nBuffIconID3` | `dwBuffIconID3` | 整数 | Buff ID | 字段名推断 | 低 |

## BuffMonitorBuffSkin.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwBuffID` | `dwBuffID` | 整数 | Buff ID | 字段名推断 | 低 |
| 2 | `szProgressPath` | `szProgressPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `szProgressPath` | `szProgressBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `szBuffIcon1` | `szBuffIcon1` | 路径 | Buff相关配置 | 字段名推断 | 低 |
| 5 | `szBuffIcon2` | `szBuffIcon2` | 路径 | Buff相关配置 | 字段名推断 | 低 |
| 6 | `szBuffIcon3` | `szBuffIcon3` | 路径 | Buff相关配置 | 字段名推断 | 低 |
| 7 | `szBuffIcon4` | `szBuffIcon4` | 路径 | Buff相关配置 | 字段名推断 | 低 |
| 8 | `nShowIconState` | `nShowIconState` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 9 | `bUseLevel` | `bUseLevel` | 布尔 | 等级/品质 | 字段名推断 | 低 |

## BuffMonitorForce.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwKungfuType` | `dwKungfuType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `dwBuffID` | `dwBuffID` | 整数 | Buff ID | 字段名推断 | 低 |
| 3 | `skillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 4 | `MaxNum` | `nMaxNum` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 5 | `MaxLevel` | `nMaxLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 6 | `IniName` | `szIniName` | 未知(R) | 待确认 | 待确认 | 待确认 |
| 7 | `ModName` | `szSuffix` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |

## BuffMonitorForceSkin.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwMKungfuID` | `dwMKungfuID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szImageTitlePath` | `szImageTitlePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `szImageBgPath` | `szImageBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## BuffSkill.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nBuffID` | `nBuffID` | 整数 | Buff ID | 字段名推断 | 低 |
| 2 | `nBuffLevel` | `nBuffLevel` | 整数 | Buff相关配置 | 字段名推断 | 低 |

## ButlerNpcInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szAvatarPath` | `szAvatarPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 4 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 5 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 6 | `nColorFrame` | `nColorFrame` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 7 | `nMaxLevel` | `nMaxLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 8 | `nSkillID1` | `nSkillID1` | 整数 | 技能ID | 字段名推断 | 低 |
| 9 | `nSkillID2` | `nSkillID2` | 整数 | 技能ID | 字段名推断 | 低 |
| 10 | `nSkillID3` | `nSkillID3` | 整数 | 技能ID | 字段名推断 | 低 |
| 11 | `nSkillID4` | `nSkillID4` | 整数 | 技能ID | 字段名推断 | 低 |
| 12 | `szSkill1Tip` | `szSkill1Tip` | 字符串 | 技能相关配置 | 翻译列/字段名 | 中 |
| 13 | `szSkill2Tip` | `szSkill2Tip` | 字符串 | 技能相关配置 | 翻译列/字段名 | 中 |
| 14 | `szSkill3Tip` | `szSkill3Tip` | 字符串 | 技能相关配置 | 字段名推断 | 低 |
| 15 | `szSkill4Tip` | `szSkill4Tip` | 字符串 | 技能相关配置 | 字段名推断 | 低 |
| 16 | `szAttribute1` | `szAttribute1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 17 | `szAttribute2` | `szAttribute2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 18 | `szAttribute3` | `szAttribute3` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 19 | `szAttribute4` | `szAttribute4` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 20 | `szAttribute5` | `szAttribute5` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 21 | `szAttribute6` | `szAttribute6` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 22 | `szAttribute7` | `szAttribute7` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 23 | `nAttribute1IconFrame` | `nAttribute1IconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 24 | `nAttribute2IconFrame` | `nAttribute2IconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 25 | `nAttribute3IconFrame` | `nAttribute3IconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 26 | `nAttribute4IconFrame` | `nAttribute4IconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 27 | `nAttribute5IconFrame` | `nAttribute5IconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 28 | `nAttribute6IconFrame` | `nAttribute6IconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 29 | `nAttribute7IconFrame` | `nAttribute7IconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## CampAuctionInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nItemType` | `nItemType` | 整数 | 道具类型 | 字段名推断 | 低 |
| 2 | `nItemIndex` | `nItemIndex` | 整数 | 道具索引 | 字段名推断 | 低 |
| 3 | `nRareness` | `nRareness` | 整数 | 待确认 | 待确认 | 待确认 |

## CampBossDetail.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `nCamp` | `nCamp` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 4 | `nClass` | `nClass` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 5 | `szDesc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 6 | `dwModelID` | `dwModelID` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `fModelScale` | `fModelScale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 8 | `fModelScaleMB` | `fModelScaleMB` | 浮点数 | 待确认 | 待确认 | 待确认 |

## CampBossInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nCamp` | `nCamp` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 3 | `szBossName` | `szBossName` | 字符串 | 首领名称 | 翻译列/字段名 | 中 |
| 4 | `szBossUITex` | `szBossUITex` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `nBossFrame` | `nBossFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `szMobileBossIcon` | `szMobileBossIcon` | 字符串 | 待确认 | 待确认 | 待确认 |

## CampMapsYinShan.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CampSkill.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nCamp` | `nCamp` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 2 | `dwSkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 3 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 4 | `nTotalCDTime` | `nTotalTime` | 整数 | 时间配置 | 字段名推断 | 低 |

## CaptionIconToTitleEffect.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `CaptionIconType` | `nCaptionIconType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `EffectID` | `dwEffectID` | 整数 | 待确认 | 待确认 | 待确认 |

## CastleImg.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szPath` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## CastleInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `CastleID` | `dwCastleID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `MapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 4 | `Index` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 5 | `CastleName` | `szCastleName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `AchievementName` | `szAchievement` | 字符串 | 成就相关配置 | 翻译列/字段名 | 中 |
| 7 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 8 | `nDefance` | `nDefance` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `szAreaName` | `szAreaName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## CDMonitorForce.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwKungfuType` | `dwKungfuType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `dwCDID` | `dwCDID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `dwSkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 4 | `bTop` | `bTop` | 布尔 | 顶部坐标/上边距 | 字段名推断 | 低 |

## CGList.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Desc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 3 | `BgPath(按钮背景图路径)` | `szBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `Normal` | `nNormalFrame` | 整数 | 普通状态帧号 | 字段名推断 | 低 |
| 5 | `Highlight（高亮帧）` | `nHightLightFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `Disable（不可用帧）` | `nDisableFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `CGPath（CG文件存放位置）` | `szCGPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `DowloadUrl（CG下载网址）` | `szDowloadUrl` | 路径 | 链接/跳转配置 | 字段名推断 | 低 |

## Challenge.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 3 | `dwFrameIcon` | `dwFrameIcon` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## ChannelInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `szDescription` | `szDescription` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |

## Channels.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ForceID` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 2 | `KungFuID` | `dwKungFuID` | 整数 | 心法/内功ID | 字段名推断 | 低 |
| 3 | `LowLevelPath` | `dwLowLevelPath` | 整数 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `MaxLevelPath` | `szMaxLevelPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |

## Channels_Recommend.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `PathID` | `dwPathID` | 整数 | 资源/文件路径 | 字段名推断 | 低 |
| 2 | `PathName` | `szPathName` | 多语言文本 | 资源/文件路径 | 翻译列/字段名 | 中 |
| 3 | `RecommendList` | `szRecommendList` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 4 | `ImportantKey` | `szImporantKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |

## Chapters.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwChapterID` | 整数 | 章节ID | 字段名推断 | 低 |
| 2 | `PathTitle` | `szTitlePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `PathContent` | `szContentPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `Note` | `szNote` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `Sound` | `szSound` | 路径 | 音效 | 字段名推断 | 低 |
| 6 | `MobilePathTitle` | `szMobilePathTitle` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `ShowStamp` | `bShowStamp` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 8 | `MobileTitle` | `szMobileTitle` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## CharacterPanelAwardTip.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## CharacterPanelExplainTip.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## Charge.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nActivityID` | `nActivityID` | 整数 | 活动ID | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 5 | `szCondition` | `szCondition` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `dwNameFrame` | `dwNameFrame` | 整数 | 名称图片帧号 | 字段名推断 | 低 |
| 7 | `szNameFrame` | `szNameFrame` | 字符串 | 名称图片帧号 | 字段名推断 | 低 |
| 8 | `dwIconFrame` | `dwIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 9 | `szImageFrame` | `szImageFrame` | 字符串 | 图片资源配置 | 字段名推断 | 低 |

## CharInfoAttack.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `KungfuID` | `dwMountKungfu` | 整数 | 当前心法/内功ID | 字段名推断 | 低 |
| 2 | `Physics1` | `bShowPhysics1` | 布尔 | 是否显示外功属性1 | 字段名推断 | 低 |
| 3 | `Physics2` | `bShowPhysics2` | 布尔 | 是否显示外功属性2 | 字段名推断 | 低 |
| 4 | `Solar1` | `bShowSolar1` | 布尔 | 是否显示阳性属性1 | 字段名推断 | 低 |
| 5 | `Solar2` | `bShowSolar2` | 布尔 | 是否显示阳性属性2 | 字段名推断 | 低 |
| 6 | `Neutral1` | `bShowNeutral1` | 布尔 | 是否显示混元属性1 | 字段名推断 | 低 |
| 7 | `Neutral2` | `bShowNeutral2` | 布尔 | 是否显示混元属性2 | 字段名推断 | 低 |
| 8 | `Lunar1` | `bShowLunar1` | 布尔 | 是否显示阴性属性1 | 字段名推断 | 低 |
| 9 | `Lunar2` | `bShowLunar2` | 布尔 | 是否显示阴性属性2 | 字段名推断 | 低 |
| 10 | `Poison1` | `bShowPoison1` | 布尔 | 是否显示毒性属性1 | 字段名推断 | 低 |
| 11 | `Poison2` | `bShowPoison2` | 布尔 | 是否显示毒性属性2 | 字段名推断 | 低 |
| 12 | `Therapy` | `bShowTherapy` | 布尔 | 是否显示治疗属性 | 字段名推断 | 低 |
| 13 | `TherapyMainly` | `bTherapyMainly` | 布尔 | 是否治疗为主 | 字段名推断 | 低 |

## CharInfoMainAttrShow.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `KungfuID` | `dwMountKungfu` | 整数 | 当前心法/内功ID | 字段名推断 | 低 |
| 2 | `Vitality` | `bVitality` | 布尔 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 3 | `Spirit` | `bSpirit` | 布尔 | 待确认 | 待确认 | 待确认 |
| 4 | `Strength` | `bStrength` | 布尔 | 待确认 | 待确认 | 待确认 |
| 5 | `Agility` | `bAgility` | 布尔 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 6 | `Spunk` | `bSpunk` | 布尔 | 待确认 | 待确认 | 待确认 |

## ChooseStep.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Step` | `dwStep` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `StepsName` | `szStepsName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `TopImagePath` | `szStepImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `TopFrame` | `nStepFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## CmdHistoryData.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwIndex` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `szName` | `nFrame` | 整数 | 帧号 | 翻译列/字段名 | 中 |
| 4 | `nCamp` |  | 未知 | 势力/阵营配置 | 字段名推断 | 低 |
| 5 | `szTips` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `szPath` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `nFrame` |  | 未知 | 帧号 | 字段名推断 | 低 |

## CoinShopHome\CoinShop_Home.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `GoodsType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `GoodsID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `dwForceID` |  | 未知 | 势力/阵营配置 | 字段名推断 | 低 |
| 5 | `bShow` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `bSet` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 7 | `szName` |  | 未知 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 8 | `Imagef1` |  | 未知 | 图片资源配置 | 字段名推断 | 低 |
| 9 | `Imagef2` |  | 未知 | 图片资源配置 | 字段名推断 | 低 |
| 10 | `Imagem1` |  | 未知 | 图片资源配置 | 字段名推断 | 低 |
| 11 | `Imagem2` |  | 未知 | 图片资源配置 | 字段名推断 | 低 |
| 12 | `szLink` |  | 未知 | 链接/跳转配置 | 字段名推断 | 低 |
| 13 | `FoldID` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CoinShopHome\CoinShop_News.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Image` |  | 未知 | 图片资源配置 | 字段名推断 | 低 |
| 3 | `Link` |  | 未知 | 链接/跳转配置 | 字段名推断 | 低 |
| 4 | `StartTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 5 | `EndTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 6 | `EndActiveOpenTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 7 | `Mode` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nRoleType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |

## CoinShopHome\CoinShopHome_Fold.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nFoldID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `szFoldName` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ImagePath` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |

## CoinShopHome\CoinShopMix_f1.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Name` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `GoodType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `LogicID` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CoinShopHome\CoinShopMix_f2.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Name` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `GoodType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `LogicID` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CoinShopHome\CoinShopMix_m1.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Name` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `GoodType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `LogicID` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CoinShopHome\CoinShopMix_m2.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Name` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `GoodType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `LogicID` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CoinShopHome\FaceliftIndex.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `FilePath` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |

## CoinShopHome\GrouponTemplateName.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szTemplateName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `Path` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `Frame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## CoinShopHome\Rank.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Class` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 2 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 3 | `MixID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Name` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `Image` |  | 未知 | 图片资源配置 | 字段名推断 | 低 |
| 6 | `StartTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 7 | `EndTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |

## Collection\CollectionBoxInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `nDLCIndex` | `nDLCIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 4 | `nQuality` | `nQuality` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 5 | `dwTabType` | `dwTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 6 | `dwItemIndex` | `dwItemIndex` | 整数 | 道具索引 | 字段名推断 | 低 |
| 7 | `szSmallIconPath` | `szSmallIconPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `nIconFrame` | `nIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 9 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 11 | `szGainWay` | `szGainWay` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |

## Collection\CollectionColorInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nColorID` | `nColorID` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 2 | `szColorName` | `szColorName` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 3 | `r` | `nR` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `g` | `nG` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `b` | `nB` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `szTextureName` | `szTextureName` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 7 | `szTexImgPath` | `szTexImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `nTexFrame` | `nTexFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## Collection\CollectionDLCInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `szRuleText` | `szRuleText` | 多语言文本 | 文本内容 | 字段名推断 | 低 |
| 4 | `szWaistPreviewPath` | `szWaistPreviewPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `nWaistPreviewFrame` | `nWaistPreviewFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `szBackPreviewPath` | `szBackPreviewPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `nBackPreviewFrame` | `nBackPreviewFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `szBoxList` | `szBoxList` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |

## Collection\CollectionFilterInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `szTypeName` | `szTypeName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |

## Collection\CollectionOrangePendantInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `nDLCIndex` | `nDLCIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `dwItemIndex` | `dwItemIndex` | 整数 | 道具索引 | 字段名推断 | 低 |
| 4 | `dwCounterID` | `dwCounterID` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 5 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 6 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 8 | `nWornLevel` | `nWornLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 9 | `uTPos1` | `uTPos1` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 10 | `uColor1` | `uColor1` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 11 | `uTID1` | `uTID1` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `uTPos2` | `uTPos2` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `uColor2` | `uColor2` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 14 | `uTID2` | `uTID2` | 整数 | 待确认 | 待确认 | 待确认 |
| 15 | `uTPos3` | `uTPos3` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 16 | `uColor3` | `uColor3` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 17 | `uTID3` | `uTID3` | 整数 | 待确认 | 待确认 | 待确认 |

## Collection\CollectionPendantInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `dwItemIndex` | `dwItemIndex` | 整数 | 道具索引 | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 4 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 5 | `dwRepresentID` | `dwRepresentID` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `nDLCIndex` | `nDLCIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 7 | `nBelongBox` | `nBelongBox` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 8 | `bLimit` | `bLimit` | 布尔 | 待确认 | 待确认 | 待确认 |
| 9 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 10 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 11 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 12 | `szPartName1` | `szPartName1` | 字符串 | 待确认 | 待确认 | 待确认 |
| 13 | `szPartName2` | `szPartName2` | 字符串 | 待确认 | 待确认 | 待确认 |
| 14 | `szPartName3` | `szPartName3` | 字符串 | 待确认 | 待确认 | 待确认 |
| 15 | `bRepeatPhysics` | `bRepeatPhysics` | 布尔 | 待确认 | 待确认 | 待确认 |
| 16 | `fSfxDelayTime` | `fSfxDelayTime` | 浮点数 | 时间配置 | 字段名推断 | 低 |
| 17 | `bOrthogonal` | `bOrthogonal` | 布尔 | 待确认 | 待确认 | 待确认 |
| 18 | `fScale` | `fScale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 19 | `szCamera` | `szCamera` | 字符串 | 待确认 | 待确认 | 待确认 |

## ColorDiamond.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ItemID` | `dwItemID` | 整数 | 道具ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `EnchantID` | `nEnchantID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `Attribute1` | `szAttribute1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `Attribute2` | `szAttribute2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `Attribute3` | `szAttribute3` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## combattextpoint.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nX` | `nX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `nY` | `nY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `fScale` | `fScale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 6 | `PosType` | `PosType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 7 | `nAlpha` | `nAlpha` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `nRed` | `nRed` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `nGreen` | `nGreen` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `nBlue` | `nBlue` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `fParam1` | `fParam1` | 浮点数 | 脚本/参数配置 | 字段名推断 | 低 |
| 12 | `fParam2` | `fParam2` | 浮点数 | 脚本/参数配置 | 字段名推断 | 低 |
| 13 | `fParam3` | `fParam3` | 浮点数 | 脚本/参数配置 | 字段名推断 | 低 |

## combattextspecialskill.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `SkillID` | `nSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 2 | `SpecialColor` | `SpecialColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |

## combattexttrack.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 3 | `szPointList` | `szPointList` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 4 | `nRoute` | `nRoute` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `bCriticalStrike` | `bCriticalStrike` | 布尔 | 待确认 | 待确认 | 待确认 |
| 6 | `nSelf` | `nSelf` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `nOther` | `nOther` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `nDamagePhysics` | `nDamagePhysics` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `nDamageSolarMagic` | `nDamageSolarMagic` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `nDamageNeutralMagic` | `nDamageNeutralMagic` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `nDamageLunarMagic` | `nDamageLunarMagic` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `nDamagePosion` | `nDamagePosion` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nDamageReflectied` | `nDamageReflectied` | 整数 | 待确认 | 待确认 | 待确认 |
| 14 | `nDamageTherapy` | `nDamageTherapy` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 15 | `nDamageStealLife` | `nDamageStealLife` | 整数 | 待确认 | 待确认 | 待确认 |
| 16 | `nDamageAbsorb` | `nDamageAbsorb` | 整数 | 待确认 | 待确认 | 待确认 |
| 17 | `nDamageShield` | `nDamageShield` | 整数 | 待确认 | 待确认 | 待确认 |
| 18 | `nDamageParry` | `nDamageParry` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 19 | `nDamageInsight` | `nDamageInsight` | 整数 | 待确认 | 待确认 | 待确认 |
| 20 | `nStateText` | `nStateText` | 整数 | 文本内容 | 字段名推断 | 低 |
| 21 | `nBuff` | `nBuff` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 22 | `nDeBuff` | `nDeBuff` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 23 | `nSkillMiss` | `nSkillMiss` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 24 | `nSkillDodge` | `nSkillDodge` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 25 | `nBuffImmunity` | `nBuffImmunity` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 26 | `nExp` | `nExp` | 整数 | 待确认 | 待确认 | 待确认 |
| 27 | `nActivityAward` | `nActivityAward` | 整数 | 奖励配置 | 字段名推断 | 低 |
| 28 | `DamagePhysicsColor` | `DamagePhysicsColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 29 | `DamageSolarMagicColor` | `DamageSolarMagicColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 30 | `DamageNeutralMagicColor` | `DamageNeutralMagicColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 31 | `DamageLunarMagicColor` | `DamageLunarMagicColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 32 | `DamagePosionColor` | `DamagePosionColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 33 | `DamageReflectiedColor` | `DamageReflectiedColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 34 | `DamageTherapyColor` | `DamageTherapyColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 35 | `DamageStealLifeColor` | `DamageStealLifeColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 36 | `DamageAbsorbColor` | `DamageAbsorbColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 37 | `DamageShieldColor` | `DamageShieldColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 38 | `DamageParryColor` | `DamageParryColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 39 | `DamageInsightColor` | `DamageInsightColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 40 | `StateTextColor` | `StateTextColor` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 41 | `BuffColor` | `BuffColor` | 字符串 | Buff相关配置 | 字段名推断 | 低 |
| 42 | `DeBuffColor` | `DeBuffColor` | 字符串 | Buff相关配置 | 字段名推断 | 低 |
| 43 | `SkillMissColor` | `SkillMissColor` | 字符串 | 技能相关配置 | 字段名推断 | 低 |
| 44 | `SkillDodgeColor` | `SkillDodgeColor` | 字符串 | 技能相关配置 | 字段名推断 | 低 |
| 45 | `BuffImmunityColor` | `BuffImmunityColor` | 字符串 | Buff相关配置 | 字段名推断 | 低 |
| 46 | `ExpColor` | `ExpColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 47 | `ActivityAward` | `ActivityAwardColor` | 字符串 | 奖励配置 | 字段名推断 | 低 |

## common.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `id` | `type` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `key` | `szKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 3 | `script` | `szScript` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |

## CommonEnchant.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `enchant_id` | `enchant_id` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `desc` | `desc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |

## ConflatePanel.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nSetID` | `nSetID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 3 | `nConflateCount` | `nConflateCount` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 4 | `szBgPath` | `szBgPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `nBgFrame` | `nBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `szConflate1Info` | `szConflate1Info` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `szConflate2Info` | `szConflate2Info` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `szConflate3Info` | `szConflate3Info` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `szConflate4Info` | `szConflate4Info` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 10 | `szConflate5Info` | `szConflate5Info` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 11 | `szConflate6Info` | `szConflate6Info` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 12 | `szConflate7Info` | `szConflate7Info` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 13 | `szConflate8Info` | `szConflate8Info` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 14 | `nGetNewID` | `nGetNewID` | 整数 | 待确认 | 待确认 | 待确认 |

## Contents.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `id` | `dwPageID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `content` | `szContent` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## CountDown.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `szTitlePath` | `szTitlePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nTitleFrame` | `nTitleFrame` | 字符串 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `szImagePath` | `szImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `szAnchorS` | `szAnchorS` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `szAnchorR` | `szAnchorR` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `nOffsetX` | `nOffsetX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 9 | `nOffsetY` | `nOffsetY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 10 | `nSizeX` | `nSizeX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 11 | `nSizeY` | `nSizeY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |

## craft.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ProfessionID` | `dwProfessionID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `CraftID` | `dwCraftID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `MasterID` | `dwMasterID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `IconID` | `dwIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 5 | `Order` | `dwOrder` | 整数 | 文本内容 | 字段名推断 | 低 |
| 6 | `ImagePath` | `szImageFile` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `NameFrame` | `nNameFrame` | 整数 | 名称图片帧号 | 字段名推断 | 低 |
| 8 | `NameDisableFrame` | `nNameDisableFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 9 | `IconNormal` | `nIconNormal` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `IconOver` | `nIconOver` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `IconClick` | `nIconClick` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `IconDisable` | `nIconDisable` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 13 | `Type` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 14 | `RelateProfessionID` | `dwRelateProfessionID` | 整数 | 待确认 | 待确认 | 待确认 |
| 15 | `RelateCraftID` | `dwRelateCraftID` | 整数 | 待确认 | 待确认 | 待确认 |
| 16 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 17 | `ReceipePanelBg` | `ReceipePanelBg` | 路径 | 待确认 | 待确认 | 待确认 |
| 18 | `Desc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |

## CraftBelongName.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ProfessionID` | `dwProfessionID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `BelongID` | `dwBelongID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `BelongName` | `szBelongName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## CraftEnchant.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ProfessionID` | `dwProfessionID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `CraftID` | `dwCraftID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `RecipeID` | `dwRecipeID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `IconID` | `dwIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 5 | `Quality` | `nQuality` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 6 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 7 | `Desc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |

## CraftGuide\CraftDoodad.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` | `dwTemplateID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nCraftID` | `nCraftID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `nTemplateType` | `nTemplateType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 5 | `dwMapID1` | `dwMapID1` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `dwMapID2` | `dwMapID2` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `dwMapID3` | `dwMapID3` | 整数 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_10.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_100.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_101.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_102.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_103.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_104.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_105.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_108.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_11.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_12.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_122.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_13.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_139.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_14.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_15.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_150.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_151.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_153.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_156.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_158.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_159.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_16.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_17.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_18.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_19.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_193.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_194.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_2.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_20.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_21.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_213.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_214.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_215.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_216.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_217.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_22.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_23.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_239.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_243.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_25.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_26.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_27.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_283.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_286.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_30.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_325.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_330.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_332.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_333.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_334.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_35.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_36.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_37.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_40.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_41.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_411.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_419.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_43.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_444.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_45.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_455.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_462.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_464.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_471.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_473.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_474.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_475.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_486.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_488.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_49.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_5.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_51.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_525.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_526.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_578.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_579.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_580.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_581.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_582.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_6.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_642.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_647.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_666.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_673.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_674.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_7.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_713.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_718.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_8.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftMapGuide_9.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `bNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |

## CraftGuide\CraftNpc.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTemplateID` | `dwTemplateID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nCraftID` | `nCraftID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `nTemplateType` | `nTemplateType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 5 | `dwMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |

## craftHole.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Index` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `HoleMask` | `dwHoleMask` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `IconID` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |

## CraftIntroduce.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `id` | `id` | 整数 | ID | 字段名推断 | 低 |
| 2 | `name` | `name` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `type` | `type` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `type_name` | `type_name` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 5 | `icon_path` | `icon_path` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `icon_frame` | `icon_frame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `image_bg` | `image_bg` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 8 | `image_bg_frame` | `image_bg_frame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 9 | `image_title` | `image_title` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 10 | `image_title_frame` | `image_title_frame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 11 | `image_type` | `image_type` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 12 | `image_type_frame` | `image_type_frame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 13 | `product_image_path` | `product_image_path` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 14 | `product_image_frames` | `product_image_frames` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 15 | `product_names` | `product_names` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 16 | `product_descs` | `product_descs` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 17 | `desc` | `desc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |

## createrole_param.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `SchoolType` | `szSchoolType` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 2 | `KungfuIndex` | `dwKungfuIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `ForceID` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 4 | `WeaponType` | `szWeaponType` | 字符串 | WEAPON_DETAIL.XXX | 源码注释 | 高 |
| 5 | `SchoolImage` | `szSchoolImage` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 6 | `SchoolFrame` | `nSchoolFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `szRoute1Name` | `szRoute1Name` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `szRoute1Value` | `szRoute1Value` | 字符串 | 待确认 | 待确认 | 待确认 |
| 9 | `szRoute2Name` | `szRoute2Name` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 10 | `szRoute2Value` | `szRoute2Value` | 字符串 | 待确认 | 待确认 | 待确认 |
| 11 | `Introduce` | `szIntroduce` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 12 | `Introduce1` | `szIntroduce1` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 13 | `SFXPath` | `szSFXPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 14 | `szNameImage` | `szNameImage` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 15 | `NameFrame` | `szNameFrame` | 整数 | 名称图片帧号 | 字段名推断 | 低 |
| 16 | `szRouteMobile1Name` | `szRouteMobile1Name` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 17 | `szKungfuTypeName1` | `szKungfuTypeName1` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 18 | `szRouteMobile2Name` | `szRouteMobile2Name` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 19 | `szKungfuTypeName2` | `szKungfuTypeName2` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 20 | `BGM` | `szBGMName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 21 | `Note` | `szNote` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 22 | `szWeaponName` | `szWeaponName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 23 | `CombatType` | `szCombatType` | 字符串 | 类型/分类 | 字段名推断 | 低 |

## CrosshairConfig.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `szImgPath` | `szImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 5 | `szAnchor` | `szAnchor` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `szFrameSize` | `szFrameSize` | 字符串 | 帧号/图片帧配置 | 字段名推断 | 低 |

## CrossingChoose.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `LEVEL_ID` | `dwLevelID` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 2 | `DESCRIPTION` | `szTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## CueWords.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Des` | `szDes` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `szIni` | `szIni` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `ImgPath` | `szImgPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `ImgFrame` | `nImgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `bShowImgStamp` | `bShowImgStamp` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 7 | `ImgStampPath` | `szImgStampPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `ImgStampFrame` | `nImgStampFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 9 | `bTextFadeIn` | `bTextFadeIn` | 布尔 | 文本内容 | 字段名推断 | 低 |
| 10 | `nFadeInTime` | `nFadeInTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 11 | `nFadeOutTime` | `nFadeOutTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 12 | `bTextRight` | `bTextRight` | 布尔 | 文本内容 | 字段名推断 | 低 |

## Currency.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `GroupID` | `dwGroupID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `Type` | `dwType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 5 | `TabIndex` | `dwTabIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 6 | `ItemID` | `nItemID` | 整数 | 道具ID | 字段名推断 | 低 |
| 7 | `Frame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 8 | `Get_Desc` | `szDesc1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `Use_Desc` | `szDesc2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 10 | `LinkInfo` | `szLinkInfo` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |

## CurrencyInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 货币索引 | 源码注释 | 高 |
| 3 | `szDescription` | `szDescription` | 字符串 | 货币名字 | 源码注释 | 高 |
| 4 | `nGroup` | `nGroup` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 5 | `szGroup` | `szGroup` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 6 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 8 | `nShowActivityID` | `nShowActivityID` | 整数 | 活动开启才显示 | 源码注释 | 高 |
| 9 | `SourceActivity` | `szSourceActivity` | 多语言文本 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 10 | `SourceShop` | `szSourceShop` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 11 | `SourceTrade` | `bSourceTrade` | 布尔 | 待确认 | 待确认 | 待确认 |
| 12 | `LinkItem` | `szLinkItem` | 多语言文本 | 道具相关配置 | 字段名推断 | 低 |
| 13 | `SourceMall` | `szSourceCoinShop` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 14 | `SourceProduce` | `szSourceProduce` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 15 | `SourceNpc` | `szSourceNpc` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 16 | `SourceCollectD` | `szSourceCollectD` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 17 | `SourceCollectN` | `szSourceCollectN` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 18 | `SourceReputation` | `szSourceReputation` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 19 | `SourceQuest` | `szSourceQuest` | 多语言文本 | 任务相关配置 | 字段名推断 | 低 |
| 20 | `SourceAchievement` | `szSourceAchievement` | 多语言文本 | 成就相关配置 | 字段名推断 | 低 |
| 21 | `SourceBoss` | `szSourceBoss` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 22 | `SourceItem` | `szSourceItem` | 多语言文本 | 道具相关配置 | 字段名推断 | 低 |
| 23 | `SourceAdventure` | `szSourceAdventure` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 24 | `SourceUIFunction` | `szUIFunction` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 25 | `SourceEventLink` | `szUILink` | 多语言文本 | 链接/跳转配置 | 字段名推断 | 低 |
| 26 | `szShopUseLink` | `szShopUseLink` | 多语言文本 | 链接/跳转配置 | 字段名推断 | 低 |
| 27 | `bHideLimit` | `bHideLimit` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## CustomBuffList.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szBuffID[split by ;]` | `szBuffID` | 字符串 | Buff ID | 字段名推断 | 低 |
| 3 | `szNote` | `szNote` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## CustomInvitation.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szSFXPath` | `szSFXPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `szImageDescPath` | `szImageDescPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 5 | `szLink` | `szLink` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 6 | `szContent` | `szContent` | 多语言文本 | 文本内容 | 字段名推断 | 低 |
| 7 | `szIniPath` | `szIniPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `szPrefabName` | `szPrefabName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 9 | `nVKType` | `nVKType` | 整数 | 类型/分类 | 字段名推断 | 低 |

## CustomizedSetForceLogo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwBelongSchoolID` | `dwBelongSchoolID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## cyclopaedia\ActicityUI.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Activity` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `TimeRepresent` | `szTimeRepresent` | 字符串 | 时间配置 | 翻译列/字段名 | 中 |
| 4 | `Class` | `nClass` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 5 | `Star` | `nStar` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `Level` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 7 | `Award` | `szAwardType` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 8 | `ShowPosition` | `nShowPosition` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 9 | `IsHighlight` | `bHighlight` | 布尔 | 待确认 | 待确认 | 待确认 |
| 10 | `HightlightPath` | `szHighlightPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 11 | `Frame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 12 | `ShowPriority` | `nShowPriority` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `DetailPath` | `szDetailPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 14 | `Hard` | `szHard` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 15 | `DetailMap` | `szDetailMap` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 16 | `DetailAwards` | `szDetailAwards` | 多语言文本 | 奖励配置 | 翻译列/字段名 | 中 |
| 17 | `Text` | `szText` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 18 | `Event` | `nEvent` | 整数 | 待确认 | 待确认 | 待确认 |
| 19 | `nAdvancedTime` | `szAdvancedTime` | 字符串 | 时间配置 | 字段名推断 | 低 |
| 20 | `Label` | `nLabel` | 整数 | 待确认 | 待确认 | 待确认 |
| 21 | `BackgroundImage1` | `szBackgroundImage` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 22 | `BackgroundImage2` | `szBackgroundImageExpend` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 23 | `Luckdraw` | `nLuckdraw` | 整数 | 待确认 | 待确认 | 待确认 |
| 24 | `LuckPath` | `szLuckPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 25 | `LuckFrame` | `nLuckFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 26 | `LuckdrawText` | `szLuckdrawText` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 27 | `DailyQuest` | `dwDailyQuestID` | 整数 | 任务ID | 字段名推断 | 低 |
| 28 | `BuffID` | `dwBuffID` | 整数 | Buff ID | 字段名推断 | 低 |
| 29 | `TotalCount` | `nTotalCount` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 30 | `FinishType` | `nFinishType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 31 | `FinishCount` | `nFinishCount` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 32 | `IsDouble` | `bDouble` | 布尔 | 待确认 | 待确认 | 待确认 |
| 33 | `ExtraReward` | `szExtraReward` | 字符串 | 奖励配置 | 翻译列/字段名 | 中 |
| 34 | `DoubleStartTime` | `nDoubleStartTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 35 | `DoubleEndTime` | `nDoubleEndTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 36 | `CareerEvent` | `nCareerEvent` | 整数 | 待确认 | 待确认 | 待确认 |
| 37 | `ShowLevel` | `szShowLevel` | 字符串 | 等级/品质 | 字段名推断 | 低 |
| 38 | `Map` | `szMap` | 字符串 | 待确认 | 待确认 | 待确认 |
| 39 | `MapTip` | `szMapTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 40 | `szTitleBg` | `szTitleBg` | 字符串 | 待确认 | 待确认 | 待确认 |
| 41 | `nMapIconFrame` | `nMapIconFrame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 42 | `BackgroundImage3` | `szSmallBackgroundImg` | 路径 | 待确认 | 待确认 | 待确认 |
| 43 | `nPriority` | `nPriority` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 44 | `bIsMultiple` | `bIsMultiple` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 45 | `szQuestID` | `szQuestID` | 字符串 | 任务ID | 字段名推断 | 低 |
| 46 | `bAutoCollect` | `bAutoCollect` | 布尔 | 待确认 | 待确认 | 待确认 |
| 47 | `bLimited` | `bLimited` | 布尔 | 待确认 | 待确认 | 待确认 |
| 48 | `dwShopGroupID` | `dwShopGroupID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 49 | `dwDefaultShopID` | `dwDefaultShopID` | 整数 | 待确认 | 待确认 | 待确认 |
| 50 | `nRedDotVersion` | `nRedDotVersion` | 整数 | 待确认 | 待确认 | 待确认 |
| 51 | `szTPLink` | `szTPLink` | 字符串 | 传送/跳转链接配置 | 字段名推断 | 低 |
| 52 | `szPanelLink` | `szPanelLink` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 53 | `bShowCountdown` | `bShowCountdown` | 布尔 | 数量/计数 | 字段名推断 | 低 |
| 54 | `MobileText` | `szMobileText` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 55 | `MobileDetailMap` | `szMobileDetailMap` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## cyclopaedia\ActivityAward.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `ActiveID` | 整数 | 活动id | 源码注释 | 高 |
| 2 | `money` | `money` | 整数 | 金 | 源码注释 | 高 |
| 3 | `experience` | `experience` | 整数 | 经验 | 源码注释 | 高 |
| 4 | `justice` | `justice` | 整数 | 侠义值 | 源码注释 | 高 |
| 5 | `prestige` | `prestige` | 整数 | 威望 | 源码注释 | 高 |
| 6 | `titlepoint` | `titlepoint` | 整数 | 战阶 | 源码注释 | 高 |
| 7 | `contribution` | `contribution` | 整数 | 休闲点 | 源码注释 | 高 |
| 8 | `exteriorpiece` | `exteriorpiece` | 字符串 | 拓印碎片 | 源码注释 | 高 |
| 9 | `train` | `train` | 整数 | 修为 | 源码注释 | 高 |
| 10 | `vigor` | `vigor` | 整数 | 活力 | 源码注释 | 高 |
| 11 | `tongfund` | `tongfund` | 整数 | 帮会资金 | 源码注释 | 高 |
| 12 | `tongresource` | `tongresource` | 整数 | 载具资源 | 源码注释 | 高 |
| 13 | `prestigelimit` | `prestigelimit` | 字符串 | 威望周上限 | 源码注释 | 高 |
| 14 | `justicelimit` | `justicelimit` | 字符串 | 侠义值周上限 | 源码注释 | 高 |
| 15 | `personalhighlevel` | `personalhighlevel` | 整数 | 个人精英分 | 源码注释 | 高 |
| 16 | `teamhighlevel` | `teamhighlevel` | 整数 | 队伍精英分 | 源码注释 | 高 |
| 17 | `exitem1` | `exitem1` | 字符串 | 额外奖励的道具 | 源码注释 | 高 |
| 18 | `exitem2` | `exitem2` | 字符串 | 额外奖励的道具 | 源码注释 | 高 |
| 19 | `exitem3` | `exitem3` | 字符串 | 额外奖励的道具 | 源码注释 | 高 |
| 20 | `exitem4` | `exitem4` | 字符串 | 额外奖励的道具 | 源码注释 | 高 |
| 21 | `exdoubleitem` | `exdoubleitem` | 字符串 | 双倍额外奖励的道具 | 源码注释 | 高 |

## cyclopaedia\ActivityAwardIcon.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Id` | `ID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `Des` | `szDes` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 5 | `szTips` | `szTips` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## cyclopaedia\ActivityBattlePassQuest.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szModuleName` | `szModuleName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `nClass` | `nClass` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `szQuestID` | `szQuestID` | 字符串 | 任务ID | 字段名推断 | 低 |
| 5 | `nBuffID` | `nBuffID` | 整数 | Buff ID | 字段名推断 | 低 |
| 6 | `nExpCanGet` | `nExpCanGet` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 7 | `nForceExpCanGet` | `nForceExpCanGet` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 8 | `szQuestDesc` | `szQuestDesc` | 字符串 | 任务相关配置 | 翻译列/字段名 | 中 |
| 9 | `nMaxFinishTimes` | `nMaxFinishTimes` | 整数 | 时间配置 | 字段名推断 | 低 |
| 10 | `szLink` | `szLink` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 11 | `szTPLink` | `szTPLink` | 字符串 | 传送/跳转链接配置 | 字段名推断 | 低 |
| 12 | `szPanelLink` | `szPanelLink` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 13 | `nRecruit` | `nRecruit` | 整数 | 待确认 | 待确认 | 待确认 |
| 14 | `nLimitLevel` | `nLimitLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 15 | `nHideLevel` | `nHideLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 16 | `nWeaponChips` | `nWeaponChips` | 整数 | 待确认 | 待确认 | 待确认 |

## cyclopaedia\ActivityBattlePassReward.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwSetID` | `dwSetID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `dwSetID2` | `dwSetID2` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 4 | `szRewardPicPath` | `szRewardPicPath` | 路径 | 奖励配置 | 字段名推断 | 低 |
| 5 | `szMalePicPath` | `szMalePicPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `szFemalePicPath` | `szFemalePicPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `szBoyPicPath` | `szBoyPicPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `szGirlPicPath` | `szGirlPicPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `szShortDescPicPath` | `szShortDescPicPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |

## cyclopaedia\ActivityHome.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `a` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szActivityID` | `szActivityID` | 字符串 | 活动ID | 字段名推断 | 低 |
| 3 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `dwClassify` | `dwClassify` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 5 | `szTypeUITex` | `szTypeUITex` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 6 | `nTypeFrame` | `nTypeFrame` | 整数 | 类型/分类 | 字段名推断 | 低 |

## cyclopaedia\ActivityInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ClassID` | `dwClassID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `ActivityID` | `dwActivityID` | 整数 | 活动ID | 字段名推断 | 低 |
| 3 | `ClassName` | `szClassName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 4 | `Title` | `szTitle` | 字符串 | 标题文本 | 字段名推断 | 低 |
| 5 | `Content` | `szContent` | 多语言文本 | 文本内容 | 字段名推断 | 低 |
| 6 | `Link` | `szLink` | 多语言文本 | 链接/跳转配置 | 字段名推断 | 低 |

## cyclopaedia\ActivityNoneML.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwActivityID` | `dwActivityID` | 整数 | 活动ID | 字段名推断 | 低 |

## cyclopaedia\ActivityQuest.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwQuestID` | `nQuestID` | 整数 | 任务ID | 字段名推断 | 低 |
| 2 | `dwNpcTemplateID` | `nNpcTemplateID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `dwQuestGroupID` | `nQuestGroupID` | 整数 | 任务ID | 字段名推断 | 低 |
| 4 | `dwActivityID` | `nActivityID` | 整数 | 活动ID | 字段名推断 | 低 |
| 5 | `bCompleteShow` | `bCompleteShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `bUnacceptedShow` | `bUnacceptedShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 7 | `bAutoComplete` | `bAutoComplete` | 布尔 | 待确认 | 待确认 | 待确认 |
| 8 | `bIgnoreCanAccept` | `bIgnoreCanAccept` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## cyclopaedia\CalenderAward.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |

## cyclopaedia\CareerEvent.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Level` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `Title` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 4 | `Introduction` | `szIntroduction` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `MapID1` | `nMapID1` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `MapID2` | `nMapID2` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `MapID3` | `nMapID3` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `MapID4` | `nMapID4` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `MapID5` | `nMapID5` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `TabIDs` | `szTab` | 字符串 | 待确认 | 待确认 | 待确认 |
| 11 | `PopUp` | `bPopUp` | 布尔 | 待确认 | 待确认 | 待确认 |

## cyclopaedia\CareerGuide.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `LinkID` | `nLinkID` | 整数 | 链接/跳转配置 | 字段名推断 | 低 |
| 2 | `MapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 3 | `NpcID` | `dwNpcID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `Kind` | `szKind` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 5 | `x` | `fX` | 浮点数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 6 | `y` | `fY` | 浮点数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `z` | `fZ` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 8 | `NpcName` | `szNpcName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `ForceID` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 10 | `Camp` | `nCamp` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 11 | `CanTP` | `bCanTP` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## cyclopaedia\CareerTab.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TabID` | `nTabID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `Title` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 4 | `Image1` | `szImage1` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 5 | `Note1` | `szNote1` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `Image2` | `szImage2` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 7 | `Note2` | `szNote2` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `Image3` | `szImage3` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 9 | `Note3` | `szNote3` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 10 | `Description` | `szDescription` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |

## cyclopaedia\CyclopaediaSkill.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `SectionID` | `nSectionID` | 整数 | 章节段落ID | 字段名推断 | 低 |
| 2 | `ForceID` | `nForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 3 | `Skill` | `szSkill` | 字符串 | 技能相关配置 | 字段名推断 | 低 |

## cyclopaedia\DailyQuestInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TypeID` | `dwTypeID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `QuestID` | `dwQuestID` | 整数 | 任务ID | 字段名推断 | 低 |
| 3 | `TypeName` | `szTypeName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 4 | `Content` | `szContent` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `Link` | `szLink` | 多语言文本 | 链接/跳转配置 | 字段名推断 | 低 |

## cyclopaedia\DungeonBoss.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `BossIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `MapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 3 | `BOSS` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `Introduce` | `szIntroduce` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `BossPath` | `szBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `BossFrame` | `nBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `Index` | `szNpcList` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 8 | `Step1Skill` | `szStep1Skill` | 字符串 | 技能相关配置 | 字段名推断 | 低 |
| 9 | `Step1Des` | `szStep1Des` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 10 | `Step2Skill` | `szStep2Skill` | 字符串 | 技能相关配置 | 字段名推断 | 低 |
| 11 | `Step2Des` | `szStep2Des` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 12 | `Step3Skill` | `szStep3Skill` | 字符串 | 技能相关配置 | 字段名推断 | 低 |
| 13 | `Step3Des` | `szStep3Des` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 14 | `Step4Skill` | `szStep4Skill` | 字符串 | 技能相关配置 | 字段名推断 | 低 |
| 15 | `Step4Des` | `szStep4Des` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 16 | `szStep5Skill` | `szStep5Skill` | 字符串 | 技能相关配置 | 字段名推断 | 低 |
| 17 | `szStep5Des` | `szStep5Des` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## cyclopaedia\DungeonClass.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ClassID` | `dwClassID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `ClassName` | `szClassName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 3 | `Content` | `szContent` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `Link` | `szLink` | 多语言文本 | 链接/跳转配置 | 字段名推断 | 低 |

## cyclopaedia\DungeonDrop.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TabType` | `dwTapType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `ID` | `dwTabIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `Durability` | `nDurability` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `BelongSchool` | `szBelongSchool` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `MagicKind` | `szMagicKind` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 6 | `Get_Desc` | `szSourceDesc` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `BelongMapID` | `szBelongMapID` | 字符串 | 待确认 | 待确认 | 待确认 |

## cyclopaedia\DungeonEnterTip.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Index` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `Tip` | `szTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## cyclopaedia\DungeonInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `MapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 2 | `ClassID` | `dwClassID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `MinLevel` | `nMinLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 4 | `FitMinLevel` | `nFitMinLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 5 | `FitMaxLevel` | `nFitMaxLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 6 | `Layer3Name` | `szLayer3Name` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `OtherName` | `szOtherName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `VersionName` | `szVersionName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `DungeonImage1` | `szDungeonImage1` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 10 | `DungeonFrame1` | `nDungeonFrame1` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 11 | `DungeonImage2` | `szDungeonImage2` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 12 | `DungeonFrame2` | `nDungeonFrame2` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 13 | `DungeonImage3` | `szDungeonImage3` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 14 | `DungeonFrame3` | `nDungeonFrame3` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 15 | `EnterWay` | `szEnterWay` | 多语言文本 | 坐标/尺寸配置 | 翻译列/字段名 | 中 |
| 16 | `BossInfo` | `szBossInfo` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 17 | `Introduction` | `szIntroduction` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 18 | `Tutorial` | `szTutorial` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 19 | `HelpImage` | `szHelpImage` | 多语言文本 | 图片资源配置 | 字段名推断 | 低 |
| 20 | `HelpText` | `szHelpText` | 多语言文本 | 文本内容 | 字段名推断 | 低 |
| 21 | `DivideLevel` | `nDivideLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 22 | `DivideName` | `szDivideName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 23 | `bRaceRank` | `bRaceRank` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 24 | `bGetLock` | `bGetLock` | 布尔 | 待确认 | 待确认 | 待确认 |
| 25 | `DlcID` | `nDLCID` | 整数 | DLC/资料片ID | 字段名推断 | 低 |
| 26 | `EnterMapID` | `nEnterMapID` | 整数 | 待确认 | 待确认 | 待确认 |
| 27 | `IsRecommend` | `bIsRecommend` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 28 | `Rushmode` | `bRushmode` | 布尔 | 待确认 | 待确认 | 待确认 |
| 29 | `RushmodeTip` | `szRushmodeTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 30 | `bIsPast` | `bIsPast` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 31 | `bHideDetail` | `bHideDetail` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 32 | `szReward` | `szReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 33 | `szExtReward` | `szExtReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 34 | `dwQuestID` | `dwQuestID` | 整数 | 任务ID | 字段名推断 | 低 |
| 35 | `nStoryMode` | `nStoryMode` | 整数 | 待确认 | 待确认 | 待确认 |

## cyclopaedia\DungeonNpc.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Index` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `NpcID` | `dwNpcID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `ModelID` | `dwModelID` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `ModelScale` | `fModelScale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 6 | `ModelScaleMB` | `fModelScaleMB` | 浮点数 | 待确认 | 待确认 | 待确认 |

## cyclopaedia\DungeonNpcCV.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Index` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `NpcName` | `szNpcName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `NpcID` | `dwNpcID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `CVName` | `szCVName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `CVPath1` | `szCVPath1` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `Time1` | `nTime1` | 整数 | 时间配置 | 字段名推断 | 低 |
| 7 | `CVPath2` | `szCVPath2` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `Time2` | `nTime2` | 整数 | 时间配置 | 字段名推断 | 低 |
| 9 | `CVPath3` | `szCVPath3` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `Time3` | `nTime3` | 整数 | 时间配置 | 字段名推断 | 低 |
| 11 | `CVPath4` | `szCVPath4` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 12 | `Time4` | `nTime4` | 整数 | 时间配置 | 字段名推断 | 低 |
| 13 | `CVPath5` | `szCVPath5` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 14 | `Time5` | `nTime5` | 整数 | 时间配置 | 字段名推断 | 低 |
| 15 | `CVPath6` | `szCVPath6` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 16 | `Time6` | `nTime6` | 整数 | 时间配置 | 字段名推断 | 低 |
| 17 | `CVPath7` | `szCVPath7` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 18 | `Time7` | `nTime7` | 整数 | 时间配置 | 字段名推断 | 低 |
| 19 | `CVPath8` | `szCVPath8` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 20 | `Time8` | `nTime8` | 整数 | 时间配置 | 字段名推断 | 低 |

## cyclopaedia\DungeonSkill.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `SkillName` | `szSkillName` | 多语言文本 | 技能相关配置 | 翻译列/字段名 | 中 |
| 3 | `IconID` | `nIconType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `Desc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |

## cyclopaedia\DungeonSkillIcon.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `IconType` | `dwIconType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `ImageFile` | `szImageFile` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 4 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 5 | `Tip` | `szTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## cyclopaedia\FAQ.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `classid` | `dwClassID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `subclassid` | `dwSubClassID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `classtitle` | `szClassName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 4 | `question` | `szQuestion` | 多语言文本 | 任务相关配置 | 翻译列/字段名 | 中 |
| 5 | `answer` | `szAnswer` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## cyclopaedia\fieldpq.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `PQTemplateID` | `dwPQTemplateID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `MapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 3 | `TotalSetp` | `nTotalStep` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 4 | `Name` | `szName` | 多语言文本 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 5 | `Description` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 6 | `X` | `fX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `Y` | `fY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 8 | `Z` | `fZ` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `IdentityVisibleID` | `szIdentityVisibleID` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |

## cyclopaedia\fieldpqstep.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `PQTemplateID` | `dwPQTemplateID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `Step` | `nSetpID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `Name` | `szName` | 多语言文本 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `Description` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 5 | `KillNpcTemplateID1` | `nKillNpcTemplateID1` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `Amount1` | `nAmount1` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 7 | `KillNpcTemplateID2` | `nKillNpcTemplateID2` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `Amount2` | `nAmount2` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 9 | `KillNpcTemplateID3` | `nKillNpcTemplateID3` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `Amount3` | `nAmount3` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 11 | `KillNpcTemplateID4` | `nKillNpcTemplateID4` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `Amount4` | `nAmount4` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 13 | `KillNpcTemplateID5` | `nKillNpcTemplateID5` | 整数 | 待确认 | 待确认 | 待确认 |
| 14 | `Amount5` | `nAmount5` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 15 | `KillNpcTemplateID6` | `nKillNpcTemplateID6` | 整数 | 待确认 | 待确认 | 待确认 |
| 16 | `Amount6` | `nAmount6` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 17 | `KillNpcTemplateID7` | `nKillNpcTemplateID7` | 整数 | 待确认 | 待确认 | 待确认 |
| 18 | `Amount7` | `nAmount7` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 19 | `KillNpcTemplateID8` | `nKillNpcTemplateID8` | 整数 | 待确认 | 待确认 | 待确认 |
| 20 | `Amount8` | `nAmount8` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 21 | `PQvalue1` | `nPQvalue1` | 整数 | 待确认 | 待确认 | 待确认 |
| 22 | `PQValueString1` | `szPQValueStr1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 23 | `PQvalue2` | `nPQvalue2` | 整数 | 待确认 | 待确认 | 待确认 |
| 24 | `PQValueString2` | `szPQValueStr2` | 字符串 | 待确认 | 待确认 | 待确认 |
| 25 | `PQvalue3` | `nPQvalue3` | 整数 | 待确认 | 待确认 | 待确认 |
| 26 | `PQValueString3` | `szPQValueStr3` | 字符串 | 待确认 | 待确认 | 待确认 |
| 27 | `PQvalue4` | `nPQvalue4` | 整数 | 待确认 | 待确认 | 待确认 |
| 28 | `PQValueString4` | `szPQValueStr4` | 字符串 | 待确认 | 待确认 | 待确认 |
| 29 | `PQvalue5` | `nPQvalue5` | 整数 | 待确认 | 待确认 | 待确认 |
| 30 | `PQValueString5` | `szPQValueStr5` | 字符串 | 待确认 | 待确认 | 待确认 |
| 31 | `PQvalue6` | `nPQvalue6` | 整数 | 待确认 | 待确认 | 待确认 |
| 32 | `PQValueString6` | `szPQValueStr6` | 字符串 | 待确认 | 待确认 | 待确认 |
| 33 | `PQvalue7` | `nPQvalue7` | 整数 | 待确认 | 待确认 | 待确认 |
| 34 | `PQValueString7` | `szPQValueStr7` | 字符串 | 待确认 | 待确认 | 待确认 |
| 35 | `PQvalue8` | `nPQvalue8` | 整数 | 待确认 | 待确认 | 待确认 |
| 36 | `PQValueString8` | `szPQValueStr8` | 字符串 | 待确认 | 待确认 | 待确认 |

## cyclopaedia\JX3Library.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ClassID` | `dwClassID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `SubClassID` | `dwSubClassID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 4 | `ClassName` | `szClassName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 5 | `SubClassName` | `szSubClassName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 6 | `Title` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 7 | `Content` | `szContent` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `Link` | `szLink` | 多语言文本 | 链接/跳转配置 | 字段名推断 | 低 |

## cyclopaedia\suggestbattlefield.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 2 | `dwID1` | `dwID1` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `dwID2` | `dwID2` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `dwID3` | `dwID3` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `dwID4` | `dwID4` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `dwID5` | `dwID5` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `dwID6` | `dwID6` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `dwID7` | `dwID7` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `dwID8` | `dwID8` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `dwID9` | `dwID9` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `dwID10` | `dwID10` | 整数 | 待确认 | 待确认 | 待确认 |

## cyclopaedia\suggestcopy.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 2 | `dwCopyID1` | `dwID1` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `dwCopyID2` | `dwID2` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `dwCopyID3` | `dwID3` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `dwCopyID4` | `dwID4` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `dwCopyID5` | `dwID5` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `dwCopyID6` | `dwID6` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `dwCopyID7` | `dwID7` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `dwCopyID8` | `dwID8` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `dwCopyID9` | `dwID9` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `dwCopyID10` | `dwID10` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `dwCopyID11` | `dwID11` | 整数 | 待确认 | 待确认 | 待确认 |
| 13 | `dwCopyID12` | `dwID12` | 整数 | 待确认 | 待确认 | 待确认 |
| 14 | `dwCopyID13` | `dwID13` | 整数 | 待确认 | 待确认 | 待确认 |
| 15 | `dwCopyID14` | `dwID14` | 整数 | 待确认 | 待确认 | 待确认 |
| 16 | `dwCopyID15` | `dwID15` | 整数 | 待确认 | 待确认 | 待确认 |
| 17 | `dwCopyID16` | `dwID16` | 整数 | 待确认 | 待确认 | 待确认 |
| 18 | `dwCopyID17` | `dwID17` | 整数 | 待确认 | 待确认 | 待确认 |
| 19 | `dwCopyID18` | `dwID18` | 整数 | 待确认 | 待确认 | 待确认 |
| 20 | `dwCopyID19` | `dwID19` | 整数 | 待确认 | 待确认 | 待确认 |
| 21 | `dwCopyID20` | `dwID20` | 整数 | 待确认 | 待确认 | 待确认 |

## cyclopaedia\suggestquest.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Level` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 2 | `ForceID` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 3 | `MapID1` | `dwMapID1` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `AreaID1` | `dwAreaID1` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `MapID2` | `dwMapID2` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `AreaID2` | `dwAreaID2` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `MapID3` | `dwMapID3` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `AreaID3` | `dwAreaID3` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `MapID4` | `dwMapID4` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `AreaID4` | `dwAreaID4` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `MapID5` | `dwMapID5` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `AreaID5` | `dwAreaID5` | 整数 | 待确认 | 待确认 | 待确认 |
| 13 | `MapID6` | `dwMapID6` | 整数 | 待确认 | 待确认 | 待确认 |
| 14 | `AreaID6` | `dwAreaID6` | 整数 | 待确认 | 待确认 | 待确认 |
| 15 | `MapID7` | `dwMapID7` | 整数 | 待确认 | 待确认 | 待确认 |
| 16 | `AreaID7` | `dwAreaID7` | 整数 | 待确认 | 待确认 | 待确认 |
| 17 | `MapID8` | `dwMapID8` | 整数 | 待确认 | 待确认 | 待确认 |
| 18 | `AreaID8` | `dwAreaID8` | 整数 | 待确认 | 待确认 | 待确认 |
| 19 | `MapID9` | `dwMapID9` | 整数 | 待确认 | 待确认 | 待确认 |
| 20 | `AreaID9` | `dwAreaID9` | 整数 | 待确认 | 待确认 | 待确认 |
| 21 | `MapID10` | `dwMapID10` | 整数 | 待确认 | 待确认 | 待确认 |
| 22 | `AreaID10` | `dwAreaID10` | 整数 | 待确认 | 待确认 | 待确认 |
| 23 | `MapID11` | `dwMapID11` | 整数 | 待确认 | 待确认 | 待确认 |
| 24 | `AreaID11` | `dwAreaID11` | 整数 | 待确认 | 待确认 | 待确认 |
| 25 | `MapID12` | `dwMapID12` | 整数 | 待确认 | 待确认 | 待确认 |
| 26 | `AreaID12` | `dwAreaID12` | 整数 | 待确认 | 待确认 | 待确认 |
| 27 | `MapID13` | `dwMapID13` | 整数 | 待确认 | 待确认 | 待确认 |
| 28 | `AreaID13` | `dwAreaID13` | 整数 | 待确认 | 待确认 | 待确认 |
| 29 | `MapID14` | `dwMapID14` | 整数 | 待确认 | 待确认 | 待确认 |
| 30 | `AreaID14` | `dwAreaID14` | 整数 | 待确认 | 待确认 | 待确认 |
| 31 | `MapID15` | `dwMapID15` | 整数 | 待确认 | 待确认 | 待确认 |
| 32 | `AreaID15` | `dwAreaID15` | 整数 | 待确认 | 待确认 | 待确认 |
| 33 | `MapID16` | `dwMapID16` | 整数 | 待确认 | 待确认 | 待确认 |
| 34 | `AreaID16` | `dwAreaID16` | 整数 | 待确认 | 待确认 | 待确认 |
| 35 | `MapID17` | `dwMapID17` | 整数 | 待确认 | 待确认 | 待确认 |
| 36 | `AreaID17` | `dwAreaID17` | 整数 | 待确认 | 待确认 | 待确认 |
| 37 | `MapID18` | `dwMapID18` | 整数 | 待确认 | 待确认 | 待确认 |
| 38 | `AreaID18` | `dwAreaID18` | 整数 | 待确认 | 待确认 | 待确认 |
| 39 | `MapID19` | `dwMapID19` | 整数 | 待确认 | 待确认 | 待确认 |
| 40 | `AreaID19` | `dwAreaID19` | 整数 | 待确认 | 待确认 | 待确认 |
| 41 | `MapID20` | `dwMapID20` | 整数 | 待确认 | 待确认 | 待确认 |
| 42 | `AreaID20` | `dwAreaID20` | 整数 | 待确认 | 待确认 | 待确认 |
| 43 | `MapID21` | `dwMapID21` | 整数 | 待确认 | 待确认 | 待确认 |
| 44 | `AreaID21` | `dwAreaID21` | 整数 | 待确认 | 待确认 | 待确认 |
| 45 | `MapID22` | `dwMapID22` | 整数 | 待确认 | 待确认 | 待确认 |
| 46 | `AreaID22` | `dwAreaID22` | 整数 | 待确认 | 待确认 | 待确认 |

## DanmakuColor.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `R` | `r` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `G` | `g` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `B` | `b` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `szPath` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 7 | `szTip37` | `szTip37` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `szTip38` | `szTip38` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## Daxiazhilu\RankInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nRankLv` | `nRankLv` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szRankName` | `szRankName` | 字符串 | 索引/排序 | 字段名推断 | 低 |
| 3 | `szRankFullName` | `szRankFullName` | 字符串 | 索引/排序 | 字段名推断 | 低 |
| 4 | `nRankPoint` | `nRankPoint` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 5 | `szImagePath` | `szImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `nImageFrame` | `nImageFrame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 7 | `nImageOverFrame` | `nImageOverFrame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 8 | `nImageClickFrame` | `nImageClickFrame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 9 | `szSFXPath` | `szSFXPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `nR` | `nR` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `nG` | `nG` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `nB` | `nB` | 整数 | 待确认 | 待确认 | 待确认 |
| 13 | `szRewardPath` | `szRewardPath` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 14 | `nRewardBgFrame` | `nRewardBgFrame` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 15 | `nRewardBgColorFrame` | `nRewardBgColorFrame` | 字符串 | 奖励配置 | 字段名推断 | 低 |

## DesertEquipInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTabType` | `dwTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `szMagicType1` | `szMagicType1` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 4 | `szMagicType2` | `szMagicType2` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 5 | `szMagicType3` | `szMagicType3` | 字符串 | 类型/分类 | 字段名推断 | 低 |

## DesertStormSkill.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `dwSkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 4 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 5 | `nQuality` | `nQuality` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 6 | `nEffect` | `nEffect` | 整数 | 待确认 | 待确认 | 待确认 |

## DesertStormSkillEffect.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |

## DesertStormSkillQuality.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |

## DesertStormSkin.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 5 | `szTask` | `szTask` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `szSFXPath` | `szSFXPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## DesertStormSkinType.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `nIconFrame` | `nIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## DesertWeaponSkill.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwMountID` | `dwMountID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 4 | `szSkillID` | `szSkillID` | 字符串 | 技能ID | 字段名推断 | 低 |
| 5 | `szWeaponID` | `szWeaponID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `nRange` | `nRange` | 整数 | 待确认 | 待确认 | 待确认 |

## Designation_Balloon.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `BallonID` | `dwBalloonID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szHandle` | `szHandle` | 字符串 | 待确认 | 待确认 | 待确认 |

## Designation_Character_ChunYang.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Character` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |

## Designation_Character_Qixiu.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Character` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |

## Designation_Character_Shaolin.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Character` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |

## Designation_Character_Tiance.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Character` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |

## Designation_Character_WanHua.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Character` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |

## Designation_Generation.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Force` | `dwForce` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 2 | `Generation` | `dwGeneration` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `Character` | `szCharacter` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `Desc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 6 | `bOutOfPrint` | `bOutOfPrint` | 布尔 | 待确认 | 待确认 | 待确认 |
| 7 | `nVersion` | `nVersion` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `nGainWayType` | `nGainWayType` | 整数 | 类型/分类 | 字段名推断 | 低 |

## Designation_Postfix.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `FromAchievementID` | `dwAchievement` | 整数 | 成就相关配置 | 字段名推断 | 低 |
| 4 | `FromOtherItemID` | `dwTableIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 5 | `Quality` | `nQuality` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 6 | `CanChatShow` | `bChatShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 7 | `Desc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 8 | `bIsEffect` | `bIsEffect` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 9 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `bOutOfPrint` | `bOutOfPrint` | 布尔 | 待确认 | 待确认 | 待确认 |
| 11 | `nVersion` | `nVersion` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `nGainWayType` | `nGainWayType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 13 | `bPopNew` | `bPopNew` | 布尔 | 待确认 | 待确认 | 待确认 |
| 14 | `bBan` | `bBan` | 布尔 | 万宝楼角色交易是否能搜称号，客户端实际无用途 | 源码注释 | 高 |

## Designation_Prefix.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `FromAchievementID` | `dwAchievement` | 整数 | 成就相关配置 | 字段名推断 | 低 |
| 4 | `FromOtherItemID` | `dwTableIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 5 | `Quality` | `nQuality` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 6 | `CanChatShow` | `bChatShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 7 | `Desc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 8 | `bIsEffect` | `bIsEffect` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 9 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `bOutOfPrint` | `bOutOfPrint` | 布尔 | 待确认 | 待确认 | 待确认 |
| 11 | `nVersion` | `nVersion` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `nGainWayType` | `nGainWayType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 13 | `bPopNew` | `bPopNew` | 布尔 | 待确认 | 待确认 | 待确认 |
| 14 | `bForce` | `bForce` | 布尔 | 势力/阵营配置 | 字段名推断 | 低 |
| 15 | `bBan` | `bBan` | 布尔 | 万宝楼角色交易是否能搜称号，客户端实际无用途 | 源码注释 | 高 |

## Designation_Prefix_Force.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `ForceID` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 3 | `Name` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 4 | `FromAchievementID` | `dwAchievement` | 整数 | 成就相关配置 | 字段名推断 | 低 |
| 5 | `FromOtherItemID` | `dwTableIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 6 | `Quality` | `nQuality` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 7 | `CanChatShow` | `bChatShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 8 | `Desc` | `szDesc` | 多语言文本 | 描述文本 | 字段名推断 | 低 |
| 9 | `bIsEffect` | `bIsEffect` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 10 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 11 | `bOutOfPrint` | `bOutOfPrint` | 布尔 | 待确认 | 待确认 | 待确认 |
| 12 | `nVersion` | `nVersion` | 整数 | 待确认 | 待确认 | 待确认 |
| 13 | `nGainWayType` | `nGainWayType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 14 | `bPopNew` | `bPopNew` | 布尔 | 待确认 | 待确认 | 待确认 |

## DesignationDecoration.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szImgPath` | `szImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 4 | `szSfxPath` | `szSfxPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `bNotGetShow` | `bShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `szLinkItem` | `szLinkItem` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 7 | `szFontRGB` | `szFontRGB` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `nBorderSize` | `nBorderSize` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 9 | `szBorderRGB` | `szBorderRGB` | 字符串 | 索引/排序 | 字段名推断 | 低 |

## DesignationGainWayList.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `TypeName` | `szTypeName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |

## DesignationTitle.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TitleID` | `dwTitleID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `Type` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `DesignationID` | `dwDesignationID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `BalloonID` | `dwBalloonID` | 整数 | 待确认 | 待确认 | 待确认 |

## DesignationVersionInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szVersionName` | `szVersionName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `szImgTitlePath` | `szImgTitlePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nNormalFrame` | `nNormalFrame` | 整数 | 普通状态帧号 | 字段名推断 | 低 |
| 5 | `nOverFrame` | `nOverFrame` | 整数 | 悬停/经过状态帧号 | 字段名推断 | 低 |
| 6 | `nDownFrame` | `nDownFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `nSelFrame` | `nSelFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `nSelOverFrame` | `nSelOverFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 9 | `nSelDownFrame` | `nSelDownFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## DialogBtn.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `IniPath` | `szIniPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `ModName` | `szModName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `BgPath` | `szBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `BgNormal` | `dwBgNormal` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `BgHighLight` | `dwBgHighLight` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `BgDisable` | `dwBgDisable` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 8 | `TitlePath` | `szTitlePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `SFXPath` | `szSFXPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## DialogueFontChange.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwFont` | `dwFont` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `dwNewFont` | `dwNewFont` | 整数 | 待确认 | 待确认 | 待确认 |

## DialoguePanelSpecialInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwTargetType` | `dwTargetType` | 整数 | 目标类型 | 字段名推断 | 低 |
| 3 | `dwItemIndex` | `dwItemIndex` | 整数 | 道具索引 | 字段名推断 | 低 |
| 4 | `szNpc` | `szNpc` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `szCustomTitle` | `szCustomTitle` | 字符串 | 待确认 | 待确认 | 待确认 |

## DiamondCost.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `fCost` | `fCost` | 浮点数 | 待确认 | 待确认 | 待确认 |

## dispelbuffer.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `外功气劲1` | `szBuffTye1` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 4 | `外功不利效果2` | `szBuffTye2` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 5 | `阳性气劲3` | `szBuffTye3` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 6 | `阳性不利效果4` | `szBuffTye4` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 7 | `混元性气劲5` | `szBuffTye5` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 8 | `混元性不利效果6` | `szBuffTye6` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 9 | `阴性气劲7` | `szBuffTye7` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 10 | `阴性不利效果8` | `szBuffTye8` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 11 | `点穴9` | `szBuffTye9` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 12 | `点穴不利效果10` | `szBuffTye10` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 13 | `毒性气劲11` | `szBuffTye11` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 14 | `毒性不利效果12` | `szBuffTye12` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 15 | `蛊13` | `szBuffTye13` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 16 | `蛊不利效果14` | `szBuffTye14` | 整数 | Buff相关配置 | 字段名推断 | 低 |

## DisplacementHotkeys.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwBitOPSchoolID` | `dwBitOPSchoolID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szKey` | `szKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 3 | `"nKeyState[0:Down,1:Up,-1:Both]"` | `nKeyState` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `nDoubleClick` | `nDoubleClick` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `nWeaponCheck` | `nWeaponCheck` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `szRepresentIDGroups` | `szRepresentIDGroups` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 7 | `szNotRepresentIDGroups` | `szNotRepresentIDGroups` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 8 | `nSprintFlag` | `nSprintFlag` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `nFollowController` | `nFollowController` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `szTargetType` | `szTargetType` | 字符串 | 目标类型 | 字段名推断 | 低 |
| 11 | `nJumpCount` | `nJumpCount` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 12 | `nJumping` | `nJumping` | 整数 | 待确认 | 待确认 | 待确认 |
| 13 | `nFighting` | `nFighting` | 整数 | 待确认 | 待确认 | 待确认 |
| 14 | `nRunOnWater` | `nRunOnWater` | 整数 | 待确认 | 待确认 | 待确认 |
| 15 | `nIgnoreGravity` | `nIgnoreGravity` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 16 | `nHangFlag` | `nHangFlag` | 整数 | 待确认 | 待确认 | 待确认 |
| 17 | `nOnTowerFlag` | `nOnTowerFlag` | 整数 | 待确认 | 待确认 | 待确认 |
| 18 | `nBirdMove` | `nBirdMove` | 整数 | 待确认 | 待确认 | 待确认 |
| 19 | `nFlyFlag` | `nFlyFlag` | 整数 | 待确认 | 待确认 | 待确认 |
| 20 | `bContinual` | `bContinual` | 布尔 | 待确认 | 待确认 | 待确认 |
| 21 | `BuffID` | `dwBuffID` | 整数 | Buff ID | 字段名推断 | 低 |
| 22 | `BuffLevel` | `nBuffLevel` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 23 | `nParkourFlag` | `nParkourFlag` | 整数 | 待确认 | 待确认 | 待确认 |
| 24 | `nIsHasValidTrack` | `nIsHasValidTrack` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 25 | `bSlideSprintFlag` | `bSlideSprintFlag` | 整数 | 待确认 | 待确认 | 待确认 |
| 26 | `nOTActionState` | `nOTActionState` | 整数 | 待确认 | 待确认 | 待确认 |
| 27 | `dwSkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 28 | `nSkillLevel` | `nSkillLevel` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 29 | `bStopAction` | `bStopAction` | 布尔 | 待确认 | 待确认 | 待确认 |
| 30 | `bClimb` | `nClimb` | 整数 | 待确认 | 待确认 | 待确认 |
| 31 | `bGlide` | `nGlide` | 整数 | 待确认 | 待确认 | 待确认 |
| 32 | `comment` | `szComment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 33 | `szUISetting` | `szUISetting` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 34 | `dwFreeModeSkillID` | `nFreeModeSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 35 | `szCombinationKeys` | `szCombinationKeys` | 字符串 | 待确认 | 待确认 | 待确认 |
| 36 | `bIgnoreCommonSprint` | `bIgnoreCommonSprint` | 布尔 | 待确认 | 待确认 | 待确认 |

## Divination.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `StickSFX` | `szStickSFX` | 路径 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 3 | `StickWaitingSFX` | `szStickWaitingSFX` | 路径 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `DiviationAfterBG` | `szDivinationAfterBG` | 路径 | 待确认 | 待确认 | 待确认 |
| 5 | `DiviationAfterBGFrame` | `nDivinationAfterFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `SignetBGPath` | `szSignetBGPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `SignetBGFrame` | `nSignetBGFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `SignetPath` | `szSignetPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `SignetFrame` | `nSignetFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 10 | `SignetText` | `szSignetText` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 11 | `SignetTip` | `szSignetTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## DLCAchievementInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `DLCID` | `dwDLCID` | 整数 | DLC/资料片ID | 字段名推断 | 低 |
| 2 | `IconPath` | `szIconPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `IconFrame` | `nIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## DLCInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `DLCID` | `dwDLCID` | 整数 | DLC/资料片ID | 字段名推断 | 低 |
| 2 | `DLCName` | `szDLCName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `ShortName` | `szShortName` | 字符串 | 简称文本 | 字段名推断 | 低 |
| 4 | `NamePrefix` | `szNamePrefix` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `Year` | `nYear` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `DLCMapID` | `szDLCMapID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `LogoSfx` | `szLogoSfx` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 8 | `NameImage` | `szNameImage` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 9 | `NameFrame` | `nNameFrame` | 整数 | 名称图片帧号 | 字段名推断 | 低 |
| 10 | `DiscribleImage` | `szDiscribleImage` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 11 | `DiscribleFrame` | `nDiscribleFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 12 | `NameTextImage` | `szNameTextImage` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 13 | `NameTextFrame` | `nNameTextFrame` | 整数 | 文本内容 | 字段名推断 | 低 |
| 14 | `NameStageImage` | `szNameStateImage` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 15 | `NameStageFrame` | `nNameStateFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 16 | `RewardQuestID1` | `nRewardQuestID1` | 整数 | 任务ID | 字段名推断 | 低 |
| 17 | `RewardScore1` | `nRewardScore1` | 整数 | 奖励配置 | 字段名推断 | 低 |
| 18 | `RewardQuestID2` | `nRewardQuestID2` | 整数 | 任务ID | 字段名推断 | 低 |
| 19 | `RewardScore2` | `nRewardScore2` | 整数 | 奖励配置 | 字段名推断 | 低 |
| 20 | `RewardQuestID3` | `nRewardQuestID3` | 整数 | 任务ID | 字段名推断 | 低 |
| 21 | `RewardScore3` | `nRewardScore3` | 整数 | 奖励配置 | 字段名推断 | 低 |
| 22 | `RewardQuestID4` | `nRewardQuestID4` | 整数 | 任务ID | 字段名推断 | 低 |
| 23 | `RewardScore4` | `nRewardScore4` | 整数 | 奖励配置 | 字段名推断 | 低 |
| 24 | `MobileNameImage` | `szMobileNameImage` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 25 | `MobileNameImageBlack` | `szMobileNameImageBlack` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 26 | `RewardName1` | `szRewardName1` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 27 | `RewardImage1` | `szRewardImage1` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 28 | `RewardName2` | `szRewardName2` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 29 | `RewardImage2` | `szRewardImage2` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 30 | `RewardName3` | `szRewardName3` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 31 | `RewardImage3` | `szRewardImage3` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 32 | `RewardName4` | `szRewardName4` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 33 | `RewardImage4` | `szRewardImage4` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 34 | `dwAvatarID` | `dwAvatarID` | 整数 | 待确认 | 待确认 | 待确认 |

## DLCMainPanelMapInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwDLCID` | `dwDLCID` | 整数 | DLC/资料片ID | 字段名推断 | 低 |
| 2 | `dwMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 3 | `nQuestAchiID` | `nQuestAchiID` | 整数 | 任务ID | 字段名推断 | 低 |
| 4 | `szDungeonAchiID` | `szDungeonAchiID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `szReputationAchiID` | `szReputationAchiID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `szOtherAchiID` | `szOtherAchiID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `nTipPosX` | `nTipPosX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 8 | `nTipPosY` | `nTipPosY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 9 | `nFbJumpType` | `nFbJumpType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 10 | `nLastRecomMap` | `nLastRecomMap` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `szQuestStageNum` | `szQuestStageNum` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 12 | `szQuestStageQuestID` | `szQuestStageQuestID` | 字符串 | 任务ID | 字段名推断 | 低 |
| 13 | `szQuestStageIcon` | `szQuestStageIcon` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 14 | `szDungeonStageNum` | `szDungeonStageNum` | 字符串 | 数量/计数 | 字段名推断 | 低 |
| 15 | `szDungeonStageQuestID` | `szDungeonStageQuestID` | 字符串 | 任务ID | 字段名推断 | 低 |
| 16 | `szDungeonStageIcon` | `szDungeonStageIcon` | 字符串 | 待确认 | 待确认 | 待确认 |
| 17 | `szOtherStageNum` | `szOtherStageNum` | 字符串 | 数量/计数 | 字段名推断 | 低 |
| 18 | `szOtherStageQuestID` | `szOtherStageQuestID` | 字符串 | 任务ID | 字段名推断 | 低 |
| 19 | `szOtherStageIcon` | `szOtherStageIcon` | 字符串 | 待确认 | 待确认 | 待确认 |
| 20 | `szReputationIcon` | `szReputationIcon` | 字符串 | 待确认 | 待确认 | 待确认 |
| 21 | `szReputationID` | `szReputationID` | 字符串 | 待确认 | 待确认 | 待确认 |

## DLCQuestMapInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `DLCID` | `dwDLCID` | 整数 | DLC/资料片ID | 字段名推断 | 低 |
| 2 | `DLCMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 3 | `Name` | `szDLCMapName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `BgPath` | `szBgPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `BgFrame` | `nBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `AchievementID` | `dwAchievementID` | 整数 | 成就ID | 字段名推断 | 低 |

## Domesticate\CubAttribute.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Index` | `nIndex` | 整数 | 给翻译平台使用 | 源码注释 | 高 |
| 2 | `ID` | `szAttributeName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `Value` | `szValue` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `WillChange` | `bWillChange` | 布尔 | 待确认 | 待确认 | 待确认 |

## Domesticate\CubEmotion.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwEmotionType` | `dwEmotion` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `desc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 3 | `frame` | `nFrame` | 字符串 | 帧号 | 字段名推断 | 低 |
| 4 | `tip` | `szTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `AnimationName` | `szAnimationName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |

## Domesticate\CubInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `AdultTabIndex` | `dwAdultTabIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `Desc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |

## Domesticate\DomesticateEvent.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nEventID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `Attribute` | `nAttribute` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `IconID` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 5 | `Award` | `szAward` | 多语言文本 | 奖励配置 | 翻译列/字段名 | 中 |
| 6 | `Desc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 7 | `Soluction` | `szSolution` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## Domesticate\DomesticatePetModel.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwCubTabIndex` | `dwCubTabIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `ModelID` | `dwModelID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `ColorChannelTable` | `nColorChannelTable` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 5 | `ColorChannel` | `nColorChannel` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 6 | `ModelScale` | `fModelScale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 7 | `ModelScaleMB` | `fModelScaleMB` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 8 | `X` | `nX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 9 | `Y` | `nY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 10 | `Z` | `nZ` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `LookAtX` | `nLookAtX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `LookAtY` | `nLookAtY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `LookAtZ` | `nLookAtZ` | 整数 | 待确认 | 待确认 | 待确认 |

## Domesticate\NewHorseAttr.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Level` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `IconID` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 5 | `Gener` | `szGener` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `Type` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 7 | `bRelateFeed` | `bRelateFeed` | 布尔 | 待确认 | 待确认 | 待确认 |
| 8 | `FeedTip` | `szFeedTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `Tip` | `szTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 10 | `TuJianTip` | `szTuJianTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 11 | `bShow` | `bShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## Domesticate\RideSubDisplay.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nDetail` | `nDetail` | 整数 | 详细说明/详情 | 字段名推断 | 低 |
| 2 | `Hungry` | `szHungry` | 字符串 | 坐标/尺寸配置 | 翻译列/字段名 | 中 |
| 3 | `FullMeasure` | `szFullMeasure` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `FullMeasure1` | `szFullMeasure1` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `FullMeasureTip1` | `szFullMeasureTip1` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `FullMeasure2` | `szFullMeasure2` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `FullMeasureTip2` | `szFullMeasureTip2` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `FullMeasure3` | `szFullMeasure3` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `FullMeasureTip3` | `szFullMeasureTip3` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 10 | `MeasureCutTip` | `szMeasureCutTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 11 | `Feed` | `szFeed` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 12 | `PutFeed` | `szPutFeed` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 13 | `FeedTip` | `szFeedTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## Domesticate\ShowWord.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `CubSubType` | `nCubSubType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `FullMeasure` | `szFullMeasure` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `FullMeasureDegree1` | `nFullMeasureDegree1` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `FullMeasureDegree2` | `nFullMeasureDegree2` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `FullMeasure1` | `szFullMeasure1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `FullMeasure2` | `szFullMeasure2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `FullMeasure3` | `szFullMeasure3` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `CubText` | `szCubText` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `AdultText` | `szAdultText` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 10 | `Feed` | `szFeed` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 11 | `PutFeed` | `szPutFeed` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## Domesticate\TrolltechHorse.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nItemTabIndex` | `nItemTabIndex` | 整数 | 道具ID/索引 | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `nNoneHide` | `nNoneHide` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 5 | `nShowGrow` | `nShowGrow` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `szTip` | `szTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `szBtnTip` | `szBtnTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `szBtnDisableTip` | `szBtnDisableTip` | 字符串 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 9 | `szBtnText` | `szBtnText` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 10 | `szGrowedMsg` | `szGrowedMsg` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## DoodadTemplate.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `BarText` | `szBarText` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## DoodadTemplateType.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `CraftID` | `nCraftID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `TemplateType` | `nTemplateType` | 整数 | 类型/分类 | 字段名推断 | 低 |

## doodadtype.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwTypeID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `Desc` | `szDesc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 3 | `MinimapImageFrame` | `nMinimapImageFrame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 4 | `EffectID` | `dwEffectID` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `CursorID` | `dwCursorID` | 整数 | 待确认 | 待确认 | 待确认 |

## Drama\Drama.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 3 | `dwMetaID` | `dwMetaID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 5 | `szAuthor` | `szAuthor` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `bOpen` | `bOpen` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 7 | `nTime` | `nTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 8 | `szPath` | `szPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `szDescribe` | `szDescribe` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 10 | `szBKGD` | `szBKGD` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 11 | `szTruth` | `szTruth` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 12 | `szEnding1` | `szEnding1` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 13 | `szEnding2` | `szEnding2` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 14 | `szEnding3` | `szEnding3` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 15 | `szEnding4` | `szEnding4` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 16 | `szEnding5` | `szEnding5` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 17 | `szEnding6` | `szEnding6` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 18 | `nUploadTime` | `nUploadTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 19 | `nGold` | `nGold` | 整数 | 待确认 | 待确认 | 待确认 |
| 20 | `szType` | `szType` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 21 | `nMemberCount` | `nMemberCount` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 22 | `nUrlID` | `nUrlID` | 整数 | 链接/跳转配置 | 字段名推断 | 低 |

## Drama\DramaClue.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwDramaID` | `dwDramaID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `dwID` | `dwClueID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `dwTagID` | `dwTagID` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `szTag` | `szTag` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `szFramePath` | `szFramePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `szPicturePath` | `szPicturePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `szBackBasePath` | `szBackBasePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `szBackPopPath` | `szBackPopPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `szDesc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 11 | `szSoundPath` | `szSoundPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 12 | `bLock` | `bLock` | 布尔 | 待确认 | 待确认 | 待确认 |
| 13 | `szQuestion` | `szQuestion` | 字符串 | 任务相关配置 | 翻译列/字段名 | 中 |
| 14 | `szAnswer` | `szAnswer` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 15 | `szAttachPath` | `szAttachPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## Drama\DramaFlow.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwDramaID` | `dwDramaID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `szDesc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |

## Drama\DramaQA.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwDramaID` | `dwDramaID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `dwID` | `dwQAID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `dwType` | `dwType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `szQuestion` | `szQuestion` | 字符串 | 任务相关配置 | 翻译列/字段名 | 中 |
| 5 | `szTrueID` | `szTrueID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `szAnswer1` | `szAnswer1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `szAnswer2` | `szAnswer2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `szAnswer3` | `szAnswer3` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `szAnswer4` | `szAnswer4` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 10 | `szAnswer5` | `szAnswer5` | 字符串 | 待确认 | 待确认 | 待确认 |
| 11 | `szAnswer6` | `szAnswer6` | 字符串 | 待确认 | 待确认 | 待确认 |
| 12 | `szAnswer7` | `szAnswer7` | 字符串 | 待确认 | 待确认 | 待确认 |
| 13 | `szAnswer8` | `szAnswer8` | 字符串 | 待确认 | 待确认 | 待确认 |

## Drama\DramaRole.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwDramaID` | `dwDramaID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `dwID` | `dwRoleID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `bDMTag` | `bDMTag` | 布尔 | 待确认 | 待确认 | 待确认 |
| 5 | `szSex` | `szSex` | 字符串 | 坐标/尺寸配置 | 翻译列/字段名 | 中 |
| 6 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 7 | `szAvatarPath` | `szAvatarPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `szSpritePath` | `szSpritePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `szStory1` | `szStory1` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 10 | `szTask1` | `szTask1` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 11 | `szStroy2` | `szStory2` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 12 | `szTask2` | `szTask2` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 13 | `szStroy3` | `szStory3` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 14 | `szTask3` | `szTask3` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 15 | `szStroy4` | `szStory4` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 16 | `szTask4` | `szTask4` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 17 | `szStroy5` | `szStory5` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 18 | `szTask5` | `szTask5` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 19 | `szStroy6` | `szStory6` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 20 | `szTask6` | `szTask6` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 21 | `szStroy7` | `szStory7` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 22 | `szTask7` | `szTask7` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 23 | `szStroy8` | `szStory8` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 24 | `szTask8` | `szTask8` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 25 | `szStroy9` | `szStory9` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 26 | `szTask9` | `szTask9` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 27 | `bDefaultShow` | `bDefaultShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## DungeonExcellent.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `szImage` | `szImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 5 | `szBgImage` | `szBgImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `nBgFrame` | `nBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `szSfxPath` | `szSfxPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `szMBImage` | `szMBImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `szMBBgImage` | `szMBBgImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `szMBSfxPath` | `szMBSfxPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 11 | `nIndex（位置，越小越中间）` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 12 | `szTip` | `szTip` | 字符串 | 待确认 | 待确认 | 待确认 |

## DynamicBarSkin.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwSkinId` | `dwSkinId` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szSkinIni` | `szSkinIni` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `anchor` | `anchor` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `active` | `active` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `passive` | `passive` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `activeend` | `activeend` | 整数 | 待确认 | 待确认 | 待确认 |

## DynamicBattleRoyale.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nMapID` | `nMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 2 | `szIniPath` | `szIniPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nDefaultSkillNum` | `nDefaultSkillNum` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 4 | `nDynamicSkillNum` | `nDynamicSkillNum` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 5 | `nCanDragCount` | `nCanDragCount` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 6 | `DropSkillRemoteCall` | `DropSkillRemoteCall` | 字符串 | 技能相关配置 | 字段名推断 | 低 |
| 7 | `nDefaultSkillID1` | `nDefaultSkillID1` | 整数 | 技能ID | 字段名推断 | 低 |
| 8 | `nSkillLevel1` | `nSkillLevel1` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 9 | `nDefaultSkillID2` | `nDefaultSkillID2` | 整数 | 技能ID | 字段名推断 | 低 |
| 10 | `nSkillLevel2` | `nSkillLevel2` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 11 | `nDefaultSkillID3` | `nDefaultSkillID3` | 整数 | 技能ID | 字段名推断 | 低 |
| 12 | `nSkillLevel3` | `nSkillLevel3` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 13 | `nDefaultSkillID4` | `nDefaultSkillID4` | 整数 | 技能ID | 字段名推断 | 低 |
| 14 | `nSkillLevel4` | `nSkillLevel4` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 15 | `nDefaultSkillID5` | `nDefaultSkillID5` | 整数 | 技能ID | 字段名推断 | 低 |
| 16 | `nSkillLevel5` | `nSkillLevel5` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 17 | `nDefaultSkillID6` | `nDefaultSkillID6` | 整数 | 技能ID | 字段名推断 | 低 |
| 18 | `nSkillLevel6` | `nSkillLevel6` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 19 | `nDefaultSkillID7` | `nDefaultSkillID7` | 整数 | 技能ID | 字段名推断 | 低 |
| 20 | `nSkillLevel7` | `nSkillLevel7` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 21 | `nDefaultSkillID8` | `nDefaultSkillID8` | 整数 | 技能ID | 字段名推断 | 低 |
| 22 | `nSkillLevel8` | `nSkillLevel8` | 整数 | 技能相关配置 | 字段名推断 | 低 |

## DynamicSkill.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Group` | `dwGroup` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `CancelContent` | `szCancel` | 字符串 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 3 | `Highlight` | `bHighLight` | 布尔 | 待确认 | 待确认 | 待确认 |
| 4 | `hide` | `bHide` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 5 | `ui` | `ui` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `ani` | `ani` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `skillupdate` | `skillupdate` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 8 | `szPet` | `szPet` | 字符串 | 待确认 | 待确认 | 待确认 |
| 9 | `nFrameL` | `nFrameL` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 10 | `nFrameM` | `nFrameM` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 11 | `nFrameR` | `nFrameR` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 12 | `szLinkPath` | `szLinkPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 13 | `szDescription` | `szDescription` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 14 | `dwSkinId` | `dwSkinId` | 字符串 | 待确认 | 待确认 | 待确认 |
| 15 | `szHotkey` | `szHotkey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 16 | `TargetAutoSearchID` | `nTargetAutoSearchID` | 整数 | 目标配置 | 字段名推断 | 低 |

## DynamicSkillUI.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `name` | `name` | 字符串 | 待确认 | 待确认 | 待确认 |
| 2 | `ui` | `uifile` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `anchor` | `anchor` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `boxactive` | `active` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `boxpassive` | `passive` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `boxactiveend` | `activeend` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `autosize` | `bAutoSize` | 布尔 | 待确认 | 待确认 | 待确认 |
| 8 | `bOriginal` | `bOriginal` | 布尔 | 待确认 | 待确认 | 待确认 |

## EatingQuick\EatingQuick_Item.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwTabType` | `dwTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 4 | `szItemName` | `szItemName` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 5 | `nGroup` | `nGroup` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 6 | `szGroup` | `szGroup` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 7 | `szSlot` | `szSlot` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `szShowBuff` | `szShowBuff` | 字符串 | Buff相关配置 | 字段名推断 | 低 |
| 9 | `szKungFu` | `szKungFu` | 字符串 | 待确认 | 待确认 | 待确认 |

## EatingQuick\EatingQuick_Slot.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nSlot` | `nSlot` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nGroup` | `nGroup` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `szGroup` | `szGroup` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 4 | `szSlot` | `szSlot` | 字符串 | 待确认 | 待确认 | 待确认 |

## EmotionAction.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `id` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `command` | `szCommand` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `nIconID` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 4 | `TargetMessage` | `szTarget` | 字符串 | 目标配置 | 翻译列/字段名 | 中 |
| 5 | `NoTargetMessage` | `szNoTarget` | 字符串 | 目标配置 | 翻译列/字段名 | 中 |
| 6 | `bShow` | `bShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 7 | `bInteract` | `bInteract` | 布尔 | 待确认 | 待确认 | 待确认 |
| 8 | `dwActionID` | `dwActionID` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `nAType` | `nActionType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 10 | `bAniEdit` | `bAniEdit` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 11 | `nAniType` | `nAniType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 12 | `bEnableRecord` | `bEnableRecord` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 13 | `nAniStep` | `nAniStep` | 整数 | 开关/条件配置 | 字段名推断 | 低 |

## EmotionActionAdd.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nRoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nIconID` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 4 | `szCommand` | `szCommand` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `szTip` | `szTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `szPath` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## EmotionActionTitle.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `typeid` | `typeid` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `name` | `name` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## EmotionTitle.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `pageid` | `pageid` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `name` | `name` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `grid_w` | `grid_w` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `grid_h` | `grid_h` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `image_path` | `image_path` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `image_frame` | `image_frame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 7 | `emotionP_w` | `image_w` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 8 | `emotionP_h` | `image_h` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 9 | `mergeid` | `mergeid` | 整数 | 待确认 | 待确认 | 待确认 |

## EnchantScore.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Score` | `nScore` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `Name` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 4 | `Attribute` | `szAttribute` | 字符串 | 待确认 | 待确认 | 待确认 |

## EnchantTipShow.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `EquipmentSub` | `nEquipmentSub` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `PermanentEnchant` | `bPermanentEnchant` | 布尔 | 待确认 | 待确认 | 待确认 |
| 3 | `TemporaryEnchant` | `bTemporaryEnchant` | 布尔 | 待确认 | 待确认 | 待确认 |
| 4 | `SurvivalEnchant` | `bSurvivalEnchant` | 布尔 | 待确认 | 待确认 | 待确认 |

## EndBattle.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Type` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `LinkTip` | `szLinkTip` | 字符串 | 链接/跳转配置 | 翻译列/字段名 | 中 |

## EndOfBattleInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `LineID` | `nLineID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `NotGetExplain` | `szNotGetExplain` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `SneakExplain` | `szSneakExplain` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `BaseAwardDesc` | `szBaseAwardDesc` | 字符串 | 奖励配置 | 翻译列/字段名 | 中 |
| 6 | `ExtraAwardDesc` | `szExtraAwardDesc` | 字符串 | 奖励配置 | 翻译列/字段名 | 中 |
| 7 | `IntegralDifference1` | `szIntegralDifference1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `TitlePoint1` | `szTitlePoint1` | 字符串 | 待确认 | 待确认 | 待确认 |
| 9 | `Prestige1` | `szPrestige1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 10 | `RewardItem1` | `szRewardItem1` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 11 | `IntegralDifference2` | `szIntegralDifference2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 12 | `TitlePoint2` | `szTitlePoint2` | 字符串 | 待确认 | 待确认 | 待确认 |
| 13 | `Prestige2` | `szPrestige2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 14 | `RewardItem2` | `szRewardItem2` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 15 | `IntegralDifference3` | `szIntegralDifference3` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 16 | `TitlePoint3` | `szTitlePoint3` | 字符串 | 待确认 | 待确认 | 待确认 |
| 17 | `Prestige3` | `szPrestige3` | 字符串 | 待确认 | 待确认 | 待确认 |
| 18 | `RewardItem3` | `szRewardItem3` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 19 | `Value1` | `nValue1` | 整数 | 待确认 | 待确认 | 待确认 |
| 20 | `Value2` | `nValue2` | 整数 | 待确认 | 待确认 | 待确认 |

## equip_recommend.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `id` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `desc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 3 | `kungfu_ids` | `kungfu_ids` | 字符串 | 待确认 | 待确认 | 待确认 |

## equipdb.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TabType` | `dwTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `ID` | `nItemID` | 整数 | 道具ID | 字段名推断 | 低 |
| 3 | `Level` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 4 | `AucGenre` | `nAucType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 5 | `AucSubType` | `nAucSubType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 6 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 7 | `BelongSchool` | `nSchoolID` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `SetID` | `nSetID` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `MagicKind` | `szMagicKind` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 10 | `MagicType` | `szMagicType` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 11 | `GetType` | `szSourceType` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 12 | `PVE_PVP` | `szPvePvp` | 字符串 | 待确认 | 待确认 | 待确认 |
| 13 | `Get_Force` | `szSourceForce` | 字符串 | 势力/阵营配置 | 翻译列/字段名 | 中 |
| 14 | `Get_Desc` | `szSourceDesc` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 15 | `BelongMapID` | `szBelongMapID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 16 | `PrestigeRequire` | `szPrestigeRequire` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## equipmentrecipe.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Level` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `Desc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 4 | `IsMobile` | `bIsMobile` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## equipset.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `SetID` | `nSetID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `UIID` | `nUIID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `ReplaceUIID` | `szReplaceUIID` | 未知(R) | 待确认 | 待确认 | 待确认 |
| 4 | `Desc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |

## Explore\MapExplore.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nSubType` | `nSubType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 5 | `dwMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 6 | `nX` | `nX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `nY` | `nY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 8 | `nZ` | `nZ` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `szIconPath` | `szIconPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 11 | `fShowScale` | `fShowScale` | 浮点数 | 开关/条件配置 | 字段名推断 | 低 |
| 12 | `szUnlockData` | `szUnlockData` | 字符串 | 待确认 | 待确认 | 待确认 |
| 13 | `szFinishData` | `szFinishData` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 14 | `szRewardData` | `szRewardData` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 15 | `szTip` | `szTip` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 16 | `dwFameID` | `dwFameID` | 整数 | 待确认 | 待确认 | 待确认 |
| 17 | `nFameLevel` | `nFameLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 18 | `szPreID` | `szPreID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 19 | `szMBFrame` | `szMBFrame` | 字符串 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 20 | `bUnexploreHide` | `bUnexploredHide` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## Explore\MapExploreReward.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `dwMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 4 | `nFinishCount` | `nFinishCount` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 5 | `szReward` | `szReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 6 | `dwQuestID` | `dwQuestID` | 整数 | 任务ID | 字段名推断 | 低 |

## Explore\MapExploreType.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `szIconPath` | `szIconPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 5 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 6 | `szMBFrame` | `szMBFrame` | 字符串 | 帧号/图片帧配置 | 字段名推断 | 低 |

## ExtendActionBarData.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ActionBarName` | `szActionBarName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 2 | `Count` | `dwCount` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 3 | `Line` | `dwLine` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `Anchor` | `ui_pos` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `bNotLoadingFresh` | `bNotLoadingFresh` | 布尔 | 待确认 | 待确认 | 待确认 |
| 6 | `Param1` | `szParam1` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 7 | `Param2` | `szParam2` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 8 | `Param3` | `szParam3` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 9 | `Param4` | `szParam4` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 10 | `Param5` | `szParam5` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 11 | `Param6` | `szParam6` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 12 | `Param7` | `szParam7` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 13 | `Param8` | `szParam8` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 14 | `Param9` | `szParam9` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 15 | `Param10` | `szParam10` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 16 | `Param11` | `szParam11` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 17 | `Param12` | `szParam12` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 18 | `Param13` | `szParam13` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 19 | `Param14` | `szParam14` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 20 | `Param15` | `szParam15` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 21 | `Param16` | `szParam16` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 22 | `MobileShowInPage` | `bMobileShowInPage` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 23 | `MobileCount` | `dwMobileCount` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 24 | `MobileParam1` | `szMobileParam1` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 25 | `MobileParam2` | `szMobileParam2` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 26 | `MobileParam3` | `szMobileParam3` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 27 | `MobileParam4` | `szMobileParam4` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 28 | `MobileParam5` | `szMobileParam5` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 29 | `MobileParam6` | `szMobileParam6` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 30 | `MobileParam7` | `szMobileParam7` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 31 | `MobileParam8` | `szMobileParam8` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 32 | `MobileParam9` | `szMobileParam9` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 33 | `MobileParam10` | `szMobileParam10` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 34 | `bCanReset` | `bCanReset` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## Exterior\CanExterior.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `CanExterior` | `dwCanExterior` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 2 | `desc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |

## Exterior\CloakColorChange.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ItemType` |  | 未知 | 道具类型 | 字段名推断 | 低 |
| 2 | `ItemIndex` |  | 未知 | 道具索引 | 字段名推断 | 低 |
| 3 | `Block` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `A` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 5 | `R` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 6 | `G` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 7 | `B` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `PendentID` |  | 未知 | 待确认 | 待确认 | 待确认 |

## Exterior\CoinShop_Title.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TitleClass` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 2 | `TitleSub` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ClassName` |  | 未知 | 类型/分类 | 翻译列/字段名 | 中 |
| 4 | `Name` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `ImagePath` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `ExpandFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `CollaspeFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `TitlePath` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `TitleFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 10 | `Type` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 11 | `RewardsClass` |  | 未知 | 奖励配置 | 字段名推断 | 低 |
| 12 | `HideWhenNoItem` |  | 未知 | 道具ID/索引 | 字段名推断 | 低 |
| 13 | `ShowWhenNoStart` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 14 | `ViewType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 15 | `bShowWeapon` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 16 | `MyExterior` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 17 | `szMyExteriorClass` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 18 | `zhtw` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 19 | `ImageModShow` |  | 未知 | 图片资源配置 | 字段名推断 | 低 |
| 20 | `bCollect` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 21 | `nLabel` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 22 | `LabelStart` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 23 | `LabelEnd` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 24 | `NotShowCount` |  | 未知 | 数量/计数 | 字段名推断 | 低 |
| 25 | `StartTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 26 | `bRewardSet` |  | 未知 | 奖励配置 | 字段名推断 | 低 |

## Exterior\CoinShop_Welfare.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwDisCouponID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `szBgPath` | `szBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nBgFrame` | `nBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `szCaptionPath` | `szCaptionPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `nCaptionFrame` | `nCaptionFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `szDescription` | `szDescription` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 8 | `rgbDescription` | `szDescriptionRgb` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 9 | `rgbTime` | `szTimeRgb` | 字符串 | 时间配置 | 字段名推断 | 低 |
| 10 | `szMenuOption` | `szMenuOption` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 11 | `nIconID` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 12 | `szTipTitle` | `szTipTitle` | 字符串 | 待确认 | 待确认 | 待确认 |
| 13 | `szTipContent` | `szTipContent` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 14 | `bNotice` | `bNotice` | 布尔 | 待确认 | 待确认 | 待确认 |
| 15 | `nNoticeTitleClass` | `nNoticeTitleClass` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 16 | `nNoticeTitleSub` | `nNoticeTitleSub` | 整数 | 待确认 | 待确认 | 待确认 |

## Exterior\CoinShopScene.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Title` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `MapName` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `CameraLight` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 5 | `PrefabLight` |  | 未知 | 待确认 | 待确认 | 待确认 |

## Exterior\DisCoupon.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Desc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 3 | `BgPath` | `szBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `NormalFrame` | `nNormalFrame` | 整数 | 普通状态帧号 | 字段名推断 | 低 |
| 5 | `MouseFrame` | `nMouseFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## Exterior\ExteriorBox.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Genre` | `nGenre` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `SubGenre` | `nSubGenre` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `Set` | `nSet` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `Force` | `nForce` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 5 | `GenreName` | `szGenreName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `SubGenreName` | `szSubGenreName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `SetName` | `szSetName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `HelmID` | `nSub1` | 整数 | 头部 | 源码注释 | 高 |
| 9 | `ChestID` | `nSub2` | 整数 | 上衣 | 源码注释 | 高 |
| 10 | `BangleID` | `nSub3` | 整数 | 护手 | 源码注释 | 高 |
| 11 | `WaistID` | `nSub4` | 整数 | 腰带 | 源码注释 | 高 |
| 12 | `BootsID` | `nSub5` | 整数 | 鞋子 | 源码注释 | 高 |
| 13 | `label` | `nLabel` | 整数 | 待确认 | 待确认 | 待确认 |
| 14 | `MatchHair` | `nMatchHair` | 整数 | 待确认 | 待确认 | 待确认 |
| 15 | `Class` | `nClass` | 整数 | 类型/分类 | 字段名推断 | 低 |

## Exterior\ExteriorCollectionDB.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `CollectionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `ItemIndex` |  | 未知 | 道具索引 | 字段名推断 | 低 |
| 3 | `Name` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `GetType` |  | 未知 | 类型/分类 | 翻译列/字段名 | 中 |
| 5 | `Get_Desc` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `BelongMapID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 7 | `Get_Force` |  | 未知 | 势力/阵营配置 | 翻译列/字段名 | 中 |
| 8 | `PrestigeRequire` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## Exterior\ExteriorFilterTitle.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `nMaxFilterNum` | `nMaxFilterNum` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 4 | `szTypeClass` | `szTypeClass` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 5 | `nAppendType` | `nAppendType` | 整数 | 类型/分类 | 字段名推断 | 低 |

## Exterior\ExteriorHome.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `HomeClass` | `nClass` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `Type` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `LogicID` | `dwDetailID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `Image` | `szBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `URL` | `szURL` | 路径 | 链接/跳转配置 | 字段名推断 | 低 |

## Exterior\ExteriorSubset.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `RoleType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 2 | `nExteriorID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `SubsetName1` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `SubsetName2` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 5 | `SubsetName3` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 6 | `SubsetName4` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 7 | `SubsetName5` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `SubsetName6` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `SubsetName7` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 10 | `SubsetName8` |  | 未知 | 待确认 | 待确认 | 待确认 |

## Exterior\KungfuWeaponJump.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwKungFuID` | `dwKungFuID` | 整数 | 心法/内功ID | 字段名推断 | 低 |
| 2 | `KungFuName` | `szKungFuName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `weaponID` | `nWeaponID` | 整数 | 待确认 | 待确认 | 待确认 |

## Exterior\RecommendGoods.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `recommend_id` | `recommend_id` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `good_id` | `good_id` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `good_type` | `good_type` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `desc` | `desc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |

## Exterior\ViewLight.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `PackageIndex` |  | 未知 | 索引/排序 | 字段名推断 | 低 |
| 3 | `Type` |  | 未知 | 类型/分类 | 字段名推断 | 低 |

## Exterior\ViewReplace.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `RepresentKey` | `szRepresentKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 2 | `RepresentReplace` | `szRepresentReplace` | 字符串 | 待确认 | 待确认 | 待确认 |

## Exterior\WeaponCollectionDB.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `CollectionID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `ItemIndex` |  | 未知 | 道具索引 | 字段名推断 | 低 |
| 3 | `Name` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `GetType` |  | 未知 | 类型/分类 | 翻译列/字段名 | 中 |
| 5 | `Get_Desc` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `BelongMapID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 7 | `Get_Force` |  | 未知 | 势力/阵营配置 | 翻译列/字段名 | 中 |
| 8 | `PrestigeRequire` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## Exterior\WeaponUI.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nSubType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `szSubName` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `dwSortID` |  | 未知 | 索引/排序 | 字段名推断 | 低 |
| 5 | `Name` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `IconID` |  | 未知 | 图标ID | 字段名推断 | 低 |
| 7 | `Label` |  | 未知 | 待确认 | 待确认 | 待确认 |

## ExteriorInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szRepresentIDGroups1` | `szRepresentIDGroups1` | 字符串 | 字符串形式的表现ID映射表组成的数组；玩家自身的表现ID映射表，若完全包含其中一个，则启用之 | 源码注释 | 高 |
| 3 | `szRepresentIDGroups2` | `szRepresentIDGroups2` | 字符串 | 含义完全类似上面，大部分时候为空，非空时二者共同起作用 | 源码注释 | 高 |
| 4 | `szNotRepresentIDGroups` | `szNotRepresentIDGroups` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 5 | `BackCloakSprintSfx(-1忽视轻功披风特效，0不开启，1开启)` | `nBackCloakSprintSfx` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 6 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 7 | `IconID` | `dwIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 8 | `SkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 9 | `SkillLevel` | `dwSkillLevel` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `OnHorse` | `nOnHorse` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `RoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 12 | `Instructions` | `szInstructions` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 13 | `Des` | `szDes` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## FaceIcon.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `id` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `command` | `szCommand` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `Type` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 4 | `imgfile` | `szImageFile` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `Frame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 6 | `bShow` | `bShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 7 | `pageid` | `dwPageID` | 整数 | 待确认 | 待确认 | 待确认 |

## FaceLift\BodyBones.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `RoleType` | `szRoleType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 3 | `ClassID` | `dwClassID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `BodyType` | `nBodyType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 5 | `ClassName` | `szClassName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 6 | `BodyName` | `szBodyName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `Step` | `nStep` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `szTip` | `szTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## FaceLift\BodyCloth.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nRoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `Exterior` | `szRepresent` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `dwIconID` | `dwIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 5 | `szMobileIconPath` | `szMobileIconPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |

## FaceLift\BodyDefault.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `RoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `FilePath` | `szFilePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 5 | `Des` | `szDes` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `IsDefault` | `bDefault` | 布尔 | 待确认 | 待确认 | 待确认 |
| 7 | `CanUseInCreate` | `bCanUseInCreate` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## FaceLift\BuyBodyCountItem.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `dwGoodsID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `nCount` |  | 未知 | 数量/计数 | 字段名推断 | 低 |

## FaceLift\DecalsAdjust.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Type` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `AdjustName` | `szAdjustName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `HDValue1` | `bShowHDV1` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 4 | `SDValue1` | `bShowSDV1` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 5 | `Name1` | `szName1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `HDValue2` | `bShowHDV2` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 7 | `SDValue2` | `bShowSDV2` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 8 | `Name2` | `szName2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `HDValue3` | `bShowHDV3` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 10 | `SDValue3` | `bShowSDV3` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 11 | `Name3` | `szName3` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## FaceLift\Decoration.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `RoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `LogicID` | `nDecorationID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 5 | `Des` | `szDes` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `IconID` | `dwIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 7 | `Label` | `nLabel` | 整数 | 待确认 | 待确认 | 待确认 |

## FaceLift\DefaultMesh.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `RoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `DefaultMesh` | `szMeshPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `DefaultMtl` | `szMtlPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `LookAtX` | `look_x` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `LookAtY` | `look_y` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 6 | `LookAtZ` | `look_z` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `CamPosX` | `pos_x` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 8 | `CamPosY` | `pos_y` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 9 | `CamPosZ` | `pos_z` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FaceLift\FaceBones.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `ClassID` | `dwClassID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `BoneType` | `eBoneType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `ClassName` | `szClassName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 5 | `BoneName` | `szBoneName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `Divide` | `bDivide` | 布尔 | 待确认 | 待确认 | 待确认 |
| 7 | `Step` | `nStep` | 整数 | 待确认 | 待确认 | 待确认 |

## FaceLift\FaceDecals.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `RoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `Type` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `ShowID` | `nShowID` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 5 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 6 | `Des` | `szDes` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `IconID` | `dwIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 8 | `FlipID` | `nFlipID` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `DefaultRGBA` | `szDefaultRGBA` | 字符串 | 待确认 | 待确认 | 待确认 |
| 10 | `Label` | `nLabel` | 整数 | 待确认 | 待确认 | 待确认 |

## FaceLift\FaceDecalsClass.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `ClassID` | `nClassID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `Text` | `szText` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `LoginShow` | `bLoginShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 5 | `CoinShopShow` | `bCoinShopShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## FaceLift\FaceDefault.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `RoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `FilePath` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `Icon` | `dwIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 4 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 5 | `Des` | `szDes` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `IsDefault` | `bDefault` | 布尔 | 待确认 | 待确认 | 待确认 |
| 7 | `CanUseInCreate` | `bCanUseInCreate` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## FaceLiftV2\BuyFaceCountItem.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwGoodsID` | `dwGoodsID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `nCount` | `nCount` | 整数 | 数量/计数 | 字段名推断 | 低 |

## FaceLiftV2\DecalsAdjustExpandV2.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nRoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `Type` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 4 | `Name` | `szName` | 多语言文本 | 名称/标题文本 | 字段名推断 | 低 |

## FaceLiftV2\DecalsAdjustV2.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Type` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `AdjustName` | `szAdjustName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `bShowScroll1` | `bShowScroll1` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 4 | `Name1` | `szName1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `bShowScroll2` | `bShowScroll2` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `Name2` | `szName2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `bShowScroll3` | `bShowScroll3` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 8 | `Name3` | `szName3` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `bValueXY` | `bValueXY` | 布尔 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FaceLiftV2\DecalsAdjustV2.tab.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Type` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 2 | `AdjustName` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `bShowScroll1` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 4 | `Name1` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 5 | `bShowScroll2` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `Name2` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 7 | `bShowScroll3` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 8 | `Name3` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `bValueXY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FaceLiftV2\DecorationV2.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `RoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `Type` | `nDecorationType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `LogicID` | `nShowID` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 5 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 6 | `IconID` | `dwIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 7 | `Label` | `nLabel` | 整数 | 待确认 | 待确认 | 待确认 |

## FaceLiftV2\DefaultMesh.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `RoleType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 2 | `DefaultMesh` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `DefaultMtl` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `LookAtX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `LookAtY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 6 | `LookAtZ` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 7 | `CamPosX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 8 | `CamPosY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 9 | `CamPosZ` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FaceLiftV2\FaceAni.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nRoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `AniPath` | `szAniPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `dwIconID` | `dwIconID` | 整数 | 图标ID | 字段名推断 | 低 |

## FaceLiftV2\FaceBoneDefault.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `RoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `FilePath` | `szFilePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `Icon` | `dwIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 5 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 6 | `Des` | `szDes` | 字符串 | 待确认 | 待确认 | 待确认 |

## FaceLiftV2\FaceBonesV2.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `AreaID` | `nAreaID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `AreaName` | `szAreaName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `AreaDefault` | `szAreaDefault` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `DefaultName` | `szDefaultName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `szAreaPath` | `szAreaPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `AreaAni` | `szAreaAni` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `ClassID` | `nClassID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 9 | `ClassName` | `szClassName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 10 | `BoneType` | `nBoneType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 11 | `BoneName` | `szBoneName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 12 | `szBoneTip` | `szBoneTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 13 | `DivideName` | `szDivideName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 14 | `Step` | `nStep` | 整数 | 待确认 | 待确认 | 待确认 |

## FaceLiftV2\FaceDecalsClassV2.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `AreaID` | `nAreaID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `AreaName` | `szAreaName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `szAreaPath` | `szAreaPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `szAreaAni` | `szAreaAni` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `ClassID` | `nClassID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 7 | `szRoleType` | `szRoleType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 8 | `ClassName` | `szClassName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 9 | `SubClassID` | `nSubClassID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 10 | `SubClass` | `szSubClassName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 11 | `DecalsType` | `nDecalsType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 12 | `LoginShow` | `bLoginShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 13 | `CoinShopShow` | `bCoinShopShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## FaceLiftV2\FaceDecalsV2.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `RoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `Type` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `ShowID` | `nShowID` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 5 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 6 | `IconID` | `dwIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 7 | `DefaultRGBA` | `szDefaultRGBA` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `Label` | `nLabel` | 整数 | 待确认 | 待确认 | 待确认 |

## FaceLiftV2\FaceDecorationColorInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `RoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `Type` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `ShowID` | `nShowID` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 5 | `ColorID` | `nColorID` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 6 | `RGBA` | `szRGBA` | 字符串 | 待确认 | 待确认 | 待确认 |

## FaceLiftV2\FaceDefaultV2.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `RoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `FilePath` | `szFilePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `Icon` | `dwIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 4 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 5 | `Des` | `szDes` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `IsDefault` | `bDefault` | 布尔 | 待确认 | 待确认 | 待确认 |
| 7 | `CanUseInCreate` | `bCanUseInCreate` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## FaceMotion.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `IconID` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 4 | `dwFaceMotionID` | `dwFaceActionID` | 整数 | 待确认 | 待确认 | 待确认 |

## FameInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `dwAchievementID` | `dwAchievementID` | 整数 | 成就ID | 字段名推断 | 低 |
| 4 | `nExtPointIndex` | `nExtPointIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 5 | `nExtPointBitIndex` | `nExtPointBitIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 6 | `nExtPointLength` | `nExtPointLength` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `szMapChapter` | `szMapChapter` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `szDec` | `szDec` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `szLevelTips` | `szLevelTips` | 多语言文本 | 等级/品质 | 翻译列/字段名 | 中 |
| 10 | `szLogoPath` | `szLogoPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 11 | `nLogoFrame` | `nLogoFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 12 | `szFameBgPath` | `szFameBgPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 13 | `nFameBgFrame` | `nFameBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 14 | `nFameSelectedFrame` | `nFameSelectedFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 15 | `szLockBgPath` | `szLockBgPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 16 | `nLockBgPath` | `nLockBgPath` | 整数 | 资源/文件路径 | 字段名推断 | 低 |
| 17 | `szBgInfo` | `szBgInfo` | 字符串 | 待确认 | 待确认 | 待确认 |
| 18 | `szMapTipsInfo` | `szMapTipsInfo` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 19 | `szRewardShopInfo` | `szRewardShopInfo` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 20 | `szRewardItemInfo` | `szRewardItemInfo` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 21 | `szVKImagePath` | `szVKImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 22 | `nVKRuleId` | `nVKRuleId` | 整数 | 待确认 | 待确认 | 待确认 |

## FameTeach.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szTitle1` | `szTitle1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `szContent1` | `szContent1` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `szTitle2` | `szTitle2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `szContent2` | `szContent2` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `szTitle3` | `szTitle3` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `szContent3` | `szContent3` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `szTitle4` | `szTitle4` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `szContent4` | `szContent4` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 10 | `szTitle5` | `szTitle5` | 字符串 | 待确认 | 待确认 | 待确认 |
| 11 | `szContent5` | `szContent5` | 多语言文本 | 文本内容 | 字段名推断 | 低 |
| 12 | `szTitle6` | `szTitle6` | 字符串 | 待确认 | 待确认 | 待确认 |
| 13 | `szContent6` | `szContent6` | 多语言文本 | 文本内容 | 字段名推断 | 低 |

## FancySkatingMusic\FancySkatingInfo.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `szPressButtom` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szNodeType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nStartFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nEndFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `fPercentX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `fPercentY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FancySkatingMusic\FancySkatingMusicInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szTableName` | `szTableName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `nDifficulty` | `nDifficulty` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `szMusicName` | `szMusicName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `dwAdultFemaleAnimationID(F2)` | `dwAdultFemaleAnimationID` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `dwAdultMaleAnimationID(M2)` | `dwAdultMaleAnimationID` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `dwLittleGirlAnimationID(F1)` | `dwLittleGirlAnimationID` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `dwLittleBoyAnimationID(M1)` | `dwLittleBoyAnimationID` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `dwStrongMaleAnimationID(M3)` | `dwStrongMaleAnimationID` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `dwSexyFemaleAnimationID(F3)` | `dwSexyFemaleAnimationID` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `nMusicEndFrame` | `nMusicEndFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 12 | `nTotalScore` | `nTotalScore` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 13 | `szPressAudio` | `szPressAudio` | 字符串 | 待确认 | 待确认 | 待确认 |

## FancySkatingMusic\FuRongShuangShu_Easy.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `szPressButtom` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szNodeTYpe` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nStartFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nEndFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `fPercentX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `fPercentY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FancySkatingMusic\FuRongShuangShu_Hard.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `szPressButtom` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szNodeTYpe` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nStartFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nEndFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `fPercentX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `fPercentY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FancySkatingMusic\FuRongShuangShu_Medium.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `szPressButtom` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szNodeTYpe` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nStartFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nEndFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `fPercentX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `fPercentY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FancySkatingMusic\FuRongShuangShu_SuperEasy.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `szPressButtom` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szNodeTYpe` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nStartFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nEndFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `fPercentX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `fPercentY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FancySkatingMusic\GongFuXiongMao_Easy.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `szPressButtom` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szNodeTYpe` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nStartFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nEndFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `fPercentX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `fPercentY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FancySkatingMusic\GongFuXiongMao_Hard.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `szPressButtom` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szNodeTYpe` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nStartFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nEndFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `fPercentX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `fPercentY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FancySkatingMusic\GongFuXiongMao_Medium.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `szPressButtom` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szNodeTYpe` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nStartFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nEndFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `fPercentX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `fPercentY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FancySkatingMusic\GongFuXiongMao_SuperEasy.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `szPressButtom` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szNodeTYpe` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nStartFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nEndFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `fPercentX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `fPercentY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FancySkatingMusic\WangXiDengMi_Easy.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `szPressButtom` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szNodeTYpe` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nStartFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nEndFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `fPercentX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `fPercentY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FancySkatingMusic\WangXiDengMi_Hard.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `szPressButtom` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szNodeTYpe` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nStartFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nEndFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `fPercentX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `fPercentY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FancySkatingMusic\WangXiDengMi_Normal.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `szPressButtom` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szNodeTYpe` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nStartFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nEndFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `fPercentX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `fPercentY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FancySkatingMusic\WangXiDengMi_SuperEasy.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `szPressButtom` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szNodeTYpe` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nStartFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nEndFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `fPercentX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `fPercentY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FancySkatingMusic\WanXiangChangAn_Easy.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `szPressButtom` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szNodeTYpe` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nStartFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nEndFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `fPercentX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `fPercentY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FancySkatingMusic\WanXiangChangAn_Medium.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `szPressButtom` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szNodeTYpe` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nStartFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nEndFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `fPercentX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `fPercentY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FancySkatingMusic\WanXiangChangAn_Normal.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `szPressButtom` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szNodeTYpe` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nStartFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nEndFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `fPercentX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `fPercentY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FancySkatingMusic\WanXiangChangAn_SuperEasy.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `szPressButtom` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szNodeTYpe` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nStartFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nEndFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `fPercentX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `fPercentY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FancySkatingMusic\XiaZheChengGe_Hard.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `szPressButtom` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szNodeTYpe` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nStartFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nEndFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `fPercentX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `fPercentY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FancySkatingMusic\XiaZheChengGe_Medium.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `szPressButtom` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szNodeTYpe` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nStartFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nEndFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `fPercentX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `fPercentY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FancySkatingMusic\XiaZheChengGe_Normal.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `szPressButtom` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szNodeTYpe` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nStartFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nEndFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `fPercentX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `fPercentY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FancySkatingMusic\XiaZheChengGe_SuperEasy.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `szPressButtom` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szNodeTYpe` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nStartFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nEndFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `fPercentX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `fPercentY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FBCDBossImage.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `BossNpcID` | `dwNpcID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `_MapID` | `_dwMapID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `BossPath` | `szAvatarPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `BossFrame` | `nAvatarFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## FBCountDown.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `IniType` | `nIniType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `Side` | `szSide` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `OffsetX` | `fOffsetX` | 浮点数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `OffsetY` | `fOffsetY` | 浮点数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 6 | `Left_Right` | `bLeft_Right` | 布尔 | 待确认 | 待确认 | 待确认 |
| 7 | `Title` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 8 | `Tip` | `szTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `bIsSceneCloseType` | `bIsSceneCloseType` | 布尔 | 目前移动端用，是否是场景关闭倒计时类型（默认触发，不会跳转选中） | 源码注释 | 高 |

## FBCountNum.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `IniType` | `nIniType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `Side` | `szSide` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `OffsetX` | `fOffsetX` | 浮点数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `OffsetY` | `fOffsetY` | 浮点数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 6 | `Type` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 7 | `Title` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 8 | `ImgPath` | `szImgPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `ImgFrame` | `nImgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 10 | `szTip` | `szTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## FeedItemList.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTabType` | `dwTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `bShop` | `bShop` | 布尔 | 待确认 | 待确认 | 待确认 |
| 4 | `dwGroup` | `dwGroup` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 5 | `dwShopID` | `dwShopID` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `nPage` | `nPage` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `nPriority` | `nPriority` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |

## FellowPet.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `FellowPetIndex` | `dwPetIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `NamePath` | `szNamePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `NameFrame` | `nNameFrame` | 整数 | 名称图片帧号 | 字段名推断 | 低 |
| 5 | `Level` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 6 | `Quality` | `nQuality` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 7 | `Class` | `nClass` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 8 | `Star` | `nStar` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `Type` | `szTypeList` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 10 | `Source` | `szSourceList` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 11 | `ForceID` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 12 | `GainDifficulty` | `nGainDifficulty` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `BgPath` | `szBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 14 | `OutputDes` | `szOutputDes` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 15 | `Desc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 16 | `Show` | `bShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 17 | `OnlyHaveShow` | `bOnlyHaveShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 18 | `LimitTime` | `bLimitTime` | 布尔 | 时间配置 | 字段名推断 | 低 |
| 19 | `ModelID` | `dwModelID` | 整数 | 待确认 | 待确认 | 待确认 |
| 20 | `ColorChannelTable` | `nColorChannelTable` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 21 | `ColorChannel` | `nColorChannel` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 22 | `ModelScale` | `fModelScale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 23 | `ModelScaleMB` | `fModelScaleMB` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 24 | `IconID` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 25 | `X` | `nX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 26 | `Y` | `nY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 27 | `Z` | `nZ` | 整数 | 待确认 | 待确认 | 待确认 |
| 28 | `LookAtX` | `nLookAtX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 29 | `LookAtY` | `nLookAtY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 30 | `LookAtZ` | `nLookAtZ` | 整数 | 待确认 | 待确认 | 待确认 |
| 31 | `CoinShopScale` | `fCoinShopScale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 32 | `CoinShopPosY` | `nCoinShopPosY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 33 | `IdentityYS` | `bIdentityYS` | 布尔 | 待确认 | 待确认 | 待确认 |
| 34 | `YSDes` | `szYSDes` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 35 | `nMapID` | `nMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 36 | `nMapX` | `nMapX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 37 | `nMapY` | `nMapY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 38 | `nMapZ` | `nMapZ` | 整数 | 待确认 | 待确认 | 待确认 |
| 39 | `szTip` | `szTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 40 | `LinkID` | `nLinkID` | 整数 | 链接/跳转配置 | 字段名推断 | 低 |
| 41 | `MobileCoinShopScale` | `fMobileCoinShopScale` | 浮点数 | 待确认 | 待确认 | 待确认 |

## FellowPetAchievement.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `AchiveName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `StartScore` | `nStartScore` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `EndScore` | `nEndScore` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `ImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `Frame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 7 | `szTitleImagePath` | `szTitleImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## FellowPetClass.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `ClassName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `Frame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## FellowPetMedal.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Index` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 3 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `IconID` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 5 | `ForceID` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 6 | `NotOpen` | `bNotOpen` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 7 | `Des` | `szDes` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `Reward` | `szReward` | 多语言文本 | 奖励配置 | 翻译列/字段名 | 中 |

## FellowPetSearch.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `TypeName` | `szTypeName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 3 | `Type` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |

## FellowPetSkill.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `FellowPetID` | `dwPetIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `SkillID1` | `nSkillID1` | 整数 | 技能ID | 字段名推断 | 低 |
| 3 | `Level1` | `nLevel1` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 4 | `SkillID2` | `nSkillID2` | 整数 | 技能ID | 字段名推断 | 低 |
| 5 | `Level2` | `nLevel2` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 6 | `SkillID3` | `nSkillID3` | 整数 | 技能ID | 字段名推断 | 低 |
| 7 | `Level3` | `nLevel3` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 8 | `SkillID4` | `nSkillID4` | 整数 | 技能ID | 字段名推断 | 低 |
| 9 | `Level4` | `nLevel4` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 10 | `SkillID5` | `nSkillID5` | 整数 | 技能ID | 字段名推断 | 低 |
| 11 | `Level5` | `nLevel5` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 12 | `SkillID6` | `nSkillID6` | 整数 | 技能ID | 字段名推断 | 低 |
| 13 | `Level6` | `nLevel6` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 14 | `SkillID7` | `nSkillID7` | 整数 | 技能ID | 字段名推断 | 低 |
| 15 | `Level7` | `nLevel7` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 16 | `SkillID8` | `nSkillID8` | 整数 | 技能ID | 字段名推断 | 低 |
| 17 | `Level8` | `nLevel8` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 18 | `SkillID9` | `nSkillID9` | 整数 | 技能ID | 字段名推断 | 低 |
| 19 | `Level9` | `nLevel9` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 20 | `SkillID10` | `nSkillID10` | 整数 | 技能ID | 字段名推断 | 低 |
| 21 | `Level10` | `nLevel10` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 22 | `SkillID11` | `nSkillID11` | 整数 | 技能ID | 字段名推断 | 低 |
| 23 | `Level11` | `nLevel11` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 24 | `SkillID12` | `nSkillID12` | 整数 | 技能ID | 字段名推断 | 低 |
| 25 | `Level12` | `nLevel12` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 26 | `SkillID13` | `nSkillID13` | 整数 | 技能ID | 字段名推断 | 低 |
| 27 | `Level13` | `nLevel13` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 28 | `SkillID14` | `nSkillID14` | 整数 | 技能ID | 字段名推断 | 低 |
| 29 | `Level14` | `nLevel14` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 30 | `SkillID15` | `nSkillID15` | 整数 | 技能ID | 字段名推断 | 低 |
| 31 | `Level15` | `nLevel15` | 整数 | 等级/品质 | 字段名推断 | 低 |

## FellowPetSort.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szSortRule` | `szSortRule` | 字符串 | 索引/排序 | 翻译列/字段名 | 中 |

## FengCeJiFen.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nGenre` | `nGenre` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `nDetail` | `nDetail` | 整数 | 详细说明/详情 | 字段名推断 | 低 |
| 4 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 5 | `nClose` | `nClose` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `nFroceID` | `nForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 7 | `szGenreName` | `szGenreName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `szDetailDesc` | `szDetailDesc` | 字符串 | 详细描述文本 | 翻译列/字段名 | 中 |
| 9 | `nDetailIconID` | `nDetailIconID` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `szDetailName` | `szDetailName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 11 | `szIndexName` | `szIndexName` | 字符串 | 索引/排序 | 翻译列/字段名 | 中 |
| 12 | `nIndexJiFen` | `nIndexJiFen` | 整数 | 索引/排序 | 字段名推断 | 低 |

## FilterAtmosphere.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nMapID` | `nMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 2 | `szTime` | `szTime` | 字符串 | 时间配置 | 字段名推断 | 低 |
| 3 | `szWeather` | `szWeather` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `szEnvPreset` | `szEnvPreset` | 路径 | 待确认 | 待确认 | 待确认 |

## FilterAtmosphereOption.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szTime` | `szTime` | 字符串 | 时间配置 | 字段名推断 | 低 |
| 3 | `szImgNormalPath` | `szImgNormalPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nNormalFrame` | `nNormalFrame` | 整数 | 普通状态帧号 | 字段名推断 | 低 |
| 5 | `szImgOverPath` | `szImgOverPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `nOverFrame` | `nOverFrame` | 整数 | 悬停/经过状态帧号 | 字段名推断 | 低 |
| 7 | `szImgSelPath` | `szImgSelPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `nSelFrame` | `nSelFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 9 | `szImgDisablePath` | `szImgDisablePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `nDisableFrame` | `nDisableFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## FilterColorParamSetting.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nColorID` | `nColorID` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 2 | `nColorClass` | `nColorClass` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 3 | `nR` | `nR` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `nG` | `nG` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `nB` | `nB` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `szImgBgPath1` | `szImgBgPath1` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `nFrame1` | `nFrame1` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `szImgBgPath2` | `szImgBgPath2` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `nFrame2` | `nFrame2` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 10 | `szImgBgPath3` | `szImgBgPath3` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 11 | `nFrame4` | `nFrame3` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## FilterInviteMsg.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szImagePath` | `szImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## FilterSetting.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nParamID` | `nParamID` | 整数 | 脚本/参数配置 | 字段名推断 | 低 |
| 2 | `nClass` | `nClass` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nSub` | `nSub` | 整数 | 二级分类/子类ID | 字段名推断 | 低 |
| 4 | `nColorClass` | `nColorClass` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 5 | `szTitleName` | `szTitleName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `szOptionName` | `szOptionName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `nDecimal` | `nDecimal` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `nMinValue` | `nMinValue` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `nMaxValue` | `nMaxValue` | 整数 | 待确认 | 待确认 | 待确认 |

## FireBookInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nWeekDay` | `nWeekDay` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 2 | `nHour` | `nHour` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `nMinute` | `nMinute` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `nBook` | `nBook` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `bOreadySel` | `bOreadySel` | 布尔 | 待确认 | 待确认 | 待确认 |
| 6 | `bMineSel` | `bMineSel` | 布尔 | 待确认 | 待确认 | 待确认 |
| 7 | `bSpecial` | `bSpecial` | 布尔 | 待确认 | 待确认 | 待确认 |
| 8 | `nFireCount1` | `nFireCount1` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 9 | `nFireCount2` | `nFireCount2` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 10 | `nFireCount3` | `nFireCount3` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 11 | `nFireCount4` | `nFireCount4` | 整数 | 数量/计数 | 字段名推断 | 低 |

## FireBookSpecialInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nTime` | `nTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 2 | `TimeTip` | `szTimeTip` | 字符串 | 时间配置 | 翻译列/字段名 | 中 |
| 3 | `nFireCount1` | `nFireCount1` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 4 | `nFireCount2` | `nFireCount2` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 5 | `nFireCount3` | `nFireCount3` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 6 | `nFireCount4` | `nFireCount4` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 7 | `szHolidays` | `szHolidays` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `szTip` | `szTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## FireBookType.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nTypeID` | `nTypeID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `szTypeName` | `szTypeName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |

## FirstLoginSkill.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `KungfuIndex` | `dwKungfuID` | 整数 | 心法/内功ID | 字段名推断 | 低 |
| 2 | `SkillID1` | `dwSkillID1` | 整数 | 技能ID | 字段名推断 | 低 |
| 3 | `SkillID2` | `dwSkillID2` | 整数 | 技能ID | 字段名推断 | 低 |
| 4 | `SkillID3` | `dwSkillID3` | 整数 | 技能ID | 字段名推断 | 低 |
| 5 | `SkillID4` | `dwSkillID4` | 整数 | 技能ID | 字段名推断 | 低 |
| 6 | `SkillID5` | `dwSkillID5` | 整数 | 技能ID | 字段名推断 | 低 |
| 7 | `SkillID6` | `dwSkillID6` | 整数 | 技能ID | 字段名推断 | 低 |
| 8 | `SkillID7` | `dwSkillID7` | 整数 | 技能ID | 字段名推断 | 低 |
| 9 | `SkillID8` | `dwSkillID8` | 整数 | 技能ID | 字段名推断 | 低 |
| 10 | `SkillID9` | `dwSkillID9` | 整数 | 技能ID | 字段名推断 | 低 |
| 11 | `SkillID10` | `dwSkillID10` | 整数 | 技能ID | 字段名推断 | 低 |
| 12 | `SkillID11` | `dwSkillID11` | 整数 | 技能ID | 字段名推断 | 低 |
| 13 | `SkillID12` | `dwSkillID12` | 整数 | 技能ID | 字段名推断 | 低 |
| 14 | `SkillID13` | `dwSkillID13` | 整数 | 技能ID | 字段名推断 | 低 |
| 15 | `SkillID14` | `dwSkillID14` | 整数 | 技能ID | 字段名推断 | 低 |
| 16 | `SkillID15` | `dwSkillID15` | 整数 | 技能ID | 字段名推断 | 低 |
| 17 | `SkillID16` | `dwSkillID16` | 整数 | 技能ID | 字段名推断 | 低 |

## Force_small_icon.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ForceID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `Path` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `Frame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## ForceID_MiniAvatarID.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ForceID` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 2 | `MiniAvatarID` | `dwMiniAvatarID` | 整数 | 待确认 | 待确认 | 待确认 |

## ForceUI.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `force_id` | `force_id` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 2 | `name` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `fullname` | `szFullName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `fight_stat_color_image 战斗统计势力颜色` | `fight_state_image` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 5 | `fight_stat_color_img_frame 战斗统计势力颜色` | `fight_state_img_Frame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `raid_color_image 团队势力颜色` | `raid_color_image` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 7 | `raid_color_img_frame` | `raid_color_img_frame` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 8 | `target_avatar_image 目标头像图素` | `target_avatar_image` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 9 | `target_avatar_img_frame` | `target_avatar_img_frame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 10 | `force_avatar_tga(小头像选择面板头像)` | `avatar_tga` | 路径 | 待确认 | 待确认 | 待确认 |
| 11 | `addon_stat_color` | `addon_fight_color` | 字符串 | 颜色配置 | 字段名推断 | 低 |

## FriendPreference.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `id` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Type` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 3 | `dwType` | `dwType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `SubType` | `szSubType` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 5 | `dwSubTpye` | `dwSubType` | 整数 | 类型/分类 | 翻译列/字段名 | 中 |
| 6 | `Show` | `bShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 7 | `Message` | `szMessage` | 字符串 | 提示消息文本 | 翻译列/字段名 | 中 |

## friendrank.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `key` | `key` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 2 | `name` | `name` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `ascend` | `ascend` | 布尔 | 待确认 | 待确认 | 待确认 |
| 4 | `main_type` | `main_key` | 字符串 | 坐标/尺寸配置 | 翻译列/字段名 | 中 |
| 5 | `image` | `image` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 6 | `image_frame_nor` | `image_frame_nor` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 7 | `image_frame_norl(正常高亮)` | `image_frame_norl` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 8 | `image_frame_gray` | `image_frame_gray` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 9 | `image_frame_grayl(灰色高亮)` | `image_frame_grayl` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 10 | `big_image` | `big_image` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 11 | `big_image_frame` | `big_image_frame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 12 | `desc` | `desc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 13 | `effort_rank` | `effort_rank` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 14 | `effort_desc` | `effort_desc` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## FriendSkin.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `ImgSocialBgPath` | `szImgSocialBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `ImgSocialBgFrame` | `nImgSocialBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `ImgFriendTipPath` | `szImgFriendTipPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `ImgFriendTipFrame` | `nImgFriendTipFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `ImgVisitCardPath` | `szImgVisitCardPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `ImgVisitCardFrame` | `nImgVisitCardFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 9 | `ImgVisitCardSmallPath` | `szImgVisitCardSmallPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `ImgVisitCardSmallFrame` | `nImgVisitCardSmallFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 11 | `szType` | `szTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 12 | `szSource` | `szSource` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## FullScreenScene\FullScreenCamera.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwCamID` | `dwCamID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szRemark` | `szRemark` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `szPos` | `szPos` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `szLookAt` | `szLookAt` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `fRoleYaw` | `fRoleYaw` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 6 | `szCenter` | `szCenter` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `szRadius` | `szRadius` | 字符串 | 待确认 | 待确认 | 待确认 |

## FullScreenScene\FullScreenScene.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szScene` | `szScene` | 路径 | 待确认 | 待确认 | 待确认 |
| 3 | `MapName` | `szMapName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `CameraLight` | `szCameraLight` | 路径 | 待确认 | 待确认 | 待确认 |
| 5 | `szPrefabPos` | `szPrefabPos` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 6 | `szPrefab` | `szPrefab` | 路径 | 待确认 | 待确认 | 待确认 |
| 7 | `fPrefabScale` | `fPrefabScale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 8 | `szProfabEulerRotation` | `szProfabEulerRotation` | 字符串 | 待确认 | 待确认 | 待确认 |
| 9 | `szHorAngle` | `szHorAngle` | 字符串 | 待确认 | 待确认 | 待确认 |
| 10 | `szVerAngle` | `szVerAngle` | 字符串 | 待确认 | 待确认 | 待确认 |
| 11 | `szRolePos` | `szRolePos` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `dwStandareMaleCamID` | `dwStandareMaleCamID` | 整数 | 待确认 | 待确认 | 待确认 |
| 13 | `dwStandareFemaleCamID` | `dwStandareFemaleCamID` | 整数 | 待确认 | 待确认 | 待确认 |
| 14 | `dwStrongMaleCamID` | `dwStrongMaleCamID` | 整数 | 待确认 | 待确认 | 待确认 |
| 15 | `dwSexyFemaleCamID` | `dwSexyFemaleCamID` | 整数 | 待确认 | 待确认 | 待确认 |
| 16 | `dwLittleBoyCamID` | `dwLittleBoyCamID` | 整数 | 待确认 | 待确认 | 待确认 |
| 17 | `dwLittleGirlCamID` | `dwLittleGirlCamID` | 整数 | 待确认 | 待确认 | 待确认 |
| 18 | `szRidePos` | `szRidePos` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 19 | `dwRideCamID` | `dwRideCamID` | 整数 | 待确认 | 待确认 | 待确认 |
| 20 | `fRideScale` | `fRideScale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 21 | `szSinglePendantPos` | `szSinglePendantPos` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 22 | `dwSinglePendantCamID` | `dwSinglePendantCamID` | 整数 | 待确认 | 待确认 | 待确认 |
| 23 | `fSinglePendantScale` | `fSinglePendantScale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 24 | `dwStandareMaleHairCamID` | `dwStandareMaleHairCamID` | 整数 | 待确认 | 待确认 | 待确认 |
| 25 | `dwStandareFemaleHairCamID` | `dwStandareFemaleHairCamID` | 整数 | 待确认 | 待确认 | 待确认 |
| 26 | `dwStrongMaleHairCamID` | `dwStrongMaleHairCamID` | 整数 | 待确认 | 待确认 | 待确认 |
| 27 | `dwSexyFemaleHairCamID` | `dwSexyFemaleHairCamID` | 整数 | 待确认 | 待确认 | 待确认 |
| 28 | `dwLittleBoyHairCamID` | `dwLittleBoyHairCamID` | 整数 | 待确认 | 待确认 | 待确认 |
| 29 | `dwLittleGirlHairCamID` | `dwLittleGirlHairCamID` | 整数 | 待确认 | 待确认 | 待确认 |

## FullScreenScene\RolePendantPreview.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nSub` | `nSub` | 整数 | 二级分类/子类ID | 字段名推断 | 低 |
| 2 | `nDetail` | `nDetail` | 整数 | 详细说明/详情 | 字段名推断 | 低 |
| 3 | `nRoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `dwCamID` | `dwCamID` | 整数 | 待确认 | 待确认 | 待确认 |

## FullScreenScene\SpecialItemPreview.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `szType` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 4 | `dwCamID` | `dwCamID` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `fScale` | `fScale` | 浮点数 | 待确认 | 待确认 | 待确认 |

## FullScreenSFXInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `szKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 2 | `szName` | `szSFXName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `szSFXPath` | `szSFXPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `szPath` | `szPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `szMobilePath` | `szMobilePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `x` | `nX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `y` | `nY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 8 | `Scaling` | `fScaling` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 9 | `nLayer` | `nLayer` | 整数 | 待确认 | 待确认 | 待确认 |

## FullScreenShopBtn.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szPath` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `szVKPath` | `szVKPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nNormal` | `nNormal` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `nMouseOver` | `nMouseOver` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `nMouseDown` | `nMouseDown` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 7 | `nDisable` | `nDisable` | 整数 | 开关/条件配置 | 字段名推断 | 低 |

## FullScreenShopCBox.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szPath` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `szVKNormalPath` | `szVKNormalPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `szVKSelectedPath` | `szVKSelectedPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `nUncheckedAndEnabled` | `nUncheckedAndEnabled` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `nCheckedAndEnabled` | `nCheckedAndEnabled` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 7 | `nUncheckedAndDisabled` | `nUncheckedAndDisabled` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 8 | `nCheckedAndDisabled` | `nCheckedAndDisabled` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 9 | `nChecking` | `nChecking` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `nUnchecking` | `nUnchecking` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `nCheckedAndEnabledWhenMouseOver` | `nCheckedAndEnabledWhenMouseOver` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 12 | `nUncheckedAndEnabledWhenMouseOver` | `nUncheckedAndEnabledWhenMouseOver` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 13 | `nCheckedAndDisabledWhenMouseOver` | `nCheckedAndDisabledWhenMouseOver` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 14 | `nUncheckedAndDisabledWhenMouseOver` | `nUncheckedAndDisabledWhenMouseOver` | 整数 | 开关/条件配置 | 字段名推断 | 低 |

## FullScreenShopPic.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nItemType` | `nItemType` | 整数 | 道具类型 | 字段名推断 | 低 |
| 2 | `nItemIndex` | `nItemIndex` | 整数 | 道具索引 | 字段名推断 | 低 |
| 3 | `szPath` | `szPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `szPngPath` | `szPngPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## FullScreenShopSkin.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nSkinID` | `nSkinID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szBgPath` | `szBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `szVKBgPath` | `szVKBgPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `szTitleInfo` | `szTitleInfo` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `szLogoInfo` | `szLogoInfo` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `ShopCloseAnimation` | `ShopCloseAnimation` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 7 | `ShopMenuAnimation` | `ShopMenuAnimation` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `ShopCBoxAnimation` | `ShopCBoxAnimation` | 字符串 | 待确认 | 待确认 | 待确认 |
| 9 | `ShopBuyAnimation` | `ShopBuyAnimation` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `ShopLeftAnimation` | `ShopLeftAnimation` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `ShopRightAnimation` | `ShopRightAnimation` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `ShopStepAnimation` | `ShopStepAnimation` | 整数 | 待确认 | 待确认 | 待确认 |
| 13 | `nScene` | `nScene` | 整数 | 待确认 | 待确认 | 待确认 |

## GameGuide.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `nClass1` | `nClass1` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nClass2` | `nClass2` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 5 | `szPeopleNum` | `szPeopleNum` | 字符串 | 数量/计数 | 字段名推断 | 低 |
| 6 | `szDifficult` | `szDifficulty` | 字符串 | 坐标/尺寸配置 | 翻译列/字段名 | 中 |
| 7 | `dwMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 8 | `dwQuestID` | `dwQuestID` | 整数 | 任务ID | 字段名推断 | 低 |
| 9 | `szTime` | `szTimeDesc` | 字符串 | 时间配置 | 翻译列/字段名 | 中 |
| 10 | `szQueue` | `szQueueDesc` | 字符串 | 待确认 | 待确认 | 待确认 |
| 11 | `szActivityID` | `szActivity` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `szFunction` | `szFunction` | 字符串 | 待确认 | 待确认 | 待确认 |
| 13 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 14 | `nMinLevel` | `nMinLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 15 | `nMaxLevel` | `nMaxLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 16 | `nLockLevel` | `nLockLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 17 | `nIconFrame` | `nIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 18 | `nTagFrame` | `nTagFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 19 | `szLink` | `szLink` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 20 | `bAlwaysDisplay` | `bAlwaysDisplay` | 布尔 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 21 | `szMobileTags` | `szMobileTags` | 字符串 | 待确认 | 待确认 | 待确认 |
| 22 | `szMobileDifficulty` | `szMobileDifficulty` | 字符串 | 坐标/尺寸配置 | 翻译列/字段名 | 中 |
| 23 | `szMobileFunction` | `szMobileFunction` | 字符串 | 待确认 | 待确认 | 待确认 |
| 24 | `szLockFunction` | `szLockFunction` | 字符串 | 待确认 | 待确认 | 待确认 |
| 25 | `szLockDesc` | `szLockDesc` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 26 | `szReward` | `szReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 27 | `szMobileHelpID` | `szMobileHelpID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 28 | `szAppointmentID` | `szAppointmentID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 29 | `nPriority` | `nPriority` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |

## GameGuideDailyQuest.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `szTypeName` | `szTypeName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 4 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 5 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 6 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 7 | `szLink` | `szLink` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 8 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `szImageBgPath` | `szImageBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `bSimpleQuest` | `bSimpleQuest` | 布尔 | 任务相关配置 | 字段名推断 | 低 |
| 11 | `szMobileFunction` | `szMobileFunction` | 字符串 | 待确认 | 待确认 | 待确认 |
| 12 | `szReward` | `szReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |

## GameGuideDailyReward.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `szReward` | `szReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |

## GameTeach.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 字段名推断 | 低 |
| 3 | `nGameID` | `nGameID` | 整数 | 待确认 | 待确认 | 待确认 |

## GameTeachDetail.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `nSub` | `nSub` | 整数 | 二级分类/子类ID | 字段名推断 | 低 |
| 3 | `nGameID` | `nGameID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 5 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `szDesc` | `szDesc` | 多语言文本 | 描述文本 | 字段名推断 | 低 |

## GasConfig.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwMKungfuID` | `dwMKungfuID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `dwTemplateID` | `dwTemplateID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `dwSkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |

## GeneralCounterSFX.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Side` | `szSide` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `OffsetX` | `fOffsetX` | 浮点数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `OffsetY` | `fOffsetY` | 浮点数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `ImageTitlePath` | `szImageTitle` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 6 | `Frame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 7 | `NumSFXPath` | `szNumSFXPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `szIniName` | `szIniName` | 字符串 | 待确认 | 待确认 | 待确认 |

## GetNew.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szInfo` | `szInfo` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `nItemType` | `nItemType` | 整数 | 道具类型 | 字段名推断 | 低 |
| 4 | `nItemID` | `nItemID` | 整数 | 道具ID | 字段名推断 | 低 |
| 5 | `szOpenFunction` | `szOpenFunction` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |

## GoldTeamAddPrice.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nPrice` | `nPrice` | 整数 | 待确认 | 待确认 | 待确认 |

## GoldTeamBoss.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `NpcID` | `dwNpcID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `BossName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |

## GoldTeamMatchName.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |

## GoldTeamNeed.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nItemType` | `nItemType` | 整数 | 道具类型 | 字段名推断 | 低 |
| 2 | `nItemID` | `nItemID` | 整数 | 道具ID | 字段名推断 | 低 |
| 3 | `KungfuIDS` | `szKungfuIDs` | 字符串 | 待确认 | 待确认 | 待确认 |

## GooseDuckKill\Identity.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nRoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `szKey` | `szKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 4 | `szPower` | `szPower` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `szGoal` | `szGoal` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `szBarBg` | `szBarBg` | 路径 | 待确认 | 待确认 | 待确认 |
| 7 | `nBarFrame` | `nBarFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `szBarBgVKPath` | `szBarBgVKPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## GrowthEquipLevel.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTabType` | `dwTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 4 | `nMaxLevel` | `nMaxLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |

## GuildCastleWarBoss.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `dwBossID` | `dwBossID` | 整数 | 首领ID | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `nPoints` | `nPoints` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `szAvatarPath` | `szAvatarPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `nAvatarFrame` | `nAvatarFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## GuilderTask.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 3 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 4 | `nPoints` | `nPoints` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `szImgBgPath` | `szImgBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## GuildLeagueMatchesAwards.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `szGetFrameName` | `szGetFrameName` | 字符串 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 2 | `szBoxFrameName` | `szBoxFrameName` | 字符串 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 3 | `nBuffID` | `nBuffID` | 整数 | Buff ID | 字段名推断 | 低 |
| 4 | `szValueName` | `szValueName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `nRequireNum` | `nRequireNum` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 6 | `bEqual` | `bEqual` | 布尔 | 待确认 | 待确认 | 待确认 |
| 7 | `szReward` | `szReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |

## H5HostConfig.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `szKey` | `szKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 2 | `szComment` | `szComment` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `szIniFile` | `szIniFile` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `szUrl` | `szUrl` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 5 | `nRemoteDataID` | `nRemoteDataID` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `szEvent` | `szEvent` | 字符串 | 待确认 | 待确认 | 待确认 |

## hairshop\DyeingDecorationColor.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `colorID` | `dwColorID` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 2 | `R` | `nR` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `G` | `nG` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `B` | `nB` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `TipItemType` | `nTipItemType` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 6 | `TipItemIndex` | `nTipItemIndex` | 整数 | 道具ID/索引 | 字段名推断 | 低 |

## hairshop\DyeingHairColor.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `colorID` | `dwColorID` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 2 | `CostType` | `dwCostType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `CostTypeName` | `szCostTypeName` | 多语言文本 | 类型/分类 | 字段名推断 | 低 |
| 4 | `R` | `nR` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `G` | `nG` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `B` | `nB` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `TipItemType` | `nTipItemType` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 8 | `TipItemIndex` | `nTipItemIndex` | 整数 | 道具ID/索引 | 字段名推断 | 低 |

## hairshop\DyeingItemSell.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `CostType` | `dwCostType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `ItemType` | `dwItemType` | 整数 | 道具类型 | 字段名推断 | 低 |
| 3 | `ItemIndex` | `dwItemIndex` | 整数 | 道具索引 | 字段名推断 | 低 |

## hairshop\hairshop_f1.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `RepresentID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `Label` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `showtype` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 5 | `hairname` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## hairshop\hairshop_f2.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `RepresentID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `Label` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `showtype` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 5 | `hairname` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## hairshop\hairshop_m1.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `RepresentID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `Label` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `showtype` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 5 | `hairname` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## hairshop\hairshop_m2.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `RepresentID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `Label` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `showtype` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 5 | `hairname` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## hairshop\HairSubset.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `RoleType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 2 | `nHairID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `SubsetName1` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `SubsetName2` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 5 | `SubsetName3` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 6 | `SubsetName4` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 7 | `SubsetName5` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `SubsetName6` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `SubsetName7` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 10 | `SubsetName8` |  | 未知 | 待确认 | 待确认 | 待确认 |

## hairshop\head_hair.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `HeadID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `Bang` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 3 | `Plait` |  | 未知 | 待确认 | 待确认 | 待确认 |

## hairshop\re_head_index.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `HeadformID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `BangID` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 3 | `PlaitID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `HeadID` |  | 未知 | 待确认 | 待确认 | 待确认 |

## HeatMapArea.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 2 | `nPQID` | `nPQID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szRegionPoint` | `szRegionPoint` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `nRegionWidth` | `nRegionW` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `nRegionHeight` | `nRegionH` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 7 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 8 | `nOffsetX` | `nOffsetX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 9 | `nOffsetY` | `nOffsetY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |

## HelpSoundTip.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |

## HLIdentity\GetFish.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `nQuality` | `nQuality` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 4 | `dwIconID` | `dwIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 5 | `szPath` | `szPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 7 | `szRegion` | `szRegion` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `szUse` | `szUse` | 字符串 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 9 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 10 | `nMoney` | `nMoney` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 11 | `nMeat` | `nMeat` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `nArchitecture` | `nArchitecture` | 整数 | 待确认 | 待确认 | 待确认 |
| 13 | `nFishType` | `nFishType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 14 | `nIdenLv` | `nIdenLv` | 整数 | 待确认 | 待确认 | 待确认 |
| 15 | `bHideBook` | `bHideBook` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## HLIdentity\HLCookFood.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwItemType` | `dwItemType` | 整数 | 道具类型 | 字段名推断 | 低 |
| 3 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |

## HLIdentity\HLCookFoodMap.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 4 | `dwPackageIndex` | `dwPackageIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |

## HLIdentity\HLIdentity.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szBasePriority` | `szBasePriority` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `szExtPriority` | `szExtPriority` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `szAbility` | `szAbility` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 6 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `szBgImgPath` | `szBgImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `szIconPath` | `szIconPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `szExpTip` | `szExpTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## HLIdentity\HLIdentityPriority.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 6 | `szReward` | `szReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 7 | `nIconID` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 8 | `szDesc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 9 | `szDescMB` | `szDescMB` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 10 | `szLockDesc` | `szLockDesc` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 11 | `szLink` | `szLink` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |

## HLIdentity\HLIdentityPriorityType.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |

## HLIdentity\HLOrder.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nExp` | `nExp` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `nMoney` | `nMoney` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `nArchitecture` | `nArchitecture` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `szProduct` | `szProduct` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `szReward` | `szReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 8 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `nSubmitLimit` | `nSubmitLimit` | 整数 | 待确认 | 待确认 | 待确认 |

## HLIdentity\HLTask.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szLink` | `szLink` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 4 | `bWeekly` | `bWeekly` | 布尔 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `szIconPath` | `szIconPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## HLIdentity\IdentityReward.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 5 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `bAutoGet` | `bAutoGet` | 布尔 | 待确认 | 待确认 | 待确认 |

## HLIdentity\IdentityRewardType.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |

## Homeland\DDZCard.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nSkinID` | `nSkinID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nCardNum` | `nCardNum` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 3 | `nColor` | `nColor` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 4 | `nLaiZi` | `nLaiZi` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `szIconPath` | `szIconPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `nIconFrame` | `nIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## Homeland\DDZSettlementSkin.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nSkinID` | `nSkinID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `bSfx` | `bSfx` | 布尔 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 3 | `szFramePath` | `szFramePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `szPath` | `szPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 6 | `szMobileNode` | `szMobileNode` | 路径 | 待确认 | 待确认 | 待确认 |
| 7 | `szMobilePath` | `szMobilePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## Homeland\DDZSkin.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nSkinID` | `nSkinID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `bSfx` | `bSfx` | 布尔 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 3 | `szFramePath` | `szFramePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `szPath` | `szPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 6 | `szMobileNode` | `szMobileNode` | 路径 | 待确认 | 待确认 | 待确认 |
| 7 | `szMobilePath` | `szMobilePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## Homeland\DDZSmallCard.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nSkinID` | `nSkinID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nCardNum` | `nCardNum` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 3 | `nColor` | `nColor` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 4 | `nIsUsed` | `nIsUsed` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 5 | `szIconPath` | `szIconPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `nIconFrame` | `nIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## Homeland\DlcForFurnitureSet.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nDlcID` | `nDlcID` | 整数 | DLC/资料片ID | 字段名推断 | 低 |
| 2 | `_Comment` | `_Comment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `szImgPath` | `szImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nFrameNormal` | `nFrameNormal` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nFrameOver` | `nFrameOver` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `nFrameDown` | `nFrameDown` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `nFrameChecked` | `nFrameChecked` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## Homeland\FurnitureAddInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Path` | `dwAttriID` | 整数 | {f = "i", t = "dwAttriID"}, | 源码注释 | 高 |
| 3 | `Frame` | `szPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `szTip` | `nFrame` | 整数 | 帧号 | 翻译列/字段名 | 中 |
| 5 | `szSource` | `szTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `bArch` | `szSource` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `bShop` | `bArch` | 布尔 | 待确认 | 待确认 | 待确认 |
| 8 | `bSpeical` | `bShop` | 布尔 | 待确认 | 待确认 | 待确认 |
| 9 | `dwFurnitureItemID` | `bSpeical` | 布尔 | 待确认 | 待确认 | 待确认 |

## Homeland\FurnitureSetCollectPointsLevel.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 2 | `_Comment` | `_Comment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `nDestPtsToNextLevel` | `nDestPtsToNextLevel` | 整数 | 升到下一等级所需要的总分数 | 源码注释 | 高 |
| 4 | `szLevelIconBgPath` | `szLevelIconBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `szLevelIconPath` | `szLevelIconPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `szLevelNameImgPath` | `szLevelNameImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `szRewardName` | `szRewardName` | 字符串 | 奖励配置 | 翻译列/字段名 | 中 |
| 8 | `nRewardItemType` | `nRewardItemType` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 9 | `dwRewardItemIndex` | `dwRewardItemIndex` | 整数 | 道具ID/索引 | 字段名推断 | 低 |
| 10 | `szRewardIconPath` | `szRewardIconPath` | 路径 | 奖励配置 | 字段名推断 | 低 |
| 11 | `nRewardIconFrame` | `nRewardIconFrame` | 整数 | 奖励配置 | 字段名推断 | 低 |

## Homeland\FurnitureSetInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nDlcID` | `nDlcID` | 整数 | DLC/资料片ID | 字段名推断 | 低 |
| 2 | `dwSetID` | `dwSetID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `szImgPath` | `szImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `nStars` | `nStars` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `dwAchievementID` | `dwAchievementID` | 整数 | 成就ID | 字段名推断 | 低 |
| 7 | `szSource` | `szSource` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## Homeland\GroundArea.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nLength` | `nLength` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nWidth` | `nWidth` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 3 | `nOrder` | `nOrder` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 4 | `bPrivateHome` | `bPrivateHome` | 布尔 | 待确认 | 待确认 | 待确认 |

## Homeland\Homeland_BlueprintCatg.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTableID` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `nCatg` | `nCatg` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `nArea` | `nArea` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `bPrivate` | `bPrivate` | 布尔 | 待确认 | 待确认 | 待确认 |

## Homeland\Homeland_Blueprints.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `nCatg` | `nCatg` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `szSizeText` | `szSizeText` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `nRequiredLevel` | `nRequiredLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 6 | `szImgPath` | `szImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `nImgFrame` | `nImgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `szFilepath` | `szFilepath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `bNew` | `bNew` | 布尔 | 是否是这一个版本所新增的 | 源码注释 | 高 |
| 10 | `bTeach` | `bTeach` | 布尔 | 是否教学蓝图 | 源码注释 | 高 |
| 11 | `nQuestID` | `nQuestID` | 整数 | 任务ID | 字段名推断 | 低 |
| 12 | `szTipImgPath` | `szTipImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 13 | `szTipText` | `szTipText` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 14 | `szAuthor` | `szAuthor` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 15 | `nRemoteOffset` | `nRemoteOffset` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |

## Homeland\Homeland_BlueprintsChoice.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szTipImgPath` | `szTipImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `szTipBigImgPath` | `szTipBigImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `szTipText` | `szTipText` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `szAuthor` | `szAuthor` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## Homeland\Homeland_FurnitureCatg.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTableID` | `dwTableID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nCatag1Index` | `nCatg1Index` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `nCatag2Index` | `nCatg2Index` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 4 | `nCatag3Index` | `nCatg3Index` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 5 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 6 | `szIconImgPath` | `szIconImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `nStaticPicFrame` | `nStaticPicFrame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 8 | `nIconFrameNormal` | `nIconFrameNormal` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 9 | `nIconFrameOver` | `nIconFrameOver` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 10 | `nIconFrameDown` | `nIconFrameDown` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 11 | `nIconFrameChecked` | `nIconFrameChecked` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 12 | `szCloudIconImgPath` | `szCloudIconImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 13 | `nCloudIconFrame` | `nCloudIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 14 | `szInteract` | `szInteract` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 15 | `_szComment` | `_szComment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## Homeland\Homeland_FurnitureColor.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwRepresentID` | `dwModelID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szColorIndices` | `szColorIndices` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 3 | `szDetailIndex0` | `szDetailIndex0` | 字符串 | 索引/排序 | 字段名推断 | 低 |
| 4 | `szDetailIndex1` | `szDetailIndex1` | 字符串 | 索引/排序 | 字段名推断 | 低 |
| 5 | `szDetailIndex2` | `szDetailIndex2` | 字符串 | 索引/排序 | 字段名推断 | 低 |
| 6 | `szDetailIndex3` | `szDetailIndex3` | 字符串 | 索引/排序 | 字段名推断 | 低 |
| 7 | `szDetailIndex4` | `szDetailIndex4` | 字符串 | 索引/排序 | 字段名推断 | 低 |
| 8 | `szDetailIndex5` | `szDetailIndex5` | 字符串 | 索引/排序 | 字段名推断 | 低 |
| 9 | `szDetailIndex6` | `szDetailIndex6` | 字符串 | 索引/排序 | 字段名推断 | 低 |
| 10 | `szDetailIndex7` | `szDetailIndex7` | 字符串 | 索引/排序 | 字段名推断 | 低 |

## Homeland\Homeland_FurnitureInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTableID` | `dwTableID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nCatag1Index` | `nCatg1Index` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `nCatag2Index` | `nCatg2Index` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 4 | `nCatag3Index` | `nCatg3Index` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 5 | `nSubgroupID` | `nSubgroupID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 6 | `nFurnitureType` | `nFurnitureType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 7 | `dwFurnitureID` | `dwFurnitureID` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `nRepresentID` | `dwModelID` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `nBrushModeCnt` | `nBrushModeCnt` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 11 | `nQuality` | `nQuality` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 12 | `bInteract` | `bInteract` | 布尔 | 待确认 | 待确认 | 待确认 |
| 13 | `szScaleRange` | `szScaleRange` | 字符串 | 待确认 | 待确认 | 待确认 |
| 14 | `bShowWhenNotGot` | `bShowWhenNotGot` | 布尔 | 未获得时是否也显示（只适用于挂件类家具） | 源码注释 | 高 |
| 15 | `bNew` | `bNew` | 布尔 | 是否是这一个版本所新增的 | 源码注释 | 高 |
| 16 | `bChainPlace` | `bChainPlace` | 布尔 | 待确认 | 待确认 | 待确认 |
| 17 | `szXYZScale` | `szXYZScale` | 字符串 | 待确认 | 待确认 | 待确认 |
| 18 | `bFreelyRotate` | `bFreelyRotate` | 布尔 | 待确认 | 待确认 | 待确认 |
| 19 | `szHeightLimit` | `szHeightLimit` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 20 | `bForTest` | `bForTest` | 布尔 | 待确认 | 待确认 | 待确认 |

## Homeland\Homeland_InteractModel.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwModelID` | `dwModelID` | 整数 | 待确认 | 待确认 | 待确认 |

## Homeland\Homeland_MiniGame.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nGameID` | `nGameID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nState` | `nState` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 4 | `bOpenView` | `bOpenView` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 5 | `szModuleID` | `szModuleID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `szBtnID` | `szBtnID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `szDisableBtn` | `szDisableBtn` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 8 | `nCountdownType` | `nCountdownType` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 9 | `szCountdownTip` | `szCountdownTip` | 字符串 | 数量/计数 | 翻译列/字段名 | 中 |
| 10 | `nProgressMin` | `nProgressMin` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `nProgressMax` | `nProgressMax` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `bSaveHistory` | `bSaveHistory` | 布尔 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `szTip` | `szTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 14 | `_Note` | `_Note` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## Homeland\Homeland_MiniGameBtn.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `nCostType` | `nCostType` | 整数 | 0表示不定价，1表示是定价按钮，2表示点击后需要先提示付费使用 | 源码注释 | 高 |
| 4 | `szCondition` | `szCondition` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `szShortcutKey` | `szShortcutKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 6 | `bClosePanel` | `bClosePanel` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 7 | `nPosRelX` | `nPosRelX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 8 | `nPosRelY` | `nPosRelY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 9 | `szDisableBtnTip` | `szDisableBtnTip` | 字符串 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 10 | `_Note` | `_Note` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## Homeland\Homeland_MiniGameMode.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szSlotID` | `szSlotID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `_Note` | `_Note` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## Homeland\Homeland_MiniGameShop.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nGameID` | `nGameID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nModuleID` | `nModuleID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `dwShopID` | `dwShopID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `dwGroup` | `dwGroup` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 5 | `nPage` | `nPage` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `nSlotID` | `szSlotID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `_Note` | `_Note` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `dwTabType` | `dwTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 9 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |

## Homeland\Homeland_MiniGameSlot.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szItemType` | `szItemType` | 字符串 | 道具类型 | 字段名推断 | 低 |
| 3 | `nType` | `nType` | 整数 | 区别宠物和道具 | 源码注释 | 高 |
| 4 | `nFilterID` | `nFilterID` | 整数 | 需要筛选功能时配置 | 源码注释 | 高 |
| 5 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 6 | `nItemMinNum` | `nItemMinNum` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 7 | `nItemMaxNum` | `nItemMaxNum` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 8 | `szTip` | `szTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `dwClassType` | `dwClassType` | 整数 | 类型/分类 | 字段名推断 | 低 |

## Homeland\Homeland_PendantInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nCatg1Index` | `nCatg1Index` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `nCatg2Index` | `nCatg2Index` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 5 | `szBeforeCollect` | `szBeforeCollect` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `szAfterCollect` | `szAfterCollect` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `szButtonTip` | `szButtonTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `szAlreadyTip` | `szAlreadyTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `szItemTip` | `szItemTip` | 字符串 | 道具相关配置 | 翻译列/字段名 | 中 |
| 10 | `szPlaceTip` | `szPlaceTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## Homeland\Homeland_Tags.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nTagID` | `nTagID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nCatg` | `nCatg` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |

## Homeland\Homeland_TagsCatg.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nCatgID` | `nCatgID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |

## Homeland\Homeland_UpgradeInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 2 | `szUnlockInfo` | `szUnlockInfo` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `szConditionInfo` | `szConditionInfo` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 4 | `szIconPath` | `szIconPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `nNomalIconFrame` | `nNomalIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `nSelectIconFrame` | `nSelectIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `nMouseIconFrame` | `nMouseIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## Homeland\Homeland_Weather.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nTime` | `nTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 2 | `nWeather` | `nWeather` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szEnvironment` | `szEnvironment` | 路径 | 待确认 | 待确认 | 待确认 |

## Homeland\HomelandGameplay.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Bit` | `nBit` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szPath` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nLockFrame` | `nLockFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nUnLockFrame` | `nUnLockFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `szTip` | `szTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## Homeland\HomelandIcon.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 2 | `szIconPath` | `szIconPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nIconFrame` | `nIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## Homeland\HomelandLocker.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwItemType` | `dwItemType` | 整数 | 道具类型 | 字段名推断 | 低 |
| 3 | `dwItemID` | `dwItemID` | 整数 | 道具ID | 字段名推断 | 低 |
| 4 | `dwClassType` | `dwClassType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 5 | `dwDataIndex` | `dwDataIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 6 | `dwMaxNum` | `dwMaxNum` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 7 | `nItemType` | `nItemType` | 整数 | 道具类型 | 字段名推断 | 低 |

## Homeland\HomelandNotify.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szPath` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nReadyFrame` | `nReadyFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nProcessingFrame` | `nProcessingFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `nRewardFrame` | `nRewardFrame` | 整数 | 奖励配置 | 字段名推断 | 低 |

## Homeland\HomelandOverview.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szBgPath` | `szBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nBgFrame` | `nBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 5 | `bDouble` | `bDouble` | 布尔 | 待确认 | 待确认 | 待确认 |
| 6 | `nMaxComplete` | `nMaxComplete` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `nCommunityLimit` | `nCommunityLimit` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `nCalendarID` | `nCalendarID` | 整数 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `bPrivate` | `bPrivate` | 布尔 | 待确认 | 待确认 | 待确认 |
| 10 | `bRecommend` | `bRecommend` | 布尔 | 待确认 | 待确认 | 待确认 |
| 11 | `nWeeklyActivityValue` | `nWeeklyActivityValue` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `szMenu` | `szMenu` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 13 | `szMenuLevel` | `szMenuLevel` | 字符串 | 等级/品质 | 字段名推断 | 低 |
| 14 | `szCommunityLimit` | `szCommunityLimit` | 字符串 | 待确认 | 待确认 | 待确认 |
| 15 | `szGuide` | `szGuide` | 字符串 | 待确认 | 待确认 | 待确认 |
| 16 | `szMenuMax` | `szMenuMax` | 字符串 | 数量/计数 | 字段名推断 | 低 |
| 17 | `szNpcInfo` | `szNpcInfo` | 字符串 | 待确认 | 待确认 | 待确认 |
| 18 | `szFurnitureType` | `szFurnitureType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 19 | `szCatg` | `szCatg` | 字符串 | 待确认 | 待确认 | 待确认 |
| 20 | `szCalendarID` | `szCalendarID` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 21 | `szLockTips` | `szLockTips` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## Homeland\HomelandOverviewReward.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nScore` | `nScore` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szReward` | `szReward` | 字符串 | 奖励配置 | 翻译列/字段名 | 中 |

## Homeland\HomelandReward.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `FurniturenIndex` |  | 未知 | 索引/排序 | 字段名推断 | 低 |
| 3 | `Price` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Coordinate` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 5 | `bIndoor` |  | 未知 | 待确认 | 待确认 | 待确认 |

## Homeland\HomelandRewardLevel.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `level` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 2 | `IconPath` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `IconFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `Introduction` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `Name` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `MinPercentage` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 7 | `MaxPercentage` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `Reward` |  | 未知 | 奖励配置 | 字段名推断 | 低 |

## Homeland\HomelandRewardSuit.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Name` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `StartTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 4 | `EndTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 5 | `TimeText` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `Introduce` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `IndoorPath` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `IndoorFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 9 | `OutdoorPath` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `OutdoorFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 11 | `szRewardList` |  | 未知 | 奖励配置 | 字段名推断 | 低 |

## Homeland\HomelandWelfare.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwLevel` | `dwLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szIconPath` | `szIconPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nIconFrame` | `nIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## Homeland\HouseInteraction.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `eType` | `eType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `bMasterShow` | `bMasterShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 4 | `bVistorShow` | `bVistorShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 5 | `bCommunityShow` | `bCommunityShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `bPrivateShow` | `bPrivateShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## Homeland\HouseKeeper.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szServantName` | `szServantName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `szAvatarUITex` | `szAvatarUITex` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `szAvatarFrame` | `szAvatarFrame` | 字符串 | 帧号/图片帧配置 | 字段名推断 | 低 |

## Homeland\HouseKeeperSkill.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szSkillName` | `szSkillName` | 字符串 | 技能相关配置 | 翻译列/字段名 | 中 |
| 3 | `nMaxLevel` | `nMaxLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 4 | `szBoxInfo` | `szBoxInfo` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `bActive` | `bActive` | 布尔 | 待确认 | 待确认 | 待确认 |

## Homeland\LandInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nMapID` | `nMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 2 | `nLandIndex` | `nLandIndex` | 整数 | 索引/排序 | 翻译列/字段名 | 中 |
| 3 | `szLandIndex` | `szLandIndex` | 字符串 | 索引/排序 | 翻译列/字段名 | 中 |
| 4 | `szLandName` | `szLandName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `szQuality` | `szQuality` | 字符串 | 等级/品质 | 翻译列/字段名 | 中 |
| 6 | `szState` | `szState` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `nArea` | `nArea` | 整数 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `szArea` | `szArea` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `nPrice` | `nPrice` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `nUIComponentIndex` | `nUIComponentIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 11 | `nPosX` | `nPosX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nPosY` | `nPosY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `szIconPath` | `szIconPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 14 | `nNormalFrame` | `nNomalFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 15 | `nOverFrame` | `nOverFrame` | 整数 | 悬停/经过状态帧号 | 字段名推断 | 低 |
| 16 | `nDownFrame` | `nDownFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 17 | `szMobileIconPath` | `szMobileIconPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |

## Homeland\MahjongDiscardPos.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `szDirection` | `szDirection` | 字符串 | 待确认 | 待确认 | 待确认 |
| 2 | `nDiscardIndex` | `nDiscardIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `nPosIndex` | `nPosIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |

## Homeland\MahjongHintInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |

## Homeland\MahjongSkinInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nSkinID` | `nSkinID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szType` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 3 | `szIniPath` | `szIniPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nMobileSkinID` | `nMobileSkinID` | 整数 | 待确认 | 待确认 | 待确认 |

## Homeland\MahjongTileInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nSkinID` | `nSkinID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szDirection` | `szDirection` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nNumber` | `nNumber` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 5 | `szIconPath` | `szIconPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `nIconFrame` | `nIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## Homeland\MahjongTitleInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nSkinID` | `nSkinID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `szSFXPath` | `szSFXPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |

## Homeland\PrivateHomeAreas.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 2 | `nLandIndex` |  | 未知 | 索引/排序 | 字段名推断 | 低 |
| 3 | `nAreaIndex` |  | 未知 | 索引/排序 | 字段名推断 | 低 |
| 4 | `szAreaName` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `nArea` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 6 | `nLockLevel` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 7 | `nLockScore` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nArchitecture` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `nMoney` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## Homeland\PrivateHomeSkin.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 2 | `dwSkinID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szSkinName` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `szLandName` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `szLandAddress` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `dwGoodsID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 7 | `szImgName` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `dwPriority` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 9 | `dwSource` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 10 | `szPath` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |

## Homeland\PrivateHomeSkinConfig.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nMapID` |  | 未知 | 地图ID | 字段名推断 | 低 |
| 2 | `dwSkinID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `nArea` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `szPath` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `nFrame` |  | 未知 | 帧号 | 字段名推断 | 低 |
| 6 | `dwX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `dwY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 8 | `dwAreaX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 9 | `dwAreaY` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## HorseEquipGainWay.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |

## HorseExterior.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `dwExteriorID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `szSource` | `szSource` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `szSourceItemInfo` | `szSourceItemInfo` | 字符串 | 道具相关配置 | 字段名推断 | 低 |

## HuaZhaoJieImage.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ImageID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `_Comment` | `szComment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `ImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 5 | `szAuthor` | `szAuthor` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `szTime` | `szTime` | 字符串 | 时间配置 | 翻译列/字段名 | 中 |
| 7 | `szAward` | `szAward` | 字符串 | 奖励配置 | 翻译列/字段名 | 中 |
| 8 | `szIniPath` | `szIniPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## icon.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `ID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `FileName` | `FileName` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `Frame` | `Frame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `Kind` | `Kind` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 5 | `SubKind` | `SubKind` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 6 | `Tag1` | `Tag1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `Tag2` | `Tag2` | 字符串 | 已废弃不用 | 源码注释 | 高 |
| 8 | `FileName_Large` | `FileName_Large` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `MobileFileName` | `MobileFileName` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `MobileBigImg` | `MobileBigImg` | 布尔 | 待确认 | 待确认 | 待确认 |

## IconSourceRequirement.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `分类` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `图标名` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `描述` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `需求描述` |  | 未知 | 待确认 | 待确认 | 待确认 |

## IdentityDynSkill.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szSkill` | `szSkill` | 字符串 | 技能相关配置 | 字段名推断 | 低 |
| 3 | `nFrameL` | `nFrameL` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `nFrameM` | `nFrameM` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nFrameR` | `nFrameR` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `szLinkPath` | `szLinkPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `szDescription` | `szDescription` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |

## IdentityInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szImgPath` | `szImgPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `dwFrame1` | `dwFrame1` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `dwFrame2` | `dwFrame2` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `szLinkFrame` | `szLinkFrame` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 7 | `szUnlockDes` | `szUnlockDes` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `szUnlockDesNext` | `szUnlockDesNext` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `szLinkToPos` | `szLinkToPos` | 多语言文本 | 链接/跳转配置 | 翻译列/字段名 | 中 |
| 10 | `dwSFrame` | `dwSFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 11 | `szSLinkPath` | `szSLinkPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 12 | `szPreFix` | `szPreFix` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `szNeutralTip` | `szNeutralTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## IdentityOtherInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nIdentity` | `nIdentity` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 3 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 4 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 5 | `szSkill` | `szSkill` | 字符串 | 技能相关配置 | 字段名推断 | 低 |
| 6 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 7 | `szDesUp` | `szDesUp` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## IdentityPet.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nModelID` | `nModelID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `szLanguage` | `szLanguage` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## IdleAction.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szActionName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `ItemType` | `dwItemType` | 整数 | 道具类型 | 字段名推断 | 低 |
| 4 | `ItemID` | `dwItemID` | 整数 | 道具ID | 字段名推断 | 低 |
| 5 | `bShowOnlyHave` | `bShowOnlyHave` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## image_preload.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `FileName` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |
| 2 | `bIcon` |  | 未知 | 图标 | 字段名推断 | 低 |
| 3 | `Desc` |  | 未知 | 描述文本 | 翻译列/字段名 | 中 |

## image_preload_25YXDH.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `FileName` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |
| 2 | `bIcon` |  | 未知 | 图标 | 字段名推断 | 低 |
| 3 | `Desc` |  | 未知 | 描述文本 | 字段名推断 | 低 |

## image_preload_25YXLY.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `FileName` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |
| 2 | `bIcon` |  | 未知 | 图标 | 字段名推断 | 低 |
| 3 | `Desc` |  | 未知 | 描述文本 | 字段名推断 | 低 |

## image_preload_25YXZL.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `FileName` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |
| 2 | `bIcon` |  | 未知 | 图标 | 字段名推断 | 低 |
| 3 | `Desc` |  | 未知 | 描述文本 | 字段名推断 | 低 |

## image_preload_SCZL.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `FileName` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |
| 2 | `bIcon` |  | 未知 | 图标 | 字段名推断 | 低 |
| 3 | `Desc` |  | 未知 | 描述文本 | 字段名推断 | 低 |

## image_preload_ZLQG.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `FileName` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |
| 2 | `bIcon` |  | 未知 | 图标 | 字段名推断 | 低 |
| 3 | `Desc` |  | 未知 | 描述文本 | 字段名推断 | 低 |

## InstrumentKey.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `szType` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 2 | `szKey` | `szKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 3 | `szWndType` | `szWndType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nIcon` | `nIcon` | 整数 | 图标 | 字段名推断 | 低 |
| 5 | `bShow` | `bShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## InstrumentName.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `szType` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |

## InstrumentPath.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `szType` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 2 | `szIni` | `szIni` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `szPath` | `szPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## InstrumentPlay.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `szType` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 2 | `szKey` | `szKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 3 | `szWnd` | `szWnd` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 字段名推断 | 低 |
| 5 | `bShow` | `bShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## InterludeInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `Comment` | `szComment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `Text` | `szText` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `Content` | `szContent` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 5 | `SFXFile` | `szSFXPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `Sound` | `szSoundPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `IniFile` | `szIniFile` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `HideTitle_MB` | `bHideTitle_MB` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## item.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ItemID` | `dwItemID` | 整数 | 道具ID | 字段名推断 | 低 |
| 2 | `IconID` | `dwIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 3 | `BigIconID` | `dwBigIconID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `SoundID` | `dwSoundID` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 6 | `Desc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 7 | `Requirement` | `szRequirement` | 字符串 | 已废弃不用 | 源码注释 | 高 |
| 8 | `MobileDesc` | `szMobileDesc` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `CanMutiUse` | `bCanMutiUse` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 10 | `MutiUseTip` | `szMutiUseTip` | 字符串 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 11 | `szFilterTag` | `szFilterTag` | 字符串 | 待确认 | 待确认 | 待确认 |

## ItemSourceList_10.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ItemType` |  | 未知 | 道具类型 | 字段名推断 | 低 |
| 2 | `ItemIndex` |  | 未知 | 道具索引 | 字段名推断 | 低 |
| 3 | `SourceActivity` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `SourceShop` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 5 | `SourceTrade` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 6 | `LinkItem` |  | 未知 | 道具相关配置 | 字段名推断 | 低 |
| 7 | `SourceMall` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `SourceProduce` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `SourceNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 10 | `SourceCollectD` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 11 | `SourceCollectN` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 12 | `SourceReputation` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 13 | `SourceQuest` |  | 未知 | 任务相关配置 | 字段名推断 | 低 |
| 14 | `SourceAchievement` |  | 未知 | 成就相关配置 | 字段名推断 | 低 |
| 15 | `SourceBoss` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 16 | `SourceItem` |  | 未知 | 道具相关配置 | 字段名推断 | 低 |
| 17 | `SourceAdventure` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 18 | `SourceUIFunction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 19 | `SourceEventLink` |  | 未知 | 链接/跳转配置 | 翻译列/字段名 | 中 |

## ItemSourceList_5.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ItemType` |  | 未知 | 道具类型 | 字段名推断 | 低 |
| 2 | `ItemIndex` |  | 未知 | 道具索引 | 字段名推断 | 低 |
| 3 | `SourceActivity` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `SourceShop` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 5 | `SourceTrade` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 6 | `LinkItem` |  | 未知 | 道具相关配置 | 字段名推断 | 低 |
| 7 | `SourceMall` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `SourceProduce` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `SourceNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 10 | `SourceCollectD` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 11 | `SourceCollectN` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 12 | `SourceReputation` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 13 | `SourceQuest` |  | 未知 | 任务相关配置 | 字段名推断 | 低 |
| 14 | `SourceAchievement` |  | 未知 | 成就相关配置 | 字段名推断 | 低 |
| 15 | `SourceBoss` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 16 | `SourceItem` |  | 未知 | 道具相关配置 | 字段名推断 | 低 |
| 17 | `SourceAdventure` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 18 | `SourceUIFunction` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 19 | `SourceEventLink` |  | 未知 | 链接/跳转配置 | 翻译列/字段名 | 中 |

## ItemSourceList_6.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ItemType` |  | 未知 | 道具类型 | 字段名推断 | 低 |
| 2 | `ItemIndex` |  | 未知 | 道具索引 | 字段名推断 | 低 |
| 3 | `SourceActivity` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `SourceShop` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 5 | `SourceTrade` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 6 | `LinkItem` |  | 未知 | 道具相关配置 | 字段名推断 | 低 |
| 7 | `SourceMall` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `SourceProduce` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `SourceNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 10 | `SourceCollectD` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 11 | `SourceCollectN` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 12 | `SourceReputation` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 13 | `SourceQuest` |  | 未知 | 任务相关配置 | 字段名推断 | 低 |
| 14 | `SourceAchievement` |  | 未知 | 成就相关配置 | 字段名推断 | 低 |
| 15 | `SourceBoss` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 16 | `SourceItem` |  | 未知 | 道具相关配置 | 字段名推断 | 低 |
| 17 | `SourceAdventure` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 18 | `SourceUIFunction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 19 | `SourceEventLink` |  | 未知 | 链接/跳转配置 | 翻译列/字段名 | 中 |

## ItemSourceList_7.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ItemType` |  | 未知 | 道具类型 | 字段名推断 | 低 |
| 2 | `ItemIndex` |  | 未知 | 道具索引 | 字段名推断 | 低 |
| 3 | `SourceActivity` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `SourceShop` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 5 | `SourceTrade` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 6 | `LinkItem` |  | 未知 | 道具相关配置 | 字段名推断 | 低 |
| 7 | `SourceMall` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `SourceProduce` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `SourceNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 10 | `SourceCollectD` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 11 | `SourceCollectN` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 12 | `SourceReputation` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 13 | `SourceQuest` |  | 未知 | 任务相关配置 | 字段名推断 | 低 |
| 14 | `SourceAchievement` |  | 未知 | 成就相关配置 | 字段名推断 | 低 |
| 15 | `SourceBoss` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 16 | `SourceItem` |  | 未知 | 道具相关配置 | 字段名推断 | 低 |
| 17 | `SourceAdventure` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 18 | `SourceUIFunction` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 19 | `SourceEventLink` |  | 未知 | 链接/跳转配置 | 翻译列/字段名 | 中 |

## ItemSourceList_8.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ItemType` |  | 未知 | 道具类型 | 字段名推断 | 低 |
| 2 | `ItemIndex` |  | 未知 | 道具索引 | 字段名推断 | 低 |
| 3 | `SourceActivity` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `SourceShop` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 5 | `SourceTrade` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 6 | `LinkItem` |  | 未知 | 道具相关配置 | 字段名推断 | 低 |
| 7 | `SourceMall` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `SourceProduce` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `SourceNpc` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 10 | `SourceCollectD` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 11 | `SourceCollectN` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 12 | `SourceReputation` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 13 | `SourceQuest` |  | 未知 | 任务相关配置 | 字段名推断 | 低 |
| 14 | `SourceAchievement` |  | 未知 | 成就相关配置 | 字段名推断 | 低 |
| 15 | `SourceBoss` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 16 | `SourceItem` |  | 未知 | 道具相关配置 | 字段名推断 | 低 |
| 17 | `SourceAdventure` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 18 | `SourceUIFunction` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 19 | `SourceEventLink` |  | 未知 | 链接/跳转配置 | 翻译列/字段名 | 中 |

## JJCEquipmentDIY\ColorDiamond.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Index` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `ItemType` | `dwTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `ItemIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 4 | `kunfuID` | `szKungfuID` | 字符串 | 心法/内功ID | 字段名推断 | 低 |

## JJCEquipmentDIY\Enchant.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Index` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `ItemType` | `dwTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `ItemIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 4 | `kungfuID` | `szKungfuID` | 字符串 | 心法/内功ID | 字段名推断 | 低 |

## JJCEquipmentDIY\Equipment.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Index` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `ItemType` | `dwTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `ItemIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |

## JoinCampReward.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nCamp` | `nCamp` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 3 | `szReward` | `szReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |

## KillFeedConfig.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwEffectID` | `dwEffectID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szBgPath` | `szBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nBgFrame` | `nBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `szSFXPath` | `szSFXPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `szMBBgPath` | `szMBBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `szMBSFXPath` | `szMBSFXPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## KillSound.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 3 | `nGroup` | `nGroup` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 5 | `szSound1` | `szSound1` | 路径 | 待确认 | 待确认 | 待确认 |
| 6 | `szSound2` | `szSound2` | 路径 | 待确认 | 待确认 | 待确认 |
| 7 | `szSound3` | `szSound3` | 路径 | 待确认 | 待确认 | 待确认 |
| 8 | `szSound4` | `szSound4` | 路径 | 待确认 | 待确认 | 待确认 |
| 9 | `szSound5` | `szSound5` | 路径 | 待确认 | 待确认 | 待确认 |
| 10 | `szSound6` | `szSound6` | 路径 | 待确认 | 待确认 | 待确认 |

## kungfu_big_icon.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `KungFuID` | `dwKungFuID` | 整数 | 心法/内功ID | 字段名推断 | 低 |
| 2 | `KungFu` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `Path` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `Frame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## learnskill.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `level` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 2 | `school` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `skills` |  | 未知 | 技能相关配置 | 字段名推断 | 低 |

## LevelUpAward.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `nItemIndex1` | `nItemIndex1` | 整数 | 道具ID/索引 | 字段名推断 | 低 |
| 4 | `nItemType1` | `nItemType1` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 5 | `szItemDesc1` | `szItemDesc1` | 字符串 | 道具相关配置 | 翻译列/字段名 | 中 |
| 6 | `nItemIndex2` | `nItemIndex2` | 整数 | 道具ID/索引 | 字段名推断 | 低 |
| 7 | `nItemType2` | `nItemType2` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 8 | `szItemDesc2` | `szItemDesc2` | 字符串 | 道具相关配置 | 翻译列/字段名 | 中 |
| 9 | `nItemIndex3` | `nItemIndex3` | 整数 | 道具ID/索引 | 字段名推断 | 低 |
| 10 | `nItemType3` | `nItemType3` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 11 | `szItemDesc3` | `szItemDesc3` | 字符串 | 道具相关配置 | 翻译列/字段名 | 中 |
| 12 | `nItemIndex4` | `nItemIndex4` | 整数 | 道具ID/索引 | 字段名推断 | 低 |
| 13 | `nItemType4` | `nItemType4` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 14 | `szItemDesc4` | `szItemDesc4` | 字符串 | 道具相关配置 | 翻译列/字段名 | 中 |
| 15 | `nItemIndex5` | `nItemIndex5` | 整数 | 道具ID/索引 | 字段名推断 | 低 |
| 16 | `nItemType5` | `nItemType5` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 17 | `szItemDesc5` | `szItemDesc5` | 字符串 | 道具相关配置 | 翻译列/字段名 | 中 |
| 18 | `nItemIndex6` | `nItemIndex6` | 整数 | 道具ID/索引 | 字段名推断 | 低 |
| 19 | `nItemType6` | `nItemType6` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 20 | `szItemDesc6` | `szItemDesc6` | 字符串 | 道具相关配置 | 翻译列/字段名 | 中 |
| 21 | `nItemIndex7` | `nItemIndex7` | 整数 | 道具ID/索引 | 字段名推断 | 低 |
| 22 | `nItemType7` | `nItemType7` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 23 | `szItemDesc7` | `szItemDesc7` | 字符串 | 道具相关配置 | 翻译列/字段名 | 中 |
| 24 | `nItemIndex8` | `nItemIndex8` | 整数 | 道具ID/索引 | 字段名推断 | 低 |
| 25 | `nItemType8` | `nItemType8` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 26 | `szItemDesc8` | `szItemDesc8` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 27 | `nItemIndex9` | `nItemIndex9` | 整数 | 道具ID/索引 | 字段名推断 | 低 |
| 28 | `nItemType9` | `nItemType9` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 29 | `szItemDesc9` | `szItemDesc9` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 30 | `nItemIndex10` | `nItemIndex10` | 整数 | 道具ID/索引 | 字段名推断 | 低 |
| 31 | `nItemType10` | `nItemType10` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 32 | `szItemDesc10` | `szItemDesc10` | 字符串 | 道具相关配置 | 字段名推断 | 低 |

## LimitedSale.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Title` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 3 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `BigImage` | `szBigImage` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 5 | `BigFrame` | `nBigFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `SideImage` | `szSideImage` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 7 | `SideFrame` | `nSideFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `ShowBox` | `szBox` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 9 | `Goods` | `szGoods` | 字符串 | 待确认 | 待确认 | 待确认 |
| 10 | `szTitlePath` | `szTitlePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 11 | `szTitleFrame` | `nTitleFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 12 | `ShowTitle` | `szShowTitle` | 字符串 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 13 | `SFX` | `szSFX` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 14 | `DiscountFrame` | `nDiscountFrame` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 15 | `BtnImgPath` | `szBtnImgPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 16 | `nBtnNormalFrame` | `nBtnNormalFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 17 | `BtnOverFrame` | `nBtnOverFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 18 | `BtnDownFrame` | `nBtnDownFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 19 | `BtnTip` | `szBtnTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## LiveShowBuff.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `BuffID` | `BuffID` | 整数 | Buff ID | 字段名推断 | 低 |
| 2 | `Name` | `BuffLevel` | 整数 | Buff相关配置 | 翻译列/字段名 | 中 |
| 3 | `BuffLevel` | `BuffName` | 字符串 | Buff相关配置 | 字段名推断 | 低 |
| 4 | `ShowLevel` | `ShowLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 5 | `Desc` | `Desc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |

## LoadingPlay.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szType` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 3 | `szPath` | `szPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `bLoop` | `bLoop` | 布尔 | 待确认 | 待确认 | 待确认 |

## LoginAnimation.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nRoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `ForceID` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 4 | `szOnceAnimation` | `szOnceAnimation` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `szStandbyAnimation` | `szStandbyAnimation` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `Path` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `szMobileIconPath` | `szMobileIconPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |

## logincreatedata.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `school` | `key` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 2 | `roletype` | `role_type` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 3 | `ChestStyle` | `ChestStyle` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `ChestColor` | `ChestColor` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 5 | `WaistStyle` | `WaistStyle` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `WaistColor` | `WaistColor` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 7 | `BangleStyle` | `BangleStyle` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 8 | `BangleColor` | `BangleColor` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 9 | `BootsStyle` | `BootsStyle` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `BootsColor` | `BootsColor` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 11 | `WeaponStyle` | `WeaponStyle` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `WeaponColor` | `WeaponColor` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 13 | `BigSwordStyle` | `BigSwordStyle` | 整数 | 文本内容 | 字段名推断 | 低 |
| 14 | `BigSwordColor` | `BigSwordColor` | 整数 | 文本内容 | 字段名推断 | 低 |
| 15 | `LShoulder` | `LShoulder` | 整数 | 待确认 | 待确认 | 待确认 |
| 16 | `RShoulder` | `RShoulder` | 整数 | 待确认 | 待确认 | 待确认 |
| 17 | `Cloak` | `Cloak` | 整数 | 待确认 | 待确认 | 待确认 |

## LoginPreset.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nRoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `ForceID` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 4 | `Represent` | `szRepresent` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `FaceFilePath` | `szFaceFilePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `BodyFilePath` | `szBodyFilePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `LoginSceneID` | `nLoginSceneID` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `szOnceAnimation` | `szOnceAnimation` | 字符串 | 待确认 | 待确认 | 待确认 |
| 9 | `szStandbyAnimation` | `szStandbyAnimation` | 字符串 | 待确认 | 待确认 | 待确认 |
| 10 | `szMoblieOnceAnimation` | `szMoblieOnceAnimation` | 字符串 | 待确认 | 待确认 | 待确认 |
| 11 | `szMoblieStandbyAnimation` | `szMoblieStandbyAnimation` | 字符串 | 待确认 | 待确认 | 待确认 |
| 12 | `ImgPath` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 13 | `szMobileIconPath` | `szMobileIconPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 14 | `szMobileIconBgPath` | `szMobileIconBgPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 15 | `MobileLoginSceneID` | `nMobileLoginSceneID` | 整数 | 待确认 | 待确认 | 待确认 |
| 16 | `szMobileGetDesc` | `szMobileGetDesc` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 17 | `szMobileGetIconPath` | `szMobileGetIconPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |

## loginquest.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szText` | `szText` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `Answer1` | `szAnswer1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `FitKungfu1` | `szFitKungfu1` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `NextID1` | `dwNextID1` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `Answer2` | `szAnswer2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `FitKungfu2` | `szFitKungfu2` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `NextID2` | `dwNextID2` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `Answer3` | `szAnswer3` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 10 | `FitKungfu3` | `szFitKungfu3` | 字符串 | 待确认 | 待确认 | 待确认 |
| 11 | `NextID3` | `dwNextID3` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `Answer4` | `szAnswer4` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 13 | `FitKungfu4` | `szFitKungfu4` | 字符串 | 待确认 | 待确认 | 待确认 |
| 14 | `NextID4` | `dwNextID4` | 整数 | 待确认 | 待确认 | 待确认 |
| 15 | `Answer5` | `szAnswer5` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 16 | `FitKungfu5` | `szFitKungfu5` | 字符串 | 待确认 | 待确认 | 待确认 |
| 17 | `NextID5` | `dwNextID5` | 整数 | 待确认 | 待确认 | 待确认 |

## LoginScene.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `IconPath` | `szPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `IconFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 4 | `MapName` | `szMapName` | 未知(R) | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `MobileMapName` | `szMobileMapName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## loginschooldata.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `school` | `key` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 2 | `roletype` | `role_type` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 3 | `HairStyle` | `HairStyle` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `HelmStyle` | `HelmStyle` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `HelmColor` | `HelmColor` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 6 | `ChestStyle` | `ChestStyle` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `ChestColor` | `ChestColor` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 8 | `WaistStyle` | `WaistStyle` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 9 | `WaistColor` | `WaistColor` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 10 | `BangleStyle` | `BangleStyle` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 11 | `BangleColor` | `BangleColor` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 12 | `BootsStyle` | `BootsStyle` | 整数 | 待确认 | 待确认 | 待确认 |
| 13 | `BootsColor` | `BootsColor` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 14 | `WeaponStyle` | `WeaponStyle` | 整数 | 待确认 | 待确认 | 待确认 |
| 15 | `WeaponColor` | `WeaponColor` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 16 | `WeaponEnchant2` | `WeaponEnchant2` | 整数 | 待确认 | 待确认 | 待确认 |
| 17 | `BigSwordStyle` | `BigSwordStyle` | 整数 | 文本内容 | 字段名推断 | 低 |
| 18 | `BigSwordColor` | `BigSwordColor` | 整数 | 文本内容 | 字段名推断 | 低 |
| 19 | `BigSwordEnchant2` | `BigSwordEnchant2` | 整数 | 文本内容 | 字段名推断 | 低 |
| 20 | `LShoulder` | `LShoulder` | 整数 | 待确认 | 待确认 | 待确认 |
| 21 | `RShoulder` | `RShoulder` | 整数 | 待确认 | 待确认 | 待确认 |
| 22 | `Cloak` | `Cloak` | 整数 | 待确认 | 待确认 | 待确认 |
| 23 | `ani` | `ani` | 字符串 | 待确认 | 待确认 | 待确认 |
| 24 | `idle_ani` | `idle_ani` | 整数 | 待确认 | 待确认 | 待确认 |
| 25 | `selected_idle_ani选中体型的待机` | `selected_idle_ani` | 整数 | 待确认 | 待确认 | 待确认 |
| 26 | `szVideoEnterPath` | `videoEnterPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 27 | `szVideoLoopPath` | `videoLoopPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 28 | `nShowUIFps` | `showUIFps` | 整数 | 开关/条件配置 | 字段名推断 | 低 |

## MainKungfuInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `KungfuID` | `dwKungfuID` | 整数 | 心法/内功ID | 字段名推断 | 低 |
| 2 | `KungfuIndex` | `nKungfuIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `ForceID` | `nForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 4 | `TalentGroup` | `nTalentGroup` | 整数 | 类型/分类 | 字段名推断 | 低 |

## MainStoryChapter.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `szTime` | `szTime` | 字符串 | 时间配置 | 字段名推断 | 低 |
| 4 | `szDesc` | `szDesc` | 多语言文本 | 描述文本 | 字段名推断 | 低 |
| 5 | `nPrevChapter` | `nPrevChapter` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `szSectionList` | `szSectionList` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 7 | `szImagePath` | `szImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## MainStorySeason.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `szTime` | `szTime` | 字符串 | 时间配置 | 字段名推断 | 低 |
| 4 | `szChapterList` | `szChapterList` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 5 | `szReward` | `szReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 6 | `dwQuestID` | `dwQuestID` | 整数 | 任务ID | 字段名推断 | 低 |
| 7 | `szImagePath1` | `szImagePath1` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `szImagePath2` | `szImagePath2` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `szSFXLogoPath` | `szSFXLogoPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `szSFXBGPath1` | `szSFXBGPath1` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 11 | `szSFXBGPath2` | `szSFXBGPath2` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 12 | `szImageTitlePath` | `szImageTitlePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 13 | `nTitleFrame` | `nTitleFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## MainStorySection.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `nSoundID` | `nSoundID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `nVideoID` | `nVideoID` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `nForceMask` | `nForceMask` | 字符串 | 势力/阵营配置 | 字段名推断 | 低 |
| 6 | `nCampMask` | `nCampMask` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 7 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 8 | `szDesc` | `szDesc` | 多语言文本 | 描述文本 | 字段名推断 | 低 |
| 9 | `szQuestList` | `szQuestList` | 字符串 | 任务相关配置 | 字段名推断 | 低 |

## map_dynamicdata.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 3 | `szImage` | `szImage` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 4 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 5 | `MinShowLevel` | `nMinShowLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 6 | `Width` | `nWidth` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `Height` | `nHeight` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 8 | `szTip` | `szTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `fScale` | `fScale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 10 | `szTitle` | `szAreaImagePath` | 路径 | 资源/文件路径 | 翻译列/字段名 | 中 |
| 11 | `szMobileImage` | `nAreaFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 12 | `szAreaImagePath` | `nAreaX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nAreaFrame` | `nAreaY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 14 | `nAreaX` | `bHideInList` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 15 | `nAreaY` | `bNotHuntTip` | 布尔 | 待确认 | 待确认 | 待确认 |
| 16 | `szMobileAreaImagePath` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |
| 17 | `bHideInList` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 18 | `bNotHuntTip` |  | 未知 | 待确认 | 待确认 | 待确认 |

## MapAppointmentInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `dwMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 4 | `dwAppointmentID` | `dwAppointmentID` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `dwActivityID` | `dwActivityID` | 整数 | 活动ID | 字段名推断 | 低 |

## MapCircle.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Index` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `LogicDistance` | `fDistance` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 4 | `UICircleDiameter` | `nCircleDiameter` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `CirclePath` | `szCirclePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `szComment` | `szComment` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## MapEventCondition.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nConditionID` | `nConditionID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szContent` | `szContent` | 多语言文本 | 文本内容 | 字段名推断 | 低 |
| 3 | `nValueType` | `nValueType` | 整数 | 类型/分类 | 字段名推断 | 低 |

## MapGroup.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `GroupName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |

## MapGuide_TrafficSkill.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `MapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 2 | `CityID` | `dwCityID` | 整数 | 待确认 | 待确认 | 待确认 |

## MapList.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Group` | `nGroup` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `Region` | `dwRegionID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 5 | `Type` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 6 | `MiddleMap0` | `szMiddleMap` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `ImagesPath` | `szImagesPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `Tip` | `szTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `movie_id` | `nMovieID` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `font_ID` | `nFontID` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `HasTreasure` | `bHasTreasure` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 12 | `bShowLeaveBtn` | `bShowLeaveBtn` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 13 | `fMaxScle` | `fMaxScale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 14 | `bEnableDayNightCycle` | `bEnableDayNightCycle` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 15 | `bEnableSelfieDayNightCycle` | `bEnableSelfieDayNightCycle` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## MapRule.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 2 | `szLink` | `szLink` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |

## MentorAward.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Instruction` | `szInstruction` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `Num` | `szNum` | 字符串 | 数量/计数 | 翻译列/字段名 | 中 |
| 4 | `Award1` | `szAward1` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 5 | `Award2` | `szAward2` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 6 | `Award3` | `szAward3` | 字符串 | 奖励配置 | 字段名推断 | 低 |

## MentorPanelInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwActivityID` | `dwActivityID` | 整数 | 活动ID | 字段名推断 | 低 |
| 2 | `nType[0、找师傅 1、师父 2、徒弟 3、同门(只从师徒界面中打开) 4、找徒弟]` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `szMsg` | `szMsg` | 字符串 | 提示消息文本 | 翻译列/字段名 | 中 |
| 4 | `szLabelType` | `szLabelType` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |

## MentorPanelLuckyMeet.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `szCondition` | `szCondition` | 字符串 | 待确认 | 待确认 | 待确认 |

## MentorPanelValueGift.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szGoodsName` | `szGoodsName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `nGoodsPrice` | `nGoodsPrice` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## MergeEmotionTitle.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `mergeid` | `mergeid` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `name` | `name` | 字符串 | 待确认 | 待确认 | 待确认 |

## MessageBoxPro.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Title` | `szTitle` | 字符串 | 标题文本 | 字段名推断 | 低 |
| 3 | `Msg` | `szMsg` | 多语言文本 | 提示消息文本 | 字段名推断 | 低 |
| 4 | `iconFile` | `szIconFile` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `IconFrame` | `nIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `Skin` | `szSkin` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `ButtonText1` | `szButtonText1` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 8 | `ButtonText2` | `szButtonText2` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 9 | `ButtonText3` | `szButtonText3` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 10 | `bVisibleWhenCoinShop` | `bVisibleWhenCoinShop` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 11 | `bShowClose` | `bShowClose` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## MessageLineList.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szIndex` | `szIndex` | 字符串 | SHOW_ITEM 键名，如 "XIA_YI" | 源码注释 | 高 |
| 3 | `szDisplayKey` | `szDisplayKey` | 字符串 | 显示用字符串（直接填中/英文）；"FPS_TITLE"/"CPU_TITLE" 为特殊标记 | 源码注释 | 高 |
| 4 | `nGroup` | `nGroup` | 整数 | 1=PVE 2=PVP 3=休闲 4=其他 | 源码注释 | 高 |
| 5 | `szGroupTitle` | `szGroupTitle` | 字符串 | 分组标题显示字符串（直接填写中/英文） | 源码注释 | 高 |
| 6 | `szCurrencyIndex` | `szCurrencyIndex` | 多语言文本 | CurrencyInfo szName，空=非表内货币 | 源码注释 | 高 |
| 7 | `nFrame` | `nFrame` | 整数 | SetFrame 帧号，0=不用 | 源码注释 | 高 |
| 8 | `szFnTip` | `szFnTip` | 多语言文本 | tip 函数名，空=无 tip | 源码注释 | 高 |
| 9 | `szFnAddHandle` | `szFnAddHandle` | 字符串 | addHandle 函数名 | 源码注释 | 高 |
| 10 | `szFnShow` | `szFnShow` | 多语言文本 | NumericalPanel 显示条件："PC"/"NotSM"/"WG" | 源码注释 | 高 |
| 11 | `szFnCondition` | `szFnCondition` | 多语言文本 | MainMessageLine 渲染条件："MultiThread"/"CampPlayerCount" | 源码注释 | 高 |
| 12 | `bNum` | `bNum` | 布尔 | 是否数值型（需 breathe 刷新） | 源码注释 | 高 |
| 13 | `bHideValue` | `bHideValue` | 布尔 | 是否隐藏数值文字 | 源码注释 | 高 |
| 14 | `bNumPanel` | `bNumPanel` | 布尔 | 是否在 NumericalPanel 弹窗中显示 | 源码注释 | 高 |
| 15 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 字段名推断 | 低 |

## MiddleMap\MiddleMapCommand.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID[14固定为Car图标的配置项]` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szMarkBtnName` | `szMarkBtnName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `szAppendWndName` | `szAppendWndName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `szMarkImageUITex` | `szMarkImageUITex` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 5 | `nMarkImageFrame` | `nMarkImageFrame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 6 | `szBattleFieldUITex` | `szBattleFieldUITex` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `nBattleFieldFrame` | `nBattleFieldFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `szMobileImage` | `szMobileImage` | 字符串 | 图片资源配置 | 字段名推断 | 低 |

## MiddleMap\MiddleMapCommandNpc.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID[21固定为boss被攻击动画的配置项]` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szAppendWndName` | `szAppendWndName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `nServerDataIndex` | `nServerDataIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 4 | `nNPCDataType` | `nNPCDataType` | 整数 | ps:这个必须和map_dynamicdata.txt中的nType对应 | 源码注释 | 高 |
| 5 | `bShow` | `bShow` | 整数 | nServerDataIndex填0是不需要策划记额外数据，此时bShow填1会仅显示图标 | 源码注释 | 高 |

## Middlemap_MapMark.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Type` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `ImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `Frame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 5 | `tip` | `szTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## Middlemap_SelectNpc.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `NpcTypeId` | `nNpcTypeID` | 整数 | 类型/分类 | 字段名推断 | 低 |

## MiddleMapLineConfig.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szImageLineName` | `szImageLineName` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 3 | `szMobileImageLineName` | `szMobileImageLineName` | 字符串 | 图片资源配置 | 字段名推断 | 低 |

## MiniGame\JigsawConfig.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `szAuthor` | `szAuthor` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 5 | `szFullImagePath` | `szFullImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `szBreakImagePath` | `szBreakImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## MiniGame\JigsawPiecesConfig.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `nX` | `nX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `nY` | `nY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 7 | `szHoverPath` | `szHoverPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `nHoverFrame` | `nHoverFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 9 | `szCorrectPath` | `szCorrectPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `nCorrectFrame` | `nCorrectFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 11 | `szHintPath` | `szHintPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 12 | `nHintFrame` | `nHintFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## MiniGame\MiniGameInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwGameID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `szGuide` | `szGuide` | 多语言文本 | 待确认 | 待确认 | 待确认 |

## MiniGame\MiniGameStart.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `szType` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 2 | `szBGPath` | `szBGPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nBgFrame` | `nBGFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `szSFXPath` | `szSFXPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `nTitleFont` | `nTitleFont` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `szFontColor` | `szFontColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |

## MiniGame\PoetryConfig.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szPoetry` | `szPoetry` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |

## MiniGame\PoetryContentConfig.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nLevel` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `szContent` | `szContent` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 3 | `szAnswer` | `szAnswer` | 字符串 | 待确认 | 待确认 | 待确认 |

## minimap_hover.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwHoverID` | `dwHoverID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szImagePath` | `szImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 4 | `szType` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |

## minimap_mark.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `type` | `type` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `is_arrow` | `is_arrow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 3 | `frame` | `frame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `out_frame` | `out_frame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## minimap_taiyuan.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `Taiyuan_Dynamic_Type` | `dwDynamicDataType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `NpcTemplate` | `dwNpcTemplateID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 5 | `nArrowFrame` | `nArrowFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## MobaShopItemInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nEquipmentSub` | `nEquipmentSub` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `nItemType` | `nItemType` | 整数 | 道具类型 | 字段名推断 | 低 |
| 4 | `nItemID` | `nItemID` | 整数 | 道具ID | 字段名推断 | 低 |
| 5 | `nKungfuMountID` | `szKungfuMountID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `nIndexX` | `nIndexX` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 7 | `nIndexY` | `nIndexY` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 8 | `nCost` | `nCost` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `nSellingPrice` | `nSellingPrice` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `szUpgradeScheme` | `szUpgradeScheme` | 字符串 | 等级/品质 | 字段名推断 | 低 |
| 11 | `szNextItemIDs` | `szNextItemIDs` | 字符串 | 道具ID/索引 | 字段名推断 | 低 |
| 12 | `szDescription` | `szDescription` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 13 | `nTagFrame` | `nTagFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 14 | `szNote` | `szNote` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## MobaShopPrePurchase.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nKungfuMountID` | `nKungfuMountID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `nEquipmentLocalID1` | `nEquipmentLocalID1` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `nEquipmentLocalID2` | `nEquipmentLocalID2` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `nEquipmentLocalID3` | `nEquipmentLocalID3` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `nEquipmentLocalID4` | `nEquipmentLocalID4` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `nEquipmentLocalID5` | `nEquipmentLocalID5` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `nEquipmentLocalID6` | `nEquipmentLocalID6` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 10 | `szNote` | `szNote` | 字符串 | 待确认 | 待确认 | 待确认 |

## MoGaoKuButton.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `szContent` | `szContent` | 多语言文本 | 文本内容 | 字段名推断 | 低 |
| 4 | `X` | `nX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `Y` | `nY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 6 | `TargetX` | `nTargetX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `TargetY` | `nTargetY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 8 | `TargetScale` | `fTargetScale` | 浮点数 | 目标配置 | 字段名推断 | 低 |
| 9 | `Left` | `bLeft` | 布尔 | 待确认 | 待确认 | 待确认 |

## MoGaoKuPanel.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `TitlePath` | `szTitlePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `TitleFrame` | `nTitleFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `MapPath` | `szMapPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `MapW` | `nW` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `MapH` | `nH` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `DefaultX` | `nDefaultX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 9 | `DefaultY` | `nDefaultY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 10 | `DefaultScale` | `fDefaultScale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 11 | `MaxScale` | `fMaxScale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 12 | `ButtonList` | `szButtonList` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |

## Monopoly\MonopolyCardInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `szPath` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `szBigPath` | `szBigPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 6 | `nTargetType` | `nTargetType` | 整数 | 目标类型 | 字段名推断 | 低 |
| 7 | `bShowRemove` | `bShowRemove` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 8 | `szDetailDesc` | `szDetailDesc` | 字符串 | 详细描述文本 | 字段名推断 | 低 |

## Monopoly\MonopolyFateEvent.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szTitleImgPath` | `szTitleImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nTitleImgFrame` | `nTitleImgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 5 | `szNotifyDesc` | `szNotifyDesc` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `szBgPath` | `szBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `nBgFrame` | `nBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `szOption1Text` | `szOption1Text` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 9 | `szOption2Text` | `szOption2Text` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 10 | `nDefaultChoose` | `nDefaultChoose` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `nNotifyKeepShowTime` | `nNotifyKeepShowTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 12 | `nOption1Money` | `nOption1Money` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `nOption2Money` | `nOption2Money` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 14 | `szOption1Tip` | `szOption1Tip` | 字符串 | 待确认 | 待确认 | 待确认 |
| 15 | `szOption2Tip` | `szOption2Tip` | 字符串 | 待确认 | 待确认 | 待确认 |

## Monopoly\MonopolyFateEventResult.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwEventID` | `dwEventID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `dwResultID` | `dwResultID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szTitleImgPath` | `szTitleImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nTitleImgFrame` | `nTitleImgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 6 | `szNotifyDesc` | `szNotifyDesc` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `szBgPath` | `szBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `nBgFrame` | `nBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 9 | `bShowTriggerPlayerName` | `bShowTriggerPlayerName` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 10 | `szResultSFXPath` | `szResultSFXPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 11 | `szResultSoundPath` | `szResultSoundPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 12 | `nNotifyKeepShowTime` | `nNotifyKeepShowTime` | 整数 | 时间配置 | 字段名推断 | 低 |

## Monopoly\MonopolyGodSFX.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nGodID` | `nGodID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nSfxItemID` | `nSfxItemID` | 整数 | 道具ID/索引 | 字段名推断 | 低 |
| 3 | `szSFXPath` | `szSFXPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `szSfxSoundPath` | `szSfxSoundPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `szSpeakSoundPath` | `szSpeakSoundPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## Monopoly\MonopolyGridConfig.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nGridID` | `nGridID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nGridType` | `nGridType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 4 | `szDesc` | `szDesc` | 多语言文本 | 描述文本 | 字段名推断 | 低 |
| 5 | `szDummyName` | `szDummyName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `szBuildingDummyName` | `szBuildingDummyName` | 字符串 | 待确认 | 待确认 | 待确认 |

## Monopoly\MonopolyGridInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nLevelType` | `nLevelType` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 2 | `szPath` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## Monopoly\MonopolyGridLayerConfig.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nLayerID` | `nLayerID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `szDesc` | `szDesc` | 多语言文本 | 描述文本 | 字段名推断 | 低 |

## Monopoly\MonopolyHonorInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nHonorID` | `nHonorID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szBadgePath` | `szBadgePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nBadgeFrame` | `nBadgeFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 字段名推断 | 低 |
| 5 | `szMobileImage` | `szMobileImage` | 字符串 | 图片资源配置 | 字段名推断 | 低 |

## Monopoly\MonopolyHonorTemplate.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nCommentID` | `nCommentID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szKey` | `szKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 3 | `szTemplate` | `szTemplate` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 4 | `bPlayerIndex` | `bPlayerIndex` | 布尔 | 索引/排序 | 字段名推断 | 低 |

## Monopoly\MonopolyInitIdentityConfig.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIdentityID` | `nIdentityID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 4 | `nIconID` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 5 | `nBgID` | `nBgID` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `szImgPathPeopleListBaner(玩家列表底图)` | `szImgPathPeopleListBaner` | 路径 | 玩家列表底图 MonopolyPlayerList | 源码注释 | 高 |
| 7 | `nFramePeopleListBaner` | `nFramePeopleListBaner` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `szImgPathHeadCircle(玩家头像圈)` | `szImgPathHeadCircle` | 路径 | 玩家头像圈 Monopoly_Base | 源码注释 | 高 |
| 9 | `nFrameHeadCircle` | `nFrameHeadCircle` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 10 | `szImgPathNameBar(玩家名字条底)` | `szImgPathNameBar` | 路径 | 玩家名字条底 Monopoly_Base | 源码注释 | 高 |
| 11 | `nFrameNameBar` | `nFrameNameBar` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 12 | `szImgPathTurnAttentionBg(当前回合行动玩家底图)` | `szImgPathTurnAttentionBg` | 路径 | 当前回合行动玩家底图 MonopolyRoundCountdown | 源码注释 | 高 |
| 13 | `nFrameTurnAttentionBg` | `nFrameTurnAttentionBg` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 14 | `szImgPathTargetCardBg(出牌选目标底图)` | `szImgPathTargetCardBg` | 路径 | 出牌选目标底图 MonopolyTargetSelectPanel | 源码注释 | 高 |
| 15 | `nFrameTargetCardBg` | `nFrameTargetCardBg` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 16 | `szImgPathFinalAvatar(结算界面身份头像)` | `szImgPathFinalAvatar` | 路径 | 结算界面身份头像 MonopolyShowFinal | 源码注释 | 高 |
| 17 | `nFrameFinalAvatar` | `nFrameFinalAvatar` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 18 | `szImgPathTipBg(Tip界面背景底图)` | `szImgPathTipBg` | 路径 | Tip界面背景底图 MonopolyNotify | 源码注释 | 高 |
| 19 | `nFrameTipBg` | `nFrameTipBg` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 20 | `szImgPathRoundCountdownBg(倒计时界面底图)` | `szImgPathRoundCountdownBg` | 路径 | 倒计时界面底图 MonopolyRoundCountdown | 源码注释 | 高 |
| 21 | `nFrameRoundCountdownBg` | `nFrameRoundCountdownBg` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 22 | `szRgbPlayerName(玩家名字颜色)` | `szRgbPlayerName` | 字符串 | 玩家名字颜色 MonopolyLogList | 源码注释 | 高 |
| 23 | `szImgPathNotifyAvatar(消息界面获得图)` | `szImgPathNotifyAvatar` | 路径 | 消息界面身份头像 MonopolyNotify | 源码注释 | 高 |
| 24 | `nFrameNotifyAvatar` | `nFrameNotifyAvatar` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## Monopoly\MonopolySound.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nSoundID` | `nSoundID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szEvent` | `szEvent` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `szDes` | `szDes` | 字符串 | 待确认 | 待确认 | 待确认 |

## Monopoly\MonopolyStatusConfig.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `nID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 4 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 5 | `nIconID` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |

## MonsterBook.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `dwIconID` | `dwIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `szDescription` | `szDescription` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |

## MonsterBoss.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `nGroup` | `nGroup` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nSteps` | `nSteps` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `dwNpcID` | `dwNpcID` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `dwProgressID` | `dwProgressID` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 7 | `szSkill` | `szSkill` | 字符串 | 技能相关配置 | 字段名推断 | 低 |
| 8 | `szWeakPoint` | `szWeakPoint` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## MonsterBossIntroduce.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `nSex` | `nSex` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `szPath` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## MonsterBossSpiritEndurance.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `nSex` | `nSex` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `nSpirit` | `nSpirit` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `nEndurance` | `nEndurance` | 整数 | 待确认 | 待确认 | 待确认 |

## MonsterCommonBook.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 2 | `dwTabType` | `dwTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `dwItemIndex` | `dwItemIndex` | 整数 | 道具索引 | 字段名推断 | 低 |
| 4 | `nCostCount` | `nCostCount` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 5 | `dwReplaceTabType` | `dwReplaceTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 6 | `dwReplaceItemIndex` | `dwReplaceItemIndex` | 整数 | 道具ID/索引 | 字段名推断 | 低 |
| 7 | `nReplaceCount` | `nReplaceCount` | 整数 | 数量/计数 | 字段名推断 | 低 |

## MonsterEffect.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `dwIconID` | `dwIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `szDescription` | `szDescription` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |

## MonsterLocker.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwItemType` | `dwItemType` | 整数 | 道具类型 | 字段名推断 | 低 |
| 3 | `dwItemID` | `dwItemID` | 整数 | 道具ID | 字段名推断 | 低 |

## MonsterSkill.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwInSkillID` | `dwInSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 2 | `dwOutSkillID` | `dwOutSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 3 | `nCost` | `nCost` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `nColor` | `nColor` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 5 | `szType` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 6 | `bDeprecated` | `bDeprecated` | 布尔 | 待确认 | 待确认 | 待确认 |
| 7 | `szSkillName` | `szSkillName` | 字符串 | 技能相关配置 | 翻译列/字段名 | 中 |
| 8 | `szBossName` | `szBossName` | 字符串 | 首领名称 | 翻译列/字段名 | 中 |
| 9 | `szBoss` | `szBoss` | 字符串 | 待确认 | 待确认 | 待确认 |
| 10 | `nSex` | `nSex` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |

## MonsterSkillSearch.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Type` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `TypeName` | `szTypeName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |

## MonsterTeach.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szKey` | `szKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 3 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 4 | `szContent1` | `szContent1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `szPath1` | `szPath1` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `nFrame1` | `nFrame1` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `szContent2` | `szContent2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `szPath2` | `szPath2` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `nFrame2` | `nFrame2` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## MoviePath.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `LocalPath` | `szLocalPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `URLPath` | `szUrlPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `szComment` | `szComment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## MPakByKungfu.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ForceID` | `dwKungfuID` | 整数 | 心法/内功ID | 字段名推断 | 低 |
| 2 | `MapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |

## MsgChannelDefaultFont.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `szChannel` | `szChannel` | 字符串 | 待确认 | 待确认 | 待确认 |
| 2 | `_Comment` | `_Comment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `nFont` | `nFont` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `RGB` | `szRGB` | 字符串 | 待确认 | 待确认 | 待确认 |

## MultiStageSkill.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `NowSkillID` | `dwNowSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 2 | `Count` | `nCount` | 整数 | 数量/计数 | 字段名推断 | 低 |

## NavigatorSetting.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `ImageOrigin` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `FrameOrigin` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 4 | `SFXOrigin` | `szSFXOriginPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `SFXDirection` | `szSFXDirectionPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `SFXStart` | `szSFXStartPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## NewHorseAttr.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Level` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 3 | `Name` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `IconID` |  | 未知 | 图标ID | 字段名推断 | 低 |
| 5 | `Gener` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 6 | `Type` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 7 | `bRelateFeed` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `FeedTip` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `Tip` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 10 | `TuJianTip` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 11 | `bShow` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |

## NewMovieInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwProtocolID` | `dwProtocolID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `URLAddress` | `szUrlAddress` | 路径 | 链接/跳转配置 | 字段名推断 | 低 |
| 4 | `szComment` | `szComment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `MobileURL` | `szMobileURL` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 6 | `EnableAdjust` | `bEnableAdjust` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 7 | `MobilePlayType` | `nMobilePlayType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 8 | `RequireQuality` | `nReqiureQuality` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 9 | `bHideLoading` | `bHideLoading` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 10 | `bNotStopSound` | `bNotStopSound` | 布尔 | 待确认 | 待确认 | 待确认 |

## NewPQ.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `PQID` | `dwPQID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `MapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 3 | `WatchNPC` | `dwWatchNpcTemplateID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `MiddleMapType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 5 | `Reward` | `szReward` | 字符串 | 奖励配置 | 翻译列/字段名 | 中 |
| 6 | `QuestList` | `szQuestList` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 7 | `MinShowLevel` | `nMinShowLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 8 | `JoinMethod` | `szJoinMethod` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `ImageFile` | `szImageFile` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `nFrame` | `nTipFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 11 | `MainTitle` | `szMainTitle` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 12 | `MainText` | `szMainText` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 13 | `MainIcon` | `nMainFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 14 | `SubTitle` | `szSubTitle` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 15 | `SubText` | `szSubText` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 16 | `Tip` | `szPQTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 17 | `ValueText1` | `szValueText1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 18 | `ValueType1` | `nValueType1` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 19 | `ValueColour1` | `nValueColour1` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 20 | `Icon1` | `nFrame1` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 21 | `ValueMax1` | `dwValueMax1` | 整数 | 待确认 | 待确认 | 待确认 |
| 22 | `ValueText2` | `szValueText2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 23 | `ValueType2` | `nValueType2` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 24 | `ValueColour2` | `nValueColour2` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 25 | `Icon2` | `nFrame2` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 26 | `ValueMax2` | `dwValueMax2` | 整数 | 待确认 | 待确认 | 待确认 |
| 27 | `ValueText3` | `szValueText3` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 28 | `ValueType3` | `nValueType3` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 29 | `ValueColour3` | `nValueColour3` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 30 | `Icon3` | `nFrame3` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 31 | `ValueMax3` | `dwValueMax3` | 整数 | 待确认 | 待确认 | 待确认 |
| 32 | `ValueText4` | `szValueText4` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 33 | `ValueType4` | `nValueType4` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 34 | `ValueColour4` | `nValueColour4` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 35 | `Icon4` | `nFrame4` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 36 | `ValueMax4` | `dwValueMax4` | 整数 | 待确认 | 待确认 | 待确认 |
| 37 | `ValueText5` | `szValueText5` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 38 | `ValueType5` | `nValueType5` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 39 | `ValueColour5` | `nValueColour5` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 40 | `Icon5` | `nFrame5` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 41 | `ValueMax5` | `dwValueMax5` | 整数 | 待确认 | 待确认 | 待确认 |
| 42 | `ValueText6` | `szValueText6` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 43 | `ValueType6` | `nValueType6` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 44 | `ValueColour6` | `nValueColour6` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 45 | `Icon6` | `nFrame6` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 46 | `ValueMax6` | `dwValueMax6` | 整数 | 待确认 | 待确认 | 待确认 |

## NewPQObjective.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `PQTemplateID` | `dwPQTemplateID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nFrame` | `nFrame1` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 3 | `nFrame2` | `nFrame2` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## NewPQStage.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `StageID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `StageName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `FrameID` | `nFrameID` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## NewRoleVideo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `RoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `VideoPath` | `dwMovieID` | 整数 | 待确认 | 待确认 | 待确认 |

## NoAnnounceAchievement.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwAchievementID` | `dwAchievementID` | 整数 | 成就ID | 字段名推断 | 低 |

## NoExtentBuff.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwBuffID` | `dwBuffID` | 整数 | Buff ID | 字段名推断 | 低 |
| 2 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |

## npc.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TemplateID` | `dwTemplateID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `TypeID` | `dwTypeID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `AimMarkPriority` | `dwAimMarkPriority` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |

## NpcCallMe.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nCallID` | `nCallID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szDes` | `szDes` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `nRoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 5 | `nForceID` | `nForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 6 | `nCamp` | `nCamp` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 7 | `nBuffID` | `nBuffID` | 整数 | Buff ID | 字段名推断 | 低 |
| 8 | `nBuffLevel` | `nBuffLevel` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 9 | `nQuestID` | `nQuestID` | 整数 | 任务ID | 字段名推断 | 低 |
| 10 | `nQuestState` | `nQuestState` | 整数 | 任务相关配置 | 字段名推断 | 低 |
| 11 | `nReputeID` | `nReputeID` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `nReputeLevel` | `nReputeLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 13 | `nAchieveRecord` | `nAchieveRecord` | 整数 | 待确认 | 待确认 | 待确认 |
| 14 | `nGeneration` | `nGeneration` | 整数 | 待确认 | 待确认 | 待确认 |

## NpcGuide\NpcTypeClass.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `typeindex` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `mapid` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 3 | `mapindex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 4 | `typename` | `szGuildName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `typeiconpath` | `szIconPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `typeiconframe` | `szIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `typetxt` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 8 | `valuelist` | `szNpcTypeList` | 字符串 | 类型/分类 | 字段名推断 | 低 |

## NpcGuide\NpcTypeInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `id` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `npcid` | `dwNpcID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `kindname` | `szTypeName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 4 | `tiptest` | `szTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `position` | `szPosition` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 6 | `kindiconpath` | `szIconPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `kindiconframe` | `szIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `mapid` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 9 | `mapindex` | `dwMapIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 10 | `sortindex` | `nSortIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |

## npcname_image.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Image` | `szImage` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 3 | `frame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 4 | `ani_loop_count(0 代表不是动，非常0代表动画，-1是循环播，正数是播的次数)` | `nLoopCount` | 整数 | 数量/计数 | 字段名推断 | 低 |

## NPCNameVisible.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nSkillID` | `nSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 2 | `nTemplateID` | `dwTemplateID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `bDefaultVisible` | `bDefaultVisible` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 4 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 5 | `MapID` | `nMapID` | 整数 | 地图ID | 字段名推断 | 低 |

## NPCRoster.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `ImageLeftPath` | `szImageLPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `ImageRightPath` | `szImageRPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## NPCSpeechSounds.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwModelID` | `dwModelID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `Text` | `szText` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `Sound` | `szSound` | 路径 | 音效 | 字段名推断 | 低 |
| 6 | `SoundEvent` | `szSoundEvent` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `szHeadPath` | `szHeadPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `FaceIni` | `szFaceIni` | 路径 | 待确认 | 待确认 | 待确认 |
| 9 | `HDCamera` | `szHDCamera` | 字符串 | 待确认 | 待确认 | 待确认 |
| 10 | `CloseTime` | `szSDCamera` | 字符串 | {f = "s", t = "szSDCamera"}, | 源码注释 | 高 |
| 11 | `BgID` | `nCloseTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 12 | `NextID` | `dwBgID` | 整数 | 待确认 | 待确认 | 待确认 |
| 13 | `SyncToChat` | `dwNextID` | 整数 | 待确认 | 待确认 | 待确认 |
| 14 | `WaitTime` | `bSyncToChat` | 布尔 | 待确认 | 待确认 | 待确认 |

## NPCSpeechSoundsBg.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `BgPath` | `szBgPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `BgFrame` | `nBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `FontColor` | `szFontColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 5 | `BtnPath` | `szBtnPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `BtnNormalFrame` | `nBtnNormalFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `BtnOverFrame` | `nBtnOverFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `BtnDownFrame` | `nBtnDownFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 9 | `bShowSfx` | `bShowSfx` | 布尔 | 坐标/尺寸配置 | 字段名推断 | 低 |

## NpcTemplate.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `RecoverHP` | `fRecoverHP` | 浮点数 | 待确认 | 待确认 | 待确认 |

## npctype.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwTypeID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `Desc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 3 | `MinimapImageFrame` | `nMinimapImageFrame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 4 | `EffectID` | `dwEffectID` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `CursorID` | `dwCursorID` | 整数 | 待确认 | 待确认 | 待确认 |

## OBDungeon\OBCastSkill.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `SkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |

## OBDungeon\OBDungeon.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Index` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `MapID` | `nMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 4 | `VoiceName` | `szVoiceName` | 字符串 | 待确认 | 待确认 | 待确认 |

## OpenPanelAtEnterGame.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szDescription[just a note]` | `szDescription` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 3 | `nOpenTime[millisecond]` | `nOpenTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 4 | `nPriority[greater first]` | `nPriority` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |

## OperatActCard.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szType` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 3 | `dwParam` | `dwParam` | 整数 | 脚本/参数配置 | 字段名推断 | 低 |
| 4 | `dwFrame` | `dwFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 5 | `szLinkFrame` | `szLinkFrame` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 6 | `szName` | `szName` | 多语言文本 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 7 | `szItem` | `szItem` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 8 | `szMoblieImage` | `szMoblieImage` | 字符串 | 图片资源配置 | 字段名推断 | 低 |

## OperatActUrl.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szButtonName` | `szButtonName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `szUrl` | `szUrl` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |

## OperatFRecallImg.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwForceID` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 3 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `dwFrame` | `dwFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 5 | `szLinkFrame` | `szLinkFrame` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |

## OperationActivity\BattlePassQuestInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szPageName` | `szPageName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `szQuestID` | `szQuestID` | 字符串 | 任务ID | 字段名推断 | 低 |
| 4 | `nBuffID` | `nBuffID` | 整数 | Buff ID | 字段名推断 | 低 |
| 5 | `nItemCanGet` | `nItemCanGet` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 6 | `nItemTwoCanGet` | `nItemTwoCanGet` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 7 | `szQuestDesc` | `szQuestDesc` | 字符串 | 任务相关配置 | 翻译列/字段名 | 中 |
| 8 | `szIconUITex` | `szIconUITex` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 9 | `nIconFrame` | `nIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 10 | `szLink` | `szLink` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 11 | `nGoldCanGet` | `nGoldCanGet` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 12 | `nNumOfMaxFinished` | `nNumOfMaxFinished` | 整数 | 数量/计数 | 字段名推断 | 低 |

## OperationActivity\BattlePassRewardInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szItem` | `szItem` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 4 | `nItemNeeded` | `nItemNeeded` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 5 | `nItemTwoNeeded` | `nItemTwoNeeded` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 6 | `nLimit` | `nLimit` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `szRewardTextureOrLink` | `szRewardTextureOrLink` | 字符串 | 奖励配置 | 字段名推断 | 低 |

## OperationActivity\ChongXiaoMonthly.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nSubID` | `nSubID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `bShow` | `bShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 4 | `nDisplayTime` | `nDisplayTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 5 | `szRewardTextureFile` | `szRewardTextureFile` | 路径 | 奖励配置 | 字段名推断 | 低 |
| 6 | `szItems` | `szItems` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 7 | `szItemPath1` | `szItemPath1` | 路径 | 道具相关配置 | 字段名推断 | 低 |
| 8 | `szItemPath2` | `szItemPath2` | 路径 | 道具相关配置 | 字段名推断 | 低 |
| 9 | `nMoney` | `nMoney` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 10 | `szActivityTime` | `szActivityTime` | 字符串 | 时间配置 | 翻译列/字段名 | 中 |
| 11 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 12 | `nStartTime` | `nStartTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 13 | `nEndTime` | `nEndTime` | 整数 | 时间配置 | 字段名推断 | 低 |

## OperationActivity\DailySignInReward.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `szImgPath` | `szImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## OperationActivity\FameAndPunishEvilInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTab` | `dwTab` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szSubTab1` | `szSubTab1` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `szSubTab2` | `szSubTab2` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `szImageBox` | `szImage1` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 5 | `szImageShop` | `szImage2` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 6 | `szMobileImageBox` | `szMobileImage1` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 7 | `szMobileImageShop` | `szMobileImage2` | 路径 | 图片资源配置 | 字段名推断 | 低 |

## OperationActivity\GongZhanActInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nCategory` | `nCategory` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `szCatgName` | `szCatgName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 5 | `szType` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 6 | `szDsc` | `szDsc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 7 | `szGuildID` | `szGuildID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `szItem` | `szItem` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 9 | `szCurrency` | `szCurrency` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |

## OperationActivity\OnePhotoRewards.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 3 | `szItem` | `szItem` | 未知(R) | 道具相关配置 | 字段名推断 | 低 |
| 4 | `szSpecial` | `szSpecial` | 未知(R) | 待确认 | 待确认 | 待确认 |

## OperationActivity\OperatAct.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwParentID` | `dwParentID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `nCategoryID` | `nCategoryID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nPriority` | `nPriority` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 6 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 7 | `szContentTitle` | `szContentTitle` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 8 | `szUserData` | `szUserData` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 9 | `szDes` | `szDes` | 字符串 | 待确认 | 待确认 | 待确认 |
| 10 | `dwNormalFrame` | `dwNormalFrame` | 整数 | 普通状态帧号 | 字段名推断 | 低 |
| 11 | `dwHighLightFrame` | `dwHighLightFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 12 | `szLinkFrame` | `szLinkFrame` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 13 | `nPreTime` | `nPreTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 14 | `szStartTime` | `szStartTime` | 字符串 | 时间配置 | 字段名推断 | 低 |
| 15 | `szEndTime` | `szEndTime` | 字符串 | 时间配置 | 字段名推断 | 低 |
| 16 | `nResTime` | `nResTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 17 | `szLinkIni` | `szLinkIni` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 18 | `szLinkWidget` | `szLinkWidget` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 19 | `szActivityExplain` | `szActivityExplain` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 20 | `Show` | `bShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 21 | `dwCounterID` | `dwCounterID` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 22 | `nCount` | `nCount` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 23 | `nClientType` | `nClientType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 24 | `nOperatMode` | `nOperatMode` | 整数 | 待确认 | 待确认 | 待确认 |
| 25 | `nOperatType` | `nOperatType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 26 | `szServerName` | `szServerName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 27 | `szReward` | `szReward` | 未知(R) | 奖励配置 | 字段名推断 | 低 |
| 28 | `szRewardBgPath` | `szRewardBgPath` | 路径 | 奖励配置 | 字段名推断 | 低 |
| 29 | `bDefaultHide` | `bDefaultHide` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 30 | `szForbiddenServer` | `szForbiddenServer` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 31 | `nShowLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 32 | `szCustomTime` | `szCustomTime` | 字符串 | 时间配置 | 字段名推断 | 低 |
| 33 | `nShowTimeType` | `nShowTimeType` | 整数 | 时间配置 | 字段名推断 | 低 |
| 34 | `szTPLink` | `szTPLink` | 字符串 | 传送/跳转链接配置 | 字段名推断 | 低 |
| 35 | `nRedDotVersion` | `nRedDotVersion` | 整数 | 待确认 | 待确认 | 待确认 |
| 36 | `szImgBgPath` | `szImgBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 37 | `szThumbnailPath` | `szThumbnailPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 38 | `szSFXPath` | `szSFXPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 39 | `szBriefDesc` | `szBriefDesc` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 40 | `szVideoPath` | `szVideoPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 41 | `szQRCodePath` | `szQRCodePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 42 | `nQRCodeFrame` | `nQRCodeFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 43 | `szQRCodeText` | `szQRCodeText` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 44 | `bHideOperationHandle` | `bHideOperationHandle` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 45 | `szPrefab_Mobile` | `szPrefab_Mobile` | 字符串 | 待确认 | 待确认 | 待确认 |
| 46 | `szBgImgPath_Mobile` | `szBgImgPath_Mobile` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 47 | `szVideoPath_Mobile` | `szVideoPath_Mobile` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 48 | `szSfxPath_Mobile` | `szSfxPath_Mobile` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 49 | `nRedPointID_Mobile` | `nRedPointID_Mobile` | 整数 | 待确认 | 待确认 | 待确认 |
| 50 | `nBtnID_Mobile` | `nBtnID_Mobile` | 整数 | 待确认 | 待确认 | 待确认 |
| 51 | `nBtnID2_Mobile` | `nBtnID2_Mobile` | 整数 | 待确认 | 待确认 | 待确认 |
| 52 | `nBtnID3_Mobile` | `nBtnID3_Mobile` | 整数 | 待确认 | 待确认 | 待确认 |
| 53 | `tbCheckFunc_Mobile` | `tbCheckFunc_Mobile` | 字符串 | 待确认 | 待确认 | 待确认 |
| 54 | `nLayoutStyle_Mobile` | `nLayoutStyle_Mobile` | 整数 | 待确认 | 待确认 | 待确认 |
| 55 | `szLayoutTop_Mobile` | `szLayoutTop_Mobile` | 字符串 | 待确认 | 待确认 | 待确认 |
| 56 | `szLayoutBottom_Mobile` | `szLayoutBottom_Mobile` | 字符串 | 待确认 | 待确认 | 待确认 |
| 57 | `szBottom_Mobile` | `szBottom_Mobile` | 字符串 | 待确认 | 待确认 | 待确认 |
| 58 | `szScript_Mobile` | `szScript_Mobile` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 59 | `szSmallImg_Mobile` | `szSmallImg_Mobile` | 路径 | 待确认 | 待确认 | 待确认 |
| 60 | `szRewardBgPath_Mobile` | `szRewardBgPath_Mobile` | 路径 | 奖励配置 | 字段名推断 | 低 |

## OperationActivity\OperatActFRecall.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwIntergral` | `dwIntergral` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szRewardTextureFile` | `szRewardTextureFile` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 4 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 5 | `bNewProduct` | `bNewProduct` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `szFRecallReward` | `szFRecallReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 7 | `szRewardTypePath` | `szRewardTypePath` | 路径 | 奖励配置 | 字段名推断 | 低 |
| 8 | `nRewardTypeFrame` | `nRewardTypeFrame` | 整数 | 奖励配置 | 字段名推断 | 低 |
| 9 | `szMobileRewardTextureFile` | `szMobileRewardTextureFile` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 10 | `szMobileRewardTypePath` | `szMobileRewardTypePath` | 路径 | 奖励配置 | 字段名推断 | 低 |

## OperationActivity\OperatActProgress.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nActivityID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `nScore` | `nScore` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 6 | `szReward` | `szReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 7 | `szImagePath` | `szImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 9 | `szIconPath` | `szIconPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `nIconFrame` | `nIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 11 | `szVKIconPath` | `szVKIconPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |

## OperationActivity\OperatActShop.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `bShowShopBtn` | `bShowShop` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 3 | `nShopGroupID` | `nShopGroupID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nShopID` | `nShopID` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `szCurrency` | `szCurrency` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 6 | `szItemCurrency` | `szItemCurrency` | 字符串 | 道具相关配置 | 字段名推断 | 低 |

## OperationActivity\OperationCategory.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nCategoryID` | `nCategoryID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `nPriority` | `nPriority` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `nIconFrame` | `nIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nHoverIconFrame` | `nHoverIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## OperationActivity\OperationCheckBox.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nTabIndex` | `nTabIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 4 | `szDsc` | `szDsc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 5 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `nUncheckedAndEnabled` | `nPathFrame` | 整数 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `szComponent` | `szComponent` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `szQRCodePath` | `szQRCodePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `nQRCodeFrame` | `nQRCodeFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 10 | `szQRCodeText` | `szQRCodeText` | 字符串 | 文本内容 | 字段名推断 | 低 |

## OperationActivity\OperationComponent.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Comment` | `szComment` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `WndCntr_ContentTop460` | `WndCntr_ContentTop460` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 4 | `WndCntr_ContentBottom460` | `WndCntr_ContentBottom460` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 5 | `WndCntr_NormalButton460` | `WndCntr_NormalButton460` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `WndCntr_ContentTop544` | `WndCntr_ContentTop544` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 7 | `WndCntr_ContentBottom544` | `WndCntr_ContentBottom544` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 8 | `WndCntr_NormalButton544` | `WndCntr_NormalButton544` | 字符串 | 待确认 | 待确认 | 待确认 |

## OperationActivity\OperationOrangeWeapon.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 字段名推断 | 低 |
| 4 | `nBgFrame` | `nBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `szMobileBgPath` | `szMobileBgPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `szMobileIcon` | `szMobileIcon` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `nIconFrame` | `nIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `szVideoPath` | `szVideoPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `szMobileVideoPath` | `szMobileVideoPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |

## OperationActivity\OperationRewardPreview.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szTag` | `szTag` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `dwTabType` | `dwTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 5 | `nBgFrame` | `nBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `nTagFrame` | `nTagFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `nRewardTypeFrame` | `nRewardTypeFrame` | 整数 | 奖励配置 | 字段名推断 | 低 |
| 8 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `szVideoPath` | `szVideoPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `szMalePath` | `szMalePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 11 | `szFemalePath` | `szFemalePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 12 | `szBoyPath` | `szBoyPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 13 | `szGirlPath` | `szGirlPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 14 | `bSelfBodyOnly` | `bSelfBodyOnly` | 布尔 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 15 | `szLink` | `szLink` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 16 | `szMobileBgFrame` | `szMobileBgFrame` | 路径 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 17 | `szMobileTagFrame` | `szMobileTagFrame` | 路径 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 18 | `szMobileRewardTypeFrame` | `szMobileRewardTypeFrame` | 路径 | 奖励配置 | 字段名推断 | 低 |
| 19 | `szMobileImagePath` | `szMobileImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 20 | `szMobileVideoPath` | `szMobileVideoPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 21 | `szMobileMalePath` | `szMobileMalePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 22 | `szMobileFemalePath` | `szMobileFemalePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 23 | `szMobileBoyPath` | `szMobileBoyPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 24 | `szMobileGirlPath` | `szMobileGirlPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 25 | `nMobileBtnID` | `nMobileBtnID` | 整数 | 待确认 | 待确认 | 待确认 |

## OperationActivity\OperationShop.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nShopID` | `nShopID` | 整数 | 待确认 | 待确认 | 待确认 |

## OperationActivity\OperationTaskListConfig.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 3 | `nTabIndex` | `nTabIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 4 | `nSortIndex` | `nSortIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 5 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 字段名推断 | 低 |
| 6 | `szSubtitle` | `szSubtitle` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `szMarkTag` | `szMarkTag` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `szMarkPath` | `szMarkPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `nMarkFrame` | `nMarkFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 10 | `szBgPath` | `szBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 11 | `nBgFrame` | `nBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 12 | `szvkMarkPath` | `szvkMarkPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 13 | `szvkBgPath` | `szvkBgPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 14 | `szReward` | `szReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 15 | `szLink` | `szLink` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 16 | `szQuestList` | `szQuestList` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 17 | `dwRandomQuestGroupID` | `dwRandomQuestGroupID` | 整数 | 任务ID | 字段名推断 | 低 |

## OperationActivity\RewardLevelInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwActivityID` | `dwActivityID` | 整数 | 活动ID | 字段名推断 | 低 |
| 2 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `szItems` | `szItems` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 4 | `nMoney` | `nMoney` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `szRewardTextureFile` | `szRewardTextureFile` | 字符串 | 奖励配置 | 字段名推断 | 低 |

## OperationActivity\SafePanelInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nTab` | `nTab` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szKey` | `szKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `szDsc` | `szDsc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 5 | `bShowMark` | `bShowMark` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `nMarkFrame` | `nMarkFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `szItems` | `szItems` | 字符串 | 道具相关配置 | 字段名推断 | 低 |

## OperationActivity\SeasonDistanceQuestInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `szQuestDesc` | `szQuestDesc` | 字符串 | 任务相关配置 | 翻译列/字段名 | 中 |
| 4 | `nScore` | `nScore` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `szSpriteFrame` | `szSpriteFrame` | 字符串 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `szTip` | `szTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `nIconFrame` | `nIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## OperationActivity\SeasonUpdateOverview.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szTitle1` | `szTitle1` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `szSubtitle1` | `szSubtitle1` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `szLink1` | `szLink1` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 5 | `szTitle2` | `szTitle2` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `szSubtitle2` | `szSubtitle2` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `szLink2` | `szLink2` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 8 | `szTitle3` | `szTitle3` | 字符串 | 待确认 | 待确认 | 待确认 |
| 9 | `szSubtitle3` | `szSubtitle3` | 字符串 | 待确认 | 待确认 | 待确认 |
| 10 | `szLink3` | `szLink3` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 11 | `szTitle4` | `szTitle4` | 字符串 | 待确认 | 待确认 | 待确认 |
| 12 | `szSubtitle4` | `szSubtitle4` | 字符串 | 待确认 | 待确认 | 待确认 |
| 13 | `szLink4` | `szLink4` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 14 | `szTitle5` | `szTitle5` | 字符串 | 待确认 | 待确认 | 待确认 |
| 15 | `szSubtitle5` | `szSubtitle5` | 字符串 | 待确认 | 待确认 | 待确认 |
| 16 | `szLink5` | `szLink5` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 17 | `szTitle6` | `szTitle6` | 字符串 | 待确认 | 待确认 | 待确认 |
| 18 | `szSubtitle6` | `szSubtitle6` | 字符串 | 待确认 | 待确认 | 待确认 |
| 19 | `szLink6` | `szLink6` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 20 | `szTitle7` | `szTitle7` | 字符串 | 待确认 | 待确认 | 待确认 |
| 21 | `szSubtitle7` | `szSubtitle7` | 字符串 | 待确认 | 待确认 | 待确认 |
| 22 | `szLink7` | `szLink7` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |

## OperationActivity\SignInReward.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `szReward` | `szReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 4 | `szSpecialReward` | `szSpecialReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 5 | `bIsMainReward` | `bIsMainReward` | 布尔 | 奖励配置 | 字段名推断 | 低 |

## OperationActivity\SimpleOperationConfig.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szTaskTitle` | `szTaskTitle` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `szTaskSubtitle` | `szTaskSubtitle` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `szTaskLink` | `szTaskLink` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 5 | `szTaskReward` | `szTaskReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 6 | `nTaskRedDotVersion` | `nTaskRedDotVersion` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `szBgPath` | `szBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `nBgFrame` | `nBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 9 | `szvkBgPath` | `szvkBgPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `szRewardTitle` | `szRewardTitle` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 11 | `szRewardHint` | `szRewardHint` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 12 | `szReward` | `szReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 13 | `szBtn1Text` | `szBtn1Text` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 14 | `szBtn1Link` | `szBtn1Link` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 15 | `szBtn2Text` | `szBtn2Text` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 16 | `szBtn2Link` | `szBtn2Link` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 17 | `szBtn3Text` | `szBtn3Text` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 18 | `szBtn3Link` | `szBtn3Link` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |

## OperationActivity\TopmenuButton.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szWndButtonPath` | `szWndButtonPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `szButtonName` | `szButtonName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `nStartTime` | `nStartTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 6 | `nEndTime` | `nEndTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 7 | `szUrl` | `szUrl` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 8 | `bShow` | `bShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 9 | `szTip` | `szTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## OrangeWeaponInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `dwForceID` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 4 | `dwMKungFuID` | `dwMKungFuID` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `dwMobileMKungFuID` | `dwMobileMKungFuID` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `dwItemIndex` | `dwItemIndex` | 整数 | 道具索引 | 字段名推断 | 低 |
| 7 | `szLink` | `szLink` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 8 | `nMaxStage` | `nMaxStage` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `nStage` | `nStage` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `dwQuestID` | `dwQuestID` | 整数 | 任务ID | 字段名推断 | 低 |
| 11 | `dwWeaponIndex` | `dwWeaponIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 12 | `nStoneCost` | `nStoneCost` | 整数 | 待确认 | 待确认 | 待确认 |
| 13 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 14 | `szMoblieImagePath` | `szMoblieImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## PanelForbidMap.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `PanelName` | `szPanelName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `ForbidMap` | `szForbidMap` | 字符串 | 待确认 | 待确认 | 待确认 |

## PanzhazhaiPanel\PzzBuildings.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## PanzhazhaiPanel\PzzBuildingStatus.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## PanzhazhaiPanel\PzzString.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szString` | `szString` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## Partner\PartnerActSetting.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwPartnerID` | `dwPartnerID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `dwEventID` | `dwEventID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szActIndex` | `szActIndex` | 字符串 | 索引/排序 | 字段名推断 | 低 |
| 4 | `fRate` | `fRate` | 浮点数 | 待确认 | 待确认 | 待确认 |

## Partner\PartnerActVoice.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nActIndex` | `nActIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `dwActID` | `dwActID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szVoicePath` | `szVoicePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `SoundEvent` | `szSoundEvent` | 字符串 | 待确认 | 待确认 | 待确认 |

## Partner\PartnerCombatInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwNpcID` | `dwNpcID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szNpcName` | `szNpcName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `szMorphAvatarPath` | `szMorphAvatarPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nMorphAvatarFrame` | `nMorphAvatarFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `szAvatarPath` | `szAvatarPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `nAvatarFrame` | `nAvatarFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `dwBuffID` | `dwBuffID` | 整数 | Buff ID | 字段名推断 | 低 |
| 8 | `dwMaxPower` | `dwMaxPower` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `bPoint` | `bPoint` | 布尔 | 待确认 | 待确认 | 待确认 |
| 10 | `dwUltSkillID` | `dwUltSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 11 | `dwTemplateID` | `dwTemplateID` | 整数 | 待确认 | 待确认 | 待确认 |

## Partner\PartnerDrawStory.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `dwPartnerID` | `dwPartnerID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 4 | `szStory` | `szStory` | 字符串 | 坐标/尺寸配置 | 翻译列/字段名 | 中 |

## Partner\PartnerGiftInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwPartnerID` | `dwPartnerID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |

## Partner\PartnerKungfu.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szPath` | `szPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## Partner\PartnerMessage.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szAvatarPath` | `szAvatarPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nAvatarFrame` | `nAvatarFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `szGuide` | `szGuide` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## Partner\PartnerMorphSkill.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `dwEnterSkillID` | `dwEnterSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 3 | `dwExSkillID` | `dwExSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 4 | `dwExAndUltSkillID` | `dwExAndUltSkillID` | 整数 | 技能ID | 字段名推断 | 低 |

## Partner\PartnerNpcInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `nKungfuIndex` | `nKungfuIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 4 | `szImgUnknownPath` | `szImgUnknownPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `dwOrigModelID` | `dwOrigModelID` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `fScale` | `fScale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 7 | `fScaleMB` | `fScaleMB` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 8 | `szCamera` | `szCamera` | 字符串 | 待确认 | 待确认 | 待确认 |
| 9 | `szSmallAvatarPath` | `szSmallAvatarPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `nSmallAvatarFrame` | `nSmallAvatarFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 11 | `szMeetAvatarPath` | `szMeetAvatarPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 12 | `nMeetAvatarFrame` | `nMeetAvatarFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 13 | `szUnlockAvatarPath` | `szUnlockAvatarPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 14 | `nUnlockAvatarFrame` | `nUnlockAvatarFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 15 | `szBgPath` | `szBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 16 | `szEquipAvatarPath` | `szEquipAvatarPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 17 | `nEquipAvatarFrame` | `nEquipAvatarFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 18 | `bCanMorph` | `bCanMorph` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `nRoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 20 | `nDefaultActID` | `nDefaultActID` | 整数 | 待确认 | 待确认 | 待确认 |
| 21 | `bSheath` | `bSheath` | 布尔 | 待确认 | 待确认 | 待确认 |
| 22 | `bOutOfPrint` | `bOutOfPrint` | 布尔 | 待确认 | 待确认 | 待确认 |
| 23 | `bTryOut` | `bTryOut` | 布尔 | 待确认 | 待确认 | 待确认 |
| 24 | `szAvatarImg` | `szAvatarImg` | 字符串 | 待确认 | 待确认 | 待确认 |
| 25 | `szBigAvatarImg` | `szBigAvatarImg` | 字符串 | 待确认 | 待确认 | 待确认 |
| 26 | `szSmallAvatarImg` | `szSmallAvatarImg` | 字符串 | 待确认 | 待确认 | 待确认 |
| 27 | `szEquipmentOwnerName` | `szEquipmentOwnerName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 28 | `nRarity` | `nRarity` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 29 | `szIntroduce` | `szIntroduce` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 30 | `szNickName` | `szNickName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 31 | `nPrice` | `nPrice` | 整数 | 待确认 | 待确认 | 待确认 |
| 32 | `nFilterWay` | `nFilterWay` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 33 | `szDrawItemList` | `szDrawItemList` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 34 | `nQuality` | `nQuality` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 35 | `szLimitTip` | `szLimitTip` | 字符串 | 待确认 | 待确认 | 待确认 |
| 36 | `szLimitIconPath` | `szLimitIconPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 37 | `nLimitIconFrame` | `nLimitIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 38 | `bAIChat` | `bAIChat` | 布尔 | 待确认 | 待确认 | 待确认 |

## Partner\PartnerQuality.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nQuality` | `nQuality` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 2 | `szImgTravelBgPath` | `szImgTravelBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nTravelBgFrame` | `nTravelBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `szImgAvatarBgPath` | `szImgAvatarBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `nAvatarBgFrame` | `nAvatarBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `szImgAvatarCirclePath` | `szImgAvatarCirclePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `nAvatarCircleFrame` | `nAvatarCircleFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## Partner\PartnerSkill.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwPartnerID` | `dwPartnerID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `dwSkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 3 | `nSkillLevel` | `nSkillLevel` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 4 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 5 | `nOpenStage` | `nOpenStage` | 整数 | 开关/条件配置 | 字段名推断 | 低 |

## Partner\PartnerSkillEffect.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwSkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 2 | `dwMorphID` | `dwMorphID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szUITex` | `szUITex` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 5 | `bAnimate` | `bAnimate` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## Partner\PartnerStageInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwPartnerID` | `dwPartnerID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nStage` | `nStage` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 4 | `dwSkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 5 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |

## Partner\PartnerStory.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `dwPartnerID` | `dwPartnerID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `nOpenLevel` | `nOpenLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 4 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 5 | `szContent` | `szContent` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `dwQuestID` | `dwQuestID` | 整数 | 任务ID | 字段名推断 | 低 |

## Partner\PartnerTrackInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwPartnerID` | `dwPartnerID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nLinkID` | `nLinkID` | 整数 | 链接/跳转配置 | 字段名推断 | 低 |
| 3 | `dwMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |

## Partner\PartnerTravelClass.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nDataIndex` | `nDataIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szClassName` | `szClassName` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nLimitType` | `nLimitType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nLimitNum` | `nLimitNum` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 5 | `szGiftItem` | `szGiftItem` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 6 | `szGiftMessage` | `szGiftMessage` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `szImgTeamBgPath` | `szImgTeamBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `nTeamBgFrame` | `nTeamBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 9 | `szCostItemMultiCount` | `szCostItemMultiCount` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 10 | `bDungeon` | `bDungeon` | 布尔 | 待确认 | 待确认 | 待确认 |

## Partner\PartnerTravelTask.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 4 | `nDataIndex` | `nDataIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 5 | `dwAdventureID` | `dwAdventureID` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `dwMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 7 | `szCostList` | `szCostList` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 8 | `nTime` | `nTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 9 | `nNeedPartnerNum` | `nNeedPartnerNum` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 10 | `szPreAchievement` | `szPreAchievement` | 字符串 | 成就相关配置 | 字段名推断 | 低 |
| 11 | `szPreQuest` | `szPreQuest` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 12 | `szPreFame` | `szPreFame` | 字符串 | 待确认 | 待确认 | 待确认 |
| 13 | `szLink` | `szLink` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 14 | `szPartnerQuality` | `szPartnerQuality` | 字符串 | 等级/品质 | 字段名推断 | 低 |
| 15 | `szGiftItem` | `szGiftItem` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 16 | `szRandomGiftItem` | `szRandomGiftItem` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 17 | `szReputation` | `szReputation` | 字符串 | 待确认 | 待确认 | 待确认 |
| 18 | `szFame` | `szFame` | 字符串 | 待确认 | 待确认 | 待确认 |
| 19 | `szAchievement` | `szAchievement` | 字符串 | 成就相关配置 | 字段名推断 | 低 |
| 20 | `szTryAdventure` | `szTryAdventure` | 字符串 | 待确认 | 待确认 | 待确认 |
| 21 | `szImgSmallBgPath` | `szImgSmallBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 22 | `nSmallBgFrame` | `nSmallBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 23 | `szImgBigBgPath` | `szImgBigBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 24 | `nBigBgFrame` | `nBigBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## Partner\PartnerTravelTeam.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 字段名推断 | 低 |
| 3 | `dwQuestID` | `dwQuestID` | 整数 | 任务ID | 字段名推断 | 低 |
| 4 | `szUnLockTip` | `szUnlockTip` | 字符串 | 待确认 | 待确认 | 待确认 |

## Partner\PartnerVoice.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `dwPartnerID` | `dwPartnerID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nOpenLevel` | `nOpenLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 5 | `szDesc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 6 | `szPath` | `szPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `SoundEvent` | `szSoundEvent` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `dwQuestID` | `dwQuestID` | 整数 | 任务ID | 字段名推断 | 低 |

## pathlist.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `szID` | 字符串 | ID | 字段名推断 | 低 |
| 2 | `PATH` | `szPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `PATH_MOBILE` | `szPathMobile` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `DisableMapID` | `szDisableMapID` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |

## pendant_back.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `TabType` | `dwType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `TabIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 4 | `BuffID` | `dwBuffID` | 整数 | Buff ID | 字段名推断 | 低 |

## pendant_face.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `TabType` | `dwType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `TabIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 4 | `BuffID` | `dwBuffID` | 整数 | Buff ID | 字段名推断 | 低 |

## pendant_waist.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `TabType` | `dwType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `TabIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 4 | `BuffID` | `dwBuffID` | 整数 | Buff ID | 字段名推断 | 低 |

## PendantEffect.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwEffectID` | `dwEffectID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szRoleType` | `szRoleType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 4 | `szType` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 5 | `nSource` | `nSource` | 整数 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `szDes` | `szDes` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `szSource` | `szSource` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `bHide` | `bHide` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 9 | `szImgPath` | `szImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `RepresentID` | `dwRepresentID` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `dwSkillSkinID` | `dwSkillSkinID` | 整数 | 技能ID | 字段名推断 | 低 |

## PendantNew.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwItemIndex` | `dwItemIndex` | 整数 | 道具索引 | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `szType` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 5 | `dwDLCID` | `dwDLCID` | 整数 | DLC/资料片ID | 字段名推断 | 低 |
| 6 | `dwSource` | `dwSource` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `szGuide` | `szGuide` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `bLimited` | `bLimited` | 布尔 | 待确认 | 待确认 | 待确认 |
| 9 | `bHide` | `bHide` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## PendantPet\AttributeInfo.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwItemIndex` |  | 未知 | 道具索引 | 字段名推断 | 低 |
| 2 | `AttrubuteID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `Name` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `PosID` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `IconID` |  | 未知 | 图标ID | 字段名推断 | 低 |
| 6 | `Tip` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 7 | `BgPath` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `BgFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |

## PendantPet\CameraParam.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwIndex` |  | 未知 | 索引/排序 | 字段名推断 | 低 |
| 2 | `nRoleType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `Comment` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `MaxXYZ` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 5 | `MaxLookatXYZ` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 6 | `MaxRoleYaw` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 7 | `MinXYZ` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `MinLookatXYZ` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `MinRoleYaw` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 10 | `InitPosition` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## PendantPet\PosInfo.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwItemdex` |  | 未知 | 道具相关配置 | 字段名推断 | 低 |
| 2 | `PosID` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 3 | `Name` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `CharacterIconPath` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `NormalFrameC` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `OverFrameC` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `SelectFrameC` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `CoinShopIconPath` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `NormalFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 10 | `OverFrame` |  | 未知 | 悬停/经过状态帧号 | 字段名推断 | 低 |
| 11 | `SelectFrame` |  | 未知 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 12 | `CameraParam` |  | 未知 | 脚本/参数配置 | 字段名推断 | 低 |
| 13 | `MobileIconPath` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |

## pendantpos.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `ClassID` | `dwClassID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `ClassName` | `szClassName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 4 | `Key` | `szKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 6 | `szMinKey` | `szMinKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `szMaxKey` | `szMaxKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 8 | `nStep` | `nStep` | 浮点数 | 待确认 | 待确认 | 待确认 |

## PengLaiSkillCallIDList.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwSkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |

## PerfumeItemList.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTabType` | `dwTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `bShop` | `bShop` | 布尔 | 待确认 | 待确认 | 待确认 |
| 4 | `dwGroup` | `dwGroup` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 5 | `dwShopID` | `dwShopID` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `nPage` | `nPage` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `nItemPos` | `nItemPos` | 整数 | 道具相关配置 | 字段名推断 | 低 |

## person_label.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `id` | `id` | 整数 | ID | 字段名推断 | 低 |
| 2 | `title` | `title` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `count_coff` | `count_coff` | 浮点数 | 数量/计数 | 字段名推断 | 低 |
| 4 | `desc` | `desc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 5 | `tips` | `tips` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `image_file` | `image_file` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `image_norframe` | `image_norframe` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 8 | `image_overframe` | `image_overframe` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 9 | `image_greyframe` | `image_greyframe` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 10 | `image_overframe1` | `image_overframe1` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 11 | `queue` | `queue` | 整数 | 待确认 | 待确认 | 待确认 |

## PersonalCard.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwDecorationID` | `dwDecorationID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nDecorationType` | `nDecorationType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `szPath` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 6 | `szVKPath` | `szVKPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `szSmallPath` | `szSmallPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `nSmallFrame` | `nSmallFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 9 | `szVKSmallPath` | `szVKSmallPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `szSFX` | `szSFX` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 11 | `nSource` | `nSource` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `szTip` | `szTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 13 | `LogicID` | `dwLogicID` | 整数 | 待确认 | 待确认 | 待确认 |
| 14 | `nW` | `nW` | 整数 | 待确认 | 待确认 | 待确认 |
| 15 | `nH` | `nH` | 整数 | 待确认 | 待确认 | 待确认 |
| 16 | `bShowWhenNotGot` | `bShowWhenNotGot` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## PersonalCardBoxMoney.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `nCost` | `nCostMoney` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |

## PersonalCardData.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nType` | `nKey` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 4 | `nVersion` | `nVersion` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `nLevelValue1` | `nLevelValue1` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 6 | `szImagePath1` | `szImagePath1` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `nImageFrame1` | `nImageFrame1` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 8 | `nLevelValue2` | `nLevelValue2` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 9 | `szImagePath2` | `szImagePath2` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `nImageFrame2` | `nImageFrame2` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 11 | `nLevelValue3` | `nLevelValue3` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 12 | `szImagePath3` | `szImagePath3` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 13 | `nImageFrame3` | `nImageFrame3` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 14 | `nLevelValue4` | `nLevelValue4` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 15 | `szImagePath4` | `szImagePath4` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 16 | `nImageFrame4` | `nImageFrame4` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 17 | `nLevelValue5` | `nLevelValue5` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 18 | `szImagePath5` | `szImagePath5` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 19 | `nImageFrame5` | `nImageFrame5` | 整数 | 图片资源配置 | 字段名推断 | 低 |

## PetSkill.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TemplateID` | `dwNpcTemplateID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `AvatarPath` | `szAvatarPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `SkillID1` | `nSkillID1` | 整数 | 技能ID | 字段名推断 | 低 |
| 4 | `Level1` | `nLevel1` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 5 | `SkillID2` | `nSkillID2` | 整数 | 技能ID | 字段名推断 | 低 |
| 6 | `Level2` | `nLevel2` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 7 | `SkillID3` | `nSkillID3` | 整数 | 技能ID | 字段名推断 | 低 |
| 8 | `Level3` | `nLevel3` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 9 | `SkillID4` | `nSkillID4` | 整数 | 技能ID | 字段名推断 | 低 |
| 10 | `Level4` | `nLevel4` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 11 | `SkillID5` | `nSkillID5` | 整数 | 技能ID | 字段名推断 | 低 |
| 12 | `Level5` | `nLevel5` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 13 | `SkillID6` | `nSkillID6` | 整数 | 技能ID | 字段名推断 | 低 |
| 14 | `Level6` | `nLevel6` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 15 | `SkillID7` | `nSkillID7` | 整数 | 技能ID | 字段名推断 | 低 |
| 16 | `Level7` | `nLevel7` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 17 | `SkillID8` | `nSkillID8` | 整数 | 技能ID | 字段名推断 | 低 |
| 18 | `Level8` | `nLevel8` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 19 | `SkillID9` | `nSkillID9` | 整数 | 技能ID | 字段名推断 | 低 |
| 20 | `Level9` | `nLevel9` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 21 | `SkillID10` | `nSkillID10` | 整数 | 技能ID | 字段名推断 | 低 |
| 22 | `Level10` | `nLevel10` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 23 | `SkillID11` | `nSkillID11` | 整数 | 技能ID | 字段名推断 | 低 |
| 24 | `Level11` | `nLevel11` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 25 | `SkillID12` | `nSkillID12` | 整数 | 技能ID | 字段名推断 | 低 |
| 26 | `Level12` | `nLevel12` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 27 | `SkillID13` | `nSkillID13` | 整数 | 技能ID | 字段名推断 | 低 |
| 28 | `Level13` | `nLevel13` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 29 | `SkillID14` | `nSkillID14` | 整数 | 技能ID | 字段名推断 | 低 |
| 30 | `Level14` | `nLevel14` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 31 | `SkillID15` | `nSkillID15` | 整数 | 技能ID | 字段名推断 | 低 |
| 32 | `Level15` | `nLevel15` | 整数 | 等级/品质 | 字段名推断 | 低 |

## PetSkillChange.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `NpcTemplateID` | `dwNpcTemplateID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `OldSkillID` | `nOldSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 3 | `OldSkillLevel` | `nOldSkillLevel` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 4 | `NewSkillID` | `nNewSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 5 | `NewSkillLevel` | `nNewSkillLevel` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 6 | `QixueSkillList` | `szQixueSkillList` | 字符串 | 技能相关配置 | 字段名推断 | 低 |

## pinyin.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `key` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 2 | `pinyin` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `char` |  | 未知 | 待确认 | 待确认 | 待确认 |

## PLActionBarSkill.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwSkillID` | `nSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 2 | `bIsPermanent` | `bIsPermanent` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 3 | `nSortLevel` | `nSortLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |

## player_miniavatar.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwPlayerMiniAvatarID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `Type` | `dwType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `KindID` | `dwKindID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `FileName` | `szFileName` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `Description` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |

## PlayerReturnBox.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `NormalPath` | `szNormalPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `NormalFrame` | `nNormalFrame` | 整数 | 普通状态帧号 | 字段名推断 | 低 |
| 4 | `OverPath` | `szOverPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `OverFrame` | `nOverFrame` | 整数 | 悬停/经过状态帧号 | 字段名推断 | 低 |
| 6 | `DownPath` | `szDownPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `DownFrame` | `nDownFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `NotNormalPath` | `szNotNormalPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `NotNormalFrame` | `nNotNormalFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 10 | `NotOverPath` | `szNotOverPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 11 | `NotOverFrame` | `nNotOverFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 12 | `NotDownPath` | `szNotDownPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 13 | `NotDownFrame` | `nNotDownFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## PlayerReturnShow.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `GradeID` | `nGradeID` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `Path` | `szImgPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `Frame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 5 | `DesPath1` | `szDesImgPath1` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `DesFrame1` | `nDesFrame1` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `DesPath2` | `szDesImgPath2` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `DesFrame2` | `nDesFrame2` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## PlotSoundInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `Name` | `szNpcName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `AvatarPath` | `szAvatarPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `AvatarFrame` | `nAvatarFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `BGPath` | `szBGPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `BGFrame` | `nBGFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `SoundPath` | `szSoundPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `bCanClose` | `bCanClose` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## PointsDrawGiftInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nPoolIndex` | `nPoolIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `nItemType` | `nItemType` | 整数 | 道具类型 | 字段名推断 | 低 |
| 4 | `dwItemIndex` | `dwItemIndex` | 整数 | 道具索引 | 字段名推断 | 低 |
| 5 | `nNum` | `nNum` | 整数 | 数量/计数 | 字段名推断 | 低 |

## PointsDrawPool.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szImgNamePath` | `szImgNamePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 5 | `szImgExteriorPath` | `szImgExteriorPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `nMaxDrawCount` | `nMaxDrawCount` | 整数 | 数量/计数 | 字段名推断 | 低 |

## PointsDrawPreviewGift.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nPoolIndex` | `nPoolIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `nDrawCount` | `nDrawCount` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 3 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 5 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## PopupRemind.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szSfxPath` | `szSfxPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `szImagePath` | `szImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nImageFrame` | `nImageFrame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 5 | `szText` | `szText` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `nTime` | `nTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 7 | `szLink` | `szLink` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |

## pqobjective.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `PQTemplateID` | `dwPQTemplateID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `Objective0` | `szObjective1` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `Objective1` | `szObjective2` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `Objective2` | `szObjective3` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 5 | `Objective3` | `szObjective4` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 6 | `Objective4` | `szObjective5` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 7 | `Objective5` | `szObjective6` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 8 | `Objective6` | `szObjective7` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 9 | `Objective7` | `szObjective8` | 多语言文本 | 待确认 | 待确认 | 待确认 |

## PQTeachInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwPQID` | `dwPQID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `dwTeachID` | `dwTeachID` | 整数 | 待确认 | 待确认 | 待确认 |

## ProfessionName.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |

## ProgressBar.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Side` | `szSide` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `OffsetX` | `fOffsetX` | 浮点数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `OffsetY` | `fOffsetY` | 浮点数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `Left_Right` | `bLeft_Right` | 布尔 | 待确认 | 待确认 | 待确认 |
| 6 | `Way` | `nWay` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `ImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `Frame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 9 | `SFXPath` | `szSFXPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `FullSFXPath` | `szFullSFXPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 11 | `Tip` | `szTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 12 | `szIniName` | `szIniName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 13 | `szMobileProgressColor` | `szMobileProgressColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |

## ProgressBarPlus.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `id` | `id` | 整数 | ID | 字段名推断 | 低 |
| 2 | `ui` | `ui` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `type` | `type` | 字符串 | 类型/分类 | 字段名推断 | 低 |

## ProtocolToAvi.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `AviPath` | `szAviPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## puppetinfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `roletype` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `path1` | `szPath1` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `path2` | `szPath2` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `path3` | `szPath3` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `path4` | `szPath4` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `path5` | `szPath5` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `path6` | `szPath6` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `x` | `x` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 9 | `y` | `y` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 10 | `z` | `z` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `scale` | `scale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 12 | `ani` | `ani` | 路径 | 待确认 | 待确认 | 待确认 |

## PuppetSkill.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TemplateID` | `dwNpcTemplateID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `Group` | `szGroup` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 3 | `SkillID1` | `nSkillID1` | 整数 | 技能ID | 字段名推断 | 低 |
| 4 | `Level1` | `nLevel1` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 5 | `SkillID2` | `nSkillID2` | 整数 | 技能ID | 字段名推断 | 低 |
| 6 | `Level2` | `nLevel2` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 7 | `SkillID3` | `nSkillID3` | 整数 | 技能ID | 字段名推断 | 低 |
| 8 | `Level3` | `nLevel3` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 9 | `SkillID4` | `nSkillID4` | 整数 | 技能ID | 字段名推断 | 低 |
| 10 | `Level4` | `nLevel4` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 11 | `SkillID5` | `nSkillID5` | 整数 | 技能ID | 字段名推断 | 低 |
| 12 | `Level5` | `nLevel5` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 13 | `SkillID6` | `nSkillID6` | 整数 | 技能ID | 字段名推断 | 低 |
| 14 | `Level6` | `nLevel6` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 15 | `SkillID7` | `nSkillID7` | 整数 | 技能ID | 字段名推断 | 低 |
| 16 | `Level7` | `nLevel7` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 17 | `SkillID8` | `nSkillID8` | 整数 | 技能ID | 字段名推断 | 低 |
| 18 | `Level8` | `nLevel8` | 整数 | 等级/品质 | 字段名推断 | 低 |

## PVPArenaLiveBan.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szServer` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## PVPCastSkill.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `SkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |

## PVPHideSkill.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `SkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |

## PVPLinkDate.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `LineID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Start` | `szStart` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `End` | `szEnd` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `StarShine` | `szStartShine` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `EndShine` | `szEndShine` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `szPath` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `szTip` | `szTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## PVPLogoInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szServer` | `szServer` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `szName1` | `szName1` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `szPath1` | `szPath1` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `szName2` | `szName2` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `szPath2` | `szPath2` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `szName3` | `szName3` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `szPath3` | `szPath3` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `szName4` | `szName4` | 字符串 | 待确认 | 待确认 | 待确认 |
| 10 | `szPath4` | `szPath4` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 11 | `szName5` | `szName5` | 字符串 | 待确认 | 待确认 | 待确认 |
| 12 | `szPath5` | `szPath5` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 13 | `szName6` | `szName6` | 字符串 | 待确认 | 待确认 | 待确认 |
| 14 | `szPath6` | `szPath6` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |

## PVPMapInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nMapID` | `nMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 2 | `szMapName` | `szMapName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `nMapFrame` | `nMapFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `nMapNameFrame` | `nMapNameFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `szSFXName` | `szSFXName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `PathL` | `szPathL` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `FrameL` | `nFrameL` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `PathR` | `szPathR` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `FrameR` | `nFrameR` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## PVPShowMapGlobalView.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `MapID` | `MapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 2 | `x` | `x` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 3 | `y` | `y` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `z` | `z` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `yaw` | `yaw` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `maxheight` | `maxheight` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |

## PVPTimeNum.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Num` | `dwNum` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 2 | `Path` | `szPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `Frame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## QMSoul.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwNpcID` | `dwNpcID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 字段名推断 | 低 |
| 4 | `szTitleImagePath` | `szTitleImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `nTitleImageFrame` | `nTitleImageFrame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 6 | `szHometown` | `szHometown` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `szNpcSFXPath` | `szNpcSFXPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `szVkImgPath` | `szVkImgPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `dwQuestID1` | `dwQuestID1` | 整数 | 任务ID | 字段名推断 | 低 |
| 10 | `szTaskContent1` | `szTaskContent1` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 11 | `dwQuestID2` | `dwQuestID2` | 整数 | 任务ID | 字段名推断 | 低 |
| 12 | `szTaskContent2` | `szTaskContent2` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 13 | `dwQuestID3` | `dwQuestID3` | 整数 | 任务ID | 字段名推断 | 低 |
| 14 | `szTaskContent3` | `szTaskContent3` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 15 | `dwQuestID4` | `dwQuestID4` | 整数 | 任务ID | 字段名推断 | 低 |
| 16 | `szTaskContent4` | `szTaskContent4` | 字符串 | 文本内容 | 字段名推断 | 低 |

## quest_survey.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ForceID` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 2 | `QuestID` | `dwQuestID` | 整数 | 任务ID | 字段名推断 | 低 |

## QuestClass.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szClass` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 3 | `DLCID` | `dwDLCID` | 整数 | DLC/资料片ID | 字段名推断 | 低 |
| 4 | `DLCMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |

## QuestGuide\quest.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `QuestID` | `dwQuestID` | 整数 | 任务ID | 字段名推断 | 低 |
| 2 | `Accept` | `szAccept` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `Finish` | `szFinish` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 4 | `QuestState1` | `szQuestState1` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 5 | `QuestState2` | `szQuestState2` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 6 | `QuestState3` | `szQuestState3` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 7 | `QuestState4` | `szQuestState4` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 8 | `QuestState5` | `szQuestState5` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 9 | `QuestState6` | `szQuestState6` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 10 | `QuestState7` | `szQuestState7` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 11 | `QuestState8` | `szQuestState8` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 12 | `KillNpc1` | `szKillNpc1` | 字符串 | 待确认 | 待确认 | 待确认 |
| 13 | `KillNpc2` | `szKillNpc2` | 字符串 | 待确认 | 待确认 | 待确认 |
| 14 | `KillNpc3` | `szKillNpc3` | 字符串 | 待确认 | 待确认 | 待确认 |
| 15 | `KillNpc4` | `szKillNpc4` | 字符串 | 待确认 | 待确认 | 待确认 |
| 16 | `NeedItem1` | `szNeedItem1` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 17 | `NeedItem2` | `szNeedItem2` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 18 | `NeedItem3` | `szNeedItem3` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 19 | `NeedItem4` | `szNeedItem4` | 字符串 | 道具相关配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_1.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_10.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_100.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_101.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_102.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_103.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_104.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_105.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_106.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_107.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_108.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_109.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_11.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_110.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_111.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_112.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_113.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_114.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_115.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_116.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_117.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_118.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_119.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_12.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_120.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_121.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_122.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_123.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_125.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_126.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_127.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_128.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_129.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_13.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_130.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_131.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_132.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_133.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_134.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_135.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_136.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_137.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_138.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_139.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_14.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_140.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_141.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_142.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_148.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_149.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_15.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_150.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_151.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_152.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_153.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_155.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_156.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_157.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_158.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_159.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_16.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_160.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_161.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_162.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_163.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_164.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_165.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_167.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_169.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_17.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_170.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_171.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_172.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_173.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_174.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_175.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_176.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_177.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_179.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_18.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_181.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_182.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_184.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_187.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_19.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_191.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_192.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_193.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_194.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_195.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_196.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_197.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_199.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_2.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_20.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_200.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_201.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_203.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_204.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_209.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_21.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_213.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_214.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_215.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_216.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_217.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_219.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_22.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_220.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_221.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_224.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_225.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_227.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_228.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_229.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_23.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_230.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_231.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_232.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_233.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_238.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_239.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_240.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_241.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_242.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_243.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_247.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_249.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_25.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_256.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_257.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_26.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_262.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_263.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_264.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_27.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_28.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_283.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_284.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_285.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_286.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_29.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_291.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_292.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_298.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_299.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_30.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_300.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_302.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_32.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_325.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_33.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_330.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_332.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_333.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_334.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_337.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_34.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_341.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_342.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_343.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_344.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_347.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_35.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_355.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_356.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_357.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_358.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_359.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_36.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_364.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_368.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_37.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_371.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_38.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_39.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_40.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_406.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_41.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_411.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_412.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_419.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_42.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_426.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_427.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_428.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_43.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_431.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_432.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_44.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_444.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_445.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_45.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_451.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_452.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_453.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_454.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_455.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_459.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_46.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_462.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_464.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_467.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_468.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_469.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_47.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_471.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_473.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_474.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_475.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_476.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_478.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_48.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_480.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_481.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_482.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_483.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_484.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_486.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_488.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_489.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_49.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_490.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_5.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_50.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_51.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_511.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_513.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_518.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_52.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_521.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_522.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_523.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_524.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_525.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_526.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_529.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_53.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_55.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_552.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_559.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_56.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_562.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_564.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_566.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_57.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_573.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_576.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_578.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_579.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_58.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_580.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_581.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_582.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_586.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_591.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_597.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_599.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_6.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_60.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_601.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_606.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_607.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_61.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_62.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_621.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_623.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_624.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_627.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_63.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_630.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_634.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_636.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_639.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_64.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_642.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_643.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_647.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_648.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_65.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_650.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_652.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_653.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_654.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_659.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_66.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_665.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_666.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_667.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_668.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_67.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_673.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_674.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_68.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_683.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_684.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_685.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_686.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_69.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_690.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_691.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_693.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_694.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_695.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_697.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_7.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_70.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_701.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_702.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_703.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_704.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_706.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_71.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_713.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_716.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_717.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_718.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_72.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_722.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_726.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_73.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_74.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_75.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_785.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_787.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_788.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_789.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_793.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_8.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_807.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questdoodad_9.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_1.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_10.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_100.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_101.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_102.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_103.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_104.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_105.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_106.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_107.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_108.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_109.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_11.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_110.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_111.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_112.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_113.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_114.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_115.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_116.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_117.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_118.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_119.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_12.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_120.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_121.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_122.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_123.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_125.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_126.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_127.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_128.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_129.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_13.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_130.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_131.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_132.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_133.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_134.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_135.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_136.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_137.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_138.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_139.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_14.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_140.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_141.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_142.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_148.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_149.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_15.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_150.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_151.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_152.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_153.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_155.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_156.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_157.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_158.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_159.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_16.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_160.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_161.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_162.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_163.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_164.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_165.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_167.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_169.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_17.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_170.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_171.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_172.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_173.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_174.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_175.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_176.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_177.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_179.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_18.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_181.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_182.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_184.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_187.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_19.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_191.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_192.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_193.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_194.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_195.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_196.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_197.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_199.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_2.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_20.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_200.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_201.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_203.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_204.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_209.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_21.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_213.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_214.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_215.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_216.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_217.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_219.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_22.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_220.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_221.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_224.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_225.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_227.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_228.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_229.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_23.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_230.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_231.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_232.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_233.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_239.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_240.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_241.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_242.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_243.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_247.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_249.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_25.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_256.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_257.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_26.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_262.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_263.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_264.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_27.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_28.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_283.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_284.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_285.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_286.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_29.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_291.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_292.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_298.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_299.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_3.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_30.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_300.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_302.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_32.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_325.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_33.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_330.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_332.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_333.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_334.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_337.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_339.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_34.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_341.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_342.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_343.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_344.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_347.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_35.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_355.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_356.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_357.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_358.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_359.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_36.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_364.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_368.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_37.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_371.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_38.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_39.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_40.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_406.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_41.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_411.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_419.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_42.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_426.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_427.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_428.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_43.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_431.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_432.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_44.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_444.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_445.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_45.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_451.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_452.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_453.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_454.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_455.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_459.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_46.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_462.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_464.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_467.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_468.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_469.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_47.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_471.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_473.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_474.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_475.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_476.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_478.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_48.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_480.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_481.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_482.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_484.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_486.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_488.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_489.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_49.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_490.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_5.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_50.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_51.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_511.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_513.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_518.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_52.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_521.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_522.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_523.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_524.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_525.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_526.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_53.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_55.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_552.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_559.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_56.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_562.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_564.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_566.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_569.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_57.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_573.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_576.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_578.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_579.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_58.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_580.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_581.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_582.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_586.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_591.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_597.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_599.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_6.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_60.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_601.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_606.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_607.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_61.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_62.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_621.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_622.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_623.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_627.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_63.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_630.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_634.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_636.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_639.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_64.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_642.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_643.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_647.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_648.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_65.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_652.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_653.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_654.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_659.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_66.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_665.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_666.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_667.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_668.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_67.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_673.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_674.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_68.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_683.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_684.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_685.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_686.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_69.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_690.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_691.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_693.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_694.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_695.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_697.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_698.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_7.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_70.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_701.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_702.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_703.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_704.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_706.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_71.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_713.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_716.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_717.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_718.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_72.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_722.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_726.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_73.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_74.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_75.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_785.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_787.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_788.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_789.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_793.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_8.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_807.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_9.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questnpc_995.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TempleteId` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `AreaID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `ActivityID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `Positions` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## QuestGuide\questrpg.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `RPGID` | `dwRpgID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `CameraID` | `dwCameraID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `AcceptDes` | `szAcceptDes` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `Text1` | `szText1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `SoundID1` | `nSound1` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `Text2` | `szText2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `SoundID2` | `nSound2` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `Text3` | `szText3` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `SoundID3` | `nSound3` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `Text4` | `szText4` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 11 | `SoundID4` | `nSound4` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `Text5` | `szText5` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 13 | `SoundID5` | `nSound5` | 整数 | 待确认 | 待确认 | 待确认 |
| 14 | `Text6` | `szText6` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 15 | `SoundID6` | `nSound6` | 整数 | 待确认 | 待确认 | 待确认 |
| 16 | `Text7` | `szText7` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 17 | `SoundID7` | `nSound7` | 整数 | 待确认 | 待确认 | 待确认 |
| 18 | `Text8` | `szText8` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 19 | `SoundID8` | `nSound8` | 整数 | 待确认 | 待确认 | 待确认 |
| 20 | `Text9` | `szText9` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 21 | `SoundID9` | `nSound9` | 整数 | 待确认 | 待确认 | 待确认 |
| 22 | `Text10` | `szText10` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 23 | `SoundID10` | `nSound10` | 整数 | 待确认 | 待确认 | 待确认 |
| 24 | `Text11` | `szText11` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 25 | `SoundID11` | `nSound11` | 整数 | 待确认 | 待确认 | 待确认 |
| 26 | `Text12` | `szText12` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 27 | `SoundID12` | `nSound12` | 整数 | 待确认 | 待确认 | 待确认 |
| 28 | `Text13` | `szText13` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 29 | `SoundID13` | `nSound13` | 整数 | 待确认 | 待确认 | 待确认 |
| 30 | `Text14` | `szText14` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 31 | `SoundID14` | `nSound14` | 整数 | 待确认 | 待确认 | 待确认 |
| 32 | `Text15` | `szText15` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 33 | `SoundID15` | `nSound15` | 整数 | 待确认 | 待确认 | 待确认 |

## QuestGuide\RPG\RpgGroup_Default.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `RPGID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `Index` |  | 未知 | 索引/排序 | 字段名推断 | 低 |
| 3 | `AcceptDes` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `SpeakerID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 5 | `CameraID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 6 | `Action` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 7 | `ActionLoop` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `Motion` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `SoundEvent` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 10 | `Text` |  | 未知 | 文本内容 | 字段名推断 | 低 |
| 11 | `CameraBreath` |  | 未知 | 待确认 | 待确认 | 待确认 |

## QuestGuide\RPG\RpgIndex.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `StartRpgID` | `dwStartRpgID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `EndRpgID` | `dwEndRpgID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `Group` | `szGroup` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 4 | `Comment` | `szComment` | 字符串 | 待确认 | 待确认 | 待确认 |

## QuestGuide\shieldquest.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `QuestID` | `dwQuestID` | 整数 | 任务ID | 字段名推断 | 低 |

## QuestGuide\twoPointQuest.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `QuestID` | `dwQuestID` | 整数 | 任务ID | 字段名推断 | 低 |

## QuestIdentityExp.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Type` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `Title` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 3 | `Icon` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |

## Quests.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `QuestID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `QuestName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `Objective` | `szObjective` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `Description` | `szDescription` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 5 | `DunningDialogue` | `szDunningDialogue` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `UnfinishedDialogue` | `szUnfinishedDialogue` | 字符串 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 7 | `FinishedDialogue` | `szFinishedDialogue` | 字符串 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 8 | `Difficulty` | `szQuestDiff` | 字符串 | 任务相关配置 | 翻译列/字段名 | 中 |
| 9 | `StartGossipType` | `nStartGossipType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 10 | `StartGossip1` | `szStartGossip1` | 字符串 | 待确认 | 待确认 | 待确认 |
| 11 | `StartGossip2` | `szStartGossip2` | 字符串 | 待确认 | 待确认 | 待确认 |
| 12 | `StartGossip3` | `szStartGossip3` | 字符串 | 待确认 | 待确认 | 待确认 |
| 13 | `StartGossip4` | `szStartGossip4` | 字符串 | 待确认 | 待确认 | 待确认 |
| 14 | `EndGossipType` | `nEndGossipType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 15 | `EndGossip1` | `szEndGossip1` | 字符串 | 待确认 | 待确认 | 待确认 |
| 16 | `EndGossip2` | `szEndGossip2` | 字符串 | 待确认 | 待确认 | 待确认 |
| 17 | `EndGossip3` | `szEndGossip3` | 字符串 | 待确认 | 待确认 | 待确认 |
| 18 | `EndGossip4` | `szEndGossip4` | 字符串 | 待确认 | 待确认 | 待确认 |
| 19 | `QuestValueStr1` | `szQuestValueStr1` | 字符串 | 任务相关配置 | 翻译列/字段名 | 中 |
| 20 | `QuestValueStr2` | `szQuestValueStr2` | 字符串 | 任务相关配置 | 翻译列/字段名 | 中 |
| 21 | `QuestValueStr3` | `szQuestValueStr3` | 字符串 | 任务相关配置 | 翻译列/字段名 | 中 |
| 22 | `QuestValueStr4` | `szQuestValueStr4` | 字符串 | 任务相关配置 | 翻译列/字段名 | 中 |
| 23 | `QuestValueStr5` | `szQuestValueStr5` | 字符串 | 任务相关配置 | 翻译列/字段名 | 中 |
| 24 | `QuestValueStr6` | `szQuestValueStr6` | 字符串 | 任务相关配置 | 翻译列/字段名 | 中 |
| 25 | `QuestValueStr7` | `szQuestValueStr7` | 字符串 | 任务相关配置 | 翻译列/字段名 | 中 |
| 26 | `QuestValueStr8` | `szQuestValueStr8` | 字符串 | 任务相关配置 | 翻译列/字段名 | 中 |
| 27 | `IsUseScriptedItem` | `bUseItem` | 布尔 | 道具相关配置 | 字段名推断 | 低 |
| 28 | `QuestFinishedObjective` | `szQuestFinishedObjective` | 字符串 | 任务相关配置 | 翻译列/字段名 | 中 |
| 29 | `QuestFailedObjective` | `szQuestFailedObjective` | 字符串 | 任务相关配置 | 翻译列/字段名 | 中 |
| 30 | `BuffID` | `dwQuestBuffID` | 整数 | 任务ID | 字段名推断 | 低 |
| 31 | `ActivityID` | `dwActivityID` | 整数 | 活动ID | 字段名推断 | 低 |
| 32 | `IsAdventure` | `IsAdventure` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 33 | `bShieldFinishEffect` | `bShieldFinishEffect` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 34 | `szAcceptDes` | `szAcceptDes` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 35 | `szFinishDes` | `szFinishDes` | 字符串 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 36 | `AcceptRpgID` | `dwAcceptRpgID` | 整数 | 待确认 | 待确认 | 待确认 |
| 37 | `FinishRpgID` | `dwFinishRpgID` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 38 | `dwDungeonID` | `dwDungeonID` | 整数 | 待确认 | 待确认 | 待确认 |
| 39 | `bActivityPanel` | `bActivityPanel` | 布尔 | 待确认 | 待确认 | 待确认 |
| 40 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 41 | `szProgressBar` | `szProgressBar` | 字符串 | 待确认 | 待确认 | 待确认 |
| 42 | `nChapterID` | `nChapterID` | 整数 | 章节ID | 字段名推断 | 低 |
| 43 | `bCancelTrace` | `bCancelTrace` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 44 | `bCancelQuest` | `bCancelQuest` | 布尔 | 任务相关配置 | 字段名推断 | 低 |
| 45 | `szMobileAcceptDes` | `szMobileAcceptDes` | 字符串 | 待确认 | 待确认 | 待确认 |
| 46 | `szMobileFinishDes` | `szMobileFinishDes` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 47 | `MobileObjective` | `szMobileObjective` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 48 | `MobileDescription` | `szMobileDescription` | 字符串 | 脚本/参数配置 | 翻译列/字段名 | 中 |
| 49 | `MobileDunningDialogue` | `szMobileDunningDialogue` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 50 | `MobileUnfinishedDialogue` | `szMobileUnfinishedDialogue` | 字符串 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 51 | `MobileFinishedDialogue` | `szMobileFinishedDialogue` | 字符串 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 52 | `MobileQuestFinishedObjective` | `szMobileQuestFinishedObjective` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 53 | `MobileQuestFailedObjective` | `szMobileQuestFailedObjective` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 54 | `MobileQuestValueStr1` | `szMobileQuestValueStr1` | 字符串 | 任务相关配置 | 翻译列/字段名 | 中 |
| 55 | `MobileQuestValueStr2` | `szMobileQuestValueStr2` | 字符串 | 任务相关配置 | 翻译列/字段名 | 中 |
| 56 | `MobileQuestValueStr3` | `szMobileQuestValueStr3` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 57 | `MobileQuestValueStr4` | `szMobileQuestValueStr4` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 58 | `MobileQuestValueStr5` | `szMobileQuestValueStr5` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 59 | `MobileQuestValueStr6` | `szMobileQuestValueStr6` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 60 | `MobileQuestValueStr7` | `szMobileQuestValueStr7` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 61 | `MobileQuestValueStr8` | `szMobileQuestValueStr8` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 62 | `BindNPCIDList1` | `szBindNPCIDList1` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 63 | `BindNPCIDList2` | `szBindNPCIDList2` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 64 | `BindNPCIDList3` | `szBindNPCIDList3` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 65 | `BindNPCIDList4` | `szBindNPCIDList4` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 66 | `BindNPCIDList5` | `szBindNPCIDList5` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 67 | `BindNPCIDList6` | `szBindNPCIDList6` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 68 | `BindNPCIDList7` | `szBindNPCIDList7` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 69 | `BindNPCIDList8` | `szBindNPCIDList8` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 70 | `EffectID1` | `nEffectID1` | 整数 | 待确认 | 待确认 | 待确认 |
| 71 | `EffectID2` | `nEffectID2` | 整数 | 待确认 | 待确认 | 待确认 |
| 72 | `EffectID3` | `nEffectID3` | 整数 | 待确认 | 待确认 | 待确认 |
| 73 | `EffectID4` | `nEffectID4` | 整数 | 待确认 | 待确认 | 待确认 |
| 74 | `EffectID5` | `nEffectID5` | 整数 | 待确认 | 待确认 | 待确认 |
| 75 | `EffectID6` | `nEffectID6` | 整数 | 待确认 | 待确认 | 待确认 |
| 76 | `EffectID7` | `nEffectID7` | 整数 | 待确认 | 待确认 | 待确认 |
| 77 | `EffectID8` | `nEffectID8` | 整数 | 待确认 | 待确认 | 待确认 |

## QuestSection.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nSectionID` | `nSectionID` | 整数 | 章节段落ID | 字段名推断 | 低 |
| 2 | `nSeasonID` | `nSeasonID` | 整数 | 赛季ID | 字段名推断 | 低 |
| 3 | `nChapterID` | `nChapterID` | 整数 | 章节ID | 字段名推断 | 低 |
| 4 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 5 | `dwBeginQuestID` | `dwBeginQuestID` | 整数 | 起始任务ID | 字段名推断 | 低 |
| 6 | `dwEndQuestID` | `dwEndQuestID` | 整数 | 结束任务ID | 字段名推断 | 低 |
| 7 | `bHideLock` | `bHideLock` | 布尔 | 是否隐藏锁定状态 | 字段名推断 | 低 |
| 8 | `szDetail` | `szDetail` | 多语言文本 | 详细说明/详情 | 翻译列/字段名 | 中 |
| 9 | `szSoundList` | `szSoundList` | 字符串 | 音效列表 | 字段名推断 | 低 |
| 10 | `_Class1Order` | `_Class1Order` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 11 | `_Class2Order` | `_Class2Order` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 12 | `_Class3Order` | `_Class3Order` | 整数 | 类型/分类 | 字段名推断 | 低 |

## QuestSectionLayer.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szType` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 3 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 4 | `szTime` | `szTime` | 字符串 | 时间配置 | 翻译列/字段名 | 中 |
| 5 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `nImageFrame` | `nImageFrame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 7 | `bHideLock` | `bHideLock` | 布尔 | 是否隐藏锁定状态 | 字段名推断 | 低 |

## QuestType.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szDes` | `szDes` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `nRed` | `nRed` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `nGreen` | `nGreen` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `nBlue` | `nBlue` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `nTraceMin` | `nTraceMin` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `nWeight` | `nWeight` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `unaccept` | `unaccept` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `finished` | `finished` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 10 | `notneedaccept` | `notneedaccept` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 11 | `high_level` | `high_level` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 12 | `lower_level` | `lower_level` | 整数 | 等级/品质 | 字段名推断 | 低 |

## QuickTeamRecruit.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nRecruitID` | `nRecruit` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |

## Ranking.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Type` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `key` | `szKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `ValueName` | `szValueName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `Desc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 7 | `Designation` | `szDesignation` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `MobileDesc` | `szMobileDesc` | 多语言文本 | 待确认 | 待确认 | 待确认 |

## RankingTitle.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Title` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |

## ReadMailPanelInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nForceID` | `nForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 2 | `nLogoFrame` | `nLogoFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 3 | `szLogoPath` | `szLogoPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `szTitle` | `szTitle` | 多语言文本 | 标题文本 | 翻译列/字段名 | 中 |
| 5 | `szText` | `szText` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `szSignature` | `szSignature` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## recipe\cooking.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Name` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `nLevel` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 4 | `szTip` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `bHide` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |

## recipe\CraftSearch.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ItemType` | `dwItemType` | 整数 | 道具类型 | 字段名推断 | 低 |
| 2 | `ItemIndex` | `dwItemIndex` | 整数 | 道具索引 | 字段名推断 | 低 |
| 3 | `CraftID` | `dwCraftID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `RecipeID` | `dwRecipeID` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `BeginAttrib1` | `szAttr1` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `BeginAttrib2` | `szAttr2` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `BeginAttrib3` | `szAttr3` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `BeginAttrib4` | `szAttr4` | 字符串 | 待确认 | 待确认 | 待确认 |
| 9 | `BeginAttrib5` | `szAttr5` | 字符串 | 待确认 | 待确认 | 待确认 |
| 10 | `BeginAttrib6` | `szAttr6` | 字符串 | 待确认 | 待确认 | 待确认 |
| 11 | `BeginAttrib7` | `szAttr7` | 字符串 | 待确认 | 待确认 | 待确认 |
| 12 | `BeginAttrib8` | `szAttr8` | 字符串 | 待确认 | 待确认 | 待确认 |
| 13 | `BeginAttrib9` | `szAttr9` | 字符串 | 待确认 | 待确认 | 待确认 |
| 14 | `BeginAttrib10` | `szAttr10` | 字符串 | 待确认 | 待确认 | 待确认 |
| 15 | `BeginAttrib11` | `szAttr11` | 字符串 | 待确认 | 待确认 | 待确认 |
| 16 | `BeginAttrib12` | `szAttr12` | 字符串 | 待确认 | 待确认 | 待确认 |

## recipe\founding.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Name` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `nLevel` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 4 | `szTip` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `bHide` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |

## recipe\furniture.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Name` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `nLevel` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 4 | `szTip` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `bHide` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |

## recipe\ItemToRecipe.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ItemType` | `dwItemType` | 整数 | 道具类型 | 字段名推断 | 低 |
| 2 | `ItemIndex` | `dwItemIndex` | 整数 | 道具索引 | 字段名推断 | 低 |
| 3 | `CraftID` | `dwCraftID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `RecipeID` | `dwRecipeID` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `CreateItemIndex` | `nCreateItemIndex` | 整数 | 道具ID/索引 | 字段名推断 | 低 |

## recipe\medicine.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Name` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `nLevel` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 4 | `szTip` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `bHide` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |

## recipe\recasting.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Name` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `nLevel` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 4 | `szTip` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## recipe\RecommendEnchant.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `ItemIndex` | `ItemIndex` | 整数 | 道具索引 | 字段名推断 | 低 |
| 3 | `dwRecommendWay` | `dwRecommendWay` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `kungfuID` | `kungfuID` | 字符串 | 心法/内功ID | 字段名推断 | 低 |

## recipe\tailoring.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Name` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `nLevel` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 4 | `szTip` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `bHide` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |

## RecipeBelong.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `BookID` | `dwBookID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `SegmentID` | `dwSegmentID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `BookItemIndex` | `dwBookItemIndex` | 整数 | 道具ID/索引 | 字段名推断 | 低 |
| 4 | `BookNumber` | `dwBookNumber` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 5 | `Sort` | `nSort` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 6 | `SubSort` | `nSubSort` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 7 | `Type` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 8 | `BookName` | `szBookName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `SegmentName` | `szSegmentName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 10 | `Desc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 11 | `PageNum` | `dwPageCount` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 12 | `PageID_0` | `dwPageID_0` | 整数 | 待确认 | 待确认 | 待确认 |
| 13 | `PageID_1` | `dwPageID_1` | 整数 | 待确认 | 待确认 | 待确认 |
| 14 | `PageID_2` | `dwPageID_2` | 整数 | 待确认 | 待确认 | 待确认 |
| 15 | `PageID_3` | `dwPageID_3` | 整数 | 待确认 | 待确认 | 待确认 |
| 16 | `PageID_4` | `dwPageID_4` | 整数 | 待确认 | 待确认 | 待确认 |
| 17 | `PageID_5` | `dwPageID_5` | 整数 | 待确认 | 待确认 | 待确认 |
| 18 | `PageID_6` | `dwPageID_6` | 整数 | 待确认 | 待确认 | 待确认 |
| 19 | `PageID_7` | `dwPageID_7` | 整数 | 待确认 | 待确认 | 待确认 |
| 20 | `PageID_8` | `dwPageID_8` | 整数 | 待确认 | 待确认 | 待确认 |
| 21 | `PageID_9` | `dwPageID_9` | 整数 | 待确认 | 待确认 | 待确认 |
| 22 | `Achievement` | `szAchievement` | 多语言文本 | 成就相关配置 | 字段名推断 | 低 |
| 23 | `SourceTrade` | `bSourceTrade` | 布尔 | 待确认 | 待确认 | 待确认 |
| 24 | `SourceMap` | `szSourceMap` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 25 | `SourceDoodad` | `szSourceDoodad` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 26 | `SourceNpc` | `szSourceNpc` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 27 | `SourceQuest` | `szSourceQuest` | 多语言文本 | 任务相关配置 | 字段名推断 | 低 |
| 28 | `SourceBoss` | `szSourceBoss` | 多语言文本 | 待确认 | 待确认 | 待确认 |

## RecipeBookEx.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `BookID` | `dwBookID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `PresentExamPrint` | `dwPresentExamPrint` | 整数 | 待确认 | 待确认 | 待确认 |

## RecommendEquipInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTabType` | `dwTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `nItemLevel` | `dwLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 5 | `nEquipUsage` | `nEquipUsage` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `nCamp` | `nCamp` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 7 | `szRecommendKungfuID` | `szRecommendKungfuID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `szMagicType1` | `szMagicType1` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 9 | `szMagicType2` | `szMagicType2` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 10 | `szMagicType3` | `szMagicType3` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 11 | `szItemPosition` | `dwPos` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |

## RegionMap.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `RegionID` | `dwRegionID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `RegionName` | `szRegionName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `X` | `nX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `Y` | `nY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `Scale` | `fScale` | 浮点数 | 待确认 | 待确认 | 待确认 |

## RegionSound.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szPath` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nPriority` | `nPriority` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |

## ReportUIData.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Name` | `szFrameName` | 字符串 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 2 | `Group` | `Group` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `Desc` | `szDesc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 4 | `OnLButtonClick` | `OnLButtonClick` | 布尔 | 待确认 | 待确认 | 待确认 |
| 5 | `OnItemLButtonClick` | `OnItemLButtonClick` | 布尔 | 道具相关配置 | 字段名推断 | 低 |
| 6 | `OnFrameOpen` | `OnFrameOpen` | 布尔 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `OnFrameClose` | `OnFrameClose` | 布尔 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `OnFrameShow` | `OnFrameShow` | 布尔 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 9 | `OnFrameHide` | `OnFrameHide` | 布尔 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 10 | `OnCheckBoxCheck` | `OnCheckBoxCheck` | 布尔 | 待确认 | 待确认 | 待确认 |
| 11 | `OnCheckBoxUncheck` | `OnCheckBoxUncheck` | 布尔 | 待确认 | 待确认 | 待确认 |
| 12 | `OnActivePage` | `OnActivePage` | 布尔 | 待确认 | 待确认 | 待确认 |

## ReportUIData_Block.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Name` | `szFrameName` | 字符串 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 2 | `bFuzzyMatch` | `bFuzzyMatch` | 布尔 | 待确认 | 待确认 | 待确认 |
| 3 | `bBlockAll` | `bBlockAll` | 布尔 | 待确认 | 待确认 | 待确认 |
| 4 | `OnLButtonClick` | `OnLButtonClick` | 布尔 | 待确认 | 待确认 | 待确认 |
| 5 | `OnItemLButtonClick` | `OnItemLButtonClick` | 布尔 | 道具相关配置 | 字段名推断 | 低 |
| 6 | `OnFrameOpen` | `OnFrameOpen` | 布尔 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `OnFrameClose` | `OnFrameClose` | 布尔 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `OnFrameShow` | `OnFrameShow` | 布尔 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 9 | `OnFrameHide` | `OnFrameHide` | 布尔 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 10 | `OnCheckBoxCheck` | `OnCheckBoxCheck` | 布尔 | 待确认 | 待确认 | 待确认 |
| 11 | `OnCheckBoxUncheck` | `OnCheckBoxUncheck` | 布尔 | 待确认 | 待确认 | 待确认 |
| 12 | `OnActivePage` | `OnActivePage` | 布尔 | 待确认 | 待确认 | 待确认 |

## Reputation\ReputationForceGroup.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nDlcID` | `nDlcID` | 整数 | DLC/资料片ID | 字段名推断 | 低 |
| 2 | `GroupName` | `szGroupName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 3 | `ForceID` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |

## Reputation\ReputationForceInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwForceID` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szIconPath` | `szIconPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `dwNpcLinkID` | `dwNpcLinkID` | 整数 | 链接/跳转配置 | 字段名推断 | 低 |
| 5 | `szDesc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 6 | `szMapIDs` | `szMapIDs` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `bHide` | `bHide` | 布尔 | - 逻辑属性 bInShow = true 当 bHide = true 时有效（如果为true，当玩家加入这个势力才显示）；逻辑属性 nInNoShow 若存在，则当 bHide = false 时有效（当玩家加入了这个值的势力就不显示） | 源码注释 | 高 |
| 8 | `bInShow` | `bInShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 9 | `nInNoShowForce` | `nInNoShowForce` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 10 | `bForAchievement` | `bForAchievement` | 布尔 | 成就相关配置 | 字段名推断 | 低 |

## Reputation\ReputationGainDesc.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwForceID` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 2 | `dwFromLevel` | `dwFromLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `dwToLevel` | `dwToLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 4 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |

## Reputation\ReputationLevel.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | - 等级对应的显示名字 | 源码注释 | 高 |
| 3 | `nFont` | `nFont` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `nFrame` | `nFrame` | 整数 | - 进度条图片帧 | 源码注释 | 高 |

## Reputation\ReputationRewardItems.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ForceID` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 2 | `ReputationLevel` | `nReputationLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `ItemTabType` | `dwItemTabType` | 整数 | 道具相关配置 | 字段名推断 | 低 |
| 4 | `ItemTabIndex` | `dwItemTabIndex` | 整数 | 道具ID/索引 | 字段名推断 | 低 |

## require.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `szRequireName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 2 | `GeneratedRequire` | `szGeneratedRequire` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `PreviewRequire` | `szPreviewRequire` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## RewardsShop\EffectToItem.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nEffectID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `DesignationID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `DesignationOrigin` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `szItemList` |  | 未知 | 道具相关配置 | 字段名推断 | 低 |

## RewardsShop\ExteriorToItem.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nType（COIN_SHOP_GOODS_TYPE）` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 2 | `nExteriorID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `szIndexList` |  | 未知 | 索引/排序 | 字段名推断 | 低 |

## RewardsShop\FurnitureCatg.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nCatag1Index` |  | 未知 | 索引/排序 | 字段名推断 | 低 |
| 2 | `nCatag2Index` |  | 未知 | 索引/排序 | 字段名推断 | 低 |
| 3 | `szName` |  | 未知 | 名称/标题文本 | 翻译列/字段名 | 中 |

## RewardsShop\FurnitureShopInfo.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `FurnitureID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `nPutType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `Pos` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `MobilePos` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `Yaw` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 6 | `Scale` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 7 | `nDetails` |  | 未知 | 详情ID列表 | 字段名推断 | 低 |

## RewardsShop\HorseAdornment.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `SetID` | `nSetID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `ItemIndex` | `dwItemIndex` | 整数 | 道具索引 | 字段名推断 | 低 |
| 3 | `SetName` | `szSetName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `nGainWay` | `nGainWay` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `szSource` | `szSource` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `bOutOfPrint` | `bOutOfPrint` | 布尔 | 待确认 | 待确认 | 待确认 |
| 7 | `dwExteriorID` | `dwExteriorID` | 整数 | 待确认 | 待确认 | 待确认 |

## RewardsShop\ItemToItemPack.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `itemtype` |  | 未知 | 道具类型 | 字段名推断 | 低 |
| 2 | `ItemIndex` |  | 未知 | 道具索引 | 字段名推断 | 低 |
| 3 | `dwIndex1` |  | 未知 | 索引/排序 | 字段名推断 | 低 |
| 4 | `dwIndex2` |  | 未知 | 索引/排序 | 字段名推断 | 低 |
| 5 | `dwIndex3` |  | 未知 | 索引/排序 | 字段名推断 | 低 |
| 6 | `dwIndex4` |  | 未知 | 索引/排序 | 字段名推断 | 低 |
| 7 | `dwIndex5` |  | 未知 | 索引/排序 | 字段名推断 | 低 |
| 8 | `dwIndex6` |  | 未知 | 索引/排序 | 字段名推断 | 低 |
| 9 | `dwIndex7` |  | 未知 | 索引/排序 | 字段名推断 | 低 |
| 10 | `dwIndex8` |  | 未知 | 索引/排序 | 字段名推断 | 低 |

## RewardsShop\LimitItemVideo.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwGoodsID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `RoleType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `StoryID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `CoinshopHoldRepresent` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 5 | `PlayHoldRepresent` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 6 | `Url` |  | 未知 | 链接/跳转配置 | 字段名推断 | 低 |
| 7 | `Title` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## RewardsShop\LimitItemView.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Sub` |  | 未知 | 二级分类/子类ID | 字段名推断 | 低 |
| 3 | `LogicID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 4 | `ItemID` |  | 未知 | 道具ID | 字段名推断 | 低 |
| 5 | `ItemType` |  | 未知 | 道具类型 | 字段名推断 | 低 |
| 6 | `bPreview` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 7 | `nReplaceRepresentID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `nReplaceRepresentColor` |  | 未知 | 颜色配置 | 字段名推断 | 低 |

## RewardsShop\LimitItemViewPack.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `dwIndex` |  | 未知 | 索引/排序 | 字段名推断 | 低 |
| 3 | `bPreview` |  | 未知 | 待确认 | 待确认 | 待确认 |

## RewardsShop\PreOrder.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `PreOrderID` |  | 未知 | 索引/排序 | 字段名推断 | 低 |
| 2 | `ErrorMsg` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## RewardsShop\RewardsCamera.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `nRoleType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `Name` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `MaxXYZ` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 5 | `MaxLookatXYZ` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 6 | `MaxRoleYaw` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 7 | `MaxCenterZ` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `MinXYZ` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `MinLookatXYZ` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 10 | `MinRoleYaw` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 11 | `MinCenterZ` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 12 | `InitPosition` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## RewardsShop\RewardsSet.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `RewardsClass` | `nRewardsClass` | 整数 | 奖励配置 | 字段名推断 | 低 |
| 2 | `ItemIndex` | `dwItemIndex` | 整数 | 道具索引 | 字段名推断 | 低 |
| 3 | `SetID` | `nSetID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `SetName` | `szSetName` | 字符串 | 待确认 | 待确认 | 待确认 |

## RewardsShop\RewardsShop.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Class` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `SubClass` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 4 | `ClassName` |  | 未知 | 类型/分类 | 翻译列/字段名 | 中 |
| 5 | `SubClassName` |  | 未知 | 类型/分类 | 翻译列/字段名 | 中 |
| 6 | `dwType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 7 | `dwIndex` |  | 未知 | 索引/排序 | 字段名推断 | 低 |
| 8 | `LogicID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 9 | `IntroduceID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 10 | `Label` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 11 | `PetIndex` |  | 未知 | 索引/排序 | 字段名推断 | 低 |
| 12 | `AnimationF1` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 13 | `AnimationF2` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 14 | `AnimationM1` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 15 | `AnimationM2` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 16 | `WeaponSheath` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 17 | `OverdueShow` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 18 | `cameraID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 19 | `ForceID` |  | 未知 | 势力/阵营配置 | 字段名推断 | 低 |
| 20 | `Tip` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 21 | `nShowTime` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 22 | `IsBP` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 23 | `GroupLogicID` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 24 | `GroupTip` |  | 未知 | 类型/分类 | 字段名推断 | 低 |

## RewardsShop\RewardsShop_Detail.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `id` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `title` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `imagePath` |  | 未知 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `PackageImage` |  | 未知 | 图片资源配置 | 字段名推断 | 低 |
| 5 | `PackageName` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `Desc` |  | 未知 | 描述文本 | 翻译列/字段名 | 中 |

## RideModelAnimation.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `AnimationName` | `szAnimationName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `AnimationID` | `dwAnimationID` | 整数 | 待确认 | 待确认 | 待确认 |

## RideModelview.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ReprestntID` | `dwRepresentID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `Scale` | `fScale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 3 | `Yaw` | `fYaw` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 4 | `offsetY` | `fOffsetY` | 浮点数 | 坐标/尺寸配置 | 字段名推断 | 低 |

## RoadChivalrous.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szPageBgUITex` | `szPageBgUITex` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 3 | `nPageBgUIFrame` | `nPageBgUIFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `szPageTitle` | `szPageTitle` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `szPageIntroUITex` | `szPageIntroUITex` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 6 | `nPageIntroFrame1` | `nPageIntroFrame1` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `nPageIntroFrame2` | `nPageIntroFrame2` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `szQuestNameUITex` | `szQuestNameUITex` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 9 | `nQuestNameFrame` | `nQuestNameFrame` | 整数 | 任务相关配置 | 字段名推断 | 低 |
| 10 | `nQuestID` | `dwQuestID` | 整数 | 任务ID | 字段名推断 | 低 |
| 11 | `szQuestItems` | `szQuestItems` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 12 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 13 | `szQuestUITex` | `szQuestUITex` | 字符串 | 任务相关配置 | 字段名推断 | 低 |
| 14 | `nQuestFrame` | `nQuestFrame` | 整数 | 任务相关配置 | 字段名推断 | 低 |
| 15 | `szQuestIntro` | `szQuestIntro` | 字符串 | 任务相关配置 | 翻译列/字段名 | 中 |
| 16 | `szActivityID` | `szActivityID` | 字符串 | 活动ID | 字段名推断 | 低 |
| 17 | `szDay` | `szDay` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 18 | `nStartTime` | `nStartTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 19 | `nLastTime` | `nLastTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 20 | `bForShareOneBillion` | `bForShareOneBillion` | 布尔 | 待确认 | 待确认 | 待确认 |
| 21 | `nPlayerLevel` | `nPlayerLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |

## RoadChivalrousModule.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ModuleID` | `dwModuleID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `SubModuleID` | `szSubModuleID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `IniItem` | `szIniItem` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 4 | `Reward` | `szReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 5 | `LimitLevel` | `nLimitLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 6 | `BindingQuestID` | `dwBindingQuestID` | 整数 | 任务ID | 字段名推断 | 低 |

## RoadChivalrousQuest.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `QuestID` | `dwQuestID` | 整数 | 任务ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |

## RoadChivalrousSubModule.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `SubModuleID` | `dwSubModuleID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `QuestID` | `szQuestID` | 字符串 | 任务ID | 字段名推断 | 低 |
| 4 | `ImagePath` | `szImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `ActivatedFrame` | `nActivatedImageFrame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 6 | `InActivatedFrame` | `nInActivatedImageFrame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 7 | `Reward` | `szReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 8 | `Predecessor` | `szPredecessor` | 字符串 | 待确认 | 待确认 | 待确认 |
| 9 | `BindingQuestID` | `dwBindingQuestID` | 整数 | 任务ID | 字段名推断 | 低 |
| 10 | `LimitLevel` | `nLimitLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 11 | `LimitNumber` | `nLimitNumber` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 12 | `LimitTime` | `szLimitTime` | 字符串 | 时间配置 | 字段名推断 | 低 |
| 13 | `RefreshTime` | `nRefreshTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 14 | `Tip` | `szTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 15 | `Target` | `szTarget` | 字符串 | 目标配置 | 翻译列/字段名 | 中 |

## roleavatar.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `forceid` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 3 | `f1_image` | `szF1Image` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 4 | `f1_frame` | `nF1ImgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `f1_sfx` | `szF1Sfx` | 路径 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 6 | `f1_onlyavatar_sfx` | `szF1OnlyAvatarSfx` | 路径 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `f1_onlyavatar_img` | `szF1OnlyAvatarImg` | 路径 | 待确认 | 待确认 | 待确认 |
| 8 | `f1_onlyavatar_frame` | `nF1OnlyAvatarFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 9 | `f2_image` | `szF2Image` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 10 | `f2_frame` | `nF2ImgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 11 | `f2_sfx` | `szF2Sfx` | 路径 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `f2_onlyavatar_sfx` | `szF2OnlyAvatarSfx` | 路径 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `f2_onlyavatar_img` | `szF2OnlyAvatarImg` | 路径 | 待确认 | 待确认 | 待确认 |
| 14 | `f2_onlyavatar_frame` | `nF2OnlyAvatarFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 15 | `m1_image` | `szM1Image` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 16 | `m1_frame` | `nM1ImgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 17 | `m1_sfx` | `szM1Sfx` | 路径 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 18 | `m1_onlyavatar_sfx` | `szM1OnlyAvatarSfx` | 路径 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 19 | `m1_onlyavatar_img` | `szM1OnlyAvatarImg` | 路径 | 待确认 | 待确认 | 待确认 |
| 20 | `m1_onlyavatar_frame` | `nM1OnlyAvatarFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 21 | `m2_image` | `szM2Image` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 22 | `m2_frame` | `nM2ImgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 23 | `m2_sfx` | `szM2Sfx` | 路径 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 24 | `m2_onlyavatar_sfx` | `szM2OnlyAvatarSfx` | 路径 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 25 | `m2_onlyavatar_img` | `szM2OnlyAvatarImg` | 路径 | 待确认 | 待确认 | 待确认 |
| 26 | `m2_onlyavatar_frame` | `nM2OnlyAvatarFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 27 | `bAnimate` | `bAnimate` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 28 | `nRelateID` | `nRelateID` | 整数 | 待确认 | 待确认 | 待确认 |
| 29 | `nHat` | `nHat` | 整数 | 待确认 | 待确认 | 待确认 |
| 30 | `hudimage_left` | `szLeftHUDImage` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 31 | `hudimage_lframe` | `nLeftHUDFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 32 | `hudimage_mid` | `szMidHUDImage` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 33 | `hudimage_mframe` | `nMidHUDFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 34 | `hudimage_right` | `szRightHUDImage` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 35 | `hudimage_rframe` | `nRightHUDFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 36 | `hudimage_leftMana` | `szLeftHUDImageMana` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 37 | `hudimage_lframeMana` | `nLeftHUDFrameMana` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 38 | `hudimage_midMana` | `szMidHUDImageMana` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 39 | `hudimage_mframeMana` | `nMidHUDFrameMana` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 40 | `hudimage_rightMana` | `szRightHUDImageMana` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 41 | `hudimage_rframeMana` | `nRightHUDFrameMana` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 42 | `hudsfx_left` | `szLeftSfx` | 路径 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 43 | `hudsfx_right` | `szRightSfx` | 路径 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 44 | `hudsfx_leftmana` | `szLeftSfxMana` | 路径 | 待确认 | 待确认 | 待确认 |
| 45 | `hudsfx_rightmana` | `szRightSfxMana` | 路径 | 待确认 | 待确认 | 待确认 |
| 46 | `szWholeAnimatePath` | `szWholeAnimatePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 47 | `nWholeAnimateFrame` | `nWholeAnimateFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 48 | `szWholeSfx` | `szWholeSfx` | 路径 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 49 | `szWholeAnimatePathMana` | `szWholeAnimatePathMana` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 50 | `nWholeAnimateFrameMana` | `nWholeAnimateFrameMana` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 51 | `szWholeSfxMana` | `szWholeSfxMana` | 路径 | 待确认 | 待确认 | 待确认 |
| 52 | `bShow` | `bShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 53 | `szLinkItem` | `szLinkItem` | 字符串 | 道具相关配置 | 字段名推断 | 低 |

## school_belong.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `BelongSchoolID` | `dwBelongSchool` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `target_avatar_image 目标头像图素` | `szSchoolImage` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 4 | `target_avatar_img_frame` | `nSchoolFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `Color` | `szColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 6 | `MobileColor` | `szMobileColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 7 | `SchoolID` | `szSchool` | 字符串 | 待确认 | 待确认 | 待确认 |

## ScrollBackground.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwBGID` | `dwBGID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szBGPath1` | `szBGPath1` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `szBGPath2` | `szBGPath2` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `szBGPath3` | `szBGPath3` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `szBGPath4` | `szBGPath4` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `szBGPath5` | `szBGPath5` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `szBGPath6` | `szBGPath6` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `szBGPath7` | `szBGPath7` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `szBGPath8` | `szBGPath8` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `szTitlePath` | `szTitlePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 11 | `szFlowerPath` | `szFlowerPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 12 | `nFlowerFrame` | `nFlowerFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 13 | `szTitleName` | `szTitleName` | 字符串 | 待确认 | 待确认 | 待确认 |

## ScrollDisplay.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwImgID` | `dwImgID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szImgPath` | `szImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## SeasonFurnitureActivity.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `dwActivityID` | `dwActivityID` | 整数 | 活动ID | 字段名推断 | 低 |
| 3 | `szGainDesc` | `szGainDesc` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `szTypeImagePath` | `szTypeImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `nTypeFrame` | `nTypeFrame` | 整数 | 类型/分类 | 字段名推断 | 低 |

## SeasonFurnitureAttribute.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nAttributeID` | `nAttributeID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szAttributeName` | `szAttributeName` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `szAttributeDesc` | `szAttributeDesc` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## SeasonFurnitureInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `nFurnitureType` | `nFurnitureType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nFurnitureIndex` | `nFurnitureIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 4 | `szActivityIndex` | `szActivityIndex` | 字符串 | 索引/排序 | 字段名推断 | 低 |
| 5 | `szAttributeID` | `szAttributeID` | 字符串 | 待确认 | 待确认 | 待确认 |

## SeasonHonorRewardConfig.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nClass` | `nClass` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `nStage` | `nStage` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `nScore` | `nScore` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `szReward` | `szReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |

## SeasonHonorTaskConfig.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nTaskID` | `nTaskID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nClass` | `nClass` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nSort` | `nSort` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 4 | `szTaskKey` | `szTaskKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 字段名推断 | 低 |
| 6 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 7 | `nScore` | `nScore` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `nFragment` | `nFragment` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `szCatgName` | `szCatgName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 10 | `szUIFunction` | `szUIFunction` | 字符串 | 待确认 | 待确认 | 待确认 |
| 11 | `szEventLink` | `szEventLink` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 12 | `szMobileFunction` | `szMobileFunction` | 字符串 | 待确认 | 待确认 | 待确认 |
| 13 | `bShow` | `bShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 14 | `bLock` | `bLock` | 布尔 | 待确认 | 待确认 | 待确认 |
| 15 | `szLockTime` | `szLockTime` | 字符串 | 时间配置 | 字段名推断 | 低 |

## SeasonLevelActiveTaskConfig.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nTaskID` | `nTaskID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `nClass` | `nClass` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `szKey` | `szKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 6 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 字段名推断 | 低 |
| 7 | `nMaxProgress` | `nMaxProgress` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `nScore` | `nScore` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `nOffset` | `nOffset` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 10 | `nLength` | `nLength` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `bStage` | `bStage` | 布尔 | 待确认 | 待确认 | 待确认 |
| 12 | `bAddition` | `bAddition` | 布尔 | 待确认 | 待确认 | 待确认 |
| 13 | `nNextTaskID` | `nNextTaskID` | 整数 | 待确认 | 待确认 | 待确认 |
| 14 | `bShow` | `bShow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 15 | `bLock` | `bLock` | 布尔 | 待确认 | 待确认 | 待确认 |
| 16 | `szLockTime` | `szLockTime` | 字符串 | 时间配置 | 字段名推断 | 低 |
| 17 | `nSort` | `nSort` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 18 | `szFunction` | `szFunction` | 字符串 | 待确认 | 待确认 | 待确认 |
| 19 | `szLink` | `szLink` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 20 | `szMobileFunction` | `szMobileFunction` | 字符串 | 待确认 | 待确认 | 待确认 |

## SeasonRankImg.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Path` | `Path` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## SeasonReward.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 4 | `nCount` | `nCount` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 5 | `szLockTips` | `szLockTips` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `szColorTips` | `szColorTips` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 7 | `szShowType` | `szShowType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 8 | `nTitleFrame` | `nTitleFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 9 | `szPath` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `bRoleType` | `bRoleType` | 布尔 | 类型/分类 | 字段名推断 | 低 |
| 11 | `szStandardMan` | `szStandardMan` | 字符串 | 待确认 | 待确认 | 待确认 |
| 12 | `szStandardFemale` | `szStandardFemale` | 字符串 | 待确认 | 待确认 | 待确认 |
| 13 | `szLittleBoy` | `szLittleBoy` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 14 | `szLittleGirl` | `szLittleGirl` | 字符串 | 待确认 | 待确认 | 待确认 |
| 15 | `szMobileTitlePath` | `szMobileTitlePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 16 | `szMobilePath` | `szMobilePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 17 | `szMobileStandardMan` | `szMobileStandardMan` | 字符串 | 待确认 | 待确认 | 待确认 |
| 18 | `szMobileStandardFemale` | `szMobileStandardFemale` | 字符串 | 待确认 | 待确认 | 待确认 |
| 19 | `szMobileLittleBoy` | `szMobileLittleBoy` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 20 | `szMobileLittleGirl` | `szMobileLittleGirl` | 字符串 | 待确认 | 待确认 | 待确认 |

## SeasonTag.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nPostion` | `nPos` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 5 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 6 | `szPath` | `szPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 8 | `nLevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |

## SelfieActionFilter.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwAnimationID` | `dwAnimationID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `AnimationFile` | `szAnimationFile` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `szType1` | `nType1` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `dwLogicID1` | `szLogicID1` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `szType2` | `nType2` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 6 | `dwLogicID2` | `szLogicID2` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `szType3` | `nType3` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 8 | `dwLogicID3` | `szLogicID3` | 字符串 | 待确认 | 待确认 | 待确认 |
| 9 | `tAndLogicIDGroups` | `szAndLogicIDGroup` | 字符串 | 以\|为间隔为一组，某一组里的id都收集了算收集 | 源码注释 | 高 |
| 10 | `bSkillSkin` | `bSkillSkin` | 布尔 | 技能相关配置 | 字段名推断 | 低 |
| 11 | `szRoleType` | `szRoleType` | 字符串 | 类型/分类 | 字段名推断 | 低 |

## SelfieBGM.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `nTime` | `nTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 4 | `szBgmEvent` | `szBgmEvent` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `szImgPath` | `szImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 7 | `szImgCutPath` | `szImgCutPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `nCutFrame` | `nCutFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## SelfieCameraAniData.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `nCameraAniID` | `nCameraAniID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 4 | `szPreviewImgPath` | `szPreviewImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## SelfieFilter.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Index(for UI, begins at 0)` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `LogicIndex(for Logic, begins at 0)` | `nLogicIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `_Comment` | `_szComment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 5 | `ForOutside` | `nForOutside` | 整数 | - 1表示仅供外面的滤镜面板使用，0表示仅供幻景云图使用，-1表示二者皆可用 | 源码注释 | 高 |
| 6 | `ImagePath` | `szImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `ImageFrame` | `nImgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `Default Gain` | `fDefGain` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 9 | `Default Contrast` | `fDefContrast` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 10 | `Default Saturation` | `fDefSaturation` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 11 | `Default VignetteIntensity` | `fDefVignetteIntensity` | 浮点数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `Default GrainIntensity` | `fDefGrainIntensity` | 浮点数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `Default Exposure` | `fDefExposure` | 浮点数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 14 | `Default Bloom` | `fDefBloom` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 15 | `Default ChromaticAberration` | `fDefChromaticAberration` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 16 | `Default_Specular` | `fDefSpecular` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 17 | `Default_Sharpen` | `fDefSharpen` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 18 | `Default_HDR` | `fDefHDR` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 19 | `Default_HighLight` | `fDefHighLight` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 20 | `Default_Shadow` | `fDefShadow` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 21 | `Default_SSRTGI_Intensity` | `fDefSSRTGIIntensity` | 浮点数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 22 | `Default_SSRTGI_Reach` | `fDefSSRTGIReach` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 23 | `Default_HSL_Hue` | `fDefHSLHue` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 24 | `Default_HSL_Saturation` | `fDefHSLSaturation` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 25 | `Default_HSL_Lightness` | `fDefHSLLightness` | 浮点数 | 待确认 | 待确认 | 待确认 |

## SelfieLightParams.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `LightIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `IntensityMin(最小强度)` | `fIntensityMin` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 3 | `IntensityMax(最大强度)` | `fIntensityMax` | 浮点数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `SaturationMin(最小饱和度)` | `fSaturationMin` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 5 | `SaturationMax(最大饱和度)` | `fSaturationMax` | 浮点数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 6 | `Color1` | `szColor1` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 7 | `Color2` | `szColor2` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 8 | `Color3` | `szColor3` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 9 | `Color4` | `szColor4` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 10 | `Color5` | `szColor5` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 11 | `Color6` | `szColor6` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 12 | `Color7` | `szColor7` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 13 | `Color8` | `szColor8` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 14 | `Color9` | `szColor9` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 15 | `Color10` | `szColor10` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 16 | `Color11` | `szColor11` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 17 | `Color12` | `szColor12` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 18 | `Color13` | `szColor13` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 19 | `Color14` | `szColor14` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 20 | `Color15` | `szColor15` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 21 | `Color16` | `szColor16` | 字符串 | 颜色配置 | 字段名推断 | 低 |

## SelfieResolution.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Width` | `nWidth` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 3 | `Height` | `nHeight` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |

## SelfieStudio.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `ImagePath` | `szImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `ImageFrame` | `nImageFrame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 5 | `szDisTip` | `szDisTip` | 多语言文本 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `MapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 7 | `Preset` | `szPreset` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `bCanWeather` | `bCanWeather` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## SelfieStudioPreset.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwPreset` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `ImagePath` | `szImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `ImageFrame` | `nImageFrame` | 整数 | 图片资源配置 | 字段名推断 | 低 |

## Servant\Servant.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwNpcIndex` | `dwNpcIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szNpcName` | `szNpcName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `szRoleType` | `szRoleType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 4 | `szImagePath` | `szImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `nRequiredRepuLevel` | `nRequiredRepuLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 6 | `szBuffName` | `szBuffName` | 字符串 | Buff相关配置 | 翻译列/字段名 | 中 |
| 7 | `szBuffDesc` | `szBuffDesc` | 多语言文本 | Buff相关配置 | 翻译列/字段名 | 中 |
| 8 | `szDescBrief` | `szDescBrief` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `szDescPersonality` | `szDescStory` | 多语言文本 | 坐标/尺寸配置 | 翻译列/字段名 | 中 |

## Servant\ServantCommonActions.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `dwActionID` | `dwActionID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `nIconID` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |

## Servant\ServantSpecialAction.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nServantNpcIndex` | `dwServantNpcIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `dwActionID` | `dwActionID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szActionName` | `szActionName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `nIconID` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |

## ServerName.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ServerID` | `dwServerID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |

## set.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `setid` | `setid` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `uiid` | `uiid` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `pos` | `pos` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |

## SFXInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szSFXPath` | `szSFXPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `szSoundPath` | `szSoundPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `nDuration[Millisecond]` | `nDuration` | 整数 | 时间配置 | 字段名推断 | 低 |
| 5 | `nScale` | `nScale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 6 | `szPos` | `szPos` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `nOffsetX` | `nOffsetX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 8 | `nOffsetY` | `nOffsetY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |

## sfxsize.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `sfxid` | `szID` | 字符串 | ID | 字段名推断 | 低 |
| 2 | `width` | `nWidth` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 3 | `height` | `nHeight` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |

## ShareStationReportReason.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 字段名推断 | 低 |

## ShareStationTag.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nTagID(只能新增，禁止删除）` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `nDataType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 3 | `szName` |  | 未知 | 名称/标题文本 | 字段名推断 | 低 |

## ShieldNpc.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TemplateID` | `TemplateID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `bFocus` | `bFocus` | 布尔 | 待确认 | 待确认 | 待确认 |
| 3 | `bSpeak` | `bSpeak` | 布尔 | 待确认 | 待确认 | 待确认 |

## ShopGroup.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `NPCID` | `dwNpcID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `GroupName` | `szGroupName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 3 | `ShopClass1` | `szShopClass1` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 4 | `ShopList1` | `szShopList1` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 5 | `ShopClass2` | `szShopClass2` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 6 | `ShopList2` | `szShopList2` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 7 | `ShopClass3` | `szShopClass3` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 8 | `ShopList3` | `szShopList3` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 9 | `ShopClass4` | `szShopClass4` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 10 | `ShopList4` | `szShopList4` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 11 | `ShopClass5` | `szShopClass5` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 12 | `ShopList5` | `szShopList5` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |

## ShopList.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nShopID` | `nShopID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `DiscountImage` | `szDisImage` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 3 | `DiscountFrame` | `nDisFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## ShopMultiBuyLimit.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTabType` | `dwTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `nLimit` | `nLimit` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `nSetp` | `nStep` | 整数 | 待确认 | 待确认 | 待确认 |

## ShopPanelSelector.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nShopID` | `nShopID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `bSchoolSelector` | `bSchoolSelector` | 布尔 | 待确认 | 待确认 | 待确认 |
| 3 | `bKungfuSelector` | `bKungfuSelector` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 4 | `bEquipPosSelector` | `bEquipPosSelector` | 布尔 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `bAttriSelector` | `bAttriSelector` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `bRequireLevelSelector` | `bRequireLevelSelector` | 布尔 | 等级/品质 | 字段名推断 | 低 |
| 7 | `bLevelSelector` | `bLevelSelector` | 布尔 | 等级/品质 | 字段名推断 | 低 |
| 8 | `bQualitySelector` | `bQualitySelector` | 布尔 | 等级/品质 | 字段名推断 | 低 |
| 9 | `bScoreSelector` | `bScoreSelector` | 布尔 | 待确认 | 待确认 | 待确认 |
| 10 | `bSkillSelector` | `bSkillSelector` | 布尔 | 技能相关配置 | 字段名推断 | 低 |
| 11 | `bHaveReadSelector` | `bHaveReadSelector` | 布尔 | 待确认 | 待确认 | 待确认 |
| 12 | `bAutoSelect` | `bAutoSelect` | 布尔 | 待确认 | 待确认 | 待确认 |
| 13 | `bDisableSort` | `bDisableSort` | 布尔 | 索引/排序 | 字段名推断 | 低 |
| 14 | `bCollectFurniture` | `bCollectFurniture` | 布尔 | 待确认 | 待确认 | 待确认 |

## showmode.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `NAME` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `DESC` |  | 未知 | 描述文本 | 字段名推断 | 低 |

## SignInLucky.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 3 | `nLuckValue` | `nLuckValue` | 整数 | 待确认 | 待确认 | 待确认 |

## SimplePlayer.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TemplateID` | `dwTemplateID` | 整数 | 待确认 | 待确认 | 待确认 |

## SimpleTip.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szIniPath` | `szIniPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |

## SituationMapInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwId` | `dwId` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szIniPath` | `szIniPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `szMapFilePath` | `szMapFilePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `szTitlePath` | `szTitlePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `nTitleFrame` | `nTitleFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `nAnimationNum` | `nAnimationNum` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 7 | `nTime` | `nTime` | 整数 | 时间配置 | 字段名推断 | 低 |

## skill.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `SkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 2 | `Level` | `dwLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `IconID` | `dwIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 4 | `Show` | `bShow` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 5 | `CombatShow` | `bCombatShow` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `Formation` | `bFormation` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `FormationCaster` | `bFormationCaster` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `PracticeID` | `dwPracticeID` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `SortOrder` | `fSortOrder` | 浮点数 | 索引/排序 | 字段名推断 | 低 |
| 10 | `CommonUse` | `bCommonUse` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 11 | `Remark` | `szRemark` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 12 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 13 | `Desc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 14 | `ShortDesc` | `szShortDesc` | 多语言文本 | 简短描述文本 | 翻译列/字段名 | 中 |
| 15 | `SpecialDesc` | `szSpecialDesc` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 16 | `KungfuDesc` | `szKungfuDesc` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 17 | `HelpDesc` | `szHelpDesc` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 18 | `IsShowInNewSkill` | `IsShowOnNewSkill` | 布尔 | 技能相关配置 | 字段名推断 | 低 |
| 19 | `CanDrag` | `bCanDrag` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 20 | `SkillRelyOnShow` | `szSkillRelyOnShow` | 字符串 | 技能相关配置 | 字段名推断 | 低 |
| 21 | `SkillRelyOnNotShow` | `szSkillRelyOnNotShow` | 字符串 | 技能相关配置 | 字段名推断 | 低 |
| 22 | `IsShowNotLearn` | `IsShowNotLearn` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 23 | `IsHotkeyExitWhenForget` | `IsHotkeyExitWhenForget` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 24 | `Buff` | `szBuff` | 字符串 | Buff相关配置 | 字段名推断 | 低 |
| 25 | `Debuff` | `szDebuff` | 字符串 | Buff相关配置 | 字段名推断 | 低 |
| 26 | `BlackList` | `bBlackList` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 27 | `SimpleDesc` | `szSimpleDesc` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 28 | `AutoSelectTarget` | `bAutoSelectTarget` | 布尔 | 目标配置 | 字段名推断 | 低 |
| 29 | `Decoration` | `nDecoration` | 整数 | 待确认 | 待确认 | 待确认 |
| 30 | `nInterruptIcon` | `nInterruptIcon` | 整数 | 待确认 | 待确认 | 待确认 |
| 31 | `nOTActionShowType` | `nOTActionShowType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 32 | `bShowLevel` | `bShowLevel` | 布尔 | 等级/品质 | 字段名推断 | 低 |

## skill_combo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwSkill` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 2 | `dwComboPreview` | `dwComboPreview` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `nMemberNum` | `nMemberNum` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 4 | `szGroup` | `szGroup` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 5 | `nComboType` | `nComboType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 6 | `bIsRandom` | `bIsRandom` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## skill_countcombo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwSkill` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 2 | `bKoMove` | `bKoMove` | 布尔 | 待确认 | 待确认 | 待确认 |

## skill_force_school.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ForceID` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 2 | `SchoolID` | `dwSchoolID` | 整数 | 待确认 | 待确认 | 待确认 |

## Skill_Hoard_Range.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwSkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 2 | `fBegin` | `fBegin` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 3 | `fEnd` | `fEnd` | 浮点数 | 待确认 | 待确认 | 待确认 |

## skill_kungfu.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `KungfuID` | `dwKungfu` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `dwMountKungfu` | `dwMKungfu` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `Skill` | `szSkill` | 字符串 | 技能相关配置 | 字段名推断 | 低 |

## skill_mkungfu_kungfu.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `MountKungfu` | `dwMKungfu` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `Kungfu` | `szKungfu` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `BG1` | `szBgPath1` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `BG2` | `szBgPath2` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `BG3` | `szBgPath3` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `BG4` | `szBgPath4` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `BG5` | `szBgPath5` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `Alpha` | `nAlpha` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `IsSection` | `bSection` | 布尔 | 待确认 | 待确认 | 待确认 |
| 10 | `fight_stat_color_image` | `szFightStateImage` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 11 | `fight_stat_color_img_frame` | `nFightStateFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 12 | `fight_stat_color` | `szFightStateColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 13 | `mobile_fight_color` | `szMobileFightColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |
| 14 | `mobile_fight_bg_color` | `szMobileFightBGColor` | 字符串 | 颜色配置 | 字段名推断 | 低 |

## skill_nouns.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nNounID` | `nNounID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `szDesc` | `szDesc` | 多语言文本 | 描述文本 | 字段名推断 | 低 |
| 4 | `szRGB` | `szRGB` | 字符串 | 待确认 | 待确认 | 待确认 |

## skill_open_level.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `SkillID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `SkillLevel` | `dwSkillLevel` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 3 | `OpenLevel` | `dwLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |

## skill_ot_action.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Comment` | `szComment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `HandleMod` | `CSS_H_NAME` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `TextName` | `CSS_T_NAME` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `ImageProgress` | `CSS_P_NAME` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `HandleGCD` | `CSS_GCD_NAME` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `ImageDelay` | `CSS_DELAY_NAME` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `HandleDevide` | `CSS_DIVID_NAME` | 字符串 | 待确认 | 待确认 | 待确认 |
| 9 | `HandleDevideM` | `CSS_DIVIDM_NAME` | 字符串 | 待确认 | 待确认 | 待确认 |
| 10 | `HandleSpecial` | `CSS_SP_NAME` | 字符串 | 待确认 | 待确认 | 待确认 |

## skill_pet_ot_action.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Comment` | `szComment` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `HandleMod` | `CSS_H_NAME` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `TextName` | `CSS_T_NAME` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `ImageProgress` | `CSS_P_NAME` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `ImageDelay` | `CSS_DELAY_NAME` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `HandleDevide` | `CSS_DIVID_NAME` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `HandleDevideM` | `CSS_DIVIDM_NAME` | 字符串 | 待确认 | 待确认 | 待确认 |

## skill_protect.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwSkill` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |

## skill_qixue.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `PointID` | `dwPointID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |

## skill_qixue_douqi.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `KungFuID` | `dwKungfuID` | 整数 | 心法/内功ID | 字段名推断 | 低 |
| 2 | `PointID` | `dwPointID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `SPIndex` | `nSPIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |

## skill_qixue_replace.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `skill_id` | `skill_id` | 整数 | 技能ID | 字段名推断 | 低 |
| 2 | `replace_skill_id` | `replace_skill_id` | 整数 | 技能ID | 字段名推断 | 低 |
| 3 | `condition_skill_id` | `condition_skill_id` | 整数 | 技能ID | 字段名推断 | 低 |
| 4 | `condition_buff_id` | `condition_buff_id` | 整数 | Buff ID | 字段名推断 | 低 |

## skill_qixue_teachby.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `KungfuID` | `dwKungFuID` | 整数 | 心法/内功ID | 字段名推断 | 低 |
| 2 | `QixueList` | `szQixueList` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |

## skill_quest_unlock.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 2 | `szQuestList` | `szQuestList` | 字符串 | 任务相关配置 | 字段名推断 | 低 |

## skill_replace.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `src_skill_id` | `dwSrcSkillId` | 整数 | 技能ID | 字段名推断 | 低 |
| 2 | `condition_skill` | `dwConditionId` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `dst_skill_id1` | `dwDstSkillId1` | 整数 | 技能ID | 字段名推断 | 低 |
| 4 | `dst_skill_id2` | `dwDstSkillId2` | 整数 | 技能ID | 字段名推断 | 低 |

## skill_school_kungfu.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ForceID` | `dwSchoolID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `KungFuID` | `szKungfu` | 字符串 | 待确认 | 待确认 | 待确认 |

## skill_skin.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `SkillID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `SkinGropID` | `dwSkinGroupID` | 整数 | 类型/分类 | 字段名推断 | 低 |

## skill_skininfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `SkinID` | `dwSkinID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `SkillID` | `dwSkillID` | 整数 | 获得新皮肤跳转使用，选填原技能ID即可 | 源码注释 | 高 |
| 3 | `SkinName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `Icon` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 5 | `Quality` | `nQuilty` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 6 | `Desc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 7 | `Source` | `szSource` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `CallBack` | `bCallBack` | 布尔 | 待确认 | 待确认 | 待确认 |

## skill_skinpreview.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `SkinID` | `dwSkinID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `RoleType` | `nRoleType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `Url` | `szUrl` | 路径 | 链接/跳转配置 | 字段名推断 | 低 |
| 4 | `Title` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |

## skill_special_gcd.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `special_cdid` | `dwCDID` | 整数 | 待确认 | 待确认 | 待确认 |

## skill_teach.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `ForceID` | `nForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 3 | `KungfuIndex` | `KungfuIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 4 | `KungfuID` | `nKungfuID` | 整数 | 心法/内功ID | 字段名推断 | 低 |
| 5 | `Level` | `szLevel` | 字符串 | 等级/品质 | 字段名推断 | 低 |
| 6 | `Solution` | `szSolution` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `Skill` | `szSkill` | 字符串 | 技能相关配置 | 翻译列/字段名 | 中 |
| 8 | `SkillList` | `szSkillList` | 字符串 | 技能相关配置 | 字段名推断 | 低 |
| 9 | `SkillDesc` | `szSkillDesc` | 多语言文本 | 技能相关配置 | 翻译列/字段名 | 中 |
| 10 | `Qixue` | `szQixue` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 11 | `QixueList` | `szQixueList` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 12 | `QixueDesc` | `szQixueDesc` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 13 | `szRecipeSkillList` | `szRecipeSkillList` | 字符串 | 技能相关配置 | 字段名推断 | 低 |

## skill_teach_recommend.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `ForceID` | `nForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 3 | `KungfuIndex` | `KungfuIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 4 | `KungfuID` | `nKungfuID` | 整数 | 心法/内功ID | 字段名推断 | 低 |
| 5 | `Solution` | `szSolution` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `Qixue1` | `szQixue1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `QixueList1` | `szQixueList1` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 8 | `Qixue2` | `szQixue2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `QixueList2` | `szQixueList2` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 10 | `Qixue3` | `szQixue3` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 11 | `QixueList3` | `szQixueList3` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 12 | `Qixue4` | `szQixue4` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 13 | `QixueList4` | `szQixueList4` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 14 | `Qixue5` | `szQixue5` | 字符串 | 待确认 | 待确认 | 待确认 |
| 15 | `QixueList5` | `szQixueList5` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 16 | `Qixue6` | `szQixue6` | 字符串 | 待确认 | 待确认 | 待确认 |
| 17 | `QixueList6` | `szQixueList6` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |

## SkillCollection.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `dwSkillID` |  | 未知 | 技能ID | 字段名推断 | 低 |
| 3 | `nStarCount` |  | 未知 | 数量/计数 | 字段名推断 | 低 |
| 4 | `bDeprecated` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 5 | `nType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |

## SkillEffect.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwBuffID` | `dwBuffID` | 整数 | Buff ID | 字段名推断 | 低 |
| 2 | `dwSkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 3 | `szUITex` | `szUITex` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 5 | `bAnimate` | `bAnimate` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## skillevent.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Desc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 3 | `IsMobile` | `bIsMobile` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 4 | `Share` | `bShare` | 布尔 | 待确认 | 待确认 | 待确认 |

## SkillExtCDID.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwExtID` | `dwExtID` | 整数 | 待确认 | 待确认 | 待确认 |

## SkillGuide.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `dwKungFuID` | `dwKungFuID` | 整数 | 心法/内功ID | 字段名推断 | 低 |
| 3 | `Level` | `szLevel` | 字符串 | 等级/品质 | 字段名推断 | 低 |
| 4 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 5 | `SkillList` | `szSkillList` | 字符串 | 技能相关配置 | 字段名推断 | 低 |
| 6 | `SkillLimitList` | `szSkillLimitList` | 字符串 | 技能相关配置 | 字段名推断 | 低 |
| 7 | `QixueList` | `szQixueList` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 8 | `Default` | `bDefault` | 布尔 | 待确认 | 待确认 | 待确认 |

## SkillGuideNext.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwSkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 2 | `dwSkillNext` | `dwSkillNext` | 整数 | 技能相关配置 | 字段名推断 | 低 |

## SkillItem.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTabType` | `dwTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `dwSkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 4 | `dwLevel` | `dwLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |

## SkillRecipeMirror.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwSkillID` | `dwMirrorSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 2 | `dwMirrorSkillID` | `dwSkillIDSRC` | 整数 | 技能ID | 字段名推断 | 低 |

## SkillRecipeTable.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Level` | `dwLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `TypeID` | `dwTypeID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `SkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 5 | `IconID` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 6 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 7 | `Desc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 8 | `BindSkillID` | `dwBindSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 9 | `TrainCost` | `nTrainCost` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `ShowNewRecipeTip` | `bShowNewRecipeTip` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 11 | `nPriority` | `nPriority` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nShowAppendSkillID` |  | 未知 | 技能ID | 字段名推断 | 低 |
| 13 | `nTeachPriority` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |

## SkillRecipeType.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwTypeID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `Desc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 3 | `AddToTip` | `nAddToTip` | 整数 | 待确认 | 待确认 | 待确认 |

## skillshield.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `skill_id` | `skill_id` | 整数 | 技能ID | 字段名推断 | 低 |
| 2 | `type` | `type` | 字符串 | 类型/分类 | 字段名推断 | 低 |

## skilltip_condition.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `CONDITION_ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `CONDITION_TYPE` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 3 | `DESCRIPTION` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `ARG1` | `szArg1` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `ARG2` | `szArg2` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `ARG3` | `szArg3` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `ARG4` | `szArg4` | 字符串 | 待确认 | 待确认 | 待确认 |

## skilltip_event.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `EVENT_ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `DESCRIPTION` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `CONDITION_ID` | `szCondition` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `SKILL_ID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 5 | `SKILL_LEVEL` | `dwSkillLevel` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 6 | `SHOW_TYPE` | `szShowType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 7 | `MAX_TIME` | `dwMaxTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 8 | `SFX_PATH` | `szShowData` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 9 | `SCALE` | `fScale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 10 | `SHOW_ONCE` | `dwShowOnce` | 整数 | 开关/条件配置 | 字段名推断 | 低 |

## skilltip_kungfu.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `KUNGFU_ID` | `dwKungfuID` | 整数 | 心法/内功ID | 字段名推断 | 低 |
| 2 | `KUNGFU_NAME` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `TARGET_BUFF` | `szTargetBuff` | 字符串 | Buff相关配置 | 字段名推断 | 低 |
| 4 | `CLIENT_BUFF` | `szPlayerBuff` | 字符串 | Buff相关配置 | 字段名推断 | 低 |
| 5 | `TARGET_LIFE` | `szTargetLife` | 字符串 | 目标配置 | 字段名推断 | 低 |
| 6 | `CLIENT_LIFE` | `szPlayerLife` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `TARGET_MANA` | `szTargetMana` | 字符串 | 目标配置 | 字段名推断 | 低 |
| 8 | `CLIENT_MANA` | `szPlayerMana` | 字符串 | 待确认 | 待确认 | 待确认 |
| 9 | `REFRESH_CD` | `szDoSkill` | 字符串 | 技能相关配置 | 字段名推断 | 低 |
| 10 | `CLIENT_ACCUMULATE` | `szPlayerAccumulate` | 字符串 | 待确认 | 待确认 | 待确认 |
| 11 | `TEAMMATE_LIFE` | `szTeammateLife` | 字符串 | 待确认 | 待确认 | 待确认 |
| 12 | `CLIENT_SUN_ACCUMULATE` | `szPlayerSunAccumulate` | 字符串 | 待确认 | 待确认 | 待确认 |
| 13 | `CLIENT_MOON_ACCUMULATE` | `szPlayerMoonAccumulate` | 字符串 | 待确认 | 待确认 | 待确认 |
| 14 | `CLIENT_RAGE` | `szPlayerRage` | 字符串 | 待确认 | 待确认 | 待确认 |
| 15 | `CLINET_ENERGY` | `szPlayerEnergy` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |

## SmallBagFilter.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nFilterID` | `nFilterID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `dwItemType` | `dwItemType` | 整数 | 道具类型 | 字段名推断 | 低 |
| 3 | `szTypeName` | `szTypeName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |

## SmartDialog.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `TurnToFight_Text_1` | `szTurnToFight_Text_1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `TurnToFight_Text_2` | `szTurnToFight_Text_2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `TurnToFight_Text_3` | `szTurnToFight_Text_3` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `Death_Text_1` | `szDeath_Text_1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `Death_Text_2` | `szDeath_Text_2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `Death_Text_3` | `szDeath_Text_3` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `TeammateDeath_Text_1` | `szTeammateDeath_Text_1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `TeammateDeath_Text_2` | `szTeammateDeath_Text_2` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 10 | `TeammateDeath_Text_3` | `szTeammateDeath_Text_3` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 11 | `Idle_Text_1` | `szIdle_Text_1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 12 | `Idle_Text_2` | `szIdle_Text_2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 13 | `Idle_Text_3` | `szIdle_Text_3` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 14 | `Custom_Text_1` | `szCustom_Text_1` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 15 | `Custom_Text_2` | `szCustom_Text_2` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 16 | `Custom_Text_3` | `szCustom_Text_3` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 17 | `TurnToIdle_Text_1` | `szTurnToIdle_Text_1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 18 | `TurnToIdle_Text_2` | `szTurnToIdle_Text_2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 19 | `TurnToIdle_Text_3` | `szTurnToIdle_Text_3` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 20 | `KillEnemy_Text_1` | `szKillEnemy_Text_1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 21 | `KillEnemy_Text_2` | `szKillEnemy_Text_2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 22 | `KillEnemy_Text_3` | `szKillEnemy_Text_3` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 23 | `Escape_Text_1` | `szEscape_Text_1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 24 | `Escape_Text_2` | `szEscape_Text_2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 25 | `Escape_Text_3` | `szEscape_Text_3` | 字符串 | 文本内容 | 字段名推断 | 低 |

## sound.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `szPath` | `szPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## SoundSetting.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `VersionName` | `szVersionName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 2 | `Enable` | `bEnable` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 3 | `EnableUISound` | `bEnableUISound` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 4 | `EnableErrorSound` | `bEnableErrorSound` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 5 | `EnableSceneSound` | `bEnableSceneSound` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `EnableCharacterSound` | `bEnableCharacterSound` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 7 | `EnableCharacterSpeak` | `bEnableCharacterSpeak` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 8 | `EnableBgMusic` | `bEnableBgMusic` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 9 | `Enable3DSound` | `bEnable3DSound` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 10 | `BgMusicLoop` | `bBgMusicLoop` | 布尔 | 待确认 | 待确认 | 待确认 |
| 11 | `TotalVolume` | `fTotalVolume` | 浮点数 | 数量/计数 | 字段名推断 | 低 |
| 12 | `UIVolume` | `fUIVolume` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 13 | `ErrorVolume` | `fErrorVolume` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 14 | `SceneVolume` | `fSceneVolume` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 15 | `ChVolume` | `fChVolume` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 16 | `SpeakVolume` | `fSpeakVolume` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 17 | `BgVolume` | `fBgVolume` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 18 | `EnableHelpSound` | `bEnableHelpSound` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `EnableTipSound` | `bEnableTipSound` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 20 | `HelpVolume` | `fHelpVolume` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 21 | `TipVolume` | `fTipVolume` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 22 | `Female` | `bFemale` | 布尔 | 待确认 | 待确认 | 待确认 |
| 23 | `EnableLoseFocusPlay` | `bEnableLoseFocusPlay` | 布尔 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 24 | `WarningVolume` | `fWarningVolume` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 25 | `KillSound1` | `nKillSound1` | 整数 | 待确认 | 待确认 | 待确认 |
| 26 | `KillSound2` | `nKillSound2` | 整数 | 待确认 | 待确认 | 待确认 |
| 27 | `KillSound3` | `nKillSound3` | 整数 | 待确认 | 待确认 | 待确认 |
| 28 | `KillSound4` | `nKillSound4` | 整数 | 待确认 | 待确认 | 待确认 |
| 29 | `KillSound5` | `nKillSound5` | 整数 | 待确认 | 待确认 | 待确认 |
| 30 | `EnableMicSound` | `bEnableMicSound` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 31 | `EnableGVSpeaker` | `bEnableGVSpeaker` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 32 | `GVMicVolume` | `fGVMicVolume` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 33 | `GVSpeakerVolume` | `fGVSpeakerVolume` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 34 | `nVoiceType` | `nVoiceType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 35 | `ActorPlayerVolume` | `fActorPlayerVolume` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 36 | `OtherPlayerVolume` | `fOtherPlayerVolume` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 37 | `ActorNpcVolume` | `fActorNpcVolume` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 38 | `EnableCloakSound` | `bEnableCloakSound` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## SpacebarMiniGame.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `szIconFrame` | `szIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 3 | `szDescription` | `szDescription` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |

## SpecailGift.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `TitlePath` | `szTitlePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `TitleFrame` | `nTitleFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `BgPath` | `szBgPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `BgFrame` | `nBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `ItemInfo` | `szItemInfo` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 7 | `szMobileTitleName` | `szMobileTitleName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## SpecialActivityInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 4 | `szDesc` | `szDesc` | 多语言文本 | 描述文本 | 字段名推断 | 低 |
| 5 | `nStartTime` | `nStartTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 6 | `nEndTime` | `nEndTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 7 | `szReward` | `szReward` | 字符串 | 奖励配置 | 字段名推断 | 低 |
| 8 | `nQuestItemCost` | `nQuestItemCost` | 整数 | 任务相关配置 | 字段名推断 | 低 |
| 9 | `szImgPath` | `szImgBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `szCustomData` | `szCustomData` | 字符串 | 待确认 | 待确认 | 待确认 |
| 11 | `szTPLink` | `szTPLink` | 字符串 | 传送/跳转链接配置 | 字段名推断 | 低 |

## SpecialActivityType.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `nStartTime` | `nStartTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 4 | `nEndTime` | `nEndTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 5 | `szInipath` | `szIniPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `szVideoPath` | `szVideoPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `dwShopGroupID` | `dwShopGroupID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 8 | `dwDefaultShopID` | `dwDefaultShopID` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `nQuestItemIndex` | `nQuestItemIndex` | 整数 | 任务相关配置 | 字段名推断 | 低 |

## SpecialEnchant.tab

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ItemID` |  | 未知 | 道具ID | 字段名推断 | 低 |
| 2 | `EnchantID` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `LevelMin` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 4 | `LevelMax` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 5 | `KungfuType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 6 | `EquipmentSub` |  | 未知 | 待确认 | 待确认 | 待确认 |

## SpecialHoardSkill.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `HoardSkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 2 | `HoardSkillLevel` | `dwSkillLevel` | 整数 | 技能相关配置 | 字段名推断 | 低 |

## SpecialHorseOnJump.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwItemIndex` | `dwItemIndex` | 整数 | 道具索引 | 字段名推断 | 低 |

## SpecialItem.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTabType` | `dwTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `dwTabIndex` | `dwTabIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `bForLootMaterial` | `bForLootMaterial` | 布尔 | 待确认 | 待确认 | 待确认 |

## SpecialNeedViewEquipMap.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Index` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `dwMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |

## SpecialSprint.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwBitOPSchoolID` | `dwBitOPSchoolID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szJumpCounts` | `szJumpCounts` | 字符串 | 数量/计数 | 字段名推断 | 低 |

## SpecialWishItemInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `nItemType` | `dwTabType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `nItemIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 5 | `nCategory` | `nCategory` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 6 | `nPriority` | `nPriority` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `nCostWish` | `nCostWish` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 8 | `nExteriorID` | `nExteriorID` | 整数 | 外观 | 源码注释 | 高 |
| 9 | `szOrItem` | `szOrItem` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 10 | `szAndItem` | `szAndItem` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 11 | `szTips` | `szTips` | 字符串 | 待确认 | 待确认 | 待确认 |

## Sprint\Action.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Index` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `IconPath` | `szIconPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `IconFrame` | `nIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `IconOverFrame` | `nOverFrame` | 整数 | 悬停/经过状态帧号 | 字段名推断 | 低 |
| 5 | `HighLight` | `bHighLight` | 布尔 | 待确认 | 待确认 | 待确认 |
| 6 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 7 | `KeyGroup` | `szKeyGroup` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 8 | `Desc` | `szDesc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 9 | `comment` | `szcomment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 10 | `MobileIconPath` | `szMobileIconPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 11 | `MobileIconFrame` | `nMobileIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 12 | `MobileBaseIconPath` | `szMobileBaseIconPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 13 | `MobileBaseIconFrame` | `nMobileBaseIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## Sprint\Condition.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Index` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `BitOPSchoolID` | `dwBitOPSchoolID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `WeaponCheck` | `nWeaponCheck` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `SprintFlag` | `nSprintFlag` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `FollowController` | `nFollowController` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `Follower` | `nFollower` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `szTargetType` | `szTargetType` | 字符串 | 目标类型 | 字段名推断 | 低 |
| 8 | `IsTeammate` | `nTeammate` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `JumpCount` | `nJumpCount` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 10 | `Jumping` | `nJumping` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `Fighting` | `nFighting` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `RunOnWater` | `nRunOnWater` | 整数 | 待确认 | 待确认 | 待确认 |
| 13 | `OnHorse` | `nOnHorse` | 整数 | 待确认 | 待确认 | 待确认 |
| 14 | `IgnoreGravity` | `nIgnoreGravity` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 15 | `Direction8` | `nDirection8` | 整数 | 待确认 | 待确认 | 待确认 |
| 16 | `HangFlag` | `nHangFlag` | 整数 | 待确认 | 待确认 | 待确认 |
| 17 | `OnTowerFlag` | `nOnTowerFlag` | 整数 | 待确认 | 待确认 | 待确认 |
| 18 | `CanTowerFlag` | `nCanTowerFlag` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `InProgress` | `nInProgress` | 整数 | 待确认 | 待确认 | 待确认 |
| 20 | `BuffID` | `dwBuffID` | 整数 | Buff ID | 字段名推断 | 低 |
| 21 | `nParkourFlag` | `nParkourFlag` | 整数 | 待确认 | 待确认 | 待确认 |
| 22 | `nIsHasValidTrack` | `nIsHasValidTrack` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 23 | `bSlideSprintFlag` | `bSlideSprintFlag` | 整数 | 待确认 | 待确认 | 待确认 |
| 24 | `InStickCamera` | `nInStickCamera` | 整数 | 待确认 | 待确认 | 待确认 |
| 25 | `KeyStateGroup` | `szKeyState` | 字符串 | 待确认 | 待确认 | 待确认 |
| 26 | `MoveStateGroup` | `szMoveState` | 字符串 | 待确认 | 待确认 | 待确认 |
| 27 | `HangVelocityAndDirection` | `szHangVelocityAndDirection` | 字符串 | 待确认 | 待确认 | 待确认 |
| 28 | `ActionGroup` | `szAction` | 字符串 | 待确认 | 待确认 | 待确认 |
| 29 | `MobileActionGroup` | `szMobileAction` | 字符串 | 待确认 | 待确认 | 待确认 |
| 30 | `DisplayGroup` | `szDisplay` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 31 | `DescImage` | `szDescImg` | 路径 | 待确认 | 待确认 | 待确认 |
| 32 | `DescFrame` | `nDescFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 33 | `OTAction` | `szOTActionBar` | 字符串 | 待确认 | 待确认 | 待确认 |
| 34 | `desc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 35 | `comment` | `szComment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## Sprint\Display.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Index` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `IconPath` | `szIconPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `IconFrame` | `nIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `Tip` | `szTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `comment` | `szcomment` | 字符串 | 待确认 | 待确认 | 待确认 |

## Sring_MobaInformation.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 待确认 | 待确认 | 待确认 |

## string.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_20yiFeedBack.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_AccountException.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 待确认 | 待确认 | 待确认 |

## String_AchievementPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 待确认 | 待确认 | 待确认 |

## string_AchievementTrace.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_ActionBarBind.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_ActivityList.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_AIChat.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 待确认 | 待确认 | 待确认 |

## string_ArenaCorpsPanel.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `szID` | 字符串 | ID | 字段名推断 | 低 |
| 2 | `Length` | `dwLength` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `String` | `szString` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## string_ArenaLivePanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_AsuraAssemble.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_AuctionPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_BalanceShip.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_BankUnlock.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_BigBagPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 待确认 | 待确认 | 待确认 |

## string_BlueSeaPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_BonusPool.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_CampFireworks.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_CampMaps.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `szID` | 字符串 | ID | 字段名推断 | 低 |
| 2 | `Length` | `dwLength` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `String` | `szString` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## string_CastingPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_ChannelPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_CharacterPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_ChatSettingPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_ChengHuangPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_Cohabitation.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_CoinShop_PointsAwardNew.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 待确认 | 待确认 | 待确认 |

## string_CoinShop_TuoyinRule.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_Comman.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `szID` | 字符串 | ID | 字段名推断 | 低 |
| 2 | `Length` | `dwLength` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `String` | `szString` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## string_CraftRead.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_CrossingChoosePanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_Cyclopaedia.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_DanmakuPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_DelphisGift.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_DLC.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_DomesticatePanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_Drama.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_DynamicCarrierBar.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_EndOfBattle.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_EnqueueVerification.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_EquipmentDIY.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_FaceStation.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 待确认 | 待确认 | 待确认 |

## string_FamePanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_FbAuction.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_FBlist.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_FeedBack.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_FurnitureCollection.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_GameGuidePanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_GMPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_GoldTeam.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_GuildBankPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_GuildMainPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_HLBView_Blueprint.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_HomelandAreaManagement.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_HomelandBuilding.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_HomelandChangeSkin.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_HomelandLocker.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_HomeLandOverview.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_HomelandPortalPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_HorsePanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_HouseFastPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_HouseMoving.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_HousePVP.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_InstrumentPlaying.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 待确认 | 待确认 | 待确认 |

## string_JiangHu.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_JiaYuan.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_JoinCamp.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_JXPlugin.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_JYPlay.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_LevelUpMax.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_LoadingPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_LoginCusomRole.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `szID` | 字符串 | ID | 字段名推断 | 低 |
| 2 | `Length` | `dwLength` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `String` | `szString` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## string_LoginRoleList.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_LoginServerList.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_LpickUp.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_LuckyPerson.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_Mahjong.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_MainPlotPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_MentorPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_MessageBoard.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_MiniGame.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 待确认 | 待确认 | 待确认 |

## string_MobaShop.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_MobileSkillTip.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_MonopolyQueue.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 待确认 | 待确认 | 待确认 |

## string_MonopolyReadyArea.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 待确认 | 待确认 | 待确认 |

## string_MonsterBook.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_NewFaceLift.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_NewPets.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_NewQuestPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_NewWorldMap.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_NewYearPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 待确认 | 待确认 | 待确认 |

## string_Novice.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_OperationActivity.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_OperationCenter.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 待确认 | 待确认 | 待确认 |

## string_OperationMode.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_OperatPreOrder.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_OrangeWeaponUpg.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_OtherPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_PanzhazhaiPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_Partner.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_PartnerTaskList.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 待确认 | 待确认 | 待确认 |

## String_PersonalCard.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_PlayerReturn.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_PlayerVisitCard.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_PleasantGoatFinal.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_PlotDialoguePanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_PrestigePanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_ProtocolAniDialogue.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 待确认 | 待确认 | 待确认 |

## string_PVP.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_PVPAcount.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_PVPMessageBoard.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_PVPSelectEquip.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_Questionnaire_Fresher.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_QuickConsumePanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 待确认 | 待确认 | 待确认 |

## string_RankingMaster.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_RedEnvelope.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_ReputationPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_RoadChivalrous.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_RoomPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_RougeLike.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_SafePanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_SafeReminder.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_SeasonJx3.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_Selfie.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_SetTeamLootMode.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_ShareBagPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_SignIn.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_SimpleDLCPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_SmallCalender.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_SnsPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_SurpriseFreeAd.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_SwitchCenter.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_SwitchServerDLC.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_TeachingPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_TeamBuilding.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_TongArena.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_TongBaoGift.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_TopMenu.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_TradingHouse.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_TwoDimensionalLogin.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_UISetting.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_Vagabond.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_VampireCountPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_VampireInfoPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_VideoManagerPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_VideoSettingPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_VoiceHall.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 待确认 | 待确认 | 待确认 |

## String_VoiceMessage.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## string_WantedPanel.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## String_ZombieFightFinal.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` |  | 未知 | ID | 字段名推断 | 低 |
| 2 | `Length` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 3 | `String` |  | 未知 | 文本内容 | 翻译列/字段名 | 中 |

## SurplusTip.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwKungfuID` | `dwKungfuID` | 整数 | 心法/内功ID | 字段名推断 | 低 |
| 2 | `szTip` | `szTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## SurpriseFree.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `TitlePath` | `szTitlePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `TitleFrame` | `nTitleFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `IconPath` | `szIconPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `IconFrame` | `nIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `Msg1` | `szMsg1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `Msg2` | `szMsg2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `IniFile` | `szIniFile` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## SwitchServerBossInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `nPage` | `nPage` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `nOpenTime` | `nOpenTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 5 | `nEndTime` | `nEndTime` | 整数 | 时间配置 | 字段名推断 | 低 |

## SwitchServerFieldInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `dwMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `szResource` | `szResource` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `szImgPath` | `szImgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## SwitchServerInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szBindCenter` | `szBindCenter` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `szContent` | `szContent` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `nOpenTime` | `nOpenTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 5 | `nBossPage` | `nBossPage` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `bBoss` | `bBoss` | 布尔 | 待确认 | 待确认 | 待确认 |
| 7 | `dwCenterID` | `dwCenterID` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `bAddFriend` | `bAddFriend` | 布尔 | 待确认 | 待确认 | 待确认 |
| 9 | `szRegionName` | `szRegionName` | 字符串 | 待确认 | 待确认 | 待确认 |

## SystemShopBanMapID.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nMapID` | `nMapID` | 整数 | 地图ID | 字段名推断 | 低 |

## SystemShopDetail.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nShopID` | `nShopID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szShopName` | `szShopName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `nCamp` | `nCamp` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 4 | `nTime` | `nTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 5 | `dwActivityID` | `dwActivityID` | 整数 | 活动ID | 字段名推断 | 低 |
| 6 | `bShowPic` | `bShowPic` | 布尔 | 图片资源配置 | 字段名推断 | 低 |
| 7 | `szRefreshCycle` | `szRefreshCycle` | 字符串 | 待确认 | 待确认 | 待确认 |

## SystemShopGroup.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwGroupID` | `dwGroupID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `nFullScreen` | `nFullScreen` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `GroupName1` | `szGroupName1` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 4 | `ShopClass1` | `szShopClass1` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 5 | `ShopList1` | `szShopList1` | 字符串 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 6 | `GroupName2` | `szGroupName2` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 7 | `ShopClass2` | `szShopClass2` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 8 | `ShopList2` | `szShopList2` | 字符串 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 9 | `GroupName3` | `szGroupName3` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 10 | `ShopClass3` | `szShopClass3` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 11 | `ShopList3` | `szShopList3` | 字符串 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 12 | `GroupName4` | `szGroupName4` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 13 | `ShopClass4` | `szShopClass4` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 14 | `ShopList4` | `szShopList4` | 字符串 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 15 | `GroupName5` | `szGroupName5` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 16 | `ShopClass5` | `szShopClass5` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 17 | `ShopList5` | `szShopList5` | 字符串 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 18 | `GroupName6` | `szGroupName6` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 19 | `ShopClass6` | `szShopClass6` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 20 | `ShopList6` | `szShopList6` | 字符串 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 21 | `GroupName7` | `szGroupName7` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 22 | `ShopClass7` | `szShopClass7` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 23 | `ShopList7` | `szShopList7` | 字符串 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 24 | `GroupName8` | `szGroupName8` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 25 | `ShopClass8` | `szShopClass8` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 26 | `ShopList8` | `szShopList8` | 字符串 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 27 | `GroupName9` | `szGroupName9` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 28 | `ShopClass9` | `szShopClass9` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 29 | `ShopList9` | `szShopList9` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 30 | `GroupName10` | `szGroupName10` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 31 | `ShopClass10` | `szShopClass10` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 32 | `ShopList10` | `szShopList10` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |

## talent.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nTalentID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `ForceID` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 3 | `TalentName` | `szTalentName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `TalentType` | `nTalentType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 5 | `IconID` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 6 | `Image` | `szImage` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 7 | `NoActiveImage` | `szNoActiveImage` | 字符串 | 图片资源配置 | 字段名推断 | 低 |

## teaching.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `0` | `id` | 整数 | ID | 字段名推断 | 低 |
| 2 | `ui_template_ini` | `template_ini` | 路径 | 待确认 | 待确认 | 待确认 |
| 3 | `ui_template_name` | `template_name` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `ui_pos` | `ui_pos` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `lock_mouse` | `lock_mouse` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `lock_hotkey` | `lock_hotkey` | 布尔 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 7 | `gray` | `gray_type` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 8 | `can_close` | `can_close` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 9 | `action` | `action` | 字符串 | 待确认 | 待确认 | 待确认 |
| 10 | `action_param` | `action_param` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 11 | `start_ani` | `start_ani` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `finish_ani` | `finish_ani` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 13 | `state_event` | `state_event` | 字符串 | 待确认 | 待确认 | 待确认 |
| 14 | `finish_condition` | `finish_condition` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 15 | `condition_param` | `condition_param` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 16 | `finish_server_event` | `finish_server_event` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |
| 17 | `next_state` | `next_state` | 整数 | 待确认 | 待确认 | 待确认 |
| 18 | `desc` | `desc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 19 | `teachingaim` | `teachingaim_id` | 整数 | 待确认 | 待确认 | 待确认 |
| 20 | `reset_teachingaim` | `reset_teachingaim` | 布尔 | 待确认 | 待确认 | 待确认 |

## teaching_aim.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `id` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `content` | `szContent` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## teaching_book.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `id` | `id` | 整数 | ID | 字段名推断 | 低 |
| 2 | `image` | `image_file` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `img_frame` | `image_frame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 4 | `title` | `title` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `desc` | `desc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |

## teaching_condition.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `教学状态完成条件(finish_condition)` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 2 | `param` |  | 未知 | 脚本/参数配置 | 字段名推断 | 低 |
| 3 | `desc` |  | 未知 | 描述文本 | 字段名推断 | 低 |

## teaching_feedback.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `id` | `id` | 整数 | ID | 字段名推断 | 低 |
| 2 | `key` | `key` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 3 | `param` | `param` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 4 | `lock_opt` | `lock_opt` | 布尔 | 待确认 | 待确认 | 待确认 |

## teaching_move.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `id` | `id` | 整数 | ID | 字段名推断 | 低 |
| 2 | `template_image` | `template_image` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 3 | `template_frame` | `template_frame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `obj_param` | `obj_param` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 5 | `quest_id` | `quest_id` | 整数 | 任务ID | 字段名推断 | 低 |
| 6 | `end_event` | `end_event` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `end_name` | `end_name` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `fly_time` | `fly_time` | 整数 | 时间配置 | 字段名推断 | 低 |

## teaching_tag.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `id` | `id` | 整数 | ID | 字段名推断 | 低 |
| 2 | `type` | `type` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 3 | `book_ids` | `book_ids` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `title` | `title` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `anchor` | `anchor` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `image` | `image_file` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `img_frame` | `image_frame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 8 | `big_image` | `big_image` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 9 | `big_image_frame` | `big_image_frame` | 整数 | 图片资源配置 | 字段名推断 | 低 |

## TeachingIntroduce.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `id` | `id` | 整数 | ID | 字段名推断 | 低 |
| 2 | `name` | `name` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `type` | `type` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `type_name` | `type_name` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 5 | `icon_path` | `icon_path` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `icon_frame` | `icon_frame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `image_bg` | `image_bg` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 8 | `image_bg_frame` | `image_bg_frame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 9 | `desc` | `desc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |

## TeamPosition.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ForceID` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `Mask1` | `dwMask1` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `Mask2` | `dwMask2` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `Mask3` | `dwMask3` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `Mask4` | `dwMask4` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `Mask5` | `dwMask5` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `Mask6` | `dwMask6` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `Mask7` | `dwMask7` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `Mask8` | `dwMask8` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `Mask9` | `dwMask9` | 整数 | 待确认 | 待确认 | 待确认 |

## TeamPosition_KungFu.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `KungFuID` | `dwKungFuID` | 整数 | 心法/内功ID | 字段名推断 | 低 |
| 2 | `Force` | `szForce` | 字符串 | 势力/阵营配置 | 翻译列/字段名 | 中 |
| 3 | `KungFu` | `szKungfuName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `Mask` | `nMask` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `Position` | `szPosition` | 字符串 | 坐标/尺寸配置 | 翻译列/字段名 | 中 |

## TeamPositionMask.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Index` | `dwIdex` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 2 | `Mask` | `dwMaskID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `Frame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 4 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 5 | `Position` | `szPosition` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |

## TeamRecruit.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `Type` | `dwType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `TypeName` | `szTypeName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 5 | `SubType` | `dwSubType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 6 | `SubTypeName` | `szSubTypeName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 7 | `MinLevel` | `dwMinLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 8 | `MaxPlayerNum` | `dwMaxPlayerNum` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 9 | `Camp` | `nCamp` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 10 | `MapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 11 | `QuestsID` | `dwQuestID` | 整数 | 任务ID | 字段名推断 | 低 |
| 12 | `Priority` | `nPriority` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `Day` | `szDay` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 14 | `StartTime` | `nStartTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 15 | `LastTime` | `nLastTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 16 | `PraiseType` | `nPraiseType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 17 | `Achievement` | `szAchievementRequire` | 字符串 | 成就相关配置 | 字段名推断 | 低 |
| 18 | `SwicthSever` | `bSwitchServer` | 布尔 | 待确认 | 待确认 | 待确认 |
| 19 | `nActivityID` | `nActivityID` | 整数 | 活动ID | 字段名推断 | 低 |
| 20 | `Mark` | `bMark` | 布尔 | 待确认 | 待确认 | 待确认 |

## TeamRecruitDynamic.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szQuest_ReID` | `szQuest_ReID` | 字符串 | 任务ID | 字段名推断 | 低 |

## TeamSpecialBuff.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Index` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `BuffID` | `dwBuffID` | 整数 | Buff ID | 字段名推断 | 低 |
| 4 | `BuffLevel` | `dwBuffLevel` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 5 | `IconID` | `dwIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 6 | `Desc` | `szDes` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## TipItem.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `IamgePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `ImageFrame` | `nImageFrame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 5 | `GoldNum` | `nGoldNum` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 6 | `Tip` | `szTip` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 7 | `SfxPath` | `szSfxPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 8 | `ShowTime` | `nShowTime` | 整数 | 时间配置 | 字段名推断 | 低 |
| 9 | `UpNum` | `nUpNum` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 10 | `UpIamgePath` | `szUpImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 11 | `UpImageFrame` | `nUpImageFrame` | 整数 | 图片资源配置 | 字段名推断 | 低 |
| 12 | `UpSfxPath` | `szUpSfxPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## TitleRank.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `TitleRank` | `dwRank` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `TitlePoint` | `dwTitlePoint` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `Desc` | `szTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `AttrDesc` | `szAttr` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## TongActivity.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID1` | `dwClassID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `ID2` | `dwSubClassID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `ID3` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 4 | `CanOpen` | `bCanOpen` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 5 | `IconID` | `dwIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 6 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 7 | `Time` | `szTime` | 字符串 | 时间配置 | 翻译列/字段名 | 中 |
| 8 | `TimeShow` | `szCycle` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `Place` | `szPlace` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 10 | `Reward` | `szReward` | 字符串 | 奖励配置 | 翻译列/字段名 | 中 |
| 11 | `Joinlevel` | `szJoinLevel` | 字符串 | 等级/品质 | 翻译列/字段名 | 中 |
| 12 | `JoinNPC` | `szJoinNPC` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 13 | `Content` | `szContent` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 14 | `LinkID` | `szLinkIDList` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 15 | `money` | `money` | 整数 | 金 | 源码注释 | 高 |
| 16 | `experience` | `experience` | 整数 | 经验 | 源码注释 | 高 |
| 17 | `justice` | `justice` | 整数 | 侠义值 | 源码注释 | 高 |
| 18 | `prestige` | `prestige` | 整数 | 威望 | 源码注释 | 高 |
| 19 | `titlepoint` | `titlepoint` | 整数 | 战阶 | 源码注释 | 高 |
| 20 | `exteriorpiece` | `exteriorpiece` | 字符串 | 拓印碎片 | 源码注释 | 高 |
| 21 | `train` | `train` | 整数 | 修为 | 源码注释 | 高 |
| 22 | `vigor` | `vigor` | 整数 | 活力 | 源码注释 | 高 |
| 23 | `tongfund` | `tongfund` | 整数 | 帮会资金 | 源码注释 | 高 |
| 24 | `tongresource` | `tongresource` | 整数 | 载具资源 | 源码注释 | 高 |
| 25 | `exitem1` | `exitem1` | 字符串 | 额外奖励的道具 | 源码注释 | 高 |
| 26 | `exitem2` | `exitem2` | 字符串 | 额外奖励的道具 | 源码注释 | 高 |
| 27 | `exitem3` | `exitem3` | 字符串 | 额外奖励的道具 | 源码注释 | 高 |
| 28 | `exitem4` | `exitem4` | 字符串 | 额外奖励的道具 | 源码注释 | 高 |
| 29 | `JoinlevelMobile` | `szJoinlevelMobile` | 字符串 | 等级/品质 | 字段名推断 | 低 |

## TongTechTreeList.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `NodeID` | `nNodeID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `Type` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `comment` | `comment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## TongTechTreeNode.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `NodeID` | `nNodeID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `Level` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `ImageFile` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `Frame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 5 | `DisableFrame` | `nDisableFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 7 | `Desc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 8 | `Introduce` | `szAllIntroduce` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## ToyBox.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `nIcon` | `nIcon` | 整数 | 图标 | 字段名推断 | 低 |
| 4 | `nSkillID` | `nSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 5 | `nSkillLevel` | `nSkillLevel` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 6 | `szEffect` | `szEffect` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `dwQuestID` | `dwQuestID` | 整数 | 任务ID | 字段名推断 | 低 |
| 8 | `dwMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 9 | `dwAchievementID` | `dwAchievementID` | 整数 | 成就ID | 字段名推断 | 低 |
| 10 | `szShop` | `szShop` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 11 | `szDesc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 12 | `dwDLCID` | `dwDLCID` | 整数 | DLC/资料片ID | 字段名推断 | 低 |
| 13 | `szFilter` | `szFilter` | 字符串 | 待确认 | 待确认 | 待确认 |
| 14 | `ItemIndex` | `dwItemIndex` | 整数 | 道具索引 | 字段名推断 | 低 |
| 15 | `nLevelGroup` | `nLevelGroup` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 16 | `nCountDataIndex` | `nCountDataIndex` | 整数 | 数量/计数 | 字段名推断 | 低 |
| 17 | `dwSetID` | `dwSetID` | 整数 | 待确认 | 待确认 | 待确认 |
| 18 | `nToyType` | `nToyType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 19 | `nbuff` | `nbuff` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 20 | `nbuffLevel` | `nbuffLevel` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 21 | `nQuality` | `nQuality` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 22 | `szMobileEffect` | `szMobileEffect` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |

## TrafficLine\CityPoint.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `index` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `id` | `id` | 整数 | ID | 字段名推断 | 低 |
| 3 | `mapid` | `mapid` | 整数 | 地图ID | 字段名推断 | 低 |
| 4 | `middlemapindex` | `middlemapindex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 5 | `comment` | `comment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `tothermapid` | `szothermapid` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `button` | `button` | 路径 | 待确认 | 待确认 | 待确认 |
| 8 | `normal` | `normal` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `over` | `over` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `down` | `down` | 整数 | 待确认 | 待确认 | 待确认 |
| 11 | `disable` | `disable` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 12 | `highlight` | `highlight` | 整数 | 待确认 | 待确认 | 待确认 |
| 13 | `x` | `x` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 14 | `y` | `y` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 15 | `w` | `w` | 整数 | 待确认 | 待确认 | 待确认 |
| 16 | `h` | `h` | 整数 | 待确认 | 待确认 | 待确认 |
| 17 | `xN` | `xN` | 整数 | 待确认 | 待确认 | 待确认 |
| 18 | `yN` | `yN` | 整数 | 待确认 | 待确认 | 待确认 |
| 19 | `nShowLevel` | `szShowLevel` | 字符串 | 等级/品质 | 字段名推断 | 低 |

## TrafficLine\CopyPoint.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `index` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `id` | `id` | 整数 | ID | 字段名推断 | 低 |
| 3 | `mapid` | `mapid` | 整数 | 地图ID | 字段名推断 | 低 |
| 4 | `middlemapindex` | `middlemapindex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 5 | `comment` | `comment` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `tothermapid` | `szothermapid` | 字符串 | 待确认 | 待确认 | 待确认 |
| 7 | `tip` | `tip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `button` | `button` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `x` | `x` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 10 | `y` | `y` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 11 | `xN` | `xN` | 整数 | 待确认 | 待确认 | 待确认 |
| 12 | `yN` | `yN` | 整数 | 待确认 | 待确认 | 待确认 |
| 13 | `nShowLevel` | `szShowLevel` | 字符串 | 等级/品质 | 字段名推断 | 低 |

## TrafficLine\MapIDToPoint.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `index` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `MapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 3 | `comment` | `comment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `x` | `x` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `y` | `y` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |

## TrafficLine\TrafficLine.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `index` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `from` | `from` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `to` | `to` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `comment` | `comment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `file` | `file` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `frame` | `frame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `disableframe` | `disableframe` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `hightlightframe` | `hightlightframe` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 9 | `disablefile` | `disablefile` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `hightlight` | `hightlight` | 路径 | 待确认 | 待确认 | 待确认 |
| 11 | `x` | `x` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `y` | `y` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 13 | `w` | `w` | 整数 | 待确认 | 待确认 | 待确认 |
| 14 | `h` | `h` | 整数 | 待确认 | 待确认 | 待确认 |
| 15 | `ShowLevel` | `szShowLevel` | 字符串 | 等级/品质 | 字段名推断 | 低 |

## TreasureBalanceBuff.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwMKungfuID` | `dwMKungfuID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `Buff_Five` | `szBuff1` | 字符串 | 五人吃鸡 | 源码注释 | 高 |
| 3 | `Buff_Single` | `szBuff2` | 字符串 | 单人吃鸡 | 源码注释 | 高 |
| 4 | `Buff_Hunt` | `szBuff5` | 字符串 | 吃鸡寻宝 | 源码注释 | 高 |

## TreasureBox\TreasureBoxContent.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szBoxName` | `szBoxName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `nContentTypeID` | `nContentType` | 整数 | 文本内容 | 字段名推断 | 低 |
| 4 | `nContentID` | `nContentID` | 整数 | 文本内容 | 字段名推断 | 低 |
| 5 | `szContentType` | `szContentType` | 字符串 | 文本内容 | 字段名推断 | 低 |
| 6 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 7 | `szItem` | `szItem` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 8 | `nLuckyID` | `nLuckyID` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `nLuckyCamp` | `nLuckyCamp` | 整数 | 奇遇阵营 | 源码注释 | 高 |
| 10 | `szImageType` | `szImageType` | 字符串 | 图片资源配置 | 字段名推断 | 低 |
| 11 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 12 | `szVKImagePath` | `szVKImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 13 | `szAndItem` | `szAndItem` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 14 | `szOtherItem` | `szOtherItem` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 15 | `nAvatarID` | `nAvatarID` | 整数 | 头像 | 源码注释 | 高 |
| 16 | `nFaceID` | `nFaceID` | 整数 | 头顶表情 | 源码注释 | 高 |
| 17 | `nPrefixID` | `nPrefixID` | 整数 | 脚印称号(前缀) | 源码注释 | 高 |
| 18 | `nPostfixID` | `nPostfixID` | 整数 | 脚印称号(后缀) | 源码注释 | 高 |
| 19 | `nCollectPetID` | `nPetID` | 整数 | 待确认 | 待确认 | 待确认 |
| 20 | `nExteriorID` | `nExteriorID` | 整数 | 外观 | 源码注释 | 高 |
| 21 | `PendentID` | `nPendentID` | 整数 | 挂件ID | 源码注释 | 高 |
| 22 | `dwSkinID` | `dwSkinID` | 整数 | 武技殊影图 | 源码注释 | 高 |
| 23 | `nQuestID` | `nQuestID` | 整数 | 任务 | 源码注释 | 高 |
| 24 | `nImageStyle` | `nImageStyle` | 整数 | 图片样式 | 源码注释 | 高 |
| 25 | `bNotCollect` | `bNotCollect` | 布尔 | 无收集属性 | 源码注释 | 高 |
| 26 | `bScriptCollect` | `bScriptCollect` | 布尔 | 是否特殊收集判定物品 | 源码注释 | 高 |

## TreasureBox\TreasureBoxInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nGroupID` | `nGroupID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nTypeID` | `nTypeID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `szTypeName` | `szTypeName` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 5 | `szItemName` | `szItemName` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 6 | `szBoxItem` | `szBoxItem` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 7 | `nMaxTime` | `nMaxTime` | 整数 | 保底 | 源码注释 | 高 |
| 8 | `bMutiOpen` | `bMultiOpen` | 布尔 | 多开 | 源码注释 | 高 |
| 9 | `nStyle` | `nStyle` | 整数 | 界面样式 | 源码注释 | 高 |
| 10 | `bOwnToShow` | `bOwnToShow` | 布尔 | 拥有才显示 | 源码注释 | 高 |
| 11 | `szOtherCheck` | `szOtherCheck` | 字符串 | 可查看的道具 | 源码注释 | 高 |
| 12 | `bPreviewOnly` | `bPreviewOnly` | 布尔 | 不支持开箱 | 源码注释 | 高 |
| 13 | `szPreviewOnlyDsc` | `szPreviewOnlyDsc` | 字符串 | 可查看的道具 | 源码注释 | 高 |

## TreasureHuntEffect.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 字段名推断 | 低 |
| 3 | `szDesc` | `szDesc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 4 | `szImagePath` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## TreasureInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Ranking` | `nRanking` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 3 | `szMap` | `szMap` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `Path` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `Frame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 6 | `BgPath` | `szBgPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 7 | `BgFrame` | `nBgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `SFXBgPath` | `szSFXBgPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 9 | `SFXTextPath` | `szSFXTextPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 10 | `SoundPath` | `szSoundPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## TreasureTeamInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwTeamID` | `dwTeamID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `Path` | `szImagePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `NormalFrame` | `nNormalFrame` | 整数 | 普通状态帧号 | 字段名推断 | 低 |
| 4 | `VIPFrame` | `nVIPFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## TrialValley.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Type` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 2 | `Level` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `TypeName` | `szTypeName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 4 | `TypePath` | `szTypePath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `NormalFrame` | `nNormalFrame` | 整数 | 普通状态帧号 | 字段名推断 | 低 |
| 6 | `HighFrame` | `nHighFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 7 | `PassNormal` | `nPassNormal` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `PassHigh` | `nPassHigh` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `DisableNormal` | `nDisableNormal` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 10 | `DisableHigh` | `nDisableHigh` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 11 | `DESCRIPTION` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |

## UICraft.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `RecipeTabPath` | `szPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |

## UIMapMask.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `szHierarchy` | `szHierarchy` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 2 | `szPanel` | `szPanel` | 字符串 | 待确认 | 待确认 | 待确认 |
| 3 | `MapMaskList` | `MapMaskList` | 字符串 | 开关/条件配置 | 字段名推断 | 低 |

## UIVerifyQuest.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `key` | `key` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 2 | `questids` | `questids` | 字符串 | 任务ID | 字段名推断 | 低 |

## UpSkill_Effect.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwSkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 2 | `nMaxRadius` | `nMaxRadius` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `bIsShowSFX` | `bIsShowSFX` | 布尔 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `dwEffectID` | `dwEffectID` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `dwSkillID` | `dwConditionSkill` | 整数 | 技能相关配置 | 字段名推断 | 低 |
| 6 | `dwEffectID` | `dwReplaceEffectID` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `dwMiJiID` | `dwMiJiID` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `dwMiJiEffectID` | `dwMiJiEffectID` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `dwQiXueAndMiJiEffectID` | `dwQiXueAndMiJiEffectID` | 整数 | 待确认 | 待确认 | 待确认 |

## VagabondCraftInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nClassificationID` | `nClassificationID` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nCraftLevel` | `nCraftLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 4 | `szRareName` | `szRareName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `szTypeName` | `szTypeName` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 6 | `szItemInfo` | `szItemInfo` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 7 | `szRecipe` | `szRecipe` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `nUseBuffID` | `nUseBuffID` | 整数 | Buff ID | 字段名推断 | 低 |
| 9 | `nBuffStackCost` | `nBuffStackCost` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 10 | `nBuffImgFrame` | `nBuffImgFrame` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 11 | `szUnlockTip` | `szUnlockTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## VagabondCrossMapInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nMapID` | `nMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 2 | `szImgPath` | `szImgPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nImgFrame` | `nImgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `szTip` | `szTip` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `szMBImagePath` | `szMBImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |

## VagabondCrossMapTips.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szIconPath` | `szIconPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 4 | `szDes` | `szDes` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## VagabondStartInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `nID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nImgFrame` | `nImgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 3 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 4 | `szSubTitle` | `szSubTitle` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `szDesc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 6 | `szRuleDesc` | `szRuleDesc` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `szLimit` | `szLimit` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `szAward` | `szAward` | 字符串 | 奖励配置 | 字段名推断 | 低 |

## videosetting.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `BD` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `Level` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 3 | `Desc` |  | 未知 | 描述文本 | 翻译列/字段名 | 中 |
| 4 | `FullScreen` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 5 | `Panauision` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `ExclusiveMode` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 7 | `ScreenSizeLimitedRate` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `Width` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 9 | `Height` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 10 | `nScaleUpMode` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 11 | `nRenderLevel` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 12 | `nEngineGraphicsLevel` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 13 | `bEnableScreenWeather` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 14 | `nRenderLimit` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 15 | `nRenderNpcLimit` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 16 | `ClientSFXLimit` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 17 | `OptimizeQiChang` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 18 | `OptimizeUniform` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 19 | `OptimizeRide` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 20 | `EnableAniShadow` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 21 | `nShadowType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 22 | `Fabric` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 23 | `bEnableRC_AmbientOcclusion` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 24 | `bEnableRC_Bloom` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 25 | `bEnableRC_Depth` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 26 | `bEnableRC_LightShaftBloom` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 27 | `bEnableRC_LightShaftOcclusion` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 28 | `bEnableRC_StingRayVolumetircCloud` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 29 | `bEnableRC_SunLensflare` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 30 | `bEnableRC_Vignette` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 31 | `bEnableRC_AtmosphericFog` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 32 | `bEnableRC_HeightFog` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 33 | `bEnableRC_SSS` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 34 | `bEnableSSPR` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 35 | `bEnableRC_ShockWave` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 36 | `bEnableRC_SpotLight` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 37 | `bEnableRC_DirectionLight` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 38 | `bEnableRC_PointLight` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 39 | `bEnableRC_SkyLight` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 40 | `bEnableRC_SpotLightShadow` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 41 | `bEnableRC_DirectionLightShadow` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 42 | `bEnableRC_PointLightShadow` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 43 | `nRC_EnvProbeLevel` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 44 | `bEnableRC_FoliageBlur` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 45 | `bEnableSubFoliageHCRender` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 46 | `bEnableSubFoliageSTRender` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 47 | `bEnableSubFoliageWJRender` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 48 | `bEnableSubFoliageGMRender` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 49 | `bEnableSubFoliageTWRender` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 50 | `nFoliageDensity` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 51 | `nStartLodLevelInAutoLodMode` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 52 | `fSpeedTreeCullDist` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 53 | `fSimpleModelCullDist` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 54 | `fParticleSystemCullDist` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 55 | `fPointlightCullDist` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 56 | `bEnableModelLodRadius` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 57 | `ModelLodRadius` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 58 | `fSpeedTreeShadowCullDist` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 59 | `fSimpleModelShadowCullDist` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 60 | `fParticleSystemShadowCullDist` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 61 | `fPointlightShadowCullDist` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 62 | `fCameraDistanceHD` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 63 | `fNodeLodLowLimit` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 64 | `fNodeLodHighLimit` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 65 | `nNewWaterQualityLevel` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 66 | `TexLODLimit` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 67 | `MyEffect` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 68 | `OtherEffect` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 69 | `bEnableRealTimeTerrainBake` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 70 | `nTerrainBakeScaleRate` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 71 | `bEnableRC_EyeProtectionMode` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 72 | `fSpeedTreeAngleCull` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 73 | `fSpeedTreeGlobalLodScaleTimes` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 74 | `fAngleCullValue` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 75 | `AAOPTION_EnableSMAA` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 76 | `fRC_EyeProtectBrightness` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 77 | `bEnableRC_ForwardRender` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 78 | `nSpeedTreeDensity` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 79 | `fFoliageCullDist` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 80 | `bEnableFur` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 81 | `nMaxFPS` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 82 | `fMyEffectAlpha` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 83 | `fMyEffectLight` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 84 | `fOtherEffectAlpha` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 85 | `fOtherEffectLight` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 86 | `AAOPTION_DLSSOption` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 87 | `AAOPTION_DLSSParam` |  | 未知 | 脚本/参数配置 | 字段名推断 | 低 |
| 88 | `SpeedTreeLeafScale` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 89 | `MinimumModelLod` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 90 | `TerrainBakeMethod` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 91 | `ShowLayer` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 92 | `szReduceTextureSize` |  | 未知 | 文本内容 | 字段名推断 | 低 |
| 93 | `AAOPTION_EnableTXAA` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 94 | `nSfxLodDist1` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 95 | `nSfxLodDist2` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 96 | `nSfxLodDist3` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 97 | `bEnableRC_HighEnvironmentRender` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 98 | `bEnableRC_ForceSkyCubeTex` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 99 | `bEnableRC_ForceSkyOitToSoftMask` |  | 未知 | 势力/阵营配置 | 字段名推断 | 低 |
| 100 | `nModelInstanceThreshold(开启合并渲染值)` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 101 | `fSceneNodeClusterLoadDistance` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 102 | `fSceneNodeClusterUnLoadDistance` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 103 | `bEnableCASSharper` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 104 | `bRenderPointLightLimit（是否开启点光源的数量限制）` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 105 | `nRenderPointLightLimitCount` |  | 未知 | 数量/计数 | 字段名推断 | 低 |
| 106 | `bEnableModelLodViewAngle` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 107 | `szModelLodViewAngle` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 108 | `bEnableAnimationPrecompute` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 109 | `bEnableDayNightCycle` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 110 | `bEnableVolumetricHeightFog` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 111 | `bEnableIndirectLightVolume` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 112 | `bEnableRC_SSR` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 113 | `bEnableSceneNodeAngleCull` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 114 | `bEnableLensLightGlobal` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 115 | `bEnableViewProbe` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 116 | `bEnableViewProbeShadow` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 117 | `bEnableViewProbeColor` |  | 未知 | 颜色配置 | 字段名推断 | 低 |
| 118 | `fViewProbeBlendStart` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 119 | `fViewProbeBlendEnd` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 120 | `fViewProbeShadowStart` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 121 | `fViewProbeShadowEnd` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 122 | `bEnableFSR2` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 123 | `nFSR2Option` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 124 | `bAutoConvertModelLoading` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 125 | `bEnableInteractFluids` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 126 | `bEnableTressFX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 127 | `bEnableTressFXMainPlayerOnly` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 128 | `fTressFXOtherPlayerDensity` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 129 | `fLod0Percent` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 130 | `fLod1Percent` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 131 | `bActorMaxLod` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 132 | `bDiamondFire` |  | 未知 | 待确认 | 待确认 | 待确认 |

## videosettinginvalid.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `mapID` | `nMap` | 整数 | 待确认 | 待确认 | 待确认 |

## videosettingnotebook.txt

- table_defs.lua：否

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `BD` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 2 | `Level` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 3 | `Desc` |  | 未知 | 描述文本 | 翻译列/字段名 | 中 |
| 4 | `FullScreen` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 5 | `Panauision` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `ExclusiveMode` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 7 | `ScreenSizeLimitedRate` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 8 | `Width` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 9 | `Height` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 10 | `nScaleUpMode` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 11 | `nRenderLevel` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 12 | `nEngineGraphicsLevel` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 13 | `bEnableScreenWeather` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 14 | `nRenderLimit` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 15 | `nRenderNpcLimit` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 16 | `ClientSFXLimit` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 17 | `OptimizeQiChang` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 18 | `OptimizeUniform` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 19 | `OptimizeRide` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 20 | `EnableAniShadow` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 21 | `nShadowType` |  | 未知 | 类型/分类 | 字段名推断 | 低 |
| 22 | `Fabric` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 23 | `bEnableRC_AmbientOcclusion` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 24 | `bEnableRC_Bloom` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 25 | `bEnableRC_Depth` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 26 | `bEnableRC_LightShaftBloom` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 27 | `bEnableRC_LightShaftOcclusion` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 28 | `bEnableRC_StingRayVolumetircCloud` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 29 | `bEnableRC_SunLensflare` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 30 | `bEnableRC_Vignette` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 31 | `bEnableRC_AtmosphericFog` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 32 | `bEnableRC_HeightFog` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 33 | `bEnableRC_SSS` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 34 | `bEnableSSPR` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 35 | `bEnableRC_ShockWave` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 36 | `bEnableRC_SpotLight` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 37 | `bEnableRC_DirectionLight` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 38 | `bEnableRC_PointLight` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 39 | `bEnableRC_SkyLight` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 40 | `bEnableRC_SpotLightShadow` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 41 | `bEnableRC_DirectionLightShadow` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 42 | `bEnableRC_PointLightShadow` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 43 | `nRC_EnvProbeLevel` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 44 | `bEnableRC_FoliageBlur` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 45 | `bEnableSubFoliageHCRender` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 46 | `bEnableSubFoliageSTRender` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 47 | `bEnableSubFoliageWJRender` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 48 | `bEnableSubFoliageGMRender` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 49 | `bEnableSubFoliageTWRender` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 50 | `nFoliageDensity` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 51 | `nStartLodLevelInAutoLodMode` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 52 | `fSpeedTreeCullDist` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 53 | `fSimpleModelCullDist` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 54 | `fParticleSystemCullDist` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 55 | `fPointlightCullDist` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 56 | `bEnableModelLodRadius` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 57 | `ModelLodRadius` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 58 | `fSpeedTreeShadowCullDist` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 59 | `fSimpleModelShadowCullDist` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 60 | `fParticleSystemShadowCullDist` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 61 | `fPointlightShadowCullDist` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 62 | `fCameraDistanceHD` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 63 | `fNodeLodLowLimit` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 64 | `fNodeLodHighLimit` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 65 | `nNewWaterQualityLevel` |  | 未知 | 等级/品质 | 字段名推断 | 低 |
| 66 | `TexLODLimit` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 67 | `MyEffect` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 68 | `OtherEffect` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 69 | `bEnableRealTimeTerrainBake` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 70 | `nTerrainBakeScaleRate` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 71 | `bEnableRC_EyeProtectionMode` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 72 | `fSpeedTreeAngleCull` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 73 | `fSpeedTreeGlobalLodScaleTimes` |  | 未知 | 时间配置 | 字段名推断 | 低 |
| 74 | `fAngleCullValue` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 75 | `AAOPTION_EnableSMAA` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 76 | `fRC_EyeProtectBrightness` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 77 | `bEnableRC_ForwardRender` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 78 | `nSpeedTreeDensity` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 79 | `fFoliageCullDist` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 80 | `bEnableFur` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 81 | `nMaxFPS` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 82 | `fMyEffectAlpha` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 83 | `fMyEffectLight` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 84 | `fOtherEffectAlpha` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 85 | `fOtherEffectLight` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 86 | `AAOPTION_DLSSOption` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 87 | `AAOPTION_DLSSParam` |  | 未知 | 脚本/参数配置 | 字段名推断 | 低 |
| 88 | `SpeedTreeLeafScale` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 89 | `MinimumModelLod` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 90 | `TerrainBakeMethod` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 91 | `ShowLayer` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 92 | `szReduceTextureSize` |  | 未知 | 文本内容 | 字段名推断 | 低 |
| 93 | `AAOPTION_EnableTXAA` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 94 | `nSfxLodDist1` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 95 | `nSfxLodDist2` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 96 | `nSfxLodDist3` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 97 | `bEnableRC_HighEnvironmentRender` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 98 | `bEnableRC_ForceSkyCubeTex` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 99 | `bEnableRC_ForceSkyOitToSoftMask` |  | 未知 | 势力/阵营配置 | 字段名推断 | 低 |
| 100 | `nModelInstanceThreshold(开启合并渲染值)` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 101 | `fSceneNodeClusterLoadDistance` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 102 | `fSceneNodeClusterUnLoadDistance` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 103 | `bEnableCASSharper` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 104 | `bRenderPointLightLimit（是否开启点光源的数量限制）` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 105 | `nRenderPointLightLimitCount` |  | 未知 | 数量/计数 | 字段名推断 | 低 |
| 106 | `bEnableModelLodViewAngle` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 107 | `szModelLodViewAngle` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 108 | `bEnableAnimationPrecompute` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 109 | `bEnableDayNightCycle` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 110 | `bEnableVolumetricHeightFog` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 111 | `bEnableIndirectLightVolume` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 112 | `bEnableRC_SSR` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 113 | `bEnableSceneNodeAngleCull` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 114 | `bEnableLensLightGlobal` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 115 | `bEnableViewProbe` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 116 | `bEnableViewProbeShadow` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 117 | `bEnableViewProbeColor` |  | 未知 | 颜色配置 | 字段名推断 | 低 |
| 118 | `fViewProbeBlendStart` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 119 | `fViewProbeBlendEnd` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 120 | `fViewProbeShadowStart` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 121 | `fViewProbeShadowEnd` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 122 | `bEnableFSR2` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 123 | `nFSR2Option` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 124 | `bAutoConvertModelLoading` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 125 | `bEnableInteractFluids` |  | 未知 | 开关/条件配置 | 字段名推断 | 低 |
| 126 | `bEnableTressFX` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 127 | `bEnableTressFXMainPlayerOnly` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 128 | `fTressFXOtherPlayerDensity` |  | 未知 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 129 | `fLod0Percent` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 130 | `fLod1Percent` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 131 | `bActorMaxLod` |  | 未知 | 待确认 | 待确认 | 待确认 |
| 132 | `bDiamondFire` |  | 未知 | 待确认 | 待确认 | 待确认 |

## videosettingoption.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `id` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `sub` | `szSub` | 字符串 | 二级分类/子类ID | 字段名推断 | 低 |
| 4 | `bDecline(value是否递减，2是完全相等)` | `nDecline` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `value1` | `szSubValue1` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `name1` | `szSubName1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `value2` | `szSubValue2` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `name2` | `szSubName2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `value3` | `szSubValue3` | 字符串 | 待确认 | 待确认 | 待确认 |
| 10 | `name3` | `szSubName3` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 11 | `value4` | `szSubValue4` | 字符串 | 待确认 | 待确认 | 待确认 |
| 12 | `name4` | `szSubName4` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 13 | `value5` | `szSubValue5` | 字符串 | 待确认 | 待确认 | 待确认 |
| 14 | `name5` | `szSubName5` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## videosettingsm.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Level(配置等级)` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Desc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 3 | `Tip` | `szTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 4 | `nMaxFPS（限制最高帧数）` | `nMaxFPS` | 整数 | 待确认 | 待确认 | 待确认 |
| 5 | `nRenderLimit（同屏玩家人数）` | `nRenderLimit` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `nRenderNpcLimit(同屏NPC人数)` | `nRenderNpcLimit` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `ClientSFXLimit（同屏特效，1000表示不限制）` | `nClientSFXLimit` | 整数 | 待确认 | 待确认 | 待确认 |
| 8 | `ScreenSizeLimitedRate(分辨率)` | `nScreenSizeLimitedRate` | 整数 | 待确认 | 待确认 | 待确认 |
| 9 | `"MyEffect（自身特效， 0 1 2 3 四个参数，但是 0 和 1 差别比较不可控，最后只有0,2,3三个参数使用）"` | `nMyEffect` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `fMyEffectAlpha(自身特效透明度)` | `fMyEffectAlpha` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 11 | `fMyEffectLight(自身特效明暗度)` | `fMyEffectLight` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 12 | `"OtherEffect(他人特效，0 1 2 3 四个参数，但是 0 和 1 差别比较不可控，最后只有0,2,3三个参数使用)"` | `nOtherEffect` | 整数 | 待确认 | 待确认 | 待确认 |
| 13 | `fOtherEffectAlpha(他人特效透明度)` | `fOtherEffectAlpha` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 14 | `fOtherEffectLight(他人特效明暗度)` | `fOtherEffectLight` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 15 | `nSfxLodDist1(特效裁剪距离1)` | `nSfxLodDist1` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 16 | `nSfxLodDist2(特效裁剪距离2)` | `nSfxLodDist2` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 17 | `nSfxLodDist3(特效裁剪距离3)` | `nSfxLodDist3` | 整数 | 开关/条件配置 | 字段名推断 | 低 |
| 18 | `bEnableRC_Depth（镜头景深DOF）` | `bEnableRC_Depth` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 19 | `bShowOutline（屏蔽勾边）` | `bShowOutline` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 20 | `bEnableDayNightCycle(日夜循环)` | `bEnableDayNightCycle` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## videosettingsmoperation.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `Level(配置等级)` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Desc` | `szDesc` | 字符串 | 描述文本 | 翻译列/字段名 | 中 |
| 3 | `CanSetLowest(最简)` | `bCanSetLowest` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 4 | `CanSetLowmost(简约)` | `bCanSetLowmost` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 5 | `CanSetLow(均衡)` | `bCanSetLow` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 6 | `CanSetMedium(唯美)` | `bCanSetMedium` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 7 | `CanSetAdvanced(高效)` | `bCanSetAdvanced` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 8 | `CanSetPerfect(电影)` | `bCanSetPerfect` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |
| 9 | `CanSetHD（极致）` | `bCanSetHD` | 布尔 | 开关/条件配置 | 字段名推断 | 低 |

## videosettingSpecialMap.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `id` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Des` | `szDes` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `nStartIndex` | `nKey` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `szKey` | `szKey` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 5 | `szString` | `szString` | 多语言文本 | 待确认 | 待确认 | 待确认 |
| 6 | `szMapID` | `szMapID` | 字符串 | 地图ID | 字段名推断 | 低 |
| 7 | `nType` | `nType` | 整数 | 类型/分类 | 字段名推断 | 低 |

## videosettingversion.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `version` | `nVersion` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `Desc` | `szDesc` | 字符串 | 描述文本 | 字段名推断 | 低 |
| 3 | `szUpParam` | `szUpParam` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |

## VoiceRoomSkin.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szRoomPath` | `szRoomPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `szRecommondPath` | `szRecommandPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 4 | `szLinkTipPath` | `szLinkTipPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## VoiceType.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `szUITex` | `szUITex` | 字符串 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 4 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 5 | `nNormal` | `nNormalFrame` | 整数 | 普通状态帧号 | 字段名推断 | 低 |
| 6 | `nHover` | `nOverFrame` | 整数 | 悬停/经过状态帧号 | 字段名推断 | 低 |
| 7 | `nDown` | `nDownFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `nDisbale` | `nDisableFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## wanted_roleavatar.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `forceid` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 2 | `f1_image` | `szF1Image` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 3 | `f1_frame` | `nF1ImgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 4 | `f2_image` | `szF2Image` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 5 | `f2_frame` | `nF2ImgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `m1_image` | `szM1Image` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 7 | `m1_frame` | `nM1ImgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 8 | `m2_image` | `szM2Image` | 路径 | 图片资源配置 | 字段名推断 | 低 |
| 9 | `m2_frame` | `nM2ImgFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## WantedLimitMap.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `MapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 2 | `Mask` | `dwMask` | 整数 | 待确认 | 待确认 | 待确认 |

## WarningType.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwIndex` | `dwIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `szType` | `szType` | 字符串 | 类型/分类 | 字段名推断 | 低 |
| 3 | `nPanelIndex` | `nPanelIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 4 | `nWarningFrameL` | `nFrameL` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `nWarningFrameM` | `nFrameM` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `nWarningFrameR` | `nFrameR` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |

## WebURL.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Comment` | `szComment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `szUrl` | `szUrl` | 字符串 | 链接/跳转配置 | 字段名推断 | 低 |
| 4 | `Entrance` | `szEntrance` | 路径 | 待确认 | 待确认 | 待确认 |
| 5 | `IniFile` | `szIniFile` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `bFullScreen` | `szIconPath` | 路径 | {f = "p", t = "szIconPath"}, | 源码注释 | 高 |
| 7 | `bSimpleWeb` | `bFullScreen` | 布尔 | 待确认 | 待确认 | 待确认 |
| 8 | `bSign` | `nWebType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 9 | `bLoginSign` | `bSign` | 布尔 | 待确认 | 待确认 | 待确认 |
| 10 | `nSignType` | `bLoginSign` | 布尔 | 待确认 | 待确认 | 待确认 |
| 11 | `bRemoteSign` | `nSignType` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 12 | `StartTime` | `bRemoteSign` | 布尔 | 待确认 | 待确认 | 待确认 |
| 13 | `EndTime` | `szStartTime` | 字符串 | 时间配置 | 字段名推断 | 低 |
| 14 | `Param` | `szEndTime` | 字符串 | 时间配置 | 字段名推断 | 低 |
| 15 | `szCenterID` | `szParam` | 字符串 | 脚本/参数配置 | 字段名推断 | 低 |
| 16 | `nExtPoint` | `szCenterID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 17 | `szFunction` | `nExtPoint` | 整数 | 待确认 | 待确认 | 待确认 |
| 18 | `szRedDotItemName` | `szFunction` | 字符串 | 待确认 | 待确认 | 待确认 |
| 19 | `nRedDotVersion` | `szRedDotItemName` | 字符串 | 道具相关配置 | 字段名推断 | 低 |
| 20 | `szTip` | `nRedDotVersion` | 整数 | 待确认 | 待确认 | 待确认 |

## WinterFestivalEnchantInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwEnchantID` | `dwEnchantID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `szPath` | `szPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 4 | `nIconFrame` | `nIconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 5 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 6 | `szAttribute` | `szAttribute` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `szSuitName` | `szSuitName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 8 | `szSuitAttribute` | `szSuitAttribute` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 9 | `szEnchant1` | `szEnchant1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 10 | `szEnchant2` | `szEnchant2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 11 | `szEnchant3` | `szEnchant3` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 12 | `szEnchant4` | `szEnchant4` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 13 | `szMobileFrame` | `szMobileFrame` | 字符串 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 14 | `szMobileIconFrame` | `szMobileIconFrame` | 字符串 | 帧号/图片帧配置 | 字段名推断 | 低 |

## WinterFestivalNpcInfo.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szAvatarPath` | `szAvatarPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 4 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 5 | `szTitle` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 6 | `nColorFrame` | `nColorFrame` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 7 | `nMaxLevel` | `nMaxLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 8 | `nSkillID1` | `nSkillID1` | 整数 | 技能ID | 字段名推断 | 低 |
| 9 | `nSkillID2` | `nSkillID2` | 整数 | 技能ID | 字段名推断 | 低 |
| 10 | `nSkillID3` | `nSkillID3` | 整数 | 技能ID | 字段名推断 | 低 |
| 11 | `szSkill1Tip` | `szSkill1Tip` | 字符串 | 技能相关配置 | 翻译列/字段名 | 中 |
| 12 | `szSkill2Tip` | `szSkill2Tip` | 字符串 | 技能相关配置 | 翻译列/字段名 | 中 |
| 13 | `szSkill3Tip` | `szSkill3Tip` | 字符串 | 技能相关配置 | 翻译列/字段名 | 中 |
| 14 | `szAttribute1` | `szAttribute1` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 15 | `szAttribute2` | `szAttribute2` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 16 | `szAttribute3` | `szAttribute3` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 17 | `szAttribute4` | `szAttribute4` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 18 | `szAttribute5` | `szAttribute5` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 19 | `szAttribute6` | `szAttribute6` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 20 | `szAttribute7` | `szAttribute7` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 21 | `nAttribute1IconFrame` | `nAttribute1IconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 22 | `nAttribute2IconFrame` | `nAttribute2IconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 23 | `nAttribute3IconFrame` | `nAttribute3IconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 24 | `nAttribute4IconFrame` | `nAttribute4IconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 25 | `nAttribute5IconFrame` | `nAttribute5IconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 26 | `nAttribute6IconFrame` | `nAttribute6IconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 27 | `nAttribute7IconFrame` | `nAttribute7IconFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 28 | `szMobileAvatarPath` | `szMobileAvatarPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |

## WinterFestivalSkillMsg.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szAvatarPath` | `szAvatarPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 3 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 4 | `szText` | `szText` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

## WLBeastClass.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Name` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `IconID` | `dwIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 4 | `ImgPath` | `szPath` | 路径 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `ImagFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |
| 6 | `SkillID` | `dwSkillID` | 整数 | 技能ID | 字段名推断 | 低 |
| 7 | `SkillLevel` | `dwSkillLevel` | 整数 | 技能相关配置 | 字段名推断 | 低 |

## WLBeastInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 3 | `Class` | `dwClass` | 整数 | 类型/分类 | 字段名推断 | 低 |
| 4 | `Desc` | `szDesc` | 多语言文本 | 描述文本 | 翻译列/字段名 | 中 |
| 5 | `ModelID` | `dwModelID` | 整数 | 待确认 | 待确认 | 待确认 |
| 6 | `ColorChannelTable` | `nColorChannelTable` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 7 | `ColorChannel` | `nColorChannel` | 整数 | 颜色配置 | 字段名推断 | 低 |
| 8 | `ModelScale` | `fModelScale` | 浮点数 | 待确认 | 待确认 | 待确认 |
| 9 | `IconID` | `nIconID` | 整数 | 图标ID | 字段名推断 | 低 |
| 10 | `X` | `nX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 11 | `Y` | `nY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `Z` | `nZ` | 整数 | 待确认 | 待确认 | 待确认 |
| 13 | `LookAtX` | `nLookAtX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 14 | `LookAtY` | `nLookAtY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 15 | `LookAtZ` | `nLookAtZ` | 整数 | 待确认 | 待确认 | 待确认 |

## WorldMap\WorldMapCity.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `dwMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 3 | `dwTrafficID` | `dwTrafficID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `szComment` | `szComment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `szType` | `szType` | 字符串 | 类型/分类 | 翻译列/字段名 | 中 |
| 6 | `szShowLevel` | `szShowLevel` | 字符串 | 等级/品质 | 字段名推断 | 低 |
| 7 | `szButtonImg` | `szButtonImg` | 字符串 | 待确认 | 待确认 | 待确认 |
| 8 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## WorldMap\WorldMapCopy.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `dwMapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 3 | `szOtherMapID` | `szOtherMapID` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `szComment` | `szComment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `szShowName` | `szShowName` | 字符串 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 6 | `szVersion` | `szVersion` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 7 | `szShowLevel` | `szShowLevel` | 字符串 | 等级/品质 | 字段名推断 | 低 |
| 8 | `szButtonImg` | `szButtonImg` | 字符串 | 待确认 | 待确认 | 待确认 |
| 9 | `dwParentMapID` | `dwParentMapID` | 整数 | 待确认 | 待确认 | 待确认 |
| 10 | `nPosX` | `nPosX` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 11 | `nPosY` | `nPosY` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |
| 12 | `nPoxZ` | `nPosZ` | 整数 | 坐标/尺寸配置 | 字段名推断 | 低 |

## WorldMap\WorldMapZoning.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 2 | `szShowLevel` | `szShowLevel` | 字符串 | 等级/品质 | 字段名推断 | 低 |
| 3 | `szChildCityMaps` | `szChildCityMaps` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `szChildCopyMaps` | `szChildCopyMaps` | 字符串 | 待确认 | 待确认 | 待确认 |
| 5 | `szButtonImg` | `szButtonImg` | 字符串 | 待确认 | 待确认 | 待确认 |
| 6 | `nFrame` | `nFrame` | 整数 | 帧号 | 字段名推断 | 低 |

## WulinShenghuiDuizhenTip.tab

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `nIndex` | `nIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |
| 2 | `dwNpcID` | `dwNpcID` | 整数 | 待确认 | 待确认 | 待确认 |
| 3 | `szName` | `szName` | 字符串 | 名称/标题文本 | 翻译列/字段名 | 中 |
| 4 | `szNickname` | `szNickname` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 5 | `szBasicTip` | `szBasicTip` | 多语言文本 | 文本内容 | 翻译列/字段名 | 中 |
| 6 | `szTipLayer2` | `szTipPhase2` | 多语言文本 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 7 | `szTipLayer3` | `szTipPhase3` | 多语言文本 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 8 | `szTipLayer4` | `szTipPhase4` | 多语言文本 | 开关/条件配置 | 翻译列/字段名 | 中 |
| 9 | `szTipLayer5` | `szTipPhase5` | 多语言文本 | 开关/条件配置 | 翻译列/字段名 | 中 |

## WXPuppetInfo.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `szName` | `szName` | 字符串 | 名称/标题文本 | 字段名推断 | 低 |
| 3 | `MapID` | `dwMapID` | 整数 | 地图ID | 字段名推断 | 低 |
| 4 | `NpcIndex` | `dwNpcIndex` | 整数 | 索引/排序 | 字段名推断 | 低 |

## zhenpai_line.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `ForceID` | `dwForceID` | 整数 | 势力/阵营配置 | 字段名推断 | 低 |
| 2 | `KungfuID` | `dwKungfuID` | 整数 | 心法/内功ID | 字段名推断 | 低 |
| 3 | `DefaultLine` | `dwDefaultLineID` | 整数 | 待确认 | 待确认 | 待确认 |
| 4 | `TotalLine` | `szTotalLine` | 字符串 | 数量/计数 | 字段名推断 | 低 |

## zhenpai_line_info.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `LineID` | `dwLineID` | 整数 | 待确认 | 待确认 | 待确认 |
| 2 | `LineName` | `szLineName` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |
| 3 | `LineInfo` | `szLineInfo` | 字符串 | 待确认 | 待确认 | 待确认 |

## ZombieFianlEvaluate.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `nlevel` | `nLevel` | 整数 | 等级/品质 | 字段名推断 | 低 |
| 3 | `szSFXPath` | `szSFXPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |

## ZombieFightFinal.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `Title` | `szTitle` | 字符串 | 标题文本 | 翻译列/字段名 | 中 |
| 3 | `ValueName` | `szValueName` | 字符串 | 待确认 | 待确认 | 待确认 |
| 4 | `bZombie` | `bZombie` | 布尔 | 待确认 | 待确认 | 待确认 |
| 5 | `ImagePath` | `szImagePath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 6 | `ImageFrame` | `nImageFrame` | 整数 | 图片资源配置 | 字段名推断 | 低 |

## ZombieLevel.txt

- table_defs.lua：是

| 序号 | 列名 | Lua字段 | 类型 | 中文注释 | 来源 | 可信度 |
| ---: | --- | --- | --- | --- | --- | --- |
| 1 | `dwID` | `dwID` | 整数 | ID | 字段名推断 | 低 |
| 2 | `BuffID` | `nBuffID` | 整数 | Buff ID | 字段名推断 | 低 |
| 3 | `BuffLevel` | `nBuffLevel` | 整数 | Buff相关配置 | 字段名推断 | 低 |
| 4 | `FinalPath` | `szFinalPath` | 字符串 | 资源/文件路径 | 字段名推断 | 低 |
| 5 | `FinalFrame` | `nFinalFrame` | 整数 | 帧号/图片帧配置 | 字段名推断 | 低 |
| 6 | `AvatarID` | `dwAvatarID` | 整数 | 待确认 | 待确认 | 待确认 |
| 7 | `szComment` | `szComment` | 字符串 | 文本内容 | 翻译列/字段名 | 中 |

