namespace LifePlanner
{
    public class Task
    {
        public string Name;
        public string Description;
        public DateTime DueDate;
        public Goal LinkedGoal;
        public List<Person> People = new List<Person>();

        public override string ToString()
        {
            return $"Name: {Name}\nDescription: {Description}\nDue Date: {DueDate}\n"
            + $"Linked Goal: \n{LinkedGoal.ToString()}";
        }
    }
}