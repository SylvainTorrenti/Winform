using System.Text.RegularExpressions;

namespace _07Age_contrôles_
{
    public partial class Form1 : Form
    {
        #region Constante
        private const String MESSAGE = "Bonjour {0}, vous avez {1} ans";
        private const String TITRE = "Age";
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
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
            DateTime dtNaiss;
            DateTime dtJour;
            long nbAns;

            //Calcule de l'age
            dtNaiss = DateTime.Parse(tbBirthday.Text);
            dtJour = DateTime.Today;
            nbAns = dtJour.Year - dtNaiss.Year;

            if ((dtNaiss.Month > dtJour.Month) || (dtNaiss.Month == dtJour.Month && dtNaiss.Day > dtJour.Day))
            {
                nbAns--;
            }

            //Affichage de l'age
            MessageBox.Show(String.Format(MESSAGE, tbName.Text, nbAns), TITRE, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Close();
        }
        #endregion
    }
}