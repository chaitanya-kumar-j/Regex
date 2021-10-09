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
                Console.WriteLine("Select Program Option: (1. FirstName Validation)");
                int programOption = Convert.ToInt32(Console.ReadLine());
                switch (programOption)
                {
                    case 1:
                        Console.WriteLine("Enter your first name:");
                        string firstName = Console.ReadLine();
                        user.FirstNameValidation(firstName);
                        break;
                    default:
                        isRun = !isRun;
                        break;
                }
            }
        }
    }
}
