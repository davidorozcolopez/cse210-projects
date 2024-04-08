public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Welcome to Fitness for Life!
This program will help you track your exercise!");

        Running runningActivity = new Running("Running", "07 April 2024", 30, 3.0);
        Cycling cyclingActivity = new Cycling("Cycling", "08 April 2024", 60, 5.0);
        Swimming swimmingActivity = new Swimming("Swimming", "10 Apr 2024", 120, 50);

        List<Activity> activities = new List<Activity>();
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        foreach (Activity activity in activities)
        {
            double distance = activity.GetDistance();
            double speed = activity.GetSpeed();
            double pace = activity.GetPace();
            System.Console.WriteLine(activity.GetSummary(distance, speed, pace));
        }

        System.Console.WriteLine("\nGreat workout!");
    }
}