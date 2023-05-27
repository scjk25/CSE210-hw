using System;

public class Referance
{
    private string _book;
    private string _chaptersVerses;
    private Scripture _scripture;

    public Referance(string book, string chaptersVerses, string verse)
    {
        _book = book;
        _chaptersVerses = chaptersVerses;
        _scripture = new Scripture(verse);
    }

    public void DisplayReferance()
    {
        Console.WriteLine($"{_book} {_chaptersVerses}");
        _scripture.DisplayScripture();
    }

    public Scripture GetScripture()
    {
        return _scripture;
    }

    public bool GuessScripture(string guess)
    {
        return string.Equals(guess, _scripture.Verse, StringComparison.OrdinalIgnoreCase);
    }
}




