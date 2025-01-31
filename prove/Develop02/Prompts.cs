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
            "What do you like on your pizza?"
        };
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
}