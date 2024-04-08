public class Running: Activity
{
    private double distance;

    public Running(string name, string date, double duration, double distance) : base(name, date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return Math.Round(distance, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round((distance / duration) * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round((60 / GetSpeed()), 2);
    }
}