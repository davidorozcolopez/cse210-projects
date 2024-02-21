using System;
using System.ComponentModel.DataAnnotations;
class Word
{
    private string wordText;
    private bool hidden;

    public Word(string word)
    {
        wordText = word;
        hidden = false;
    }

    public void HideWord()
    {
        hidden = true;
    }

    public bool WordIsHidden()
    {
        return hidden;
    }

    public void DisplayWord() //
    {
        if (hidden)
        {
            int length = wordText.Count();
            for(var i = 0; i < length; i++)
            {
                System.Console.Write("_");
            }
        }
        else
        {
            System.Console.Write(wordText);
        }
    }
}
