using System.Reflection;

public class Reception : Event
{
    private string _RSVP;

    //constructor
    public Reception(string RSVP, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _RSVP = RSVP;
    }

    //methods 
    public override void FullDisplay()
    {
        Console.WriteLine($"RSVP: {_RSVP}\ntitle: {base.GetTitle()}\ndescription: {base.GetDescription()}\ndate: {base.GetDate()}\ntime: {base.GetTime()}\naddress: {base.GetFullAddress()}");
    }
    public override void ShortDisplay()
    {  
        string _eventName = "Reception";
        Console.WriteLine($"event type: {_eventName}\ntitle: {base.GetTitle()}\ndate: {base.GetDate()}");
        
    }
}