using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcom();
        string name = PromptUserName();
        int number = PromptUserNumber();
        DisplayResult(name, number);
    }

    static void DisplayWelcom()
    {
        Console.WriteLine("Welcome to the program!");        
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }

    static void DisplayResult(string name, int number)
    {
        int sqNum = SquareNumber(number);
        Console.WriteLine($"{name}, the square of your number is {sqNum}.");
    }

}