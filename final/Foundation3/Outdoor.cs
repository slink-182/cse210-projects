public class Outdoor : Event
{
    private string _weather;

    //constructor
    public Outdoor(string weather, string title, string desc, string date, string time, Address address) : base(title, desc, date, time, address)
    {
        _weather = weather;
    }

    //methods
    public override void FullDisplay()
    {
        Console.WriteLine($"weather: {_weather}\ntitle: {base.GetTitle()}\ndescription: {base.GetDescription()}\ndate: {base.GetDate()}\ntime: {base.GetTime()}\naddress: {base.GetFullAddress()}");
    }
    public override void ShortDisplay()
    {  
        string _eventName = "outdoor gathering";
        Console.WriteLine($"event type: {_eventName}\ntitle: {base.GetTitle()}\ndate: {base.GetDate()}");
        
    }
}