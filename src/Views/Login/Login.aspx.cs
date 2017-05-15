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
                /// Test acc
                new Controllers.Users.Users("test@test.com", "test", "Emiliano", "Montesdeoca").New();
                new Controllers.Users.Users("test2@test.com", "test", "Luis", "Sanfiel").New();

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
                Session["User"] = new Controllers.Users.Users().DecodeUser(u);
                Response.Redirect("~/Views/Dashboard/Dashboard.aspx");
            }

        }
    }
}