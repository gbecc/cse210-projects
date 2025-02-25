using System;
using System.Collections.Generic;

class ListingActivity : MindfulnessProgram
{
    private static int _listingCount = 0;
    private List<string> listingPrompts = new List<string>
    {
        "Who are some people that you appreciate",
        "What are some of your personal strengths?",
        "Who have you helped this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> userResponses = new List<string>();

    public ListingActivity(int duration) 
        : base(duration, "This activity helps you reflect on the good things you've done, or some good things you have in life.")
    {
    }

    public void GetPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(listingPrompts.Count);
        Console.WriteLine(listingPrompts[index]);
        Spinner();
    }

    public void UserResponse()
    {
        Console.WriteLine("Start listing items:");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrEmpty(response))
            {
                userResponses.Add(response);
            }
        }
    }

    public void DisplayUserResponses()
    {
        Console.WriteLine("\nYou listed the following items:");
        foreach (string response in userResponses)
        {
            Console.WriteLine($"- {response}");
        }
    }

    public void Start()
    {
        Console.Clear();
        _listingCount++;
        Console.WriteLine($"\nYou have completed this activity {_listingCount} times this session, including this time.");
        StartActivity("Listing Activity");
        GetPrompt();
        UserResponse();
        DisplayUserResponses();
        EndActivity("Listing Activity");
    }
}
