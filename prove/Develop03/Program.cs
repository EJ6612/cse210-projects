using System;

namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            Loader loader = new Loader("dictionary.csv");
            Scripture scripture = new Scripture(loader.FindRandomScripture());
            Console.Clear();

            while (scripture.hiddenWords != scripture.totalWords)
            {
                //Display Menu
                Console.WriteLine(loader.reference + " " + scripture.AsString());
                Console.WriteLine();
                Console.WriteLine("Press P to hide a word.");
                Console.WriteLine("Press O to reveal the last word.");
                Console.WriteLine("Type 'quit' to exit.");
                string keyEnter = Console.ReadLine();

                //if user enters P, then hide a word
                if (keyEnter.ToLower() == "p")
                {
                    scripture.HideRandomWord();
                    Console.Clear();
                }

                //if user enters O, reveal last hidden word
                else if (keyEnter.ToLower() == "o")
                {
                    scripture.ShowLastHiddenWord();
                    Console.Clear();
                }

                //if user types and enters 'quit', break from the while loop
                else if (keyEnter.ToLower() == "quit")
                {
                    break;
                }

                //if user enters any other input
                else 
                {
                    Console.Clear();
                    Console.WriteLine("Please enter P, O, or 'quit'.");
                    Console.WriteLine();
                }
            }

            Console.Clear();
            Console.WriteLine(loader.reference + " " + scripture.AsString());
            Console.WriteLine();
            Console.WriteLine("Press any key to terminate program.");
            Console.ReadLine();

            //loader.TestDictionaryPrint(2);
            
        }
    }
}