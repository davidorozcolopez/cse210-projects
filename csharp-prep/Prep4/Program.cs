using System;

class Program
{
    static void Main(string[] args)
    {
        // list
        List<int> myInts = new List<int>(); // Is that 'new' needed?
        var moreInt = new List<int>();

        moreInt.Add(34);
        moreInt.Add(10);
        
        // iterate through items
        foreach(var n in moreInt) {
            System.Console.WriteLine($"n = {n}");
        }
    }
}