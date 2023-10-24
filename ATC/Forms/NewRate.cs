using System;
using System.Windows.Forms;

namespace ATC
{
    public partial class NewRate : Form
    {
        public NewRate()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            UserActions.Rates[nameBox.Text] = Convert.ToInt32(priceBox.Text);
            MessageBox.Show("New rate has been added.", "Complete!");
            Close();
        }
    }
}