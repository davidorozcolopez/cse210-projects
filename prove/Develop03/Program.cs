using System;
using System.Runtime.Intrinsics.Arm;
using Microsoft.VisualBasic;
public class Program
{
    static void Main(string[] args)
    {
        string verse = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, verse);

        bool finished = false;
        bool firstTime = true;
        while (!finished)
        {
            Console.Clear();
            if (!firstTime)
                scripture.HideThreeWords();
            scripture.DisplayScripture();
            if (scripture.IsHidden())
            {
                finished = true;
            }
            else
            {
                System.Console.WriteLine("Press enter to continue, type 'quit' to exit.");
                var choice = System.Console.ReadLine();
                if (choice == "quit")
                {
                    finished = true;
                }
            }
            firstTime = false;
        }
    }
}