using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace lovis.Security
{
    public class CryptoUtils
    {
        #region KEYS

        /// <summary>
        /// Function that generates random base64 userkey
        /// </summary>
        /// <returns>Base64 userkey</returns>
        public static string RandomKey()
        {
            string res = "";

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                // Buffer storage.
                byte[] data = new byte[6];

                // Five iterations.
                for (int i = 0; i < 5; i++)
                {
                    // Fill buffer.
                    rng.GetBytes(data);

                    // Convert to int 32.
                    int value = BitConverter.ToInt32(data, 0);

                    // Convert to string
                    res = value.ToString();
                }
                // Make it non negative
                if (res.Substring(0, 1) == "-")
                {
                    res = res.Remove(0, 1);
                }
            }
            return res;
        }

        #endregion

        #region SHA

        /// <summary>
        /// Compute hash for string encoded as UTF8
        /// </summary>
        /// <param name="s">String to be hashed</param>
        /// <returns>40-character hex string</returns>
        public static string SHA256HashStringForUTF8String(string s)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(s);

            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return HexStringFromBytes(hashBytes);
            }
        }

        /// <summary>
        /// Compute hash for string encoded as UTF8, used for IDs.
        /// </summary>
        /// <param name="s">String to be hashed</param>
        /// <returns>40-character hex string</returns>
        public static string SHA1HashStringForUTF8String(string s)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(s);

            var sha1 = SHA1.Create();
            byte[] hashBytes = sha1.ComputeHash(bytes);

            return HexStringFromBytes(hashBytes);
        }

        /// <summary>
        /// Convert an array of bytes to a string of hex digits
        /// </summary>
        /// <param name="bytes">array of bytes</param>
        /// <returns>String of hex digits</returns>
        public static string HexStringFromBytes(byte[] bytes)
        {
            var sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                var hex = b.ToString("x2");
                sb.Append(hex);
            }
            return sb.ToString();
        }

        #endregion

        #region USER ENCODE


        /// <summary>
        /// Method that encode an string
        /// </summary>
        /// <param name="u">User</param>
        /// <param name="StringToEncode">String to encode</param>
        /// <returns></returns>
        public static string EncodeUsername(string StringToEncode)
        {
            // Make it base64 string
            string encodedstring = Convert.ToBase64String(Encoding.UTF8.GetBytes(StringToEncode));

            // Concat enodedstring + first 8 randomkey hash + encode all again
            //string fullencodedstring = Convert.ToBase64String(Encoding.UTF8.GetBytes(encodedstring));

            // Return it
            return encodedstring;
        }

        /// <summary>
        /// Method that encode an string
        /// </summary>
        /// <param name="u">User</param>
        /// <param name="StringToEncode">String to encode</param>
        /// <returns></returns>
        public static string EncodeUserString(lovis.Controllers.Users.Users u, string StringToEncode)
        {
            // Make it base64 string
            string encodedstring = Convert.ToBase64String(Encoding.UTF8.GetBytes(StringToEncode));

            // Concat enodedstring + first 8 randomkey hash + encode all again
            string fullencodedstring = Convert.ToBase64String(Encoding.UTF8.GetBytes(encodedstring + "&" + u.RandomKey.Substring(0, 8)));

            // Return it
            return fullencodedstring;
        }

        /// <summary>
        /// Method that decodes an string
        /// </summary>
        /// <param name="StringToDecode">String to decode</param>
        /// <returns></returns>
        public static string DecodeUserString(string StringToDecode, lovis.Controllers.Users.Users u)
        {

            // Decode StringToDecode.
            byte[] data = Convert.FromBase64String(StringToDecode);
            string decodedString = Encoding.UTF8.GetString(data);

            // Split in 2.
            string[] splittedstring = decodedString.Split('&');
            if (u.RandomKey.Substring(0, 8) == splittedstring[1])
            {
                // Get 1 and decode it again.
                data = Convert.FromBase64String(splittedstring[0]);
                decodedString = Encoding.UTF8.GetString(data);
            }
            else
            {
                decodedString = "";
            }

            // Return it.
            return decodedString;
        }

        /// <summary>
        /// Method that decodes a string once
        /// </summary>
        /// <param name="us"></param>
        /// <returns></returns>
        public static string DecodeUsername(string us)
        {

            byte[] data = Convert.FromBase64String(us);
            string decodedString = Encoding.UTF8.GetString(data);

            return decodedString;
        }

        #endregion

        #region ELEMENT / PROYECTS ENCODE

        /// <summary>
        /// Method that encode an string from an element, with its license
        /// </summary>
        /// <param name="u">User</param>
        /// <param name="StringToEncode">String to encode</param>
        /// <returns></returns>
        public static string EncodeElementString(lovis.Controllers.Proyects.Proyects p, string StringToEncode)
        {
            // Make it base64 string
            string encodedstring = Convert.ToBase64String(Encoding.UTF8.GetBytes(StringToEncode));

            // Concat enodedstring + first 8 randomkey hash + encode all again
            string fullencodedstring = Convert.ToBase64String(Encoding.UTF8.GetBytes(encodedstring + "&" + p.IdLicense.Substring(0, 8)));

            // Return it
            return fullencodedstring;
        }

        /// <summary>
        /// Method that decodes an string from an elements, with its license
        /// </summary>
        /// <param name="StringToDecode">String to decode</param>
        /// <returns></returns>
        public static string DecodeElementString(lovis.Controllers.Proyects.Proyects p, string StringToDecode)
        {
            // Decode StringToDecode.
            byte[] data = Convert.FromBase64String(StringToDecode);
            string decodedString = Encoding.UTF8.GetString(data);

            // Split in 2.
            string[] splittedstring = decodedString.Split('&');
            // If this license have access to that element
            if (p.IdLicense.Substring(0, 8) == splittedstring[1])
            {
                // Get 1 and decode it again.
                data = Convert.FromBase64String(splittedstring[0]);
                decodedString = Encoding.UTF8.GetString(data);
            }
            else
            {
                decodedString = "";
            }

            // Return it.
            return decodedString;
        }

        #endregion

    }
}