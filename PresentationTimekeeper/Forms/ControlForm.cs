using PresentationTimekeeper.Dto;
using PresentationTimekeeper.Util;
using System;
using System.Windows.Forms;

namespace PresentationTimekeeper.Forms
{
    public partial class ControlForm : Form
    {
        public Setting Setting { get; set; }
        private bool _mainTimerIsRunning;
        private int _timeLeft;

        public ControlForm()
        {
            InitializeComponent();
            Setting = new Setting();
            LoadSetting();
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (_mainTimerIsRunning)
            {
                StopTimer();
            }
            else
            {
                StartTimer();
            }
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            _timeLeft--;

            if (_timeLeft < 0 && !Setting.DoCountUp)
            {
                StopTimer();
            }
            else
            {
                UpdateTimeText(_timeLeft);
            }
        }

        private void UpdateTimeText(int second)
        {
            timeTextType.Text = second < 0 ? "超過時間" : "残り時間";

            second = second < 0 ? second * -1 : second;

            var hmsStr = Utility.Second2HmsString(second);

            if(hmsStr.Hour == "00" && Setting.OmitHourDisplay)
            {
                timeText.Text = $"{hmsStr.Minute}:{hmsStr.Second}";
            }
            else
            {
                timeText.Text = $"{hmsStr.Hour}:{hmsStr.Minute}:{hmsStr.Second}";
            }

            ResizeTimeText();
        }

        private void ResizeTimeText()
        {
            var fontName = timeText.Font.Name;
            var fontSize = Math.Round((double)(signPanel.Width / timeText.Text.Length));
            timeText.Font = new System.Drawing.Font(fontName, (float)fontSize);

            var x = Math.Round((double)(signPanel.Width - timeText.Width) / 2);
            var y = Math.Round((double)(signPanel.Height - timeText.Height) / 2);

            timeText.Location = new System.Drawing.Point((int)x, (int)y);
        }

        private void StartTimer()
        {
            mainTimer.Start();
            startStopButton.Text = "ストップ";
            _mainTimerIsRunning = true;
            settingButton.Enabled = false;
        }

        private void StopTimer()
        {
            mainTimer.Stop();
            startStopButton.Text = "スタート";
            _mainTimerIsRunning = false;
            settingButton.Enabled = true;
        }

        private void ResetTimer()
        {
            _timeLeft = Setting.TargetTime;
            UpdateTimeText(_timeLeft);
        }

        public void LoadSetting()
        {
            overtimeBehaviorLabel.Text = Setting.DoCountUp ? "超過時間表示" : "停止";
            var hmsStr = Utility.Second2HmsString(Setting.TargetTime);
            hourLabel.Text = hmsStr.Hour;
            minuteLabel.Text = hmsStr.Minute;
            secondLabel.Text = hmsStr.Second;
            signPanel.BackColor = Setting.BackgroundColor;
            timeTextType.ForeColor = Setting.TextColor;
            timeText.ForeColor = Setting.TextColor;
            ResetTimer();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            var settingForm = new ParameterSettingForm();
            settingForm.Show(this);
        }
    }
}
