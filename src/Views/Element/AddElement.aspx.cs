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
            Controllers.Proyects.Proyects cP = Session["Proyect"] as Controllers.Proyects.Proyects;

            pagetitle.Text = cP.Title;
        }

        protected void adde_create_Click(object sender, EventArgs e)
        {
            Controllers.Proyects.Proyects cP = Session["Proyect"] as Controllers.Proyects.Proyects;

            new Controllers.Elements.Elements(adde_title.Text, adde_type.Text, adde_state.Text, adde_priority.Text, adde_assignedto.Text, adde_summary.Text, Convert.ToDateTime(adde_datestart.Text), Convert.ToDateTime(adde_datefinish.Text), cP);


        }
    }
}