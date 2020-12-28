using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_Person
{
    class Person
    {
        private string firstName;
        private string lastName;
        private string emailAddress;
        private DateTime dOB;


        public Person()
        {

        }
        public Person(string firstName, string lastName, string emailAddress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
        }
        public Person(string firstName, string lastName, DateTime dOB)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.DOB = dOB;
        }

        public Person(string firstName, string lastName, string emailAddress, DateTime dOB)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.DOB = dOB;
        }


        //public  string DOB { get => dOB.ToString(); set => dOB = new DateTime(Convert.ToInt32(value.Substring(0,4)), Convert.ToInt32(value.Substring(4, 2)),Convert.ToInt32(value.Substring(6,2))); }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public DateTime DOB { get => dOB; set => dOB = value; }

        public bool Adult
        {
            get
            {
                if ((DateTime.Today.Year - dOB.Year) >= 18)
                    return true;
                else 
                    return false;
            }
        }

        

        public string SunSign
        {
            get
            {
                switch (dOB.Month)
                {

                    case 1:
                        if (dOB.Day <= 20)
                        {
                            return "Capricorn";
                        }
                        else
                            return "Aquarius";
                    //break;
                    case 2:
                        if (dOB.Day <= 18)
                        {
                            return "Aquarius";
                        }
                        else
                            return "Pisces";

                    default:
                        return "null";
                }

            }
        }
            public bool BirthDay
        {
            get
            {
                if ((dOB.Month == DateTime.Today.Month) && (dOB.Day == DateTime.Today.Day))
                {
                    return true;
                }
                else
                    return false;
            }
        }

        public string ScreenName
        {
            get
            {
                string screenName;
                screenName = firstName.Substring(0, 4) + dOB.Month.ToString();
                return screenName;
            }
        }


    }

    interface IPayable
    {
         double RetrieveDueAmount();
        void AddToDueAmount(int dueAmount);
        void PaymentAddress(string address);
    }

    class Employee : Person, IPayable
    {
        private double salary;
        private string mailingAddress;
        private double dueAmount;

        public Employee(string fName, string lName, string email, double salary, double dueAmount, string mAdress)
        {
            base.FirstName = fName;
            base.LastName = lName;
            base.EmailAddress = email;
            this.salary = salary;
            this.dueAmount = dueAmount;
            this.mailingAddress = mAdress;

        }
        public Employee()
        {
            dueAmount = 0.0;
        }
        public double Salary 
        { 
            get
            {
                return (salary - dueAmount);
            }
            set => salary = value; 
        }
        public string MailingAddress
        { 
            get => mailingAddress; 
            set => mailingAddress = value; 
        }


        public void AddToDueAmount(int dueAmount)
        {
            this.dueAmount += dueAmount;
        }

        public void PaymentAddress(string address)
        {
            this.mailingAddress = address;
        }

        public double RetrieveDueAmount()
        {
            return dueAmount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string fName, lName, email, dOB;
            /*
            Console.WriteLine("Enter the First Name");
            fName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            lName = Console.ReadLine();
            Console.WriteLine("Enter the Email Address");
            email = Console.ReadLine();
            Console.WriteLine("Enter the date of birth in the format year, month and day");
            dOB = Console.ReadLine();

            DateTime dT = new DateTime(Convert.ToInt32(dOB.Substring(0, 4)), Convert.ToInt32(dOB.Substring(4, 2)), Convert.ToInt32(dOB.Substring(6, 2)));


            Person p1 = new Person(fName, lName, email, dT);
            Console.WriteLine("The person is an adult? : " + p1.Adult);
            Console.WriteLine("The sunsign:" + p1.SunSign);
            Console.WriteLine("Toad is BirthDay?:" + p1.BirthDay);
            Console.WriteLine("The allotted screen name:" + p1.ScreenName);
            */
            //employee class related
            Employee e1 = new Employee("Sunil", "T", "sun@gmail.com", 20000.00, 2456.0, "bengaluru");
            Console.WriteLine("Salary:" + e1.Salary);
            Console.WriteLine(e1.ScreenName);
            Console.ReadLine();

        }
    }
}
