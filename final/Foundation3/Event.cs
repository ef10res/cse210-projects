using System.Net.Sockets;

public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address = new Address();

    public Event()
    {

    }

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetTDescription()
    {
        return _description;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetTime(string time)
    {
        _time = time;
    }

    public string GetTime()
    {
        return _time;
    }

    public void StandardDetails()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_time}");
        Console.WriteLine($"{_address.GetStreetAdress()}, {_address.GetCity()}, {_address.GetState()}, {_address.GetCountry()}");
        Console.WriteLine();
    }

    public void ShortDescription(string eventType)
    {
        string _eventType = eventType;
        Console.WriteLine($"{eventType}");
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{_date}");
        Console.WriteLine();
    }
}