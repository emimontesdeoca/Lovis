using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lovis.Views.Proyects.Element
{
    public partial class ManageElement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                managee_error.Visible = false;

                Controllers.Users.Users CU = Session["User"] as Controllers.Users.Users;
                /// Someone tried to access this web without the correct id

                /// Get ID from URL
                string fullPATH = HttpContext.Current.Request.Url.AbsoluteUri;
                string[] splitnpu = fullPATH.Split('=');

                /// Get project from ID
                Controllers.Proyects.Proyects cP = Session["Proyect"] as Controllers.Proyects.Proyects;
                if (cP == null)
                {
                    Response.Redirect("~/Views/Dashboard/dashboard.aspx");
                }
                else
                {
                    /// Fill all the dropowns by backend
                    /// Types
                    managee_type.Items.Add(new ListItem("Bug", "Bug")); /// 1
                    managee_type.Items.Add(new ListItem("Feature", "Feature")); /// 5
                    managee_type.Items.Add(new ListItem("Support", "Support")); /// 6
                    managee_type.Items.Add(new ListItem("Review", "Review")); /// 7
                    managee_type.Items.Add(new ListItem("Defect", "Defect")); ///2
                    managee_type.Items.Add(new ListItem("Patch", "Patch")); /// 3
                    managee_type.Items.Add(new ListItem("Changes", "Changes")); /// 4
                    managee_type.Items.Add(new ListItem("Documentation", "Documentation")); /// 8
                                                                                            /// Priorities
                    managee_priority.Items.Add(new ListItem("Low", "Low"));
                    managee_priority.Items.Add(new ListItem("Normal", "Normal"));
                    managee_priority.Items.Add(new ListItem("High", "High"));
                    managee_priority.Items.Add(new ListItem("Critical", "Critical"));
                    /// States
                    managee_state.Items.Add(new ListItem("New", "New"));
                    managee_state.Items.Add(new ListItem("Analysis", "Analysis"));
                    managee_state.Items.Add(new ListItem("In-Progress", "In-Progress"));
                    managee_state.Items.Add(new ListItem("Resolved", "Resolved"));
                    managee_state.Items.Add(new ListItem("Test", "Test"));
                    managee_state.Items.Add(new ListItem("Closed", "Closed"));
                    /// Assigned
                    /// Get the people from the proyect
                    var query = (from lUL in Controllers.Users.Users.uLTest
                                 join UL in Controllers.UserLicense.UserLicense.lUL on lUL.Id equals UL.IdUser
                                 where UL.IdLicense == cP.IdLicense
                                 select lUL).Distinct().ToList();
                    foreach (Controllers.Users.Users u in query)
                    {
                        ListItem l = new ListItem(Security.CryptoUtils.DecodeUserString(u.Name, u) + " " + Security.CryptoUtils.DecodeUserString(u.Surname, u), u.Id);
                        managee_assignedto.Items.Add(l);
                    }


                    /// Check if user has access to this task by checking if the user itself has access to this PROJECT
                    foreach (Controllers.UserLicense.UserLicense UL in Controllers.UserLicense.UserLicense.lUL)
                    {
                        /// Find Userlicenses of user
                        if (UL.IdUser == CU.Id)
                        {
                            /// Find License of UserLicense
                            var y = Controllers.License.License.lL.Single(l => l.IdLicense == UL.IdLicense);


                            /// Filter proyects for Licenses of user
                            foreach (Controllers.Proyects.Proyects P in Controllers.Proyects.Proyects.lP)
                            {
                                /// If userlicense and proyect licenese are == that means is our proyect
                                if (P.IdLicense == y.IdLicense)
                                {
                                    try
                                    {
                                        var x = Controllers.Elements.Elements.lE.Single(a => a.Id == splitnpu[1] && a.IdProyect == cP.Id);

                                        managee_title.Text = Security.CryptoUtils.DecodeElementString(cP, x.Title);
                                        managee_summary.Text = Security.CryptoUtils.DecodeElementString(cP, x.Summary);
                                        managee_type.SelectedValue = Security.CryptoUtils.DecodeElementString(cP, x.Type);
                                        managee_state.SelectedValue = Security.CryptoUtils.DecodeElementString(cP, x.State);
                                        managee_priority.SelectedValue = Security.CryptoUtils.DecodeElementString(cP, x.Priority);
                                        managee_datestart.Text = x.DateStart.ToString();
                                        managee_datefinish.Text = x.DateFinish.ToString();
                                        managee_assignedto.SelectedValue = Security.CryptoUtils.DecodeElementString(cP, x.AssignedTo);


                                    }
                                    catch (Exception)
                                    {
                                        Response.Redirect("~/Views/Dashboard/dashboard.aspx");
                                    }
                                }
                            }
                        }
                    }
                    pagetitle.Text = managee_title.Text + " - Lovis";
                }
            }
        }

        protected void managee_update_btn_Click(object sender, EventArgs e)
        {
            Controllers.Users.Users CU = Session["User"] as Controllers.Users.Users;

            /// Get the current proyect previously.
            Controllers.Proyects.Proyects cP = Session["Proyect"] as Controllers.Proyects.Proyects;

            /// Get ID from URL
            string fullPATH = HttpContext.Current.Request.Url.AbsoluteUri;
            string[] splitnpu = fullPATH.Split('=');

            /// Find the proyect where this current proyect id match some proyect ID
            var x = Controllers.Elements.Elements.lE.Single(a => a.Id == splitnpu[1]);

            /// Change everything and encode it again.
            x.Title = Security.CryptoUtils.EncodeElementString(cP, managee_title.Text);
            x.Summary = Security.CryptoUtils.EncodeElementString(cP, managee_summary.Text);
            x.Type = Security.CryptoUtils.EncodeElementString(cP, managee_type.SelectedValue);
            x.State = Security.CryptoUtils.EncodeElementString(cP, managee_state.SelectedValue);
            x.Priority = Security.CryptoUtils.EncodeElementString(cP, managee_priority.SelectedValue);
            x.DateFinish = Convert.ToDateTime(managee_datefinish.Text);

            var nu = Controllers.Users.Users.uLTest.Single(a => a.Id == managee_assignedto.SelectedValue);

            if (managee_assignedto.SelectedValue != Security.CryptoUtils.DecodeElementString(cP, x.AssignedTo))
            {
                x.AssignedTo = Security.CryptoUtils.EncodeElementString(cP, managee_assignedto.Text);
                Controllers.Email.Email.SendEmailElementNotification(Security.CryptoUtils.DecodeUsername(nu.Username), cP.Title, managee_title.Text,
                    managee_summary.Text, managee_type.SelectedValue, managee_state.SelectedValue,
                    managee_priority.SelectedValue, Security.CryptoUtils.DecodeUserString(nu.Name, nu) + " " + Security.CryptoUtils.DecodeUserString(nu.Surname, nu), x.DateCreation.ToString(),
                    managee_datestart.Text, managee_datefinish.Text, Security.CryptoUtils.DecodeUserString(nu.Name, nu) + " " + Security.CryptoUtils.DecodeUserString(nu.Surname, nu), CU.Name + " " + CU.Surname);
            }

            Response.Redirect("~/Views/Proyects/Proyects.aspx?id=" + cP.IdLicense);
        }
    }
}