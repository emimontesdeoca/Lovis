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
        public string Phone1 { get; set; }
        public DateTime DateRegister { get; set; }

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
        public Users(string username, string passwordIntroduced, string name, string surname, string phone1)
        {
            // New user
            Id = Security.CryptoUtils.SHA1HashStringForUTF8String(lovis.Security.CryptoUtils.RandomKey());
            Username = Security.CryptoUtils.EncodeUsername(username);
            RandomKey = Security.CryptoUtils.SHA256HashStringForUTF8String(lovis.Security.CryptoUtils.RandomKey());
            PasswordHash = Security.CryptoUtils.SHA256HashStringForUTF8String(passwordIntroduced);
            Name = Security.CryptoUtils.EncodeUserString(this, name);
            Surname = Security.CryptoUtils.EncodeUserString(this, surname);
            Phone1 = Security.CryptoUtils.EncodeUserString(this, phone1);
            DateRegister = DateTime.Now;
        }

        #endregion

        #region CHECK

        public Users DecodeUser(Users cU)
        {

            cU.Username = Security.CryptoUtils.DecodeUserString(cU.Username, cU);
            cU.Name = Security.CryptoUtils.DecodeUserString(cU.Name, cU);
            cU.Surname = Security.CryptoUtils.DecodeUserString(cU.Surname, cU);
            cU.Phone1 = Security.CryptoUtils.DecodeUserString(cU.Phone1, cU);

            return cU;
        }

        #endregion

        #region NEW

        /// <summary>
        /// Method that creates a new user and a new license.
        /// </summary>
        public void New()
        {
            // Create new user + add to database

            // Create new license (it add itself to db)
            License.License idLicense = new License.License(this);

            // Add to UserLicense (it add itself to db)
            new UserLicense.UserLicense(this.Id, idLicense.Id, 1, false);
        }

        #endregion

        #region EDIT

        public void Edit(string passwordIntroduced, string name, string surname, string phone1)
        {
            // Edit user
            // Do foreach in entityframework

            PasswordHash = Security.CryptoUtils.SHA256HashStringForUTF8String(passwordIntroduced);
            Name = Security.CryptoUtils.EncodeUserString(this, name);
            Surname = Security.CryptoUtils.EncodeUserString(this, surname);
            Phone1 = Security.CryptoUtils.EncodeUserString(this, phone1);
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