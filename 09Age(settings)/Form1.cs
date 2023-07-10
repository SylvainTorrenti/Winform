using System.Text.RegularExpressions;

namespace _09Age_settings_
{
    public partial class frmMain : Form
    {
        const string TITRE = "Age";
        public frmMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbBirthday.Text = Properties.Settings.Default.DtNaiss;
            this.tbName.Text = Properties.Settings.Default.Nom;
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
            if (birthday.Day > today.Day && birthday.Month == today.Month)
            {
                year = year - 1;
            }
            if (birthday.Month > today.Month)
            {
                year = year - 1;

            }
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

        private void btClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Nom = tbName.Text;
            Properties.Settings.Default.DtNaiss = tbBirthday.Text;
            Properties.Settings.Default.Save();
        }
    }
}