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
            Path();
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
                // Ajout du chemin de l'image dans la libPath
                libPath.Items.Add(tbPath.Text);
                tbPath.Clear();

                // Appel de la fonction qui gère les grisages
                GestionGrisages();
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
            if (libPath.SelectedIndex != -1)
            {
                // On supprime l'élément sélectionné dans la libPath
                libPath.Items.RemoveAt(libPath.SelectedIndex);
                btDelete.Enabled = false;
                pbImage.Image = null;
            }
            GestionGrisages();
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
            pbImage.Image = null;
            GestionGrisages();
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
            if (libPath.SelectedIndex != -1)
            {

                pbImage.Load(libPath.SelectedItem.ToString());
                btDelete.Enabled = true;

            }
        }
        #endregion

        #region Fonction perso
        private void GestionGrisages()
        {

            btAdd.Enabled = (tbPath.Text.Length > 0);

            btDelete.Enabled = (libPath.SelectedIndex != -1);

            btClear.Enabled = (libPath.Items.Count != 0);
        }
        private void Path()
        {
            string filePath = string.Empty;
            string fileName = string.Empty;
            string tempItemName = string.Empty;

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
                    fileName = System.IO.Path.GetFileName(filePath);
                    tbPath.Text = filePath;
                    if (tbPath.Text.Length > 0)
                    {
                        if (libPath.Items.Count == 0)
                        {
                            GestionGrisages();
                        }
                        foreach (var item in libPath.Items)
                        {
                            tempItemName = System.IO.Path.GetFileName(item.ToString());
                            if (fileName != tempItemName)
                            {
                                GestionGrisages();
                            }
                        }

                    }
                }
            }
        }
        #endregion
    }
}