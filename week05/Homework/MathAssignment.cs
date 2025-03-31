public class MathAssignment : Assignment
{
    private string _textbookSection {get; set;} = String.Empty;
    private string _problems {get; set;} = String.Empty;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeWorkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}