using System; 

namespace Prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Prep3 World!");

            bool alive = true;
            int timesPlayed = 0;

            while (alive)
            {

                Random randomGenerator = new Random();
                int number = randomGenerator.Next(1, 101);

                int tries = 0;

                int guess = -1;

                Console.WriteLine("Guess a number! ");

                while (guess != number)
                {
                    guess = int.Parse(Console.ReadLine());

                    if (guess < number)
                    {
                        Console.WriteLine("Wrong! Guess higher...");
                    }

                    else if (guess > number)
                    {
                        Console.WriteLine("Wrong! Guess lower...");
                    }

                    else
                    {
                        Console.WriteLine($"Congratulations! That took {tries} attempt(s).");

                    }

                    tries += 1;
                }

                Console.WriteLine("Do you want to play again? [YES/NO]");
                string playAgain = Console.ReadLine();

                timesPlayed += 1;
                
                if (playAgain.ToLower() == "yes")
                {
                    alive = true;
                }

                else
                {
                    alive = false;
                }

            }

            Console.WriteLine($"Thanks for playing! You played {timesPlayed} time(s)! ");

        }
    }
}