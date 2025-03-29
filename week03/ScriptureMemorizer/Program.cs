/*
    Scripture Memorization Program
    -------------------------------------------
    This program helps users memorize scriptures by gradually hiding words.
    Exceeds requirements by adding:
    A library of scriptures (chooses randomly).
    Loads scriptures from a text file.
    Ensures only visible words are hidden.
    Created for enhanced scripture learning experience.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void ClearScreen()
    {
        Console.Clear();
        
    }

    // Carregar as escrituras de um arquivo de texto
    static List<Scripture> LoadScriptures(string filePath)
    {
        var scriptures = new List<Scripture>();
        var lines = File.ReadAllLines(filePath);

        foreach (var line in lines)
        {
            var parts = line.Split('|');
            if (parts.Length == 2)
            {
                var referenceParts = parts[0].Split(' ');
                var book = referenceParts[0];
                var chapterVerse = referenceParts[1].Split(':');
                var chapter = int.Parse(chapterVerse[0]);
                var verses = chapterVerse[1].Split('-').Select(int.Parse).ToArray();
                
                var reference = verses.Length > 1 
                    ? new Reference(book, chapter, verses[0], verses[1]) 
                    : new Reference(book, chapter, verses[0]);
                
                scriptures.Add(new Scripture(reference, parts[1]));
            }
        }

        return scriptures;
    }

static void Main()
{
    var scriptures = LoadScriptures("scriptures.txt");
    var random = new Random();
    var scripture = scriptures[random.Next(scriptures.Count)];
    
    // Salva a versão completa da escritura
    var old = scripture.ToString();

    while (true)
    {
        ClearScreen();
        Console.WriteLine(scripture); // Exibe a escritura com ou sem palavras ocultas
        Console.Write("\nHint: Focus on the first few words. Press Enter to continue or type 'quit' to exit: ");
        string input = Console.ReadLine().Trim().ToLower();

        if (input == "quit")
            break;

        // Chama HideRandomWords e continua ocultando palavras
        if (!scripture.HideRandomWords())
            break;
    }

    ClearScreen();
    Console.WriteLine(old); // Exibe a escritura completa no final
    Console.WriteLine("\nAll words are hidden. Program ended.");
}

}

