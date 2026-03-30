using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer cust1 = new Customer("John Smith", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Book", "B101", 10.0, 2));
        order1.AddProduct(new Product("Pen", "P202", 2.5, 5));

        Address addr2 = new Address("456 King Rd", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Alice Brown", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Laptop", "L303", 800.0, 1));
        order2.AddProduct(new Product("Mouse", "M404", 25.0, 2));

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():0.00}");
            Console.WriteLine("-----------------------------------\n");
        }
    }
}