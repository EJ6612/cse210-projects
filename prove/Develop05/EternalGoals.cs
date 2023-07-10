namespace Develop05 
{
    public class Eternal : Goal
    {
        public Eternal(string name, string description, int points, bool isCompleted) : base(name, description, points, isCompleted)
        {
            Points = 100;
        }
        
        public override void Complete()
        {
            Points += 100;
        }
        
    }
}