namespace Test
{
    public partial class frMain : Form
    {
        private Random rnd = new Random();
        public frMain()
        {
            InitializeComponent();
        }

        private void btTestColor_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void btSize_Click(object sender, EventArgs e)
        {
            Height = Height * 2;
            Width = Width * 2;
        }

        private void btColorRed_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void btColorGreen_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void btColorRand_Click(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            BackColor = randomColor;
        }

        private void btDisappear_Click(object sender, EventArgs e)
        {
            btDisappear.Visible = false;
        }

        private void btAppears_Click(object sender, EventArgs e)
        {
            btDisappear.Visible = true;
        }
    }
}