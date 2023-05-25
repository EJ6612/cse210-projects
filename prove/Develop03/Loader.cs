using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Develop03
{
    class Loader
    {
        Dictionary<string, string[]> newdict = new Dictionary<string, string[]>();
        public string reference;

        public Loader()
        {
            //load the file into the dictionary
            newdict = File.ReadLines("dictionary.csv")
            .Select(line => line.Split('|'))
            .GroupBy(arr => arr[0])
            .ToDictionary(gr => gr.Key, gr => gr.Select(s => s[1]).ToArray());
            //⤴️honestly, I'm not entirely sure how this even works. But it does!
        }

        //Find a random key and return the accompanying scripture
        private string FindRandomKeyScripture()
        {
            if (newdict.Count == 0)
            {
                Console.WriteLine("No data available.");
                return null;
            }

            Random random = new Random();
            int index = random.Next(newdict.Count);
            string key = newdict.ElementAt(index).Key;

            //save key to reference, which will be used in Program for visual purposes
            reference = key;

            if (newdict.TryGetValue(key, out string[] value))
            {
                string result = string.Join("|", value);
                return result;
            }

            else 
            {
                Console.WriteLine("Key not found.");
                return "ERROR";
            }            
        }

        //turn the scripture (which is a string) into a list so that it can be imported to the class Scripture
        public List<string> FindRandomScripture()
        {
            string[] words = FindRandomKeyScripture().Split(" ");
            List<string> result = words.ToList();
            return result;
        }

        //for testing whether the dictionary successfully imported (make public when testing)
        private void TestDictionaryPrint(int choice)
        {
            //print all
            if (choice == 1)
            {
                foreach (KeyValuePair<string, string[]> entry in newdict)
                {
                    Console.WriteLine(entry.Key + ": " + string.Join(", ", entry.Value));
                }
            }

            //print key
            else 
            {
                Console.WriteLine(FindRandomKeyScripture());
            }

        }
        

    /*First attempt code
        private List<Words> _words = new List<Words>();

        private bool _isHidden;

        public Reference(string verse)
        {
            char[] exemptions = {' ', '\t'};
            string[] words = verse.Split();

            foreach (string newWord in words)
            {   
                Words word = new Words(newWord);
                _words.Add(word);
            }

        }

        public void Display()
        {
            foreach (Words word in _words)
            {
                word.Display();
                Console.Write(" ");
                //return word;
                //Console.Write(word);
            }

        }

        public void HideWord()
        {
            //count the amount of words that aren't hidden
            int wordCount = 0;
            foreach (Words word in _words)
            {
                //is word not hidden yet? Count goes up.
                if (!word.IsItHidden())
                {
                    wordCount++;
                }
            }

            //choose random words to hide
            //if the amount of words that aren't hidden is an actual amount, run the code!
            if (wordCount > 0)
            {
                Random randomGenerator = new Random();
                //choose a number between 0 and the amount of words
                int index = randomGenerator.Next(0, _words.Count);

                if (!_words[index].IsItHidden())
                {
                    _words[index].HideMe();
                }

                else
                {
                    HideWord();
                }

            }

            else 
            {
                _isHidden = true;
            }

        }

        public bool IsItHidden()
        {
            return _isHidden;
        }

    */
    
    }
}