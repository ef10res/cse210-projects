public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, string activity, int minutes, float distance, int laps) : base(date, activity, minutes, distance)
    {
        _laps = laps;
    }

    public void SetLaps(int laps)
    {
        _laps = laps;
    }

    public int GetLaps()
    {
        return _laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return this.GetDistance()/_minutes * 60;
    }

    public override double GetPace()
    {
        return _minutes / this.GetDistance();
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date}, {_activity}, {_laps} laps ({_minutes} min): Distance per lap {_distance} meters, Total Distance: {this.GetDistance()} miles, Speed: {this.GetSpeed()} mph, Pace {this.GetPace()} min per mile");
    }
}