using System;

namespace LifePlanner
{
    public class PrimaryGoal : Goal
    {

        public PrimaryGoal(string goalName, string description, string dueDate) : base(goalName, description, dueDate)
        {
            Name = goalName;
            Description = description;
            DueDate = dueDate;
        }
        public override void SetNewGoal()
        {
            Console.WriteLine("Congrats! You have set a new Primary Goal.");
            Console.ReadLine();
        }
    }
}