public class Menue 
{   


    public Menue()
    {
        Activity activity = new Activity("","","");
    }

    public void displayActivites()
    {   
        int _choice = 0;

        while(_choice != 4)
        {   
            Console.WriteLine("\nWelcome to the midfulness program");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");

            Console.Write("Choose an option to begin a program ");
            _choice = int.Parse(Console.ReadLine());
            System.Console.Clear();

        // do the breathing activity
        if (_choice == 1)
        {
            Breathing breathing = new Breathing("","","");
            breathing.displayInstructions();
            System.Console.Clear();
            breathing.countDown();
    
        }

        // do the reflection activity
        else if (_choice == 2)
        {
            Reflection reflection = new Reflection("","","");
            reflection.displayInstructions();
            System.Console.Clear();
            reflection.displayPrompt();
            reflection.displayQuestion();
        }
        
        else if (_choice == 3)
        {
            Listing listing = new Listing("", "", "","");
            listing.displayInstructions();
            System.Console.Clear();
            listing.displayListPrompt();
            listing.GetResponse();
        }

        else if (_choice == 4)
        {
            Console.WriteLine("Thanks for doing the program Hope to see you again");
        }    

        }

    }
}