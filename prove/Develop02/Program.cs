using System;

class Program
{
    
    static void Main()
    {
        Prompts promptVar = new Prompts();
        DataStorage dataVar = new DataStorage();

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

            // Condition - if can be parsed, true and continue, else send error and repeat loop.
            if (int.TryParse(Console.ReadLine(), out choiceNumber))
            {
                switch (choiceNumber)
                {
                    case 1:
                        string randomPrompt = promptVar.GetRandomPrompt();
                        Console.WriteLine($"{randomPrompt}");
                        string userResponse = Console.ReadLine();
                        dataVar.AddEntry(randomPrompt, userResponse);
                        // Have to pull a random prompt, store the prompt and entry in DataStorage as active.
                        //Create list in DataStorage for Prompts.
                        //Create list in DataStorage for entries.
                        break;

                    case 2:
                        Console.WriteLine("Journal Entries:");
                        dataVar.DisplayEntries();
                        // Be able to display the journal entries.
                        break;

                    case 3:
                        Console.WriteLine("Option 3 selected: Save entries.");
                        dataVar.SaveEntries();
                        // Save the active entries to a file using DataStorage.
                        break;

                    case 4:
                        Console.WriteLine("Option 4 selected: Load entries.");
                        dataVar.LoadEntries();
                        // Load file's contents as the active entry using DataStorage.
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
