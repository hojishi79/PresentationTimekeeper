using PresentationTimekeeper.Util;
using System.Windows.Forms;

namespace PresentationTimekeeper.Forms
{
    public partial class AddBellForm : Form
    {
        public int RingingTiming;
        public int BellCount;

        public AddBellForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            var ringingTiming = Utility.ConvertHms2Sec((int)hourUpDown.Value, (int)minuteUpDown.Value, (int)secondUpDown.Value);
            RingingTiming = overTimeRadio.Checked ? -1 * ringingTiming : ringingTiming;
            BellCount = (int)bellCountUpDown.Value;
            DialogResult = DialogResult.OK;
            Hide();
        }
    }
}
