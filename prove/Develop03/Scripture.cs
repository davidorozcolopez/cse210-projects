using System;
class Scripture
{
    private Reference reference;
    private List<Word> words = new List<Word>();

    public Scripture(Reference reference, string verse)
    {
        this.reference = reference;
        List<string> wordsList = verse.Split(" ").ToList();
        foreach (string word in wordsList)
        {
            Word singleWord = new Word(word);
            words.Add(singleWord);
        }
    }

    public void HideThreeWords()
    {
        for (int i = 0; i < 3; i++)
        {
            Random randomNumGenerator = new Random(); // create a new instance of the class Random and assign it to randomNumGenerator variable
            int randomIndex = randomNumGenerator.Next(0, words.Count); // generate a random number between the range of 0 and the length of the list of prompts, using the Next method, and assign it to the randomIndex variable
            var randomWord = words[randomIndex]; // using the randomIndex, access the element (the prompt) of the list prompts at that specific index and return it as a string
            randomWord.HideWord(); //
        }
    }
    
    public void DisplayScripture()
    {
        reference.DisplayReference();
        foreach (Word word in words)
        {
            word.DisplayWord();
            System.Console.Write(" ");
        }
    }

    public bool IsHidden()
    {
        foreach (Word word in words)
        {
            bool hiddenState = word.WordIsHidden();
            if (!hiddenState)
            {
                return false;
            }
        }
        return true;
    }
}