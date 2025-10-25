using System;

class Word
{
    private string _text;
    private bool _isHidden = false;
    public bool IsHidden()
    {
        return _isHidden;
    }

    public Word(string word)
    {
        _text = word;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public string Display()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}