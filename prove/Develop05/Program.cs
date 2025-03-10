using System;
using System.Collections.Generic;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;
    static Event eventManager = new Event();

    static void Main()
    {
        while (true)
        {
            Console.Clear(); // Clears the console for a cleaner look
            Console.WriteLine($"You currently have {score} points.\n");

            Console.WriteLine("Eternal Quest - Goal Tracker");
            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. View Goals");
            Console.WriteLine("3. Record Progress");
            Console.WriteLine("4. Save Progress");
            Console.WriteLine("5. Load Progress");
            Console.WriteLine("6. Exit");
            Console.Write("\nSelect an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    DisplayGoals();
                    break;
                case "3":
                    RecordProgress();
                    break;
                case "4":
                    eventManager.Save(goals, score);
                    break;
                case "5":
                    (goals, score) = eventManager.Load();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine(); // Pause before returning to the menu
        }
    }

    static void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("Enter goal title:");
        string title = Console.ReadLine();
        Console.WriteLine("Enter goal description:");
        string description = Console.ReadLine();
        Console.WriteLine("Enter points for completion:");
        int points = int.Parse(Console.ReadLine());

        Console.WriteLine("Select goal type: 1. Simple 2. Eternal 3. Checklist");
        string type = Console.ReadLine();

        switch (type)
        {
            case "1":
                goals.Add(new SimpleGoal(title, description, points));
                break;
            case "2":
                Console.WriteLine($"Assigning {points} points per completion.");
                int eternalPoints = points;
                goals.Add(new EternalGoal(title, description, points, eternalPoints));
                break;
            case "3":
                Console.WriteLine("How many times must it be completed?");
                int times = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter bonus points for completion:");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(title, description, points, times, bonus));
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }

    static void DisplayGoals()
    {
        Console.Clear();
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
        }
        else
        {
            foreach (var goal in goals)
                goal.DisplayGoal();
        }
    }

static void RecordProgress()
{
    Console.Clear();
    DisplayGoals();

    if (goals.Count == 0)
    {
        Console.WriteLine("\nNo goals available to record progress.");
        return;
    }

    Console.WriteLine("\nEnter goal number to record progress:");
    if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= goals.Count)
    {
        Goal selectedGoal = goals[index - 1];

        selectedGoal.Run();  // ✅ Run the goal first to update its status

        int earnedPoints = selectedGoal.GetPoints();  // ✅ Now calculate points AFTER status updates

        if (earnedPoints > 0)  // ✅ Only add points if they were earned
        {
            score += earnedPoints;
            Console.WriteLine($"You now have {score} points!");
        }
    }
    else
    {
        Console.WriteLine("Invalid selection. Try again.");
    }
}



}
