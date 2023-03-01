using System;

public class Resume 
{
    public string _name;
    public List<Job> _jobsList = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: ");
        // Console.WriteLine(_jobsList);
        foreach (Job job in _jobsList)
        {
            job.Display();
        }
    }

}