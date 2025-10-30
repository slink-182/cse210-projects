// this is the base class file that will store two attributes: _studentName:string, and _topic:string!

using System;
// set class name
public class Assignment
{
    // set the two variables/attributes
    private string _studentName;
    private string _topic;
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;

    }

    //set up GetSummary method to return a string containing the two attributes student and topic 
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}


