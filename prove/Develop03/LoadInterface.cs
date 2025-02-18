using System;
using System.IO;

class LoadInterface
{
    private string filePath = "scriptures.txt";

    // load scripture & reference
    public (string scripture, string book, int chapter, int verse) LoadScripture()
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                // picks a random scripture line
                string line = lines[new Random().Next(lines.Length)];
                string[] parts = line.Split('|'); //this splits it into different parts
                //which then are discerned and applied to the right variables below.
                if (parts.Length == 4)
                {
                    string book = parts[0];
                    int chapter = int.Parse(parts[1]);
                    int verse = int.Parse(parts[2]);
                    string scripture = parts[3];
                    return (scripture, book, chapter, verse);
                }
            }
        }

        // If file is empty, default scripture will b e returned
        return ("Trust in the Lord with all your heart and lean not on your own understanding.", "Proverbs", 3, 5);
    }

    // saves the scripture with its reference
    public void SaveScripture(string scripture, ScriptureReference reference)
    {
        string line = $"{reference.GetBook()}|{reference.GetChapter()}|{reference.GetVerse()}|{scripture}";
        try
        {
            File.AppendAllText(filePath, line + Environment.NewLine);
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Failed to save scripture: {ex.Message}");
        }
    }
}
