
namespace LifePlanner
{
    public abstract class Goal 
    {
        public string Name;
        public string Description;
        public DateTime DueDate;
        public List<Task> Tasks = new List<Task>();
        public List<Person> People = new List<Person>();


        public override string ToString()
        {
            return $"Name: {Name}\nDescription: {Description}\nDue Date: {DueDate}\n"
            + "";
        }
        
    }
}