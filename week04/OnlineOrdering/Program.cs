using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.\n");

        // Customer 1 with address in the USA
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Product product1 = new Product("Laptop", 101, 799.99, 2);
        Product product2 = new Product("Mouse", 102, 25.50, 3);
        Product product3 = new Product("Keyboard", 103, 49.99, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Customer 2 with address in Canada
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product4 = new Product("Smartphone", 104, 599.99, 1);
        Product product5 = new Product("Headphones", 105, 89.99, 2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display Order 1 Details
        Console.WriteLine("Order 1 Details:");
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine(order1.GetPackingLabel());
        order1.DisplayShippingLabel();
        Console.WriteLine();

        // Display Order 2 Details
        Console.WriteLine("Order 2 Details:");
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
        Console.WriteLine(order2.GetPackingLabel());
        order2.DisplayShippingLabel();
        Console.WriteLine();
    }
}