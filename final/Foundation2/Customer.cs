using System.Net.Sockets;

public class Customer
{
    private string customerName;
    private Address address;

    public Customer(string customerName, Address address)
    {
        this.customerName = customerName;
        this.address = address;
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