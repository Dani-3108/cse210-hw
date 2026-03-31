using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Edgemere Blvd", "El Paso", "TX", "USA");
        Address address2 = new Address("5th street", "Vancouver", "BC", "CA");

        Customer customer1 = new Customer("Lety", address1);
        Customer customer2 = new Customer("Isabel", address2);

        Product customer1Product1 = new Product("Iphone", 2256, 650.50, 1);
        Product customer1Product2 = new Product("Macbook", 11232, 2142.42, 2);

        Product customer2Product1 = new Product("Kayak", 3000, 2322, 1);
        Product customer2Product2 = new Product("PaddleBoard", 4565, 550.50, 3);

        List<Product> customer1Order = new List<Product>();
        customer1Order.Add(customer1Product1);
        customer1Order.Add(customer1Product2);

        List<Product> customer2Order = new List<Product>();
        customer2Order.Add(customer2Product1);
        customer2Order.Add(customer2Product2);

        Order firstOrder = new Order(customer1Order, customer1);
        Order secondOrder = new Order(customer2Order, customer2);

        //Order one
        Console.WriteLine(firstOrder.GetPackingLabel());
        Console.WriteLine(firstOrder.GetShippingLabel());
        Console.WriteLine(firstOrder.GetTotalCost());

        Console.WriteLine();
        //Second Order
        Console.WriteLine(secondOrder.GetPackingLabel());
        Console.WriteLine(secondOrder.GetShippingLabel());
        Console.WriteLine(secondOrder.GetTotalCost());
    }
}