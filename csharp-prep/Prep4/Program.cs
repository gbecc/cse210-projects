using System;

class Program
{
    static void Main(string[] args)
    {
    int number = -1; 
    List<int> numbers = new List<int>();
    while (number != 0)
    {
        if (number != 0)
        {
        Console.Write("Please enter a number: ");
        number = int.Parse(Console.ReadLine());
        numbers.Add(number);
        }
    }
        int sum = numbers.Sum();
        double average = numbers.Average();
        int largest = numbers.Max();
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Largest Number: {largest}");
    }
}