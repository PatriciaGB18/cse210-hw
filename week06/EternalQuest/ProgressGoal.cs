public class ProgressGoal : Goal
{
    private int _current;
    private int _target;
    private int _bonus;

    public ProgressGoal(string name, int points, int target, int bonus)
        : base(name, points)
    {
        _current = 0;
        _target = target;
        _bonus = bonus;
    }

    public override bool IsComplete() => _current >= _target;

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _current++;
            if (IsComplete())
            {
                return GetPoints() + _bonus;
            }
            return GetPoints();
        }
        return 0;
    }

    public override string GetStatus()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {GetName()} -- Progress {_current}/{_target}";
    }

    public override string GetGoalType() => "ProgressGoal";

    public override string Serialize()
    {
        return $"{GetGoalType()}|{GetName()}|{GetPoints()}|{_target}|{_bonus}|{_current}";
    }
}
