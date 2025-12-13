using System.Runtime.InteropServices;

public class Swimming : Activity
{
    private int _lapCount;
    public Swimming(int laps, string date, int min) : base(date, min)
    {
        _lapCount = laps;
    }
    public override string GetActivityName()
    {
        return "swimming";
    }
    public override double GetDistance()
    {
        return _lapCount * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return GetDistance() / GetMinutes() * 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    //return summary
    public override string GetSummary()
    {        
        return $"{base.GetDate()} {GetActivityName()} ({base.GetMinutes()} min)- {_lapCount} laps, distance: {GetDistance()} miles, speed: {GetSpeed()} mph, pace: {GetPace()}";
    }
}