using System;

class Program
{
    static void Main(string[] args)
    {
        List <Activity> activites = new List<Activity>();

        DateTime date1 = new DateTime(2023, 11, 3);
        Running running = new Running (date1, 30, 3.0);
        activites.Add(running);

        DateTime date2 = new DateTime(2023, 11, 3);
        Cycling cycling = new Cycling(date2, 30, 6.0);
        activites.Add(cycling);

        DateTime date3 = new DateTime(2023, 11, 3);
        Swimming swimming = new Swimming(date3, 30, 20);
        activites.Add(swimming);

        foreach (Activity activity in activites)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}