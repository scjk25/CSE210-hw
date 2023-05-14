using System;
using System.Collections.Generic;

namespace Develop02{
    class Program
    {
    static void Main(string[] args)
    {

        string displayMenu = Prompt.displayMenu();

        string propmt1 = Prompt.prompt1();
        Entry Entry1 = new Entry();
        Entry1.Hold($"What was the best part of your day?", $"{propmt1}",  "May 12 2023");

        string propmpt2 = Prompt.propmt2();
        Entry Entry2 = new Entry();
        Entry2.Hold($"Who was the most intresting person you interacted with today? ", $"{propmpt2}","May 12 2023");

        string propmpt3 = Prompt.propmt3();
        Entry Entry3 = new Entry();
        Entry3.Hold($"How did I see the hand of the lord today? ", $"{propmpt3}", "May 12 2023");

        string propmpt4 = Prompt.propmt4();
        Entry Entry4 = new Entry();
        Entry4.Hold($"What was the strongest emotion felt today? ", $"{propmpt4}", "May 12 2023");

        string propmpt5 = Prompt.prompt5();
        Entry Entry5 = new Entry();
        Entry5.Hold($"If i had one thing I would like to change about today what would it be?", $"{propmpt5}", "May 12 2023");



        Journal journal = new Journal();
        journal.AddEntry(Entry1);
        journal.AddEntry(Entry1);
        journal.AddEntry(Entry2);
        journal.AddEntry(Entry3);
        journal.AddEntry(Entry4);
        journal.AddEntry(Entry5);


        List<Entry> entries = journal.GetAllEntries();

        foreach(Entry entry in entries)
        {
            string message = entry.ConvertToString();
            Console.WriteLine(message);
        }  
        
    }
    }}