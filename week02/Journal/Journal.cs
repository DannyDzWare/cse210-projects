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
        foreach(Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine(Environment.NewLine);
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
                string[] parts = s.Split('|');
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                AddEntry(entry);
            }
        }
       
    }
}