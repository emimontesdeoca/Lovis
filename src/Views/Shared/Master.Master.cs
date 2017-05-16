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
                Controllers.Users.Users CU = Session["User"] as Controllers.Users.Users;
                /// Get proyects from user to build sidebar

                List<Controllers.Proyects.Proyects> CuLP = new List<Controllers.Proyects.Proyects>();

                foreach (Controllers.UserLicense.UserLicense UL in Controllers.UserLicense.UserLicense.lUL)
                {
                    /// Find Userlicenses of user
                    if (UL.IdUser == CU.Id)
                    {
                        /// Finde License of UserLicense
                        var x = Controllers.License.License.lL.Single(l => l.Id == UL.IdLicense);

                        /// Filter proyects for Licenses of user
                        foreach (Controllers.Proyects.Proyects P in Controllers.Proyects.Proyects.lP)
                        {
                            if (P.IdLicense == x.Id)
                            {
                                CuLP.Add(P);
                            }
                        }
                    }
                }
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