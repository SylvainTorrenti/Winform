using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Age_DateTimePicker_
{
    public partial class frmMain : Form
    {
        const string TITRE = "Age";
        public frmMain()
        {
            InitializeComponent();
        }

        private void btYear_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var today = DateTime.Today;
            int year = DateTime.Now.Year - dtpYear.Value.Year;
            if (dtpYear.Value.Day > today.Day && dtpYear.Value.Month == today.Month)
            {
                year = year - 1;
            }
            if (dtpYear.Value.Month > today.Month)
            {
                year = year - 1;

            }
            MessageBox.Show("bonjour " + name + ", vous avez " + year + " ans", TITRE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}