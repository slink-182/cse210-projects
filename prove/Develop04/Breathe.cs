public class Breathe : Activity
{
    public Breathe(string name, string desc, int dura) : base(name, desc, dura)
    {
        //  theres nothing in here sadge:(
    }

    public void BreatheCycle()
    {
        int _duration = GetDuration();
        for (int i = _duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine("done.");
    }
}