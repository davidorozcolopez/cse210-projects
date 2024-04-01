using System.ComponentModel.DataAnnotations.Schema;

public abstract class Goal
{
    protected string name;
    protected string description;
    protected int goalPoints;
    protected bool goalCompleted;

    // Constructor that assigns values to the attributes
    public Goal()
    {
        System.Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();
        System.Console.Write("What is a short description of it? ");
        description = Console.ReadLine();
        System.Console.Write("What is the amount of points associated with this goal? ");
        goalPoints = int.Parse(Console.ReadLine());
        goalCompleted = false; // default value of goalCompleted is set to false
    }

    // polymorphism will be applied here by calling the right method / the right version of DisplayGoal()
    // that matches the custom data type of the goal, whether it is a Simple, Eternal or Checklist goal
    public abstract void DisplayGoal();

    // polymorphism will be applied here by calling the right method / the right version of SaveGoal()
    // that matches the custom data type of the goal, whether it is a Simple, Eternal or Checklist goal
    public abstract string SaveGoal();
    
    public void DisplayNameGoal()
    {
        System.Console.WriteLine($"{name}");
    }
}