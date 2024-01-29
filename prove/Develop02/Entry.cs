
public class Entry
{
    public string response;
    public string prompt;
    public string date;

    // Constructor
    public Entry(string import, string programPrompt, string programDate){
        response = import;
        prompt = programPrompt;
        date = programDate;
    }

    public string exportEntry()
    {

    }
}