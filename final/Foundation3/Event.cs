public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    //constructor
    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    
    //methods
    public void StandardDisplay()
    {
        Console.WriteLine($"title: {_title}\ndescription: {_description}\ndate: {_date}\ntime: {_time}\naddress: {_address.GetAddress()}");
    }
    public abstract void FullDisplay();
    public abstract void ShortDisplay();


    //all the get methods to retrieve attributes
    public string GetTitle()
    {
        return _title;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetTime()
    {
        return _time;
    }
    //create a method to grab address for any subclass
    public string GetFullAddress()
    {
        return _address.GetAddress();
    }

    //add extra method for the visual side to make each display have a period of time to show and then clear and show the next one.
    public static void DelayClear()
    {
        Thread.Sleep(7000);
        Console.Clear();
    }

}