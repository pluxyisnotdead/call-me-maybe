using System;
using System.Windows.Forms;

namespace ATC
{
    public partial class RefillBalance : Form
    {
        public string Login;
        public int Payment;
        public RefillBalance(string login)
        {
            InitializeComponent();
            Login = login;
        }

        private void refillButton_Click(object sender, EventArgs e)
        {
            Payment = Int32.Parse(refillBox.Text);
            User.LoginBalance[Login] += Payment;
            User.LoginRefills[Login] += DateTime.Now + " | " +(Convert.ToString(Payment) + "$\n");
            Main main = new Main(Login);
            main.Show();
            Close();
        }


    }
}