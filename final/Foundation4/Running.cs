public class Running : Activity
{
    private double _distance;

    public Running(double dist, string date, int min) : base(date, min)
    {
        _distance = dist;
    }

    public override string GetActivityName()
    {
        return "running";
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / base.GetMinutes() * 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    //print the GetSummary method to return all the calculations for running
    public override string GetSummary()
    {
        return $"{base.GetDate()} {GetActivityName()} ({base.GetMinutes()} min)- distance {GetDistance()}, speed {GetSpeed()} mph, pace: {GetPace()} min per mile";
    }

}