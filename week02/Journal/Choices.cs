using System.Runtime.InteropServices;

public class Choices
{
    public List<string> _options {get; set;} = new List<string>();
    public Choices()
    {
        
    }

    public Choices(List<string> options)
    {
        _options = options;
    }

    public void AddOption(string option)
    {
        _options.Add(option);
    }

    public void Display()
    {
        Console.WriteLine("Please select one of the following choices:");
        for(int i = 0; i < _options.Count; i++)
        {
            Console.WriteLine($"{(i+1).ToString()}. {_options[i]}");
        }
        Console.WriteLine("What would you like to do?");
    }

    public string GetChoice(string index)
    {
        try
        {
            Int32.TryParse(index, out int result);
            return _options[result-1];
        }
        catch(Exception)
        {
            return "";
        }
    }
}