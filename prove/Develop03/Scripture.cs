using System;
using System.Collections.Generic;
using System.Linq;

namespace Develop03
{
    class Scripture
    {    
        private List<Word> _words = new List<Word>();

        //LastHiddenWord index (tbd 😭)
        private List<Word> _hiddenWordsIndex = new List<Word>();

        Scripture(List<string> words)
        {
            //create a new instance of Word
            //for each string from the scripture
            //and save it all to a List<Word>
            foreach (string word in words)
            {
                Word newWord = new Word(word);
                _words.Add(newWord);
            }
        }

        public string AsString()
        {
            //'print' new scripture with changes
            string currentScripture = "";
            foreach (Word word in _words)
            {
                currentScripture += $"{word.AsString()} ";
            }

            return currentScripture;
        }

        public void HideRandomWord()
        {
            //generate random number
            Random random = new Random();
            int randomIndex = random.Next(0, _words.Count);

            //check randomly selected word against words that
            //have already been hidden. If already hidden, generate
            //new number and start again.
            foreach (Word word in _hiddenWordsIndex)
            {
                while (word == _words[randomIndex])
                {                    
                    if (word != _words[randomIndex])
                    {
                        _words[randomIndex].Hide();
                        _hiddenWordsIndex.Add(_words[randomIndex]);
                        break;
                    }

                    else 
                    {                        
                        randomIndex = random.Next(0, _words.Count);
                    }
                }
            }
        }

        public void ShowLastHiddenWord()
        {
            int hiddenWordPlacement = _hiddenWordsIndex.Count - 1;
            
            //_words.Find(_hiddenWordsIndex.Last());


            
            _hiddenWordsIndex.RemoveAt(hiddenWordPlacement);
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