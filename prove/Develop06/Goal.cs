using System;

abstract class Goal
{
    public string Name { get; private set; }
    public int PointValue { get; private set; }
    public bool IsComplete { get; protected set; }
    public int BonusPoints { get; protected set; }
    public Goal(string name, int pointValue, int bonusPoints = 0)
    {
        Name = name;
        PointValue = pointValue;
        IsComplete = false;  
        BonusPoints = bonusPoints;
    }
    public abstract void RecordEvent();

   
    public abstract string GetStatus();
}
