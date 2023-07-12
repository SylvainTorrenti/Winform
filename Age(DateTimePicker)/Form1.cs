using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Age_DateTimePicker_
{
    public partial class frmMain : Form
    {
        #region Constante
        const string TITRE = "Age";
        #endregion
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.tbName.Text = Properties.Settings.Default.Name;
            this.dtpYear.Value = Properties.Settings.Default.Date;
            this.dtpYear.MaxDate = DateTime.Now;
        }

        #region Btn Year
        /// <summary>
        /// Calcul l'age de la personne en fonction de sa date de naissance
        /// Verifie aussi le jour et le mois pour eviter les incohérences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btYear_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var today = DateTime.Today;
            int year = DateTime.Now.Year - dtpYear.Value.Year;
            if (dtpYear.Value.Day > today.Day && dtpYear.Value.Month == today.Month)
            {
                year = year - 1;
            }
            if (dtpYear.Value.Month > today.Month)
            {
                year = year - 1;

            }
            MessageBox.Show("bonjour " + name + ", vous avez " + year + " ans", TITRE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Btn Cancel
        /// <summary>
        /// Ferme la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Name = tbName.Text;
            Properties.Settings.Default.Date = dtpYear.Value;
            Properties.Settings.Default.Save();
        }


    }
}