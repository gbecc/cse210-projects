using System;

public class Comment
{
    // Private fields
    private string _commenterName;
    private string _text;

    // Public read-only properties
    public string CommenterName => _commenterName;
    public string Text => _text;

    // Constructor
    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    public void Display()
    {
        Console.WriteLine($"- {CommenterName}: {Text}");
    }
}
