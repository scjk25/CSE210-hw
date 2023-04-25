using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your final grade? ");
        string studentResponse = Console.ReadLine();
        int grade = int.Parse(studentResponse);

        string letter = "";

        if (grade >90)
        {
           letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your final grade is {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("You have passed the class");
        }
        else
        {
            Console.WriteLine("You have failed the class");
        }
    }  
}