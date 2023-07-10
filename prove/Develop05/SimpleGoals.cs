using System;

namespace Develop05 
{
    public class Simple : Goal
    {
        public Simple(string name, string description, int points, bool isCompleted) : base(name, description, points, isCompleted)
        {
            Points = 50;
        }

        public override void Complete()
        {
            if (!Completed)
            {
                Completed = true;
            }

        }

        public override string ToString()
        {
            return base.ToString() + $"Is Completed: {Completed}\n";
        }

        
    }
}