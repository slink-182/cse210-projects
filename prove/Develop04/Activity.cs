using System.ComponentModel;

public class Activity
{
    // set attributes
    private string _name;
    private string _description;
    private int _duration;

    // constructor time<3
    public Activity(string name, string desc, int dura)
    {
        _name = name;
        _description = desc;
        _duration = dura;
    }
    

    // set methods
    public void DisplayStart()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session? ");
        string _duraStr = Console.ReadLine();
        _duration = int.Parse(_duraStr);

    }
    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayEnd()
    {

    }
    public void CountDown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine("done.");
    }

}