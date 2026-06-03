@echo off
chcp 65001 >nul
setlocal
set SCRIPT_DIR=%~dp0
echo.
echo ============ 填tab表工具 ============
echo.
dotnet publish "%SCRIPT_DIR%src\TabFileEditor.App\TabFileEditor.App.csproj" -c Release -r win-x64 --self-contained false -p:PublishSingleFile=true -p:EnableCompressionInSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true
if %errorlevel% neq 0 (
    echo.
    echo [ERROR] 构建失败！
    pause
    exit /b 1
)
del /q "%SCRIPT_DIR%src\TabFileEditor.App\bin\Release\net10.0-windows\win-x64\publish\*.pdb" 2>nul
for %%f in ("%SCRIPT_DIR%src\TabFileEditor.App\bin\Release\net10.0-windows\win-x64\publish\*.exe") do copy /y "%%f" "%SCRIPT_DIR%填tab表工具.exe" >nul
if %errorlevel% equ 0 (
    echo.
    echo [OK] 完成！已复制到项目目录！
    echo 文件: %SCRIPT_DIR%填tab表工具.exe
) else (
    echo.
    echo [WARN] 完成，但复制失败。请手动从 publish 目录复制。
)
echo.
