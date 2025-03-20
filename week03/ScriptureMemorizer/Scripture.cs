public class Scripture
{
    private Reference _reference {get; set;} = new Reference("", 0, 0);
    private List<Word> _words {get; set;} = new List<Word>();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach(string s in text.Split(' '))
        {
            Word word = new Word(s);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        //Get List of Words which are not hidden
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        if (IsCompletelyHidden())
        {
             return; 
        }
        //Make sure not to hide more words than we have left.
        numberToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < numberToHide; i++)
        {
            int index = new Random().Next(visibleWords.Count);
            visibleWords[index].Hide();

            //Remove Word from List so it's not selected a second time
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + " ";
        foreach(Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        text = text.Remove(text.Length-1);
        return text;
    }

    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if(!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}