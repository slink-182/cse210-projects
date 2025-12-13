public class Cycling : Activity
{
    private float _speed;

    public Cycling(float speed, string date, int lengthmin) : base(date, lengthmin)
    {
        _speed = speed;
    }

    //methods
    public override string GetSummary()
    {
        string name = "cycling";
        
        return $"{name} | {base.GetDate()} speed: {_speed} for a total of {base.GetLengthInMin()}min";
    }
}