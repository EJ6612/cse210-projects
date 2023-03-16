
class Reference
{
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

}