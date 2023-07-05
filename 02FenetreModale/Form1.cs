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
            //var result = MessageBox.Show("", tbTitle.Text,MessageBoxButtons.OKCancel);

            //if (result == DialogResult.Cancel)
            //{
            //    tbTitle.Clear();
            //}


            frmFille frmFille = new frmFille();
            frmFille.Text = this.tbTitle.Text;

            if (frmFille.ShowDialog(this) == DialogResult.Cancel)
            {
                this.tbTitle.Text = "";
            }
            else
            {
                this.tbTitle.Text = tb
            }
            frmFille.Dispose();
        }

    }
}
