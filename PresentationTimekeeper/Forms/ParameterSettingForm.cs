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
        private readonly Setting _tmpSetting;
        private readonly Dictionary<int, int> _bellChkbIdxMap;
        private readonly Dictionary<int, int> _chColChkIdxMap;

        public ParameterSettingForm(Setting setting)
        {
            InitializeComponent();
            Setting = setting;
            _tmpSetting = Utility.DeepCopy(setting);
            _bellChkbIdxMap = new Dictionary<int, int>();
            _chColChkIdxMap = new Dictionary<int, int>();
        }

        private void ParameterSettingForm_Load(object sender, EventArgs e)
        {
            bellChbList.SelectedIndexChanged += BellChbList_SelectedIndexChanged;
            colorChangeChbList.SelectedIndexChanged += ColorChangeChbList_SelectedIndexChanged;
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
            textColorButton.BackColor = Setting.DefaultColor.Text;
            backGroundColorButton.BackColor = Setting.DefaultColor.BackGround;
            WriteBellChbList();
            WriteChangeColorChbList();
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
            var color = Utility.ChangeColor(textColorButton.BackColor);
            textColorButton.BackColor = color;
            _tmpSetting.DefaultColor.Text = color;
        }

        private void BackGroundColorButton_Click(object sender, EventArgs e)
        {
            var color = Utility.ChangeColor(backGroundColorButton.BackColor);
            backGroundColorButton.BackColor = color;
            _tmpSetting.DefaultColor.BackGround = color;
        }

        private void AddBellButton_Click(object sender, EventArgs e)
        {
            var form = new AddBellForm();
            if(form.ShowDialog() == DialogResult.OK)
            {
                _tmpSetting.RingTiming[form.Timing] = form.Count;
                WriteBellChbList();                
            }
            form.Dispose();
        }

        private void WriteBellChbList()
        {
            bellChbList.Items.Clear();
            _bellChkbIdxMap.Clear();
            foreach (var pair in _tmpSetting.RingTiming.OrderByDescending(x => x.Key))
            {
                var timeTypeStr = pair.Key < 0 ? "超過時間" : "残り時間";
                var hmsStr = Utility.Second2HmsString(Math.Abs(pair.Key));
                var idx = bellChbList.Items.Add($"[{timeTypeStr}] {hmsStr.Hour}:{hmsStr.Minute}:{hmsStr.Second} {pair.Value}回");
                _bellChkbIdxMap.Add(idx, pair.Key);
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
                    var ringingTiming = _bellChkbIdxMap[idx];
                    _tmpSetting.RingTiming.Remove(ringingTiming);
                }
            }
            WriteBellChbList();
        }

        private void AddColorChangeButton_Click(object sender, EventArgs e)
        {
            var form = new AddChangeColorForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _tmpSetting.ChangeColorTiming[form.Timing] = form.TextBgColor;
                WriteChangeColorChbList();
            }
            form.Dispose();
        }

        private void WriteChangeColorChbList()
        {
            colorChangeChbList.Items.Clear();
            _chColChkIdxMap.Clear();
            foreach (var pair in _tmpSetting.ChangeColorTiming.OrderByDescending(x => x.Key))
            {
                var timeTypeStr = pair.Key < 0 ? "超過時間" : "残り時間";
                var hmsStr = Utility.Second2HmsString(Math.Abs(pair.Key));
                var idx = colorChangeChbList.Items.Add($"[{timeTypeStr}] {hmsStr.Hour}:{hmsStr.Minute}:{hmsStr.Second} 文字色={pair.Value.Text.Name} 背景色={pair.Value.BackGround.Name}");
                _chColChkIdxMap.Add(idx, pair.Key);
            }
        }

        private void ColorChangeChbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            delColorChangeButton.Enabled = colorChangeChbList.CheckedItems.Count > 0;
        }

        private void DelColorChangeButton_Click(object sender, EventArgs e)
        {
            for (var idx = 0; idx < colorChangeChbList.Items.Count; idx++)
            {
                if (colorChangeChbList.GetItemChecked(idx))
                {
                    var timing = _chColChkIdxMap[idx];
                    _tmpSetting.ChangeColorTiming.Remove(timing);
                }
            }
            WriteChangeColorChbList();
        }
    }
}
