using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lovis.Views.Proyects
{
    public partial class ManageProyect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
                        /// If they are equal (just in case someone paste another proyectID)
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

                /// Get current Proyect from the Session["Proyect"]
                /// Set the summary on the view
                managep_summary.Text = cP.Summary;
                managep_webiste.Text = cP.Website;
                managep_owner.Text = cP.Owner;
                managep_title.Text = cP.Title;
                managep_support.Text = cP.Support;
                managep_repository.Text = cP.Repository;
                Master.cpTITLE = cP.Title;

                /// Get the people from the proyect
                var query = (from lUL in Controllers.Users.Users.uLTest
                             join UL in Controllers.UserLicense.UserLicense.lUL on lUL.Id equals UL.IdUser
                             where UL.IdLicense == cP.IdLicense
                             select lUL).ToList();

                StringBuilder sb = new StringBuilder();

                /// Build the string with all the contributors
                foreach (Controllers.Users.Users pU in query)
                {
                    Controllers.Users.Users ppU = new Controllers.Users.Users();
                    ppU.Username = Security.CryptoUtils.DecodeUsername(pU.Username);
                    ppU.Name = Security.CryptoUtils.DecodeUserString(pU.Name, pU);
                    ppU.Surname = Security.CryptoUtils.DecodeUserString(pU.Surname, pU);

                    sb.AppendFormat("{0} {1}, ", ppU.Name, ppU.Surname);
                }
                /// Remove last ,
                sb.Remove(sb.Length - 2, 2);
                /// Set it
                proyect_people.InnerText = sb.ToString();
            }


        }

        protected void managep_update_Click(object sender, EventArgs e)
        {
            /// Get the current proyect previously.
            Controllers.Proyects.Proyects CP = Session["Proyect"] as Controllers.Proyects.Proyects;

            /// Find the proyect where this current proyect id match some proyect ID
            var x = Controllers.Proyects.Proyects.lP.Single(a => a.Id == CP.Id);

            /// Change everything and encode it again.
            x.Title = Security.CryptoUtils.EncodeElementString(x, managep_title.Text);
            x.Summary = Security.CryptoUtils.EncodeElementString(x, managep_summary.Text);
            x.Owner = Security.CryptoUtils.EncodeElementString(x, managep_owner.Text);
            x.Website = Security.CryptoUtils.EncodeElementString(x, managep_webiste.Text);
            x.Repository = Security.CryptoUtils.EncodeElementString(x, managep_repository.Text);
            x.Support = Security.CryptoUtils.EncodeElementString(x, managep_support.Text);

        }

        protected void managep_btn_delete_Click(object sender, EventArgs e)
        {
            Controllers.Proyects.Proyects CP = Session["Proyect"] as Controllers.Proyects.Proyects;
            if (managep_name_delete.Text == CP.Title)
            {
                if (managep_checkbox_delete.Checked)
                {
                    /// Remove project
                    Controllers.Proyects.Proyects.lP.Remove(Controllers.Proyects.Proyects.lP.Single(a => a.Id == CP.Id));

                    /// Remove userlicense to this user
                    Controllers.Users.Users CU = Session["User"] as Controllers.Users.Users;
                    Controllers.UserLicense.UserLicense.lUL.Remove(Controllers.UserLicense.UserLicense.lUL.Single(b => b.IdUser == CU.Id && b.IdLicense == CP.IdLicense));

                    Response.Redirect("~/Views/Dashboard/dashboard.aspx");
                }
            }
        }

        protected void managep_addcollaborators_Click(object sender, EventArgs e)
        {
            string[] cb = managep_invitepeople.Text.Split(' ');
            string fullPATH = HttpContext.Current.Request.Url.AbsoluteUri;
            string[] splitnpu = fullPATH.Split('=');
            foreach (string t in cb)
            {
                var x = Controllers.Users.Users.uLTest.Single(a => Security.CryptoUtils.DecodeUsername(a.Username) == t);
                new Controllers.UserLicense.UserLicense(x.Id, splitnpu[1], 1, false);
            }

            Response.Redirect("~/Views/Proyects/Proyects.aspx?id=" + splitnpu[1]);
        }
    }
}