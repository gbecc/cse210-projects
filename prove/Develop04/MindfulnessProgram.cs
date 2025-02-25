using System;
using System.Reflection.Metadata;

class MindfulnessProgram
{
    protected int _duration;

    protected string _description;

    public MindfulnessProgram (int duration, string description)
    {
        _duration = duration;
        _description = description;
    }

    public void Spinner()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public string DisplayMessage()
    {
        Console.Clear();
        Console.WriteLine("\nPlease select an option:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Enter your choice (1-4): ");

        string choice = Console.ReadLine();
        if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
    {
        return choice;
    }
    else
    {
        Console.WriteLine("Invalid choice. Please try again.");
        return DisplayMessage();
    }
    }

    public int DurationInput()
    {
        Console.WriteLine("Please type in a duration for the activity (in seconds):");
        string input = Console.ReadLine();
        int _duration;

        if (int.TryParse(input, out _duration))
    {
        return _duration;
    }
    else
    {
        Console.WriteLine("Invalid entry. Please choose a number.");
        return DurationInput();
    }
    }
    public void StartActivity(string activityName)
    {
        Console.WriteLine($"\nStarting {activityName}...");
        Console.WriteLine(_description);
        Console.WriteLine("Prepare to begin...");
        Spinner();
    }

    public void EndActivity(string activityName)
    {
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You have completed the {activityName} for {_duration} seconds.");
        Spinner();
    }
}