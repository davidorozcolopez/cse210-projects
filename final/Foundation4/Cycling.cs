public class Cycling: Activity
{
    private double speed;

    public Cycling(string name, string date, double duration, double speed) : base(name, date, duration)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return (speed / 60) * duration;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }
}