public class Reception: Event
{
    private string registrationEmail;

    public Reception(string type, string title, string description, string date, string time, string address, string registrationEmail) : base(type, title, description, date, time, address)
    {
        this.registrationEmail = registrationEmail;
    }
    
    public string GetFullDetails()
    {
        System.Console.WriteLine("\n_________________________________________________________________________");
        System.Console.WriteLine("\t\t\t > Full Details");
        System.Console.WriteLine("_________________________________________________________________________");

        return $@"Title: {title}.
Event Type: {type}.
Description: {description}.
Date: {date}. Time: {time}.
Address: {address}.
Registration email: {registrationEmail}.";
    }
}