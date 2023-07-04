using System.Collections.Generic;

public class Listing : Activity
{
    private List<string> _promptQuestions = new List<string>();

    public Listing(string startMessage, string endMessage, string instructions) : 
    base(startMessage, endMessage, instructions)
    {
       
    }

    public int displayInstructions()
    {
        Console.WriteLine(_instructions);
        Console.WriteLine("How long in seconds wpuld you like to run the program? ");
        int input = Int32.Parse(Console.ReadLine());
        return input;

    
    }
    

    public void displayListPrompt()
    {   // add the prompt questions to the list 
        _promptQuestions.Add("Who are people that you apperciate?");
        _promptQuestions.Add("What are personal streghths of yours?");
        _promptQuestions.Add("Who are people that you have helped this week?");
        _promptQuestions.Add("When have you felt the Holy Ghost this month?");
        _promptQuestions.Add("Who are some of your personal heros");

        // get a random prompt.
        Random random = new Random();
        int randomNum = random.Next(0,4);
        Console.WriteLine(_promptQuestions[randomNum]);
    }

    public void GetResponse()
    {   
        // get the current time that is stored in the computer and then 
        // add 30 seconds to end the time.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(30);

        List<string> _response = new List<string>();

        // loop thru the time so the program stops in 30 seconds
        while (DateTime.Now < endTime)
        {
            string userResponse = Console.ReadLine();
            _response.Add(userResponse);
        }

        int responseCount = _response.Count;
        Console.WriteLine("\nTotal responses: " + responseCount);
    }
    
}
