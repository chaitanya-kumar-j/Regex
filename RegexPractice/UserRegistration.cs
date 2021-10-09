using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    class UserRegistration
    {
        const string NAME_FORMAT = "^[A-Z]{1}[a-z]{3,}$";
        public void FirstNameValidation(string firstName)
        {
            if (Regex.IsMatch(firstName, NAME_FORMAT))
            {
                Console.WriteLine("Entered firstname is as per requirements");
                return;
            }
            Console.WriteLine("Entered firstname is not as per requirements");
        }
    }
}
