public class Breathing : Activity
{


    public Breathing(string startMessage, string endMessage, string instructions): 
    base(startMessage, endMessage, instructions)
    {
        
    }

      public void displayInstructions()
    {
        string instructions = "For this activity breath in and breath out when instruced to do so";
        Console.WriteLine(instructions);
        string begin = "When ready type start";
        Console.WriteLine(begin);
        begin = Console.ReadLine();
         if (begin != "start")
            {
                Console.WriteLine("Please type start");
            }
    }
    // show the the message breath in 
    public void displayInhale()
    {   
        Console.WriteLine("\nBreath in\n");
        timeInBetween();
    }

    // show the message breath out 
    public void displayExhale()
    {   
        
        Console.WriteLine("\nBreath out\n");
        timeInBetween();
    }

    // have a count down between breaths
    public void countDown()
    {   
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(30);

        while(startTime <= endTime)
        {
            displayInhale();
            displayExhale();
            startTime = DateTime.Now;
        }
        Console.WriteLine("Well Done you have completed the activity\n");
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