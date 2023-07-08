using System;
using System.Collections.Generic;
using System.IO;

namespace Develop05
{
    public class Transfer
    {

        public static void SaveToFile(string saveFile, List<Goal> goals)
        {
            using (StreamWriter outputFile = new StreamWriter(saveFile))
            {
                outputFile.WriteLine(Program.PointTotal);

                foreach (Goal goal in goals) 
                {
                    string line;
                    if (goal is Checklist checklistGoal)
                    {
                        line = $"{goal.GetType().Name}]]{goal.Name}]]{goal.Description}]]{goal.Points}]]{goal.Completed}]]{checklistGoal.GoalCompleted}]]{checklistGoal.GoalTotal}";
                    }
                    else
                    {
                        line = $"{goal.GetType().Name}]]{goal.Name}]]{goal.Description}]]{goal.Points}]]{goal.Completed}";
                    }

                    outputFile.WriteLine(line);
                }
            }
        }


        public static List<Goal> ReadGoalsFromFile(string saveFile)
        {
            List<Goal> goals = new List<Goal>();

            using (StreamReader reader = new StreamReader(saveFile))
            {
                Program.PointTotal = int.Parse(reader.ReadLine());

                string line;

                while((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(new string[] { "]]" }, StringSplitOptions.None);

                    string goalType = values[0];
                    string name = values[1];
                    string description = values[2];
                    int points = int.Parse(values[3]);
                    bool isCompleted = bool.Parse(values[4]);

                    Goal goal;
                    switch (goalType)
                    {
                        case "Simple":
                            goal = new Simple(name, description, points, isCompleted);
                            break;
                        case "Eternal":
                            goal = new Eternal(name, description, points, isCompleted);
                            break;
                        case "Checklist":
                            int subGoalsCompleted = int.Parse(values[5]);
                            int subGoalsTotal = int.Parse(values[6]);
                            goal = new Checklist(name, description, points, isCompleted, subGoalsCompleted, subGoalsTotal);
                            break;
                        default:
                            throw new ArgumentException("Unknown goal type: " + goalType);
                    }

                    goals.Add(goal);
                }
            }            
            Console.WriteLine("\nYour file has been loaded.\n\nPress ENTER to continue.");
            Console.ReadLine();

            return goals;
        }
    }
}