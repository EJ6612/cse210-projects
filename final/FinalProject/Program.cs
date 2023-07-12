using System;

namespace LifePlanner
{
    class Program
    {
        public void Main(string[] args)
        {
            string userSelection = "0";
            bool alive = true;

            while(alive)
            {
                Console.Clear();
                Console.WriteLine("Welcome to LifePlanner!");
                Console.WriteLine("(System autosaves)");
                Console.WriteLine("--Menu--");
                Console.WriteLine("1. Create");
                Console.WriteLine("2. Modify");
                Console.WriteLine("3. List");
                Console.WriteLine("4. ");
                Console.WriteLine("5. ");
                Console.WriteLine("6. Quit");
                Console.WriteLine("");
                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    //Create
                    case "1":
                        Console.Clear();
                        Console.WriteLine("What would you like to create?");
                        Console.WriteLine("1. Create New Goal");
                        Console.WriteLine("2. Create New Task");
                        Console.WriteLine("3. Create New Event");
                        Console.WriteLine("4. Create New Person");
                        Console.WriteLine("5. Go back\n");
                        userSelection = Console.ReadLine();

                        switch (userSelection)
                        {
                            case "1":
                                break;

                            case "2":
                                break;

                            case "3":
                                break;

                            case "4":
                                break;

                            case "5":
                                break;
                        }


                        break;

                    //List
                    case "2":
                        Console.Clear();
                        Console.WriteLine("What would you like to modify?");
                        Console.WriteLine("1. A Goal");
                        Console.WriteLine("2. A Task");
                        Console.WriteLine("3. An Event");
                        Console.WriteLine("4. A Person");
                        Console.WriteLine("5. Go back\n");
                        userSelection = Console.ReadLine();

                        switch (userSelection)
                        {
                            case "1":
                                break;

                            case "2":
                                break;

                            case "3":
                                break;

                            case "4":
                                break;

                            case "5":
                                break;
                        }

                        break;

                    //Save
                    case "3":
                        Console.Clear();

                        break;

                    //Load
                    case "4":
                        Console.Clear();

                        break;

                    //Record
                    case "5":
                        Console.Clear();

                        break;

                    //Quit
                    case "6":
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