using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Develop05
{
    public class Transfer
    {

        public static void SaveToFile(string saveFile, List<Goal> goals)
        {
            using (StreamWriter outputFile = new StreamWriter(saveFile))
            {
                foreach(Goal goal in goals)
                {
                    string goalConverted = goal.ToString();
                    outputFile.WriteLine(goalConverted + goal.SaveGoal());            
                }
            }
        }

        public static void LoadFromFile(string saveFile)
        {
            string[] lines = File.ReadAllLines(saveFile);

            if (lines != null)
            {
                Program._goals.Clear();

                foreach(string line in lines)
                {
                    string[] parts = line.Split("]]");
                    string goalType = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool completed = bool.Parse(parts[4]);

                    if (goalType == "Develop05.Simple")
                    {
                        Goal newGoal = new Simple(name, description);
                        //newGoal.Points = points;
                        newGoal.Completed = completed;
                        Program._goals.Add(newGoal);
                    }

                    if (goalType == "Develop05.Eternal")
                    {
                        Goal newGoal = new Eternal(name, description);
                        //newGoal.Points = points;
                        newGoal.Completed = completed;
                        Program._goals.Add(newGoal);
                    }

                    if (goalType == "Develop05.Checklist")
                    {
                        Goal newGoal = new Checklist(name, description, 100);
                        //newGoal.Points = points;
                        newGoal.Completed = completed;
                        Program._goals.Add(newGoal);
                    }
                }
            }


        }        
    }
}