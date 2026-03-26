using System;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string desc, int points)
        : base(name, desc, points) { }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return GetPoints();
        }
        return 0;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatus()
    {
        return _isComplete ? "[X]" : "[ ]";
    }
    public override string SaveFormat()
{
    return $"Simple|{GetName()}|{_isComplete}|{GetPoints()}";
}
}