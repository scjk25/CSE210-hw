<<<<<<< HEAD
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
=======
using System.Collections.Generic;

public class Reflection : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public Reflection(string startMessage, string endMessage, string instructions): 
    base(startMessage, endMessage, instructions)
    {

    }

      // display instructions for each activity
    public int displayInstructions()
    {
        Console.WriteLine(_instructions);
        Console.WriteLine("How long would you like the program to run? ");
        int input = Int32.Parse(Console.ReadLine());
        return input;
    }
    
    // display prompts 
    public void displayPrompt()
    {   
        _prompts.Add("\nThink of a time when you stood up for someone else.\n");
        _prompts.Add("Think of a time when you did something really difficult.\n");
        _prompts.Add("Think of a time when you helped someone in need.\n");
        _prompts.Add("Think of a time when you have done something truly selfless.\n");

        Random rand= new Random();
        int randNum = rand.Next(0,3);
        Console.WriteLine(_prompts[randNum]);
        displayAnimation();

    }
    // display question for the user to reflect on. 
    public void displayQuestion()
    {
        _questions.Add("Why was this experiance menigful to you?\n");
        _questions.Add("Have You done anything like this before?\n");
        _questions.Add("What is your faviorite thing bout this experiance?\n");
        _questions.Add("What did you learn from yourself from this experinace?\n");
        _questions.Add("How can you keep this experinaces for times in the future?\n");

        // loop thru each of the questions with a 5 second pause
        foreach(string question in _questions)
        {
            Console.WriteLine(question);
            displayAnimation();
        }
    }

    public void displayAnimation()
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        foreach(string s in animation)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }   

    public void countDown()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(30);

        while(startTime <= endTime)
        {
            displayPrompt();
            displayQuestion();
            startTime = DateTime.Now;
>>>>>>> bfbb845825e2a6b73ed3118be33fbc934f733e1d
        }
    }
}