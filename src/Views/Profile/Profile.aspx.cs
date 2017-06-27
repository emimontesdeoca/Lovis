using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lovis.Views.Profile
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Controllers.Users.Users u = Session["User"] as Controllers.Users.Users;

            user_username.Text = u.Username;
            user_surname.Text = u.Surname;
            user_skype.Text = u.Skype;
            user_name.Text = u.Name;
            user_linkedin.Text = u.Linkedin;
            user_googleplus.Text = u.Googleplus;
            user_gh.Text = u.Github;
            user_fb.Text = u.Facebook;
            user_cp.Text = u.PostalCode;
            user_country.Text = u.Country;
            user_city.Text = u.City;
            user_address.Text = u.Address;
            user_aboutme.Text = u.AboutMe;
            user_company.Text = "Not yet.";
            user_tw.Text = u.Twitter;


        }
    }
}