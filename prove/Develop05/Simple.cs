public class Simple: Goal
{
    public Simple() : base()
    {
    }

    public override void DisplayGoal()
    {
        // if goal has been completed, put an X, else, put a blank space instead
        System.Console.WriteLine($"[{(goalCompleted ? "X" : " ")}] {name} ({description})");
    }

    // public override void DisplayGoal(string prefix)
    // {
    //     System.Console.WriteLine($"{prefix}[{(goalCompleted ? "X" : " ")}] {name} ({description})");
    // }
}