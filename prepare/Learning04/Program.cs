using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        // Create an Assignment object
        Assignment assignment = new Assignment("Gus Cat", "Cats vs Dogs");
        System.Console.WriteLine(assignment.GetSummary());
        
        // Create a Math Assignment object
        MathAssignment mathHW = new MathAssignment("David Orozco", "Fractions", "7.3", "8-19");
        System.Console.WriteLine(mathHW.GetSummary());
        System.Console.WriteLine(mathHW.GetHomeworkList());

        // Create a Writing Assignment object
        WritingAssignment writingHW = new WritingAssignment("Kylian Mbappe", "World Cup", "Best world cup final");
        System.Console.WriteLine(writingHW.GetSummary());
        System.Console.WriteLine(writingHW.GetWritingInformation());
    }
}