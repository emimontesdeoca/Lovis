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

            }
            else
            {
                Session["User"] = null;

            }
        }

        protected void login_loginbtn_Click(object sender, EventArgs e)
        {
            Controllers.Users.Users u = new Controllers.Users.Users().isUser(login_username.Text, login_password.Text);
            if (u != null)
            {
                Controllers.Users.Users loginUser = new Controllers.Users.Users();

                loginUser.Id = u.Id;
                loginUser.Username = Security.CryptoUtils.DecodeUsername(u.Username);
                loginUser.Name = Security.CryptoUtils.DecodeUserString(u.Name, u);
                loginUser.Surname = Security.CryptoUtils.DecodeUserString(u.Surname, u);
                loginUser.DateRegister = u.DateRegister;
                loginUser.PasswordHash = u.PasswordHash;
                loginUser.RandomKey = u.RandomKey;

                Session["User"] = loginUser;
                Response.Redirect("~/Views/Dashboard/Dashboard.aspx");
            }

        }
    }
}