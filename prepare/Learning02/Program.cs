using System;
class Program
{
    static void Main(string[] args)
    {
        Jobs job1 = new Jobs();
        job1._jobTitle = "Custodian";
        job1._company = "Madison High School";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Console.WriteLine($"{job1._jobTitle}"); 
        Console.WriteLine($"{job1._company}"); 
        Console.WriteLine($"{job1._startYear}");
        Console.WriteLine($"{job1._endYear}");

    }

    
}
