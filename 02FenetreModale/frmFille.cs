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
        private void btYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion

        #region Btn Cancel 
        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        } 
        #endregion
    }
}
