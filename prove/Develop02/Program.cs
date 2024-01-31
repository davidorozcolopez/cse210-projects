using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Program
{
    static void Main(string[] args)
    {
        public Journal journal;
        public List<string> prompts = new List<string>()
        {
            "What was the best part of my day? ",
            "Who was the most interesting person I interacted with today? ",
            "How did I see the hand of the Lord in my life today? ",
            "What was the strongest emotion I felt today? ",
            "If I had one thing I could do over today, what would it be? ",
        };

        // Constructor
        public Program(Journal programJournal){
            journal = programJournal;
        }

        public string GeneratePrompt()
        {
            int index = Random(0, prompts.Count);
            return prompts[index];
        }
        public Entry CreateEntry()
        {
            
        }

        public void ShowPrompt()
        {
            System.Console.WriteLine(string prompt);
        }

        public void DisplayJournal()
        {
            System.Console.WriteLine(string[] journal);
        }

        public void SaveJournal()
        {

        }

        public string GetFilename()
        {

        }

        public Journal LoadJournal()
        {

        }

        public var DisplayMenu()
        {
            System.Console.WriteLine(string menu);
        }
    }
}