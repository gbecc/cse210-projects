using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            MindfulnessProgram program = new MindfulnessProgram(0, "");
            string choice = program.DisplayMessage();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity(program.DurationInput());
                breathing.Start();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity(program.DurationInput());
                reflection.Start();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity(program.DurationInput());
                listing.Start();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
        }
    }
}
