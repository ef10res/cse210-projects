using System.Runtime.CompilerServices;

public class Customer
{
    private string _name;
    public Address _address = new Address();

    public Customer()
    {

    }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsUSA()
    {
        bool isUSA = false;
        if (this._address.IsLocal())
        {
            isUSA = true;
        }
        return isUSA;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }
    public Address GetAddress()
    {
        return _address;
    }
}