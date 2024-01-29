using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Notes from class lesson

        // list
        List<int> myInts = new List<int>(); // The 'new' keyword is needed to initialize a new instance of the List class
        var moreInt = new List<int>();

        moreInt.Add(34);
        moreInt.Add(10);
        
        // iterate through items
        foreach(var n in moreInt) {
            System.Console.WriteLine($"n = {n}");
        }

        // Assignment #4
        System.Console.WriteLine("\nAssignment #4\n");

        List<int> myNumbers = new List<int>();
        
        System.Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        bool finished = false;
        float sum = 0;
        int largestNumber = -1;
        
        do
        {
            System.Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                finished = true;
            }
            else
            {
                myNumbers.Add(number);
                sum += number;
                if (number >= largestNumber)
                {
                    largestNumber = number;
                }
            }
        } while (finished == false);

        float average = sum/myNumbers.Count;
   
        System.Console.WriteLine($"The sum is: {sum}");
        System.Console.WriteLine($"The average is: {average}");
        System.Console.WriteLine($"The largest number is {largestNumber}");

    }
}