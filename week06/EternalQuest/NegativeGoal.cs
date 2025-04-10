public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, string points) : base(name, description, points)
    {
    }

    public override int GetPoints()
    {
        Int32 points = Convert.ToInt32(_points);
        if(points > 0)
        {
            return points * -1;
        }
        return  points;
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal|{_shortName}|{_description}|{_points}";
    }
}