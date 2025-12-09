public class Word
{
    private string _word;
    private bool _hide = false;

    public Word(string word)
    {
        _word = word;
    }

    //methods
    public void Replace()
    {
        _hide = true;
    }
    public bool IsHidden()
    {
        return _hide;
    }

    public string GetDisplayText()
    {
        if (_hide)
        {
            int length = _word.Length;
            string hidden = new string('_', length);
            return hidden;
        }
        else
        {
            return _word;
        }
    
    }

}