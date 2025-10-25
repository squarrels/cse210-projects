namespace Develop03;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse = 0;

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    private string _reference;
    public string GetReference()
    {
        if (_endVerse != 0)
        {
            _reference = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        else
        {
            _reference = $"{_book} {_chapter}:{_startVerse}";
        }
        return _reference;
    }
}
