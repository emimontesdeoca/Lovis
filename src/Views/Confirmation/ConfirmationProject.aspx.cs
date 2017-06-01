using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lovis.Views.Confirmation
{
    public partial class ConfirmationProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fullPATH = HttpContext.Current.Request.Url.AbsoluteUri;
            string[] splitnpu = fullPATH.Split('=');
            try
            {
                new Controllers.UserLicense.Confirmation.Confirmation().Activate(splitnpu[1]);
            }
            catch (Exception)
            {
            }

            Response.Redirect("~/Views/Login/Login.aspx");
        }
    }
}