public class Entry
{
    private string _date {get; set;} = DateTime.Now.ToString("MM/dd/yyyy");
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

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\n{_entryText}");
    }

    public string GetEntryAsLine()
    {
        return _date + "|" + _promptText + "|" + _entryText;
    }
}