public class Breathing : Activity
{   
    private string _inhale;
    private string _exhale;


    public Breathing(string startMessage, string endMessage, string instructions,
    string inhale, string exhale): 
    base(startMessage, endMessage, instructions)
    {
        _inhale = inhale;
        _exhale = exhale;
    }

      public int displayInstructions()
    {
        Console.WriteLine(_instructions);
        Console.WriteLine("How long in seconds wpuld you like to run the program? ");
        int input = Int32.Parse(Console.ReadLine());
        return input;
    }
    // show the the message breath in 
    public void displayInhale()
    {   
        Console.WriteLine($"Breath in");
        timeInBetween();
    }

    // show the message breath out 
    public void displayExhale()
    {   
        
        Console.WriteLine($"Breath out");
        timeInBetween();
    }

    // have a count down between breaths
    public void countDown(int input)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(input);

        while(startTime <= endTime)
        {
            displayInhale();
            displayExhale();
            startTime = DateTime.Now;
        }
        // Console.WriteLine("Well Done you have completed the activity\n");
    }

    public void timeInBetween()
    {
         
        for(int i = 5; i >0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
    

}