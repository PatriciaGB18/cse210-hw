using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    public Reference Reference { get; }
    private List<Word> Words { get; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public bool HideRandomWords(int count = 2)
    {
        var visibleWords = Words.Where(word => !word.Hidden).ToList();

        if (visibleWords.Count == 0)
            return false; 

        var random = new Random();
        foreach (var word in visibleWords.OrderBy(_ => random.Next()).Take(count))
        {
            word.Hide();
        }

        return true; 
    }

    public override string ToString()
    {
        string scriptureText = string.Join(" ", Words);
        return $"{Reference}\n{scriptureText}";
    }
}
