using System;

class Journal
{
    //public string _date;
    public List<Entry> _entries = new List<Entry>();

    string filename = "journal.csv";


    public void DisplayEntries()
    {
        foreach(Entry entryRead in _entries)
        {
            entryRead.Display();
        }
    }

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

    //Load Journal file. Isn't working properly.
    public void Load()
    {
        Journal journal = new Journal();

        string[] lines = (System.IO.File.ReadAllLines(filename));
        
        try
        {
            foreach (string line in lines)
            {
                string[] parts = line.Split("]]");  

                    Entry entry = new Entry();
                    //Console.WriteLine($"{parts[0]} {parts[1]} {parts[2]}");
                    entry._dateText = parts[0];
                    entry._prompt = parts[1];
                    entry._entry = parts[2];
                    journal._entries.Add(entry);
                

                //Console.WriteLine(line);


               // foreach (string loadedEntry in parts)
                //{
                    //string[] entryParts = line.Split("]]");

                    //Entry entry = new Entry();
                    //Console.WriteLine($"{entryParts[0]} {entryParts[1]} {entryParts[2]}");
                    //entry._dateText = entryParts[0];
                    //entry._prompt = entryParts[1];
                    //entry._entry = entryParts[2];
                    //journal._entries.Add(entry);
                //}         
            }
        }

        catch 
        {
            Console.WriteLine("Error happened.");
        }

    }
}