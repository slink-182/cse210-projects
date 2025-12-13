public class Cycling : Activity
{
    private double _speed;
    public Cycling(double speed, string date, int min) : base(date, min)
    {
        _speed = speed;
    }
    public override string GetActivityName()
    {
        return "cycling";
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override double GetDistance()
    {
        return 60 / GetPace();
    }
    public override double GetSpeed()
    {
        return _speed;
    }

    //print the GetSummary method to return all the calculations for cycling
    public override string GetSummary()
    {
        return $"{base.GetDate()} {GetActivityName()} ({base.GetMinutes()} min) - distance {GetDistance():00.00}, speed {GetSpeed():00.00} mph, pace: {GetPace():00.00} min per mile";
    }
}