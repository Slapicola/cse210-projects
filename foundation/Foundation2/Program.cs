using System;

class Program
{
    static void Main(string[] args)
    {

        List<Product> products1 = new List<Product>()
        {
            new Product("milk", 008763442, 3.50, 2),
            new Product("sugar", 8356771709, 10.00, 3),
            new Product("bread", 6788902213, 5.25, 2)
        };
        Address address1 = new Address("3345 Marigold Dr.", "Orlando", "Florida", "USA");
        Address address2 = new Address("225 Old Bay Cir.", "Dublin", "Leinster", "Ireland");
        
        Customer customer1 = new Customer("James Turner", address1);
        Customer customer2 = new Customer("Sasha Rink", address2);

        Order order1 = new Order(customer1, products1);

        List<Product> products2 = new List<Product>()
        {
            new Product("towels", 9948674966, 15.75, 4),
            new Product("cereal", 77439661195, 5.99, 2)
        };
        
        Order order2 = new Order(customer2, products2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("-----------------------");
        Console.WriteLine(order1.GetShippingLabel());
        //Console.WriteLine(order1.GetTotalPrice());
        Console.WriteLine("");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("-----------------------");
        Console.WriteLine(order2.GetShippingLabel());
        //Console.WriteLine(order2.GetTotalPrice());
    }
}