using System;

class Program
{
    static void Main(string[] args)
    {
        int groupSize = 4;
        int totalGroups = 3;
        int currentNumber = 1;

        for (int i = 0; i < totalGroups; i++)
        {
            for (int j = 0; j < groupSize; j++)
            {
                Console.Write(currentNumber + " ");
                currentNumber += 2;
            }
            Console.Write(" ");

            for (int j = 0; j < groupSize; j++)
            {
                Console.Write(currentNumber + " ");
                currentNumber += 2;
            }
            Console.WriteLine();
        }
    }

    
}