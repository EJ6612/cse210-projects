using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04 
{
    public class Activities 
    {
        private string[] titles = {
            "Breathing",
            "Reflection",
            "Listing"
        };

        //private List<string> descriptions = new List<string>();
        private string[] descriptions = {
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on breathing.",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        };        

        private int userTimer = 0;


        public void LoadSpinner(string message, int duration = 6)
        {
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(duration);

            DateTime currentTime = DateTime.Now;

            Console.WriteLine(message);

            while (currentTime < futureTime)
            {
                Console.Write("|"); // Add |

                currentTime = DateTime.Now;

                Thread.Sleep(1000);

                currentTime = DateTime.Now;

                Console.Write("|"); // Add |

                currentTime = DateTime.Now;

                Thread.Sleep(1000);

                currentTime = DateTime.Now;

                Console.Write("|"); // Add |

                currentTime = DateTime.Now;

                Thread.Sleep(1000);

                currentTime = DateTime.Now;

                Console.Write("\b \b"); // Remove |
                Console.Write("\b \b"); // Remove |
                Console.Write("\b \b"); // Remove |

                currentTime = DateTime.Now;

                Thread.Sleep(1000);

                currentTime = DateTime.Now;
            }

        }

        public int SetTimer(int clear = 0)
        {
            if (clear == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("How long, in seconds, would you like for your session?");
                userTimer = Int16.Parse(Console.ReadLine());

                return userTimer;
            }
            else 
            {
                userTimer = 0;
                return 0;
            }
        }

        public void LogData(string activityName, int duration)
        {
            Console.Clear();
            Console.WriteLine("");
            Thread.Sleep(400);
            Console.WriteLine("— —Activity Log— —");
            Thread.Sleep(400);
            Console.WriteLine($"Activity: {activityName}");
            Thread.Sleep(400);
            Console.WriteLine($"Duration: ~{duration} seconds");
            Thread.Sleep(400);
            Console.WriteLine("  —  —  —  —  —  —  ");
            Thread.Sleep(400);
            Console.WriteLine("");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        public string SelectRandomThing(Random random, List<string> list)
        {
            int index = random.Next(list.Count);
            return list[index];
        }


        //activityType: 0 is breathing, 1 is reflection, 2 is listing
        public void StartMessage(int activityType)
        {
            Console.WriteLine($"Welcome to the {titles[activityType]} Activity!");
            Console.WriteLine(descriptions[activityType]);        
        }

        public void EndMessage(int activityType, int activityTime, int amount = 0)
        {
            if (amount == 0)
            {
                Console.WriteLine("");
                Console.WriteLine($"You have completed (approx.) another {activityTime} seconds of the {titles[activityType]} Activity.");
            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine($"You have completed (approx.) another {activityTime} seconds of the {titles[activityType]} Activity,");
                Console.WriteLine($"and entered {amount} items!");
            }
        } 

    }

}