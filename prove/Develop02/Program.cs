using System;
using System.Collections.Generic;
using System.IO;

/////////////////////////////////////////////////////
// Entry Class
/////////////////////////////////////////////////////
public class Entry
{
    public string Prompt { get; set; } //apparently the values get and set are used to both read and write data into these variables.
    public string Response { get; set; }
    public string Date { get; set; }

    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public void Display()
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine("----------------------------");
    }
}

/////////////////////////////////////////////////////
// Journal Class
/////////////////////////////////////////////////////
public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
            return;
        }

        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();

        foreach (var line in File.ReadAllLines(filename))
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                _entries.Add(new Entry(parts[1], parts[2], parts[0]));
            }
        }

        Console.WriteLine("Journal loaded successfully!");
    }
}

/////////////////////////////////////////////////////
// Program Class
/////////////////////////////////////////////////////
class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        string[] prompts = new string[]
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random rand = new Random();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Journal Menu ---");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Load journal from file");
            Console.WriteLine("4. Save journal to file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            //all the nasty if statements enabling the user to choose what they want to do.
            if (choice == "1")
            {
                string prompt = prompts[rand.Next(prompts.Length)];
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToString("yyyy-MM-dd");

                Entry newEntry = new Entry(prompt, response, date);
                myJournal.AddEntry(newEntry);
                Console.WriteLine("Entry added!\n");
            }
            else if (choice == "2")
            {
                Console.WriteLine("\n--- Your Journal Entries ---");
                myJournal.DisplayEntries();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to load from: ");
                string loadFile = Console.ReadLine();
                myJournal.LoadFromFile(loadFile);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to save to: ");
                string saveFile = Console.ReadLine();
                myJournal.SaveToFile(saveFile);
            }
            else if (choice == "5")
            {
                running = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1-5.");
            }
        }
    }
}


//I'm starting to see the structure of name, attrribute, and methods. I prefer calling it name, variables, and functions, but whatever.
//the hardest part of this assignment so far is just the general syntax of C#. I'm having to review syntax every single time I want to write code. 
//Beyond that, I'm having to ask AI to understand what each line does in the examples it gives.
//Really, I just need to write the same line a thousand times to internalize how to code in C#.