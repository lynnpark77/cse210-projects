using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Maple Street", "New York", "NY", "USA");
        Address address2 = new Address("45 Kensington Road", "London"," ","UK");
        Address address3 = new Address("5678 Pine Avenue", "Miami", "FL", "USA");

        
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Priya Singh", address2);
        Customer customer3 = new Customer("Maria Gonzalez", address3);

        Product product1 = new Product("Wireless Headphones", "WH-101", 89.99m, 2);
        Product product2 = new Product("Bluetooth Speaker", "BS-102", 45.50m, 4);
        Product product3 = new Product("Electric Kettle", "EK-202",49.99m, 3);
        Product product4 = new Product("Smartwatch", "SW-303", 149.99m, 1);
        Product product5 = new Product("Fitness Tracker", "FT-304", 99.99m, 1);
        Product product6 = new Product("Toaster","T-203", 25.99m, 1);

        Order order1 = new Order(customer1,address1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2,address2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Order order3 = new Order(customer3,address3);
        order3.AddProduct(product5);
        order3.AddProduct(product6);

        
        Console.WriteLine(order1.GetShippingLabel(customer1,address1));
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Cost: {order1.CalculateTotalCost()}\n");
        
        
        Console.WriteLine(order2.GetShippingLabel(customer2,address2));
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Cost: {order2.CalculateTotalCost()}\n");

        
        Console.WriteLine(order3.GetShippingLabel(customer3,address3));
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine($"Total Cost: {order3.CalculateTotalCost()}");
        
        


    
        


    }
}