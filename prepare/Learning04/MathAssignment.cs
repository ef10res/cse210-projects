public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string texbooksection, string problems) : base( name, topic)
    {
        _textbookSection = texbooksection;
        _problems = problems;
    }

    public string GetHomeWorkList()
    {
        return "Section " + _textbookSection + " Problems " + _problems;
    }
}
