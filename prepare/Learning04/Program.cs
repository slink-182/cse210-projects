using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");
        // create an object that uses the method from the base class to display the student name and topic
        Assignment _student1 = new Assignment("fred", "Mathematics");
        MathAssignment _math1 = new MathAssignment("jimmy", "Mathematics", "7.3", "8-19");
        WritingAssignment _writing1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        // apply the object and it's content to the method GetSummary
        Console.WriteLine(_student1.GetSummary());
        //apply another object
        Console.WriteLine(_math1.GetHomeworkList());
        // apply another object
        Console.WriteLine(_writing1.GetWritingInformation());
    }

}


// notes
// When I decided to do this assignment, I made the choice to actually go through the readings and follow the steps, asking AI for clarification anytime I got confused.
// Instead of rushing to get the assignment done, I actually gave it the time to read through all the material and let it soak in.
// turns out the curriculum for this class is really good, and it's the students fault for not actually following it LOL WOOPSEE

// A fact I heard is that the ideal amount of time to study for school is the number of credits you're taking, multiplied by 2 or 3.
// On average students are actually spending 10 hours a week on studying instead of 24-36.
// My takeaway is that the brain needs time in the material to actually understand it and retain it long term. So, I'll be working to spend more time learning in this class.
