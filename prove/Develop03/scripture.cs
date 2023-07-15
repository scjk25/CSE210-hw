public class Scripture
{

    public void Referance()
    {
        Referance referance = new Referance();
        referance.SetBook("John");
        referance.SetChapter(3);
        referance.SetVerse(16);

        Console.WriteLine($"{referance.GetBook()}:{referance.GetChapter()}-{referance.GetVerse()}");
    }


    public void Verse()
    {   
        
        Word word = new Word();
        Console.WriteLine($"{word.GetWord()}");
    }

    public void Text()
    {
        Word word = new Word();
        word.SetText("For God so loved the world he gave his only begotton son that who so ever beliveth in him shall have everlasting life");
        Console.WriteLine($"{word.GetText()}");
    }
}