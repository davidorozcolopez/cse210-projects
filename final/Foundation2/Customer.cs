using System.Net.Sockets;

public class Customer
{
    private string customerName;
    private Address address;

    public Customer()
    {

    }

    public string GetCustomerName()
    {
        return customerName;
    }

    public Address GetAddress()
    {
        return address;
    }

    public bool IsInUSA()
    {

    }
}