using System;
using System.ComponentModel;
using System.Runtime;
using System.Web;

class Program
{
    static void Main(string[] args)
    {   
    //Console.WriteLine("For example");
    //     for (int i = 5; i > 0; i--)
    //     {
    //         Console.Write(i);
    //         Thread.Sleep(1000);
    //         Console.Write("\b \b");
    //     }
        Console.WriteLine("Spinner Example:");
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
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}