using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    
    public void SaveToCsv(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("Date,Prompt,Response,UserName,Mood,Location"); 
                foreach (Entry entry in entries)
                {
                    writer.WriteLine(entry.ToCsvFormat());  
                }
            }
            Console.WriteLine($"Your journal has been saved to {fileName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving to file: {ex.Message}");
        }
    }

    
    public void LoadFromFile(string fileName)
    {
        try
        {
            entries.Clear();  
            using (StreamReader reader = new StreamReader(fileName))
            {
                reader.ReadLine();  
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (values.Length == 6)
                    {
                        DateTime date = DateTime.Parse(values[0]);
                        string prompt = values[1].Trim('"');
                        string response = values[2].Trim('"');
                        string userName = values[3].Trim('"');
                        string mood = values[4].Trim('"');
                        string location = values[5].Trim('"');

                        Entry entry = new Entry(date, prompt, response, userName, mood, location);
                        AddEntry(entry);
                    }
                }
            }
            Console.WriteLine($"Journal has been loaded from {fileName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading from file: {ex.Message}");
        }
    }
}
