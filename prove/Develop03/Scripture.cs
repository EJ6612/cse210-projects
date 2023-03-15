

class Scripture
{

    private bool _isHidden;
    private List<Reference> _verse = new List<Reference>();

    public Scripture(List<string> entireScripture)
    {
        foreach (string newVerse in entireScripture)
        {
            Reference verse = new Reference(newVerse);
            _verse.Add(verse);
        }

    }

    public void Display()
    {
        Console.WriteLine("3 Nephi 3:6-8");
        foreach(Reference verse in _verse)
        {
            verse.Display();

            //return verse;
            //Console.Write(verse);
        }
        //now run code to hide 3 words
        HideVerse();
        HideVerse();
        HideVerse();
    }

    public void HideVerse()
    {
        //count the amount of verses that aren't hidden
        int verseCount = 0;

        foreach (Reference verse in _verse)
        {
            //is verse not hidden yet? Count goes up.
            if (!verse.IsItHidden())
            {
                verseCount++;
            }
        }

        //choose random verses to hide
        //if the amount of verses that aren't hidden is an actual amount, run the code!
        if (verseCount > 0)
        {
            Random randomGenerator = new Random();
            //choose a number between 0 and the amount of verses
            int index = randomGenerator.Next(0, _verse.Count);

            if (!_verse[index].IsItHidden())
            {
                _verse[index].HideWord();
            }

            else
            {
                HideVerse();
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


}