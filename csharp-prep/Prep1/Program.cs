using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is your first name? ");
        string first = Console.ReadLine();

        Console.WriteLine("Waht is your last name? ");
        string last = Console.ReadLine();
        
        Console.WriteLine($"Your name is {last}, {first}, {last}");
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("What is your grade? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";
        
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
       {
            letter = "C";
       } 
       else if (percent >= 60)
       {
            letter = "D";
       }
       else 
       {
            letter = "F";
       }
       Console.WriteLine ($"Your grade is {letter}");
       if (percent >= 70)
       {
        Console.WriteLine ("You passed the class");

       }
        else {
            Console.WriteLine("You have failed the class");
        }
    }
}