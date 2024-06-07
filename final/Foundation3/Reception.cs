public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _email = email;
    }

    public void SetEmail(string email)
    {
        _email = email;
    }

    public string GetEmail()
    {
        return _email;
    }

    public void FullDetails()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_time}");
        Console.WriteLine($"{_address.GetStreetAdress()}, {_address.GetCity()}, {_address.GetState()}, {_address.GetCountry()}");
        Console.WriteLine($"RSVP: {_email}");
        Console.WriteLine();
    }
}