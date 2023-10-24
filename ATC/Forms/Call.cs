using System;
using System.Linq;
using System.Windows.Forms;

namespace ATC
{
    public partial class Call : Form
    {
        public int Time;
        public string Login;
        public Call(string login)
        {
            InitializeComponent();
            Login = login;
        }

        private void timeButton_Click(object sender, EventArgs e)
        {
            Time = Int32.Parse(timeBox.Text);
            User.LoginCalls[Login] += DateTime.Now + " | " + Convert.ToString(Time) + " minutes | " + Convert.ToString(Time * UserActions.Rates[User.LoginRate[Login]] + "$\n");
            User.LoginBalance[Login] -= UserActions.Call(Login, Time);
            Close();
            Main main = new Main(Login);
            main.Show();
        }
    }
}