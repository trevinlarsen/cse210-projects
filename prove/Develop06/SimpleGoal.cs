using System;

class SimpleGoal : Goal
{    public SimpleGoal(string name, int pointValue, int bonusPoints = 0)
        : base(name, pointValue, bonusPoints) { }
    public override void RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = true; 
            Console.WriteLine($"Goal '{Name}' is complete! You earned {BonusPoints} bonus points.");
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' is already complete.");
        }
    }
    public override string GetStatus()
    {
        
        return IsComplete ? $"[X] {Name} (Completed)" : $"[ ] {Name}";
    }
}
