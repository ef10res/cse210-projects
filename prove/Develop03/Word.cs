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
        _text = _text;
    }

    public bool _IsHidden()
    {
        if(_text = " ______ ")
        {
            return true;
        }
    }

    public string GetDisplayText()
    {
        return _text;
    }
}