using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    class UserRegistration
    {
        const string NAME_FORMAT = "^[A-Z]{1}[a-z]{2,}$";
        const string EMAIL_ID_FORMAT = "^[A-Z0-9a-z]{1,}([.#$^_-][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        const string MOBILE_NUMBER_FORMAT = "^[0-9]{2}[ ][6-9][0-9]{9}$";
        const string PASSWORD_FORMAT = "^.{8,}$";

        public void FirstNameValidation(string firstName)
        {
            if (Regex.IsMatch(firstName, NAME_FORMAT))
            {
                Console.WriteLine("Entered firstname is as per requirements");
                return;
            }
            Console.WriteLine("Entered firstname is not as per requirements");
        }
        public void LastNameValidation(string lastName)
        {
            if (Regex.IsMatch(lastName, NAME_FORMAT))
            {
                Console.WriteLine("Entered lastname is as per requirements");
                return;
            }
            Console.WriteLine("Entered lastname is not as per requirements");
        }
        public void EmailValidation(string emailId)
        {
            if (Regex.IsMatch(emailId, EMAIL_ID_FORMAT))
            {
                Console.WriteLine("Entered email is as per requirements");
                return;
            }
            Console.WriteLine("Entered email is not as per requirements");
        }
        public void MobileNumberValidation(string mobileNumber)
        {
            if (Regex.IsMatch(mobileNumber, MOBILE_NUMBER_FORMAT))
            {
                Console.WriteLine("Entered Mobile number is as per requirements");
                return;
            }
            Console.WriteLine("Entered Mobile number is not as per requirements");
        }
        public void PasswordValidation(string password)
        {
            if (Regex.IsMatch(password, PASSWORD_FORMAT))
            {
                Console.WriteLine("Entered Password is as per requirements");
                return;
            }
            Console.WriteLine("Entered Password is not as per requirements");
        }
    }
}
