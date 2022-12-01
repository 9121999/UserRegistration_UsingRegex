namespace UserRegistrationUsingRegex
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
                Console.WriteLine("1.First Name \n 2.Last Name \n 3.Mobile Number \n 4.Email \n 5.PassWord");
                 choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter your First name");
                        string firstName = Console.ReadLine();
                        userFirstName.ValidateFirstName(firstName);
                        break;
                    case 2:
                        Console.WriteLine("Enter your Last name");
                        string lastName = Console.ReadLine();
                        userFirstName.ValidateLastName(lastName);
                        break;
                    case 3:
                        Console.WriteLine("Enter your Mobile Number");
                        string mobileNumber = Console.ReadLine();
                        userFirstName.ValidateMobileNumber(mobileNumber);
                        break;
                    case 4:
                        Console.WriteLine("Enter your Email Id");
                        string email = Console.ReadLine();
                        userFirstName.ValidateEmail(email);
                        break;
                    case 5:
                        Console.WriteLine("Enter your Password");
                        string password = Console.ReadLine();
                        userFirstName.ValidatePassword(password);
                        break;
                }
            }
        }
    }
}

  
              