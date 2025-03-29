using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");

        
        Customer customer1 = new Customer("John Doe", address1);

        
        Product product1 = new Product("Laptop", "P123", 1000.00m, 1); 
        Product product2 = new Product("Headphones", "P124", 50.00m, 2); 

        
        List<Product> products = new List<Product> { product1, product2 };
        Order order1 = new Order(products, customer1);

        
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

       
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product3 = new Product("Smartphone", "P125", 800.00m, 1); 
        Product product4 = new Product("Charger", "P126", 20.00m, 3); 

        List<Product> products2 = new List<Product> { product3, product4 };
        Order order2 = new Order(products2, customer2);

        
        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}
