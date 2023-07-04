using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
class Program
{

       private static List<Goal> goals = new List<Goal>();
       private static int score = 0;

       public static void Main(string[] args)
       {
            LoadGoalsAndScore();

            while (true)
            {
                Console.WriteLine("1. Create a new goal");
                Console.WriteLine("2. Record an event");
                Console.WriteLine("3. Show list of goals");
                Console.WriteLine("4. Show score");
                Console.WriteLine("5. Save goals and score");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice: ");
                string choice = Console.ReadLine();

                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                    CreateGoal();
                    break;

                    case "2":
                    RecordEvent();
                    break;

                    case "3":
                    ShowGoals();
                    break;

                    case "4":
                    ShowScore();
                    break;

                    case "5":
                    SaveGoalsAndScore();
                    break;

                    case "6":
                    SaveGoalsAndScore();
                    return;

                    default:
                    Console.WriteLine("Invalid choice. Please try again. ");
                    break;
                }

                Console.WriteLine();

            }
       }

       public static void CreateGoal()

       {    System.Console.Clear();

            Console.WriteLine("Select a goal type");
            Console.WriteLine("1. Simple goal");
            Console.WriteLine("2. Eternal goal");
            Console.WriteLine("3. CheckList goal");
            Console.WriteLine("Enter your a goal you would like to create: ");
            string choice = Console.ReadLine();

            Console.Write("\nEnter a goal to create: ");
            string name = Console.ReadLine();

            Console.Write("Enter the amount of points the goal is worth: ");
            int points = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case "1":
                goals.Add(new Simple(name, points));
                Console.WriteLine("Simple goal has been created");
                break;

                case "2":
                goals.Add(new Eternal(name, points));
                Console.WriteLine("Eternal goal has been created");
                break;

                case "3":
                Console.Write("Enter target count: ");
                int targetCount = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter bounus points: ");
                int bounusPoints = Convert.ToInt32(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, points, targetCount, bounusPoints));
                Console.WriteLine("Checklist goal has been completed");
                break;

                default: 
                Console.WriteLine("invalid choice. Goal creation canceled.");
                break;
            }
            System.Console.Clear();
       }

       public static void RecordEvent()
       {
            Console.WriteLine("Select a goal to record an event: ");
            ShowGoals();
            Console.Write("Enter the goal number if the goal is completed: ");
            int goalNumber = Convert.ToInt32(Console.ReadLine()) -1;

            if (goalNumber >= 0 && goalNumber < goals.Count)
            {
                Goal goal = goals[goalNumber];
                goal.MarkComplete();
                int eventPoints = goal.points + (goal is ChecklistGoal ? ((ChecklistGoal) goal).GetBonusPoints() : 0);
                score += eventPoints;
                Console.WriteLine($"Event has been recorded: You have gained {eventPoints} points.");
            }

            else
            {
                Console.WriteLine("Invalid goal number. Event recording has been canceled.");

            }
       }

       public static void ShowGoals()
       {
            if (goals.Count == 0)
            {
                Console.WriteLine("No goals found");
            }

            else
            {
                Console.WriteLine("List of Goals");
                for(int i = 0; i < goals.Count; i ++)
                {
                    Goal goal = goals[i];
                    string progress = goal.GetProgress();
                    string completionStatus = goal.IsComplete() ? "[X]" : "[ ]";
                    Console.WriteLine($"{i + 1}. {completionStatus} {goal.name} - {progress}");
                }
            }

       }

       public static void ShowScore()
       {
            Console.WriteLine($"Your score: {score} points");
       }

       public static void SaveGoalsAndScore()
       {
            try
            {
                string goalsJson = JsonSerializer.Serialize(goals);
                File.WriteAllText("goals.json", goalsJson);

                string scoreJson = JsonSerializer.Serialize(score);
                File.WriteAllText("score.json", goalsJson);

                Console.WriteLine("Goals and score saved successfully.");
            }

            catch (Exception e)
            {
                Console.WriteLine("Error occured while saving goals and score: " + e.Message);
            }
       }
       private static void LoadGoalsAndScore()
        {
            try 
            {
                if (File.Exists("goals.json"))
                {
                    string goalsJson = File.ReadAllText("goals.json");
                    goals = JsonSerializer.Deserialize<List<Goal>>(goalsJson);
                }

                if (File.Exists("score.json"))
                {
                   string scoreJson = File.ReadAllText("score.json");
                   score = JsonSerializer.Deserialize<int>(scoreJson);
                }

                Console.WriteLine("Goals and score loaded sucessfully.");
            }

            catch (Exception e)
            {
                Console.WriteLine("Error occured while loading goals and score: " + e.Message);
            }   
        }
}
        