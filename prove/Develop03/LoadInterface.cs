using System;
using System.IO;

class LoadInterface
{
    private string filePath = "scriptures.txt"; // Loads from this specific file in the folder of the program.

    public string LoadScripture()
    {
        if (File.Exists(filePath))
        {
            string[] scriptures = File.ReadAllLines(filePath);
            if (scriptures.Length > 0)
                return scriptures[new Random().Next(scriptures.Length)];
        }

        return "Trust in the Lord with all your heart and lean not on your own understanding"; // Default scripture
    }
}
