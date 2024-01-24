using System;

class Program
{
    static void Main(string[] args)
    {
        var cars = new List<Car>();

        var car = new Car();
        car.make = "Ford";
        car.model = "Bronco";
        car.gallons = 30;
        car.milesPerGallon = 5;
        cars.Add(car);

        // We can reuse the same variable, because we have already added it in a our list cars. We do need to use the "new" keyword.
        car = new Car();
        car.make = "Toyota";
        car.model = "Corolla";
        car.gallons = 10;
        car.milesPerGallon = 30;
        cars.Add(car);

        foreach (var c in cars)
        {
            c.Display();
            int range = c.TotalRange();
        }
    }
}