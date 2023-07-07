namespace TousEnsemble
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btImage_Click(object sender, EventArgs e)
        {

        }

        private void btAge_Click(object sender, EventArgs e)
        {
            using Age age = new Age();
            age.ShowDialog();

        }

        private void btCalcul_Click(object sender, EventArgs e)
        {
            using Calculer calculer = new Calculer();
            calculer.ShowDialog();
        }
    }
}