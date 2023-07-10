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
        /// <summary>
        /// Calcul l'age de la personne en fonction de sa date de naissance
        /// Verifie aussi le jour et le mois pour eviter les incohérences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Ferme la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        } 
        #endregion
    }
}