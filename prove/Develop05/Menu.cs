
public class Menu
{
    // private List<string> _options = new List<string>();

    private List<Goal> _goals = new List<Goal>();
    private int _points = 0;
    private int _totalPoints = 0;
   
    public void StartMessage()
    {   
        Console.WriteLine($"\nYou have {_totalPoints} points");
        Console.WriteLine("Welcome to the goal program below are options to the program");
    }


    public void MenuChoice()
    {        
        int choice = 0;
    
        while(choice != 6)
        {   
            Console.WriteLine("\n1. Create goals");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. quit");

            Console.Write("Which of these options would you like to choose? ");
            choice = int.Parse(Console.ReadLine());
            System.Console.Clear();

            if (choice == 1)
            {   
                Console.WriteLine("Welcome to the create goal menu. Below is a list of goals to create");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Check List");
                string input = "Please select which type of goal you would like to create ";

                Console.WriteLine(input);
                int choices = int.Parse(Console.ReadLine());
                System.Console.Clear();

                if (choices == 1)
                {
                    Simple simple = new Simple();
                    simple.CreateGoal();
                    _goals.Add(simple);
                    
                }

                else if (choices == 2)
                {
                    Eternal eternal = new Eternal();
                    eternal.CreateGoal();
                    _goals.Add(eternal);
                }

                else if (choices == 3)
                {
                    CheckList checkList = new CheckList();
                    checkList.CreateGoal();
                    _goals.Add(checkList);
                }

            }

            else if (choice == 2)
            {
                foreach (Goal goal in _goals) 
                {
                    goal.ListGoal();
                }
                
            }
            
            else if (choice == 3)
            {
                string filePath = "My file.txt";
                Save.SaveFile(filePath, $"{_goals}");
            }

            else if (choice == 4)
            {
                string filePath = "My file.txt";
                string loadedText = Load.LoadFile(filePath);
                Console.WriteLine(loadedText);
            }

            else if (choice == 5)
            {

                Console.WriteLine("Here is a list of your goals: ");
                
                for (int i = 0; i < _goals.Count; i ++)
                {
                   Goal goal = _goals[i];
                   goal.RecordGoal(i + 1);

                }

                Console.WriteLine("Which goal have you completed? ");
                int completed = int.Parse(Console.ReadLine());

                if (completed == 1)
                {   
                    _totalPoints += _points;
                    Console.WriteLine($"You now have {_totalPoints} points");
                }
                
                
            }
            
            else if (choice == 6)
            {
                Console.WriteLine("Thanks for doing the program come back soon.");
            }
        }

    }        
} 