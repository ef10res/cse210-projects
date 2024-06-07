public class Cycling : Activity
{
    public Cycling(string date, string activity, int minutes, float distance) : base(date, activity, minutes, distance)
    {
        
    }

    public override double GetSpeed()
    {
        return (_distance/_minutes) * 60;
    }

    public override double GetPace()
    {
        return _minutes / _distance;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date}, {_activity}, ({_minutes} min): Distance {_distance} miles, Speed: {this.GetSpeed()} mph, Pace {this.GetPace()} min per mile");
    }
}