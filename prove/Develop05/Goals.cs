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

        public Goal(string name, string description)
        {
            Name = name;
            Description = description;
            Points = 0;
            Completed = false;
        }

        public abstract void Complete();

        public string SaveGoal()
        {        
            return $"]]{Name}]]{Description}]]{Points}]]{Completed}";
        }     
    }
}