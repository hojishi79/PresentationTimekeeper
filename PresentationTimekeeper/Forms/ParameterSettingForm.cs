using System;
using PresentationTimekeeper.Dto;
using PresentationTimekeeper.Util;

namespace PresentationTimekeeper.Forms
{
    public partial class ParameterSettingForm : System.Windows.Forms.Form
    {
        private Setting _setting;

        public ParameterSettingForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            _setting = ((ControlForm)Owner).Setting;
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
        }

        private void SubmitButton_Click(object sender, System.EventArgs e)
        {
            _setting.TargetTime = Utility.ConvertHms2Sec((int)hourUpDown.Value, (int)minuteUpDown.Value, (int)secondUpDown.Value);
            _setting.DoCountUp = countupRadio.Checked;
            ((ControlForm)Owner).LoadSetting();
            Dispose();
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }
    }
}
