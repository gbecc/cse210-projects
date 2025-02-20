using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment ("John", "Mathmatics");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathassignment1 = new MathAssignment("1", "1,2,3,4,5", "John", "Math");
        Console.WriteLine(mathassignment1.GetSummary());
        Console.WriteLine(mathassignment1.GetHomeworkList());

        WritingAssignment writingassignment1 = new WritingAssignment("John", "Writing", "Shakespeare");
        Console.WriteLine (writingassignment1.GetSummary());
        Console.WriteLine (writingassignment1.GetWritingInformation());
    }
}