using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of each event type
        Address address1 = new Address("123 Main St", "Rexburg", "Idaho", "83144");
        Lecture lecture = new Lecture("How to use C# in your career", "This lecture is about learning the basic principals of programing with C#. This lecture is supposed to open up carrer oppertunites for programing skills\n", DateTime.Now, TimeSpan.FromHours(1), address1, "John Doe", 100);

        Address address2 = new Address("456 Elm St", "Rexburg", "Idaho", "83144");
        Reception reception = new Reception("Programing with classes in C#", "This is a reception that covers the topics of progaming with classes in c#. At this event there is going to be interactive avtities with that will help you understand the privipals of abastraction, encapsulation, inheritance, and polymorphisism. Food will be provied at this reception.\n", DateTime.Now, TimeSpan.FromHours(2), address2, "rsvp@example.com");

        Address address3 = new Address("789 Oak St", "Rexburg", "Idaho", "83144");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Take a break from programing", "Come enjoy this fun and filled event with water games, carnival rides, and raffels to have a chance to win amazing prizes\n", DateTime.Now, TimeSpan.FromHours(3), address3, "Sunny");

        // Generate marketing messages for each event
        Console.WriteLine("\nStandard Details:\n");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:\n");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:\n");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}