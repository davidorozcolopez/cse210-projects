using System;
using System.Runtime.Intrinsics.Arm;
public class Program
{
    static void Main(string[] args)
    {
        string verse = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, verse);
        Word word = new Word

        bool finished = false;
        bool hidden = false;
        while (!finished)
        {
            Console.Clear();
            scripture.DisplayScripture();
            System.Console.WriteLine("Press enter to continue, type 'quit' to exit.");
            var choice = System.Console.ReadLine();

            if (scripture.word != hidden)
            {
                if (choice == "quit")
                {
                    finished = true;
                }
                else
                {
                    scripture.HideThreeWords();
                }
            }
            else
            {
                finished = true;
            }
        }
    }
}