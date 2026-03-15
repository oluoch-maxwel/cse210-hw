using System;
using System. Collections.Generic;
using System. IO;
// Stores a list of journal entries.
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }

public void SaveToFile(string filename)
    {
        StreamWriter outputFile = new StreamWriter(filename);
        using (outputFile)
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}| {entry._entryText}");
            }
            
        }
    }

public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry();

            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);
        }
    }
    
}
