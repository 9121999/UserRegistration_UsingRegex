﻿namespace UserRegistrationUsingRegex
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            UserRegistration userFirstName = new UserRegistration();
            bool flag = true;
            int choice;
            while (flag)
            {
              
                Console.WriteLine("Select option");
                Console.WriteLine("1.First Name");
                 choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter your First name");
                        string firstName = Console.ReadLine();
                        userFirstName.ValidateFirstName(firstName);
                        break;
                }
            }
        }
    }
}

  
              