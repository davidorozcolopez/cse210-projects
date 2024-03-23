using System;

class Program
{
    static void Main(string[] args)
    {
        bool done = false;

        while (!done)
        {
            System.Console.WriteLine();
            System.Console.WriteLine(@"Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit");
            System.Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1) // Create New Goal
            {
                System.Console.WriteLine();
                System.Console.WriteLine(@"The types of goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal");
                System.Console.Write("Which type of goal would you like to create? ");
                int goalChoice = int.Parse(Console.ReadLine());

                if (goalChoice == 1) // Simple Goal
                {
                    System.Console.WriteLine("Simple Goal test");
                }
                else if (goalChoice == 2) // Eternal Goal
                {
                    System.Console.WriteLine("Eternal Goal test");
                }
                else if (goalChoice == 3) // Checklist Goal
                {
                    System.Console.WriteLine("Checklist Goal test");
                }
                else // Handle invalid choice input
                {
                    System.Console.WriteLine("Please enter a valid choice from 1 to 3.");
                }
            }
            else if (choice == 2) // List Goals
            {

            }
            else if (choice == 3) // Save Goals
            {

            }
            else if (choice == 4) // Load Goals
            {

            }
            else if (choice == 5) // Record Event
            {

            }
            else if (choice == 6) // Quit
            {
                done = true;
            }
            else // Handle invalid choice input
            {
                System.Console.WriteLine("Please enter a valid choice from 1 to 6.");
            }
        }
    }
}