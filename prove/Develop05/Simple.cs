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

    public override string SaveGoal()
    {
        return $"SimpleGoal,{name},{description},{goalPoints},{goalCompleted}";
    }

    public override void LoadGoal(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string goal = parts[0];
            string name = parts[1];
            string description = parts[2];
            int goalPoints = int.Parse(parts[3]);
            bool goalCompleted = bool.Parse(parts[4]);
        }
    }
}