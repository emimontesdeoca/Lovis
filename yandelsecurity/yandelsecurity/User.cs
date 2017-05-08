using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yandelsecurity
{
    public class User
    {

        public int Id { get; set; }
        public string Username { get; set; }
        public string UserKey { get; set; }
        public string PasswordKey { get; set; }
        public string EmailKey { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool isLogged { get; set; }

        public User()
        {

        }

        public User(int id, string username, string passwordIntroduced, string emailIntroduced, string name, string surname, bool isLogged = false)
        {
            Id = id;
            Username = username;
            UserKey = new Yandel().GenerateUserKey();
            PasswordKey = new Yandel().EncodeString(this.UserKey, passwordIntroduced);
            EmailKey = new Yandel().EncodeString(this.EmailKey, emailIntroduced);
            Name = name;
            Surname = surname;
            this.isLogged = isLogged;
        }

        public bool UserLogin(User u, string usernameIntroduced, string passwordIntroduced)
        {
            bool res = false;

            // Check if usernameintroducde match with userList
            if (u.Username == usernameIntroduced && u.PasswordKey == new Yandel().EncodeString(u.UserKey,passwordIntroduced))
            {
                // User entered right username and password
                res = true;
            }


            return res;
        }

    }
}
