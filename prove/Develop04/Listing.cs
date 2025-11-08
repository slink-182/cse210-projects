using System;

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
    public void DisplayPrompt()
    {
        
    }
    public void DisplaySummary()
    {

    }

}