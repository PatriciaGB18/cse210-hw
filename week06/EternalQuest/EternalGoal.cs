public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) {}

    public override bool IsComplete() => false;

    public override int RecordEvent()
    {
        return GetPoints(); 
    }

    public override string GetStatus()
    {
        return $"[∞] {GetName()}";
    }

    public override string GetGoalType() => "EternalGoal";

    public override string Serialize()
    {
        return $"{GetGoalType()}|{GetName()}|{GetPoints()}";
    }
}
