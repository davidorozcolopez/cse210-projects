public class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("7625 Brooklyn Ave", "New York City", "New York", "USA");
        Address address2 = new Address("1339 Atherton Dr", "Taylorsville", "Utah", "USA");
        Address address3 = new Address("4200 Olive St", "Portland", "Oregon", "USA");

        Lecture lecture = new Lecture("Lecture", "How to effectively use AI", "A walkthrough on how to get into this exciting era of AI", "07/07/2024", "1 PM", address1.GetAddress(), "Jake Wolf", 200);
        Reception reception = new Reception("Reception", "The Youngs Wedding reception", "Come join us for the reception of Mr. and Mrs. Young", "05/15/2024", "5 PM", address2.GetAddress(), "youngregistration@gmail.com");
        Outdoor outdoor = new Outdoor("Outdoor", "Classic cars expo", "Come enjoy classic Fords and BMWs", "09/20/2024", "10 AM", address3.GetAddress(), "70 F");
        
        System.Console.WriteLine("_________________________________________________________________________");
        System.Console.WriteLine("  Welcome to Events Corporation. These are our next events on schedule:");
        System.Console.WriteLine("_________________________________________________________________________");

        System.Console.WriteLine("\n\t\t\t> > > EVENT #1 < < <");
        System.Console.WriteLine(lecture.GetStandardDetails());
        System.Console.WriteLine(lecture.GetFullDetails());
        System.Console.WriteLine(lecture.GetShortDescription());

        System.Console.WriteLine("\n\t\t\t> > > EVENT #2 < < <");
        System.Console.WriteLine(reception.GetStandardDetails());
        System.Console.WriteLine(reception.GetFullDetails());
        System.Console.WriteLine(reception.GetShortDescription());

        System.Console.WriteLine("\n\t\t\t> > > EVENT #3 < < <");
        System.Console.WriteLine(outdoor.GetStandardDetails());
        System.Console.WriteLine(outdoor.GetFullDetails());
        System.Console.WriteLine(outdoor.GetShortDescription());

        System.Console.WriteLine("\n\n\t\t      > Thank you for choosing us!\n");
    }
}