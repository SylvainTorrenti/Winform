namespace _04Calculs_Controles_
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Btn Result
        /// <summary>
        /// Quand on click sur le bouton result
        /// Verifie que les donn�es entr�es sont bonnes et si elles le sont fait le calcul
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btResult_Click(object sender, EventArgs e)
        {
            int nb1;
            bool success = int.TryParse(tbNb1.Text, out nb1);
            if (success)
            {
                tbNb1.Text = nb1.ToString();
            }
            else
            {
                MessageBox.Show("Vous n'avez pas entrez un nombre dans le premier champ");
                tbNb1.Clear();
                tbNb1.Focus();
            }
            int nb2;
            bool success2 = int.TryParse(tbNb2.Text, out nb2);
            if (success2)
            {
                tbNb2.Text = nb2.ToString();
            }
            else
            {
                MessageBox.Show("Vous n'avez pas entrez un nombre dans le deuxi�me champ");
                tbNb2.Clear();
                tbNb2.Focus();
            }
            if (success && success2)
            {
                int result = nb1 + nb2;
                tbResult.Text = result.ToString();
            }

        }
        #endregion

        #region Btn Reset
        /// <summary>
        /// Reset tout les champs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btReset_Click(object sender, EventArgs e)
        {
            tbNb1.Clear();
            tbNb2.Clear();
            tbResult.Clear();
            tbNb1.Focus();
        }
        #endregion

        #region Tb Nb1 Enter
        /// <summary>
        /// Reset le champ resultat d�s que l'on entre dans la text box 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbNb1_Enter(object sender, EventArgs e)
        {
            tbResult.Clear();
        }
        #endregion

        #region Tb Nb2 Enter
        /// <summary>
        /// Reset le champ resultat d�s que l'on entre dans la text box 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbNb2_Enter(object sender, EventArgs e)
        {
            tbResult.Clear();
        }
        #endregion

        #region Tb Nb1 Key Press
        /// <summary>
        /// Remplace '.' par ',' et emp�che d'en entr�e plusieurs dans la text box 1
        /// Emp�che l'utilisateur de rentrer autre chose que des nombres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbNb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',' && tbNb1.Text.Contains(','))
            {
                e.Handled = true;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Tb Nb2 Key Press
        /// <summary>
        /// Remplace '.' par ',' et emp�che d'en entr�e plusieurs dans la text box 2
        /// Emp�che l'utilisateur de rentrer autre chose que des nombres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbNb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',' && tbNb1.Text.Contains(','))
            {
                e.Handled = true;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        } 
        #endregion
    }
}