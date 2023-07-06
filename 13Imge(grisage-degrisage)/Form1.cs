namespace _13Imge_grisage_degrisage_
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void btImage_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Images(*.jpeg/*.jpg/*.png)|*.jpeg;*.jpg;*.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    tbPath.Text = filePath;
                    btAdd.Enabled = true;
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            libPath.Items.Add(tbPath.Text);
            tbPath.Clear();
            btClear.Enabled = true;
            btAdd.Enabled = false;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            libPath.Items.Remove(libPath.SelectedItem);
            btDelete.Enabled = false;
            if (libPath.Items.Count == 0)
            {
                btClear.Enabled = false;
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            libPath.Items.Clear();
            btClear.Enabled = false;
        }

        private void libPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDelete.Enabled = true;
        }
    }
}