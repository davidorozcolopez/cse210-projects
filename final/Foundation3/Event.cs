public class Event
{
    protected string type;
    protected string title;
    protected string description;
    protected string date;
    protected string time;
    protected Address address;

    public Event(string type, string title, string description, string date, string time, Address address)
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
        return $"Title: {title}. Description: {description}. Date: {date}. Time: {time}. Address: {address}.";
    }

    public string GetShortDescription()
    {
        return $"Event type: {type}. Title: {title}. Date: {date}.";
    }

}