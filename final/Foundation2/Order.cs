public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    private Address _address;
    
    public Order()
    {
        _customer = new Customer();
        _products = new List<Product>();
        _address = new Address();
    }

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public int ShippingCost(Customer customer)
    {
        int shipping;
        if(customer.IsUSA())
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
        totalordercost = totalproductcost + this.ShippingCost(customer);
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

    public void ShippingLabel(Customer customer, Address address)
    {
        string name = customer.GetName();

        Console.WriteLine($"{name}");
        address.FullAddress();
    }
}