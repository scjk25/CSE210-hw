using System.Collections.Generic;
using System;

public class Activity
{
    private string _startMessage;
    private string _end_Message;
    private List<string> _activites = new List<string>();
    private string _instructions;

    public Activity(string startMessage, string endMessage, string instructions)
    {
        _startMessage = startMessage;
        _end_Message = endMessage;
        _instructions = instructions;
    }

    // show the starting message and ending message to each of the activites 
    public void displayMessage(string activity)
    {
        string startMessage = $"Welcome to the {activity} activity";
        Console.WriteLine(startMessage);
    }
    
}