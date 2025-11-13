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
        // Console.WriteLine("");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session? ");
        string _duraStr = Console.ReadLine();
        Console.WriteLine("Get Ready...");
        _duration = int.Parse(_duraStr);

    }
    public void DisplayEnd()
    {
        Console.WriteLine($"You completed another {_duration} seconds of the {_name} Activity!");
    }
    public void CountDown()
    {
        for (int i = _duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if (i > 9)
            {
                Console.Write("\b\b  \b\b");
            }
            else{
                Console.Write("\b \b");
            }
        }
    }

    public void Animation()
    {
        
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

}