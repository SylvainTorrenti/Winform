namespace _02FenetreModale
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btFrmFille_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("", tbTitle.Text,MessageBoxButtons.OKCancel);
            
            if (result == DialogResult.Cancel)
            {
                tbTitle.Clear();
            }

        }

        }
    }
