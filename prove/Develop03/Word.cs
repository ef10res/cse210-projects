public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _text = " ______ ";
    }

    public void Show()
    {
        _text = text;
    }

    public bool _IsHidden(string text)
    {
        if(text == " ______ ")
        {
            return true;
        }
    }

    public string GetDisplayText()
    {
        return _text;
    }
}