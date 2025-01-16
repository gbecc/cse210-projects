using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
    while (guess != magicNumber)
    {
        Console.Write("What is the magic number? ");
        guess = int.Parse(Console.ReadLine());

        if (guess > magicNumber)
        {
            Console.Write("Lower! ");
        }
        else if (guess < magicNumber)
        {
            Console.Write("Higher! ");
        }
        else 
        {
            Console.Write("You guessed it! ");
        }
    }
    }
}