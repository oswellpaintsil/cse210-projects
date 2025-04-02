using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();
        
        Product product1 = new Product("Microsoft Suit", "20253103", 300, 2);
        Product product2 = new Product("Adobe Professional Suit", "20243111", 155, 6);

        Product product3 = new Product("Microsoft Suit", "20253103", 300, 10);
        Product product4 = new Product("Adobe Professional Suit", "20243111", 155, 32);

        Address address1 = new Address("PrinceTodd Street", "Ofankor", "G/A Region", "Ghana");
        Address address2 = new Address("Teachers Estate", "Amasaman", "G/A Region", "Ghana");

        Customer customer1 = new Customer("Oswell Paintsil",address1);
        Customer customer2 = new Customer("Mercy Assor Apeaning",address2);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        order2.AddProduct(product3);
        order2.AddProduct(product4);

        order1.GetPackingLabel();
        Console.WriteLine("---------------------------");
        Console.WriteLine($"Total price of order: ${order1.TotalCostOfOrder()}");
        Console.WriteLine("---------------------------\n");

        order2.GetPackingLabel();
        Console.WriteLine("---------------------------");
        Console.WriteLine($"Total price of order: ${order2.TotalCostOfOrder()}");
        Console.WriteLine("---------------------------\n");

    }
}