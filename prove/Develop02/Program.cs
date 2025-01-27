using System;

class Program
{
    static void Main()
    {
        int choiceNumber = 6;

        while (choiceNumber != 5)
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1: Write in your journal.");
            Console.WriteLine("2: Display Entries.");
            Console.WriteLine("3: Save Entries.");
            Console.WriteLine("4: Load Entries.");
            Console.WriteLine("5: Quit.");
            Console.Write("What would you like to do? ");

            // Read user input and convert it to an integer
            if (int.TryParse(Console.ReadLine(), out choiceNumber))
            {
                switch (choiceNumber)
                {
                    case 1:
                        Console.WriteLine("Option 1 selected: Write in your journal.");
                        break;

                    case 2:
                        Console.WriteLine("Option 2 selected: Display entries.");
                        break;

                    case 3:
                        Console.WriteLine("Option 3 selected: Save entries.");
                        break;

                    case 4:
                        Console.WriteLine("Option 4 selected: Load entries.");
                        break;

                    case 5:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a number between 1 and 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
