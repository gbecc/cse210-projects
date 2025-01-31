using System;
using System.Runtime.CompilerServices;

class Prompts
{
    private string[] prompts;

    public Prompts()
    {
        prompts = new String[]
        {
            "Describe your perfect day.",
            "What do you like on your pizza?",
            "What was the most frustrating part of your day?",
            "Who did you help today?"
        };
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
}