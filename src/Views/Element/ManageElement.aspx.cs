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

                /// Fill all the dropowns by backend
                /// Types
                managee_type.Items.Add(new ListItem("Bug", "Bug"));
                managee_type.Items.Add(new ListItem("Feature", "Feature"));
                managee_type.Items.Add(new ListItem("Support", "Support"));
                managee_type.Items.Add(new ListItem("Review", "Review"));
                managee_type.Items.Add(new ListItem("Defect", "Defect"));
                managee_type.Items.Add(new ListItem("Patch", "Patch"));
                managee_type.Items.Add(new ListItem("Changes", "Changes"));
                managee_type.Items.Add(new ListItem("Documentation", "Documentation"));
                /// Priorities
                managee_priority.Items.Add(new ListItem("Low", "Low"));
                managee_priority.Items.Add(new ListItem("Normal", "Normal"));
                managee_priority.Items.Add(new ListItem("High", "High"));
                managee_priority.Items.Add(new ListItem("Critical", "Critical"));
                /// States
                managee_state.Items.Add(new ListItem("New", "New"));
                managee_state.Items.Add(new ListItem("In-Progress", "In-Progress"));
                managee_state.Items.Add(new ListItem("Resolved", "Resolved"));
                managee_state.Items.Add(new ListItem("Test", "Test"));
                managee_state.Items.Add(new ListItem("Done", "Done"));
                /// Assigned
                /// Get the people from the proyect
                var query = (from lUL in Controllers.Users.Users.uLTest
                             join UL in Controllers.UserLicense.UserLicense.lUL on lUL.Id equals UL.IdUser
                             where UL.IdLicense == cP.IdLicense
                             select lUL).ToList();
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
                        }
                    }
                }
            }


        }

        protected void managee_update_Click(object sender, EventArgs e)
        {
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
            x.DateFinish = Convert.ToDateTime(Security.CryptoUtils.EncodeElementString(cP, managee_datefinish.Text));
            x.AssignedTo = Security.CryptoUtils.EncodeElementString(cP, managee_assignedto.Text);
        }
    }
}