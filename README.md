# Mouse Coordinate Viewer

A small, portable Windows utility that displays live mouse coordinates in an always-on-top window.

## Use

Run **MouseCoordinateViewer.exe**. On startup, the pointer moves to the center of your primary screen. Move your mouse normally to see its current X and Y coordinates. Click **Center on primary screen** to center it again, or close the window to exit.

- Detects your primary screen resolution automatically.
- Uses physical pixel coordinates, including when Windows display scaling is enabled.
- On a 1920 × 1080 primary screen, the center is (960, 540).
- On a 1280 × 1024 primary screen, the center is (640, 512).
- Coordinates on other screens can be negative.
- No installer or administrator access required.

Requires Windows with .NET Framework 4.x, normally included with Windows 10 and 11. Only the EXE is needed to run the utility.

## Build from source

Run `build.cmd` on Windows. It uses the .NET Framework C# compiler and the included manifest to produce `MouseCoordinateViewer.exe`.

Source: `MouseCoordinateViewer.cs`.

## Verification

The English version compiles successfully. The original version passed its primary-screen and cursor-reading self-test. The English interface has not been visually checked.

The utility moves the pointer once at startup and when the center button is clicked. It does not click, drag, or modify files.
