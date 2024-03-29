public class Entry
{
    public string date;
    public string prompt;
    public string response;

    // Constructors
    public Entry(string programDate, string programPrompt, string userResponse)
    {
        date = programDate;
        prompt = programPrompt;
        response = userResponse; // assign parameters of the constructor function to the attributes of the class Entry
    }

    public Entry(string importedEntry) // another constructor function, used for another purpose. This function receives an importedEntry as a string from the Journal class and separates the values of said entry
    {
        string[] entryParts = importedEntry.Split("|"); // split string importedEntry into parts, return an array of strings to the entryParts variable (array of strings)
        date = entryParts[0];     // assign element at index 0 of the array to the date variable
        prompt = entryParts[1];   // assign element at index 1 of the array to the prompt variable
        response = entryParts[2]; // assign element at index 2 of the array to the response variable
    }

    public string ExportEntry() // this function exports a single entry with its parts separated by the delimiter "|"
    {
        return $"{date}|{prompt}|{response}";
    }

    public string DisplayEntry() // this function displays an entry by returning a formatted string where the parts of an entry are joined together
    {
        return $"Date: {date} - Prompt: {prompt} \n{response}";
    }

}