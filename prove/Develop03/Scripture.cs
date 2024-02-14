using System;
using System.Security.Cryptography.X509Certificates;

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
            words.Append(singleWord);
        }
    }

    public HideThreeWords()
    {

    }
}