public class Breathe : Activity
{
    public Breathe(string name, string desc, int dura) : base(name, desc, dura)
    {
        //  theres nothing in here sadge:(
    }

    public void BreatheCycle()
    {
        DisplayStart();
        //call animation
        Animation();
        //countdown
        Console.Write($"Breathe in for: "); CountDown(); Console.WriteLine();
        Console.Write($"Hold your breath for: "); CountDown(); Console.WriteLine();
        Console.Write($"Breathe out for: "); CountDown(); Console.WriteLine();
        //ending message
        DisplayEnd();
    }
}