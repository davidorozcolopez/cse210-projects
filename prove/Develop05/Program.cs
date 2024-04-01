using System;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int totalPoints = 0; // default value of totalPoints is set to 0

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
                    System.Console.WriteLine("Please enter a valid whole number from 1 to 3.");
                }
            }

            else if (choice == 2) // List Goals
            {
                System.Console.WriteLine("The goals are: ");

                for (var i = 0; i < goals.Count; ++i)
                {
                    System.Console.Write($"{i + 1}. ");
                    goals[i].DisplayGoal(); // access goal in goals list at that specific index, and display it using polymorphism
                    // polymorphism is applied here by calling the right method / the right version of DisplayGoal()
                    // that matches the custom data type of the goal, whether it is a Simple, Eternal or Checklist goal
                }
            }

            else if (choice == 3) // Save Goals (write to file)
            {
                System.Console.Write("\nWhat is the name of the file to write to? ");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine($"{totalPoints}");

                    foreach (Goal goal in goals) // for each goal in goals list
                    {
                        string saveGoalInfo = goal.SaveGoal(); // get the formatted string with the goal info to save
                        // use polymorphism here by calling the right version of SaveGoal() to get the string with the correct format
                        // according to the custom data type of the goal, whether it is a Simple, Eternal or Checklist goal
                        outputFile.WriteLine(saveGoalInfo); // save goal: write goal info to file
                    }
                }
            }

            else if (choice == 4) // Load Goals (read from file)
            {

            }

            else if (choice == 5) // Record Event (record goal completion)
            {
                System.Console.WriteLine("The goals are:");
                foreach (Goal goal in goals)
                {
                    goal.DisplayNameGoal();
                }
                System.Console.Write("Which goal did you accomplish? ");
                int completedGoal = int.Parse(Console.ReadLine());

                // Remember here to adjust the goalCompleted variable (state) to be set to True now.

                // System.Console.WriteLine($"Congratulations! You have earned {goalPoints} points!");
                // System.Console.WriteLine($"You now have {totalPoints}");
            }

            else if (choice == 6) // Quit
            {
                done = true;
            }

            else // Handle invalid choice input
            {
                System.Console.WriteLine("Please enter a valid whole number from 1 to 6.");
            }
        }
    }
}