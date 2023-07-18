using System;

namespace LifePlanner
{
    public class Friend : Person
    {
        public Friend() {}

        public Friend(string first, string last, string phone, string email)
        {
            FirstName = first;
            LastName = last;
            PhoneNumber = phone;
            Email = email;
        }
        
        public override void CreatePerson()
        {
            Console.WriteLine("What is their first name? ");
            FirstName = Console.ReadLine();
            Console.WriteLine("What is their last name?");
            LastName = Console.ReadLine();

            Console.WriteLine("What's their email?");
            Email = Console.ReadLine();
            Console.WriteLine("What is their phone number?");
            Email = Console.ReadLine();

            Console.WriteLine($"{FirstName} has been added! ");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
        }
    }
}
