public class Reference
{
    private string _book;
    private string _chapter;
    private int _verseStart;
    private int _verseEnd;

    public Reference(string book, string chapter, int start, int end)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = start;
        _verseEnd = end;
    }
    public string GetReferenceText()
    {
        if (_verseStart == _verseEnd)
        {
            return $"{_book} {_chapter}:{_verseStart}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
    }
}
