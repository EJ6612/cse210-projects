using System;

namespace LifePlanner
{
    internal class YouGoal : Goal
    {
        public YouGoal(string goalName, string description, string dueDate) : base(goalName, description, dueDate)
        {
            Name = goalName;
            Description = description;
            DueDate = dueDate;
        }
        public override void SetNewGoal()
        {
            Console.WriteLine("Congrats! You have set a new You Goal.");
            Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Name: {Name} \nDesription: {Description}";
        }

    }
}
