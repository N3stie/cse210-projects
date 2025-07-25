using System;
using System.Collections.Generic;

class Program
{
    static void Main()

     // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

    {
        try
        {
            // Create addresses
            Address phAddress = new Address("123 Rizal Ave", "Manila", "NCR", "Philippines");
            Address usAddress = new Address("456 Main St", "Los Angeles", "CA", "USA");

            // Create customers
            Customer localCustomer = new Customer("Juan Dela Cruz", phAddress);
            Customer foreignCustomer = new Customer("John Smith", usAddress);

            // Create products
            Product laptop = new Product("Laptop", "P001", 30000, 1);
            Product mouse = new Product("Mouse", "P002", 500, 2);
            Product keyboard = new Product("Keyboard", "P003", 1200, 1);

            // Create orders
            Order order1 = new Order(localCustomer);
            order1.AddProduct(laptop);
            order1.AddProduct(mouse);

            Order order2 = new Order(foreignCustomer);
            order2.AddProduct(keyboard);
            order2.AddProduct(laptop);

            // Display order info
            DisplayOrder(order1);
            DisplayOrder(order2);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine("=================================");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"TOTAL COST: ${order.CalculateTotalCost():N2}");
        Console.WriteLine("=================================\n");
    }
}