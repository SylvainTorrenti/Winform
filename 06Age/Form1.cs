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
            var today = DateTime.Today;
            var birthday = Convert.ToDateTime(tbBirthday.Text);
            var year = today.Year - birthday.Year;
            MessageBox.Show(year.ToString(), TITRE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}