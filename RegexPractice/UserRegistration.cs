using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    public class UserRegistration
    {
        const string NAME_FORMAT = "^[A-Z]{1}[a-z]{2,}$";
        const string EMAIL_ID_FORMAT = "^[A-Z0-9a-z]{1,}([.#$^_-][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2,3})?$";
        const string MOBILE_NUMBER_FORMAT = "^[0-9]{2}[ ][6-9][0-9]{9}$";
        const string PASSWORD_FORMAT = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[^A-Za-z0-9]){1}.{8,}$";

        public bool FirstNameValidation(string firstName)
        {
            if (Regex.IsMatch(firstName, NAME_FORMAT))
            {
                Console.WriteLine("Entered firstname is as per requirements");
                return true;
            }
            throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_FIRSTNAME, "Entered firstname is not as per requirements");
        }
        public bool LastNameValidation(string lastName)
        {
            if (Regex.IsMatch(lastName, NAME_FORMAT))
            {
                Console.WriteLine("Entered lastname is as per requirements");
                return true;
            }
            throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_LASTNAME, "Entered lastname is not as per requirements");
        }
        public bool EmailValidation(string emailId)
        {
            Console.WriteLine(emailId);
            if (Regex.IsMatch(emailId, EMAIL_ID_FORMAT))
            {
                Console.WriteLine("Entered email is as per requirements");
                return true;
            }
            throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_EMAIL, "Entered email is not as per requirements");
        }
        public bool MobileNumberValidation(string mobileNumber)
        {
            if (Regex.IsMatch(mobileNumber, MOBILE_NUMBER_FORMAT))
            {
                Console.WriteLine("Entered Mobile number is as per requirements");
                return true;
            }
            throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_MOBILENUMBER, "Entered Mobile number is not as per requirements");
        }
        public bool PasswordValidation(string password)
        {
            if (Regex.IsMatch(password, PASSWORD_FORMAT))
            {
                Console.WriteLine("Entered Password is as per requirements");
                return true;
            }
            throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_PASSWORD, "Entered Password is not as per requirements");
        }
    }
}
