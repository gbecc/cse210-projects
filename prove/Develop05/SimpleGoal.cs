class SimpleGoal : Goal
{
    public SimpleGoal(string title, string description, int points) 
        : base(title, description, points) { }

    public override void Run()
    {
        _isComplete = true;
        Console.WriteLine($"Goal '{_title}' completed! You earned {_points} points.");
    }
}
