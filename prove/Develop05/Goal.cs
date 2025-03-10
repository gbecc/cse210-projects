using System;
using System.Collections.Generic;
using System.IO;

abstract class Goal
{
    protected string _title;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public abstract void Run();

    public virtual void DisplayGoal()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_title} - {_description} ({_points} points)");
    }

    public virtual int GetPoints()
    {
        return _isComplete ? _points : 0;
    }

    public virtual string SaveString()
    {
        return $"{GetType().Name},{_title},{_description},{_points},{_isComplete}";
    }

    public static Goal LoadGoal(string[] data)
{
    string title = data[1];
    string description = data[2];
    int points = int.Parse(data[3]);
    bool isComplete = bool.Parse(data[4]);

    switch (data[0])
    {
        case "SimpleGoal":
            return new SimpleGoal(title, description, points) { _isComplete = isComplete };

        case "EternalGoal":
            int eternalPoints = int.Parse(data[5]);
            return new EternalGoal(title, description, points, eternalPoints);

        case "ChecklistGoal":
            int executionTimes = int.Parse(data[5]);
            int bonusPoints = int.Parse(data[6]);
            int timesExecuted = int.Parse(data[7]);

            ChecklistGoal checklistGoal = new ChecklistGoal(title, description, points, executionTimes, bonusPoints);
            checklistGoal._isComplete = isComplete;
            checklistGoal.SetTimesExecuted(timesExecuted);  // ✅ Use setter method
            return checklistGoal;

        default:
            return null;
    }
}


}
