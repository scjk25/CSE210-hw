public class Eternal:Goal
{

    private int completionCount;

    public Eternal(string name, int points) : base(name, points)
    {
        completionCount = 0;
    }

    public override bool IsComplete()
    {
        return false;
    }
    
    public override void MarkComplete()
    {
        completionCount ++;
    }

    public override string GetProgress()
    {
       return "In Progress";
    }
        
}
