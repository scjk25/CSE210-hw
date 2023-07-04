public class Breathing : Activity
{
    private string breath_in;
    private string breath_out;

    public Breathing(string activity_name, string start_message, string description, int _time, string ending_message) :
    base(activity_name, start_message, description, _time, ending_message)
    {
        
    }

    public void DoActivity(string inhale, string exhale)

    {
        breath_in = inhale;
        breath_out = exhale;

        Console.WriteLine("\nStart in\n");
          for (int i = 5; i > 0; i--)
        {   
            Console.WriteLine(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine($"\n{inhale}\n");
        for(int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
        Console.WriteLine($"\n{exhale}\n");

        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
      
        Console.WriteLine("Well done you are now done with the breathing activity");
    }
}