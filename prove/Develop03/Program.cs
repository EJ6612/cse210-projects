using System;

namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            
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