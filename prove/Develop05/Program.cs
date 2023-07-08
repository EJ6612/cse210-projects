using System;
using System.Collections.Generic;

namespace Develop05
{
    class Program
    {
        public static List<Goal> _goals = new List<Goal>();
        public static int PointTotal = 0;

        static void Main(string[] args)
        {
            string userSelection = "0";
            bool alive = true;

            while(alive)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1. Create");
                Console.WriteLine("2. List");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Record");
                Console.WriteLine("6. Quit");
                Console.WriteLine("");
                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    //Create
                    case "1":
                        Console.Clear();
                        CreateNewGoal();

                        break;

                    //List
                    case "2":
                        Console.Clear();
                        foreach (Goal goal in _goals)
                        {
                            Console.WriteLine(goal.ToString());
                        }                 
                        Console.ReadLine();                       
                        break;

                    //Save
                    case "3":
                        Console.Clear();
                        Transfer.SaveToFile("saveFile.txt", _goals);

                        Console.WriteLine("Files have been saved to a file!");
                        Console.ReadLine();
                        break;

                    //Load
                    case "4":
                        Console.Clear();
                        Console.WriteLine("What file would you like to load?");
                        string newFile = Console.ReadLine();

                        _goals = Transfer.ReadGoalsFromFile(newFile);
                        break;

                    //Record
                    case "5":

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
    
        public static void CreateNewGoal()
        {
            Goal goal;
            Console.WriteLine("What type of goal do you want to create? ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("");
            string userSelection = Console.ReadLine();

            Console.WriteLine("Enter the name of the goal: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a brief description: ");
            string description = Console.ReadLine();

            switch (userSelection)
            {
                //simple
                case "1":
                    goal = new Simple(name, description, 0, false);
                break;

                //simple
                case "2":
                    goal = new Eternal(name, description, 0, false);
                break;

                //simple
                case "3":
                    Console.WriteLine("How many times do you want to achieve this? ");
                    int itemCount = int.Parse(Console.ReadLine());
                    goal = new Checklist(name, description, 0, false, 0, itemCount);
                break;

                default:
                    Console.WriteLine("Invalid goal type. Try again.");
                    return;                
            }

            _goals.Add(goal);
        }
    
    }
}