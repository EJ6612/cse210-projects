using System;
using System.Collections.Generic;

namespace Develop03
{
    class Scripture
    {    
        private List<Word> _words = new List<Word>();
        private List<int> _replacedWordsIndex = new List<int>();

        //these values will be referenced in Program to keep track of progress
        public int totalWords, hiddenWords = 0;

        public Scripture(List<string> words)
        {
            //create a new instance of Word
            //for each string from the scripture
            //and save it all to a List<Word>
            foreach (string word in words)
            {
                Word newWord = new Word(word);
                _words.Add(newWord);
                totalWords ++;
            }
        }

        //return the current state of the scripture as a string
        public string AsString()
        {
            string currentScripture = "";
            foreach (Word word in _words)
            {
                currentScripture += $"{word.AsString()} ";
            }

            return currentScripture;
        }

        //hide a word at random
        public void HideRandomWord()
        {
            //choose a word at random that hasn't already been hidden
            Random random = new Random();
            int index;
            do 
            {
                index = random.Next(_words.Count);
            } while (_replacedWordsIndex.Contains(index));

            //find the word, then run Word.Hide() to turn it into _ _ _ 
            _words[index].Hide();

            //add reference of the word to the index
            _replacedWordsIndex.Add(index);
            hiddenWords ++;
        }


        //show the last hidden word
        public void ShowLastHiddenWord()
        {
            if (_replacedWordsIndex.Count > 0)
            {
                //find the word, then run Word.Show() to flip it back to it's original state
                int index = _replacedWordsIndex[_replacedWordsIndex.Count - 1];
                _words[index].Show();

                //remove reference of the word from the index
                _replacedWordsIndex.Remove(index);
                hiddenWords --;
            }
        }



    /*
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

    */
    }
}