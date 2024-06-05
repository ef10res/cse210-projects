using System.IO;
using System.IO.Enumeration;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {

    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }
    public void SaveToFile(string fileName, List<Entry> entries)
    {
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry entry in entries)
            outputFile.WriteLine($"{entry}");
        }
        
    }

    public void LoadFromFile()
    {
        string entryFile = "entries.txt";
        string [] lines = System.IO.File.ReadAllLines(entryFile);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}