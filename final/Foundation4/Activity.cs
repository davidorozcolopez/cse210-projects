public abstract class Activity
{
    protected string name;
    protected string date;
    protected double duration;

    public Activity(string name, string date, double duration)
    {
        this.name = name;
        this.date = date;
        this.duration = duration;
    }

    abstract public double GetDistance();

    abstract public double GetSpeed();

    abstract public double GetPace();

    public string GetSummary(double distance, double speed, double pace)
    {
        return $"> {date} - {name} - ({duration} min) - Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";
    }
}