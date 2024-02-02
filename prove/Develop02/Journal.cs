// Add here the methods that I need class Journal to have according to the class Program
public class Journal
{
    public List<Entry> entries;

    // Constructors

    public Journal()
    {
        List<Entry> entries = new List<Entry>(); // create a new list that holds Entry data type values and assign it to entries variable
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

    public string ImportJournal(string)
    {
        
    }

    public string ExportJournal(string filename)
    {

    }

    public void SaveJournal()
    {
            
    }

    public Journal LoadJournal()
    {

    }        
}