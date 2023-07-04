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
            Breathing breathing = new Breathing("Welcome to the Breathing Activity!",
                "\nWell done you have completed the Breathing activity\n",
                "For this activity breath in and breath out when instruced to do so", 
                "", "");

            breathing.displayMessage();
            int input = breathing.displayInstructions();
            System.Console.Clear();
            breathing.countDown(input);
            breathing.DisplayEndmessage();
        }

        // do the reflection activity
        else if (_choice == 2)
        {
            Reflection reflection = new Reflection("Welcome to the Reflection activity",
            "\nWell Done you have completed the reflection activity\n",
            "For this activity ponder on the prompts and questions as they appear");
            reflection.displayMessage();
            reflection.displayInstructions();
            System.Console.Clear();
            reflection.displayPrompt();
            reflection.displayQuestion();
            reflection.DisplayEndmessage();
        }
        
        else if (_choice == 3)
        {
            Listing listing = new Listing("Welcome to the listing activity", 
            "\nWell done you have completed the Lisiting activity\n", 
            "For this activty you are given a propmt. While being timed start listing your answer to the question."
            );
            listing.displayMessage();
            listing.displayInstructions();
            System.Console.Clear();
            listing.displayListPrompt();
            listing.GetResponse();
            listing.DisplayEndmessage();
        }

        else if (_choice == 4)
        {
            Console.WriteLine("Thanks for doing the program Hope to see you again");
        }    

        }

    }
}