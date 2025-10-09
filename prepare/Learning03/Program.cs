using System;

class Program
{
    // static int age = 18;
    // static double price = 19.99;
    // static string name = "Mason";
    // static bool isStudent = true;
    // static char grade = 'A';

    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade}");
        // Console.WriteLine($"Student: {isStudent}, Price: {price}");

        Job Job1 = new Job();
        Job1._title = "Software Engineer";
        Job1._company = "Acme Corp";
        Job1._startDate = "Jan 2025";

        Job Job2 = new Job();
        Job2._title = "title 2";
        Job2._company = "company 2";
        Job2._startDate = "start date 2";

        Job1.Display(); //show the jobs added V
        Job2.Display();
    }

    public class Job //define the structure of job
    {
        public string _startDate;
        public string _title;
        public string _company;
        public void Display() //this is the fuction that prints the data to the terminal
        {
            Console.WriteLine($"Title: {_title}, Company: {_company}, Start Date: {_startDate}");
        }
    }
}

// define the needed functions
// function to display the data
// function to structure the job
// function to add data to that job structure
// notes: Reviewing the basics of C# as I tend to keep forgetting it each week. Fun fun!