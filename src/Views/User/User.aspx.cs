using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lovis.Views.User
{
    public partial class User : System.Web.UI.Page
    {
        public bool isError;
        public bool UpdatedSuccess;

        protected void Page_Load(object sender, EventArgs e)
        {
            pagetitle.Text = "Settings - Lovis";

            Controllers.Users.Users DU = Session["User"] as Controllers.Users.Users;
            if (!IsPostBack)
            {
                /// Load user for User page information

                user_username.Text = DU.Username;
                user_name.Text = DU.Name;
                user_surname.Text = DU.Surname;
                user_city.Text = DU.City;
                user_country.Text = DU.Country;
                user_cp.Text = DU.PostalCode;
                user_address.Text = DU.Address;
                user_aboutme.Text = DU.AboutMe;
                user_fb.Text = DU.Facebook;
                user_tw.Text = DU.Twitter;
                user_gh.Text = DU.Github;
                user_skype.Text = DU.Skype;
                user_googleplus.Text = DU.Googleplus;
                user_linkedin.Text = DU.Linkedin;
                user_public.Checked = DU.isPublic;
                user_registerdate.Text = DU.DateRegister.ToString();
                user_lastmodification.Text = DU.LastModification.ToString();

            }
            if (UpdatedSuccess)
            {
                user_username.Text = DU.Username;
                user_name.Text = DU.Name;
                user_surname.Text = DU.Surname;
                user_city.Text = DU.City;
                user_country.Text = DU.Country;
                user_cp.Text = DU.PostalCode;
                user_address.Text = DU.Address;
                user_aboutme.Text = DU.AboutMe;
                user_fb.Text = DU.Facebook;
                user_tw.Text = DU.Twitter;
                user_gh.Text = DU.Github;
                user_skype.Text = DU.Skype;
                user_googleplus.Text = DU.Googleplus;
                user_linkedin.Text = DU.Linkedin;
                user_public.Checked = DU.isPublic;
                user_registerdate.Text = DU.DateRegister.ToString();
                user_lastmodification.Text = DU.LastModification.ToString();
            }
            user_error.Visible = false;
        }

        protected void user_update_Click(object sender, EventArgs e)
        {
            if (user_name.Text != "" && user_surname.Text != "")
            {
                /// Get current user
                Controllers.Users.Users DU = Session["User"] as Controllers.Users.Users;

                /// Filter user list with user
                var x = Controllers.Users.Users.uLTest.Single(u => u.Id == DU.Id);

                /// Set new variables
                x.Name = Security.CryptoUtils.EncodeUserString(x, user_name.Text);
                x.Surname = Security.CryptoUtils.EncodeUserString(x, user_surname.Text);
                x.Address = Security.CryptoUtils.EncodeUserString(x, user_address.Text);
                x.City = Security.CryptoUtils.EncodeUserString(x, user_city.Text);
                x.Country = Security.CryptoUtils.EncodeUserString(x, user_country.Text);
                x.PostalCode = Security.CryptoUtils.EncodeUserString(x, user_cp.Text);
                x.AboutMe = Security.CryptoUtils.EncodeUserString(x, user_aboutme.Text);
                x.Facebook = Security.CryptoUtils.EncodeUserString(x, user_fb.Text);
                x.Twitter = Security.CryptoUtils.EncodeUserString(x, user_tw.Text);
                x.Github = Security.CryptoUtils.EncodeUserString(x, user_gh.Text);
                x.Skype = Security.CryptoUtils.EncodeUserString(x, user_skype.Text);
                x.Googleplus = Security.CryptoUtils.EncodeUserString(x, user_googleplus.Text);
                x.Linkedin = Security.CryptoUtils.EncodeUserString(x, user_linkedin.Text);
                x.isPublic = user_public.Checked;


                x.LastModification = DateTime.Now;

                Controllers.Users.Users loginUser = new Controllers.Users.Users();

                /// Set new User for Session
                loginUser.Id = x.Id;
                loginUser.Username = Security.CryptoUtils.DecodeUsername(x.Username);
                loginUser.Name = Security.CryptoUtils.DecodeUserString(x.Name, x);
                loginUser.Surname = Security.CryptoUtils.DecodeUserString(x.Surname, x);
                loginUser.Address = Security.CryptoUtils.DecodeUserString(x.Address, x);
                loginUser.City = Security.CryptoUtils.DecodeUserString(x.City, x);
                loginUser.Country = Security.CryptoUtils.DecodeUserString(x.Country, x);
                loginUser.PostalCode = Security.CryptoUtils.DecodeUserString(x.PostalCode, x);
                loginUser.AboutMe = Security.CryptoUtils.DecodeUserString(x.AboutMe, x);
                loginUser.Facebook = Security.CryptoUtils.DecodeUserString(x.Facebook, x);
                loginUser.Twitter = Security.CryptoUtils.DecodeUserString(x.Twitter, x);
                loginUser.Github = Security.CryptoUtils.DecodeUserString(x.Github, x);
                loginUser.Skype = Security.CryptoUtils.DecodeUserString(x.Skype, x);
                loginUser.Googleplus = Security.CryptoUtils.DecodeUserString(x.Googleplus, x);
                loginUser.Linkedin = Security.CryptoUtils.DecodeUserString(x.Linkedin, x);
                loginUser.DateRegister = x.DateRegister;
                loginUser.LastModification = x.LastModification;
                loginUser.RandomKey = x.RandomKey;
                loginUser.PasswordHash = x.PasswordHash;
                loginUser.isPublic = x.isPublic;

                /// Clear Session
                Session.Clear();
                /// Create new Session
                Session["User"] = loginUser;
                UpdatedSuccess = true;
                /// Set error message and show it
                user_error.Attributes.Add("class", "text-success text-center");
                user_error.InnerHtml = "Profile updated.";
                user_error.Visible = true;
                Response.Redirect(Request.RawUrl);

            }
            /// Passwords do not match
            else if (user_name.Text == "" || user_surname.Text == "")
            {
                user_error.Visible = true;
                user_error.InnerText = "First and last name have to be filled.";
            } /// Some error
            else
            {
                user_error.Visible = true;
                user_error.InnerText = "There was an error.";
            }
        }

        protected void user_updatepasswordbtn_Click(object sender, EventArgs e)
        {
            /// Get current user
            Controllers.Users.Users DU = Session["User"] as Controllers.Users.Users;

            /// Filter user list with user
            var x = Controllers.Users.Users.uLTest.Single(u => u.Id == DU.Id);

            if (user_password.Text != "" && user_repeatpassword.Text != "")
            {
                if (Security.CryptoUtils.SHA256HashStringForUTF8String(user_currentpassword.Text) == x.PasswordHash)
                {
                    if (user_password.Text == user_repeatpassword.Text)
                    {
                        x.PasswordHash = Security.CryptoUtils.SHA256HashStringForUTF8String(user_password.Text);

                        Session.Clear();
                        Session.Abandon();
                        Response.Redirect("/Views/Login/Login.aspx");
                    }
                    else
                    {
                        user_error.Visible = true;
                        user_error.InnerText = "Passwords dont match.";
                    }
                }
                else
                {
                    user_error.Visible = true;
                    user_error.InnerText = "Incorrect current password.";
                }
            }
            else
            {
                user_error.Visible = true;
                user_error.InnerText = "Password does not match.";
            }
        }
    }
}