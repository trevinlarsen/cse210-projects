using System;
abstract class Activity
{
    private DateTime _date;
    private int _duration;

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }
    public DateTime GetDate() => _date;
    public int GetDuration() => _duration;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} ({_duration} min): Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min/km";
    }
}
class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }
    public override double GetDistance() => _distance;
    public override double GetSpeed() => (GetDistance() / GetDuration()) * 60;
    public override double GetPace() => GetDuration() / GetDistance();
}

class Swimming : Activity
{
    private int _laps;
    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }
    public override double GetDistance() => _laps * 0.05;
    public override double GetSpeed() => (GetDistance() / GetDuration()) * 60;
    public override double GetPace() => GetDuration() / GetDistance();
}
class Cycling : Activity
{
    private double _speed;
    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }
    public override double GetDistance() => (_speed * GetDuration()) / 60;
    public override double GetSpeed() => _speed;
    public override double GetPace() => 60 / _speed;
}
class Program
{
    static void Main()
    {
        var activities = new Activity[]
        {
            new Running(new DateTime(2021, 12, 20), 50, 5.0),
            new Cycling(new DateTime(2022, 12, 21), 40, 25.0),
            new Swimming(new DateTime(2027, 12, 22), 30, 20)
        };
        
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
