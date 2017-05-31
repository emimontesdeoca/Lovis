using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lovis.Views.Proyects
{
    public partial class AddProyect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Controllers.Users.Users CU = Session["User"] as Controllers.Users.Users;
            addp_owner.Text = CU.Name + " " + CU.Surname + " (" + CU.Username + ")";
        }

        protected void addp_create_Click(object sender, EventArgs e)
        {
            // Get User
            Controllers.Users.Users CU = Session["User"] as Controllers.Users.Users;

            // Create proyect to license
            Controllers.Proyects.Proyects a = new Controllers.Proyects.Proyects(addp_title.Text, addp_summary.Text, addp_owner.Text, addp_webiste.Text, addp_repository.Text, addp_support.Text, CU);
            Controllers.Email.Email.SendEmailProjectNotification(CU.Username, addp_title.Text, addp_summary.Text, addp_owner.Text, addp_webiste.Text, addp_repository.Text, addp_support.Text, CU.Name + " " + CU.Surname);
            //Redirecto to dashboard
            Response.Redirect("~/Views/Proyects/Proyects.aspx?id=" + a.IdLicense);
        }
    }
}