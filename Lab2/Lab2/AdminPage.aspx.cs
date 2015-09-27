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

namespace Lab2
{
    public partial class AdminPage : System.Web.UI.Page
    {
        private static string _fileWithID = @"C:\Storage\id.txt";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("~/login.aspx");
            }
        }

        public IEnumerable<Race> GetRaces()
        {
            return RaceManagment.GetAllRaces();
        }

        public void UpdateRace(int ID)
        {
            Race race = new Race();
            if (TryUpdateModel(race, new FormValueProvider(ModelBindingExecutionContext)))
            {
                RaceManagment.UpdateRace(race);
            }
        }

        public void DeleteRace(int ID)
        {
            RaceManagment.DeleteRace(ID);
        }

        public void InsertRace()
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