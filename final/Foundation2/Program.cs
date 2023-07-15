class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main Street", "Cityville", "Stateville", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        List<Product> products1 = new List<Product>
        {
            new Product("Books", "3256", 10, 2),
            new Product("Markers", "1267", 15, 1)
        };
        Order order1 = new Order(customer1, products1);

        Address address2 = new Address("456 Elm Street", "Townsville", "Provville", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        List<Product> products2 = new List<Product>
        {
            new Product("Soap", "0923", 20, 3),
            new Product("Shoes", "2943", 8, 5)
        };
        Order order2 = new Order(customer2, products2);

        Console.WriteLine("\nOrder 1 Packing Label:");
        foreach (Product product in products1)
        {
            Console.WriteLine($"Name of product: {product.GetName()}, Product ID: {product.GetProductId()}");
        }

        Console.WriteLine("\nOrder 1 Shipping Label:");
        Console.WriteLine($"Name of customer: {customer1.GetName()}");
        Console.WriteLine($"Address: {customer1.GetAddress().GetFullAddress()}");

        Console.WriteLine($"Order 1 Total Price: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\n\nOrder 2 Packing Label:");
        foreach (Product product in products2)
        {
            Console.WriteLine($"Name: {product.GetName()}, Product ID: {product.GetProductId()}");
        }

        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine($"Name: {customer2.GetName()}");
        Console.WriteLine($"Address: {customer2.GetAddress().GetFullAddress()}");

        Console.WriteLine($"Order 2 Total Price: ${order2.CalculateTotalCost()}\n");
    
    }
}