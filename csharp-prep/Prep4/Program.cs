using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        bool alive = true;
        
        List<int> numbers = new List<int>();

        while (alive)
        {
            Console.WriteLine("Enter a number: (integers ONLY)");
            int newNumber = int.Parse(Console.ReadLine());

            //asking for numbers
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }

            //not asking for numbers
            else 
            {
                //print total
                Console.WriteLine($"Total: {numbers.Count}"); 

                //print average
                float howManyNumbers = numbers.Count;
                float average = numbers.Sum() / howManyNumbers;
                Console.WriteLine($"Average: {average}");

                int bigBoi = 0;
                int smallBoi = numbers.Sum() * 5;

                //print BIGGEST NUMBER
                foreach (int number in numbers)
                {
                    if (number > bigBoi)
                    { bigBoi = number; }
                    if (number < smallBoi)
                    { smallBoi = number; }
                }

                Console.WriteLine($"BIGGEST BOI IS: {bigBoi}.");
                Console.WriteLine($"smallest boi is {smallBoi}.");

                //sort the numbers
                numbers.Sort(); 

                Console.WriteLine("Sorted: ");

                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }

                alive = false;

            }


        }

    }
}