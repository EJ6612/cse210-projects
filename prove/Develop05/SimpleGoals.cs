using System;

namespace Develop05 
{
    public class Simple : Goal
    {
        public Simple(string name, string description) : base(name, description)
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

        
    }
}