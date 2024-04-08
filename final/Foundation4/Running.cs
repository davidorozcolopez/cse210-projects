public class Running: Activity
{
    private double distance;

    public Running(string name, string date, double duration, double distance) : base(name, date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / duration) * 60;
    }

    public override double GetPace()
    {
        return (60 / GetSpeed());
    }
}