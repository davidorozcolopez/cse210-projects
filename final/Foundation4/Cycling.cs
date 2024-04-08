public class Cycling: Activity
{
    private double speed;

    public Cycling(string name, string date, double duration, double speed) : base(name, date, duration)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return Math.Round((speed / 60) * duration, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round(speed, 2);
    }

    public override double GetPace()
    {
        return Math.Round(60 / speed, 2);
    }
}