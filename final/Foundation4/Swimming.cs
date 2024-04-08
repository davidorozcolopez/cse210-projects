public class Swimming: Activity
{
    private double laps;

    public Swimming(string name, string date, double duration, double laps) : base(name, date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {   
        return laps * (50 / 1000) * 0.62; // Convert.ToDouble needed?
    }

    public override double GetSpeed()
    {
        return (GetDistance() / duration) * 60;
    }

    public override double GetPace()
    {
        return (60 / GetSpeed());
    }
}