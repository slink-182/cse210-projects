using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");

        //this is the big wig file that runs the fun little project. rawr
        
        int pointTotal = 0; //set the default value to 0 without it resetting every time the while loop loops
        bool RUNNING = true; //keep the option menu running
        while (RUNNING)
        {
            Console.WriteLine("Welcome to the goal setter! Set a goal, but first, set the goal type!\n1. Simple Goal\n2. Checklist Goal\n3. Eternal Goal\n4. Check Total Points\n5.Quit Program\n> ");
            string _answer = Console.ReadLine();

            if (_answer == "1") //do the simple goal
            {
                //create the attributes that fill in the parameters of the object
                Console.WriteLine("Welcome to the simple goal setter!\nInput your goal: ");
                string goalName = Console.ReadLine();
                Console.WriteLine("Please set how much this goal is worth.\nInput goal value: ");
                string s = Console.ReadLine();
                int goalValue = int.Parse(s);

                //create the object that takes the attributes
                Simple simpleobj1 = new Simple(false,goalName,goalValue,pointTotal);

            } else if (_answer == "2") //do the checklist goal
            {
                
            } else if (_answer == "3") //do the eternal goal
            {
                
            } else if (_answer == "4") //check total point score
            {
                
            } else if (_answer == "5") //get the oomph outta there
            {
                RUNNING = false;
                
            }
        }
    }
}


/*notes
I might need to reframe this assigment. If I want to keep track of multiple goals at a time, I might need a list, and potentially, a list of lists.
The way that I currently have it may not work for that simply because of what each if statement has.
*/