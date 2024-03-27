using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int totalPoints;

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
                    Simple simpleGoal = new Simple();
                    goals.Add(simpleGoal);
                }
                else if (goalChoice == 2) // Eternal Goal
                {
                    Eternal eternalGoal = new Eternal();
                    goals.Add(eternalGoal);
                }
                else if (goalChoice == 3) // Checklist Goal
                {
                    Checklist checklistGoal = new Checklist();
                    goals.Add(checklistGoal);
                }
                else // Handle invalid choice input
                {
                    System.Console.WriteLine("Please enter a valid choice from 1 to 3.");
                }
            }
            else if (choice == 2) // List Goals
            {
                foreach (Goal goal in goals)
                {
                    goal.DisplayGoal( );
                }
            }
            else if (choice == 3) // Save Goals
            {
                for(var i=0;i<goals.Count; ++i) {
                    System.Console.Write($"{i}. ");
                    goals[i].DisplayGoal();
                }
            }
            else if (choice == 4) // Load Goals
            {

            }
            else if (choice == 5) // Record Event
            {
                System.Console.WriteLine("The goals are:");
                foreach (Goal goal in goals)
                {
                    goal.DisplayNameGoal();
                }
                System.Console.Write("Which goal did you accomplish? ");
                int completedGoal = int.Parse(Console.ReadLine());

                // System.Console.WriteLine($"Congratulations! You have earned {goalPoints} points!");
                // System.Console.WriteLine($"You now have {totalPoints}");
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