using System;
class Scripture
{
    // declare needed attributes
    private Reference reference;
    private List<Word> words = new List<Word>();

    // create constructor with its parameters
    public Scripture(Reference reference, string verse)
    {
        this.reference = reference; // assign parameter value to attribute
        List<string> wordsList = verse.Split(" ").ToList(); // split the string verse into substrings and convert it into a list of strings 
        foreach (string word in wordsList) // for each string word in wordsList
        {
            Word singleWord = new Word(word); // create a new Word object by feeding it the word and storing it in a new variable
            words.Add(singleWord); // add it to the previously declared list that holds Word data types - List<Word> words
        }
    }

    public void HideThreeWords()
    {
        for (int i = 0; i < 3; i++) // iterate through loop 3 times
        {
            Random randomNumGenerator = new Random(); // create a new instance of the Random class and assign it to randomNumGenerator variable
            int randomIndex = randomNumGenerator.Next(0, words.Count); // generate a random number between the range of 0 and the length of the list of words, using the Next method, and assign it to the randomIndex variable
            var randomWord = words[randomIndex]; // using the randomIndex, access the element (the word) of the list words at that specific index and assign it to a Word class instance - randomWord
            randomWord.HideWord(); // reference the Word class instance - randomWord - and call the Word class method HideWord() to hide single word
        }
    }
    
    public void DisplayScripture()
    {
        reference.DisplayReference(); // reference the Reference class instance - reference - and call the Reference class method DisplayReference() to display reference
        foreach (Word word in words) // for each word in the list of words, all of them being Word data types
        {
            word.DisplayWord(); // reference the Word class instance - word - and call the Word class method DisplayWord() to display word
            System.Console.Write(" "); // display a blank space right after each word for correct formatting
        }
    }

    public bool IsHidden()
    {
        foreach (Word word in words) // for each word in the list of words, all of them being Word data types
        {
            bool hiddenState = word.WordIsHidden(); // reference Word class instance - word - and call its method WordIsHidden() to return a true/false value to hiddenState variable
            if (!hiddenState) // if word is not hidden, exit the loop and return false
            {
                return false;
            }
        }

        return true; // if all words are hidden, return true
    }
}