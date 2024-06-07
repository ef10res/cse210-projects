using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("06/05/2024", "Running", 45, 6);
        Cycling cycling = new Cycling("05/30/2024", "Cycling", 60, 12);
        Swimming swimming = new Swimming("05/27/2024", "Swimming", 25, 50, 40);

        List<Activity> activities = new List<Activity>();

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach(Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}