using System;
using System.Windows.Forms;

namespace ATC
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            User.LoginPassword[userChooseBox.Text] = newPasswordBox.Text;
            MessageBox.Show("Password has been changed.", "Complete!");
            Close();
        }
    }
}