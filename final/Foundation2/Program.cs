using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "Boise", "ID", "USA");
        Customer cust1 = new Customer("John Smith", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "A1", 800, 1));
        order1.AddProduct(new Product("Mouse", "B2", 20, 2));

        Address addr2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Alice Brown", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Phone", "C3", 600, 1));
        order2.AddProduct(new Product("Charger", "D4", 25, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}