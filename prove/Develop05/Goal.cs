class Goal
{
    protected string name;
    protected string description;
    protected int points;

    // Goal Constructor that assigns values to attributes
    public Goal()
    {
        System.Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();
        System.Console.Write("What is a short description of it? ");
        description = Console.ReadLine();
        System.Console.Write("What is the amount of points associated with this goal? ");
        points = int.Parse(Console.ReadLine());
    }

    public string GetName()
    {
        return name;
    }

    public string GetDescription()
    {
        return description;
    }

    public int GetPoints()
    {
        return points;
    }

    // public void RecordEvent()
    // {

    // }

    // public bool IsComplete()
    // {

    // }

    // public override PerformTask()
    // {

    // }
}