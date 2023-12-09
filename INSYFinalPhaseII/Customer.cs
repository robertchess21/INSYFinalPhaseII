using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSYFinalPhaseII
{
    public class Customer
    {
        private static int autoIncreament;
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string SSN { get; set; }
        public string Age { get; set; }
        public string CreditScore { get; set; }
        //above is all of the customer demographics and information needed for the accounts
   
        public Customer()
        {
            autoIncreament++;
            Id = autoIncreament;
        }
    }
}