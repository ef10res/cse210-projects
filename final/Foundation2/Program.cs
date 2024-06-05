using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1719 N 725 W", "Clinton", "UT", "US");
        Address address2 = new Address ("2001 Block 5", "Cerro Grande", "Tegucigalpa", "Honduras");
        Customer customer1 = new Customer("Erick Flores", address1);
        Customer customer2 = new Customer("Omar Flores", address2);

        Product product1 = new Product("shoes", "0001", 55.95, 1);
        Product product2 = new Product("shirt", "0002", 19.95, 2);
        Product product3 = new Product("shorts", "0003", 25.95, 1);

        Product product4 = new Product("socks", "0055", 55.95, 1);
        Product product5 = new Product("ball", "0056", 55.95, 3);
        Product product6 = new Product("soccer shoes", "0057", 55.95, 1);

        List<Product> _products1 = new List<Product>();
        List<Product> _products2 = new List<Product>();

        _products1.Add(product1);
        _products1.Add(product2);
        _products1.Add(product3);

        _products2.Add(product4);
        _products2.Add(product5);
        _products2.Add(product6);

        
        Order order1 = new Order(customer1, _products1);
        Order order2 = new Order(customer2, _products2);

        order1.PackingLabel(customer1,_products1);
        order1.ShippingLabel(customer1, address1);
        double order1Cost = order1.TotalOrderCost(_products1, customer1);
        Console.WriteLine($"$ {order1Cost}");

        order2.PackingLabel(customer2,_products2);
        order2.ShippingLabel(customer2, address2);
        double order2Cost = order2.TotalOrderCost(_products2, customer2);
         Console.WriteLine($"$ {order2Cost}");
    }
}