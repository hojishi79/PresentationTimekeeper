using PresentationTimekeeper.Dto;
using PresentationTimekeeper.Util;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PresentationTimekeeper.Forms
{
    public partial class ParameterSettingForm : Form
    {
        private Setting _setting;

        public ParameterSettingForm(Setting setting)
        {
            InitializeComponent();
            _setting = setting;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            LoadSetting();
        }

        private void LoadSetting()
        {
            var hmsInt = Utility.Second2HmsInt(_setting.TargetTime);
            hourUpDown.Value = hmsInt.Hour;
            minuteUpDown.Value = hmsInt.Minute;
            secondUpDown.Value = hmsInt.Second;
            countupRadio.Checked = _setting.DoCountUp;
            stopRadio.Checked = !_setting.DoCountUp;
            omitHourCheckBox.Checked = _setting.OmitHourDisplay;
            textColorButton.BackColor = _setting.TextColor;
            backGroundColorButton.BackColor = _setting.BackgroundColor;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            _setting.TargetTime = Utility.ConvertHms2Sec((int)hourUpDown.Value, (int)minuteUpDown.Value, (int)secondUpDown.Value);
            _setting.DoCountUp = countupRadio.Checked;
            _setting.OmitHourDisplay = omitHourCheckBox.Checked;
            _setting.TextColor = textColorButton.BackColor;
            _setting.BackgroundColor = backGroundColorButton.BackColor;
            DialogResult = DialogResult.OK;
            Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void TextColorButton_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog
            {
                Color = textColorButton.BackColor
            };

            if(cd.ShowDialog() == DialogResult.OK)
            {
                textColorButton.BackColor = cd.Color;
                _setting.TextColor = cd.Color;
            }
        }

        private void BackGroundColorButton_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog
            {
                Color = backGroundColorButton.BackColor
            };

            if (cd.ShowDialog() == DialogResult.OK)
            {
                backGroundColorButton.BackColor = cd.Color;
                _setting.BackgroundColor = cd.Color;
            }
        }

        private void AddBellButton_Click(object sender, EventArgs e)
        {
            var form = new AddBellForm();
            if(form.ShowDialog() == DialogResult.OK)
            {
               _setting.RingingTiming[form.RingingTiming] = form.BellCount;

                bellChbList.Items.Clear();
                foreach(var pair in _setting.RingingTiming.OrderByDescending(x => x.Key))
                {
                    var timeTypeStr = pair.Key < 0 ? "超過時間" : "残り時間";
                    var hmsStr = Utility.Second2HmsString(Math.Abs(pair.Key));
                    bellChbList.Items.Add($"[{timeTypeStr}] {hmsStr.Hour}:{hmsStr.Minute}:{hmsStr.Second} {pair.Value}回");
                }
            }
            form.Dispose();
        }
    }
}
