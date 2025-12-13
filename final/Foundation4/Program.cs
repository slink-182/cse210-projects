using System;

class Program
{
    static void Main(string[] args)
    {
        //polymorphism project
        List<Activity> _activities = new List<Activity>
        {
            new Running(5,"12/13/2025",100),
            new Cycling(12, "12/14/2025", 20),
            new Swimming(3, "12/15/2025", 28)
        };

        foreach (Activity a in _activities)
        {
            Console.WriteLine(a.GetSummary());

        }


    }
}

/*
What was throwing me off for this assignment was that we had to get the distance, pace, and speed, 
all in each activity but that didn't mean we had all the attributes in one place.

My first thought was that we somehow had to universally get the distance from the lapcount to run the distance for everything else. That makes no sense at all.

After wrestling with the assingment for a couple hours I asked ChatGPT to check my work, to which it clarified that yes the original idea of having one unique 
attribute per subclass was true, and we just needed to run different formulas as needed to get the missing data. The coding process -- which I did on my own -- went smoothly
after that.
*/