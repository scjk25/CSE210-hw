using System.IO;
using System;

namespace Develop02{

    public class Prompt{



        public static string displayMenu()
         {
            string entry = "";
            bool done = false;
            
            while (!done)
            {
                Console.WriteLine("What would you like to write about today?");
                Console.WriteLine("1. Add A new Line to your Journal");
                Console.WriteLine("2. Save and exit");
                

                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.Write($"What was the best part of your day? ");
                    entry += Console.ReadLine() + "\n";

                    Console.Write($"Who was the most intresting person you interacted with today? ");
                    entry += Console.ReadLine() + "\n";

                    Console.Write($"How did I see the hand of the lord today? ");
                    entry += Console.ReadLine() + "\n";
                    
                    Console.Write($"What was the strongest emotion that was felt today? ");
                    entry += Console.ReadLine() + "\n";

                    Console.Write($"If i had one thing to do over today what would it be? ");
                    entry += Console.ReadLine() + "\n";

                }
                else if (input == "2")
                {
                    done = true;
                    break;

                }
                else
                {
                    Console.WriteLine("Invalid input please enter a valid option. ");
                }          
            }

            return entry.TrimEnd();
         }

        public static string prompt1()
        {   
         Console.Write("What was the best part of your day?");
            return Console.ReadLine();
        }
    
        public static string propmt2()
        {
            Console.Write("Who was the most intresting person you interacted with? ");

            return Console.ReadLine();
        }
         public static string propmt3()
         {
            Console.Write("How did I see the hand of the lord today? ");

            return Console.ReadLine();
         }

         public static string propmt4()
         {
            Console.Write("What was the strongest emotion felt today? ");

            return Console.ReadLine();
         }

         public static string prompt5()
         {
            Console.Write("If i had one thing I would like to change about today what would it be? ");

            return Console.ReadLine();
         }


         

        }    }
