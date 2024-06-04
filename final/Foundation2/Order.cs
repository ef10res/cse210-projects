public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    
    public Order()
    {
        _customer = new Customer();
        _products = new List<Product>();
    }

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public int ShippingCost(Customer customer)
    {
        int shipping;
        if(customer.IsUSA(Address address))
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }
        return shipping;
    }

    public double TotalOrderCost(List<Product> products, Customer customer)
    {
        double totalordercost = 0;
        double totalproductcost = 0;
        foreach (Product product in products)
        {
            totalproductcost = product.TotalCost(product.GetPrice(), product.GetQuantity());
            totalproductcost = totalproductcost + totalproductcost;
        }
        totalordercost = totalproductcost + Order.ShippingCost(customer);
        return totalordercost;
    }

    public void PackingLabel(Customer customer, List<Product> products)
    {
       string name = customer.GetName();
        List<Product> _products = products;

        foreach (Product product in _products)
        {
            Console.WriteLine($"{name}");
            Console.WriteLine($"{product.GetProductId()}");
        }
    }

    public void ShippingLabel(Customer customer)
    {
        string name = customer.GetName();
        customer = new Customer(); 

        Console.WriteLine($"{name}");
        Console.WriteLine($"{customer.GetAddress()}");
    }
}