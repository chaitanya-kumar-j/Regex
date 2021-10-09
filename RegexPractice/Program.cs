using System;

namespace RegexPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool isRun = true;
            while (isRun)
            {
                UserRegistration user = new UserRegistration();
                Console.WriteLine("Select Program Option: (1. First name Validation, 2. Last name Validation)");
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
                    default:
                        isRun = !isRun;
                        break;
                }
            }
        }
    }
}
