using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace Lab2
{
    public partial class AdminPage : System.Web.UI.Page
    {
        private static string _fileWithID = WebConfigurationManager.AppSettings["_idData"];

        protected void Page_Load(object sender, EventArgs e)    // Session check
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("~/login.aspx");
            }
        }

        public IEnumerable<Race> GetRaces() // Get races
        {
            return RaceManagment.GetAllRaces();
        }

        public void UpdateRace(int ID)  // Update race
        {
            Race race = new Race();
            if (TryUpdateModel(race, new FormValueProvider(ModelBindingExecutionContext)))
            {
                RaceManagment.UpdateRace(race);
            }
        }

        public void DeleteRace(int ID)  // Delete race
        {
            RaceManagment.DeleteRace(ID);
        }

        public void InsertRace()    // New race
        {
            Race race = new Race();
            if (TryUpdateModel(race, new FormValueProvider(ModelBindingExecutionContext)))
            {
                int id = int.Parse(File.ReadAllText(_fileWithID));
                race.ID = id;
                id++;
                File.WriteAllText(_fileWithID, id.ToString());
                RaceManagment.AddRace(race);
            }
        }
    }
}