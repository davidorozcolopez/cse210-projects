using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        // functions
        // returnType FunctionName(ParamType paramName1, ParamType paramName2)
        // {
        //   function body
        // }

        int Add2(int number) {
            return number + 2;
        }

        int more = Add2(10);
        System.Console.WriteLine(more);

        // void
        void PrintName(string name) {
            if (name.Length == 0) {
                return;
            }
            System.Console.WriteLine($"Name is {name}");
            return;
        }
        PrintName("Bob");

        // variable scope
        var y = 0;
        {
            var w = 10;
            w = y + 4;
            y = w + 5;
        }
        // y = w + 4; doesn't work because w was declared locally inside curly braces

    }

}