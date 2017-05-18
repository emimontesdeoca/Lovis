using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lovis.Views.Shared
{
    public partial class Master : System.Web.UI.MasterPage
    {
        public static List<Controllers.Proyects.Proyects> CuLPP = new List<Controllers.Proyects.Proyects>();
        protected static string _cpTITLE = "Proeyect";
        public string cpTITLE
        {
            get { return _cpTITLE; }
            set { _cpTITLE = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            CuLPP.Clear();
            if (Session["User"] == null)
            {
                Session.Abandon();
                Session.Clear();
                Response.Redirect("/Views/Login/Login.aspx");
            }
            else
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////////////
                ///
                /// GLOBAL VARIABLES TO USE IN MASTERPAGE
                ///
                ////////////////////////////////////////////////////////////////////////////////////////////////////////

                #region GLOBAL VARIALBES

                Controllers.Users.Users CU = Session["User"] as Controllers.Users.Users;
                string url = HttpContext.Current.Request.Url.AbsolutePath;

                #endregion

                ////////////////////////////////////////////////////////////////////////////////////////////////////////
                ///
                /// HANDLE 404 ERROR 
                ///
                ////////////////////////////////////////////////////////////////////////////////////////////////////////

                #region HANDLE 404 ERRO

                if (Response.TrySkipIisCustomErrors == true || Response.Status == "404 Not Found" || Response.StatusCode == 404)
                {
                    Response.Redirect("/Views/Error/404.aspx");
                }

                #endregion

                ////////////////////////////////////////////////////////////////////////////////////////////////////////
                ///
                /// START BUILD SIDEBAR
                ///
                ////////////////////////////////////////////////////////////////////////////////////////////////////////

                #region BUILD SIDEBAR


                /// Get proyects from user to build sidebar
                List<Controllers.Proyects.Proyects> CuLP = new List<Controllers.Proyects.Proyects>();

                foreach (Controllers.UserLicense.UserLicense UL in Controllers.UserLicense.UserLicense.lUL)
                {
                    /// Find Userlicenses of user
                    if (UL.IdUser == CU.Id)
                    {
                        /// Finde License of UserLicense
                        var x = Controllers.License.License.lL.Single(l => l.IdLicense == UL.IdLicense);

                        /// Filter proyects for Licenses of user
                        foreach (Controllers.Proyects.Proyects P in Controllers.Proyects.Proyects.lP)
                        {
                            /// If userlicense and proyect licenese are == that means is our proyect
                            if (P.IdLicense == x.IdLicense)
                            {
                                CuLP.Add(P);
                            }
                        }
                    }
                }

               

                foreach (Controllers.Proyects.Proyects DP in CuLP)
                {
                    Controllers.Proyects.Proyects dP = new Controllers.Proyects.Proyects();

                    dP.Id = DP.Id;
                    dP.IdLicense = DP.IdLicense;
                    dP.Title = Security.CryptoUtils.DecodeElementString(DP, DP.Title);
                    dP.Summary = Security.CryptoUtils.DecodeElementString(DP, DP.Summary);

                    CuLPP.Add(dP);
                }

                GenerateSidebar(HttpContext.Current.Request.Url.AbsolutePath);

                #endregion

                ////////////////////////////////////////////////////////////////////////////////////////////////////////
                ///
                /// START SET PROJECT SESSION IF WEB IS PROYECTS.ASPX
                ///
                ////////////////////////////////////////////////////////////////////////////////////////////////////////

                ////////////////////////////////////////////////////////////////////////////////////////////////////////
                ///
                /// BUILD TOP BAR
                ///
                ////////////////////////////////////////////////////////////////////////////////////////////////////////

                #region PROJECT SESSION

                if (url == "/Views/Proyects/Proyects.aspx")
                {
                    Master_pagetitle.InnerText = "Lovis > Projects > " + cpTITLE;
                }
                else
                {
                    /// Else its normal path
                    string[] splitedurl = url.Split('/');
                    string[] splitpath = splitedurl.Last().Split('.');
                    Master_pagetitle.InnerText = splitpath[0];

                    /// Some fixes

                    if (splitpath[0] == "AddProyect")
                    {
                        Master_pagetitle.InnerText = "Lovis > Proyects > Add proyect";

                    }
                    if (splitpath[0] == "User")
                    {
                        Master_pagetitle.InnerText = "Lovis > Account > Manage";

                    }
                    if (splitpath[0] == "404")
                    {
                        Master_pagetitle.InnerText = "Page not found";

                    }
                    if (splitpath[0] == "Dashboard")
                    {
                        Master_pagetitle.InnerText = "Lovis > Dashboard";

                    }
                }

                #endregion

                #region BUILD TOPBAR

                /// Set name in account dropdown
                master_username.InnerText = CU.Name;

                #endregion
            }
        }

        private void GenerateSidebar(string url)
        {
            //string[] urlsplit = url.Split('/');

            string dashboardurl = "/Views/Dashboard/Dashboard.aspx";
            string newproyecturl = "/Views/Proyects/AddProyect.aspx";
            string proyecturl = "/Views/Proyects/Proyects.aspx";
            string BASEproyecturl = "/Views/Proyects/Proyects.aspx";

            /// Fix for proyect
            if (url == proyecturl)
            {
                string fullPATH = HttpContext.Current.Request.Url.AbsoluteUri;
                string[] splitnpu = fullPATH.Split('=');
                proyecturl = proyecturl + "?id=" + splitnpu[1];
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(@"<ul class=""nav"">");

            /// Dashboard
            if (dashboardurl == url)
            {
                sb.Append(@"<li class=""active"">");
            }
            else
            {
                sb.Append("<li>");
            }
            sb.AppendFormat(@"<a  href=""{0}"">", dashboardurl);
            sb.Append(@"<i class=""material-icons"">dashboard</i>");
            sb.Append(@"<p class=""text-capitalize""> Dashboard</p>");
            sb.Append(@"</a>");
            sb.Append("</li>");

            /// New proyect


            if (newproyecturl == url)
            {
                sb.Append(@"<li class=""active"">");
            }
            else
            {
                sb.Append("<li>");
            }
            sb.AppendFormat(@"<a href=""{0}"">", newproyecturl);
            sb.Append(@"<i class=""material-icons"">add</i>");
            sb.Append(@"<p class=""text-capitalize"">New project</p>");
            sb.Append(@"</a>");
            sb.Append("</li>");

            /// Proyects
            foreach (Controllers.Proyects.Proyects DP in CuLPP)
            {

                if (proyecturl == url + "?id=" + DP.IdLicense)
                {
                    sb.Append(@"<li class=""active"">");
                }
                else
                {
                    sb.Append("<li>");
                }
                sb.AppendFormat(@"<a href=""{0}?id={1}"">", BASEproyecturl, DP.IdLicense);
                sb.Append(@"<i class=""material-icons"">assignment</i>");
                sb.AppendFormat(@"<p class=""text-capitalize"">{0}</p>", DP.Title);
                sb.Append(@"</a>");
                sb.Append("</li>");
            }
            sb.Append(@"</ul>");

            sidebarContainer.InnerHtml = sb.ToString();

        }

        protected void master_logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("/Views/Login/Login.aspx");
        }
    }
}