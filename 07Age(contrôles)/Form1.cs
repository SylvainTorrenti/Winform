using System.Text.RegularExpressions;

namespace _07Age_contrôles_
{
    public partial class Form1 : Form
    {
        #region Constante
        const string TITRE = "Age"; 
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        #region Visible
        private void visible()
        {
            var regex = new Regex("^[0-9]{1,2}\\/[0-9]{1,2}\\/[0-9]{4}$");
            if ((tbName.Text != "") && (tbBirthday.Text != ""))
            {
                if (regex.IsMatch(tbBirthday.Text))
                {
                    int result = DateTime.Compare(Convert.ToDateTime(tbBirthday.Text), DateTime.Now);
                    if (result < 0)
                    {

                        btYear.Enabled = true;
                    }
                }
            }
        }
        #endregion

        #region Btn Year
        private void btYear_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var today = DateTime.Today;
            var birthday = Convert.ToDateTime(tbBirthday.Text);
            var year = today.Year - birthday.Year;
            if ((birthday.Day > today.Day && birthday.Month == today.Month) || birthday.Month > today.Month)
            {
                year--;
            }

            MessageBox.Show("bonjour " + name + ", vous avez " + year + " ans", TITRE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Tb Name
        private void tbName_TextChanged(object sender, EventArgs e)
        {
            visible();
        }
        #endregion

        #region Tb Birthday
        private void tbBirthday_TextChanged(object sender, EventArgs e)
        {
            visible();
        }
        #endregion

        #region Btn Close
        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        } 
        #endregion
    }
}