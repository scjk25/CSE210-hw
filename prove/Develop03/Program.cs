using System;

class Program
{
    static void Main(string[] args)
    {
        // Referance referance = new Referance("John", "3:16", "For God so loved the world");
        // referance.DisplayReferance();

        // Scripture scripture = referance.GetScripture();
        // scripture.HideAllWords();

        // Console.WriteLine("Guess the hidden part of the scripture:");
        // string guess = Console.ReadLine();

        // if (referance.GuessScripture(guess))
        // {
        //     Console.WriteLine("Congratulations! Your guess is correct.");
        // }
        // else
        // {
        //     Console.WriteLine("Sorry, your guess is incorrect.");
        // }

        

        Console.WriteLine("Type the enter key or type quit");
        string start = Console.ReadLine();

        if (start == "enter")
        {   
            Scripture scripture = new Scripture();
            scripture.Referance();
            scripture.Text();
            scripture.Verse();
        }

        else if (start == "quit")
        {
            Console.WriteLine("Goodbye");
        }
    }
}