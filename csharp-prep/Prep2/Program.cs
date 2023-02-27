using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!"); 

        Console.Write("What is your grade? ");
        float grade = float.Parse(Console.ReadLine());

        string letter;
        string classStatus;

        // A
        if (grade >= 90)
        {
            letter = "A";
        }

        // B
        else if (grade >= 80)
        {
            letter = "B";
        }

        // C
        else if (grade >= 70)
        {
            letter = "C";
        }

        // D
        else if (grade >= 60)
        {
            letter = "D";
        }

        // F
        else
        {
            letter = "F";
        }

        // PASS OR FAIL
        if (grade >= 70)
        {
            classStatus = "PASS";
        }

        else 
        {
            classStatus = "FAIL";
        }

        Console.WriteLine($"Your grade is {letter}. STATUS: {classStatus}");

    }
}