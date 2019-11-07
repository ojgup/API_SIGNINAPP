using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_SIGNINAPP.Models
{
    public class Session
    {

        public string Date { get; set; }
        public int ClassID { get; set; }

        public Session(string date, int classID)
        {
            this.Date = date;
            this.ClassID = classID;
        }


    }
}
