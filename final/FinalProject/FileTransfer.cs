using System;
using System.Collections.Generic;
using System.IO;

namespace LifePlanner
{
    public class FileTransfer
    {

        public static void SaveToFile(string saveFile, List<Goal> goals, List<Event> events,
                                        List<Task> tasks, List<Person> people)
        {
            using (StreamWriter outputFile = new StreamWriter(saveFile))
            {
                outputFile.WriteLine("GOALS");

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

                outputFile.WriteLine("TASKS");

                foreach (Task task in tasks) 
                {
                    string line = $"{task.Name}[/]{task.Description}[/]{task.DueDate}[/]{task.LinkedGoal}";                    

                    outputFile.WriteLine(line);
                }

                outputFile.WriteLine("EVENTS");

                foreach (Event iEvent in events) 
                {
                    string line = $"{iEvent.Name}[/]{iEvent.Description}[/]{iEvent.CreationDate}[/]{iEvent.ModificationDate}"
                    +$"[/]{iEvent.StartTime}[/]{iEvent.EndTime}[/]{iEvent.LinkedGoal}";                    

                    outputFile.WriteLine(line);
                }

                outputFile.WriteLine("PEOPLE");

                foreach (Person person in people) 
                {
                    string line = $"{person.FirstName}[/]{person.LastName}[/]{person.PhoneNumber}[/]{person.EMail}";                    

                    outputFile.WriteLine(line);
                }
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

                    while((line = reader.ReadLine()) != null)
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