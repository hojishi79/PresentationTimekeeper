using PresentationTimekeeper.Util;
using System.Windows.Forms;

namespace PresentationTimekeeper.Forms
{
    public partial class AddBellForm : Form
    {
        public int Timing;
        public int Count;

        public AddBellForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            var timing = Utility.ConvertHms2Sec((int)hourUpDown.Value, (int)minuteUpDown.Value, (int)secondUpDown.Value);
            Timing = overTimeRadio.Checked ? -1 * timing : timing;
            Count = (int)bellCountUpDown.Value;
            DialogResult = DialogResult.OK;
            Hide();
        }
    }
}
