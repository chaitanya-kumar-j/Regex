using System;
using System.IO;

namespace RegexPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool isRun = true;
            while (isRun)
            {
                string emailsFilePath = @"G:\BridgeLabz\Regex\RegexPractice\ValidEmailsList.txt";
                UserRegistration user = new UserRegistration();
                Console.WriteLine("Select Program Option: (1. First name Validation, 2. Last name Validation, 3. Email validation" +
                    "\n4. Mobile number validation)");
                int programOption = Convert.ToInt32(Console.ReadLine());
                switch (programOption)
                {
                    case 1:
                        Console.WriteLine("Enter your first name:");
                        string firstName = Console.ReadLine();
                        user.FirstNameValidation(firstName);
                        break;
                    case 2:
                        Console.WriteLine("Enter your last name:");
                        string lastName = Console.ReadLine();
                        user.LastNameValidation(lastName);
                        break;
                    case 3:
                        string[] validEmailList = File.ReadAllText(emailsFilePath).Split("\n")[0].Split(",");
                        string[] inValidEmailList = File.ReadAllText(emailsFilePath).Split("\n")[1].Split(",");
                        string[] bothValidAndInValidEmailList = File.ReadAllText(emailsFilePath).Split("\n")[2].Split(",");
                        Console.WriteLine("Validation of validEmailList: ");
                        foreach (string email in validEmailList)
                        {
                            Console.Write($"\n{email} - ");
                            user.EmailValidation(email);
                        }
                        Console.WriteLine("\nValidation of inValidEmailList: ");
                        foreach (string email in inValidEmailList)
                        {
                            Console.Write($"\n{email} - ");
                            user.EmailValidation(email);
                        }
                        Console.WriteLine("\nValidation of bothValidAndInValidEmailList: ");
                        foreach (string email in bothValidAndInValidEmailList)
                        {
                            Console.Write($"\n{email} - ");
                            user.EmailValidation(email);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter your 2 digit country code space 10 digit mobile number:");
                        string mobileNumber = Console.ReadLine();
                        user.MobileNumberValidation(mobileNumber);
                        break;
                    default:
                        isRun = !isRun;
                        break;
                }
            }
        }
    }
}
