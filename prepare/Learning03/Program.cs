using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();                     // create a new instance of class Fraction and call constructor with no parameters to set default values 1/1
        System.Console.WriteLine(fraction1.GetFractionString()); // call GetFractionString() method
        System.Console.WriteLine(fraction1.GetDecimalValue());   // call GetDecimalValue() method

        Fraction fraction2 = new Fraction(1);                    // create a new instance of Fraction and call constructor with one parameter
        System.Console.WriteLine(fraction2.GetFractionString()); // call GetFractionString() method
        System.Console.WriteLine(fraction2.GetDecimalValue());   // call GetDecimalValue() method

        fraction2.SetTop(5);                                     // call Setter SetTop() to set top of fraction to be 5
        System.Console.WriteLine(fraction2.GetFractionString()); // call GetFractionString() method
        System.Console.WriteLine(fraction2.GetDecimalValue());   // call GetDecimalValue() method

        Fraction fraction3 = new Fraction(3, 4);                 // create new instance of Fraction and call constructor with two parameters
        System.Console.WriteLine(fraction3.GetFractionString()); // call GetFractionString() method
        System.Console.WriteLine(fraction3.GetDecimalValue());   // call GetDecimalValue() method

        Fraction fraction4 = new Fraction(1, 3);                 // create new instance of Fraction and call constructor with two parameters
        System.Console.WriteLine(fraction4.GetFractionString()); // call GetFractionString() method
        System.Console.WriteLine(fraction4.GetDecimalValue());   // call GetDecimalValue() method

        Fraction fraction5 = new Fraction();                     // create new instance of Fraction and call constructor with no parameters
        fraction5.SetTop(7);                                     // call Setter SetTop() to set top of fraction to be 7 (change value)
        System.Console.WriteLine(fraction5.GetTop());            // call Getter GetTop() to get top of fraction (retrieve value)
        fraction5.SetBottom(8);                                  // call Setter SetBottom() to set bottom of fraction to be 8 (change value)
        System.Console.WriteLine(fraction5.GetBottom());         // call Getter GetBottom() to get bottom of fraction (retrieve value)
        System.Console.WriteLine(fraction5.GetFractionString()); // call GetFractionString() method
        System.Console.WriteLine(fraction5.GetDecimalValue());   // call GetDecimalValue() method
    }

}