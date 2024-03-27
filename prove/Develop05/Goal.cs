using System.ComponentModel.DataAnnotations.Schema;

public abstract class Goal
{
    protected string name;
    protected string description;
    protected int goalPoints;

    protected bool goalCompleted;

    // Goal Constructor that assigns values to attributes
    public Goal()
    {
        System.Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();
        System.Console.Write("What is a short description of it? ");
        description = Console.ReadLine();
        System.Console.Write("What is the amount of points associated with this goal? ");
        goalPoints = int.Parse(Console.ReadLine());
    }

    public abstract void DisplayGoal();

    public void DisplayNameGoal()
    {
        System.Console.WriteLine($"{name}");
    }

    // public bool goalCompleted()
    // {
    //     if (Goal goal )
    //     {
    //         return true;
    //     }
    //     else
    //     {
    //         return false;
    //     }
    // }

    // public bool IsComplete()
    // {

    // }

    // public override PerformTask()
    // {

    // }
}