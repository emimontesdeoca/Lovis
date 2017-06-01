using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lovis.Views.Confirmation
{
    public partial class Confirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fullPATH = HttpContext.Current.Request.Url.AbsoluteUri;
            string[] splitnpu = fullPATH.Split('?');

            string[] token = splitnpu[1].Split('=');
            string[] username = splitnpu[2].Split('=');

            new Controllers.Users.Confirmation.Confirmation().Activate(token[1], username[1]);

            Response.Redirect("~/Views/Login/Login.aspx");


        }
    }
}