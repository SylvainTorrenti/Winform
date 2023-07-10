using System.Windows.Forms;

namespace _12Image_Listbox_
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
            libPath.Items.Add(tbPath.Text);
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
            libPath.Items.Remove(libPath.SelectedItem);
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
        } 
        #endregion
    }
}