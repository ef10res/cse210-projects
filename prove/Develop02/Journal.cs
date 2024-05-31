using System.IO;
public class Journal
{
    string fileName = "entriesFile.txt";
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
    public void SaveToFile(Entry entry)
    {
        string  entryFile = "entries.txt";
        using (StreamWriter outputFile = new StreamWriter(entryFile))
        {
            outputFile.WriteLine(entry);
        }
        
    }

    public void LoadFromFile(Entry entry)
    {
        string entryFile = "entries.txt";
        string [] lines = System.IO.File.ReadAllLines(entryFile);
        foreach (string line in lines)
        {
            Console.ReadLine(line);
        }
    }

}