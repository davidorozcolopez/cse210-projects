class Listing: Activity
{
    public Listing() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public void StartListing(string randomPrompt, int duration)
    {
        
    }

    public string SelectRandomPrompt()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Who are the people that make you feel loved?");
        prompts.Add("What are you grateful for today?");
        prompts.Add("What are the things that made your day today?");
        prompts.Add("What are some things you were not expecting but were good surprises?");
        prompts.Add("What makes you happy?");
        prompts.Add("What helps you feel good when going through a hard time?");
        prompts.Add("What are some of your personal qualities that you are proud of?");
        prompts.Add("What are the things that you have complete control of?");

        Random randomNumGenerator = new Random();
        int randomIndex = randomNumGenerator.Next(0, prompts.Count);
        string randomPrompt = prompts[randomIndex];

        return randomPrompt;
    }
}