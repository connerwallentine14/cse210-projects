using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        while (true)
        {
            Console.WriteLine($"\nScore: {_score} | Level: {GetLevel()}");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");

            Console.Write("Select: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": RecordEvent(); break;
                case "4": Save(); break;
                case "5": Load(); break;
                case "6": return;
            }
        }
    }

    private int GetLevel()
    {
        return _score / 1000; // creativity feature
    }

    private void CreateGoal()
    {
        Console.WriteLine("1. Simple\n2. Eternal\n3. Checklist");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int pts = int.Parse(Console.ReadLine());

        if (type == "1")
            _goals.Add(new SimpleGoal(name, desc, pts));
        else if (type == "2")
            _goals.Add(new EternalGoal(name, desc, pts));
        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, pts, target, bonus));
        }
    }

    private void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()} {_goals[i].GetName()}");
        }
    }

    private void RecordEvent()
    {
        ListGoals();
        Console.Write("Select goal: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int earned = _goals[index].RecordEvent();
        _score += earned;

        Console.WriteLine($"You earned {earned} points!");
    }

    private void Save()
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            sw.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                sw.WriteLine(g.SaveFormat());
            }
        }
        Console.WriteLine("Saved successfully!");
    }

    private void Load()
{
    if (!File.Exists("goals.txt"))
    {
        Console.WriteLine("No save file found.");
        return;
    }

    string[] lines = File.ReadAllLines("goals.txt");
    _score = int.Parse(lines[0]);
    _goals.Clear();

    for (int i = 1; i < lines.Length; i++)
    {
        string[] parts = lines[i].Split('|');

        if (parts[0] == "Simple")
        {
            SimpleGoal g = new SimpleGoal(parts[1], "", int.Parse(parts[3]));
            if (bool.Parse(parts[2]))
                g.RecordEvent(); // mark complete

            _goals.Add(g);
        }
        else if (parts[0] == "Eternal")
        {
            _goals.Add(new EternalGoal(parts[1], "", int.Parse(parts[2])));
        }
        else if (parts[0] == "Checklist")
        {
            ChecklistGoal g = new ChecklistGoal(
                parts[1],
                "",
                int.Parse(parts[4]),
                int.Parse(parts[3]),
                int.Parse(parts[5])
            );

            int current = int.Parse(parts[2]);
            for (int j = 0; j < current; j++)
                g.RecordEvent();

            _goals.Add(g);
        }
    }

    Console.WriteLine("Loaded successfully!");
}
}