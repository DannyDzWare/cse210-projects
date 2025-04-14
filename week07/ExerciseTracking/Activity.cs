public class Activity
{
    protected Int32 _minutes = 0;
    protected string _activityName = "Activity";
    protected string _date = "01. January 2025";

    public void GetSummary()
    {
        string result =  $"{_date} {_activityName} ({_minutes} min)- Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
        Console.WriteLine(result);
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }
}