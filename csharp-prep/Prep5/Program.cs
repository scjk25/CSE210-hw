using System;

class Program
{
    static void Main(string[] args)

    {
        DisplayWelcome();

        string username = UserName();
        int usernumber = UserNumber();

        int SquaredNumber = SquareNumber(usernumber);
        ReturnResults(username, SquaredNumber);

        static void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the program");
        }

        string UserName()
        {
            Console.Write("Please enter your name: ");

            string username = Console.ReadLine();

            return username;
        }

        int UserNumber()
        {
            Console.Write("What is your favorite Number: ");

            int usernumber = int.Parse(Console.ReadLine());

            return usernumber;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;

            return square;
        }

        static void ReturnResults(string name, int square)
        {
            Console.WriteLine($"{name}, The square of your number is {square}");
        }
    }
    
}