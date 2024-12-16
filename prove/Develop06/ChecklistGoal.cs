class ChecklistGoal : Goal
{
    private int TargetCount;
    private int CurrentCount;

    public ChecklistGoal(string name, int pointValue, int targetCount, int bonusPoints)
        : base(name, pointValue, bonusPoints)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
    }

    public override void RecordEvent()
{
    if (CurrentCount < TargetCount)
    {
        CurrentCount++;
        Console.WriteLine($"Progress made for '{Name}'. You earned {PointValue} points.");

        
        if (CurrentCount >= TargetCount)
        {
            IsComplete = true; 
            Console.WriteLine($"Congratulations! You've completed '{Name}' and earned a bonus of {BonusPoints} points.");
        }
    }
    else
    {
        Console.WriteLine($"Goal '{Name}' is already completed.");
    }
}



    public override string GetStatus()
    {
        return IsComplete 
            ? $"[X] {Name} (Completed {CurrentCount}/{TargetCount})" 
            : $"[ ] {Name} (Completed {CurrentCount}/{TargetCount})";
    }
}
