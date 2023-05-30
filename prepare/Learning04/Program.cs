using System;

class Program
{
    static void Main(string[] args)
    {
      
      Assignments assignment = new Assignments("John Smith", "Multiplication");
      Console.WriteLine(assignment.GetSummary());

      Math math = new Math("James Jones", "Fractions", "7.3", "8-9");
      Console.WriteLine(math.GetSummary());
      Console.WriteLine(math.GetHomeworkList());

      Writting writting = new Writting("Mary waters", "American History", "The civil war");
      Console.WriteLine(writting.GetSummary());
      Console.WriteLine(writting.GetWrittingInfo());
    }
}