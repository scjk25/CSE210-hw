
public class ChecklistGoal:Goal
{

    private int completedCount;
    private int targetCount;
    private int bounusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bounusPoints) : base(name, points)
    {
        this.completedCount = 0;
        this.targetCount = targetCount;
        this.bounusPoints = bounusPoints;
        this.name = name;
    }

    public override bool IsComplete()
    {
        return completedCount >= targetCount;
    }

    public override void MarkComplete()
    {
        completedCount ++;
    }

    public override string GetProgress()
    {
        return $"Completed {completedCount}/{targetCount} times";
    }

    public int GetBonusPoints()
    {
        if (IsComplete())
        return bounusPoints;
        else
        return 0;
    }
    
}