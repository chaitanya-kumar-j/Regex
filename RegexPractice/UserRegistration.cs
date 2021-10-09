using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    class UserRegistration
    {
        const string NAME_FORMAT = "^[A-Z]{1}[a-z]{2,}$";
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
    }
}
