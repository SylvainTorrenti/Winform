namespace _01HelloWorld
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Button Exit
        /// <summary>
        /// Quand on click sur le bouton exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Exit
        /// <summary>
        /// Quand on ferme la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Confirmez vous la fermeture de l'application ?";
            const string caption = "Fermeture";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question,
                                         MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        } 
        #endregion
    }
}