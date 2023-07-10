namespace _02FenetreModale
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Frm Fille
        /// <summary>
        /// Quand on appuie sur le bouton pour faire apparaitre la fenêtre fille
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btFrmFille_Click(object sender, EventArgs e)
        {
            using frmFille frmFille = new frmFille(); // remplace le dispose()
            frmFille.Text = this.tbTitle.Text;
            DialogResult res = frmFille.ShowDialog();

            if (res == DialogResult.OK)
            {
                tbTitle.Text = frmFille.tbFrmFille.Text;
            }
            else
            {
                this.tbTitle.Text = string.Empty;
            }

        } 
        #endregion
    }
}
