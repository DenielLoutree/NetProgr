using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string GetErrorMessage()
        {
            string result = null;
            if (Session["error"] != null)
            {
                result = string.Format("<div><label class=\"text_label\" style=\"color: red\">{0}</label></div><br>", "Невозможно выполнить вход. Введены некорректные данные.");
                Session.Remove("error");
            }
            return result;
        }
    }
}