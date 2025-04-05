using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 04, 1), 30, 3.0),     // 3.0 miles in 30 mins, or 1 mile per 10 mins
            new Cycling(new DateTime(2025, 04, 2), 45, 12.0),    // 12 mph for 45 mins
            new Swimming(new DateTime(2025, 04, 3), 40, 30)      // 30 laps = 0.93 miles, but I round it to 0.9
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}
