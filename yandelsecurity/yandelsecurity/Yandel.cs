using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace yandelsecurity
{
    public class Yandel
    {

        /// <summary>
        /// Function that generates random base64 userkey
        /// </summary>
        /// <returns>Base64 userkey</returns>
        public string GenerateUserKey()
        {
            string res = "";

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                // Buffer storage.
                byte[] data = new byte[4];

                // Ten iterations.
                for (int i = 0; i < 10; i++)
                {
                    // Fill buffer.
                    rng.GetBytes(data);

                    // Convert to int 32.
                    int value = BitConverter.ToInt32(data, 0);

                    // Convert to string
                    res = value.ToString();

                    // Make it non negative
                    
                }
                if (res.Substring(0, 1) == "-")
                {
                    res = res.Remove(0, 1);
                }
            }
            res = Convert.ToBase64String(Encoding.UTF8.GetBytes(res));

            return res;
        }

        /// <summary>
        /// Function that encode string in base64
        /// </summary>
        /// <param name="UserKey">Userkey in base64 string</param>
        /// <param name="String">String to encode</param>
        /// <returns></returns>
        public string EncodeString(string UserKey, string String)
        {
            // Get the non encoded string - passw or email
            string nonencodedstring = String;

            // Make it base64 string
            string encodedstring = Convert.ToBase64String(Encoding.UTF8.GetBytes(nonencodedstring));

            // Concat it with base64 userkey
            string encodedconcat = UserKey + "%" + encodedstring;

            // Reencode it again
            string reencodedconcat = Convert.ToBase64String(Encoding.UTF8.GetBytes(encodedconcat));

            // Return it
            return reencodedconcat;
        }
    }
}
