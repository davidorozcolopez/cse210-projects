public class Checklist: Goal
{
    private int maxCount;
    private int currentCount;
    private int bonusPoints;

    public Checklist() : base()
    {
        System.Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        maxCount = int.Parse(Console.ReadLine());
        System.Console.Write("What is the bonus for accomplishing it that many times? ");
        bonusPoints = int.Parse(Console.ReadLine());
        currentCount = 0; // default value of currentCount is set to 0
    }

    public Checklist(string line) : base(line)
    {
        string[] parts = line.Split(",");

        name = parts[1];
        description = parts[2];
        goalPoints = int.Parse(parts[3]);
        bonusPoints = int.Parse(parts[4]);
        maxCount = int.Parse(parts[5]);
        currentCount = int.Parse(parts[6]);
        goalCompleted = bool.Parse(parts[7]);
    }

    public override void DisplayGoal()
    {
        // if goal has been completed, put an X, else, put a blank space instead
        System.Console.WriteLine($"[{(goalCompleted ? "X" : " ")}] {name} ({description}) - Currently completed: {currentCount}/{maxCount}");
    }

    public override string SaveGoal()
    {
        return $"ChecklistGoal,{name},{description},{goalPoints},{bonusPoints},{maxCount},{currentCount},{goalCompleted}";
    }

    public override int RecordGoal()
    {
        currentCount++;
        if (currentCount < maxCount) // handle cases when maxCount has not been reached yet
        {
            System.Console.WriteLine($"Congatulations! You have earned {goalPoints} points!");
            return goalPoints;
        }
        else // handle the case when the currentCount == maxCount. Add the bonus points and set goalCompleted to true.
        {
            System.Console.WriteLine($"Congatulations! You have earned {goalPoints + bonusPoints} points!");
            goalCompleted = true;
            return goalPoints + bonusPoints;
        }
    }
}