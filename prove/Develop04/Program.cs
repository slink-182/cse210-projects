using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {

        bool running = true;

        if (running)
        {
            Console.Write(":-:=:-:\n1.Start Breathing Activity\n2.Start Reflection Activity\n3.Start Listing Activity\n4.Exit\n:-:=:-:\nSelect a choice from the menu: ");
            string _userInput = Console.ReadLine();

            if (_userInput == "1")
            {
                Breathe breath1 = new Breathe("Breathe", "This activity will help you relax by walking you through breathing in and out slowly. CLear your mind and focus on your breathing.", 0);
                breath1.BreatheCycle();
            }
            else if (_userInput == "2")
            {
                Reflection reflect1 = new Reflection(["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."], ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"], "Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                reflect1.DisplayReflection();
            }
            else if (_userInput == "3")
            {
                Listing listing1 = new Listing(["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"], [], "Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
                listing1.ListingMethod();
            }
            else if (_userInput == "4")
            {
                Console.WriteLine("Farewell.");
                running = false;
            }
        }


    }
}

//notes 
//I feel like the if statements should loop after each activity but they currently don't. 