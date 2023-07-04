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
            ShowMyDialogBox();
        }
        public void ShowMyDialogBox()
        {
            frmFille frmFille = new frmFille();
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (frmFille.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                this.tbTitle.Text = frmFille.Text;
            }
            else
            {
                this.tbTitle.Text = "";
            }
            frmFille.Dispose();
        }
    }
}