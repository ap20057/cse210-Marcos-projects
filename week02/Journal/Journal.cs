/*Author: Marcos Alas
Project: Journal app*/
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        List<string> lines = new List<string>();

        foreach (Entry entry in _entries)
        {
            lines.Add(entry.ToFileFormat());
        }

        File.WriteAllLines(file, lines);
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("The file was not found.");
            return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            try
            {
                _entries.Add(Entry.FromFileFormat(line));
            }
            catch (FormatException)
            {
                Console.WriteLine("Skipped invalid entry in file.");
            }
        }
    }
}