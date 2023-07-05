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

        private void btYes_Click(object sender, EventArgs e)
        {
            btYes.DialogResult = DialogResult.OK;
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            btCancel.DialogResult = DialogResult.Cancel;
        }
    }
}
