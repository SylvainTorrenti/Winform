using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _05Diviseurs
{
    public partial class frmDivisor : Form
    {
        #region Constantes
        const string ERREURNB1 = "Vous n'avez pas entrez un nombre entier dans le premier champ";
        const string ERREURNB2 = "Vous n'avez pas entrez un nombre entier dans le deuxiéme champ";
        const string MESSAGE2 = "Le denominateur ne peut être 0"; 
        #endregion
        public frmDivisor()
        {
            InitializeComponent();

        }

        #region Btn Result
        private void btResult_Click(object sender, EventArgs e)
        {
            divisor();
        }
        #endregion
        #region Diviseur
        private void divisor()
        {
            int nb1;
            bool success = int.TryParse(tbNominator.Text, out nb1);
            if (success)
            {
                tbNominator.Text = nb1.ToString();
            }
            else
            {
                MessageBox.Show(ERREURNB1);
                tbNominator.Focus();
            }
            int nb2;
            bool success2 = int.TryParse(tbDenominator.Text, out nb2);
            if (success2 && (nb2 != 0))
            {
                tbDenominator.Text = nb2.ToString();
            }
            if (nb2 == 0)
            {
                MessageBox.Show(MESSAGE2);
            }
            if (success2 != true)
            {
                MessageBox.Show(ERREURNB2);
                tbDenominator.Focus();
            }
            else
            {
                var c = 1;
                var a = nb1;
                var b = nb2;


                while (c != 0)
                {
                    c = a % b;
                    a = b;
                    b = c;

                }

                nb1 = nb1 / a;
                nb2 = nb2 / a;
                ToolTip toolResultD = new ToolTip();
                toolTip1.ShowAlways = true;
                toolTip1.SetToolTip(lbResultD, a.ToString());
                ToolTip toolResultN = new ToolTip();
                toolTip1.ShowAlways = true;
                toolTip1.SetToolTip(lbResultN, a.ToString());
            }
            lbResultN.Text = nb1.ToString();
            lbResultD.Text = nb2.ToString();
        } 
        #endregion
    }


}
