using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2.Model
{
    public class Race
    {
        public int ID { get; set; }

        public string Aeroport { get; set; }

        public string Departure { get; set; }

        public string Destination { get; set; }

        public DateTime DepartureDateTime { get; set; }

        public DateTime DestinationDateTime { get; set; }

        public TimeSpan DelayTimeSpan { get; set; }

        public Race()
        {

        }

        public Race(string token)
        {
            string[] data = token.Split(new string[] { RaceManagment.CrazyToken }, StringSplitOptions.RemoveEmptyEntries);
            ID = int.Parse(data[0]);
            Aeroport = data[1];
            Departure = data[2];
            Destination = data[3];
            DepartureDateTime = DateTime.Parse(data[4]);
            DestinationDateTime = DateTime.Parse(data[5]);
            DelayTimeSpan = TimeSpan.Parse(data[6]);
        }

        public string CorrectDepartureDateTime
        {
            get
            {
                return (DepartureDateTime + DelayTimeSpan).ToString("dd.MM.yyyy HH:mm") + (DelayTimeSpan.TotalSeconds > 0 ? string.Format(" (задержка на {0} минут)", DelayTimeSpan.TotalMinutes) : "");
            }
        }

        public string CorrectDestinationDateTime
        {
            get
            {
                return (DestinationDateTime + DelayTimeSpan).ToString("dd.MM.yyyy HH:mm");
            }
        }
    }
}