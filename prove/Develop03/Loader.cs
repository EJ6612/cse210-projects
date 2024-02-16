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

        public Loader(string importDictionary)
        {            
            //load the file into the dictionary
            newdict = File.ReadLines(importDictionary)
            .Select(line => line.Split('|'))
            .GroupBy(arr => arr[0])
            .ToDictionary(group => group.Key, group => group.Select(splitLine => splitLine[1]).ToArray());
            //'splitLine' represents each individual line that has been split into an array of strings 
            //using the "|" character as the delimiter.
            //
            //'group' represents each group of 'splitLine' arrays that have been grouped together based 
            //on the value at index 0 (the first element) of each array. Each group has a unique key.
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
    
    }
}