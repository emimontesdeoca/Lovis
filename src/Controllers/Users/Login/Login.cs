using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lovis.Controllers.Users.Login
{
    public class Login
    {

        public Users isUser(string UsernameIntroduced, string PasswordIntroduced)
        {
            Users x = new Users().isUser(UsernameIntroduced, PasswordIntroduced);

            if (x != null)
            {
                return x;
            }
            else
            {
                return null;
            }
        }
    }
}