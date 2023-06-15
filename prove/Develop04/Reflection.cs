using System.Collections.Generic;

public class Reflection : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public Reflection(string startMessage, string endMessage, string instructions): base(startMessage, endMessage, instructions)
    {

    }

      // display instructions for each activity
    public void displayInstructions()
    {
        string instructions = "For this activity ponder on the prompts and questions as they appear";
        Console.WriteLine(instructions);
        string begin = "When ready type start";
        Console.WriteLine(begin);
        begin = Console.ReadLine();
         if (begin != "start")
            {
                Console.WriteLine("Please type start");
            }
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
        }
    }
}