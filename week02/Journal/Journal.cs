using System.IO; 

public class Journal
{
    public List<Entry>_entries = new List<Entry>();
    
    public void AddEntry(Entry newEntry)
    {
            _entries.Add(newEntry);
    }
    
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file, true))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
                outputFile.WriteLine(entry._entryText);
                outputFile.WriteLine();
            }
        }
        if (_entries.Count != 0)
        {
            Console.WriteLine("Journal successfully saved to file!");
        }
        
    }


    public void LoadFromFile(string file)
    {
        
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }    
    }
}