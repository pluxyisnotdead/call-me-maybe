using System;
using System.Windows.Forms;

namespace ATC
{
    public partial class ChangeRate : Form
    {
        private string Login;
        public ChangeRate(string login)
        {
            Login = login;
            InitializeComponent();
            foreach (var rate in UserActions.Rates)
            {
                this.rateBox.Items.Add(rate.Key);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (termsCheck.Checked)
            {
                User.LoginRate[Login] = rateBox.Text;
                Close();
                Main main = new Main(Login);
                main.Show();
            }

            else
            {
                MessageBox.Show("You should sign Terms of Use!", "Warning!");
            }
        }
    }
}