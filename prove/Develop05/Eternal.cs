public class Eternal: Goal
{
    public Eternal() : base()
    {
    }

    public Eternal(string line) : base(line)
    {
        string[] parts = line.Split(",");

        name = parts[1];
        description = parts[2];
        goalPoints = int.Parse(parts[3]);
    }

    public override void DisplayGoal()
    {
        // always put a blank space inside the [brackets] since an eternal goal cannot be completed
        System.Console.WriteLine($"[ ] {name} ({description})");
    }

    public override string SaveGoal()
    {
        return $"EternalGoal,{name},{description},{goalPoints}";
    }
}