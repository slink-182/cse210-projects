using System.Reflection;
using System.Runtime.CompilerServices;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    //constructor
    public Lecture(string speaker, int capacity, string title, string desc, string date, string time, Address address) : base(title, desc, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
        
    }

    //methods
    public override void FullDisplay()
    {
        Console.WriteLine($"speaker: {_speaker}\ncapacity: {_capacity}\ntitle: {base.GetTitle()}\ndescription: {base.GetDescription()}\ndate: {base.GetDate()}\ntime: {base.GetTime()}\naddress: {base.GetFullAddress()}");
    }
    public override void ShortDisplay()
    {  
        string _eventName = "lecture";
        Console.WriteLine($"event type: {_eventName}\ntitle: {base.GetTitle()}\ndate: {base.GetDate()}");
        
    }



}