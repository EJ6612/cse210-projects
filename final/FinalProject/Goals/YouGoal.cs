using System;

namespace LifePlanner
{
    internal class YouGoal : Goal
    {
        private Person user;
        public Person User 
        {
            get { return user; }
            set { user = value; }
        }

        public YouGoal(string goalName, string description, string dueDate, Person theUser)  : base(goalName, description, dueDate)
        {
            GoalType = "'ME' GOAL";
            Name = goalName;
            Description = description;
            DueDate = dueDate;
            User = theUser;
        }
            

        public override string ToString()
        {
            return base.ToString() + $"{User.FirstName}[/]{User.LastName}";
        }

        public override void PresentGoal()
        {
            Console.WriteLine($"Name: {Name}\nDescription: {Description}\nDue Date: {DueDate}\n");

            Console.WriteLine($"This goal is centered on you, {User.FirstName}.");

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
