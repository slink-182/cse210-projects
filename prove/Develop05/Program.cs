using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");

        //this is the big wig file that runs the fun little project. rawr
        
        bool RUNNING = true; //keep the option menu running 
        while (RUNNING)
        {
            Console.WriteLine("Welcome to the goal setter! Set a goal, but first, set the goal type!\n1. Simple Goal\n2. Checklist Goal\n3. Eternal Goal\n4. Quit Program\n ~ ");
            string _answer = Console.ReadLine();

            if (_answer == "1") //do the simple goal
            {

                
            } else if (_answer == "2") //do the checklist goal
            {
                
            }else if (_answer == "3") //do the eternal goal
            {
                
            }else if (_answer == "4") //get the oomph outta there
            {
                RUNNING = false;
            }
        }
    }
}