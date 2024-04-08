public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Welcome to Fitness for Life!
This program will help you track your exercise!");
        
        // Create activities
        Running runningActivity = new Running("Running", "07 April 2024", 30, 3.0);
        Cycling cyclingActivity = new Cycling("Cycling", "08 April 2024", 60, 5.0);
        Swimming swimmingActivity = new Swimming("Swimming", "10 Apr 2024", 120, 50);

        // Create list of activities and populate it
        List<Activity> activities = new List<Activity>();
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        // Compute distance, speed and pace for each activity
        // Display results in a summary
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