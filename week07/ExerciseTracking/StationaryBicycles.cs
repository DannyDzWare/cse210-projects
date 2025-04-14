public class StationaryBicycles : Activity
{
    private double _speed = 0.0;

    public StationaryBicycles(Int32 lengthInMinutes, double speed)
    {
        _minutes = lengthInMinutes;
        _date = DateTime.Now.ToString("dd MMM yyy");
        _activityName = "Stationary Bicycles";
        _speed = speed;
    }

    public override double GetDistance()
    {
        double result = _minutes / GetPace();
        return Math.Round(result, 2);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double result = 60 / _speed;
        return Math.Round(result, 2);
    }
}