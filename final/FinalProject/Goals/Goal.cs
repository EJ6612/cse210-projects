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
        private List<Task> Tasks = new List<Task>();
        private List<Person> People = new List<Person>();

        public Goal(string goalName, string description, string dueDate)
        {
            Name = goalName;
            Description = description; 
            DueDate = dueDate;
        }


        public abstract void SetNewGoal();

        public override string ToString()
        {
            return $"Name: {Name}\nDescription: {Description}\nDue Date: {DueDate}\n"
            + "";
        }
        
    }
}