namespace Develop03 
{
    class Word 
    {
        private string _original, _current;

        public Word(string word)
        {
            _original = word;
            _current = word;
        }

        //return the current state of the word as a string
        public string AsString()
        {
            return _current;
        }

        //turn the word into underscores 
        public void Hide()
        {
            //Count the letters in the word, then replace each letter
            //with an underscore (_).
            //ex: pass > ____

            string newWord = "";
            int letterCount = _original.Length;
            
            //i < letterCount (instead of <=) so that the space is not included in the replacement
            for (int i = 0; i < letterCount; i++)
            {
                newWord = newWord + "_";
            }
            
            _current = newWord;            
        }

        //revert the current state of the word to it's original state
        public void Show()
        {
            _current = _original;
        }
    }
}