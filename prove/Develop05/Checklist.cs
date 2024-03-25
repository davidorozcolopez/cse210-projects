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
    }

    public override void DisplayGoal()
    {
        System.Console.WriteLine($"[ ] {name} ({description}) - Currently completed: {currentCount}/{maxCount}");
    }
    
}