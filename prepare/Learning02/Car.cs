public class Car  // A class is just a custom data type.
{                    
    public int milesPerGallon;
    public int gallons;
    public string make;
    public string model;
    public Owner owner;
    
    // Constructor is a function named after the class itself

    public int TotalRange() 
    {
        return gallons * milesPerGallon;
    }

    public void Display()
    {
        System.Console.WriteLine($"{make} {model} {owner.name}: Range = {TotalRange()}");
    }
}