public class Word
{
    private List<string> _word;
    private string _verse;

    public Word()
    {
        _word = new List<string>
        {
            "For", "God", "so", "loved", "the", "world", "he","gave","his", "only","begotton", "that", "who", "so", "ever", "belivith", "in", "him", "shall", "have", "everlasting", "life"
        };
    }
    public string GetWord()
    {
       Random random = new Random();
       int index = random.Next(_word.Count);
       return _word[index];
    }

    public void SetVerse(string word)
    {
       _word.Add(word);
    }

    public string GetText()
    {
        return _verse;
    }

    public void SetText(string verse)
    {
        _verse = verse;
    }
}