using System;
using System.Formats.Asn1;

public class Listing : Activity
{
    // set attributes
    private List<string> _promptList;
    private List<string> _answerList;

    public Listing(List<string> prompt, List<string> answer, string name, string desc, int dura) : base(name, desc, dura)
    {
        _promptList = prompt;
        _answerList = answer;
    }


    // set methods
    public void ListingMethod()
    {
        DisplayStart();
        Animation();
        Console.WriteLine("Consider the following prompt:");
        for (int i = 0; i < _promptList.Count; i++)
        {
            string _currentPrompt = _promptList[i];
            Console.WriteLine($"--==-- {_currentPrompt} --==-- ");
            Console.Write("Ready in: "); CountDown(); Console.WriteLine();
            Console.Write("> ");
            string _answer = Console.ReadLine();
            _answerList.Add(_answer);

        }
        Console.WriteLine($"Your answers: ");
        foreach (string _answer in _answerList)
        {
            Console.WriteLine(_answer);
        }
        
        DisplayEnd();

    }

}