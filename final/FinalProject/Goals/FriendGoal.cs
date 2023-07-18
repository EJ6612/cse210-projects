using System;

namespace LifePlanner
{
    internal class FriendGoal : Goal
    {
        private Person friend;
        public Person Friend 
        {
            get { return friend; }
            set { friend = value; }
        }
        public FriendGoal(string goalName, string description, string dueDate, Person friend) : base(goalName, description, dueDate)
        {
            GoalType = "FRIEND GOAL";
            Name = goalName;
            Description = description;
            DueDate = dueDate;
            Friend = friend;
        }

        public override string ToString()
        {
            return base.ToString() + $"{Friend.FirstName}[/]{Friend.LastName}[/]{Friend.PhoneNumber}[/]{Friend.Email}";
        }

        public override void PresentGoal()
        {
            Console.WriteLine($"Name: {Name}\nDescription: {Description}\nDue Date: {DueDate}\n");

            Console.WriteLine($"This goal is centeted on {Friend.FirstName}.");

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

    }
}
