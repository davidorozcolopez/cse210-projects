public class Event
{
    protected string type;
    protected string title;
    protected string description;
    protected string date;
    protected string time;
    protected string address;

    public Event(string type, string title, string description, string date, string time, string address)
    {
        this.type = type;
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        System.Console.WriteLine("\n_________________________________________________________________________");
        System.Console.WriteLine("\t\t\t > Standard Details");
        System.Console.WriteLine("_________________________________________________________________________");

        return $@"Title: {title}.
Description: {description}.
Date: {date}.
Time: {time}.
Address: {address}.";
    }

    public string GetShortDescription()
    {
        System.Console.WriteLine("\n_________________________________________________________________________");
        System.Console.WriteLine("\t\t\t > Short Description");
        System.Console.WriteLine("_________________________________________________________________________");

        return $@"Event type: {type}.
Title: {title}.
Date: {date}.";
    }

}