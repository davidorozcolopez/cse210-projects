
public class Goal
{
    protected int points;
    protected string name;
    protected string description;

    public Goal()
    {
        System.Console.WriteLine("What is the name of your goal? ");
        name = Console.ReadLine();
        System.Console.WriteLine("What is a short description of it? ");
        description = Console.ReadLine();
        System.Console.WriteLine("What is the amount of points associated with this goal? ");
        points = int.Parse(Console.ReadLine());
    }

    public int GetPoints()
    {

    }

    public string GetName()
    {

    }

    public string GetDescription()
    {

    }

    public void RecordEvent()
    {

    }

    public bool IsComplete()
    {

    }

    public void GoalMenu()
    {

    }

    public override PerformTask()
    {

    }
}