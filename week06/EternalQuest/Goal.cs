public abstract class Goal
{
    protected string _shortName = String.Empty;
    protected string _description = String.Empty;
    protected string _points = String.Empty;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public virtual Int32 GetPoints()
    {
        return Convert.ToInt32(_points);
    }

    public virtual void RecordEvent()
    {

    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        string complete = IsComplete() ? "[X]" : "[ ]";
        return $"{complete} {_shortName} ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }
}