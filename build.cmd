@echo off
setlocal
cd /d "%~dp0"
set "COMPILER=%WINDIR%\Microsoft.NET\Framework\v4.0.30319\csc.exe"
if not exist "%COMPILER%" (
  echo .NET Framework C# compiler was not found.
  exit /b 1
)
"%COMPILER%" /nologo /target:winexe /platform:anycpu /optimize+ /win32manifest:MouseCoordinateViewer.manifest /reference:System.Windows.Forms.dll /reference:System.Drawing.dll /out:MouseCoordinateViewer.exe MouseCoordinateViewer.cs
exit /b %errorlevel%
