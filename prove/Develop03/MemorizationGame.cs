using System;

class MemorizationGame
{
    private Scripture scripture;
    private UserInterface ui;
    private LoadInterface loader;

    public MemorizationGame()
    {
        ui = new UserInterface();
        loader = new LoadInterface();

        // load up the scripture and its reference
        var (loadedScripture, book, chapter, verse) = loader.LoadScripture();
        var reference = new ScriptureReference(book, chapter, verse);
        scripture = new Scripture(loadedScripture, reference);
    }

    public void Start()
    {
        ui.DisplayMessage("Would you like to enter a new scripture? (yes/no)");
        string choice = ui.GetUserInput().ToLower();

        if (choice == "yes")
        {
            AddNewScripture();
        }

        ui.DisplayMessage("Memorize the Scripture:");
        DisplayScripture();

        ui.DisplayMessage("\nPress Enter to hide words or type 'quit' to exit.");

        while (!scripture.AllWordsHidden())
        {
            string input = ui.GetUserInput();
            if (input.ToLower() == "quit") break;

            scripture.WordSubstitution();
            ui.ClearScreen();
            ui.DisplayMessage("Memorize the Scripture:");
            DisplayScripture();
            ui.DisplayMessage("\nPress Enter to continue hiding words or type 'quit' to exit.");
        }

        ui.DisplayMessage("\nAll words are hidden. Type 'quit' to exit.");
        while (ui.GetUserInput().ToLower() != "quit") { }
    }

    private void AddNewScripture()
    {
        // gets the scripture text from the user
        ui.DisplayMessage("Enter the new scripture:");
        string newScripture = ui.GetUserInput();

        // gets the book name
        ui.DisplayMessage("Enter the book name:");
        string book = ui.GetUserInput();

        int chapter = GetPositiveNumber("Enter the chapter number:");
        int verse = GetPositiveNumber("Enter the verse number:");

        var newReference = new ScriptureReference(book, chapter, verse);

        // save scripture and reference
        loader.SaveScripture(newScripture, newReference);
        scripture = new Scripture(newScripture, newReference);
        ui.DisplayMessage("New scripture and reference saved and set as active!");
    }

    // need to make sure that the numbers for chapter and verse are positive.
    private int GetPositiveNumber(string prompt)
    {
        int number;
        do
        {
            ui.DisplayMessage(prompt);
            string input = ui.GetUserInput();
            if (int.TryParse(input, out number) && number > 0)
            {
                return number;
            }
            ui.DisplayMessage("Invalid input. Please enter a positive number.");
        } while (true);
    }

    private void DisplayScripture()
    {
        ui.DisplayMessage(scripture.GetActiveScripture());
    }
}
