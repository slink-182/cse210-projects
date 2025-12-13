using System;

class Program
{
    static void Main(string[] args)
    {
        //polymorphism project
        List<Activity> _activities = new List<Activity>
        {
            new Running(15,"12/12/2025",25),
            new Cycling(80,"12/13/2025",10),
            new Swimming(8,"12/14/2025",35)
        };

        foreach (Activity a in _activities)
        {
            Console.WriteLine(a.GetSummary());

        }


    }
}