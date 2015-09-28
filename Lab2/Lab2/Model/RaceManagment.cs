using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Lab2.Model
{
    public class RaceManagment
    {
        private static string _fileWithRaces = WebConfigurationManager.AppSettings["_raceData"];

        private static string _crazyToken = "___haafnc___";

        public static string CrazyToken // Separator
        {
            get
            {
                return _crazyToken;
            }
        }

        public static List<Race> GetAllRaces()  // Returns all races data
        {
            List<Race> result = new List<Race>();
            string[] lines = File.ReadAllLines(_fileWithRaces);
            foreach (string x in lines)
            {
                result.Add(new Race(x));
            }
            return result;
        }

        public static void DeleteRace(int id)   // Delete race
        {
            List<Race> races = GetAllRaces();
            races.RemoveAll(x => x.ID == id);
            File.Delete(_fileWithRaces);
            foreach (Race x in races)
            {
                AddRace(x);
            }
        }

        public static void AddRace(Race race)   // Add race
        {
            string token = "";
            string[] strings = { race.ID.ToString(), race.Airport, race.Departure, race.Destination, race.DepartureDateTime.ToString(), race.DestinationDateTime.ToString(), race.DelayTimeSpan.ToString() };
            foreach (string x in strings)
            {
                token += x;
                token += _crazyToken;
            }
            File.AppendAllLines(_fileWithRaces, new string[] { token });
        }

        public static void UpdateRace(Race race)    // Modify race
        {
            List<Race> races = GetAllRaces();
            races.RemoveAll(x => x.ID == race.ID);
            races.Add(race);
            File.Delete(_fileWithRaces);
            foreach (Race x in races)
            {
                AddRace(x);
            }
        }
    }
}