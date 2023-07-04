namespace _05Diviseurs
{
    public partial class frmDivisor : Form
    {
        public frmDivisor()
        {
            InitializeComponent();
        }

        private void btResult_Click(object sender, EventArgs e)
        {
            int nb1;
            bool success = int.TryParse(tbNominator.Text, out nb1);
            if (success)
            {
                tbNominator.Text = nb1.ToString();
            }
            else
            {
                MessageBox.Show("Vous n'avez pas entrez un nombre dans le premier champ");
                tbNominator.Clear();
                tbNominator.Focus();
            }
            int nb2;
            bool success2 = int.TryParse(tbDenominator.Text, out nb2);
            if (success2)
            {
                tbDenominator.Text = nb2.ToString();
            }
            else
            {
                MessageBox.Show("Vous n'avez pas entrez un nombre dans le deuxiéme champ");
                tbDenominator.Clear();
                tbDenominator.Focus();
            }
            if (success && success2)
            {
                lbResultN.Text = nb1.ToString();
                lbResultD.Text = nb2.ToString();
            }
        }
    }
}