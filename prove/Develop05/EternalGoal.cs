class EternalGoal : Goal
{
    private int _eternalPoints;

    public EternalGoal(string title, string description, int points, int eternalPoints) 
        : base(title, description, points)
    {
        _eternalPoints = eternalPoints;
    }

    public override void Run()
    {
        Console.WriteLine($"You recorded progress on '{_title}'. You earned {_eternalPoints} points.");
    }

    public override int GetPoints()
    {
        return _eternalPoints;  // Ensure that points are granted on each progress record
    }

    public override string SaveString()
    {
        return $"{base.SaveString()},{_eternalPoints}";
    }
}
