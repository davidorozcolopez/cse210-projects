class Checklist: Goal
{
    private int count;
    private int bonusPoints;

    public Checklist() : base()
    {
        System.Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        count = int.Parse(Console.ReadLine());
        System.Console.Write("What is the bonus for accomplishing it that many times? ");
        bonusPoints = int.Parse(Console.ReadLine());
    }

    
}