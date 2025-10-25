using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = scriptureText.Split(' ');
        foreach (string w in wordArray)
        {
            _words.Add((new Word(w)));
        }
    }
    public void Display()
    {
        Console.WriteLine(_reference.GetReference());

        foreach (Word w in _words)
        {
            Console.Write(w.Display() + " ");
        }

        Console.WriteLine();
    }
    public void HideRandomWord()
    {
        Random rand = new Random();

        // Create a list of visible words
        List<Word> visibleWords = new List<Word>();
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                visibleWords.Add(w);
            }
        }

        // Hide a random visible word if any exist
        if (visibleWords.Count > 0)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

    public bool IsFullyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
                return false;
        }
        return true;
    }
    

}

