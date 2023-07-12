using System.Text.RegularExpressions;

namespace _08Age_texteparDefaut_
{
    public partial class Form1 : Form
    {
        #region Constante
        const string TITRE = "Age";
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        #region Visible
        /// <summary>
        /// Definit la visibilit� du bouton Year grace a une Regex qui verifie si ce qui est entr� correspond � un format de date
        /// </summary>
        private void visible()
        {
            DateTime dtNaiss;

            // On teste que les champs soient renseign�s et que la date de naissance soit valide et ant�rieure � la date du jour
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
        /// Verifie aussi le jour et le mois pour eviter les incoh�rences
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
        /// appel la fonction visible pour verifier si le bouton Year dois �tre gris� au non
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
        /// appel la fonction visible pour verifier si le bouton Year dois �tre gris� au non
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
        /// Ferme la fen�tre
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