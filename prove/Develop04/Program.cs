using System;
using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
        bool finished = false;

        while (!finished)
        {
            System.Console.WriteLine(@"Menu Options: 
    1. Start breathing activity
    2. Start reflecting activity
    3. Start listing activity
    4. Quit");
            System.Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1) // Start breathing activity
            {
                Breathing breathingActivity = new Breathing();
                Console.Clear();

                System.Console.WriteLine(breathingActivity.GetStartMessage());
                int duration = breathingActivity.PromptDuration();
                Console.Clear();

                breathingActivity.DisplaySpinnerAnimation();
                breathingActivity.StartBreathing();

                System.Console.WriteLine(breathingActivity.GetEndMessage());

            }
            else if (choice == 2) // Start reflecting activity
            {
                
            }
            else if (choice == 3) // Start listing activity
            {
                
            }
            else if (choice == 4) // Quit
            {
                finished = true;
            }
            else // Handle invalid input for choice
            {
                System.Console.WriteLine("Please enter a valid whole number from 1 to 4.");
            }
        }
    }
}