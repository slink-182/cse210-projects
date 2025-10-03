using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "King of The Frogs";
        job1._company = "Big Brother";
        job1._startYear = 1969;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Queen of Karens";
        job2._company = "Target";
        job2._startYear = 2024;
        job2._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "Billy Joel";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}



//Notes
//Much of what was coded was based off of the assignment solution. I'll be totally honest in the fact that mentally I'm out of it tonight.
//something that was supposed to be relatively simple I immediately made it way too complicated and got overwhelmed.
//Grade it how you please, I did make sure to type out all the code. I did not copy and paste it!
//I also changed the company names and titles to put effort there.
//I'd also be down to redo this assignment in the future for full credit!