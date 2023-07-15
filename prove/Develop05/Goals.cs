
public class Goal
{
    private List<string> _goals = new List<string>();
    // private List<string> _getgoals = new List<string>();

    protected string _goal;
    protected string _description;
    protected int _points;
    protected int _totalPoints = 0;

    public Goal()
    {
        // _goal = goal;
    }

   

    public virtual void CreateGoal()
    {   
        
        Console.WriteLine("What goal would you like to focus on today? ");
        _goal = Console.ReadLine();
        Console.WriteLine( "how are you going to acomplish that goal? ");
        _description = Console.ReadLine();
        Console.WriteLine("How many points is this goal? ");
        _points = int.Parse(Console.ReadLine());
    
    }

    public virtual void ListGoal()
    {
        Console.WriteLine($"[ ] {_goal} ({_description})");
    }

    public virtual void RecordGoal(int index)
    {  
        
        Console.WriteLine($"{index}. {_goal}");

       
       
    }

    public virtual void GetPoints()
    {   
                 
        _totalPoints += _points;

        
        
    }
}