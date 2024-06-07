public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather): base(title, description, date, time, address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _weather = weather;
    }

    public void SetWeather(string weather)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }

    public void FullDetails()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_time}");
        Console.WriteLine($"{_address.GetStreetAdress()}, {_address.GetCity()}, {_address.GetState()}, {_address.GetCountry()}");
        Console.WriteLine($"Weather: {_weather}");
        Console.WriteLine();
    }
}