using Microsoft.VisualBasic;

public class Entry
{
    public string _date;
    public string _prompt;
    List<string> _prompts = new List<string>()
    {
        "What was something you learned from someone today?",
        "How did you serve someone today?", 
        "What is a good thought that came to your mind today?",
        "What would be something you would do differently that you did today?",
        "What miracles did you see today?"
    };
    public string _entry;

    public Entry()
    {
    }

    public void Display()
    {
        Console.WriteLine($"{_date} {_prompt} {_entry}");
    }
}