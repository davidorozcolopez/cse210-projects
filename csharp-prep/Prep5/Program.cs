using System;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        // Notes from class lesson
        // Functions
        // returnType FunctionName(ParamType paramName1, ParamType paramName2)
        // {
        //   function body
        // }

        static int Add2(int number) { // To define a standalone function in C#, use the static keyword before the return type.
            return number + 2;
        }

        int more = Add2(10);
        System.Console.WriteLine(more);

        // void
        static void PrintName(string name) {
            if (name.Length == 0) {
                return;
            }
            System.Console.WriteLine($"Name is {name}");
            return;
        }
        PrintName("David");

        // variable scope
        var y = 0;
        {
            var w = 10;
            w = y + 4;
            y = w + 5;
        }
        // y = w + 4; doesn't work here because "w" was declared locally inside curly braces

        // Assignment #5
        System.Console.WriteLine("\nAssignment #5: Functions calling functions\n");

        static void DisplayWelcome()
        {
            System.Console.Write("Welcome to the Program!\n");
        }

        static string PromptUserName()
        {
            System.Console.Write("Please enter your username: ");
            string username = Console.ReadLine();
            return username;
        }
        
        static int PromptUserNumber()
        {
            System.Console.Write("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;
        }

        static int SquareNumber(int number)
        {
            int squareNum = number * number;
            return squareNum;
        }

        static void DisplayResult(string name, int numberSquared)
        {
            System.Console.WriteLine($"{name}, the square of your number is {numberSquared}");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);

    }

}