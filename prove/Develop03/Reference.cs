public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapeter, int verse)
    {
        _book = book;
        _chapter = chapeter;
        _verse = verse;
    }

    public Reference(string book, int chapeter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapeter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        return $"{_book} {_chapter} {_verse} {_endVerse}";
    }
}