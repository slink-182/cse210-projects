using System.IO.Compression;

public class Journal
{
    Random randomNumber = new Random();
    private List<Entry> _journalEntries = new List<Entry>();
    private List<string> _promptList = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    
    public Journal(){}

    public void AddEntry() //create the method that allows the user to add another entry to the list of entrys
    {
        Console.WriteLine("input current date");
        Console.Write("> ");

        //record the date
        string _date = Console.ReadLine();

        //set up random number for the index prompt return
        int randomIndex = randomNumber.Next(_promptList.Count);
        string _randomPrompt = _promptList[randomIndex];

        Console.Write($"{_randomPrompt}\n> ");

        //record user response to prompt
        string _userInput = Console.ReadLine();

        //store data into object
        Entry entry1 = new Entry(_date,_randomPrompt,_userInput);

        //add to the journaEntries list
        _journalEntries.Add(entry1);

    }

    public void DisplayTotalEntries()
    {
        foreach (Entry entry in _journalEntries)
        {
            Console.WriteLine(entry.GetEntry());
        }

    }

    public void FileSave()
    {
        Console.Write("enter file name to save to\n> ");
        string filename = Console.ReadLine();

        // Loop through each entry and write its data to the file
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _journalEntries)
            {
                // Combine date, prompt, and user response with '|' separator
                string line = entry.GetDate() + "|" + entry.GetPrompt() + "|" + entry.GetUserInput();
                writer.WriteLine(line);
            }
        }

        Console.WriteLine("saved successfully");
    }

    public void FileLoad()
    {
        Console.Write("enter filename to load\n> ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        _journalEntries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            string date = parts[0];
            string prompt = parts[1];
            string userInput = parts[2];

            Entry entry = new Entry(date, prompt, userInput);
            _journalEntries.Add(entry);
        }


    }
    

}