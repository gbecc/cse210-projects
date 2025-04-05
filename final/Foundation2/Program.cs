using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Mouse", "SKU01", 15.99, 2);
        Product product2 = new Product("Keyboard", "SKU02", 45.50, 1);
        Product product3 = new Product("Webcam", "SKU03", 29.99, 1);
        Product product4 = new Product("Laptop Stand", "SKU04", 32.00, 1);

        Address addressUSA = new Address("123 Trump St", "Springfield", "IL", "USA");
        Address addressCanada = new Address("456 MapleSyrup Ave", "Toronto", "ON", "Canada");

        Customer customerUSA = new Customer("Donald Trump", addressUSA);
        Customer customerCanada = new Customer("Justin Trudeau", addressCanada);

        Order order1 = new Order(customerUSA);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customerCanada);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("ORDER 1");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice().ToString("F2"));
        Console.WriteLine();

        Console.WriteLine("ORDER 2");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice().ToString("F2"));
    }
}
