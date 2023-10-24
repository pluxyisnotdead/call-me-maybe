using System;
using System.Windows.Forms;

namespace ATC
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (User.LoginPassword.ContainsKey(loginBox.Text) 
                && User.LoginPassword[loginBox.Text] == passwordBox.Text)
            {
                if (User.AdminRights[loginBox.Text])
                {
                    AdminPanel adminPanel = new AdminPanel(loginBox.Text);
                    adminPanel.Show();
                    Hide();
                }
                else
                {
                    Main main = new Main(loginBox.Text);
                    main.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("This user doen't exist!", "Error");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}