using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace Lab2
{
    public partial class do_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["username"] == WebConfigurationManager.AppSettings["_login"] && Request["userpassword"] == WebConfigurationManager.AppSettings["_password"])
            {
                Session.Add("admin", new object());
                Response.Redirect("AdminPage.aspx");
            }
            else
            {
                Session.Add("error", true);
                Response.Redirect("login.aspx");
            }
        }
    }
}