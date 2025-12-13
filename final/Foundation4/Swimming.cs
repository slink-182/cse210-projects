using System.Runtime.InteropServices;

public class Swimming : Activity
{
    private int _lapCount;

    public Swimming(int lapc, string date, int lengthmin) : base(date, lengthmin)
    {
        _lapCount = lapc;
    }

    public override void GetSummary()
    {
        string name = "swimming";
        
        Console.WriteLine($"{name} | {base.GetDate()} swam: {_lapCount} laps for a total of {base.GetLengthInMin()}min");


    }
}