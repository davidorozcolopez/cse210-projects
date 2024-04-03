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

    public override string SaveGoal()
    {
        return $"EternalGoal,{name},{description},{goalPoints}";
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
        }
    }
}