using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public int Score => _score;
    public IReadOnlyList<Goal> Goals => _goals;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            int points = _goals[index].RecordEvent();
            _score += points;
            Console.WriteLine(points > 0 ? $"You earned {points} points!" : "Goal already completed.");
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void Save(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            sw.WriteLine(_score);
            foreach (var goal in _goals)
            {
                sw.WriteLine(goal.Serialize());
            }
        }
    }

    public void Load(string filename)
    {
        _goals.Clear();
        if (!File.Exists(filename)) return;
        using (StreamReader sr = new StreamReader(filename))
        {
            _score = int.Parse(sr.ReadLine());
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                _goals.Add(Goal.Deserialize(line));
            }
        }
    }
}