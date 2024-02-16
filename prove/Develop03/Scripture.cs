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

        //blerp
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


        //blerps
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
    }
}