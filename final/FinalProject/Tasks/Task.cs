using System;

namespace LifePlanner
{
    public class Task
    {
        private string name;
        private bool isTaskComplete;

        public bool Completed 
        {
            get { return isTaskComplete; }
            set { isTaskComplete = value; }
        }
        public string Name
        {
            get { return name; }   
            set { name = value; }  
        }

        public Task()
        {
            Console.WriteLine("What is this task?");
            Name = Console.ReadLine();
            Console.WriteLine($"Task '{Name}' has been created.");
            isTaskComplete = false;
            Console.ReadLine();
        }

        public Task(string name, bool complete)
        {
            Name = name;
            isTaskComplete = complete;
        }

        public void Complete()
        {
            isTaskComplete = true;
        }

        public string PresentTask()
        {
            if (isTaskComplete)
            {
                return $"[X] {Name}";
            }

            else
            {
                return $"[ ] {Name}";
            }
        }

        public override string ToString()
        {
            return $"{Name}[/]{Completed}";
        }
        
    }
}