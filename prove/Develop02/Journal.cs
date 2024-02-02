// Add here the methods that I need class Journal to have according to the class Program
public class Journal
{
    public List<Entry> entries;
    public string filename;

    // Constructor
    public Journal(string[] lines){
        entries = new List<Entry>();
        foreach(var line in lines){
            var entry = new Entry(line);
            entries.Add(entry);
        }
    };

    public string ImportJournal(string)
    {
        
    }

    public string ExportJournal(string filename)
    {

    }

    public void DisplayJournal()
    {
        System.Console.WriteLine(string[] journal);
    }

    public void SaveJournal()
    {
            
    }

    public Journal LoadJournal()
    {

    }        
}