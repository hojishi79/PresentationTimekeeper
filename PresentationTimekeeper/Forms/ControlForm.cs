using PresentationTimekeeper.Dto;
using PresentationTimekeeper.Util;
using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace PresentationTimekeeper.Forms
{
    public partial class ControlForm : Form
    {
        private Setting _setting;
        private bool _mainTimerIsRunning;
        private int _timeLeft;

        public ControlForm()
        {
            InitializeComponent();
            _setting = new Setting();
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

            if (_timeLeft < 0 && !_setting.DoCountUp)
            {
                StopTimer();
            }
            else
            {
                UpdateTimeText(_timeLeft);
            }
            RingBell();
        }

        private void UpdateTimeText(int second)
        {
            timeTextType.Text = second < 0 ? "超過時間" : "残り時間";

            second = second < 0 ? second * -1 : second;

            var hmsStr = Utility.Second2HmsString(second);

            if(hmsStr.Hour == "00" && _setting.OmitHourDisplay)
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
            _timeLeft = _setting.TargetTime;
            UpdateTimeText(_timeLeft);
        }

        public void LoadSetting()
        {
            overtimeBehaviorLabel.Text = _setting.DoCountUp ? "超過時間表示" : "停止";
            var hmsStr = Utility.Second2HmsString(_setting.TargetTime);
            hourLabel.Text = hmsStr.Hour;
            minuteLabel.Text = hmsStr.Minute;
            secondLabel.Text = hmsStr.Second;
            signPanel.BackColor = _setting.BackgroundColor;
            timeTextType.ForeColor = _setting.TextColor;
            timeText.ForeColor = _setting.TextColor;
            ResetTimer();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            var settingForm = new ParameterSettingForm(_setting);
            if(settingForm.ShowDialog(this) == DialogResult.OK)
            {
                LoadSetting();
            }
            settingForm.Dispose();
        }

        private void RingBell()
        {
            var isRingtime = _setting.RingingTiming.TryGetValue(_timeLeft, out int count);
            if (!isRingtime)
            {
                return;
            }

            UnmanagedMemoryStream stream;
            switch (count)
            {
                case 3:
                    stream = Properties.Resources.ringing_bell_3;
                    break;
                case 2:
                    stream = Properties.Resources.ringing_bell_2;
                    break;
                case 1:
                default:
                    stream = Properties.Resources.ringing_bell_1;
                    break;
            }

            using (var player = new SoundPlayer(stream))
            {
                player.Play();
            }
        }
    }
}
