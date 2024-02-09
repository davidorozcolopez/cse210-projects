using System;
public class Fraction
{
    // Attributes
    private int top;   // private attributes that can only be accessed internally in the class or externally through the internal methods of this class
    private int bottom;

    // Constructors
    public Fraction() // Constructor that receives no parameters but sets default values to initialize the number to 1/1
    {
        top = 1;          // set default value of top to be 1
        bottom = 1;       // set default value of bottom to be 1
    }

    public Fraction(int topNum) // Constructor that has one parameter for the top and that initializes the denominator to 1
    {
        top = topNum;      // assigning parameter to the attribute
        bottom = 1;        // set default value of bottom to be 1
    }

    public Fraction(int topNum, int bottomNum) // Constructor that has two parameters, one for the top and one for the bottom
    {
        top = topNum;       // assigning values to attributes of class Fraction by assigning the parameters to the attributes
        bottom = bottomNum;
    }

    // Getters and Setters
    public int GetTop()
    {
        return top;
    }

    public void SetTop(int numerator)
    {
        top = numerator;
    }

    public int GetBottom()
    {
        return bottom;
    }

    public void SetBottom(int denominator)
    {
        bottom = denominator;
    }

    // Methods
    public string GetFractionString()
    {
        return $"{top}/{bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)top / (double)bottom;
    }
}