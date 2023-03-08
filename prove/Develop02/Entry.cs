using System;


class Entry
{
    public string _entry, _prompt, _dateText;

    public List<string> _randomPrompt = new List<string>
    { 
        "Who was the most interesting person that I met today?", 
        "What was the best part of my day?", 
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion that I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Anything that I should vent about?",
        "What song did I listen to the most today?",
        "Was anyone kind to me today?",
        "Was I kind to anyone today?" 
    };

    public void Display()
    {
        Console.WriteLine($"Date: {_dateText} — Prompt: {_prompt} \r\n{_entry} \r\n"); 
    }

    public string SaveEntry()
    {        
        return $"{_dateText}]]{_prompt}]]{_entry}";
    }


}