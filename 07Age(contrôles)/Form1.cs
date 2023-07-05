using System.Text.RegularExpressions;

namespace _07Age_contrôles_
{
    public partial class Form1 : Form
    {
        const string TITRE = "Age";
        public Form1()
        {
            InitializeComponent();
        }
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

        private void btYear_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var today = DateTime.Today;
            var birthday = Convert.ToDateTime(tbBirthday.Text);
            var year = today.Year - birthday.Year;
            MessageBox.Show("bonjour " + name + ", vous avez " + year + " ans", TITRE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            visible();
        }

        private void tbBirthday_TextChanged(object sender, EventArgs e)
        {
            visible();
        }
    }
}