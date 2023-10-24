using System;
using System.Windows.Forms;

namespace ATC
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            foreach (var rate in UserActions.Rates)
            {
                this.rateBox.Items.Add(rate.Key);
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (termsCheck.Checked)
            {
                User.LoginPassword.Add(loginBox.Text, passwordBox.Text);
                User.LoginPhNum.Add(loginBox.Text, phNumBox.Text);
                User.LoginBalance.Add(loginBox.Text, 0);
                User.LoginRefills.Add(loginBox.Text, "");
                User.LoginRate.Add(loginBox.Text, rateBox.Text);
                User.LoginCalls[loginBox.Text] = null;
                User.AdminRights[loginBox.Text] = false;
                User.LoginName.Add(loginBox.Text, nameBox.Text);
                MessageBox.Show("Successfully registered.", "Complete!");
                Close();
            }
            else
            {
                MessageBox.Show("You should sign Terms of Use!", "Warning!");
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Agreement agreement = new Agreement();
            agreement.Show();
        }
    }
}