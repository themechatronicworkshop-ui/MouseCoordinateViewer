using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal static class Program
{
    [DllImport("user32.dll")] internal static extern bool SetProcessDPIAware();
    [DllImport("user32.dll")] internal static extern bool SetCursorPos(int x, int y);
    [DllImport("user32.dll")] internal static extern bool GetCursorPos(out Point point);

    [STAThread]
    private static void Main(string[] args)
    {
        SetProcessDPIAware(); // Coordinates stay in physical pixels at any Windows scaling.
        if (args.Length > 0 && args[0] == "--self-test")
        {
            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            Point center = Center(bounds);
            if (Center(new Rectangle(0, 0, 1280, 1024)) != new Point(640, 512))
                Environment.Exit(1);
            Point cursor;
            if (!GetCursorPos(out cursor)) Environment.Exit(2);
            System.IO.File.WriteAllText(args.Length > 1 ? args[1] : "self-test.txt",
                "PASS\r\nPrimary screen: " + bounds + "\r\nCenter: " + center +
                "\r\nCurrent cursor: " + cursor);
            return;
        }
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new CoordinateWindow());
    }

    internal static Point Center(Rectangle bounds)
    {
        return new Point(bounds.Left + bounds.Width / 2, bounds.Top + bounds.Height / 2);
    }
}

internal sealed class CoordinateWindow : Form
{
    private readonly Label coordinates = new Label();
    private readonly Label screenInfo = new Label();
    private readonly Timer timer = new Timer();

    internal CoordinateWindow()
    {
        Text = "Mouse Coordinate Viewer";
        TopMost = true;
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        MaximizeBox = false;
        MinimizeBox = false;
        AutoScaleMode = AutoScaleMode.None;
        ClientSize = new Size(300, 143);
        BackColor = Color.FromArgb(245, 247, 250);
        StartPosition = FormStartPosition.Manual;
        Rectangle area = Screen.PrimaryScreen.WorkingArea;
        Location = new Point(area.Right - Width - 16, area.Top + 16);

        coordinates.SetBounds(12, 12, 276, 36);
        coordinates.Font = new Font("Consolas", 20, FontStyle.Bold);
        coordinates.TextAlign = ContentAlignment.MiddleCenter;
        Controls.Add(coordinates);

        screenInfo.SetBounds(12, 56, 276, 40);
        screenInfo.Font = new Font("Segoe UI", 9);
        screenInfo.TextAlign = ContentAlignment.MiddleCenter;
        Controls.Add(screenInfo);

        Button center = new Button();
        center.Text = "Center on primary screen";
        center.SetBounds(45, 104, 210, 27);
        center.Click += delegate { MoveToCenter(); };
        Controls.Add(center);

        timer.Interval = 30;
        timer.Tick += delegate { UpdateCoordinates(); };
        Shown += delegate { MoveToCenter(); UpdateCoordinates(); timer.Start(); };
        FormClosed += delegate { timer.Dispose(); };
    }

    private void MoveToCenter()
    {
        Point center = Program.Center(Screen.PrimaryScreen.Bounds);
        if (!Program.SetCursorPos(center.X, center.Y))
            coordinates.Text = "Could not move cursor";
    }

    private void UpdateCoordinates()
    {
        Point point;
        if (!Program.GetCursorPos(out point)) return;
        Rectangle primary = Screen.PrimaryScreen.Bounds;
        coordinates.Text = "X: " + point.X + "  Y: " + point.Y;
        screenInfo.Text = "Primary screen: " + primary.Width + " × " + primary.Height +
            "\r\n" + (primary.Contains(point) ? "Cursor on primary screen" : "Cursor on another screen");
    }
}
