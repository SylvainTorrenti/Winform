namespace _06Age
{
    public partial class frmMain : Form
    {

        #region Constante
        const string TITRE = "Age"; 
        #endregion

        public frmMain()
        {
            InitializeComponent();
        }

        #region Btn Calcul
        private void btCalcul_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var today = DateTime.Today;
            var birthday = Convert.ToDateTime(tbBirthday.Text);
            var year = today.Year - birthday.Year;
            if ((birthday.Day > today.Day && birthday.Month == today.Month) || birthday.Month > today.Month)
            {
                year--;
            }
            MessageBox.Show("bonjour " + name + ", vous avez " + year + " ans", TITRE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Btn Close
        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        } 
        #endregion
    }
}