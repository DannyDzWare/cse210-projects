public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target = 0;
    private int _bonus = 500;
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

     public ChecklistGoal(string name, string description, string points, int bonus, int target, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override Int32 GetPoints()
    {
        int points = Convert.ToInt32(_points);
        if(IsComplete())
        {
            return points + _bonus;
        }
        return points;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target ? true : false;

    }

    public override string GetDetailsString()
    {
        string basic = base.GetDetailsString();
        return $"{basic} --- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";
    }
}