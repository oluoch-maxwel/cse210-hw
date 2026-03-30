using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1. Create address
        Address addr = new Address("123 Street", "Nairobi", "Nairobi", "Kenya");
        Address addr1 = new Address("124 Street", "America", "St.Mary", "USA");

        // 2. Create customer
        Customer cust = new Customer("Oluoch", addr);
        Customer cust1 = new Customer("Maxwel", addr1);

        // 3. Create order
        Order order = new Order(cust);
        Order order1 = new Order(cust1);

        // 4. Create products
        Product p1 = new Product("Pen", "P01", 2.5, 3);
        Product p2 = new Product("Book", "B22", 10, 2);

        // 5. Add products to order
        order.AddProduct(p1);
        order.AddProduct(p2);
        order1.AddProduct(p1);
        order1.AddProduct(p2);

      
        // Console.WriteLine("PACKING LABEL:");
        // Console.WriteLine(order.GetPackagingLabel());
        
        // Console.WriteLine("\nSHIPPING LABEL:");
        // Console.WriteLine(order.GetShippingLabel());

        // Console.WriteLine("\nTOTAL COST:");
        // Console.WriteLine(order.GetTotalCost());



       // 6. Display results
    // For first customer (Oluoch)
        Console.WriteLine("PACKING LABEL:");
        Console.WriteLine(order.GetPackagingLabel());

        Console.WriteLine("\nSHIPPING LABEL:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine("\nTOTAL COST:");
        Console.WriteLine(order.GetTotalCost());


        // For second customer (Maxwel)
        Console.WriteLine("\n\nPACKING LABEL:");
        Console.WriteLine(order1.GetPackagingLabel());

        Console.WriteLine("\nSHIPPING LABEL:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("\nTOTAL COST:");
        Console.WriteLine(order1.GetTotalCost());
            }
}