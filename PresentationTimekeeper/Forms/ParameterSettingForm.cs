using PresentationTimekeeper.Dto;
using PresentationTimekeeper.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PresentationTimekeeper.Forms
{
    public partial class ParameterSettingForm : Form
    {
        public Setting Setting;
        private Setting _tmpSetting;
        private readonly Dictionary<int, int> _chkbIdxMap;

        public ParameterSettingForm(Setting setting)
        {
            InitializeComponent();
            Setting = setting;
            _tmpSetting = Utility.DeepCopy(setting);
            _chkbIdxMap = new Dictionary<int, int>();
        }

        private void ParameterSettingForm_Load(object sender, EventArgs e)
        {
            bellChbList.SelectedIndexChanged += BellChbList_SelectedIndexChanged;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            LoadSetting();
        }

        private void LoadSetting()
        {
            var hmsInt = Utility.Second2HmsInt(Setting.TargetTime);
            hourUpDown.Value = hmsInt.Hour;
            minuteUpDown.Value = hmsInt.Minute;
            secondUpDown.Value = hmsInt.Second;
            countupRadio.Checked = Setting.DoCountUp;
            stopRadio.Checked = !Setting.DoCountUp;
            omitHourCheckBox.Checked = Setting.OmitHourDisplay;
            textColorButton.BackColor = Setting.TextColor;
            backGroundColorButton.BackColor = Setting.BackgroundColor;
            WriteBellChbList();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            _tmpSetting.TargetTime = Utility.ConvertHms2Sec((int)hourUpDown.Value, (int)minuteUpDown.Value, (int)secondUpDown.Value);
            _tmpSetting.DoCountUp = countupRadio.Checked;
            _tmpSetting.OmitHourDisplay = omitHourCheckBox.Checked;
            Setting = _tmpSetting;
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
                _tmpSetting.TextColor = cd.Color;
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
                _tmpSetting.BackgroundColor = cd.Color;
            }
        }

        private void AddBellButton_Click(object sender, EventArgs e)
        {
            var form = new AddBellForm();
            if(form.ShowDialog() == DialogResult.OK)
            {
                _tmpSetting.RingingTiming[form.RingingTiming] = form.BellCount;
                WriteBellChbList();                
            }
            form.Dispose();
        }

        private void WriteBellChbList()
        {
            bellChbList.Items.Clear();
            _chkbIdxMap.Clear();
            foreach (var pair in _tmpSetting.RingingTiming.OrderByDescending(x => x.Key))
            {
                var timeTypeStr = pair.Key < 0 ? "超過時間" : "残り時間";
                var hmsStr = Utility.Second2HmsString(Math.Abs(pair.Key));
                var idx = bellChbList.Items.Add($"[{timeTypeStr}] {hmsStr.Hour}:{hmsStr.Minute}:{hmsStr.Second} {pair.Value}回");
                _chkbIdxMap.Add(idx, pair.Key);
            }
        }

        private void BellChbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            delBellButton.Enabled = bellChbList.CheckedItems.Count > 0;
        }

        private void DelBellButton_Click(object sender, EventArgs e)
        {
            for(var idx = 0; idx < bellChbList.Items.Count; idx++)
            {
                if (bellChbList.GetItemChecked(idx))
                {
                    var ringingTiming = _chkbIdxMap[idx];
                    _tmpSetting.RingingTiming.Remove(ringingTiming);
                }
            }
            WriteBellChbList();
        }
    }
}
