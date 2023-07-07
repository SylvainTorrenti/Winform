namespace _04Calculs_Controles_
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

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

        private void btReset_Click(object sender, EventArgs e)
        {
            tbNb1.Clear();
            tbNb2.Clear();
            tbResult.Clear();
            tbNb1.Focus();
        }

        private void tbNb1_Enter(object sender, EventArgs e)
        {
            tbResult.Clear();
        }

        private void tbNb2_Enter(object sender, EventArgs e)
        {
            tbResult.Clear();
        }

        private void tbNb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',' && tbNb1.Text.Contains(','))
            {
                e.Handled =true;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbNb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if ( e.KeyChar == ',' && tbNb1.Text.Contains(','))
            {
                e.Handled = true;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}