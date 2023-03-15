using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Console.Clear();

        Assignment basics1 = new Assignment("Elijah Dodge", "Multiplication");
        MathAssignment maths1 = new MathAssignment("Elijah Dodge", "Fractions", "Section 7.3", "Problems 8-19");
        WritingAssignment writings1 = new WritingAssignment("Elijah Dodge", "History of Ducks", "History of Ducks VOL XXIII: The Cold War");

        Console.WriteLine(basics1.GetSummary());
        Console.WriteLine();
        Console.WriteLine(maths1.GetSummary());
        Console.WriteLine(maths1.GetHomeworkList());
        Console.WriteLine();
        Console.WriteLine(writings1.GetSummary());
        Console.WriteLine(writings1.GetWritingInformation());
        
    }
}