public class Assignment
{
    private string _studentName {get; set;} = String.Empty;
    private string _topic {get; set;} = String.Empty;

    public string studentName
    {
        get{ return _studentName; }
    }

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    
}