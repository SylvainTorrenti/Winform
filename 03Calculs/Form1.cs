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

        }

        private void btEgal_Click(object sender, EventArgs e)
        {
            int nb1 = int.Parse(tbNb1.Text);
            int nb2 = int.Parse(tbNb2.Text);
            int result = nb1 + nb2;

            tbResult.Text = result.ToString();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbNb1.Clear();
            tbNb2.Clear();
            tbResult.Clear();
            tbNb1.Focus();
        }


    }
}