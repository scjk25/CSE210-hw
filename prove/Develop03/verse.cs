using System;

public class Word
{
    private string _word;

    public string Text { get { return _word; } }

    public Word(string word)
    {
        _word = word;
    }

    public void HideWord()
    {
        int amount = _word.Length;
        _word = new string('_', amount);
    }

    public void DisplayWord()
    {
        Console.WriteLine(_word);
    }
}






