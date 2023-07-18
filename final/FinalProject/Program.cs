using System;
using System.Collections.Generic;
using System.IO;

namespace LifePlanner
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            User theUser = new User();

            string userSelection = "0";
            bool alive = true;  
            
            //If/when the load/save feature is implemented, there will be code that would check to see if a user has already been created.
            Console.WriteLine("Welcome to LifePlanner!");
            if (!CheckUserFile("SaveFileUser.txt"))
            {
                theUser.CreatePerson();                
            }
            else
            {
                theUser = ReadUserFromFile("SaveFileUser.txt");
            }

            List<Goal> goals = ReadGoalsFromFile("SaveFileGoals.txt", theUser);
            List<Task> tasks = ReadTasksFromFile("SaveFileTasks.txt");
            List<Person> people = new List<Person>();
            List<Event> iEvents = new List<Event>();

            while(alive)
            {
                Console.Clear();
                Console.WriteLine("Welcome to LifePlanner!");
                Console.WriteLine("(System autosaves)");
                Console.WriteLine("--Menu--");
                Console.WriteLine("1. Create");
                Console.WriteLine("2. Modify");
                Console.WriteLine("3. List");
                Console.WriteLine("4. Manual Save");
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
                        Console.WriteLine("3. ");//Event
                        Console.WriteLine("4. Create New Person");
                        Console.WriteLine("5. Go back\n");
                        userSelection = Console.ReadLine();

                        if (userSelection != "5")
                        {
                            switch (userSelection)
                            {
                                //Goals
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("What type of goal would you like this to be?");
                                    Console.WriteLine("1. Primary Goal");
                                    Console.WriteLine("2. Secondary Goal");
                                    Console.WriteLine("3. A 'Me' Goal");
                                    Console.WriteLine("4. A Friend Goal");
                                    Console.WriteLine("5. Go Back");
                                    Console.WriteLine("");
                                    string goalSelection = Console.ReadLine();
                                    Console.WriteLine("\nWhat is the name of your goal? ");
                                    string name = Console.ReadLine();
                                    Console.WriteLine("Give a description for your goal: ");
                                    string description = Console.ReadLine();
                                    Console.WriteLine("When would you like to achieve this goal? ");
                                    string dueDate = Console.ReadLine();
                                    

                                    if (goalSelection != "5")
                                    {
                                        switch (goalSelection)
                                        {
                                            case "1":
                                                PrimaryGoal newPrimaryGoal = new PrimaryGoal(name, description, dueDate);
                                                newPrimaryGoal.AddTasks();
                                                goals.Add(newPrimaryGoal);
                                                break;
                                            case "2":
                                                SecondaryGoal newSecondaryGoal = new SecondaryGoal(name, description, dueDate);
                                                newSecondaryGoal.AddTasks();
                                                goals.Add(newSecondaryGoal);
                                                break;
                                            case "3":
                                                YouGoal newYouGoal = new YouGoal(name, description, dueDate, theUser);
                                                newYouGoal.AddTasks();
                                                goals.Add(newYouGoal);
                                                break;
                                            case "4":
                                                Friend newFriend = new Friend();
                                                newFriend.CreatePerson();                                                
                                                FriendGoal newFriendGoal = new FriendGoal(name, description, dueDate, newFriend);
                                                newFriendGoal.AddTasks();
                                                goals.Add(newFriendGoal);
                                                break;
                                            case "5":
                                                break;
                                        }
                                        SaveGoalsToFile("SaveFileGoals.txt", goals);

                                        Console.ReadLine();
                                    }

                                    else
                                    {
                                        Console.WriteLine("Going back...");
                                    }

                                    break;

                                //Tasks
                                case "2":
                                    Task newTask = new Task();
                                    tasks.Add(newTask);
                                    SaveTasksToFile("SaveFileTasks.txt", tasks);
                                    break;

                                case "3":
                                    break;

                                case "4":
                                    break;

                                case "5":
                                    break;
                            }

                        }

                        else
                        {
                            Console.WriteLine("Going back...");
                        }
                        break;

                    //Modify
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
                                Console.Clear();
                                Console.WriteLine("Choose a goal to modify: ");
                                int goalCount = 1;
                                foreach (Goal goal in goals)
                                {
                                    Console.WriteLine($"{goalCount}. {goal.Name} ({goal.GoalType}) ");
                                    Console.WriteLine("");
                                    goalCount++;
                                }
                                SaveGoalsToFile("SaveFileGoals.txt", goals);
                                break;

                            case "2":
                                Console.Clear();
                                Console.WriteLine("Choose a task to modify: ");
                                int taskCount = 1;
                                foreach (Task task in tasks)
                                {
                                    Console.WriteLine($"{taskCount}. {task.Name} ");
                                    Console.WriteLine("");
                                    taskCount++;
                                }
                                SaveTasksToFile("SaveFileTasks.txt", tasks);
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
                    case "3":

                    Console.Clear();
                        Console.WriteLine("What would you like to list?");
                        Console.WriteLine("1. My Goals");
                        Console.WriteLine("2. My Tasks");
                        Console.WriteLine("3. An Event");
                        Console.WriteLine("4. A Person");
                        Console.WriteLine("5. Go back\n");
                        userSelection = Console.ReadLine();

                        switch (userSelection)
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("");
                                foreach (Goal goal in goals)
                                {
                                    Console.WriteLine($"{goal.GoalType}: ");
                                    goal.PresentGoal();
                                    Console.WriteLine("");
                                }
                                break;

                            case "2":
                                Console.Clear();
                                Console.WriteLine("");
                                foreach(Task task in tasks)
                                {
                                    Console.WriteLine(task.PresentTask());
                                    Console.WriteLine("");
                                }
                                break;

                            case "3":
                                break;

                            case "4":
                                break;

                            case "5":
                                break;
                        }
                        

                        Console.WriteLine("Press ENTER to go back to the menu.");
                        Console.ReadLine();

                        break;

                    //Save
                    case "4":
                        SaveUserToFile("SaveFileUser.txt", theUser);
                        SaveTasksToFile("SaveFileTasks.txt", tasks);
                        SaveGoalsToFile("SaveFileGoals.txt", goals);
                        Console.Clear();

                        break;

                    //Load
                    case "5":
                        Console.Clear();
                        ReadTasksFromFile("SaveFileTasks.txt");

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

        public static void SaveUserToFile(string saveFile, User user)
        {
            using (StreamWriter outputFile = new StreamWriter(saveFile))
            {

                outputFile.WriteLine($"{user.GetType().Name}[/]{user.FirstName}[/]{user.LastName}[/]{user.Birthday}[/]{user.PhoneNumber}[/]{user.Email}");                
            }
        }

        public static void SaveTasksToFile(string saveFile, List<Task> tasks)
        {
            using (StreamWriter outputFile = new StreamWriter(saveFile))
            {
                foreach (Task task in tasks) 
                {
                    string line = $"{task.Name}[/]{task.Completed}";                    

                    outputFile.WriteLine(line);
                }

            }
        }

        public static void SaveGoalsToFile(string saveFile, List<Goal> goals)
        {
            using (StreamWriter outputFile = new StreamWriter(saveFile))
            {
                foreach (Goal goal in goals) 
                {
                    string lineTasks = "";
                    foreach (Task task in goal.Tasks)
                    {
                        lineTasks = lineTasks + "[/]TASK[/]" + task.ToString();
                    }
                    string line = goal.ToString() + lineTasks;

                    outputFile.WriteLine(line);
                }
            }
        }

        public static bool CheckUserFile(string saveFile)
        {
           using (StreamReader reader = new StreamReader(saveFile))
                {
                    string line;
                    if ((line = reader.ReadLine()) != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

        }

        public static User ReadUserFromFile(string saveFile)
        {
            using (StreamReader reader = new StreamReader(saveFile))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(new string[] { "[/]" }, StringSplitOptions.None);

                    string firstName = values[1];
                    string lastName = values[2];
                    string birthday = values[3];
                    string email = values[4];
                    string phone = values[5];

                    User importedUser = new User(firstName, lastName, birthday, email, phone);

                    return importedUser;
                }

            }     

            return null;   
        }

        public static List<Task> ReadTasksFromFile(string saveFile)
        {
            List<Task> tasks = new List<Task>();

            try
            {
                using (StreamReader reader = new StreamReader(saveFile))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(new string[] { "[/]" }, StringSplitOptions.None);

                        string name = values[0];
                        bool completed = bool.Parse(values[1]);

                        Task task = new Task(name, completed);
                        tasks.Add(task);
                    }

                }
                return tasks;
            }

            catch
            {
                Console.WriteLine("\nInvalid file type.");

                Console.WriteLine("\nPress ENTER to continue.");
                Console.ReadLine();

                return null;
            }

        }

        public static List<Goal> ReadGoalsFromFile(string saveFile, User user)
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
                        string dueDate = values[3];

                        Goal goal;
                        switch (goalType)
                        {
                            case "PRIMARY GOAL":
                                goal = new PrimaryGoal(name, description, dueDate);
                                break;
                            case "SECONDARY GOAL":
                                goal = new SecondaryGoal(name, description, dueDate);
                                break;
                            case "'ME' GOAL":                                
                                goal = new YouGoal(name, description, dueDate, user);
                                break;
                            case "FRIEND GOAL":
                                Friend friend = new Friend(values[4], values[5], values[6], values[7]);
                                goal = new FriendGoal(name, description, dueDate, friend);
                                break;
                            default:
                                throw new ArgumentException("Unknown goal type: " + goalType);
                        }
                        
                        goals.Add(goal);
                    }

                }
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