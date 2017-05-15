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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("/Views/Login/Login.aspx");
            }

            Controllers.Users.Users DU = Session["User"] as Controllers.Users.Users;
            user_username.Text = DU.Username;
            user_name.Text = DU.Name;
            user_surname.Text = DU.Surname;
        }
    }


}