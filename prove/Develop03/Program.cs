using System;
using System.Runtime.Intrinsics.Arm;
using Microsoft.VisualBasic;
public class Program
{
    static void Main(string[] args)
    {
        // hard-code the verse
        string verse = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        Reference reference = new Reference("John", 3, 16); // create a new instance of the Reference class and pass it parameters
        Scripture scripture = new Scripture(reference, verse); // create a new instance of the Scripture class and pass it parameters

        // set sentinel variables for the while loop
        bool finished = false;
        bool firstTime = true;

        while (!finished)
        {
            Console.Clear(); // clear the screen
            if (!firstTime) // start the hiding process once it is not the first time going through the loop
                scripture.HideThreeWords(); // reference scripture and call its method HideThreeWords() to hide 3 words every time we go through the loop
            
            scripture.DisplayScripture(); // reference scripture and call its method DisplayScripture() to display scripture

            if (scripture.IsHidden()) // if scripture is hidden, finish the program
            {
                finished = true;
            }
            else
            {
                System.Console.WriteLine("\nPress enter to continue, type 'quit' to exit."); // display instructions
                var choice = System.Console.ReadLine(); // receive user input
                if (choice == "quit") // if user types quit, finish the program
                {
                    finished = true;
                }
            }

            firstTime = false; // set firstTime variable to false
        }
    }
}