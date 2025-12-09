using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference referenceObj = new Reference("John", "3", 16, 16);
        string scriptureText = "For God so loved the world that he gave his only begotten Son";
        List<Word> words = new List<Word>();
        foreach (string w in scriptureText.Split(' '))
        {
            words.Add(new Word(w));
        }

        Scripture scriptureObj = new Scripture(words, referenceObj);

        string input = "";

        while (input.ToLower() != "quit" && !scriptureObj.AllWordsHidden())
        {
            Console.Clear();
            scriptureObj.Display();

            Console.Write("\npress enter to hide more words, or type 'quit' to exit\n> ");
            input = Console.ReadLine();

            if (input == "")
            {
                scriptureObj.HideRandomWord();
            }
        }

        Console.Clear();
        scriptureObj.Display();
        Console.WriteLine("\nall words are now hidden or program ended.");
    }
}
