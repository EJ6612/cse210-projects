namespace Develop03 
{
    class Word 
    {
        private string _original, _current;

        public Word(string word)
        {
            _original = word;
        }

        public string AsString()
        {
            return _current;
        }

        public void Hide()
        {
            //Count the letters in the word, then replace each letter
            //with an underscore (_).
            //ex: pass > ____

            string newWord = "";
            int letterCount = _original.Length;
            
            for (int i = 0; i <= letterCount; i++)
            {
                newWord = newWord + "_";
            }

            _current = newWord;
            
        }

        public void Show()
        {
            _current = _original;
        }


        /* First attempt code
        private string _word;

        private bool _isHidden;

        public Words(string word)
        {
            _word = word;
        }

        public void Display()
        {
            if(_isHidden)
            {
                string newWord = "";
                int letterCount = _word.Length;
                
                for (int i = 0; i <= letterCount; i++)
                {
                    newWord = newWord + "_";
                }

                Console.Write(newWord);

                //return newWord;
            }
            else
            {
                Console.Write(_word);
                //return _word;
            }
        }

        public void HideMe()
        {
            _isHidden = true;
        }

        public bool IsItHidden()
        {
            return _isHidden;
        }
        */

    }
}