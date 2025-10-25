using System;

class Program
{
    static void Main(string[] args)
    {
        Reference myReference = new Reference("John", 3, 16, 16);
        Scripture myScripture = new Scripture(myReference, "For God so loved the world that he gave his only Son...");

        while (!myScripture.IsFullyHidden())
        {
            Console.Clear();
            myScripture.Display();

            Console.WriteLine("Press enter to hide a word or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            myScripture.HideRandomWord();
        }

        Console.Clear();
        myScripture.Display();
        Console.WriteLine("All words are hidden. Good job!");
    
    }
}