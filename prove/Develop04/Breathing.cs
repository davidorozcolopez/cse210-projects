class Breathing: Activity
{
    public Breathing() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void StartBreathing(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration); // endTime is the maximum time

        while (DateTime.Now < endTime)
        {
            System.Console.Write("\n\nBreathe in...");
            base.DisplayCountDown(4);
            System.Console.Write("\nNow breathe out...");
            base.DisplayCountDown(4);
        }
    }
}