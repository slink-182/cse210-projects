using System.Runtime.InteropServices;

public class Swimming : Activity
{
    private double _lapCount;
    public Swimming(double laps, string date, int min) : base(date, min)
    {
        _lapCount = laps;
    }
    public override string GetActivityName()
    {
        return "swimming";
    }
    public override double GetDistance()
    {
        return _lapCount * 50.0;
    }
    public override double GetSpeed()//we're going to keep the data in meters format for swimming
    {
        return GetDistance() / GetMinutes();
    }
    public override double GetPace()
    {
        return GetMinutes() / _lapCount;//minutes per lap
    }

    //return summary
    public override string GetSummary()
    {        
        return $"{GetDate()} {GetActivityName()} ({GetMinutes()} min) - {_lapCount} laps, distance: {GetDistance():0.00} meters, speed: {GetSpeed():0.00} m/min, pace: {GetPace():0.00} min/lap";
    }
}