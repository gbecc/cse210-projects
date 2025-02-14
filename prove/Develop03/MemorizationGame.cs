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

        // Load scripture from file, or set a default scripture if none exists
        string loadedScripture = loader.LoadScripture();
        scripture = new Scripture(loadedScripture);
    }

    public void Start()
    {
        ui.DisplayMessage("Memorize the Scripture:"); //ui is responsible for writeline and readline
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

    private void DisplayScripture()
    {
        ui.DisplayMessage(scripture.GetActiveScripture());
    }
}
