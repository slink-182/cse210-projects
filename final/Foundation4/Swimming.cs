using System.Runtime.InteropServices;

public class Swimming : Activity
{
    private int _lapCount;

    public Swimming(int lapc, string date, int lengthmin) : base(date, lengthmin)
    {
        _lapCount = lapc;
    }

    public override string GetSummary()
    {
        string name = "swimming";
        
        return $"{name} | {base.GetDate()} swam: {_lapCount} laps for a total of {base.GetLengthInMin()}min";


    }
}