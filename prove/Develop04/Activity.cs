class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public int PromptDuration()
    {
        System.Console.Write("\nHow long, in seconds, would you like for your session? ");
        return duration = int.Parse(Console.ReadLine());
    }

    public bool CheckTime() // Passing currentTime as parameter?
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration); // futureTime is the maxTime

        DateTime currentTime = DateTime.Now; // Or is this how I should do it?

        if (currentTime < futureTime)
        {
            return false; // time has not reached desired duration
        }

        return true; // time has reached desired duration
    }

    public void DisplayCountDown(int max_num) // count down from max_num to 0
    {
        for (int i = max_num; i > 0; i--)
        {
            System.Console.Write(i);
            Thread.Sleep(1000); // Pause for one second
            System.Console.Write("\b \b");
        }
    }

    public void DisplaySpinnerAnimation()
    {
        System.Console.WriteLine("Get ready...");

        List<string> spinnerStrings = new List<string>();
        spinnerStrings.Add("|");
        spinnerStrings.Add("/");
        spinnerStrings.Add("-");
        spinnerStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string spinnerSequence = spinnerStrings[i];
            System.Console.Write(spinnerSequence);
            Thread.Sleep(500); // Pause for half a second
            System.Console.Write("\b \b");

            i++;

            if (i >= spinnerStrings.Count)
            {
                i = 0;
            }
        }
    }

    public string GetStartMessage()
    {
        return $@"Welcome to the {name}!

{description}";
    }

    public string GetEndMessage()
    {
        return $@"Good job!

You have completed another {duration} seconds of the {name}.";
    }
}