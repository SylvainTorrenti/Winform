using _13Imge_grisage_degrisage_.Properties;
using Microsoft.VisualBasic;
using System.Collections.Specialized;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _13Imge_grisage_degrisage_
{
    public partial class frmMain : Form
    {
        #region Iniatialize
        public frmMain()
        {
            InitializeComponent();
            if (Properties.Settings.Default.liste == null)
            {
                Properties.Settings.Default.liste = new System.Collections.Specialized.StringCollection();
            }
            if (Properties.Settings.Default.liste.Count > 0)
            {
                btClear.Enabled = true;
            }

        }
        #endregion

        #region Form Load
        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (string item in Properties.Settings.Default.liste)
            {
                this.libPath.Items.Add(item);
            }
        }
        #endregion

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
                    if (!(Properties.Settings.Default.liste.Contains(tbPath.Text)) || !(libPath.Items.Contains(tbPath.Text)))
                    {
                        btAdd.Enabled = true;

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
            if ((tbPath.Text.Length > 0) && !(Properties.Settings.Default.liste.Contains(tbPath.Text)))
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
                string? tempo = libPath.SelectedItem.ToString();
                libPath.Items.Remove(tempo);
                btDelete.Enabled = false;
                Properties.Settings.Default.liste.Remove(tempo);


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
            Properties.Settings.Default.liste.Clear();
            Properties.Settings.Default.Save();
        }

        #endregion

        #region Lib Path
        /// <summary>
        /// Permet de dégriser le Boutton Delete si un element est selectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void libPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDelete.Enabled = true;
        }
        #endregion

        #region Form Closed
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var item in libPath.Items)
            {
                if (!Properties.Settings.Default.liste.Contains(item.ToString()))
                {
                    Properties.Settings.Default.liste.Add(item.ToString());
                }
            }
                    Properties.Settings.Default.Save();
        }
        #endregion

        #region Fonction perso
        /// <summary>
        /// Save les item de la list box sur l'ordinateur
        /// </summary>
        //public void SaveToDisk()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    foreach (var item in libPath.Items)
        //    {
        //        sb.AppendLine(item.ToString());
        //    }

        //    File.WriteAllText($"{Path.GetTempPath()}\\images.txt", sb.ToString());
        //}
        ///// <summary>
        ///// Charge le fichier precedement créé pour remplir la list box
        ///// </summary>
        //public void LoadFromDisk()
        //{



        //    libPath.Items.Clear();

        //    var listContent = File.ReadAllLines($"{Path.GetTempPath()}\\images.txt");

        //    foreach (var line in listContent)
        //    {
        //        libPath.Items.Add(line);
        //    }

        ////}
        #endregion




    }
}