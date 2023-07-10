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
                Console.WriteLine($"Total points: {PointTotal}\n");
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
                        Console.Clear();
                        CompleteGoal();
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
            Console.WriteLine("4. Quit and go back");
            Console.WriteLine("");

            string userSelection = Console.ReadLine();

            if (userSelection != "4")
            {
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

            else
            {
                Console.WriteLine("Going back...");
            }
        }

        private static void CompleteGoal()
        {
            Console.Clear();
            Console.WriteLine("Complete a goal!\n");

            if(_goals.Count == 0)
            {
                Console.WriteLine("There are no goals. Hence, none can be marked as complete.");
                Console.WriteLine("\nPress ENTER to go back.");
                Console.ReadLine();
                return;
            }

            else 
            {
                Console.WriteLine("Which goal have you completed? \n");

                for (int i = 0; i < _goals.Count; i++)
                {
                    if (_goals[i].Completed is false)
                    {
                        Console.WriteLine($"{i + 1}. {_goals[i].Name}");
                    }

                    else
                    {
                        Console.WriteLine($"{i + 1}. {_goals[i].Name} (COMPLETED)");
                    }
                }

                Console.WriteLine();
                Console.Write("(Enter the goal number): ");
                int goalNumber = int.Parse(Console.ReadLine());

                if (goalNumber <= 0 || goalNumber > _goals.Count)
                {
                    Console.WriteLine("Invalid input. Try again.");
                    Console.WriteLine("\nPress ENTER to go back.");
                    Console.ReadLine();
                    return;
                }

                else 
                {
                    if (_goals[goalNumber - 1].Completed is false)
                    {
                        Goal selectedGoal = _goals[goalNumber - 1];
                        selectedGoal.Complete();
                        PointTotal += selectedGoal.Points;

                        Console.WriteLine($"Congratulations! You have completed {selectedGoal.Name}, which earned you {selectedGoal.Points} points!");
                    }

                    else
                    {
                        Console.WriteLine("Sorry! You've already completed this goal.");
                    }

                    Console.WriteLine("\nPress ENTER to go back.");
                    Console.ReadLine();
                    return;
                }

            }

        }
    
    }
}