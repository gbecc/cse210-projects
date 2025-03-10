using System;
using System.Collections.Generic;
using System.IO;

class Event
{
    public void Save(List<Goal> goals, int score)
    {
        Console.Write("Enter filename to save (e.g., goals.txt): ");
        string filePath = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(score);
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.SaveString());
            }
        }
        Console.WriteLine($"Progress saved successfully to '{filePath}'!");
    }

    public (List<Goal>, int) Load()
    {
        Console.Write("Enter filename to load (e.g., goals.txt): ");
        string filePath = Console.ReadLine();

        List<Goal> goals = new List<Goal>();
        int score = 0;

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                Goal goal = Goal.LoadGoal(data);
                if (goal != null) goals.Add(goal);
            }
            Console.WriteLine($"Progress loaded successfully from '{filePath}'!");
        }
        else
        {
            Console.WriteLine($"File '{filePath}' not found. Starting fresh.");
        }

        return (goals, score);
    }
}
