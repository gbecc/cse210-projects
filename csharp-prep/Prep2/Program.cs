using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string grade = Console.ReadLine();
        int grade1 = int.Parse(grade);

        string letter = "";
        if (grade1 >= 90)
        {
            letter = "A";
        }
        else if (grade1 >= 80)
        {
            letter = "B";
        }
        else if (grade1 >= 70)
        {
            letter = "C";
        }
        else if (grade1 >= 60)
        {
            letter = "D";
        }
        else if (grade1 >= 50)
        {
            letter = "F";
        }
        Console.WriteLine($"You got a {letter}");

        if (grade1 >= 70)
        {
        Console.WriteLine($"You passed!");
        }
        else if (grade1 < 70)
        {
        Console.WriteLine($"You failed!");
        }
    }
}