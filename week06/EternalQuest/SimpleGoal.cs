public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        _completed = false;
    }

    public override bool IsComplete() => _completed;

    public override int RecordEvent()
    {
        if (!_completed)
        {
            _completed = true;
            return GetPoints();
        }
        return 0;
    }

    public override string GetStatus()
    {
        return $"[{(_completed ? "X" : " ")}] {GetName()}";
    }

    public override string GetGoalType() => "SimpleGoal";

    public override string Serialize()
    {
        return $"{GetGoalType()}|{GetName()}|{GetPoints()}|{_completed}";
    }
}
