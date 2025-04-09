public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, int points, int target, int bonus) : base(name, points)
    {
        _timesCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override bool IsComplete() => _timesCompleted >= _target;

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _timesCompleted++;
            if (_timesCompleted == _target)
            {
                return GetPoints() + _bonus;
            }
            return GetPoints();
        }
        return 0;
    }

    public override string GetStatus()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {GetName()} -- Completed {_timesCompleted}/{_target}";
    }

    public override string GetGoalType() => "ChecklistGoal";

    public override string Serialize()
    {
        return $"{GetGoalType()}|{GetName()}|{GetPoints()}|{_target}|{_bonus}|{_timesCompleted}";
    }
}
