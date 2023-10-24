using System.Collections.Generic;

namespace ATC
{
    public class User
    {
        public static Dictionary<string, string> LoginRefills = new Dictionary<string, string>()
        {
            {"user", ""},
            {"admin", ""}
        };

        
        public static Dictionary<string, string> LoginName = new Dictionary<string, string>()
        {
            {"user", "Alex"},
            {"admin", "Nazi"}
        };
        
        public static Dictionary<string, string> LoginPassword = new Dictionary<string, string>()
        {
            {"user", "user"},
            {"admin", "admin"}
        };
        
        public static Dictionary<string, bool> AdminRights = new Dictionary<string, bool>()
        {
            {"user", false},
            {"admin", true}
        };
        
        public static Dictionary<string, string> LoginPhNum = new Dictionary<string, string>()
        {
            {"user", "234234"},
            {"admin", "234234"}
        };
        
        public static Dictionary<string, string> LoginRate = new Dictionary<string, string>()
        {
            {"user", "Default"},
            {"admin", "Default"}
        };
        
        public static Dictionary<string, int> LoginBalance = new Dictionary<string, int>
        {
            {"user", 0},
            {"admin", 9999999}
        };
        
        public static Dictionary<string, string> LoginCalls = new Dictionary<string, string>
        {
            {"user", ""},
            {"admin", ""}
        };

        
        public string Login; 
        public string PhNumber;
        public string Password;
        public int Rate = 0;
        public double Balance = 0;

        public User()
        {
            Login = "";
            PhNumber = "";
            Password = "";
        }
        
        public User(string login, string phNumber, string password, int rate)
        {
            Login = login;
            PhNumber = phNumber;
            Password = password;
            Rate = rate;
        }
    }
}