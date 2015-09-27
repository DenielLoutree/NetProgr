using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] != null)
            {
                Response.Redirect("~/AdminPage.aspx");
            }
        }

        public IEnumerable<Race> GetRaces()
        {
            List<Race> races = RaceManagment.GetAllRaces();
            string key = Request["key"];
            string value = Request["value"];
            if (key != null && value != null)
            {
                if (key == "Aeroport")
                {
                    races = races.Where(x => x.Aeroport == value).ToList();
                }
                else if (key == "Departure")
                {
                    races = races.Where(x => x.Departure == value).ToList();
                }
                else if (key == "Destination")
                {
                    races = races.Where(x => x.Destination == value).ToList();
                }
                else if (key == "DepartureDateTime")
                {
                    races = races.Where(x => x.DepartureDateTime.ToString("dd.MM.yyyy HH:mm").Contains(value)).ToList();
                }
                else if (key == "DestinationDateTime")
                {
                    races = races.Where(x => x.DestinationDateTime.ToString("dd.MM.yyyy HH:mm").Contains(value)).ToList();
                }
            }
            return races;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("~/MainPage.aspx?key={0}&value={1}", DropDownList1.SelectedItem.Value, TextBox1.Text));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MainPage.aspx");
        }
    }
}