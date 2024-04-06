public class Outdoor: Event
{
    private string weatherForecast;

    public Outdoor(string type, string title, string description, string date, string time, string address, string weatherForecast) : base(type, title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
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
Weather forecast: {weatherForecast}.";
    }
}