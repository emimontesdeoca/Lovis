using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lovis.Controllers.Users
{
    public class Users
    {
        #region ATTRIBUTES

        public string Id { get; set; }
        public string Username { get; set; }
        public string RandomKey { get; set; }
        public string PasswordHash { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateRegister { get; set; }

        public static List<Users> uLTest = new List<Users>();

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Empty constructor
        /// </summary>
        public Users() { }

        /// <summary>
        /// Constructor filled with an introduced User
        /// </summary>
        /// <param name="u"></param>
        public Users(Users u) { }

        /// <summary>
        /// Constructor with parameteres
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="name">Name</param>
        /// <param name="surname">Surname</param>
        /// <param name="phone1">Phone</param>
        public Users(string username, string passwordIntroduced, string name, string surname)
        {
            // New user
            Id = Security.CryptoUtils.SHA1HashStringForUTF8String(Security.CryptoUtils.RandomKey());
            Username = Security.CryptoUtils.EncodeUsername(username);
            RandomKey = Security.CryptoUtils.SHA256HashStringForUTF8String(Security.CryptoUtils.RandomKey());
            PasswordHash = Security.CryptoUtils.SHA256HashStringForUTF8String(passwordIntroduced);
            Name = Security.CryptoUtils.EncodeUserString(this, name);
            Surname = Security.CryptoUtils.EncodeUserString(this, surname);
            DateRegister = DateTime.Now;
        }

        #endregion

        #region CHECK

        public Users DecodeUser(Users cU)
        {

            cU.Username = Security.CryptoUtils.DecodeUsername(cU.Username);
            cU.Name = Security.CryptoUtils.DecodeUserString(cU.Name, cU);
            cU.Surname = Security.CryptoUtils.DecodeUserString(cU.Surname, cU);

            return cU;
        }

        public Users isUser(string UsernameIntroduced, string PasswordIntroduced)
        {
            /// User list - have to fill it from DATABASE
            List<Users> uL = uLTest;

            /// Look for the user introduced
            var xu = uL.First(x => x.Username == Security.CryptoUtils.EncodeUsername(UsernameIntroduced) && x.PasswordHash == Security.CryptoUtils.SHA256HashStringForUTF8String(PasswordIntroduced));

            /// If it is not null return user
            if (xu != null)
            {
                /// Return user if login is a success
                return xu;
            }
            /// Else return no user 
            else
            {
                return null;
            }
        }

        #endregion

        #region NEW

        /// <summary>
        /// Method that creates a new user and a new license.
        /// </summary>
        public void New()
        {
            // Create new user + add to database
            uLTest.Add(this);
            // Create new license (it add itself to db)
            License.License idLicense = new License.License(this);

            // Add to UserLicense (it add itself to db)
            new UserLicense.UserLicense(this.Id, idLicense.IdLicense, 1, false);
        }

        #endregion

        #region EDIT

        public void Edit(string passwordIntroduced, string name, string surname)
        {
            // Edit user
            // Do foreach in entityframework

            PasswordHash = Security.CryptoUtils.SHA256HashStringForUTF8String(passwordIntroduced);
            Name = Security.CryptoUtils.EncodeUserString(this, name);
            Surname = Security.CryptoUtils.EncodeUserString(this, surname);
        }

        #endregion

        #region REMOVE

        public void Remove()
        {
            // Delete from database
            // entityframework
        }

        #endregion
    }
}