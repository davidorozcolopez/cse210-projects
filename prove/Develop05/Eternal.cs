public class Eternal: Goal
{
    public Eternal() : base()
    {
    }

    public override void DisplayGoal()
    {
        // always put a blank space inside the [brackets] since an eternal goal cannot be completed
        System.Console.WriteLine($"[ ] {name} ({description})");
    }
}