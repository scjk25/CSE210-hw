using System;

public class Scripture
{
    private string _verse;
    private Word[] _words;

    public string Verse { get { return _verse; } }
    public Word[] Words { get { return _words; } }

    public Scripture(string verse)
    {
        _verse = verse;
        string[] words = verse.Split(' ');
        _words = new Word[words.Length];
        for (int i = 0; i < words.Length; i++)
        {
            _words[i] = new Word(words[i]);
        }
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_verse);
    }

    public void HideAllWords()
    {
        foreach (Word word in _words)
        {
            word.HideWord();
        }
    }

    public void DisplayAllWords()
    {
        foreach (Word word in _words)
        {
            word.DisplayWord();
        }
    }
}