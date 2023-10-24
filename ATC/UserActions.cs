using System.Collections.Generic;

namespace ATC
{
    public class UserActions : User
    {
        public static Dictionary<string, int> Rates = new Dictionary<string, int>()
        {
            {"Default", 2},
            {"Advanced", 5}
        };
        
        

        public static int Call(string login, int time)
        {
            return time * Rates[User.LoginRate[login]];
        }
        
    }
}