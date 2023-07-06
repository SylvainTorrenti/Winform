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
            ToolTip tpReset = new ToolTip();
            tpReset.AutoPopDelay = 0;
            tpReset.InitialDelay = 0;
            tpReset.ReshowDelay = 0;
            tpReset.ShowAlways = true;
            tpReset.SetToolTip(this.btReset, "Reset");

            ToolTip tpResult = new ToolTip();
            tpResult.AutoPopDelay = 0;
            tpResult.InitialDelay = 0;
            tpResult.ReshowDelay = 0;
            tpResult.ShowAlways = true;
            tpResult.SetToolTip(this.btResult, "Resultat");

            ToolTip tbNb1 = new ToolTip();
            tbNb1.AutoPopDelay = 0;
            tbNb1.InitialDelay = 0;
            tbNb1.ReshowDelay = 0;
            tbNb1.ShowAlways = true;
            tbNb1.SetToolTip(this.tbNb1, "Le 1er nombre");

            ToolTip tbNb2 = new ToolTip();
            tbNb2.AutoPopDelay = 0;
            tbNb2.InitialDelay = 0;
            tbNb2.ReshowDelay = 0;
            tbNb2.ShowAlways = true;
            tbNb2.SetToolTip(this.tbNb2, "Le 2eme nombre");

            ToolTip tbResult = new ToolTip();
            tbResult.AutoPopDelay = 0;
            tbResult.InitialDelay = 0;
            tbResult.ReshowDelay = 0;
            tbResult.ShowAlways = true;
            tbResult.SetToolTip(this.tbResult, "Le resultat");
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
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}