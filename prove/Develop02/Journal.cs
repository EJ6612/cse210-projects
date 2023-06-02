using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Develop02
{
    ///<summary>
    ///The responsibility of Journal is to store entries.
    ///</summary>
    class Journal
    {
        // First Attempt Code

        //public string _date;
        public List<Entry> _entries = new List<Entry>();

        string filename = "journal.csv";

        public Journal() 
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("]]");
                string date = parts[0];
                string prompt = parts[1];
                string entry = parts[2];

                Entry newEntry = new Entry();
                newEntry._dateText = date;
                newEntry._prompt = prompt;
                newEntry._entry = entry;
                _entries.Add(newEntry);
            }

        }


        //Display Journal entries
        public void DisplayEntries()
        {
            foreach(Entry entryRead in _entries)
            {
                entryRead.Display();
            }
        }

        //Save Journal file.
        public void Save()
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach(Entry entryRead in _entries)
                {
                    outputFile.WriteLine(entryRead.SaveEntry());            
                }
            }

        }

        //Load Journal file.
        public void LoadFromOtherJournal(string journalFile)
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            if (lines != null)
            {
                _entries.Clear();

                foreach (string line in lines)
                {
                    string[] parts = line.Split("]]");
                    string date = parts[0];
                    string prompt = parts[1];
                    string entry = parts[2];

                    Entry newEntry = new Entry();
                    newEntry._dateText = date;
                    newEntry._prompt = prompt;
                    newEntry._entry = entry;
                    _entries.Add(newEntry);
                }

                Console.WriteLine("SUCCESSFULLY LOADED JOURNAL ENTRIES");
            }

            else 
            {
                Console.WriteLine("INVALID FILETYPE");
            }
        }
        
    }
}