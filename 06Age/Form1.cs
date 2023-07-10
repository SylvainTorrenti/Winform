namespace _06Age
{
    public partial class frmMain : Form
    {

        const string TITRE = "Age";

        public frmMain()
        {
            InitializeComponent();
        }

        private void btCalcul_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var today = DateTime.Today;
            var birthday = Convert.ToDateTime(tbBirthday.Text);
            var year = today.Year - birthday.Year;
            if (birthday.Day > today.Day && birthday.Month == today.Month)
            {
                year = year - 1;
            }
            if (birthday.Month > today.Month)
            {
                year = year - 1;

            }
            MessageBox.Show("bonjour " + name + ", vous avez " + year + " ans", TITRE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}