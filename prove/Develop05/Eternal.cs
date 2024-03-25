public class Eternal: Goal
{
    public Eternal() : base()
    {
    }

    public override void DisplayGoal()
    {
        System.Console.WriteLine($"[ ] {name} ({description})");
    }
}