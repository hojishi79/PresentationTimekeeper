using System;
using System.Windows.Forms;

namespace PresentationTimekeeper.Forms
{
    public partial class ControlForm : Form
    {
        private bool _mainTimerIsRunning = false;
        private int _targetTime = 60;
        private int _timeLeft;
        private bool _doCountUp = true;

        public ControlForm()
        {
            InitializeComponent();
            ResetTimer();
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

            var h = second / (60 * 60);
            var m = second / 60;
            var s = second % 60;

            var hStr = SubstringFromRight($"0{h}", 2);
            var mStr = SubstringFromRight($"0{m}", 2);
            var sStr = SubstringFromRight($"0{s}", 2);

            timeText.Text = $"{hStr}:{mStr}:{sStr}";
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

        private int ConvertHmsToSec(int hour, int minute, int second)
        {
            return hour * 60 * 60 + minute * 60 + second;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private static string SubstringFromRight(string str, int length)
        {
            return str.Substring(str.Length - length, length);
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            var settingForm = new ParameterSettingForm();
            settingForm.Show(this);
        }
    }
}
