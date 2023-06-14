using System;

namespace Develop04 
{
    class Program
    {
        static void Main(string[] args)
        {
            string userSelection = "0";
            bool alive = true;
            int userInputSeconds = 0;

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
                        Console.WriteLine("How many seconds?");
                        userInputSeconds = Int16.Parse(Console.ReadLine());

                        Breathing breathing = new Breathing(userInputSeconds);

                        Console.WriteLine("");
                        Console.WriteLine("Press ENTER to go back to the menu.");
                        Console.ReadLine();
                        userInputSeconds = 0;
                        break;

                    case "2":

                        Console.WriteLine("");
                        Console.WriteLine("Press ENTER to go back to the menu.");
                        Console.ReadLine();
                        userInputSeconds = 0;
                    break;

                    case "3":

                        Console.WriteLine("");
                        Console.WriteLine("Press ENTER to go back to the menu.");
                        Console.ReadLine();
                        userInputSeconds = 0;
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