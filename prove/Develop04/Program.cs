using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");

        bool running = true;

        if (running){
            Console.Write(":-:=:-:\n1.Start Breathing Activity\n2.Start Reflection Activity\n3.Start Listing Activity\n4.Exit\n:-:=:-:\nSelect a choice from the menu: ");
            string _userInput = Console.ReadLine();

            if (_userInput == "1")
            {
                Activity.DisplayStart();
            }
            else if (_userInput == "2")
            {

            }
            else if (_userInput == "3")
            {

            }
            else if (_userInput == "4")
            {
                
            }
        }

        // Student student = new Student("Gary", "1234");
        // Schedule schedule = new Schedule(student);

        // bool keepRunning = true;

        // while (keepRunning)
        // {
        //     Console.WriteLine("1. Display");
        //     Console.WriteLine("2. Add Course");
        //     Console.WriteLine("Choose Option:");

        //     string response = Console.ReadLine();

        //     if (response == "1")
        //     {
        //         schedule.Display();
        //     } else if (response == "2")
        //     {
        //         Console.WriteLine("Course Number?");
        //         string courseNumber = Console.ReadLine();

        //     }

        // }
    }
}