using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        while (userNumber != 0);
        {
            Console.Write("Enter in a number type 0 when finished ");
            string Response = Console.ReadLine();
            userNumber = int.Parse(Response);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sume is {sum}");
    }
}