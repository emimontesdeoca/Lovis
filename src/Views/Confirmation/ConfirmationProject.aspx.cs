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
                text.InnerText = "Confirmation complete, redirecting to Lovis in 5 seconds...";
            }
            catch (Exception)
            {
                text.InnerText = "There was an error, redirecting to Lovis in 5 seconds...";
            }
            System.Threading.Thread.Sleep(5000);

            Response.Redirect("~/Views/Login/Login.aspx");
        }
    }
}