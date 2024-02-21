using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("id1", "John", "Computer Science");
        Faculty faculty = new Faculty("id2", "Professor Jane", "Bioagriculture");
        
        student.Display();
        faculty.Display();

        // Create a list that contains both Students and Faculty objects (data types)
        // All you have access is what is defined in the parent class, Person class in this case
        List<Person> people = new List<Person>();
        people.Add(student);
        people.Add(faculty);
    } 
}

// Person
class Person
{
    protected string id; // Visible to the parent and children classes, but for everyone else they're private (not accessible)
    protected string name;

    public Person(string id, string name)
    {
        this.id = id;
        this.name = name;
    }
}

// Student
class Student: Person // This is how we declare that Person class is a parent class for Student class 
{
    private string major;

    public Student(string id, string name, string major) : base(id, name)
    {
        this.major = major;
    }

    public Display()
    {
        System.Console.WriteLine("Student");
    }
}

// Faculty
class Faculty: Person
{
    private string department;
    public Faculty(string id, string name, string department) : base(id, name)
    {
        this.department = department;
    }

    public Display()
    {
        System.Console.WriteLine("Student");
    }
}

class Vehicle
{
    protected string make;
    protected string model;
    protected int miles;

    public Vehicle(string make, string model, int miles)
    {
        this.make = make;
        this.model = model;
        this.miles = miles;
    }
}

class Car: Vehicle
{
    public Car(string make, string model, int miles) : base(make, model, miles)
    {

    }
}

class Truck: Vehicle
{
    private int towing;
    public Truck(string make, string model, int miles, int towing) : base(make, model, miles)
    {
        this.towing = towing;
    }
}
