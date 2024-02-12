using System;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job(); // create a new instance of Job class and assign it to job1
        job1.company = "Micron"; // assign values to job1 attributes
        job1.jobTitle = "Computer Engineer";
        job1.startYear = 2020;
        job1.endYear = 2025;

        Job job2 = new Job(); // create a new instance of Job class and assign it to job2
        job2.company = "Intel"; // assign values to job2 attributes
        job2.jobTitle = "Hardware Engineer";
        job2.startYear = 2026;
        job2.endYear = 2035;

        Resume resume1 = new Resume(); // create a new instance of Resume class and assign it to resume1
        resume1.name = "David Orozco"; // assign value to resume1 name attribute
        resume1.jobs.Add(job1); // add job1 to the list of jobs in the resume1 object
        resume1.jobs.Add(job2); // add job2 to the list of jobs in the resume1 object
        resume1.DisplayResume(); // call the DisplayResume() method of Resume class
    }
}