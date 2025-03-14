public class Entry
{
    private string _date {get; set;} = DateTime.Now.ToString("MM/dd/yyyy");
    private string _time {get; set;} = DateTime.Now.ToString("HH:mm:ss");
    private string _promptText {get; set;} = String.Empty;
    private string _entryText {get; set;} = String.Empty;

    public Entry(string promptText, string entryText)
    {
        _promptText = promptText;
        _entryText = entryText;
    }

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public Entry(string date, string time, string promptText, string entryText)
    {
        _date = date;
        _time = time;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - {_time} Prompt: {_promptText}\n{_entryText}");
    }

    public string GetEntryAsLine()
    {
        return _date + ";" + _time + ";" + _promptText + ";" + _entryText;
    }
}