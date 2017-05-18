using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lovis.Views.Proyects
{
    public partial class ManageProyect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Controllers.Users.Users CU = Session["User"] as Controllers.Users.Users;
            /// Someone tried to access this web without the correct id

            /// Get ID from URL
            string fullPATH = HttpContext.Current.Request.Url.AbsoluteUri;
            string[] splitnpu = fullPATH.Split('=');

            /// Get project from ID
            Controllers.Proyects.Proyects cP = new Controllers.Proyects.Proyects();

            try
            {
                /// Get userlicence in common of this proyect and this user
                var query2 = (from lUL in Controllers.UserLicense.UserLicense.lUL
                              where lUL.IdUser == CU.Id && lUL.IdLicense == splitnpu[1]
                              select lUL).First();
                try
                {
                    /// If they are equal ( just in case someone paste another proyectID
                    var x = Controllers.Proyects.Proyects.lP.Single(a => a.IdLicense == splitnpu[1] && a.IdLicense == query2.IdLicense);

                    cP.Id = x.Id;
                    cP.IdLicense = x.IdLicense;
                    cP.Title = x.Title;
                    cP.Summary = x.Summary;
                    cP.Owner = x.Owner;
                    cP.Website = x.Website;
                    cP.Repository = x.Repository;
                    cP.Support = x.Support;

                    cP.Title = Security.CryptoUtils.DecodeElementString(cP, cP.Title);
                    cP.Summary = Security.CryptoUtils.DecodeElementString(cP, cP.Summary);
                    cP.Owner = Security.CryptoUtils.DecodeElementString(cP, cP.Owner);
                    cP.Website = Security.CryptoUtils.DecodeElementString(cP, cP.Website);
                    cP.Repository = Security.CryptoUtils.DecodeElementString(cP, cP.Repository);
                    cP.Support = Security.CryptoUtils.DecodeElementString(cP, cP.Support);


                    /// If everything works lets save Session
                    Session["Proyect"] = cP as Controllers.Proyects.Proyects;

                    Master.cpTITLE = cP.Title;
                }
                catch (Exception)
                {
                    /// GTFO
                    Session.Abandon();
                    Session.Clear();
                    Response.Redirect("/Views/Login/Login.aspx");

                }
            }
            catch (Exception)
            {
                Response.Redirect("/Views/Error/404.aspx");
            }
        }
    }
}