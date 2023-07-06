using System.Text.RegularExpressions;
using System.Windows.Forms;

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
            int years = DateTime.Now.Year - dtpYear.Value.Year;
            MessageBox.Show("bonjour " + name + ", vous avez " + years + " ans", TITRE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}