using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_SIGNINAPP.Models
{
    public class Classes
    {
        public int ClassID { get; set; }
        public string Day { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }

        public Classes(int classID, string day, string startTime, string endTime, string name, string label)
        {
            this.ClassID = classID;
            this.Day = day;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Name = name;
            this.Label = label;
        }
    }

}
