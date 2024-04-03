public class Program
{
    static void Main(string[] args)
    {
        List<Product> productsGroup1 = new List<Product>() {
            new Product("Apple", "A1", 1, 1),
            new Product("Bread", "B1", 1, 1),
            new Product("Milk", "M2", 1, 1),
        };

        List<Product> productsGroup2 = new List<Product>() {
            new Product("Broom", "B3", 1, 1),
            new Product("Notebook", "N7", 1, 1),
            new Product("Pencil", "P11", 1, 1),
        };

        Address address1 = new Address("2476 Rose Park", "San Francisco", "CA", "USA");
        Customer customer1 = new Customer("Sarah Connor", address1);
        Order order1 = new Order(customer1, productsGroup1);
        order1.DisplayOrder();

        Address address2 = new Address("1723 Calle Girasol", "San Miguel Petapa", "GUA", "Guatemala");
        Customer customer2 = new Customer("David Rivera", address2);
        Order order2 = new Order(customer2, productsGroup2);
        order2.DisplayOrder();
    }
}