using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04 
{
    public class Listing : Activities 
    {
        //private List<string> prompts = new List<string>();
        private List<string> prompts = new List<string>{
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        private int userResponses = 0;
        private int userSeconds;
        private string currentPrompt;
        Random random = new Random();

        public Listing()
        {
            base.StartMessage(2);
            userSeconds = base.SetTimer();
            currentPrompt = base.SelectRandomThing(random, prompts);

            Console.Clear();
            Console.WriteLine($"Prompt: {currentPrompt}");
            base.LoadSpinner("Think about it...", 3);
            Console.WriteLine("Ready");
            Thread.Sleep(1000);
            Console.WriteLine("Set");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            Thread.Sleep(900);

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(userSeconds);

            DateTime currentTime = DateTime.Now;

            while (currentTime < futureTime)
            {
                Console.Clear();
                Console.WriteLine($"Prompt: {currentPrompt}");
                currentTime = DateTime.Now;
                Console.ReadLine();
                userResponses++;
                currentTime = DateTime.Now;
            }            

            base.EndMessage(2, userSeconds, userResponses); 
            base.SetTimer(1);
            base.LoadSpinner("", 6);
            base.LogData("Listing", userSeconds);            
        }

    }
}