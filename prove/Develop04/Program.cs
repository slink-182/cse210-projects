using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");

        Student student = new Student("Gary", "1234");
        Schedule schedule = new Schedule(student);

        bool keepRunning = true;
        
        while (keepRunning)
        {
            Console.WriteLine("1. Display");
            Console.WriteLine("2. Add Course");
            Console.WriteLine("Choose Option:");

            string response = Console.ReadLine();

            if (response == "1")
            {
                schedule.Display();
            } else if (response == "2")
            {
                Console.WriteLine("Course Number?");
                string courseNumber = Console.ReadLine();

            }

        }
    }
}