using System;
using System.Windows.Forms;
using PresentationTimekeeper.Dto;
using PresentationTimekeeper.Util;

namespace PresentationTimekeeper.Forms
{
    public partial class TimeSignForm : Form
    {
        public TimeSignForm()
        {
            InitializeComponent();
        }

        private void TimeSignForm_Load(object sender, EventArgs e)
        {
            Resize += Form_Resize;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ResizeTimeText();
            ResizeTimetypeText();
        }

        public void UpdateTimeText(int second, bool omitHourDisplay)
        {
            timeTextType.Text = second < 0 ? "超過時間" : "残り時間";

            second = Math.Abs(second);

            var hmsStr = Utility.Second2HmsString(second);

            if (hmsStr.Hour == "00" && omitHourDisplay)
            {
                timeText.Text = $"{hmsStr.Minute}:{hmsStr.Second}";
            }
            else
            {
                timeText.Text = $"{hmsStr.Hour}:{hmsStr.Minute}:{hmsStr.Second}";
            }

            ResizeTimeText();
        }

        public void ResizeTimeText()
        {
            var fontName = timeText.Font.Name;
            var fontSize = Math.Round((double)(Width / timeText.Text.Length));
            timeText.Font = new System.Drawing.Font(fontName, (float)fontSize);

            var x = Math.Round((double)(Width - timeText.Width) / 2);
            var y = Math.Round((double)(Height - timeText.Height) / 2);

            timeText.Location = new System.Drawing.Point((int)x, (int)y);
        }

        private void ResizeTimetypeText()
        {
            var fontName = timeTextType.Font.Name;
            var fontSize = Math.Round((double)(Width / 16));
            timeTextType.Font = new System.Drawing.Font(fontName, (float)fontSize);
        }

        public void ChangeColor(TextBgColor color)
        {
            if (color == null)
            {
                return;
            }
            BackColor = color.BackGround;
            timeTextType.ForeColor = color.Text;
            timeText.ForeColor = color.Text;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            ResizeTimeText();
            ResizeTimetypeText();
        }
    }
}
