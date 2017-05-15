using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lovis.Views.Shared
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("/Views/Login/Login.aspx");
            }
            else
            {
                /// Get proyects from user to build sidebar
            }
        }

        protected void master_logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("/Views/Login/Login.aspx");
        }
    }
}