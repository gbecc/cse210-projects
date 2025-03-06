using System;
using System.Collections.Generic;
using System.Threading;

class ReflectionActivity : MindfulnessProgram
{
    private static int _reflectionCount = 0;
    private List<string> reflectionPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> reflectionQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(int duration) 
        : base(duration, "Reflect on times when you have shown strength and resilience.")
    {
    }

    public void GetReflectionPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(reflectionPrompts.Count); // Generates a random integer between 0 and the max count from the prompts.
        Console.WriteLine($"\nConsider the following prompt:\n- {reflectionPrompts[index]}\n");//chooses prompt based off of previous number.
        Console.WriteLine("When you have something in mind, press Enter to continue...");
        Console.ReadLine();
    }

    public void ShowReflectionQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(reflectionQuestions.Count); // Generates a random integer between 0 and the max count from the questions.
        Console.WriteLine($"\nReflect on this question:\n- {reflectionQuestions[index]}"); //chooses question based off of previous number.
        Spinner();
    }

    public void Start()
    {
        Console.Clear();
        _reflectionCount++;
        Console.WriteLine($"\nYou have completed this activity {_reflectionCount} times this session, including this time.");
        StartActivity("Reflection Activity");
        
        GetReflectionPrompt();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            ShowReflectionQuestion();

            // If the list is empty, gives it a new list with questions. This helps also in case all the questions have been gone through, by giving a new list.
            if (reflectionQuestions.Count == 0)
            {
                reflectionQuestions = new List<string>
                {
                    "Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not as successful?",
                    "What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?"
                };
            }
        }

        EndActivity("Reflection Activity");
    }
}
