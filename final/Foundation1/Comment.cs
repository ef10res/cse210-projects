public class Comment
{
    public string _name;
    public string _text;

    public Comment()
    {

    }
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetText(string text)
    {
        _text = text;
    }

    public string GetText()
    {
        return _text;
    }
}