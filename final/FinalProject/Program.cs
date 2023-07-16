using System;
using System.Collections.Generic;
using System.IO;

namespace LifePlanner
{
    class Program
    {
        public static void Main(string[] args)
        {
            User theUser = new User();
            List<Goal> goals = new List<Goal>();
            List<Person> people = new List<Person>();

            string userSelection = "0";
            bool alive = true;  
            
            
            Console.WriteLine("Welcome to LifePlanner!");                
            theUser.CreatePerson();                


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
                                Console.Clear();
                                Console.WriteLine("What is the name of your goal? ");
                                string name = Console.ReadLine();
                                Console.WriteLine("Give a description for your goal: ");
                                string description = Console.ReadLine();
                                Console.WriteLine("When would you like to achieve this goal? ");
                                string dueDate = Console.ReadLine();
                                Console.WriteLine("What type of goal would you like this to be?");
                                Console.WriteLine("1. Primary Goal");
                                Console.WriteLine("2. Secondary Goal");
                                Console.WriteLine("3. A 'Me' Goal");
                                Console.WriteLine("4. A Friend Goal");
                                Console.WriteLine("5. Go Back");
                                Console.WriteLine("");
                                string goalSelection = Console.ReadLine();

                                switch (goalSelection)
                                {
                                    case "1":
                                        PrimaryGoal newGoal = new PrimaryGoal(name, description, dueDate);
                                        newGoal.SetNewGoal();
                                        goals.Add(newGoal);
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

                                Console.Clear();
                                Console.WriteLine("");
                                foreach (Goal goal in goals)
                                {
                                    Console.WriteLine(goal.ToString());
                                }

                                Console.ReadLine();
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


        //If time permits, complete this. If not, leave energy for actual application development.
        public static void SaveToFile(string saveFile, User user, List<Goal> goals, List<Event> events,
                                        List<Task> tasks, List<Person> people)
        {
            using (StreamWriter outputFile = new StreamWriter(saveFile))
            {

                outputFile.WriteLine($"{user.GetType().Name}[/]{user.FirstName}[/]{user.LastName}[/]{user.Birthday}[/]{user.PhoneNumber}[/]{user.Email}");                

                /*
                foreach (Goal goal in goals) 
                {
                    string line;

                    if (goal is UrgentGoal urgentGoal)
                    {
                        line = $"{goal.GetType().Name}[/]{goal.Name}[/]{goal.Description}[/]{goal.DueDate}[/]{goal.Tasks}";
                    }
                    else
                    {
                        line = $"{goal.GetType().Name}[/]{goal.Name}[/]{goal.Description}[/]{goal.DueDate}[/]{goal.Tasks}";
                    }

                    outputFile.WriteLine(line);
                }

                /*
                outputFile.WriteLine("TASKS");

                foreach (Task task in tasks) 
                {
                    string line = $"{task.Name}[/]{task.Description}[/]{task.DueDate}[/]{task.LinkedGoal}";                    

                    outputFile.WriteLine(line);
                }

                /*
                outputFile.WriteLine("EVENTS");

                foreach (Event iEvent in events) 
                {
                    string line = $"{iEvent.Name}[/]{iEvent.Description}[/]{iEvent.CreationDate}[/]{iEvent.ModificationDate}"
                    +$"[/]{iEvent.StartTime}[/]{iEvent.EndTime}[/]{iEvent.LinkedGoal}";                    

                    outputFile.WriteLine(line);
                }

                /*
                outputFile.WriteLine("PEOPLE");

                foreach (Person person in people) 
                {
                    string line = $"{person.FirstName}[/]{person.LastName}[/]{person.PhoneNumber}[/]{person.EMail}";                    

                    outputFile.WriteLine(line);
                }
                */
            }
        }

        public static List<Person> ReadPeopleFromFile(string saveFile) 
        {
            List<Person> people = new List<Person>();

            try
            {
                using (StreamReader reader = new StreamReader(saveFile))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {

                        string[] values = line.Split(new string[] { "[/]" }, StringSplitOptions.None);

                        string goalType = values[0];
                        string name = values[1];
                        string description = values[2];
                        int points = int.Parse(values[3]);
                        bool isCompleted = bool.Parse(values[4]);

                    }

                }
                Console.WriteLine("\nYour file has been loaded.\n\nPress ENTER to continue.");
                Console.ReadLine();

                return people;
            }

            catch
            {
                Console.WriteLine("\nInvalid file type.");

                Console.WriteLine("\nPress ENTER to continue.");
                Console.ReadLine();

                return null;
            }
        }

        public static List<Goal> ReadGoalsFromFile(string saveFile)
        {
            List<Goal> goals = new List<Goal>();

            try
            {
                using (StreamReader reader = new StreamReader(saveFile))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {

                        string[] values = line.Split(new string[] { "[/]" }, StringSplitOptions.None);

                        string goalType = values[0];
                        string name = values[1];
                        string description = values[2];
                        int points = int.Parse(values[3]);
                        bool isCompleted = bool.Parse(values[4]);

                    }

                }
                Console.WriteLine("\nYour file has been loaded.\n\nPress ENTER to continue.");
                Console.ReadLine();

                return goals;
            }

            catch
            {
                Console.WriteLine("\nInvalid file type.");

                Console.WriteLine("\nPress ENTER to continue.");
                Console.ReadLine();

                return null;
            }

        }


    }
}