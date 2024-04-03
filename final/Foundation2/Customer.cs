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

    public string GetAddress()
    {
        return address.GetCompleteAddress();
    }

    public bool IsInUSA()
    {
        if (address.IsInUSA())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}