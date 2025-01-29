using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine(new string('-', 40)); 

        
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        
        Customer customer1 = new Customer("Egu Jared", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        
        order1.AddProduct(new Product("Laptop", "A1001", 999.99, 1));
        order1.AddProduct(new Product("Wireless Mouse", "A1002", 29.99, 2));

        
        order2.AddProduct(new Product("Headphones", "B2001", 89.99, 1));
        order2.AddProduct(new Product("Keyboard", "B2002", 49.99, 1));
        order2.AddProduct(new Product("Monitor", "B2003", 199.99, 1));

        
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():0.00}");
        Console.WriteLine(new string('-', 40)); 
    }
}
