/*
 * 
 * This program allows users to record daily journal entries with prompts. 
 * 1. The program now saves the journal entries to a CSV file format that can be opened in Excel. 
 * 2. The CSV file format correctly handles commas and quotes within the journal content.
 * 3. Added additional information to each journal entry: User's name, mood, and location are saved with each entry.
 * 4. Prompts are generated randomly, allowing for a more dynamic journaling experience.
 * 5. The program includes a menu to write new entries, display, save, and load the journal from a file.
*/

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Application!");

        // Get user details
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Enter your current mood: ");
        string userMood = Console.ReadLine();

        Console.Write("Enter your current location: ");
        string userLocation = Console.ReadLine();

        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("📓 Journal Application");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to a CSV file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($" Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    Entry newEntry = new Entry(prompt, response, userName, userMood, userLocation);
                    journal.AddEntry(newEntry);
                    Console.WriteLine(" Your entry has been saved!");
                    break;
                
                case "2":
                    
                    journal.DisplayJournal();
                    Console.WriteLine("Press any key to return to the menu...");
                    Console.ReadKey();
                    break;
                
                case "3":
                    
                    Console.Write("Enter a filename to save the journal: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToCsv(saveFile);
                    Console.WriteLine("Your journal has been saved to a CSV file.");
                    Console.WriteLine("Press any key to return to the menu...");
                    Console.ReadKey();
                    break;

                case "4":
                    
                    Console.Write("Enter a filename to load the journal: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine("Press any key to return to the menu...");
                    Console.ReadKey();
                    break;

                case "5":
                    
                    running = false;
                    Console.WriteLine("Goodbye! See you next time.");
                    break;

                default:
                    Console.WriteLine(" Invalid option. Please choose a valid number.");
                    break;
            }
        }
    }
}
