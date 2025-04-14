public abstract class Activity
{
    protected Int32 _minutes = 0;
    protected string _activityName = "Activity";
    protected string _date = "01. January 2025";

    public void GetSummary()
    {
        string result =  $"{_date} {_activityName} ({_minutes} min)- Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
        Console.WriteLine(result);
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();
    public abstract double GetPace();
}