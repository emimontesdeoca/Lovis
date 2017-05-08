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
    }
}
