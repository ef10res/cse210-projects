public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {

    }

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public string GetState()
    {
        return _state;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    public string GetCountry()
    {
        return _country;
    }


    public bool IsLocal()
    {
        bool isLocal = false;
        if(_country == "USA")
        {
            isLocal = true;
        }
        return isLocal;
    }

    public void FullAddress(Address address)
    {

        Console.WriteLine($"{address.GetStreetAddress()}, {address.GetCity()}");
        Console.WriteLine($"{address.GetState()}, {address.GetCountry()}");
    }
}