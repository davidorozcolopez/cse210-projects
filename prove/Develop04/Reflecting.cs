class Reflecting: Activity
{
    public Reflecting() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }

    public void StartReflecting(string randomPrompt, int duration)
    {
        System.Console.Write($@"
Consider the following prompt:

--- {randomPrompt} ---

When you have something in mind, press enter to continue.
");
        System.Console.ReadLine(); // wait until user presses enter

        System.Console.Write(@"Now ponder on each of the following questions as they relate to this experience.

You may begin in: ");
        base.DisplayCountDown(7);
        Console.Clear();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            DisplayRandomQuestion();
            base.DisplaySpinnerAnimation();
        }
    }

    public string SelectRandomPrompt()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Think of a time when you accomplished something really difficult.");
        prompts.Add("Ponder about an experience that helped you improve.");
        prompts.Add("Remember that day when you taught something useful to someone else.");
        prompts.Add("Think of that time when you felt a rewarding feeling because of something you did.");
        prompts.Add("Consider that experience when you finished a long/hard task.");
        prompts.Add("Ponder about that moment when you felt successful.");

        Random randomNumGenerator = new Random();
        int randomIndex = randomNumGenerator.Next(0, prompts.Count);
        string randomPrompt = prompts[randomIndex];

        return randomPrompt;
    }

    private void DisplayRandomQuestion()
    {
        List<string> questions = new List<string>();
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What was different about this experience from others?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What did you learn from this?");
        questions.Add("How could you apply this to other areas of your life?");
        questions.Add("How can you keep this experience in mind in the future?");
        questions.Add("How would you like to put into practice the lesson you learned that day?");
        questions.Add("How was your mindset that day?");
        questions.Add("What skills were important for you to accomplish that?");

        Random randomNumGenerator = new Random();
        int randomIndex = randomNumGenerator.Next(0, questions.Count);
        string randomQuestion = questions[randomIndex];

        System.Console.WriteLine($"> {randomQuestion}");
    }
}