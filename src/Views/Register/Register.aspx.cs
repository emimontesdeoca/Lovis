using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lovis.Views.Register
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void reg_register_Click(object sender, EventArgs e)
        {
            if (reg_password.Text == reg_repeatpassword.Text && reg_checkbox.Checked)
            {
                new Controllers.Users.Confirmation.Confirmation(reg_email.Text, reg_password.Text, reg_name.Text, reg_surname.Text).Add();
                //new Controllers.Users.Users(reg_email.Text, reg_password.Text, reg_name.Text, reg_surname.Text).New();
                Response.Redirect("~/Views/Login/Login.aspx");
            }
        }
    }
}