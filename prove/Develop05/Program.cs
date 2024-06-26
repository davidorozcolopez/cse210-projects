using System;
using System.IO;
using Microsoft.VisualBasic;

public class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int totalPoints = 0; // default value of totalPoints is set to 0

        System.Console.WriteLine("___________________________________________________________________________________");
        System.Console.WriteLine("\n               Welcome to your personalized Goal Tracker Assistant!");
        System.Console.WriteLine("___________________________________________________________________________________");

        bool done = false;

        while (!done)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("-----------------------------------------------------------------------------------");
            System.Console.WriteLine($"You have {totalPoints} points.");
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
                System.Console.WriteLine("\nThe goals are: ");

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
                        // use polymorphism here by calling the right version of SaveGoal() to get the string with the correct
                        // format according to the custom data type of the goal, whether it is a Simple, Eternal or Checklist goal
                        string saveGoalInfo = goal.SaveGoal(); // get the formatted string with the goal info to save
                        outputFile.WriteLine(saveGoalInfo); // save goal: write goal info to file
                    }
                }
            }

            else if (choice == 4) // Load Goals (read from file)
            {
                System.Console.Write("\nWhat is the name of the file to read from? ");
                string filename = Console.ReadLine();
                
                string[] lines = System.IO.File.ReadAllLines(filename);

                totalPoints = int.Parse(lines[0]); // Import the previous totalPoints from the file being read

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");

                    if (parts[0] == "SimpleGoal")
                    {
                        goals.Add(new Simple(line));
                    }
                    else if (parts[0] == "EternalGoal")
                    {
                        goals.Add(new Eternal(line));
                    }
                    else if (parts[0] == "ChecklistGoal")
                    {
                        goals.Add(new Checklist(line));
                    }
                }
            }

            else if (choice == 5) // Record Event (record goal completion)
            {
                System.Console.WriteLine("\nThe goals are: ");

                for (var i = 0; i < goals.Count; ++i)
                {
                    System.Console.Write($"{i + 1}. "); // adjust i by adding 1 to start displaying count from 1 instead of 0
                    goals[i].DisplayGoal(); // access goal in goals list at that specific index, and display it using polymorphism
                    // polymorphism is applied here by calling the right method / the right version of DisplayGoal()
                    // that matches the custom data type of the goal, whether it is a Simple, Eternal or Checklist goal
                }

                System.Console.Write("\nWhich goal did you accomplish? (type in the number) ");
                int completedGoalNum = int.Parse(Console.ReadLine());

                totalPoints += goals[completedGoalNum - 1].RecordGoal(); // adjust completedGoal number by subtracting 1 to access the right goal at the right index from goals list
                // polymorphism is applied here by calling the right method / the right version of RecordGoal()
                // that matches the custom data type of the goal, whether it is a Simple, Eternal or Checklist goal

                System.Console.WriteLine($"\nYou now have {totalPoints} points.");
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