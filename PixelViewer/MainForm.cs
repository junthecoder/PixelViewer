using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace PixelViewer
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc,
            int ySrc, int dwRop);

        private Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);

        public MainForm()
        {
            InitializeComponent();
            LoadSettings();
        }

        public class Settings
        {
            public bool ShowToolBar { get; set; } = true;
            public bool ShowRgb16 { get; set; } = true;
            public bool ShowRgb10 { get; set; } = true;
            public bool ShowRgb0To1 { get; set; } = true;
            public bool ShowHsv { get; set; } = true;
            public bool ShowCmyk { get; set; } = true;
        }

        private void LoadSettings()
        {
            Settings settings;

            try
            {
                var serializer = new XmlSerializer(typeof(Settings));
                using (var stream = new FileStream(GetSettingsFilePath(), FileMode.Open))
                using (var reader = new XmlTextReader(stream))
                {
                    settings = (Settings)serializer.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                settings = new Settings();
            }

            ToolStrip.Visible = settings.ShowToolBar;
            RGB16Button.Checked = settings.ShowRgb16;
            RGB10Button.Checked = settings.ShowRgb10;
            RGB0to1Button.Checked = settings.ShowRgb0To1;
            HsvButton.Checked = settings.ShowHsv;
            CmykButton.Checked = settings.ShowCmyk;
        }

        private void UpdateLabelVisibilities(object sender, EventArgs e)
        {
            RGBHexLabel.Visible = RGB16Button.Checked;
            RGBDecimalLabel.Visible = RGB10Button.Checked;
            RGB0to1Label.Visible = RGB0to1Button.Checked;
            HSVLabel.Visible = HsvButton.Checked;
            CMYKLabel.Visible = CmykButton.Checked;
        }

        private string GetSettingsFilePath()
        {
            var path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            path = Path.GetDirectoryName(path);
            path = Path.Combine(path, "settings.xml");
            return path;
        }

        private void SaveSettings()
        {
            var settings = new Settings
            {
                ShowToolBar = ToolStrip.Visible,
                ShowRgb16 = RGB16Button.Checked,
                ShowRgb10 = RGB10Button.Checked,
                ShowRgb0To1 = RGB0to1Button.Checked,
                ShowHsv = HsvButton.Checked,
                ShowCmyk = CmykButton.Checked
            };

            var serializer = new XmlSerializer(typeof(Settings));

            using (var stream = new FileStream(GetSettingsFilePath(), FileMode.Create))
            using (var writer = new XmlTextWriter(stream, Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                serializer.Serialize(writer, settings);
            }
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            var cursor = new Point();
            GetCursorPos(ref cursor);

            var color = GetColorAt(cursor);
            ColorLabel.BackColor = color;

            RGBHexLabel.Text = $"RGB(16): {color.R:X2}, {color.G:X2}, {color.B:X2}";
            RGBDecimalLabel.Text = $"RGB(10): {color.R}, {color.G}, {color.B}";
            RGB0to1Label.Text = $"RGB[0,1]: {color.R / 255.0:F2}, {color.G / 255.0:F2}, {color.B / 255.0:F2}";
            var hue = color.GetHue();
            //if (hue >= 360)
            //    hue %= 360;
            HSVLabel.Text = $"HSV: H:{hue:F0}°, S:{color.GetSaturation():F2}, V:{color.GetBrightness():F2}";
            if (color.R == 0 && color.G == 0 && color.B == 0)
            {
                var black = 1;
                var cyan = 0;
                var magenta = 0;
                var yellow = 0;
                CMYKLabel.Text = $"CMYK: C:{cyan:F2}, M:{magenta:F2}, Y:{yellow:F2}, K:{black:F2}";
            }
            else
            {
                var red = color.R / 255.0;
                var green = color.G / 255.0;
                var blue = color.B / 255.0;
                var black = Math.Min(1 - red, Math.Min(1 - green, 1 - blue));
                var cyan = (1 - red - black) / (1 - black);
                var magenta = (1 - green - black) / (1 - black);
                var yellow = (1 - blue - black) / (1 - black);
                CMYKLabel.Text = $"CMYK: C:{cyan:F2}, M:{magenta:F2}, Y:{yellow:F2}, K:{black:F2}";
            }
        }

        public Color GetColorAt(Point point)
        {
            using (var gDest = Graphics.FromImage(screenPixel))
            using (var gSrc = Graphics.FromHwnd(IntPtr.Zero))
            {
                var hSrcDC = gSrc.GetHdc();
                var hDC = gDest.GetHdc();
                BitBlt(hDC, 0, 0, 1, 1, hSrcDC, point.X, point.Y, (int)CopyPixelOperation.SourceCopy);
                gDest.ReleaseHdc();
                gSrc.ReleaseHdc();
            }

            return screenPixel.GetPixel(0, 0);
        }

        private void RGB16Button_Click(object sender, EventArgs e)
        {
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void ToolStrip_VisibleChanged(object sender, EventArgs e)
        {
            Panel.Location = new Point(0, ToolStrip.Visible ? ToolStrip.Height : 0);
        }
    }
}