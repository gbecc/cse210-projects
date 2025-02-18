using System;

public class ScriptureReference
{
    private string _book;
    private int _chapter;
    private int _verse;
    public ScriptureReference(string book, int chapter, int verse)
    {
        SetBook(book);
        SetChapter(chapter);
        SetVerse(verse);
    }
    public string GetBook() => _book;
    public int GetChapter() => _chapter;
    public int GetVerse() => _verse;

    public string GetFormattedReference()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
    private void SetBook(string book)
    {
        if (string.IsNullOrWhiteSpace(book))
        {
            throw new ArgumentException("Book name cannot be empty.");
        }
        _book = book;
    }

    private void SetChapter(int chapter)
    {
        if (chapter <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(chapter), "Chapter number must be positive.");
        }
        _chapter = chapter;
    }

    private void SetVerse(int verse)
    {
        if (verse <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(verse), "Verse number must be positive.");
        }
        _verse = verse;
    }
}
