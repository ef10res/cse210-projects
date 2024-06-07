public class Activity
{
    protected string _date;
    protected string _activity;
    protected int _minutes;
    protected float _distance;
    protected float _speed;
    protected float _pace;

    public Activity(string date, string activity, int minutes, float distance)
    {
        _date = date;
        _activity = activity;
        _minutes = minutes;
        _distance = distance;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetMinutes(int minutes)
    {
        _minutes = minutes;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public void SetDistance(float distance)
    {
        _distance = distance;
    }

    public virtual double GetDistance()
    {
        return _distance;
    }

    public virtual double GetSpeed()
    {
        return (_distance/_minutes) * 60;
    }

    public virtual double GetPace()
    {
        return _minutes / _distance;
    }

    public virtual void GetSummary()
    {
        Console.WriteLine("Summary");
    }
}