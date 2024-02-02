
public class Entry
{
    public string date;
    public string prompt;
    public string response;
    List<Entry> entries;

    // Constructor
    public Entry(string programDate, string programPrompt, string userResponse)
    {
        date = programDate;
        prompt = programPrompt;
        response = userResponse; // assign parameters of the constructor function to the attributes of the class Entry (that's how we connect them)
    }

    public Entry(string importEntry) // another constructor function. This function receives an importEntry as a string from the Journal class and separates the values of said entry
    {
        string[] entryParts = importEntry.Split("|"); // split string importEntry into parts, return an array of strings to the entryParts variable (array of strings)
        date = entryParts[0];     // assign element at index 0 of the array to the date variable
        prompt = entryParts[1];   // assign element at index 1 of the array to the prompt variable
        response = entryParts[2]; // assign element at index 2 of the array to the response variable
    }

    public string ExportEntry() // ?? (No parameters needed here?) this function exports a single entry with its parts separated by the delimiter "|"
    {
        return $"{date}|{prompt}|{response}";
    }

    public string DisplayEntry() // this function displays an entry by returning a formatted string where the parts of an entry are joined together
    {
        return $"Date: {date} - Prompt: {prompt} \n{response}";
    }

    public void AddEntry() // this function adds a single entry to the list of entries
    {
        var entry = new Entry(date, prompt, response); // create a new instance of the class Entry, use constructor of Entry, and assign it to entry variable
        entries.Add(entry); // add single entry to list of entries
    }
}