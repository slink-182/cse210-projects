using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> Entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry e in Entries)
        {
            e.Display();
            Console.WriteLine();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry e in Entries)
            {
                writer.WriteLine(e.ToFileString());
            }
        }
    }

   public void LoadFromFile(string filename)
    {
        Entries.Clear();
        foreach (string line in File.ReadAllLines(filename))
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entries.Add(new Entry(parts[0], parts[1], parts[2]));
            }
        }
    }
}