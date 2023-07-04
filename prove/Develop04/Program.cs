

class Program
{
    static void Main(string[] args)
    {
        //Breathing breathing = new Breathing("Breathing", "Wlecome to the program", "This is the breathing instructions", 0, "Well done you completed the program");
       
        //breathing.DisplayMessage();
        //breathing.Displaytime();

        Menue menue = new Menue("","Welcome to the mindfulness program", "", 0, "");
        menue.DisplayMenue();
        menue.Selecttion();

    }
}