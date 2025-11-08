using System;
using System.ComponentModel;
using System.Data;


public class Reflection : Activity
{
    // set attributes
    private List<string> _promptList;
    private List<string> _questionList;

    // constructor
    public Reflection(List<string> prompt, List<string> question, string name, string desc, int dura) : base(name, desc, dura)
    {
        _promptList = prompt;
        _questionList = question;
    }
    // set methods
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestion()
    {
        
    }
}