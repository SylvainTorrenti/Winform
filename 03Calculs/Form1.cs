namespace _03Calculs
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            #region Tool tip
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
            tpResult.SetToolTip(this.btEgal, "Resultat");

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
            #endregion


        }

        #region btn Egal
        /// <summary>
        /// Quand on click qur le bouton egal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEgal_Click(object sender, EventArgs e)
        {
            int nb1 = int.Parse(tbNb1.Text);
            int nb2 = int.Parse(tbNb2.Text);
            int result = nb1 + nb2;

            tbResult.Text = result.ToString();
        }
        #endregion

        #region btn Reset
        /// <summary>
        /// Quand on click sur le bouton reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btReset_Click(object sender, EventArgs e)
        {

            tbNb1.Clear();
            tbNb2.Clear();
            tbResult.Clear();
            tbNb1.Focus();
        } 
        #endregion



    }
}