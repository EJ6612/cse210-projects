namespace Develop05 
{
    public class Checklist : Goal
    {
        public int GoalTotal { get; set; }
        public int GoalCompleted { get; set; }

        public Checklist(string name, string description, int points, bool isCompleted, int completed, int toBeCompleted) 
            : base(name, description, points, isCompleted)
        {
            GoalTotal = toBeCompleted;
            GoalCompleted = completed;
        }
        
        public override void Complete()
        {
            GoalCompleted++;

            if (GoalCompleted == GoalTotal)
            {
                Points = (GoalCompleted * 10) + (GoalTotal * 10);
                Completed = true;
            }

            else 
            {
                Points = GoalCompleted * 5;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"Completed so far: {GoalCompleted}/{GoalTotal}\n";
        }
        
    }
}