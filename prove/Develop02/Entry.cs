public class Entry
{
    public string response;
    public string prompt;
    public string date;

    // Constructor
    public Entry(string userResponse, string programPrompt, string programDate){
        response = userResponse;
        prompt = programPrompt;
        date = programDate;
    }

    public string ImportEntry()
    {
        entry = journal.entries;
        return entry;
    }

    public List<Entry> ExportEntry()
    {
        List<Entry> entries = new List<Entry>();
        return entries;
    }
}