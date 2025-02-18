using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Scripture
{
    private string activeScripture;
    private List<string> words;
    private Random random;
    private ScriptureReference reference;

    public Scripture(string text, ScriptureReference refInfo)
    {
        activeScripture = text;
        reference = refInfo;
        words = Regex.Split(text, @"(\s+)").ToList();
        random = new Random();
    }

    public string GetActiveScripture()
    {
        return $"{reference.GetFormattedReference()}: {string.Join("", words)}";
    }

    public void SetActiveScripture(string newText)
    {
        activeScripture = newText;
        words = Regex.Split(newText, @"(\s+)").ToList();
    }

    public void WordSubstitution()
    {
        var validIndexes = new List<int>();
        for (int i = 0; i < words.Count; i++)
        {
            // only hide words containing letters and not already hidden
            if (words[i].All(char.IsLetter) && words[i] != new string('_', words[i].Length))
            {
                validIndexes.Add(i);
            }
        }

        // hide a random word
        if (validIndexes.Count > 0)
        {
            int indexToHide = validIndexes[random.Next(validIndexes.Count)];
            words[indexToHide] = new string('_', words[indexToHide].Length);
        }
    }

    public bool AllWordsHidden()
    {
        // check if all words are hidden
        return words.All(word => !word.Any(char.IsLetter));
    }
}
