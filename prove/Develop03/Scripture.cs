using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Scripture
{
    private string activeScripture;
    private List<string> words;
    private Random random;

    public Scripture(string text)
    {
        activeScripture = text;
        words = Regex.Split(text, @"(\s+)").ToList(); // Preserves spaces, splits words into array
        random = new Random();
    }

    public string GetActiveScripture()
    {
        return string.Join("", words);
    }

    public void SetActiveScripture(string newText)
    {
        activeScripture = newText;
        words = Regex.Split(newText, @"(\s+)").ToList();
    }

    public void WordSubstitution()
    {
        var wordIndexes = words
            .Select((word, index) => new { Word = word, Index = index })
            .Where(w => w.Word.All(char.IsLetter))
            .Select(w => w.Index)
            .ToList();

        if (wordIndexes.Count == 0) return;

        int indexToHide = wordIndexes[random.Next(wordIndexes.Count)];
        words[indexToHide] = new string('_', words[indexToHide].Length);
    }

    public bool AllWordsHidden()
    {
        return words.All(word => !word.Any(char.IsLetter));
    }
}
