using System.Text.RegularExpressions;

namespace _09Age_settings_
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
        #region Form load
        /// <summary>
        /// Charge les Setting enregistrer lors de la precedente fermeture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbBirthday.Text = Properties.Settings.Default.DtNaiss;
            this.tbName.Text = Properties.Settings.Default.Nom;
        }
        #endregion

        #region Visible
        /// <summary>
        /// Definit la visibilité du bouton Year grace a une Regex qui verifie si ce qui est entré correspond à un format de date
        /// </summary>
        private void visible()
        {
            DateTime dtNaiss;

            // On teste que les champs soient renseignés et que la date de naissance soit valide et antérieure à la date du jour
            if (String.IsNullOrWhiteSpace(tbName.Text) ||
                String.IsNullOrWhiteSpace(tbBirthday.Text) ||
                !DateTime.TryParse(tbBirthday.Text, out dtNaiss) ||
                dtNaiss >= DateTime.Today)
            {
                btYear.Enabled = false;
            }
            else
            {
                btYear.Enabled = true;
            }
        }
        #endregion

        #region Btn Year
        /// <summary>
        /// Calcul l'age de la personne en fonction de sa date de naissance
        /// Verifie aussi le jour et le mois pour eviter les incohérences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btYear_Click(object sender, EventArgs e)
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

        #region Tb Name
        /// <summary>
        /// appel la fonction visible pour verifier si le bouton Year dois être grisé au non
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbName_TextChanged(object sender, EventArgs e)
        {
            visible();
        }
        #endregion

        #region Tb Birthday
        /// <summary>
        /// appel la fonction visible pour verifier si le bouton Year dois être grisé au non
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbBirthday_TextChanged(object sender, EventArgs e)
        {
            visible();
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

            this.Close();
        }
        #endregion

        #region Form Close
        /// <summary>
        /// Enregistre les Settings entré
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Nom = tbName.Text;
            Properties.Settings.Default.DtNaiss = tbBirthday.Text;
            Properties.Settings.Default.Save();
        } 
        #endregion
    }
}