using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        List<string> _promptList = new List<string>
        {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
        };
        List<string> _answerList = new List<string>();

        
        bool running = true; //make sure the display menu continues to loop until user asks to quit
        while (running)
        {
            Console.Write("Welcome to the Journal Program!\nPlease select one of the following options:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nchoose an option: ");
            string _userInput = Console.ReadLine();

            if (_userInput == "1") //write
            {
                foreach (string prompt in _promptList)
                {
                Console.Write($"{prompt}\n> ");
                string _answer = Console.ReadLine();
                _answerList.Add(_answer);
                }
                
            } else if (_userInput == "2") //display
            {
                
            } else if (_userInput == "3") //load
            {
                
            } else if (_userInput == "4") //save
            {
                
            } else if (_userInput == "5") //quit
            {
                
            }
        }
    
    
    }


}

