using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;

public class Order
{
    private Customer customer;
    private List<Product> products;

    public Order(Customer customer, List<Product> products)
    {
        this.customer = customer;
        this.products = products;
    }

    public double ComputeOrderTotalCost()
    {
        double totalProductCost = 0;
        foreach(Product product in products)
        {
            totalProductCost += product.ComputeProductTotalCost();
        }

        int shippingCost;
        if (customer.IsInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        return totalProductCost + shippingCost;
    }

    public void DisplayPackingLabel()
    {
        System.Console.WriteLine("Packing label:");

        foreach(Product product in products)
        {
            System.Console.WriteLine($"Product name: {product.GetProductName()} ID: {product.GetProductID()}");
        }
    }

    public void DisplayShippingLabel()
    {
        System.Console.WriteLine("\nShipping label:");

        System.Console.WriteLine($"Customer name: {customer.GetCustomerName()} Address: {customer.GetAddress()}");
    }

    public void DisplayOrder()
    {
        DisplayPackingLabel();
        DisplayShippingLabel();
        System.Console.WriteLine($"Total cost: {ComputeOrderTotalCost()}");
    }
}