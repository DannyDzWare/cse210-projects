public class Reference
{
    private string _book {get;set;} = string.Empty;
    private int _chapter {get;set;} = -1;
    private int _verse {get;set;} = -1;
    private int _endVerse {get;set;} = -1;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        string OUT = $"{_book} {_chapter.ToString()}:{_verse.ToString()}";

        if(_endVerse != -1)
        {
            OUT += $"-{_endVerse.ToString()}";
        }
        return OUT;
    }
}