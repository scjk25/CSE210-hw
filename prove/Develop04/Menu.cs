using System.Collections.Generic;
using System;
public class Menue : Activity
{
    List<string> activites = new List<string>();

    string message;

    // Menue constructor that set the name of the activity
    // starting message
    // description of the activity
    // the amount of time 
    // the ending message 
    // the begging message 
    // the response 
    public Menue(string activity_name, string start_message, string description, int _time, string ending_message):
    base(activity_name, start_message, description, _time, ending_message) 
    {
       message = start_message;
    }

    public void DisplayMenue()
    {   
        Console.WriteLine(message);

        // adding the activites to the list.
        activites.Add("1. Breathing");
        activites.Add("2. Reflection");
        activites.Add("3. Listing");

        // Looping thru the list so that it displays. 
        foreach(string activity in activites)
        {
            Console.WriteLine(activity);
        }
        

    }
    public void Selecttion()
    {   
        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("Choose an activity to beign");
            choice = int.Parse(Console.ReadLine());
            
            
            if (choice == 1)
            {
                Breathing breathing = new Breathing("breathing", "", "The purpose of this program is to help control your breath Inhale and Exhale when instructed to do so", 0, "Well done you completed the program");
       
                breathing.DisplayMessage();
                breathing.Displaytime();
                breathing.DoActivity("Inhale", "Exhale");
            }
            else if (choice == 2)
            {
                Reflection reflection = new Reflection();

                reflection.DisplayPrompts();
            }
        
        }

        
    }

}