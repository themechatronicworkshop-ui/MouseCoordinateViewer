# Mouse Coordinate Viewer

A lightweight, portable Windows application that displays your mouse pointer's **X and Y coordinates in real time**.

## Application screenshot

![Mouse Coordinate Viewer screenshot](images/ekran-goruntusu.png)

**Language:** This is the English documentation. [Türkçe ana sayfaya dön / Back to Turkish](README.md).

## Features

- Displays live mouse X/Y coordinates.
- Keeps its window always on top.
- Detects primary monitor resolution automatically.
- Moves the pointer to the primary monitor's center using the **Center on primary screen** button.
- Uses physical pixel coordinates under Windows display scaling.
- Does not require an installer or administrator privileges.

## Download and run

The prebuilt `MouseCoordinateViewer.exe` has **not yet been published in this repository**. Once uploaded, download it and run it on Windows. The cursor moves to the center of the primary screen at startup. Moving the mouse updates the coordinates, and closing the window exits the application.

## Build from source

1. Select **Code → Download ZIP** and extract the repository.
2. On Windows, run `build.cmd`.
3. If compilation succeeds, `MouseCoordinateViewer.exe` will be created.

Requires Windows and the .NET Framework 4.x C# compiler. Visual Studio is not required if the compiler is installed.

## Example coordinates

On a 1920 × 1080 primary display, the center is **X: 960, Y: 540**. On a 1280 × 1024 display, it is **X: 640, Y: 512**. Coordinates may be negative when multiple monitors are connected.

## Project files

| File | Description |
|---|---|
| `MouseCoordinateViewer.cs` | C# application source |
| `MouseCoordinateViewer.manifest` | Windows manifest and DPI configuration |
| `build.cmd` | Windows build script |
| `.gitignore` | Git ignore rules |
| `README.md` | Turkish primary documentation |
| `README_EN.md` | English documentation |

## Verification

The English-interface build was previously reported to compile, and the original build passed a basic cursor-reading and screen-center self-test. The graphical interface has not been visually verified on Windows. This repository does not include an automated test suite.

## Security and behavior

The application moves the pointer on startup and when the center button is pressed. It does not click, modify files, or request administrator privileges.

## License

No license file has been added yet. A license should be selected to clarify permission to use, modify, and redistribute the project.
