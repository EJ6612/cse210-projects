using System;

namespace Develop04 
{
    class Program
    {
        static void Main(string[] args)
        {
            string userSelection = "0";
            bool alive = true;

            while(alive)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");
                Console.WriteLine("");
                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    //Breathing Activity
                    case "1":
                        Console.Clear();

                        Breathing breathing = new Breathing();
                        break;

                    case "2":
                        Console.Clear();

                        Reflection reflection = new Reflection();                        
                    break;

                    case "3":
                        Console.Clear();

                        Listing listing = new Listing();
                    break;

                    //Quit
                    case "4":
                        alive = false;
                        break;
                    
                    default:
                        Console.WriteLine("Please enter a valid option.");
                        Console.WriteLine();

                        Console.WriteLine("Press ENTER to go back to the menu.");
                        Console.ReadLine();
                        break;
                }
            }

            Console.WriteLine("Press ENTER to terminate program.");
            Console.ReadLine();
        }
    }
}