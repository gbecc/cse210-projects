class ChecklistGoal : Goal
{
    private int _timesExecuted;
    private int _executionTimes;
    private int _bonusPoints;

    public ChecklistGoal(string title, string description, int points, int executionTimes, int bonusPoints) 
        : base(title, description, points)
    {
        _executionTimes = executionTimes;
        _bonusPoints = bonusPoints;
        _timesExecuted = 0;
    }

  public override void Run()
{
    if (_isComplete)
    {
        Console.WriteLine($"You've already completed '{_title}'.");
        return;  //Prevents additional completion.
    }

    _timesExecuted++;
    Console.WriteLine($"Recorded progress on '{_title}'. You earned {_points} points.");

    if (_timesExecuted == _executionTimes) //Final completion
    {
        Console.WriteLine($"Goal '{_title}' completed! Bonus {_bonusPoints} points awarded!");
    }
}




   public override int GetPoints()
{
    if (_timesExecuted == _executionTimes && !_isComplete) // adds bonus points after completion.
    {
        _isComplete = true;
        return _points + _bonusPoints; //Fixed -- Now does not reoccur after completion.
    }

    else if (_isComplete) 
    {
        return 0;
    }

    else return _points;
}





    public override void DisplayGoal()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_title} - {_description} ({_points} points per completion, Completed {_timesExecuted}/{_executionTimes})");
    }

    public override string SaveString()
    {
        return $"{base.SaveString()},{_executionTimes},{_bonusPoints},{_timesExecuted}";
    }

    public void SetTimesExecuted(int times)
    {
        _timesExecuted = times;
    }
    public string GetTitle()
{
    return _title;
}

}
