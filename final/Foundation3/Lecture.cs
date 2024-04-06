public class Lecture: Event
{
    private string speaker;
    private int capacity;

    public Lecture(string type, string title, string description, string date, string time, Address address, string speaker, int capacity) : base(type, title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public string GetFullDetails()
    {
        return $@"Title: {title}. Event Type: {type}. Description: {description}.
Date: {date}. Time: {time}. Address: {address}.
Speaker: {speaker}. Capacity: {capacity}.";
    }
}