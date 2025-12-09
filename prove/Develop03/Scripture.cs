public class Scripture
{
    private List<Word> _verse = new List<Word>();
    private Reference _reference;
    private Random _randomNum = new Random();

    public Scripture(List<Word> verse, Reference reference)
    {
        _verse = verse;
        _reference = reference;
    }

    //methods
    public void Display()
    {
        Console.WriteLine(_reference.GetReferenceText());
        string verseText = "";
        foreach (Word W in _verse)
        {
            verseText += W.GetDisplayText() + " ";
        }
        Console.WriteLine(verseText.Trim());
    }

    public bool AllWordsHidden()
    {
        foreach (Word W in _verse)
        {
            if (!W.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void HideRandomWord()
    {
        int index = _randomNum.Next(_verse.Count);
        Word randomWord = _verse[index];
        randomWord.Replace();
    }
}
