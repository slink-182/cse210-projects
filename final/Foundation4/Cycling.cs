public class Cycling : Activity
{
    private float _speed;

    public Cycling(float speed, string date, int lengthmin) : base(date, lengthmin)
    {
        _speed = speed;
    }

    //methods
    public override void GetSummary()
    {
        string name = "cycling";
        
        Console.WriteLine($"{name} | {base.GetDate()} speed: {_speed} for a total of {base.GetLengthInMin()}min");
    }
}