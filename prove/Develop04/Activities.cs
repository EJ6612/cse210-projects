using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04 

{
    public class Activities 
    {
        //private List<string> descriptions = new List<string>();
        private string[] descriptions = {
            "",
            ""
        };

        private int userTimer = 0;



        public void LoadSpinner(int duration = 5)
        {
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(duration);

            DateTime currentTime = DateTime.Now;

            while (currentTime < futureTime)
            {
                Console.Write("|");

                currentTime = DateTime.Now;

                Thread.Sleep(400);

                //Console.Write("\b \b"); // Erase the + character
                Console.Write("|"); // Replace it with the - character

                currentTime = DateTime.Now;

                Thread.Sleep(400);

                //Console.Write("\b \b"); // Erase the + character
                Console.Write("|"); // Replace it with the - character

                currentTime = DateTime.Now;

                Thread.Sleep(400);

                Console.Write("\b \b"); // Erase the + character—
                Console.Write("\b \b"); // Erase the + character—
                Console.Write("\b \b"); // Erase the + character—

                currentTime = DateTime.Now;

                Thread.Sleep(400);
            }

        }

        public void SetTimer(int seconds)
        {
            userTimer = seconds;

        }

        public void LogData()
        {

        }

        public void SelectRandomPrompt(string[] prompts)
        {

        }

        public string StartMessage()
        {
            return "";
        }

        public string EndMessage()
        {
            return "";
        }

        public string Description()
        {
            return "";
        }
        


    }

}