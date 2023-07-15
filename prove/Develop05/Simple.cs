
public class Simple: Goal
{
    // private string _goal;

    public override void CreateGoal()
    {
        Console.WriteLine("What simple goal would you like to focus on today? ");
        _goal = Console.ReadLine();
        Console.WriteLine("What are some ways you are going to do to acomlish that goal? ");
        _description = Console.ReadLine();
        Console.WriteLine("How many points is this goal? ");
        _points = int.Parse(Console.ReadLine());
    }


}