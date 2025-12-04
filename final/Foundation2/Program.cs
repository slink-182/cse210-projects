using System;

class Program
{
    static void Main(string[] args)
    {
        //encapsulation project
        //address objects
        Address address1 = new Address("742 Evergreen Terrace", "Springfield", "IL", "USA");
        Address address2 = new Address("1600 Pennsylvania Ave", "Washington", "DC", "USA");
        Address address3 = new Address("123 Banana Street", "Fruitville", "CA", "USA");
        Address address4 = new Address("99 Mystery Lane", "Spooky Town", "ON", "Canada");

        //customer objects
        Customer customer1 = new Customer("Homer Simpson", address1);
        Customer customer2 = new Customer("Donald Duck", address2);
        Customer customer3 = new Customer("Bananaman", address3);
        Customer customer4 = new Customer("Ghostly Greg", address4);

        //product objects
        Product product1 = new Product("Magic Donut", "MD-001", 3.5f, 12);
        Product product2 = new Product("Silly Hat", "SH-007", 15f, 2);
        Product product3 = new Product("Rubber Chicken", "RC-420", 7.5f, 1);
        Product product4 = new Product("Invisible Ink", "II-009", 10f, 5);
        Product product5 = new Product("Spicy Sauce", "SS-666", 2f, 20);
        Product product6 = new Product("Flying Carpet", "FC-101", 100f, 1);

        //order objects
        List<Product> _order1Products = new List<Product> { product1, product2, product3 };
        Order order1 = new Order(_order1Products, customer1);
        List<Product> _order2Products = new List<Product> { product4, product5, product6 };
        Order order2 = new Order(_order2Products, customer4);

        //display order 1
        Console.WriteLine("order 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"total: ${order1.FinalTotalCost()}\n");

        //dislay order 2
        Console.WriteLine("order 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"total: ${order2.FinalTotalCost()}\n");


    }
}