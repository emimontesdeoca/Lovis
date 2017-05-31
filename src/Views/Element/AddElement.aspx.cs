using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lovis.Views.Proyects.Element
{
    public partial class AddElement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /// Get current userç
            Controllers.Users.Users CU = Session["User"] as Controllers.Users.Users;

            /// Set error message to false
            adde_error.Visible = false;

            /// Get proyect from session
            Controllers.Proyects.Proyects cP = Session["Proyect"] as Controllers.Proyects.Proyects;
            if (cP == null)
            {
                Response.Redirect("~/Views/Dashboard/Dashboard.aspx");
            }
            else
            {
                /// Set page title from session
                pagetitle.Text = cP.Title;

                /// Fill all the dropowns by backend
                /// Types
                adde_type.Items.Add(new ListItem("Bug", "Bug")); ///
                adde_type.Items.Add(new ListItem("Feature", "Feature")); ///
                adde_type.Items.Add(new ListItem("Support", "Support")); ///
                adde_type.Items.Add(new ListItem("Review", "Review")); //
                adde_type.Items.Add(new ListItem("Defect", "Defect")); ///
                adde_type.Items.Add(new ListItem("Patch", "Patch")); ///
                adde_type.Items.Add(new ListItem("Changes", "Changes")); ///
                adde_type.Items.Add(new ListItem("Documentation", "Documentation"));

                /// Priorities
                adde_priority.Items.Add(new ListItem("Low", "Low"));
                adde_priority.Items.Add(new ListItem("Normal", "Normal"));
                adde_priority.Items.Add(new ListItem("High", "High"));
                adde_priority.Items.Add(new ListItem("Critical", "Critical"));
                /// States
                /// 
                adde_state.Items.Add(new ListItem("New", "New"));
                adde_state.Items.Add(new ListItem("In-Progress", "In-Progress"));
                adde_state.Items.Add(new ListItem("Resolved", "Resolved"));
                adde_state.Items.Add(new ListItem("Test", "Test"));
                adde_state.Items.Add(new ListItem("Closed", "Closed"));
                /// Assigned

                /// Get the people from the proyect
                var query = (from lUL in Controllers.Users.Users.uLTest
                             join UL in Controllers.UserLicense.UserLicense.lUL on lUL.Id equals UL.IdUser
                             where UL.IdLicense == cP.IdLicense
                             select lUL).ToList();
                foreach (Controllers.Users.Users u in query)
                {
                    ListItem l = new ListItem(Security.CryptoUtils.DecodeUserString(u.Name, u) + " " + Security.CryptoUtils.DecodeUserString(u.Surname, u), u.Id);
                    adde_assignedto.Items.Add(l);
                }
            }
        }

        protected void adde_create_Click(object sender, EventArgs e)
        {
            Controllers.Proyects.Proyects cP = Session["Proyect"] as Controllers.Proyects.Proyects;

            if (adde_datestart.Text == "" || adde_datestart == null)
            {
                adde_error.InnerText = "Start date must be filled.";
            }
            else if (adde_datefinish.Text == "" || adde_datefinish.Text == null)
            {
                adde_error.InnerText = "Finish date must be filled.";
            }
            else
            {
                new Controllers.Elements.Elements(adde_title.Text, adde_type.SelectedValue, adde_state.SelectedValue, adde_priority.SelectedValue, adde_assignedto.SelectedValue, adde_summary.Text, Convert.ToDateTime(adde_datestart.Text), Convert.ToDateTime(adde_datefinish.Text), cP);

                /// Redirecto to dashboard
                string fullPATH = HttpContext.Current.Request.Url.AbsoluteUri;
                string[] splitnpu = fullPATH.Split('=');
                Response.Redirect("~/Views/Proyects/Proyects.aspx?id=" + splitnpu[1]);
            }
        }
    }
}