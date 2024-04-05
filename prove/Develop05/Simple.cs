public class Simple: Goal
{
    public Simple() : base()
    {
    }

    public Simple(string line) : base(line)
    {
        string[] parts = line.Split(",");

        name = parts[1];
        description = parts[2];
        goalPoints = int.Parse(parts[3]);
        goalCompleted = bool.Parse(parts[4]);
    }

    public override void DisplayGoal()
    {
        // if goal has been completed, put an X, else, put a blank space instead
        System.Console.WriteLine($"[{(goalCompleted ? "X" : " ")}] {name} ({description})");
    }

    public override string SaveGoal()
    {
        return $"SimpleGoal,{name},{description},{goalPoints},{goalCompleted}";
    }

    public override int RecordGoal()
    {
        System.Console.WriteLine($"Congatulations! You have earned {goalPoints} points!");
        goalCompleted = true;

        return goalPoints;
    }
}