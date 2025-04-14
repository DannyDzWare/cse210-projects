public class Running : Activity
{
    private double _distance = 0.0;

    public Running(Int32 lengthInMinutes, double distance)
    {
        _minutes = lengthInMinutes;
        _date = DateTime.Now.ToString("dd MMM yyy");
        _activityName = "Running";
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double result = (GetDistance() / _minutes) * 60;
        return Math.Round(result, 2);
    }

    public override double GetPace()
    {
        double result = _minutes / GetDistance();
        return Math.Round(result, 2);
    }
}