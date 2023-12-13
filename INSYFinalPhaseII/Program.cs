using ClassProject.Model;
using System.Net.Cache;
using System.Net.Sockets;

namespace INSYFinalPhaseII
{
    public class Program
    {
<<<<<<< HEAD
        
=======
        private static Customers customers;
        private static List<Appointment> appointments;
        private static List<CutomerAppointment> customerAppointments;
        private static Customer authenticatedCustomer;

        private static Customer customer;
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing...");
            Initialize(); // Create and initialize all objects ...
            Menu();
        }

        static void Initialize()
        {
            var c1 = new Customer
            {
                FirstName = "Kambiz",
                LastName = "Saffari",
                Username = "kambiz",
                Password = "1234",
                Id = "1",
                Address = "827 n 17th st",
                PhoneNumber = "1234567890",
                SSN = "1234567890",
                Age = "25",
                CreditScore = "850"
            };
            var c2 = new Customer
            {
                FirstName = "Terence",
                LastName = "Ow",
                Username = "terence",
                Password = "2345",
                Id = "2",
                Address = "829 n 15th st",
                PhoneNumber = "1134567890",
                SSN = "1134567890",
                Age = "26",
                CreditScore = "849"
            };
            var a1 = new Appointment();
            var a2 = new Appointment();
            var a3 = new Appointment();

            var ca1 = new CutomerAppointment(c1, a1);
            var ca2 = new CutomerAppointment(c1, a2);
            var ca3 = new CutomerAppointment(c2, a3);

            customers = new Customers();
            customers.customers.Add(c1);
            customers.customers.Add(c2);

            var newA1 = new Appointment(DateTime.Now.AddDays(1), "CFP");
            var newA2 = new Appointment(DateTime.Now.AddDays(2), "CFA");
            var newA3 = new Appointment(DateTime.Now.AddDays(3), "CFP");

            appointments = new List<Appointment>();
            appointments.Add(a1);
            appointments.Add(a2);
            appointments.Add(a3);

            customerAppointments = new List<CutomerAppointment>();
            customerAppointments.Add(ca1);
            customerAppointments.Add(ca2);
            customerAppointments.Add(ca3);


        }

        static void Menu()
        {
            bool done = false;

            while (!done)
            {
                Console.WriteLine("Options: Login: 1 --- Logout: 2 --- Sign Up: 3 --- Appointments: 4 --- Clear Screen: c --- Quit: q ---");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        LoginMenu();
                        break;
                    case "2":
                        LogoutMenu();
                        break;
                    case "3":
                        SignUpMenu();
                        break;
                    case "4":
                        GetCurrentAppointmentsMenu();
                        break;
                    case "c":
                        Console.Clear();
                        break;
                    case "q":
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }

            }

        }


        static void LoginMenu()
        {
            if (authenticatedCustomer == null)
            {
                Console.Write("Enter your username: ");
                string username = Console.ReadLine();
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();
                authenticatedCustomer = customers.Authenticate(username, password);
                if (authenticatedCustomer != null)
                {
                    Console.WriteLine($"Welcome {authenticatedCustomer.FirstName}");
                }
                else
                {
                    Console.WriteLine("invalid username or password");
                }
            }
            else
            {
                Console.WriteLine($"You are already logged in as {authenticatedCustomer.Username}");
            }
        }

        static void LogoutMenu()
        {
            authenticatedCustomer = null;
            Console.WriteLine("Logged out!");
        }

        static void SignUpMenu()
        {
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string LastName = Console.ReadLine();
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            Console.WriteLine("Select Advisor Type: ");
            Console.WriteLine("1. CFP");
            Console.WriteLine("2. CFA");
            Console.Write("Enter your choice (1 or 2): ");
            int advisorChoice = int.Parse(Console.ReadLine());

            string advisorType = (advisorChoice == 1) ? "CFP" : "CFA";

            var newAppointment = new Appointment(DateTime.Now.AddDays(7), advisorType);

            var newCustomer = new Customer
            {
                FirstName = firstName,
                LastName = LastName,
                Username = username,
                Password = password
            };

            customers.customers.Add(newCustomer);

            Console.WriteLine("Profile created!");

        }


        static void GetCurrentAppointmentsMenu()
        {
            if (authenticatedCustomer == null)
            {
                Console.WriteLine("You are not logged in.");
                return;
            }


            var appointmentList = customerAppointments.Where(o => o.customer.Username == authenticatedCustomer.Username);

            if (appointmentList.Count() == 0)
            {
                Console.WriteLine("0 appointment found.");
            }
            else
            {
                foreach (var appointmnet in appointmentList)
                {
                    Console.WriteLine(appointmnet.appointment.date);
                }
            }
        }




>>>>>>> 7af03c26e0c3d8b41010e1fec31e1fac2122b91b
    }
}

