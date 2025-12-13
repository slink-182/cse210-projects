using System;

class Program
{
    static void Main(string[] args)
    {
        //polymorphism project
        List<Activity> _activities = new List<Activity>
        {
            new Running(3,"12/13/2025",30),
            new Cycling(9, "12/14/2025", 30),
            new Swimming(3, "12/15/2025", 75)
        };

        foreach (Activity a in _activities)
        {
            Console.WriteLine(a.GetSummary());

        }


    }
}
