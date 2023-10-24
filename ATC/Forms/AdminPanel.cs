using System;
using System.Windows.Forms;

namespace ATC
{
    public partial class AdminPanel : Form
    {
        public static string Login;
        public AdminPanel(string login)
        {
            InitializeComponent();
            Login = login;
            loginBox.Text = login;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Close();
            Login login = new Login();
            login.Show();
        }

        private void newRateButton_Click(object sender, EventArgs e)
        {
            NewRate newRate = new NewRate();
            newRate.Show();
        }

        private void addAdminButton_Click(object sender, EventArgs e)
        {
            NewAdmin newAdmin = new NewAdmin();
            newAdmin.Show();
        }

        private void newUserBotton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void changePassButton_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
        }
    }
}