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