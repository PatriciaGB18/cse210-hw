using System;

public class Entry
{
    
    public DateTime Date { get; private set; }
    public string Prompt { get; private set; }
    public string Response { get; private set; }
    public string UserName { get; private set; }  
    public string Mood { get; private set; }      
    public string Location { get; private set; } 

    
    public Entry(string prompt, string response, string userName, string mood, string location)
    {
        Date = DateTime.Now;
        Prompt = prompt;
        Response = response;
        UserName = userName;
        Mood = mood;
        Location = location;
    }

    
    public Entry(DateTime date, string prompt, string response, string userName, string mood, string location)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        UserName = userName;
        Mood = mood;
        Location = location;
    }

    
    public void DisplayEntry()
    {
        Console.WriteLine($" Date: {Date:yyyy-MM-dd}");
        Console.WriteLine($" Prompt: {Prompt}");
        Console.WriteLine($" Response: {Response}");
        Console.WriteLine($" User: {UserName}");
        Console.WriteLine($" Mood: {Mood}");
        Console.WriteLine($" Location: {Location}");
        Console.WriteLine(new string('-', 40)); 
    }

    
    public string ToCsvFormat()
    {
        return $"{Date:yyyy-MM-dd},\"{Prompt}\",\"{Response}\",\"{UserName}\",\"{Mood}\",\"{Location}\"";
    }
}
