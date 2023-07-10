using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02FenetreModale
{
    public partial class frmFille : Form
    {
        public frmFille()
        {
            InitializeComponent();
        }

        #region Btn Yes
        /// <summary>
        /// Quand on appuie sur le bouton yes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion

        #region Btn Cancel 
        /// <summary>
        /// Quand on appuie sur le bouton cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        } 
        #endregion
    }
}
