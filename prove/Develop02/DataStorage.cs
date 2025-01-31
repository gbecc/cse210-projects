using System;
using System.Collections.Generic;
using System.IO;

class DataStorage
{
    private List<string> prompts; //New lists for prompts and responses.
    private List<string> responses;

    public DataStorage() //constructor
    {
        prompts = new List<string>();
        responses = new List<string>();
    }

    public void AddEntry(string prompt, string response)
    {
        prompts.Add(prompt); //initialize the lists
        responses.Add(response);
    }
    public void DisplayEntries()
    {
        if (prompts.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        for (int i = 0; i < prompts.Count; i++)
        {
            Console.WriteLine($"Prompt {i + 1}: {prompts[i]}");//i+1 to iterate through list entries.
            Console.WriteLine($"Response {i + 1}: {responses[i]}");
            Console.WriteLine();
        }
    }
    
    public void SaveEntries()
    {
        Console.Write("Enter the filename to save (such as fulename.txt, remember to include .txt): ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            for (int i = 0; i < prompts.Count; i++)
            {
                writer.WriteLine(prompts[i]);   
                writer.WriteLine(responses[i]); 
                writer.WriteLine("----------");        // Separates to make file readable.
            }
        }
        Console.WriteLine($"Entries have been saved successfully to {fileName}.\n");
    }

    public void LoadEntries()
    {
        Console.Write("Enter the filename to load (such as filename.txt, remember to include .txt): ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found. Please check the filename and try again.\n");
            return;
        }

        prompts.Clear();   // Clear current entries before loading
        responses.Clear();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string prompt = line; // Read prompt
                string response = reader.ReadLine(); // Read response
                reader.ReadLine(); // Read separator line (----------), ignore it

                prompts.Add(prompt);
                responses.Add(response);
            }
        }
        Console.WriteLine($"Entries have been loaded successfully from {fileName}.\n");
    }
}
