public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speakerName, int capacity) : base (title, description, date, time, address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public void SetSpeakerName(string speakerName)
    {
        _speakerName = speakerName;
    }

    public string GetSpeakerName()
    {
        return _speakerName;
    }

    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public void FullDetails()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_time}");
        Console.WriteLine($"{_address.GetStreetAdress()}, {_address.GetCity()}, {_address.GetState()}, {_address.GetCountry()}");
        Console.WriteLine($"{_speakerName}");
        Console.WriteLine($"Capacity: {_capacity}");
        Console.WriteLine();
    }
}