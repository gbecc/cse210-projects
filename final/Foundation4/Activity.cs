using System;

public class Activity
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

    public virtual double GetDistance() => 0;
    public virtual double GetPace() => 0;
    public virtual double GetSpeed() => 0;

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_duration} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile";
    }
}
