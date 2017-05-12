using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lovis.Controllers.UserLicense
{
    public class UserLicense
    {
        #region ATTRIBUTES

        public string Id { get; set; }
        public string IdUser { get; set; }
        public string IdLicense { get; set; }
        public int Role { get; set; }
        public bool IsBlocked { get; set; }

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Empty constructor
        /// </summary>
        public UserLicense() { }

        /// <summary>
        /// Constructor filled with UserLicense
        /// </summary>
        /// <param name="L">UserLicense</param>
        public UserLicense(UserLicense L) { }

        /// <summary>
        /// Contructor with paramenteres
        /// </summary>
        /// <param name="idUser">User ID</param>
        /// <param name="idLicense">License ID</param>
        /// <param name="role">Role</param>
        /// <param name="isBlocked">Blocked (keep false for creating user)</param>
        public UserLicense(string idUser, string idLicense, int role, bool isBlocked = false)
        {
            Id = lovis.Security.CryptoUtils.SHA1HashStringForUTF8String(lovis.Security.CryptoUtils.RandomKey());
            IdUser = idUser;
            IdLicense = idLicense;
            Role = role;
            isBlocked = false;

            // Add to database
            New();
        }

        #endregion

        #region NEW 

        public void New()
        {
            // Add to database

        }

        #endregion

        #region EDIT 

        #endregion

        #region ADD USER TO LICENSE


        #endregion
    }
}