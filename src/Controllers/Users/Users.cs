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
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string AboutMe { get; set; }
        public DateTime DateRegister { get; set; }
        public DateTime LastModification { get; set; }


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
            Address = Security.CryptoUtils.EncodeUserString(this, "");
            City = Security.CryptoUtils.EncodeUserString(this, "");
            Country = Security.CryptoUtils.EncodeUserString(this, "");
            PostalCode = Security.CryptoUtils.EncodeUserString(this, "");
            AboutMe = Security.CryptoUtils.EncodeUserString(this, "");
            LastModification = DateTime.Now;
            DateRegister = DateTime.Now;
        }

        #endregion

        #region CHECK

        /// <summary>
        /// Method that decode user
        /// </summary>
        /// <param name="cU">User to decode</param>
        /// <returns></returns>
        public Users DecodeUser(Users cU)
        {

            cU.Username = Security.CryptoUtils.DecodeUsername(cU.Username);
            cU.Name = Security.CryptoUtils.DecodeUserString(cU.Name, cU);
            cU.Surname = Security.CryptoUtils.DecodeUserString(cU.Surname, cU);
            cU.Address = Security.CryptoUtils.DecodeUserString(cU.Address, cU);
            cU.City = Security.CryptoUtils.DecodeUserString(cU.City, cU);
            cU.Country = Security.CryptoUtils.DecodeUserString(cU.Country, cU);
            cU.PostalCode = Security.CryptoUtils.DecodeUserString(cU.PostalCode, cU);
            cU.AboutMe = Security.CryptoUtils.DecodeUserString(cU.AboutMe, cU);

            return cU;
        }

        /// <summary>
        /// Method that returns a user if it exists in the user LIST
        /// </summary>
        /// <param name="UsernameIntroduced">Username introduced</param>
        /// <param name="PasswordIntroduced">Password introduced</param>
        /// <returns></returns>
        public Users isUser(string UsernameIntroduced, string PasswordIntroduced)
        {
            /// User list - have to fill it from DATABASE
            List<Users> uL = uLTest;

            try
            {
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
            catch (Exception)
            {
                throw;
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