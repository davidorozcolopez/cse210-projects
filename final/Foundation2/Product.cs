public class Product
{
    private string productName;
    private string productID;
    private double pricePerUnit;
    private int quantity;

    public Product(string productName, string productID, double pricePerUnit, int quantity)
    {
        this.productName = productName;
        this.productID = productID;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }
    
    public string GetProductName()
    {
        return productName;
    }

    public string GetProductID()
    {
        return productID;
    }

    public double GetPricePerUnit()
    {
        return pricePerUnit;
    }

    public int ComputeProductTotalCost()
    {
        return Convert.ToInt32(pricePerUnit) * quantity;
    }
}