using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Model
{
    public class Appointment
    {
        private static int autoIncrement;
        public int Id { get; private set; }
        public DateTime Date { get; set; }

        // AdvisorType property is kept for general use
        public string AdvisorType { get; set; }

        // Specific properties for CFP and CFA
        public bool IsCFP { get; set; }
        public bool IsCFA { get; set; }

        public Appointment()
        {
            autoIncrement++;
            Id = autoIncrement;
        }

        // Additional constructor to initialize CFP or CFA
        public Appointment(bool isCFP, bool isCFA) : this()
        {
            IsCFP = isCFP;
            IsCFA = isCFA;

            // Automatically set AdvisorType based on CFP or CFA
            if (IsCFP)
            {
                AdvisorType = "CFP";
            }
            else if (IsCFA)
            {
                AdvisorType = "CFA";
            }
        }

        public Appointment(DateTime dateTime, string advisorType)
        {
            AdvisorType = advisorType;
        }
    }
}

