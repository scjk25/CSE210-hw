public class CheckList: Goal
{
    private int _ammount_of_times;
    private int _bounus;
    // private int _points;
    // private string _description;

    public override void CreateGoal()
    {
        Console.WriteLine("What goal would you like to focus on today? ");
        _goal = Console.ReadLine();
        Console.WriteLine("What are you going to do to complete this goal? ");
        _description = Console.ReadLine();
        Console.WriteLine("How many points is this goal? ");
        _points = int.Parse(Console.ReadLine());
        Console.WriteLine("How many times do yoiu need to complete the goal? ");
        _ammount_of_times = int.Parse(Console.ReadLine());
        Console.WriteLine("After completing the goal how many bous pooints would you like to add? ");
        _bounus = int.Parse(Console.ReadLine());

    }

    public override void ListGoal()
    {
        Console.WriteLine($"[ ] {_goal} ({_description}) {_ammount_of_times}");
    }

    public override void RecordGoal(int index)
    {
         Console.WriteLine($"{index}. {_goal} {_ammount_of_times}");
    }

    

}   
