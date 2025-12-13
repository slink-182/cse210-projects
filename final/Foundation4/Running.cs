using System.Runtime.InteropServices;

public class Running : Activity
{
    private float _distance;

    public Running(float distance, string date, int lengthmin) : base(date, lengthmin)
    {
        _distance = distance;
    }

    public override void GetSummary()
    {
        string name = "running";
        
        Console.WriteLine( $"{name} | {base.GetDate()} distance: {_distance} total of {base.GetLengthInMin()}min");
    }

}