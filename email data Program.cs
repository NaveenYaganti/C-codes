using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Email_data_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            string email;
            Console.WriteLine("Enter your email id");
            email = Console.ReadLine();
            if (IsValidEmail(email))
            {
                Console.WriteLine("entered email is valid");
            }
            else
                Console.WriteLine("entered email is not valid");

            Console.ReadLine();
        }

        public static bool IsValidEmail(string email)
        {
            
            if (string.IsNullOrWhiteSpace(email))
                return false;
            try
            { 
            if (Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                return true;
            }
            else
                return false;
            }
            catch(Exception e)
            {
                return false;
            }
            /*try
            {
                // Normalize the domain
                /*email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }
                
            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }*/
        }
    }
}

