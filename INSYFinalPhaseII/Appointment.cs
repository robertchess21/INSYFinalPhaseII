using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Model
{
    public class Appointment
    {
        private static int autoIncreament;
        public int Id { get; set; }
        public DateTime date { get; set; }

        public string AdvisorType { get; set; }
        //these specify the Id, date, and advisor type for the meeting 

        public Appointment()
        {
            autoIncreament++;
            Id = autoIncreament;
        }
    }
}
