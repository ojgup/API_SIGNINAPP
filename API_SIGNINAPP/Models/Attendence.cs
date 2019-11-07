using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_SIGNINAPP.Models
{
    public class Attendence
    {
        public int Barcode { get; set; }
        public string Date { get; set; }
        public int ClassID { get; set; }
        public string Time { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public bool actionPerformed { get; set; }

        public Attendence(int barcode, string date, int classID, string time, double longitude, double latitude, bool actionperformed)
        {

        }

    }
}
