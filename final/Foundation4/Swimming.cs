public class Swimming: Activity
{
    private double laps;

    public Swimming(string name, string date, double duration, double laps) : base(name, date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {   
        double distance = laps * (50.0 / 1000.0) * 0.62;
        return Math.Round(distance, 2);
    }

    public override double GetSpeed()
    {
        double speed = (GetDistance() / duration) * 60;
        return Math.Round(speed, 2);
    }

    public override double GetPace()
    {
        double pace = (60 / GetSpeed());
        return Math.Round(pace, 2);
    }
}