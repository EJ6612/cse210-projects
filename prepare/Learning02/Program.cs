using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        
        Job job1 = new Job();
        Job job2 = new Job();

        //add details to job1
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2023;
        job1._endYear = 2025;
        //job1.Display();

        //add details to job2
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2023;
        job2._endYear = 2026;
        //job2.Display();

        //print out resume
        Resume resume1 = new Resume();
        resume1._name = "Billy Bob Joe";
        resume1._jobsList.Add(job1);
        resume1._jobsList.Add(job2);
        resume1.Display();
    }
}