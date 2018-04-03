using PresentationTimekeeper.Dto;
using PresentationTimekeeper.Util;
using System;
using System.Windows.Forms;

namespace PresentationTimekeeper.Forms
{
    public partial class AddChangeColorForm : Form
    {
        public int Timing;
        public TextBgColor TextBgColor;

        public AddChangeColorForm()
        {
            InitializeComponent();
            TextBgColor = new TextBgColor();
        }

        private void AddChangeColorForm_Load(object sender, EventArgs e)
        {
            textColorButton.BackColor = TextBgColor.Text;
            backGroundColorButton.BackColor = TextBgColor.BackGround;
        }

        private void TextColorButton_Click(object sender, EventArgs e)
        {
            var color = Utility.ChangeColor(textColorButton.BackColor);
            textColorButton.BackColor = color;
            TextBgColor.Text = color;
        }

        private void BackGroundColorButton_Click(object sender, EventArgs e)
        {
            var color = Utility.ChangeColor(backGroundColorButton.BackColor);
            backGroundColorButton.BackColor = color;
            TextBgColor.BackGround = color;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var timing = Utility.ConvertHms2Sec((int)hourUpDown.Value, (int)minuteUpDown.Value, (int)secondUpDown.Value);
            Timing = overTimeRadio.Checked ? -1 * timing : timing;
            DialogResult = DialogResult.OK;
            Hide();
        }
    }
}
