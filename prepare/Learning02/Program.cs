using System;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
    
        job1._jobTitle = "Custodian";
        job1._company = "Madison High School";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Walmart";
        job2._startYear = 2018;
        job2._endYear = 2020;

        
        Resume myresume = new Resume();
        myresume._name = "Scott Kishpaugh";
        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);


        myresume.Display();
    }

    
}
