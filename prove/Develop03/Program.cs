using System;

namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            Loader loader = new Loader();
            Scripture scripture = new Scripture(loader.FindRandomScripture());

            while (scripture.hiddenWords != scripture.totalWords)
            {
                Console.Clear();
                Console.WriteLine(loader.reference + " " + scripture.AsString());
                Console.WriteLine();
                Console.WriteLine("Press P to hide a word.");
                Console.WriteLine("Press O to reveal the last word.");
                Console.WriteLine("Type 'quit' to exit.");
                string keyEnter = Console.ReadLine();

                if (keyEnter.ToLower() == "p")
                {
                    scripture.HideRandomWord();
                    Console.Clear();
                }

                else if (keyEnter.ToLower() == "o")
                {
                    scripture.ShowLastHiddenWord();
                    Console.Clear();
                }

                else if (keyEnter.ToLower() == "quit")
                {
                    break;
                }

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
            
            /* first attempt code
            Console.WriteLine("Hello Develop03 World!");
            Console.Clear();

            int lastWord = 1;

            List<string> _scripture = new List<string>
            {
                "Therefore I write unto you, desiring that ye would yield up unto this my people, your cities, your lands, and your possessions, rather than that they should visit you with the sword and that destruction should come upon you.",
                "Or in other words, yield yourselves up unto us, and unite with us and become acquainted with our secret works, and become our brethren that ye may be like unto us—not our slaves, but our brethren and partners of all our substance.", 
                "And behold, I swear unto you, if ye will do this, with an oath, ye shall not be destroyed; [...]"
            };

            Scripture scripture = new Scripture(_scripture);

            scripture.Display();
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue or type 'quit' to exit.");

            while (true)
            {            
                string keyEnter = Console.ReadLine();

                if (keyEnter.ToLower() != "quit" && !scripture.IsItHidden())
                {
                    Console.Clear();
                    scripture.Display();
                    Console.WriteLine();
                    Console.WriteLine("Press ENTER to continue or type 'quit' to exit.");
                }

                else
                {
                    if (lastWord == 1)
                    {
                        if (keyEnter.ToLower() != "quit")
                        {
                            Console.Clear();
                            scripture.Display();
                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to continue or type 'quit' to exit.");
                            lastWord = 0;
                        }
                    }
                    
                    else
                    {
                        Console.WriteLine("Press any key to terminate program.");
                        Console.ReadLine();
                        break;
                    }
                }

                
            }

            */
        }
    }
}