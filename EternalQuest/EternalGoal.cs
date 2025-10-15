public class EternalGoal : Goal
{
    private int _timesCompleted;

    public EternalGoal(string name, string description, int points, int timesCompleted = 0)
        : base(name, description, points)
    {
        _timesCompleted = timesCompleted;
    }

    public override bool IsComplete() => false;

    public override int RecordEvent()
    {
        _timesCompleted++;
        return Points;
    }

    public override string GetStatus()
    {
        return $"[ ] {Name} ({Description}) -- Completed {_timesCompleted} times";
    }

    public override string Serialize()
    {
        return $"EternalGoal|{Name}|{Description}|{Points}|{_timesCompleted}";
    }
}