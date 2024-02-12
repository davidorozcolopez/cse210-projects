using System;
public class Job
{
    // Attributes
    public string company;
    public string jobTitle;
    public int startYear;
    public int endYear;

    // Method
    public void DisplayJob()
    {
        System.Console.WriteLine($"{jobTitle} ({company}) {startYear}-{endYear}"); // display job with all its components together in a nice format
    }
}