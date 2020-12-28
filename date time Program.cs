using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //year of birth
            int yob;
            //month of birth
            int mob;
            //day of birth
            int dob;

            //read the  date [year, month and day from the user]
            //read each of them seperately
            Console.WriteLine("Enter the year of your birth");
            yob = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the month of your birth");
            mob = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the day of your birth");
            dob = Convert.ToInt32(Console.ReadLine());

            //rCode=1 then it means the i/p date is a future date
            //rCode=2 then it means the age of the person is going >=135 years
            //rCode=0  born today
            //else its the age of the user.

            int rCode = CheckTheBirthDate(yob, mob, dob);

            switch(rCode)
            {
                case -1:
                    Console.WriteLine("You are born in this year..");
                    break;
                case 0:
                    Console.WriteLine("Hey you are born today. Welcome!!!");
                        break;
                case 1: Console.WriteLine("You have entered a future date....");
                    break;
                case 2: Console.WriteLine("Your are lucky to have lived >=135.. Impossible");
                    break;
                default: Console.WriteLine("Age of the user is: " + rCode);
                    if (TodayBirthday(mob, dob))
                        Console.WriteLine("Happy BirthDay");
                    Console.WriteLine(DisplayAstrologicalSign(mob, dob));    
                    break;
            }

            Console.ReadLine();

        }

        private static string DisplayAstrologicalSign(int mob, int dob)
        {
            

            switch(mob)
            {

                case 1:
                    if (dob <= 20)
                    {
                        return "Capricorn";
                    }
                    else
                        return "Aquarius";
                //break;
                case 2:
                    if (dob <= 18)
                    {
                        return "Aquarius";
                    }
                    else
                        return "Pisces";
                case 3:
                    if (dob <= 20)
                    {
                        return "Pisces";
                    }
                    else
                        return "Aries";


                default: return "null";

            }
        }

        //returns true if today is user's birth day
        //else false
        private static bool TodayBirthday(int mob, int dob)
        {
            //DateTime tdy = DateTime.Today;
            if (mob == DateTime.Today.Month && dob == DateTime.Today.Day)
                return true;
            else
                return false;
        }

        private static int CheckTheBirthDate(int yob, int mob, int dob)
        {
            DateTime bDate = new DateTime(yob, mob, dob);
            DateTime tDate = DateTime.Today;
            int rValue = DateTime.Compare(bDate, tDate);
            if(rValue<0)
            {
                if ((tDate.Year - bDate.Year) >= 135)
                    return 2;
                else if ((tDate.Year - bDate.Year) == 0)
                    return -1;
                else
                    return (tDate.Year - bDate.Year);
            }
            else if(rValue > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}
