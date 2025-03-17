using System.ComponentModel;

public class ScriptureTemplate
{
    private string _reference {get; set;} = string.Empty;
    private string _text {get; set;} = string.Empty;

    public ScriptureTemplate(string reference, string text)
    {
        _reference = reference;
        _text = text;
    }

//John 3:16
    public Reference GetReference()
    {
        string book = _reference.Split(' ')[0];
        string rest = _reference.Split(' ')[1];
        int chapter = Convert.ToInt32(rest.Split(':')[0]);
        rest = rest.Split(':')[1];
        int verse = Convert.ToInt32(rest.Split('-')[0]);
        if(rest.Contains("-"))
        {
            int endVerse = Convert.ToInt32(rest.Split('-')[1]);
            return new Reference(book, chapter, verse, endVerse);
        }
        
        return new Reference(book, chapter, verse);
    }

    public string GetText()
    {
        return _text;
    }
}