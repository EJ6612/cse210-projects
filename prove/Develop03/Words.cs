/*
Sources: 
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements
https://stackoverflow.com/questions/12247147/c-sharp-adding-string-to-another-string
*/

class Words 
{
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

}