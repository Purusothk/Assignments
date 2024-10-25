using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment
{
    internal class CustomerValidation
    {
        public void run()
        {


            Console.WriteLine("Enter customer phone number:");
            string phoneNumber = Console.ReadLine();

            if (ValidatePhoneNumber(phoneNumber))
            {
                Console.WriteLine("Phone number is valid.");
            }
            else
            {
                Console.WriteLine("Phone number is invalid. Please enter a 10-digit number.");
            }

            // Additional validations can be added here
            Console.WriteLine("Enter customer email:");
            string email = Console.ReadLine();

            if (ValidateEmail(email))
            {
                Console.WriteLine("Email is valid.");
            }
            else
            {
                Console.WriteLine("Email is invalid. Please follow the correct format.");
            }

            Console.WriteLine("Enter date of birth (DD/MM/YYYY):");
            string dob = Console.ReadLine();

            if (ValidateDOB(dob))
            {
                Console.WriteLine("Date of birth is valid.");
            }
            else
            {
                Console.WriteLine("Date of birth is invalid. Please follow the correct format.");
            }
        }







        public Boolean ValidatePhoneNumber(string str)
        {
            string pattern = @"^\d{10}$";
            if (Regex.IsMatch(str, pattern))
                return true;
            return false;
        }


        public Boolean ValidateEmail(string str)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";
            if (Regex.IsMatch(str, pattern))
                return true;
            return false;
        }



        public Boolean ValidateDOB(string str)
        {
            string pattern = @"^ (0[1-9] | [12][0-9] | 3[0-1]) / (0[1-9] | [1][0-2]) / ([19|20]\d\d)$";
            if (Regex.IsMatch(str, pattern))
                return true;
            return false;
        }
    }
}
