using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        
        bool alive = true;

        Journal journal = new Journal();

        DateTime theCurrentTime = DateTime.Now;


        while (alive)
        {
            //Welcome message and options
            Console.WriteLine("Welcome to your digital journal.");
            Console.WriteLine("Please select one of the following options: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            //User response
            Console.Write("What would you like to do? ");
            try 
            {
                int userResponse = int.Parse(Console.ReadLine());

                //1. Write
                if (userResponse == 1)
                {   
                    Console.WriteLine();

                    Entry entry = new Entry();

                    var randomPrompt = new Random();
                    int index = randomPrompt.Next(entry._randomPrompt.Count);
                    entry._prompt = entry._randomPrompt[index];
                    Console.WriteLine(entry._prompt);
                    
                    entry._entry = Console.ReadLine();

                    entry._dateText = theCurrentTime.ToShortDateString();

                    journal._entries.Add(entry);

                }

                //2. Display
                else if (userResponse == 2)
                {
                    journal.DisplayEntries();
                }

                //3. Load
                else if (userResponse == 3)
                {
                    journal.Load();
                    Console.WriteLine("\r\nJournal entries have been loaded. \r\n");
                }

                //4. Save
                else if (userResponse == 4)
                {
                    journal.Save();
                    Console.WriteLine("\r\nJournal entries have been saved. \r\n");
                }

                //5. Quit
                else if (userResponse == 5)
                {
                    Console.WriteLine("\r\n \r\nThanks for using your digital journal! Have a great day.");
                    Console.Write("\r\nPress any key to exit. ");
                    string exitJournal = Console.ReadLine();
                    break;

                }

                else 
                {
                    
                    Console.WriteLine("\r\nPlease enter a number bewteen 1-5.\r\n");
                }
            }

            catch 
            {
                Console.WriteLine("\r\nPlease submit a number.\r\n");
            }

        }

    }
}