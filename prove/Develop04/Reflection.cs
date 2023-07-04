public class Reflection
{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();



    public Reflection()
    {

    }
    public void DisplayPrompts()
    {
        _prompts.Add("What was the best thing that has happend to you?");
        _prompts.Add("What makes you excited about waking up everyday?");
        _prompts.Add("What was the most sucessful thing you have done?");
        _prompts.Add("Are you happy with where you are at in Life?");

        foreach(string prompt in _prompts)
        {   

            for (int i = 5; i > 0; i--)
            
            {   
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine(prompt);
        }
    }

    public void DisplayQuestion()
    {
        _questions.Add("Explain what made your best day ever");
        _questions.Add("Why does that excite you?");
        _questions.Add("Are you more happy with those acivments?");
        _questions.Add("What makes you happy?");

        foreach(string question in _questions)
        {
            Console.WriteLine(question);
        }
    }
}