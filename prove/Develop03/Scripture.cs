public class Scripture
{
    private List<Word> _verse = new List<Word>();
    private Reference _reference;

    public Scripture(List<Word> verse, Reference reference)
    {
        _verse = verse;
        _reference = reference;

    }

    //methods
    public void Display()
    {
        //create the random value for each word in the word type list
        Random _randomNum = new Random();
        int _index = _randomNum.Next(_verse.Count);
        Word _randomWord = _verse[_index];
        


    }
}