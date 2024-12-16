class EternalGoal : Goal
{
    public EternalGoal(string name, int pointValue) : base(name, pointValue) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded progress for '{Name}'. You earned {PointValue} points.");
    }

    public override string GetStatus()
    {
        return $"[∞] {Name}";
    }
}
