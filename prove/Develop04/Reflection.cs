using System;
using System.Collections.Generic;

namespace Develop04 
{
    public class Reflection : Activities 
    {
        private List<string> prompts = new List<string>{
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        private List<string> questions = new List<string>{
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        private int userSeconds;
        private int questionCount;
        private int questionsAsked = 0;

        private string currentPrompt;
        Random random = new Random();

        public Reflection()
        {
            base.StartMessage(1);
            userSeconds = base.SetTimer();

            //each question will take up 6 seconds
            questionCount = userSeconds / 6;

            Console.Clear();
            base.LoadSpinner("Get ready...", 6);
            Console.WriteLine("");

            currentPrompt = base.SelectRandomThing(random, prompts);

            while (questionsAsked < questionCount)
            {
                    Console.Clear();
                    Console.WriteLine($"Prompt: {currentPrompt}");
                    Console.WriteLine("");
                    base.LoadSpinner(base.SelectRandomThing(random, questions), 6);
                    questionsAsked++;
            }
            
            base.EndMessage(1, userSeconds);
            base.LoadSpinner("", 4);
            base.SetTimer(1);
            base.LogData("Reflection", userSeconds);
        }


        
    }
    
}