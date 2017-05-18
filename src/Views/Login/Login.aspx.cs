using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace lovis.Views.Login
{

    public partial class Login : System.Web.UI.Page
    {
        public bool isWrong;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                /// Test accs
                if (Controllers.Users.Users.uLTest.Exists(x => Security.CryptoUtils.DecodeUsername(x.Username) == "test@test.com"))
                {

                }
                else
                {
                    new Controllers.Users.Users("test@test.com", "test", "Emiliano", "Montesdeoca").New();
                }
                login_error.Visible = false;
            }
            else
            {
                Session["User"] = null;
            }
        }

        protected void login_loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                /// Get user if is user in DB
                Controllers.Users.Users u = new Controllers.Users.Users().isUser(login_username.Text, login_password.Text);
                /// If not null means there is a user with username && password hashed 
                if (u != null)
                {
                    Controllers.Users.Users loginUser = new Controllers.Users.Users();

                    /// Fill session with user
                    loginUser.Id = u.Id;
                    loginUser.Username = Security.CryptoUtils.DecodeUsername(u.Username);
                    loginUser.Name = Security.CryptoUtils.DecodeUserString(u.Name, u);
                    loginUser.Surname = Security.CryptoUtils.DecodeUserString(u.Surname, u);
                    loginUser.Address = Security.CryptoUtils.DecodeUserString(u.Address, u);
                    loginUser.City = Security.CryptoUtils.DecodeUserString(u.City, u);
                    loginUser.Country = Security.CryptoUtils.DecodeUserString(u.Country, u);
                    loginUser.PostalCode = Security.CryptoUtils.DecodeUserString(u.PostalCode, u);
                    loginUser.AboutMe = Security.CryptoUtils.DecodeUserString(u.AboutMe, u);
                    loginUser.Facebook = Security.CryptoUtils.DecodeUserString(u.Facebook, u);
                    loginUser.Twitter = Security.CryptoUtils.DecodeUserString(u.Twitter, u);
                    loginUser.Github = Security.CryptoUtils.DecodeUserString(u.Github, u);
                    loginUser.Skype = Security.CryptoUtils.DecodeUserString(u.Skype, u);
                    loginUser.Linkedin = Security.CryptoUtils.DecodeUserString(u.Linkedin, u);
                    loginUser.Googleplus = Security.CryptoUtils.DecodeUserString(u.Googleplus, u);
                    loginUser.DateRegister = u.DateRegister;
                    loginUser.LastModification = u.LastModification;
                    loginUser.PasswordHash = u.PasswordHash;
                    loginUser.RandomKey = u.RandomKey;
                    loginUser.isPublic = u.isPublic;

                    /// Set user
                    Session["User"] = loginUser;
                    /// Redirect
                    Response.Redirect("~/Views/Dashboard/Dashboard.aspx");
                }
            }
            catch (Exception)
            {
                /// Wrong user || password text
                isWrong = true;
                login_error.Visible = true;
            }
        }
    }
}