using System.Reflection.Emit;
using System.Windows.Forms;

namespace _14Image_listeSansDoublon_
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Btn Image
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
                    if (libPath.Items.Count == 0)
                    {
                        btAdd.Enabled = true;
                    }
                    foreach (var item in libPath.Items)
                    {
                        if (item.ToString() != filePath)
                        {
                            btAdd.Enabled = true;
                        }
                    }
                }
            }
        }
        #endregion

        #region Btn Add
        private void btAdd_Click(object sender, EventArgs e)
        {
            libPath.Items.Add(tbPath.Text);
            tbPath.Clear();
            btClear.Enabled = true;
            btAdd.Enabled = false;
        }
        #endregion

        #region Btn Delete
        private void btDelete_Click(object sender, EventArgs e)
        {
            libPath.Items.Remove(libPath.SelectedItem);
            btDelete.Enabled = false;
            if (libPath.Items.Count == 0)
            {
                btClear.Enabled = false;
            }
        }
        #endregion

        #region Btn Clear
        private void btClear_Click(object sender, EventArgs e)
        {
            libPath.Items.Clear();
            btClear.Enabled = false;
        }
        #endregion

        #region Lib Path
        private void libPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDelete.Enabled = true;
        } 
        #endregion
    }
}