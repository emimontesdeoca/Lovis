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

        public static List<UserLicense> lUL = new List<UserLicense>();
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
            Id = Security.CryptoUtils.SHA1HashStringForUTF8String(lovis.Security.CryptoUtils.RandomKey());
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
            lUL.Add(this);
        }

        #endregion

        #region EDIT 

        /// <summary>
        /// Method that edits a UserLicens, mostly going to be used to edit a role
        /// </summary>
        public void Edit(string Username, string idLicense, int NewRole)
        {
            // Get idUser from Username
            string idUser = "";

            // Set new role

            // Search on the userlicenses list/table where usernmar&&idlicense match, set NewRole

        }

        #endregion

        #region ADD USER TO LICENSE

        /// <summary>
        /// Method that creates a new user for an existing license
        /// </summary>
        /// <param name="Username">Username (email)</param>
        /// <param name="idLicense">License ID</param>
        public void AddUserToLicense(string Username, string idLicense)
        {
            // Get idUser from Username
            string idUser = "";

            // Create new UserLicense
            new UserLicense(idUser, idLicense, 0, false);

        }

        #endregion
    }
}