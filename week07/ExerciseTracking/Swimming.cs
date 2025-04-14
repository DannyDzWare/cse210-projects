public class Swimming : Activity
{
    private int _numberOfLaps = 0;

    public Swimming(Int32 lengthInMinutes, int numberOfLaps)
    {
        _minutes = lengthInMinutes;
        _date = DateTime.Now.ToString("dd MMM yyy");
        _activityName = "Swimming";
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        double result = (_numberOfLaps * 50.0) / 1000;
        return Math.Round(result, 2);
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