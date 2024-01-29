using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        // Notes from class lesson

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

        // Assignment #3
        System.Console.WriteLine("Assignment #3: Guess My Number Program\n");

        // Generate a random number
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 100);

        bool found = false;
        do
        {
            System.Console.WriteLine("What is your guess? ");
            int guessNumber = int.Parse(Console.ReadLine()); // The int.Parse() method converts a string into an integer

            if (guessNumber > randomNumber)
            {
                System.Console.WriteLine("Lower");
            }
            else if (guessNumber < randomNumber)
            {
                System.Console.WriteLine("Higher");
            }
            else if (guessNumber == randomNumber)
            {
                System.Console.WriteLine("You guessed it!");
                found = true;
            }
        } while (found == false);
        
    }
}