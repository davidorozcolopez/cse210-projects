using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using Microsoft.VisualBasic;
using static System.Random;
using System.IO;

class Program
{
    static List<string> prompts = new List<string>() // create a new list that holds strings and assign it to prompts variable
        {
            "What was the best part of my day? ",                             // individual prompts
            "Who was the most interesting person I interacted with today? ",
            "How did I see the hand of the Lord in my life today? ",
            "What was the strongest emotion I felt today? ",
            "If I had one thing I could do over today, what would it be? ",
        };

    static void Main(string[] args) // main function
    {
        Journal journal = new Journal(); // create a new instance of the class Journal and assign it to journal variable

        bool finished = false;

        while (finished == false)
        {
            Console.Clear(); // clear screen for a better user interface
            int choice = DisplayMenu(); // call DisplayMenu function and assign returned value to choice variable
            
            if (choice == 1) // write a new entry: display random prompt, save their response, the prompt, and the date as an Entry.
            {
                var prompt = ChooseRandomPrompt(); // display random prompt
                System.Console.WriteLine(prompt);
                DateTime currentDate = DateTime.Now; // create a new instance (new object) of the class DateTime and assign it to currentDate variable
                string programDate = currentDate.ToShortDateString(); // get a short date string and assign it to programDate variable
                string userResponse = Console.ReadLine(); // read input from the user and assign it to userResponse variable
                Entry singleEntry = new Entry(programDate, prompt, userResponse); // 
                journal.AddEntry(singleEntry); // use AddEntry method from class Journal, to add current entry to the list of entries held by the Journal object
            }
            else if (choice == 2) // display the complete journal
            {
                journal.DisplayJournal(); // use method DisplayJournal() from class Journal
            }
            else if (choice == 3) // load the journal from a file
            {
                string[] fileImportedLines = ReadFile(); // call ReadFile function and store the returned array of strings into fileImportedLines variable
                journal = new Journal(fileImportedLines);
            }
            else if (choice == 4) // save the journal to a file
            {
                string[] linesToBeWrittenIntoFile = journal.ExportJournal(); // use method ExportJournal from class Journal, and store the returned array of strings into the linesToBeWrittenIntoFile variable
                WriteFile(linesToBeWrittenIntoFile); // call WriteFile function to write the array of strings linesToBeWrittenIntoFile into the text file
            }
            else if (choice == 5) // quit/exit
            {
                finished = true; // set boolean variable finished to true in order to exit the while loop
            }
            else
            {
                System.Console.WriteLine("Please write a valid number from 1 to 5.");
            }
        }
    }

    static int DisplayMenu() // this function displays menu and returns the number of the choice given by the user
    {
        System.Console.WriteLine("Please choose one of the following options:");
        System.Console.WriteLine("1. Write");
        System.Console.WriteLine("2. Display");
        System.Console.WriteLine("3. Load");
        System.Console.WriteLine("4. Save");
        System.Console.WriteLine("5. Quit");
        System.Console.WriteLine("What would you like to do? ");
        int choice = int.Parse(Console.ReadLine()); // read user input, convert it from a string to an integer, and assign it to choice variable
        return choice; // return choice variable, which holds the number of the choice given by the user
    }

    // this function receives a list of strings called prompts, and returns a single random prompt
    static string ChooseRandomPrompt()
    {
        Random randomNumGenerator = new Random(); // create a new instance of the class Random and assign it to randomNumGenerator variable
        int randomIndex = randomNumGenerator.Next(0, prompts.Count); // generate a random number between the range of 0 and the length of the list of prompts, using the Next method, and assign it to the randomIndex variable
        return prompts[randomIndex]; // using the randomIndex, access the element (the prompt) of the list prompts at that specific index and return it as a string
    }

    static void WriteFile(string[] lines) // this function receives an array of strings (lines), and writes it into a new text file as indicated by the user (filename)
    {
        System.Console.Write("What is the filename? "); // prompt the user for filename
        string filename = Console.ReadLine(); // read user input and store it in filename variable
        System.IO.File.WriteAllLines(filename, lines); // create a new text file (filename), write all lines from the provided array of strings (lines) into file, close the file  
    }

    static string[] ReadFile() // this function reads from a file and returns an array of strings
    {
        System.Console.Write("What is the filename? "); // prompt the user for filename
        string filename = Console.ReadLine(); // read user input and store it in filename variable
        return System.IO.File.ReadAllLines(filename); // open the text file (filename), read all lines from the file and return them as an array of strings, close the file
    }

}