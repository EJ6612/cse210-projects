using System;
using System.Collections.Generic;

namespace Develop05 
{
    [Serializable]
    public abstract class Goal
    {        
        public string Name { get; }
        public string Description { get; }

        public int Points { get; protected set; }
        public bool Completed { get; set; }

        public Goal(string name, string description, int points, bool isCompleted)
        {
            Name = name;
            Description = description;
            Points = points;
            Completed = isCompleted;
        }

        public abstract void Complete();

        public string SaveGoal()
        {        
            return $"]]{Name}]]{Description}]]{Points}]]{Completed}";
        }


        public override string ToString()
        {
            return $"Name: {Name}\nDescription: {Description}\nPoints: {Points}\n";
        }
    }
}