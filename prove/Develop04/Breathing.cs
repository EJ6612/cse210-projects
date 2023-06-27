using System;
using System.Threading;

namespace Develop04 
{
    public class Breathing : Activities
    {
        private int breathCount, breathIndex = 0;
        private int userSeconds;
        public Breathing()
        {
            base.StartMessage(0);
            userSeconds = base.SetTimer();
            SplitTime(userSeconds);

            Console.Clear();
            base.LoadSpinner("Get ready...", 6);

            Console.WriteLine("");

            while (breathIndex < breathCount)
            {
                Console.Write("Breathe in...");
                Count();

                Console.WriteLine();
                Thread.Sleep(1500);

                Console.Write("Breathe out...");
                Count();

                Console.WriteLine("");
                Console.WriteLine("");
                
                Thread.Sleep(1500);                

                breathIndex ++;
            }

            base.LoadSpinner("Well done!", 6);

            base.EndMessage(0, userSeconds);
            base.SetTimer(1);
            base.LoadSpinner("", 4);
            base.LogData("Breathing", userSeconds);
        }

        private void SplitTime(int seconds)
        {
            breathCount = seconds / 6;
        }

        private void Count()
        {
            Console.Write("3"); 

            Thread.Sleep(1000);

            Console.Write("\b \b");

            Console.Write("2"); 

            Thread.Sleep(1000);

            Console.Write("\b \b");

            Console.Write("1"); 

            Thread.Sleep(1000);

            Console.Write("\b \b");
        }
    }
    
}