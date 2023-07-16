using System;

namespace LifePlanner
{
    public class User : Person
    {
        private string _birthday;

        public string Birthday
        {
            get { return _birthday;  }
            set { _birthday = value; } 
        }

        public override void CreatePerson()
        {
            Console.WriteLine("What is your first name? ");
            FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            LastName = Console.ReadLine();

            Console.WriteLine("What's your birthday? ");
            Birthday = Console.ReadLine();
            Console.WriteLine("What's your email?");
            Email = Console.ReadLine();
            Console.WriteLine("What is your phone number?");
            PhoneNumber = Console.ReadLine();

            Console.WriteLine($"Welcome {FirstName}! ");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
        }
    }
}
