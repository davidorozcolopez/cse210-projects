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
                
                System.Console.WriteLine("Get ready...");
                breathingActivity.DisplaySpinnerAnimation();
                breathingActivity.StartBreathing(duration);
                Console.Clear();

                System.Console.WriteLine(breathingActivity.GetEndMessage());
                breathingActivity.DisplaySpinnerAnimation();
                Console.Clear();
            }
            else if (choice == 2) // Start reflecting activity
            {
                Reflecting reflectingActivity = new Reflecting();
                Console.Clear();

                System.Console.WriteLine(reflectingActivity.GetStartMessage());
                int duration = reflectingActivity.PromptDuration();
                Console.Clear();
                
                System.Console.WriteLine("Get ready...");
                reflectingActivity.DisplaySpinnerAnimation();
                string randomPrompt = reflectingActivity.SelectRandomPrompt();
                reflectingActivity.StartReflecting(randomPrompt, duration);
                Console.Clear();
                
                System.Console.WriteLine(reflectingActivity.GetEndMessage());
                reflectingActivity.DisplaySpinnerAnimation();
                Console.Clear();
            }
            else if (choice == 3) // Start listing activity
            {
                Listing listingActivity = new Listing();
                Console.Clear();

                System.Console.WriteLine(listingActivity.GetStartMessage());
                int duration = listingActivity.PromptDuration();
                Console.Clear();

                System.Console.WriteLine("Get ready...");
                listingActivity.DisplaySpinnerAnimation();
                string randomPrompt = listingActivity.SelectRandomPrompt();
                listingActivity.StartListing(randomPrompt, duration);
                listingActivity.DisplaySpinnerAnimation();
                Console.Clear();

                System.Console.WriteLine(listingActivity.GetEndMessage());
                listingActivity.DisplaySpinnerAnimation();
                Console.Clear();
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