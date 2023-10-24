using System;
using System.Windows.Forms;

namespace ATC
{
    public partial class Main : Form
    {
        public static string Login;

        public Main(string login)
        {
            InitializeComponent();
            Login = login;
            loginBox.Text = login;
            phBox.Text = User.LoginPhNum[login];
            balanceBox.Text = Convert.ToString(User.LoginBalance[login]);
            rateBox.Text = User.LoginRate[login];
            nameBox.Text = User.LoginName[login];
        }

        private void callButton_Click(object sender, EventArgs e)
        {
            Call call = new Call(Login);
            call.Show();
            Close();
        }

        private void refillBalanceButton_Click(object sender, EventArgs e)
        {
            RefillBalance refillBalance = new RefillBalance(Login);
            refillBalance.Show();
            Close();
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill(Login);
            bill.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Close();
            Login login = new Login();
            login.Show();
        }

        private void changeRateButton_Click(object sender, EventArgs e)
        {
            ChangeRate changeRate = new ChangeRate(Login);
            changeRate.Show();
            Close();
        }
        
    }
}