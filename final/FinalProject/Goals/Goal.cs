using System;
using System.Collections.Generic;

namespace LifePlanner
{
    public abstract class Goal 
    {
        private string name, description, dueDate; 
        public string Name
        {
            get { return name; }   
            set { name = value; }  
        }
        public string Description
        {
            get { return description; }   
            set { description = value; }  
        }
        public string DueDate
        {
            get { return dueDate; }   
            set { dueDate = value; }  
        }

        public string GoalType;
        
        public List<Task> Tasks = new List<Task>();
        private List<Person> People = new List<Person>();

        public Goal(string goalName, string description, string dueDate)
        {

        }

        public void AddTasks()
        {
            bool alive = true;
            while (alive)
            {
                Console.WriteLine("Would you like to add a task to this goal?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                string userSelection = Console.ReadLine();

                if (userSelection == "1")
                {
                    Task newTask = new Task();
                    Tasks.Add(newTask);
                }

                else
                {
                    Console.WriteLine("No new tasks will be added.");

                    alive = false;
                }
            }
        }

        public abstract void PresentGoal();

        public override string ToString()
        {
            return $"{GoalType}[/]{Name}[/]{Description}[/]{DueDate}[/]";
        }
        
    }
}