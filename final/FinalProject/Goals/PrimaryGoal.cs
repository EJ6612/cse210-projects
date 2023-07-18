using System;

namespace LifePlanner
{
    public class PrimaryGoal : Goal
    {
        public PrimaryGoal(string goalName, string description, string dueDate)  : base(goalName, description, dueDate)
        {
            GoalType = "PRIMARY GOAL";
            Name = goalName;
            Description = description; 
            DueDate = dueDate;
        }

        public override void PresentGoal()
        {
            Console.WriteLine($"Name: {Name}\nDescription: {Description}\nDue Date: {DueDate}\n");

            Console.WriteLine("Tasks: ");

            if (Tasks.Count == 0)
            {
                Console.WriteLine($"[No tasks assigned to goal '{Name}'.]");
            }

            else
            {
                foreach (Task task in Tasks)
                {
                    Console.WriteLine(task.PresentTask());
                }                
            }
        }

        public override string ToString()
        {
            return base.ToString() + "";
        }
    }
}