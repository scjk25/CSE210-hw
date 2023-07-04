
public class Activity
{
    private string name_of_activity;
    private string welcome_message;
    private string instructions;
    private int time;
    private string end_message;

    public Activity(string activity_name, string start_message, string description, int _time, string ending_message)
    {
        
        welcome_message = start_message;
        name_of_activity = activity_name;
        instructions = description;
        time = _time;
        end_message = ending_message;
    }

    public void DisplayMessage()
    {
        Console.WriteLine($"\nWelcome to the {name_of_activity} activity");

        Console.WriteLine($"{instructions}");

    }
    
    public void Displaytime()
    {
        Console.Write($"How long in seconds would you like the activity to last ");
        time = int.Parse(Console.ReadLine());
    }
    
}

   