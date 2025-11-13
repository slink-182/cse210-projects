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
    public void DisplayReflection()
    {
        DisplayStart();
        Animation();
        Console.WriteLine("Consider the following prompt:");
        for (int i = 0; i < _promptList.Count; i++)
        {
            string _currentPrompt = _promptList[i];
            Console.Write($"--==-- {_currentPrompt} --==-- ");
            Animation(); Console.WriteLine();
            
        }
        DisplayEnd();
    }

    
}