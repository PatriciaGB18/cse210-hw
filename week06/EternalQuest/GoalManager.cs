using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void CreateGoal()
    {
        Console.WriteLine("1. Progress Goal");
        Console.Write("Select a choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter points per event: ");
        int points = int.Parse(Console.ReadLine());

        Console.Write("Enter target to complete: ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("Enter bonus for completion: ");
        int bonus = int.Parse(Console.ReadLine());

        _goals.Add(new ProgressGoal(name, points, target, bonus));
    }

    public void ShowGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void RecordEvent()
    {
        ShowGoals();
        Console.Write("Which goal did you complete? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int earned = _goals[index].RecordEvent();
        _score += earned;
        Console.WriteLine($"You earned {earned} points!");
    }

    public void ShowScore()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            sw.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                sw.WriteLine(goal.Serialize());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            string type = parts[0];
            string name = parts[1];
            int points = int.Parse(parts[2]);

            if (type == "ProgressGoal")
            {
                int target = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                int current = int.Parse(parts[5]);
                ProgressGoal pg = new ProgressGoal(name, points, target, bonus);
                
                
                typeof(ProgressGoal).GetField("_current", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(pg, current);

                _goals.Add(pg);
            }
        }
    }
}
