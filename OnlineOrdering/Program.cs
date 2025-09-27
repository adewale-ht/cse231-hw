using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Widget", "W123", 10.0, 2));
        order1.AddProduct(new Product("Gadget", "G456", 15.5, 1));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Thingamajig", "T789", 7.25, 3));
        order2.AddProduct(new Product("Doohickey", "D012", 12.0, 2));

        // Display results
        Order[] orders = { order1, order2 };
        for (int i = 0; i < orders.Length; i++)
        {
            Console.WriteLine($"Order #{i + 1}");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(orders[i].GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(orders[i].GetShippingLabel());
            Console.WriteLine($"Total Cost: ${orders[i].GetTotalCost():F2}");
            Console.WriteLine();
        }
    }
}