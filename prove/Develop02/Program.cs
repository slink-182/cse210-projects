using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu:\n1. Write New Entry\n2. Display Journal\n3. Save Journal\n4. Load Journal\n5. Quit");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = prompts[new Random().Next(prompts.Count)];
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                string date = DateTime.Now.ToString("MM/dd/yyyy");
                Entry entry = new Entry(date, prompt, response);
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save: ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
            }
            else if (choice == "5")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            Console.WriteLine();
        }
    }
}
