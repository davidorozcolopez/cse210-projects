
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

}