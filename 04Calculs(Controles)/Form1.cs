namespace _04Calculs_Controles_
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Btn Result
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
                MessageBox.Show("Vous n'avez pas entrez un nombre dans le deuxiéme champ");
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
        private void btReset_Click(object sender, EventArgs e)
        {
            tbNb1.Clear();
            tbNb2.Clear();
            tbResult.Clear();
            tbNb1.Focus();
        }
        #endregion

        #region Tb Nb1 Enter
        private void tbNb1_Enter(object sender, EventArgs e)
        {
            tbResult.Clear();
        }
        #endregion

        #region Tb Nb2 Enter
        private void tbNb2_Enter(object sender, EventArgs e)
        {
            tbResult.Clear();
        }
        #endregion

        #region Tb Nb1 Key Press
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