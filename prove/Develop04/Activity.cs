<<<<<<< HEAD

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

   
=======
using System.Collections.Generic;
using System;

public class Activity
{
    protected string _startMessage;
    protected string _endMessage;
    protected string _instructions;
    protected List<string> _activites = new List<string>();

    public Activity(string startMessage, string endMessage, string instructions)
    {
        _startMessage = startMessage;
        _endMessage = endMessage;
        _instructions = instructions;
        
    }

    // show the starting message and ending message to each of the activites 

    
    public void displayMessage()
    {
        Console.WriteLine(_startMessage);
    }

    public void DisplayEndmessage()
    {
        Console.WriteLine(_endMessage);
    }

}
>>>>>>> bfbb845825e2a6b73ed3118be33fbc934f733e1d
