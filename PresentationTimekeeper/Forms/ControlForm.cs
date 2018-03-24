using PresentationTimekeeper.Dto;
using PresentationTimekeeper.Util;
using System;
using System.Windows.Forms;

namespace PresentationTimekeeper.Forms
{
    public partial class ControlForm : Form
    {
        public Setting Setting { get; set; }
        private int _targetTime;
        private bool _mainTimerIsRunning;
        private int _timeLeft;
        private bool _doCountUp;

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

            if (_timeLeft < 0 && !_doCountUp)
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

            timeText.Text = $"{hmsStr.Hour}:{hmsStr.Minute}:{hmsStr.Second}";
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
            _timeLeft = _targetTime;
            UpdateTimeText(_timeLeft);
        }

        public void LoadSetting()
        {
            _targetTime = Setting.TargetTime;
            _doCountUp = Setting.DoCountUp;
            overtimeBehaviorLabel.Text = _doCountUp ? "超過時間表示" : "停止";
            var hmsStr = Utility.Second2HmsString(_targetTime);
            hourLabel.Text = hmsStr.Hour;
            minuteLabel.Text = hmsStr.Minute;
            secondLabel.Text = hmsStr.Second;
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
