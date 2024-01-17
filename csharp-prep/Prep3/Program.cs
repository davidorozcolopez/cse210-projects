using System;

class Program
{
    static void Main(string[] args)
    {
        // while loop
        int count = 5;

        while (count < 10) {
            System.Console.WriteLine($"Count = {count}");
            count++;
        }

        // do-while loop
        int anotherCount = 0;
        do {
            System.Console.WriteLine($"AnotherCount = {anotherCount++}"); // Sometimes putting the ++ before or after matters.
        } while (anotherCount < 10);

        // for loop (declaring, end condition, how to change each time we go through the loop)
        for (int i=0; i<5; ++i) { // Here, the position of the ++ signs does not matter because it will always go up after each loop and do the same.
            System.Console.WriteLine($"i = {i}");
        }

        // Generate a random number

        System.Console.WriteLine("Guess a number: ");
        int guess = int.Parse(Console.ReadLine());
    }
}