using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yandelsecurity
{
    public class Yandel
    {
        public string UserKey { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }



        public string EncodeString(string UserKey, string String)
        {
            string res = "";

            string nonencodedstring = String;
            string encodedstring = Convert.ToBase64String(Encoding.UTF8.GetBytes(nonencodedstring));

            string encodedconcat = UserKey + encodedstring;
            string reencodedconcat = Convert.ToBase64String(Encoding.UTF8.GetBytes(encodedconcat));

            Random rnd = new Random();

            int i = rnd.Next(1, 4);

            //string[] splitEncoded = reencodedconcat.Split()


            return res;
        }

    }
}
