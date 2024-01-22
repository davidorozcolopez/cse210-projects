using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("What is your grade percentage: ");
        string grade_percentage_str = Console.ReadLine();
        int grade_percentage_num = int.Parse(grade_percentage_str);
        string letter = "";

        if (grade_percentage_num >= 90)
        {
            letter = "A";
        }
        else if (grade_percentage_num >= 80)
        {
            letter = "B";
        }
        else if (grade_percentage_num >= 70)
        {
            letter = "C";
        }
        else if (grade_percentage_num >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        System.Console.WriteLine($"{letter}");

        if (grade_percentage_num >= 70)
        {
            System.Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            System.Console.WriteLine("Unfortunately, you did not pass the course this time. However, you can always do better next time!");
        }
    }
}