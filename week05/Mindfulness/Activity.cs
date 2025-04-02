using System;
using System.Threading;

class Activity
{
    
    protected string _name;
    protected string _description;
    protected int _duration;

   
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine(_description);
        Console.Write("\nEnter the duration of the activity (in seconds): ");
        
        
        _duration = int.Parse(Console.ReadLine());
        
        Console.WriteLine("\nGet ready to begin...");
        ShowSpinner(3); 
    }

    
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGood job! You have completed the activity.");
        Console.WriteLine($"You spent {_duration} seconds in the {_name} Activity.");
        ShowSpinner(3);
    }

    
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
        }
    }

    
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
