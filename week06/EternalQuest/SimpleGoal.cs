public class SimpleGoal : Goal
{
    private bool _isComplete = false;
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
    }

    public SimpleGoal(string name, string description, string points, string isComplete) : base(name, description, points)
    {
        _isComplete = Convert.ToBoolean(isComplete);
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{IsComplete().ToString()}";
    }
}