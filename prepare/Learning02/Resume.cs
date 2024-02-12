using System;
public class Resume
{
    // Attributes
    public string name;

    public List<Job> jobs = new List<Job>(); // create a new instance of a list that holds Job data type values and assign it to jobs 

    // Method
    public void DisplayResume()
    {
        System.Console.WriteLine($"Name: {name}");
        System.Console.WriteLine("Jobs:");

        foreach (Job job in jobs) // for each job of data type Job in the list of jobs
        {
            job.DisplayJob(); // call the DisplayJob() method of Job class
        }
    }
}