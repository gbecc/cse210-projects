using System;

class Program
{
     static void Main()
    {
        DisplayWelcome();

        string userName = PromptUserName();

        int favoriteNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(squaredNumber, userName);
    }
        static void DisplayWelcome()
    {
        Console.WriteLine("Welcome To the Program!");
    }

    static string PromptUserName()
    {
        Console.Write($"Please enter a username:");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write($"What is your favorite number?");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }

    static void DisplayResult(int squared, string userName)
    {
        Console.WriteLine($"Hello {userName}, your number squared is {squared}!");
    }
}