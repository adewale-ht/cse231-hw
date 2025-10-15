public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _bonus;
    private int _currentCount;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, int currentCount = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = currentCount;
    }

    public override bool IsComplete() => _currentCount >= _targetCount;

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
                return Points + _bonus;
            else
                return Points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        string box = IsComplete() ? "[X]" : "[ ]";
        return $"{box} {Name} ({Description}) -- Completed {_currentCount}/{_targetCount} times";
    }

    public override string Serialize()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{_targetCount}|{_bonus}|{_currentCount}";
    }
}