namespace _01HelloWorld
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {

            DialogResult r8 = MessageBox.Show(this, "Confirmez vous la fermeture de l'application ?",
                                               "Fermeture", MessageBoxButtons.YesNo);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r8 = MessageBox.Show(this, "Confirmez vous la fermeture de l'application ?",
                                               "Fermeture", MessageBoxButtons.YesNo);
        }
    }
}