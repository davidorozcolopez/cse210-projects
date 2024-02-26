using System;
using System.ComponentModel.DataAnnotations;
class Word
{
    // declare attributes
    private string wordText; // the text by itself
    private bool hidden; // the characteristic to check whether word is hidden or not

    // create constructor with its single parameter
    public Word(string word) // every time we create a new instance of the Word class throughout the program, we feed it a string word and it creates a Word object
    {
        wordText = word; // the string word that we feed is the wordText
        hidden = false; // set the hidden characteristic to a default value of false, since at the beginning the words are not hidden
    }

    public void HideWord()
    {
        hidden = true; // set the hidden characteristic to true, to indicate that the word is now hidden
    }

    public bool WordIsHidden()
    {
        return hidden; // return value of the hidden characteristic whether it is true or false
    }

    public void DisplayWord()
    {
        if (hidden) // if word is already hidden
        {
            int length = wordText.Count(); // determine the length of the word by counting the characters in the wordText string

            for(var i = 0; i < length; i++) // display an underscore for each character in the word
            {
                System.Console.Write("_");
            }
        }
        else // if word is not hidden yet
        {
            System.Console.Write(wordText); // display its text by itself
        }
    }
}
