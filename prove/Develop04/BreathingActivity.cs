using System;

class BreathingActivity : MindfulnessProgram
{
    private static int _breathingCount = 0;
    public BreathingActivity(int duration) 
        : base(duration, "This activity works based off of your breathing, to help you relax. Breathe in when instructed, and breathe out when instructed as well.")
    {
    }

    public void BreatheCountdown()
    {
        int cycles = _duration / 10;
        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breathe in... ");
            for (int j = 4; j > 0; j--)
            {
                Console.Write($"{j}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.Write("Breathe out... ");
            for (int j = 6; j > 0; j--)
            {
                Console.Write($"{j}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }
    }

    public void Start()
    {
        Console.Clear();
        _breathingCount++;
        Console.WriteLine($"\nYou have completed this activity {_breathingCount} times this session, including this time.");
        StartActivity("Breathing Activity");
        BreatheCountdown();
        EndActivity("Breathing Activity");
    }
}
