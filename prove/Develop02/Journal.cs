using Microsoft.VisualBasic;

public class Journal
{
    public List<Entry> entries;

    // Constructors
    public Journal()
    {
        entries = new List<Entry>(); // create a new list that holds Entry data type values and assign it to entries variable
    }

    public Journal(string[] importLines)
    {
        List<Entry> entries = new List<Entry>(); // ??? create (again?) a new list that holds Entry data type values and assign it to entries variable
        foreach (var line in importLines) // for each line in the importLines array of strings
        {
            var entry = new Entry(line); // create a new instance of class Entry, feed it a line as a parameter, and assign it to entry variable 
            entries.Add(entry); // add single entry to the list of entries
        }
    }

    public void DisplayJournal() // this function displays the complete journal
    {
        System.Console.WriteLine("\nJournal:\n");

        foreach (var entry in entries) // for each entry in the list of entries
        {
            System.Console.WriteLine(entry.DisplayEntry()); // use method DisplayEntry from class Entry
        }

        System.Console.WriteLine("\nPress any key to continue.");
        System.Console.ReadKey(); // continue with the program until any key is pressed
    }

    public void AddEntry(Entry entry) // this function adds a single entry to the list of entries
    {
        entries.Add(entry); // add single entry to list of entries
    }

    public string[] ExportJournal()
    {
        var linesToBeWrittenIntoFile = new List<string>(); // create a new list of strings and assign it to the linesToBeWrittenIntoFile variable
        foreach (var entry in entries)
        {
            linesToBeWrittenIntoFile.Add(entry.ExportEntry());
        }
        return linesToBeWrittenIntoFile.ToArray();
    }

}