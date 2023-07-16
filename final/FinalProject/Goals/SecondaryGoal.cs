using System;

namespace LifePlanner
{
    public class SecondaryGoal : Goal
    {
        public SecondaryGoal(string goalName, string description, string dueDate) : base(goalName, description, dueDate)
        {
            Name = goalName;
            Description = description;
            DueDate = dueDate;
        }
        public override void SetNewGoal()
        {
            Console.WriteLine("Congrats! You have set a new Secondary Goal.");
            Console.ReadLine();
        }

    }
}