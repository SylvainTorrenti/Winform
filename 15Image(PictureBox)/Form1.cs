namespace _15Image_PictureBox_
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Btn Image
        /// <summary>
        /// Permet de chercher les fichier qui ont l'extension que nous lui indiquons avec 'openFileDialog.Filter'
        /// Affiche le chemin dans la Textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Ajoute le chemin present dans la Text Box dans la Liste Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbPath.Text.Length > 0)
            {

                libPath.Items.Add(tbPath.Text);
                tbPath.Clear();
                btClear.Enabled = true;
                btAdd.Enabled = false;
            }
        }
        #endregion

        #region Btn Delete
        /// <summary>
        /// Supprime l'element selectionner de la Listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (libPath.Items != null)
            {

                libPath.Items.Remove(libPath.SelectedItem);
                btDelete.Enabled = false;
            }
            if (libPath.Items.Count == 0)
            {
                btClear.Enabled = false;
            }
        }
        #endregion

        #region Btn Clear
        /// <summary>
        /// Delete tous les element de la List box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClear_Click(object sender, EventArgs e)
        {
            libPath.Items.Clear();
            btClear.Enabled = false;
        }
        #endregion

        #region Lib path
        /// <summary>
        /// Permet de dégriser le Boutton Delete si un element est selectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void libPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDelete.Enabled = true;
            pbImage.Load(libPath.SelectedItem.ToString());
        }
        #endregion

    }
}