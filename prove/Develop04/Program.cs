using System;

class Program
{
    static void Main(string[] args)
    {
        Breathing breathing = new Breathing("","","");
        Activity activity = new Activity("","","");
        Listing List = new Listing("","","","");
        Menue menue = new Menue();
        menue.displayActivites();
        

        // breathing.displayMessage("Breathing");
        // breathing.displayInstructions();

        // Reflection reflection = new Reflection();
        // reflection.displayPrompt();
    }
}