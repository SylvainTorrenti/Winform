using System.Text.RegularExpressions;

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
            var birthday = Convert.ToDateTime
            var year = today - dtpYear;
            MessageBox.Show("bonjour " + name + ", vous avez " + year + " ans", TITRE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}