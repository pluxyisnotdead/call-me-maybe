using System;
using System.Windows.Forms;

namespace ATC
{
    public partial class NewAdmin : Form
    {
        public NewAdmin()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            User.AdminRights[userChooseBox.Text] = true;
            MessageBox.Show("New admin has been added.", "Complete!");
            Close();
        }
    }
}