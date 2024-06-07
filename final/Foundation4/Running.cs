public class Running : Activity
{
    public Running(string date, string activity, int minutes, float distance) : base(date, activity, minutes, distance)
    {
        
    }

    public override double GetSpeed()
    {
        double _speed = (_distance/_minutes) * 60;
        return _speed;
    }

    public override double GetPace()
    {
        double _pace = _minutes / _distance;
        return _pace;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date}, {_activity}, ({_minutes} min): Distance {_distance} miles, Speed: {this.GetSpeed()} mph, Pace {this.GetPace()} min per mile");
    }
}