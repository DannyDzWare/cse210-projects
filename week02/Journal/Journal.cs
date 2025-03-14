using System.Security.Cryptography;

public class Journal
{
    private List<Entry> _entries {get; set;} = new List<Entry>();

    public Journal()
    {
        
    }

    public Journal(List<Entry> entries)
    {
        _entries = entries;
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if(_entries.Count == 0)
        {
            Console.WriteLine("Your Journal has no entries." + Environment.NewLine);
            return;
        }

        foreach(Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine("");
        }
    }

    public void SaveToFile(string file)
    {
        using(StreamWriter outputFile = new StreamWriter(file))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine(entry.GetEntryAsLine());
            }
        }
    }

    public void LoadFromFile(string file)
    {
        if(File.Exists(file))
        {
            _entries.Clear();
            List<string> lines = new List<string>();
            lines.AddRange(File.ReadAllLines(file));

            foreach(string s in lines)
            {
                string[] parts = s.Split(';');
                Entry entry = new Entry(parts[0], parts[1], parts[2], parts[3]);
                AddEntry(entry);
            }
        }
        else
        {
            Console.WriteLine($"The File {file} is not existing." + Environment.NewLine);
        }   
    }
}